Public Class 界面顶层_暂停菜单
    Private Sub UiButton回到游戏_Click(sender As Object, e As EventArgs) Handles UiButton回到游戏.Click
        Me.Dispose()
    End Sub

    Private Sub UiButton保存并回主菜单_Click(sender As Object, e As EventArgs) Handles UiButton保存并回主菜单.Click
        界面控制.切换界面(界面控制.主界面图层.主层, New 界面主层_主菜单)
        界面控制.关闭三层界面()
        界面控制.关闭二层界面()
        界面控制.关闭顶层界面()
        声音控制.自动选择下一首BGM进行播放(True)
    End Sub

    Private Sub UiButton断开连接_Click(sender As Object, e As EventArgs) Handles UiButton断开连接.Click
        界面控制.切换界面(界面控制.主界面图层.主层, New 界面主层_主菜单)
        界面控制.关闭三层界面()
        界面控制.关闭二层界面()
        界面控制.关闭顶层界面()
        声音控制.自动选择下一首BGM进行播放(True)
    End Sub
End Class
