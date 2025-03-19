Public Class 界面二层_仓库
    Private Sub UiButton返回_Click(sender As Object, e As EventArgs) Handles UiButton返回.Click
        Dispose()
    End Sub

    Public 是否已初始化 As Boolean = False

    Private Sub 界面二层_仓库_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetControlFont(Me)
        暗黑列表视图自绘制.绑定列表视图事件(ListView1)
        Me.ImageList1.ImageSize = New Size(1, 30 * Form1.DPI)
        Me.Label16.Width = Me.Label16.Parent.Width * 0.7 - 20 * Form1.DPI
        Me.Label15.Width = Me.Label15.Parent.Width * 0.15
        Me.Label14.Width = Me.Label14.Parent.Width * 0.15
        Me.ListView1.Width = Me.ListView1.Parent.Width + SystemInformation.VerticalScrollBarWidth * Form1.DPI
        Me.ListView1.Columns(0).Width = Me.ListView1.Parent.Width * 0.7 - 20 * Form1.DPI
        Me.ListView1.Columns(1).Width = Me.ListView1.Parent.Width * 0.15
        Me.ListView1.Columns(2).Width = Me.ListView1.Parent.Width * 0.15
        Me.Panel14.Width = 200 * Form1.DPI
        Me.Panel11.Width = 430 * Form1.DPI
        Me.UiButton15.Width = 130 * Form1.DPI
        Me.UiButton14.Width = 130 * Form1.DPI
        Me.UiButton返回.Width = 130 * Form1.DPI
        Me.UiTrackBar1.BarSize = 30 * Form1.DPI
        是否已初始化 = True
        调整界面()
    End Sub

    Private Sub 界面二层_仓库_DpiChangedAfterParent(sender As Object, e As EventArgs) Handles Me.DpiChangedAfterParent
        If Not 是否已初始化 Then Exit Sub
        If Me.ParentForm.WindowState = FormWindowState.Minimized Then Exit Sub
        调整界面()
    End Sub

    Private Sub 界面二层_仓库_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not 是否已初始化 Then Exit Sub
        If Me.ParentForm.WindowState = FormWindowState.Minimized Then Exit Sub
        调整界面()
    End Sub

    Public Sub 调整界面()
        Me.UiTabControlMenu1.ItemSize = New Size(Me.Panel14.Width - Me.Panel14.Padding.Right, 50 * Form1.DPI)

    End Sub

    Private Sub UiTabControlMenu1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UiTabControlMenu1.SelectedIndexChanged
        Dim 子选项卡 As TabPage = Me.UiTabControlMenu1.SelectedTab
        Select Case True
            Case 子选项卡.IsEqual(TabPage关键物资)
                Me.Panel4.Visible = True
                Me.UiTrackBar1.Visible = True
                Me.UiTextBox1.Enabled = True : Me.UiTextBox1.Watermark = "输入数量"
            Case 子选项卡.IsEqual(TabPage制作材料)
                Me.Panel4.Visible = True
                Me.UiTrackBar1.Visible = True
                Me.UiTextBox1.Enabled = True : Me.UiTextBox1.Watermark = "输入数量"
            Case 子选项卡.IsEqual(TabPage养成道具)
                Me.Panel4.Visible = True
                Me.UiTrackBar1.Visible = True
                Me.UiTextBox1.Enabled = True : Me.UiTextBox1.Watermark = "输入数量"
            Case 子选项卡.IsEqual(TabPage消耗品)
                Me.Panel4.Visible = True
                Me.UiTrackBar1.Visible = True
                Me.UiTextBox1.Enabled = True : Me.UiTextBox1.Watermark = "输入数量"
            Case 子选项卡.IsEqual(TabPage武器)
                Me.Panel4.Visible = False
                Me.UiTrackBar1.Visible = False
                Me.UiTextBox1.Enabled = False : Me.UiTextBox1.Watermark = "单件"
            Case 子选项卡.IsEqual(TabPage装备)
                Me.Panel4.Visible = False
                Me.UiTrackBar1.Visible = False
                Me.UiTextBox1.Enabled = False : Me.UiTextBox1.Watermark = "单件"
            Case 子选项卡.IsEqual(TabPage任务物品)
                Me.Panel4.Visible = True
                Me.UiTrackBar1.Visible = True
                Me.UiTextBox1.Enabled = True : Me.UiTextBox1.Watermark = "输入数量"
            Case 子选项卡.IsEqual(TabPage收集品)
                Me.Panel4.Visible = True
                Me.UiTrackBar1.Visible = True
                Me.UiTextBox1.Enabled = True : Me.UiTextBox1.Watermark = "输入数量"
        End Select
        Me.UiTextBox1.Text = ""
    End Sub

End Class
