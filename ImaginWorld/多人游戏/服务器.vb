Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class 服务器
    Public Shared Property UDP广播 As UdpClient
    Public Shared Property UDP服务器 As UdpClient
    Public Shared Property 广播任务 As Task
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
    Public Shared Property 自动踢出延迟 As Integer = -1
    Public Shared Property 自动开始广播 As Boolean = False
    Public Shared Property 保留的客户端列表 As New List(Of IPEndPoint)
    Public Shared Property 黑名单 As New List(Of IPEndPoint)
    Public Shared Property 开放单人数据位 As Boolean = False

    Class 玩家信息单片结构
        Public Property IP As IPEndPoint
        Public Property 权限 As 玩家权限类型
        Public Property 延迟 As Integer
        Public Property 心跳包发送时间 As Date
        Public Property 心跳包接收时间 As Date
        Public Property 连续超时次数 As Integer
        Public Property 玩家对象名称 As String
    End Class

    Enum 玩家权限类型
        普通玩家禁用控制台 = 0
        管理员执行大多数指令 = 1
        超级管理员全部指令 = 2
    End Enum

    Public Shared Sub 启动服务器()
        Try
            UDP广播 = New UdpClient()
            取消令牌源 = New CancellationTokenSource()
            广播任务 = Task.Run(AddressOf 广播服务器游戏信息, 取消令牌源.Token)
            UDP服务器 = New UdpClient(服务器端口)

            For i As Integer = 1 To 响应线程数量
                Dim 响应任务 As Task = Task.Run(AddressOf 监听消息, 取消令牌源.Token)
                响应任务列表.Add(响应任务)
            Next

            Ping任务 = Task.Run(AddressOf 向所有客户端发送心跳包, 取消令牌源.Token)
            是否正在运行 = True
            DebugPrint($"服务器已经启动，地址：{获取本地IPv4()}:{服务器端口}", Color.Yellow)
            Form服务器.Show()
        Catch ex As Exception
            停止服务器()
            DebugPrint(ex.Message, Color.OrangeRed,, True)
        End Try
    End Sub

    Public Shared Sub 广播服务器游戏信息()
        Dim endPoint = New IPEndPoint(IPAddress.Broadcast, 1059)
        Dim ip = 获取本地IPv4()
        Dim message As Byte()
        UDP广播.EnableBroadcast = True
        While 是否正在运行 AndAlso Not 取消令牌源.Token.IsCancellationRequested
            message = Encoding.UTF8.GetBytes($"ImaginWorldSever|{ip}|{服务器端口}|{服务器名称}|{服务器描述}|{服务器可用状态}")
            UDP广播.Send(message, message.Length, endPoint)
            Thread.Sleep(1000)
        End While
    End Sub

    Public Shared Sub 监听消息()
        While 是否正在运行 AndAlso Not 取消令牌源.Token.IsCancellationRequested
            Try
                Dim 发送者地址 As New IPEndPoint(IPAddress.Any, 服务器端口)
                Dim 数据_接收到的字节 As Byte() = UDP服务器.Receive(发送者地址)
                If 数据_接收到的字节.LongLength = 0 Then Continue While
                SyncLock 黑名单
                    If 黑名单.Contains(发送者地址) Then
                        发送消息(发送者地址, New List(Of String) From {"iw_message", "你已被此服务器封禁"})
                        DebugPrint($"已拒绝黑名单 {发送者地址} 的请求", Color.Yellow)
                        Continue While
                    End If
                End SyncLock
                Dim 数据_文本 = Encoding.UTF8.GetString(数据_接收到的字节)
                Dim 数据_消息列表 As List(Of String) = 数据_文本.Split("<iw_separator>", StringSplitOptions.None).ToList()
                If 数据_消息列表.Count = 0 Then Continue While
                SyncLock 客户端列表
                    If 是否允许新地址加入 Then
                        If Not 客户端列表.ContainsKey(发送者地址) Then
                            If 数据_消息列表(0) = "iw_sever_connect" Then
                                客户端列表(发送者地址) = New 玩家信息单片结构 With {.IP = 发送者地址, .权限 = 玩家默认权限}
                            Else
                                Continue While
                            End If
                        End If
                    Else
                        If Not 保留的客户端列表.Contains(发送者地址) Then
                            发送消息(发送者地址, New List(Of String) From {"iw_message", "此服务器已禁止新玩家加入，而您不在设备列表中，所以无法加入此服务器"})
                            DebugPrint($"已拒绝 {发送者地址} 的请求", Color.Yellow)
                            Continue While
                        Else
                            If 数据_消息列表(0) = "iw_sever_connect" Then
                                客户端列表(发送者地址) = New 玩家信息单片结构 With {.IP = 发送者地址, .权限 = 玩家默认权限}
                            End If
                        End If
                    End If
                End SyncLock
                消息响应.执行消息(数据_消息列表, 发送者地址)
            Catch ex As Exception
                DebugPrint(ex.Message, Color.Tomato)
            End Try
        End While
    End Sub

    Public Shared Sub 发送消息(IP As IPEndPoint, message As List(Of String))
        Try
            Dim combinedMessage As String = String.Join("<iw_separator>", message)
            Dim data = Encoding.UTF8.GetBytes(combinedMessage)
            UDP服务器.Send(data, data.Length, IP)
        Catch ex As Exception
            DebugPrint(ex.Message, Color.Tomato)
        End Try
    End Sub

    Shared ReadOnly 心跳包数据 As Byte() = Encoding.UTF8.GetBytes(String.Join("<iw_separator>", {"iw_sever_ping", ""}))

    Public Shared Sub 向所有客户端发送心跳包()
        While 是否正在运行 AndAlso Not 取消令牌源.Token.IsCancellationRequested
            Dim ClientList As New List(Of IPEndPoint)(客户端列表.Keys)
            For i = 0 To ClientList.Count - 1
                Try
                    客户端列表(ClientList(i)).心跳包发送时间 = Now
                    UDP服务器.Send(心跳包数据, 心跳包数据.Length, 客户端列表(ClientList(i)).IP)
                Catch ex As Exception
                    DebugPrint(ex.Message, Color.Tomato)
                End Try
            Next
            计算所有客户端的延迟()
            Thread.Sleep(5000)
        End While
    End Sub

    Public Shared Sub 计算所有客户端的延迟()
        For Each 客户端信息 In 客户端列表
            Dim 延迟 As Integer = 客户端信息.Value.心跳包接收时间.Subtract(客户端信息.Value.心跳包发送时间).Milliseconds
            客户端信息.Value.延迟 = 延迟
            If 自动踢出延迟 > 100 Then
                If 延迟 > 自动踢出延迟 Then
                    客户端信息.Value.连续超时次数 += 1
                    If 客户端信息.Value.连续超时次数 > 10 Then
                        DebugPrint($"玩家 {客户端信息.Key} 由于延迟过高已被踢出", Color.Tomato)
                        客户端列表.Remove(客户端信息.Key)
                    End If
                Else
                    客户端信息.Value.连续超时次数 = 0
                End If
            End If
        Next
    End Sub

    Public Shared Sub 广播全体消息(message As String)
        Dim data = Encoding.UTF8.GetBytes(message)
        For Each clientKey In 客户端列表.Keys
            UDP服务器.Send(data, data.Length, clientKey)
        Next
    End Sub

    Public Shared Async Sub 停止服务器()
        是否正在运行 = False
        If 取消令牌源 IsNot Nothing Then
            取消令牌源.Cancel()
            Await Task.WhenAll(广播任务, Ping任务)
            Await Task.WhenAll(响应任务列表)
            If 取消令牌源 IsNot Nothing Then
                取消令牌源.Dispose()
                取消令牌源 = Nothing
            End If
        End If
        UDP广播.Close()
        UDP服务器.Close()
        客户端列表?.Clear()
        Form服务器.Close()
        GC.Collect()
        DebugPrint("服务器已被停止", Color.Tomato)
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
