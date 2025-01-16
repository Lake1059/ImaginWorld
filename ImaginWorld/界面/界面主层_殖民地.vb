
Public Class 界面主层_殖民地

    Public 是否已初始化 As Boolean = False
    Public DPI As Single

    Private Sub 模板_殖民地_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetControlFont(Me)

        是否已初始化 = True
        DPI = Form1.DPI
        调整界面()
    End Sub

    Private Sub 模板_殖民地_DpiChangedAfterParent(sender As Object, e As EventArgs) Handles Me.DpiChangedAfterParent
        DPI = Form1.DPI
        调整界面()
    End Sub

    Private Sub 模板_殖民地_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not 是否已初始化 Then Exit Sub
        If Me.ParentForm.WindowState = FormWindowState.Minimized Then Exit Sub
        调整界面()
    End Sub

    Public Sub 调整界面()
        If Not 是否已初始化 Then Exit Sub

    End Sub

    Private Sub UiButton仓库_Click(sender As Object, e As EventArgs) Handles UiButton仓库.Click
        界面控制.切换界面(界面控制.主界面图层.二层, New 界面二层_仓库)
    End Sub

    Private Sub UiButton建筑_Click(sender As Object, e As EventArgs) Handles UiButton建筑.Click
        界面控制.切换界面(界面控制.主界面图层.二层, New 界面二层_建筑和生产)
    End Sub

    Private Sub UiButton运输_Click(sender As Object, e As EventArgs) Handles UiButton运输.Click

    End Sub

    Private Sub UiButton角色_Click(sender As Object, e As EventArgs) Handles UiButton角色.Click
        界面控制.切换界面(界面控制.主界面图层.二层, New 界面二层_角色详情)
    End Sub

    Private Sub UiButton载具_Click(sender As Object, e As EventArgs) Handles UiButton载具.Click

    End Sub

    Private Sub UiButton合成_Click(sender As Object, e As EventArgs) Handles UiButton合成.Click

    End Sub

    Private Sub UiButton科技_Click(sender As Object, e As EventArgs) Handles UiButton科技.Click

    End Sub

    Private Sub UiButton决策_Click(sender As Object, e As EventArgs) Handles UiButton决策.Click

    End Sub

    Private Sub UiButton田地_Click(sender As Object, e As EventArgs) Handles UiButton田地.Click

    End Sub

    Private Sub UiButton场景_Click(sender As Object, e As EventArgs) Handles UiButton场景.Click

    End Sub

    Private Sub UiButton菜单_Click(sender As Object, e As EventArgs) Handles UiButton菜单.Click
        界面控制.切换界面(界面控制.主界面图层.顶层, New 界面顶层_暂停菜单)
    End Sub
End Class
