Public Class 界面二层_角色详情
    Private Sub UiButton返回_Click(sender As Object, e As EventArgs) Handles UiButton返回.Click
        Dispose
    End Sub

    Public 是否已初始化 As Boolean = False

    Private Sub 界面二层_角色详情_Load(sender As Object, e As EventArgs) Handles Me.Load

        SetControlFont(Me)
        暗黑列表视图自绘制.绑定列表视图事件(ListView1)
        暗黑列表视图自绘制.绑定列表视图事件(ListView3)
        是否已初始化 = True
        调整界面()
    End Sub

    Private Sub 界面二层_角色详情_DpiChangedAfterParent(sender As Object, e As EventArgs) Handles Me.DpiChangedAfterParent

    End Sub
    Private Sub 界面二层_角色详情_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not 是否已初始化 Then Exit Sub
        If Me.ParentForm.WindowState = FormWindowState.Minimized Then Exit Sub
        调整界面()
    End Sub

    Public Sub 调整界面()
        Me.ListView3.Columns(0).Width = Label2.Width - 5 * Form1.DPI
        Me.ListView3.Columns(1).Width = Label3.Width
        Me.ListView3.Columns(2).Width = Label4.Width
        Me.ListView3.Columns(3).Width = Label5.Width
        Me.ListView3.Columns(4).Width = Label6.Width
        Me.ListView3.Columns(5).Width = Label34.Width
        Me.ListView3.Columns(6).Width = Label1.Width
        Me.ListView3.Columns(7).Width = Label35.Width - SystemInformation.VerticalScrollBarWidth * Form1.DPI
    End Sub



End Class
