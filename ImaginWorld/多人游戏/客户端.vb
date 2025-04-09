Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports ImaginWorld.多人模式通信数据类

Public Class 客户端
    Public Shared Property UDP客户端 As UdpClient
    Public Shared Property 服务器地址 As IPEndPoint
    Public Shared Property 监听任务列表 As New List(Of Task)
    Public Shared Property 取消令牌源 As CancellationTokenSource
    Public Shared Property 是否正在运行 As Boolean = False
    Public Shared Property 是否收到响应 As Boolean = False
    Public Shared Property 响应线程数量 As Integer = 1
    Public Shared Property 接收到的玩家角色位信息表 As New 玩家角色位信息表

    Public Shared Sub 启动客户端(服务器IP As String, 服务器端口 As String)
        是否正在运行 = True
        是否收到响应 = False
        UDP客户端 = New UdpClient()
        服务器地址 = New IPEndPoint(IPAddress.Parse(服务器IP), 服务器端口)
        取消令牌源 = New CancellationTokenSource()
        UDP客户端.Client.ReceiveTimeout = 10000

        For i As Integer = 1 To 响应线程数量
            Dim 监听任务 As Task = Task.Run(AddressOf 监听消息, 取消令牌源.Token)
            监听任务列表.Add(监听任务)
        Next
    End Sub

    Public Shared Sub 监听消息()
        While 是否正在运行 AndAlso Not 取消令牌源.Token.IsCancellationRequested
            Try
                Dim 数据_接收到的字节 = UDP客户端.Receive(服务器地址)
                Dim 数据_文本 = Encoding.UTF8.GetString(数据_接收到的字节)
                Dim 数据_消息列表 As List(Of String) = 数据_文本.Split(通信指令.数据分隔符, StringSplitOptions.None).ToList()
                客户端的消息响应.执行消息(数据_消息列表)
            Catch ex As TimeoutException
                DebugPrint($"[Client] 接收消息超时，请关注网络波动", Color.Yellow)
            Catch ex As SocketException When ex.SocketErrorCode = SocketError.TimedOut
            Catch ex As Exception
                DebugPrint(ex.Message, Color.Tomato)
            End Try
        End While
        UI同步上下文.Post(Sub() DebugPrint("[Client] 客户端消息处理线程已停止运行", Color.Tomato), Nothing)
    End Sub

    Public Shared Sub 发送消息(message As List(Of String))
        Try
            Dim combinedMessage As String = String.Join(通信指令.数据分隔符, message)
            Dim data = Encoding.UTF8.GetBytes(combinedMessage)
            UDP客户端.Send(data, data.Length, 服务器地址)
        Catch ex As Exception
            DebugPrint(ex.Message, Color.Tomato)
        End Try
    End Sub

    Public Shared Async Sub 停止客户端()
        是否收到响应 = False
        是否正在运行 = False
        If 取消令牌源 IsNot Nothing Then
            取消令牌源.Cancel()
            Await Task.WhenAll(监听任务列表)
            If 取消令牌源 IsNot Nothing Then
                取消令牌源.Dispose()
                取消令牌源 = Nothing
            End If
        End If
        UDP客户端?.Close()
        UDP客户端 = Nothing
        监听任务列表.Clear()
    End Sub
End Class
