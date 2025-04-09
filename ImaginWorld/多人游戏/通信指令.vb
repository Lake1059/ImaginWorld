Public Class 通信指令

    Public Shared ReadOnly 数据分隔符 As String = "<iw_separator>"
    Public Shared ReadOnly 服务器发送Ping As String = "iw_sever_ping"
    Public Shared ReadOnly 服务器发送模式对话框消息 As String = "iw_sever_message"
    Public Shared ReadOnly 服务器主动关机 As String = "iw_sever_powerdown"
    Public Shared ReadOnly 服务器发送玩家位信息 As String = "iw_sever_playerlist"
    Public Shared ReadOnly 服务器踢出玩家 As String = "iw_sever_remove"
    Public Shared ReadOnly 服务器封禁玩家 As String = "iw_sever_ban"


    Public Shared ReadOnly 客户端回应Ping As String = "iw_client_receiveping"
    Public Shared ReadOnly 客户端请求连接服务器 As String = "iw_client_login_dev3"
    Public Shared ReadOnly 客户端主动断开连接 As String = "iw_client_disconnect"

End Class
