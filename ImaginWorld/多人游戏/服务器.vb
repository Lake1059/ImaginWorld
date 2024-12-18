Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class 服务器
    Public Shared Property UDP广播 As UdpClient
    Public Shared Property UDP服务器 As UdpClient
    Public Shared Property 广播线程 As Thread
    Public Shared Property 响应线程 As Thread
    Public Shared Property 服务器端口 As Integer = 10590
    Public Shared Property 是否正在运行 As Boolean = False
    Public Shared Property 服务器名称 As String = "ImaginWorld Sever"
    Public Shared Property 服务器描述 As String = "Sever Description"
    Public Shared Property 服务器可用状态 As String = "无法连接，因为没做"
    Public Shared Property 客户端列表 As New Dictionary(Of String, IPEndPoint)
    Public Shared Property 服务器地址协议 As AddressFamily = AddressFamily.InterNetwork


    Public Shared Sub 启动服务器()
        UDP广播 = New UdpClient()
        广播线程 = New Thread(AddressOf 广播服务器游戏信息)
        广播线程.Start()
        UDP服务器 = New UdpClient(服务器端口)
        响应线程 = New Thread(AddressOf 监听消息)
        响应线程.Start()
        是否正在运行 = True
        DebugPrint($"服务器已经启动，地址：{If(服务器地址协议 = AddressFamily.InterNetwork, 获取本地IPv4(), 获取本地IPv6())}:{服务器端口}", Color.Yellow)
    End Sub

    Public Shared Sub 广播服务器游戏信息()
        Dim endPoint = New IPEndPoint(IPAddress.Broadcast, 1059)
        Dim message = Encoding.UTF8.GetBytes($"ImaginWorldSever|{If(服务器地址协议 = AddressFamily.InterNetwork, 获取本地IPv4(), 获取本地IPv6())}|{服务器端口}|{服务器名称}|{服务器描述}|{服务器可用状态}")
        UDP广播.EnableBroadcast = True
        While 是否正在运行
            UDP广播.Send(message, message.Length, endPoint)
            Thread.Sleep(1000)
        End While
    End Sub

    Public Shared Sub 监听消息()
        While 是否正在运行
            Try
                Dim remoteEndPoint As New IPEndPoint(IPAddress.Any, 0)
                Dim data = UDP服务器.Receive(remoteEndPoint)
                Dim message = Encoding.UTF8.GetString(data)
                MsgBox($"收到来自 {remoteEndPoint} 的消息: {message}")
                Dim clientKey = remoteEndPoint.ToString()
                If Not 客户端列表.ContainsKey(clientKey) Then
                    客户端列表(clientKey) = remoteEndPoint
                End If
            Catch ex As Exception
                DebugPrint(ex.Message, Color.OrangeRed)
            End Try
        End While
    End Sub

    Public Shared Sub 发送消息(clientKey As String, message As String)
        Dim remoteEndPoint As IPEndPoint = Nothing
        If 客户端列表.TryGetValue(clientKey, remoteEndPoint) Then
            Dim data = Encoding.UTF8.GetBytes(message)
            UDP服务器.Send(data, data.Length, remoteEndPoint)
        End If
    End Sub

    Public Shared Sub 广播全体消息(message As String)
        Dim data = Encoding.UTF8.GetBytes(message)
        For Each clientKey In 客户端列表.Keys
            Dim remoteEndPoint = 客户端列表(clientKey)
            UDP服务器.Send(data, data.Length, remoteEndPoint)
        Next
    End Sub

    Public Shared Sub 停止服务器()
        是否正在运行 = False
        UDP服务器.Close()
        客户端列表.Clear()
        GC.Collect()
    End Sub

    Private Shared Function 获取本地IPv4() As String
        Dim host = Dns.GetHostEntry(Dns.GetHostName())
        For Each ip In host.AddressList
            If ip.AddressFamily = AddressFamily.InterNetwork Then
                Return ip.ToString()
            End If
        Next
        Return "unknow"
    End Function

    Private Shared Function 获取本地IPv6() As String
        Dim host = Dns.GetHostEntry(Dns.GetHostName())
        For Each ip In host.AddressList
            If ip.AddressFamily = AddressFamily.InterNetworkV6 Then
                Return ip.ToString()
            End If
        Next
        Return "unknow"
    End Function

End Class
