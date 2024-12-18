Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Public Class 客户端
    Public Shared Property UDP客户端 As UdpClient
    Public Shared Property 服务器地址端口 As IPEndPoint
    Public Shared Property 监听线程 As Thread
    Public Shared Property 是否正在运行 As Boolean = False

    Public Shared Sub 启动客户端(服务器IP As String, 服务器端口 As String)
        UDP客户端 = New UdpClient()
        服务器地址端口 = New IPEndPoint(IPAddress.Parse(服务器IP), 服务器端口)
        监听线程 = New Thread(AddressOf 监听消息)
        监听线程.Start()
        是否正在运行 = True
    End Sub

    Public Shared Sub 监听消息()
        While 是否正在运行
            Try
                Dim remoteEndPoint As New IPEndPoint(IPAddress.Any, 0)
                Dim data = UDP客户端.Receive(remoteEndPoint)
                Dim message = Encoding.UTF8.GetString(data)
            Catch ex As Exception
                Console.WriteLine("接收消息时出错: " & ex.Message)
            End Try
        End While
    End Sub

    Public Shared Sub 发送消息(message As String)
        Try
            Dim data = Encoding.UTF8.GetBytes(message)
            UDP客户端.Send(data, data.Length, 服务器地址端口)
        Catch ex As Exception
            Console.WriteLine("发送消息时出错: " & ex.Message)
        End Try
    End Sub

    Public Shared Sub 停止客户端()
        是否正在运行 = False
        UDP客户端.Close()
    End Sub
End Class
