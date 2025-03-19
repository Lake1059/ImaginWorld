
Public Class 客户端的消息响应
    Public Shared Property 消息字典 As New Dictionary(Of String, Action(Of List(Of String)))

    Public Shared Sub 初始化()
        消息字典.Add("iw_sever_ping", AddressOf 收到心跳Ping)
        消息字典.Add("iw_sever_message", AddressOf 收到弹出式消息)
        消息字典.Add("iw_sever_playerlist", AddressOf 收到多人模式空位列表)
        消息字典.Add("iw_sever_powerdown", AddressOf 收到服务器已停止运行)
        消息字典.Add("iw_sever_remove", AddressOf 收到服务器移出此设备)
        消息字典.Add("iw_sever_ban", AddressOf 收到服务器封禁此设备)

        DebugPrint($"客户端消息响应初始化完成，共计 {消息字典.Count } 个消息处理方法", Color.CornflowerBlue)
    End Sub

    Public Shared Sub 执行消息(消息 As List(Of String))
        Dim 消息名称 As String = 消息(0)
        Dim value As Action(Of List(Of String)) = Nothing
        If 消息字典.TryGetValue(消息名称, value) Then
            value(消息)
        Else
            DebugPrint("未知指令：" & 消息名称, Color.Tomato)
        End If
    End Sub

    Public Shared Sub 收到心跳Ping(消息 As List(Of String))
        客户端.发送消息(New List(Of String) From {"iw_client_receiveping"})
    End Sub

    Public Shared Sub 收到弹出式消息(消息 As List(Of String))
        UI同步上下文.Post(Sub()
                         Dim a1 As New 多项单选对话框($"收到弹出式消息", {"OK"}, 消息.Last)
                         a1.ShowDialog(Form1)
                     End Sub, Nothing)
    End Sub

    Public Shared Sub 收到多人模式空位列表(消息 As List(Of String))
        客户端.是否收到响应 = True
        UI同步上下文.Post(Sub()
                         界面控制.切换界面(界面控制.主界面图层.二层, New 界面二层_多人模式角色列表)
                     End Sub, Nothing)
    End Sub

    Public Shared Sub 收到服务器已停止运行(消息 As List(Of String))
        客户端.停止客户端()
        UI同步上下文.Post(Sub()
                         Dim a1 As New 多项单选对话框($"自动断开连接", {"OK"}, "服务器已停止运行")
                         a1.ShowDialog(Form1)
                         Form1.释放所有资源回主菜单()
                     End Sub, Nothing)
    End Sub

    Public Shared Sub 收到服务器移出此设备(消息 As List(Of String))
        客户端.停止客户端()
        UI同步上下文.Post(Sub()
                         Dim a1 As New 多项单选对话框($"主动断开连接", {"OK"}, "你已被服务器移出")
                         a1.ShowDialog(Form1)
                         Form1.释放所有资源回主菜单()
                     End Sub, Nothing)
    End Sub

    Public Shared Sub 收到服务器封禁此设备(消息 As List(Of String))
        客户端.停止客户端()
        UI同步上下文.Post(Sub()
                         Dim a1 As New 多项单选对话框($"强制断开连接", {"OK"}, "你已被服务器封禁")
                         a1.ShowDialog(Form1)
                         Form1.释放所有资源回主菜单()
                     End Sub, Nothing)
    End Sub

End Class
