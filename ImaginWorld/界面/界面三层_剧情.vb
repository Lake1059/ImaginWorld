Public Class 界面三层_剧情

    Private Sub 界面三层_剧情_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ImageList1.ImageSize = New Size(1, 35 * Form1.DPI)
        SetControlFont(Me)
        暗黑列表视图自绘制.绑定列表视图事件(ListView1)
        调整界面()
    End Sub

    Private Sub 界面三层_剧情_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.ParentForm.WindowState = FormWindowState.Minimized Then Exit Sub
        调整界面()

    End Sub

    Public Sub 调整界面()
        Me.ListView1.Width = Me.ListView1.Parent.Width + SystemInformation.VerticalScrollBarWidth * Form1.DPI




    End Sub

    Private Sub UiButton菜单_Click(sender As Object, e As EventArgs) Handles UiButton菜单.Click
        界面控制.切换界面(界面控制.主界面图层.顶层, New 界面顶层_暂停菜单)
    End Sub


End Class
