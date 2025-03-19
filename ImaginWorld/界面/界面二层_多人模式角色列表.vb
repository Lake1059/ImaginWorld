Public Class 界面二层_多人模式角色列表
    Public 是否已初始化 As Boolean = False
    Private Sub 界面二层_多人模式角色列表_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        是否已初始化 = True
        调整界面()
    End Sub

    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles UiButton1.Click
        客户端.发送消息(New List(Of String) From {"iw_client_disconnect"})
        客户端.停止客户端()
        Me.Dispose()
    End Sub

    Private Sub 界面二层_多人模式角色列表_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not 是否已初始化 Then Exit Sub
        If Me.ParentForm.WindowState = FormWindowState.Minimized Then Exit Sub
        调整界面()
    End Sub

    Public Sub 调整界面()
        Me.Panel4.Width = (Me.Width - Panel38.Width) * 0.5
    End Sub


End Class
