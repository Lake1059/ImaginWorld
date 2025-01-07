Imports System.Net

Public Class 消息响应

    Public Shared Property 消息字典 As New Dictionary(Of String, Action(Of List(Of String), IPEndPoint))

    Public Shared Sub 初始化()
        消息字典.Add("iw_sever_ping", AddressOf 作为客户端_收到服务器的心跳包)
        消息字典.Add("iw_client_receiveping", AddressOf 作为服务器_收到客户端的心跳响应)
        消息字典.Add("iw_client_login_beta3", AddressOf 作为服务器_收到客户端的连接请求)
        消息字典.Add("iw_sever_message", AddressOf 作为客户端_收到服务器的弹出式消息)
        消息字典.Add("iw_gotplayerlist", AddressOf 作为客户端_收到服务器的多人模式空位列表)
        DebugPrint($"服务器和客户端的消息响应初始化完成，共计 {消息字典.Count } 个消息处理方法", Color.CornflowerBlue)
    End Sub

    Public Shared Sub 执行消息(消息 As List(Of String), 发送者地址 As IPEndPoint)
        Dim 消息名称 As String = 消息(0)
        Dim value As Action(Of List(Of String), IPEndPoint) = Nothing
        If 消息字典.TryGetValue(消息名称, value) Then
            value(消息, 发送者地址)
        Else
            DebugPrint("未知指令：" & 消息名称, Color.Tomato)
        End If
    End Sub

    Public Shared Sub 作为客户端_收到服务器的心跳包(消息 As List(Of String), 发送者地址 As IPEndPoint)
        服务器.发送消息(发送者地址, New List(Of String) From {"iw_client_receiveping"})
    End Sub

    Public Shared Sub 作为服务器_收到客户端的心跳响应(消息 As List(Of String), 发送者地址 As IPEndPoint)
        Dim value As 服务器.玩家信息单片结构 = Nothing
        If 服务器.客户端列表.TryGetValue(发送者地址, value) Then
            value.心跳包接收时间 = Now
        End If
    End Sub

    Public Shared Sub 作为服务器_收到客户端的连接请求(消息 As List(Of String), 发送者地址 As IPEndPoint)
        服务器.发送消息(发送者地址, New List(Of String) From {"iw_sever_message", "客户端连接测试成功，此时服务器应该向客户端发送多人空位信息表"})
    End Sub

    Public Shared Sub 作为客户端_收到服务器的弹出式消息(消息 As List(Of String), 发送者地址 As IPEndPoint)
        Dim a1 As New 多项单选对话框($"来自 {发送者地址} 的弹出式消息", {"OK"}, 消息.Last)
        a1.ShowDialog(Form1)
    End Sub

    Public Shared Sub 作为客户端_收到服务器的多人模式空位列表(消息 As List(Of String), 发送者地址 As IPEndPoint)
        客户端.是否收到响应 = True

    End Sub

End Class
