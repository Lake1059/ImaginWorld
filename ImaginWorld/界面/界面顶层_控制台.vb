Public Class 界面顶层_控制台

    Public Sub 禁用可操作区域()
        Panel1.Visible = False
        Panel3.Visible = False
        Panel6.Visible = False
    End Sub

    Public Sub 启用可操作区域()
        Panel1.Visible = True
        Panel3.Visible = True
        Panel6.Visible = True
    End Sub


    Private Sub 界面顶层_控制台_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub UiButton关闭控制台_Click(sender As Object, e As EventArgs) Handles UiButton关闭控制台.Click
        Visible = False
    End Sub
End Class
