Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.Text.Json
Imports Microsoft.VisualBasic.FileIO.FileSystem

Public Class 服务器
    Public Shared Property UDP广播 As UdpClient
    Public Shared Property UDP服务器 As UdpClient
    Public Shared Property 广播任务 As Task
    Public Shared Property 取消广播任务令牌源 As CancellationTokenSource
    Public Shared Property 响应任务列表 As New List(Of Task)
    Public Shared Property 响应线程数量 As Integer = 1
    Public Shared Property Ping任务 As Task
    Public Shared Property 取消令牌源 As CancellationTokenSource
    Public Shared Property 服务器端口 As Integer = 10590
    Public Shared Property 是否正在运行 As Boolean = False
    Public Shared Property 服务器名称 As String = "ImaginWorld Sever"
    Public Shared Property 服务器描述 As String = "Sever Description"
    Public Shared Property 服务器可用状态 As String = "无法连接，因为没做"
    Public Shared Property 客户端列表 As New Dictionary(Of IPEndPoint, 玩家信息单片结构)
    Public Shared Property 玩家默认权限 As 玩家权限类型 = 1
    Public Shared Property 是否允许新地址加入 As Boolean = False
    Public Shared Property 自动踢出延迟 As Integer = Integer.MaxValue
    Public Shared Property 自动开始广播 As Boolean = False
    Public Shared Property 保留的客户端列表 As New List(Of String)
    Public Shared Property 黑名单 As New List(Of String)
    Public Shared Property 开放单人数据位 As Boolean = False

    Public Shared Property 已发送字节 As Long = 0
    Public Shared Property 已接收字节 As Long = 0
    Public Shared Property 已发送个数 As Long = 0
    Public Shared Property 已接收个数 As Long = 0

    Class 玩家信息单片结构
        Public Property IP As IPEndPoint
        Public Property 权限 As 玩家权限类型
        Public Property 延迟 As Integer = 0
        Public Property 心跳包发送时间 As Date = Nothing
        Public Property 心跳包接收时间 As Date = Nothing
        Public Property 连续超时次数 As Integer = 0
        Public Property 玩家对象名称 As String = ""
        Public Property 玩家所在主场景 As String = "等待角色"
    End Class

    Enum 玩家权限类型
        普通玩家 = 0
        管理员 = 1
        超级管理员 = 2
    End Enum

    Public Shared Sub 启动服务器()
        Try
            是否正在运行 = True
            UDP广播 = New UdpClient()
            If 自动开始广播 Then
                取消广播任务令牌源 = New CancellationTokenSource()
                广播任务 = Task.Run(AddressOf 广播服务器游戏信息, 取消广播任务令牌源.Token)
            End If
            取消令牌源 = New CancellationTokenSource()
            UDP服务器 = New UdpClient(服务器端口)
            UDP服务器.Client.ReceiveTimeout = 10000
            For i As Integer = 1 To 响应线程数量
                Dim 响应任务 As Task = Task.Run(AddressOf 监听消息, 取消令牌源.Token)
                响应任务列表.Add(响应任务)
            Next
            Dim 黑名单文件 = Path.Combine(Application.StartupPath, "PlayerData", "SeverBan.json")
            If FileExists(黑名单文件) Then 黑名单 = JsonSerializer.Deserialize(Of List(Of String))(ReadAllText(黑名单文件))
            已发送字节 = 0
            已接收字节 = 0
            已发送个数 = 0
            已接收个数 = 0
            Ping任务 = Task.Run(AddressOf 计算所有客户端的延迟并发送下一次Ping, 取消令牌源.Token)
            DebugPrint($"[Sever] 服务器已在 {获取本地IPv4()}:{服务器端口} 上启动", Color.YellowGreen)
            Form服务器.Show()
        Catch ex As Exception
            DebugPrint(ex.Message, Color.Tomato,, True)
            停止服务器()
        End Try
    End Sub

    Public Shared Sub 广播服务器游戏信息()
        Dim endPoint = New IPEndPoint(IPAddress.Broadcast, 1059)
        Dim ip = 获取本地IPv4()
        Dim message As Byte()
        UDP广播.EnableBroadcast = True
        While 是否正在运行 AndAlso Not 取消广播任务令牌源.Token.IsCancellationRequested
            message = Encoding.UTF8.GetBytes($"ImaginWorldSever|{ip}|{服务器端口}|{服务器名称}|{服务器描述}|{服务器可用状态}")
            UDP广播.Send(message, message.Length, endPoint)
            已发送字节 += message.Length
            已发送个数 += 1
            Thread.Sleep(1000)
        End While
    End Sub

    Public Shared Sub 监听消息()
        While 是否正在运行 AndAlso Not 取消令牌源.Token.IsCancellationRequested
            Try
                Dim 发送者地址 As New IPEndPoint(IPAddress.Any, 服务器端口)
                Dim 数据_接收到的字节 As Byte() = UDP服务器.Receive(发送者地址)
                If 数据_接收到的字节.Length = 0 Then Continue While
                已接收字节 += 数据_接收到的字节.LongLength
                已接收个数 += 1
                If 验证是否被封禁(发送者地址) Then Continue While
                Dim 数据_文本 = Encoding.UTF8.GetString(数据_接收到的字节)
                Dim 数据_消息列表 As List(Of String) = 数据_文本.Split(通信指令.数据分隔符, StringSplitOptions.None).ToList()
                If 数据_消息列表.Count = 0 Then Continue While
                If 验证是否被限行(发送者地址, 数据_消息列表(0)) Then Continue While
                服务器的消息响应.执行消息(数据_消息列表, 发送者地址)
            Catch ex As TimeoutException
                DebugPrint($"[Sever] 接收消息超时，服务器的网络连接可能不稳定", Color.Yellow)
            Catch ex As SocketException When ex.SocketErrorCode = SocketError.TimedOut
            Catch ex As Exception
                DebugPrint(ex.Message, Color.Tomato)
            End Try
        End While
        界面线程执行(Sub() DebugPrint("[Sever] 服务器消息处理线程已停止运行", Color.Tomato))
    End Sub

    Public Shared Function 验证是否被封禁(发送者地址 As IPEndPoint) As Boolean
        SyncLock 黑名单
            If 黑名单.Contains(发送者地址.Address.ToString) Then
                发送消息(发送者地址, New List(Of String) From {通信指令.服务器发送模式对话框消息, "你已被此服务器封禁"})
                DebugPrint($"[Sever] 已拒绝黑名单 {发送者地址} 的请求", Color.YellowGreen)
                Return True
            Else
                Return False
            End If
        End SyncLock
    End Function

    Public Shared Function 验证是否被限行(发送者地址 As IPEndPoint, 客户端的通信指令 As String) As Boolean
        SyncLock 客户端列表
            If 是否允许新地址加入 Then
                If Not 客户端列表.ContainsKey(发送者地址) Then
                    If 客户端的通信指令 = 通信指令.客户端请求连接服务器 Then 客户端列表(发送者地址) = New 玩家信息单片结构 With {.IP = 发送者地址, .权限 = 玩家默认权限, .心跳包接收时间 = Now, .心跳包发送时间 = Now}
                End If
                Return False
            Else
                If Not 保留的客户端列表.Contains(发送者地址.Address.ToString) Then
                    发送消息(发送者地址, New List(Of String) From {通信指令.服务器发送模式对话框消息, "此服务器已禁止新玩家加入，而您不在设备列表中，所以无法加入此服务器"})
                    DebugPrint($"[Sever] 已拒绝 {发送者地址} 的请求", Color.YellowGreen)
                    Return True
                Else
                    If 客户端的通信指令 = 通信指令.客户端请求连接服务器 Then 客户端列表(发送者地址) = New 玩家信息单片结构 With {.IP = 发送者地址, .权限 = 玩家默认权限, .心跳包接收时间 = Now, .心跳包发送时间 = Now}
                    Return False
                End If
            End If
        End SyncLock
    End Function

    Public Shared Sub 发送消息(IP As IPEndPoint, message As List(Of String))
        Try
            Dim combinedMessage As String = String.Join(通信指令.数据分隔符, message)
            Dim data = Encoding.UTF8.GetBytes(combinedMessage)
            UDP服务器.Send(data, data.Length, IP)
            已发送字节 += data.Length
            已发送个数 += 1
        Catch ex As Exception
            DebugPrint(ex.Message, Color.Tomato)
        End Try
    End Sub
    Public Shared Sub 发送消息(IP As IPEndPoint, message As String())
        Try
            Dim combinedMessage As String = String.Join(通信指令.数据分隔符, message)
            Dim data = Encoding.UTF8.GetBytes(combinedMessage)
            UDP服务器.Send(data, data.Length, IP)
            已发送字节 += data.Length
            已发送个数 += 1
        Catch ex As Exception
            DebugPrint(ex.Message, Color.Tomato)
        End Try
    End Sub

    Shared ReadOnly 心跳包数据 As Byte() = Encoding.UTF8.GetBytes(String.Join(通信指令.数据分隔符, {通信指令.服务器发送Ping}))

    Public Shared Sub 计算所有客户端的延迟并发送下一次Ping()
        While 是否正在运行 AndAlso Not 取消令牌源.Token.IsCancellationRequested

            For Each 客户端信息 In 客户端列表
                Dim 延迟 As Integer = (客户端信息.Value.心跳包接收时间 - 客户端信息.Value.心跳包发送时间).Milliseconds

                If 延迟 < 0 Then
                    客户端信息.Value.延迟 = Integer.MaxValue
                Else
                    客户端信息.Value.延迟 = 延迟
                End If

                If 客户端信息.Value.延迟 >= 自动踢出延迟 Then
                    客户端信息.Value.连续超时次数 += 1
                    If 客户端信息.Value.连续超时次数 >= 10 Then
                        客户端列表.Remove(客户端信息.Key)
                        DebugPrint($"[Sever] 玩家 {客户端信息.Key.Address} {客户端信息.Key} 由于延迟过高已被自动踢出", Color.Tomato)
                    End If
                Else
                    客户端信息.Value.连续超时次数 = 0
                End If
            Next

            Dim ClientList As New List(Of IPEndPoint)(客户端列表.Keys)
            For i = 0 To ClientList.Count - 1
                Try
                    UDP服务器.Send(心跳包数据, 心跳包数据.Length, ClientList(i))
                    客户端列表(ClientList(i)).心跳包发送时间 = Now
                    已发送字节 += 心跳包数据.Length
                    已发送个数 += 1
                Catch ex As Exception
                    DebugPrint(ex.Message, Color.Tomato)
                End Try
            Next
            Thread.Sleep(3000)
        End While
    End Sub

    Public Shared Sub 广播全体消息(message As List(Of String))
        Dim combinedMessage As String = String.Join(通信指令.数据分隔符, message)
        Dim data = Encoding.UTF8.GetBytes(combinedMessage)
        For Each clientKey In 客户端列表.Keys
            UDP服务器.Send(data, data.Length, clientKey)
            已发送字节 += data.Length
            已发送个数 += 1
        Next
    End Sub

    Public Shared Async Sub 停止服务器()
        DebugPrint("[Sever] 已开始进行服务器停止流程，网络上的任务可能不会立即停止", Color.Gold)
        DebugPrint("[Sever] 请在再次启动服务器之前耐心等待其超时自动停止", Color.Gold)
        是否正在运行 = False
        Await Task.Run(Sub() 广播全体消息(New List(Of String) From {通信指令.服务器主动关机}))
        If 取消广播任务令牌源 IsNot Nothing Then
            取消广播任务令牌源.Cancel()
            Await 广播任务
            If 取消广播任务令牌源 IsNot Nothing Then
                取消广播任务令牌源.Dispose()
                取消广播任务令牌源 = Nothing
            End If
        End If
        UDP广播?.Close()
        UDP广播?.Dispose()
        UDP广播 = Nothing
        广播任务 = Nothing

        If 取消令牌源 IsNot Nothing Then
            取消令牌源.Cancel()
            Await Ping任务
            Await Task.WhenAll(响应任务列表)
            If 取消令牌源 IsNot Nothing Then
                取消令牌源.Dispose()
                取消令牌源 = Nothing
            End If
        End If
        UDP服务器?.Close()
        UDP服务器?.Dispose()
        UDP服务器 = Nothing
        Ping任务 = Nothing
        响应任务列表.Clear()
        客户端列表?.Clear()

        Form服务器.Close()

        Dim 黑名单文件 = Path.Combine(Application.StartupPath, "PlayerData", "SeverBan.json")
        WriteAllText(黑名单文件, JsonSerializer.Serialize(黑名单, JSON序列化选项), False)
        DebugPrint("[Sever] 服务器已停止", Color.Tomato)
        GC.Collect()
    End Sub

    Public Shared Function 获取本地IPv4() As String
        Dim host = Dns.GetHostEntry(Dns.GetHostName())
        For Each ip In host.AddressList
            If ip.AddressFamily = AddressFamily.InterNetwork Then
                Return ip.ToString()
            End If
        Next
        Return "unknow"
    End Function

    Public Shared Function 获取本地IPv6() As String
        Dim host = Dns.GetHostEntry(Dns.GetHostName())
        For Each ip In host.AddressList
            If ip.AddressFamily = AddressFamily.InterNetworkV6 Then
                Return ip.ToString()
            End If
        Next
        Return "unknow"
    End Function

End Class
