Public Class 界面顶层_暂停菜单
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub UiButton回到游戏_Click(sender As Object, e As EventArgs) Handles UiButton回到游戏.Click
        Me.Dispose()
    End Sub

    Private Sub UiButton保存并回主菜单_Click(sender As Object, e As EventArgs) Handles UiButton保存并回主菜单.Click
        界面控制.切换界面(界面控制.主界面图层.主层, New 界面主层_主菜单)
        If Form1.界面图层_二层 IsNot Nothing Then Form1.界面图层_二层.Dispose()
        If Form1.界面图层_三层 IsNot Nothing Then Form1.界面图层_三层.Dispose()
        Form1.界面图层_顶层.Dispose()
        声音控制.自动选择下一首BGM进行播放(True)
    End Sub
End Class
