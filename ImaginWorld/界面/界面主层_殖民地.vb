Public Class 界面主层_殖民地

    Public 是否已初始化 As Boolean = False

    Private Sub 模板_殖民地_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetControlFont(Me)
        是否已初始化 = True
        调整界面()
    End Sub

    Private Sub 模板_殖民地_DpiChangedAfterParent(sender As Object, e As EventArgs) Handles Me.DpiChangedAfterParent
        调整界面()
    End Sub

    Private Sub 模板_殖民地_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not 是否已初始化 Then Exit Sub
        If Me.ParentForm.WindowState = FormWindowState.Minimized Then Exit Sub
        调整界面()
    End Sub

    Public Sub 调整界面()
        If Not 是否已初始化 Then Exit Sub
        Me.Panel8.Width = (Me.Width - Panel38.Width * 2) / 3
        Me.Panel11.Width = Me.Panel8.Width
        Me.Panel35.Width = Me.Panel18.Width - 125 * Form1.DPI
    End Sub

    Private Sub UiButton仓库_Click(sender As Object, e As EventArgs) Handles UiButton仓库.Click
        界面控制.切换界面(界面控制.主界面图层.二层, New 界面二层_仓库)
    End Sub

    Private Sub UiButton建筑_Click(sender As Object, e As EventArgs) Handles UiButton建筑.Click
        界面控制.切换界面(界面控制.主界面图层.二层, New 界面二层_建筑和生产)
    End Sub

    Private Sub UiButton角色_Click(sender As Object, e As EventArgs)
        界面控制.切换界面(界面控制.主界面图层.二层, New 界面二层_角色详情)
    End Sub

    Private Sub UiButton菜单_Click(sender As Object, e As EventArgs) Handles UiButton菜单.Click
        界面控制.切换界面(界面控制.主界面图层.顶层, New 界面顶层_暂停菜单)
    End Sub


    Private Sub UiButton离开据点_Click(sender As Object, e As EventArgs) Handles UiButton离开据点.Click
        界面控制.切换界面(界面控制.主界面图层.主层, New 界面主层_地图)
    End Sub
End Class
