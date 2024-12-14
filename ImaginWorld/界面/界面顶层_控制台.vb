Public Class 界面顶层_控制台

    Public Sub 禁用可操作区域()
        Panel3.Visible = False
        Panel6.Visible = False
    End Sub

    Public Sub 启用可操作区域()
        Panel3.Visible = True
        Panel6.Visible = True
        Me.RichTextBox1.Dock = DockStyle.None
        Me.RichTextBox1.Dock = DockStyle.Fill
        调整界面()
    End Sub

    Private Sub 界面顶层_控制台_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetControlFont(Me, {RichTextBox1})
        AddHandler Me.UiTextBox1.KeyDown, Sub(s1, e1)
                                              Select Case e1.KeyData
                                                  Case Keys.Enter
                                                      If e1.KeyData = Keys.Enter Then UiButton发送指令.PerformClick()
                                                      Me.UiTextBox1.Focus()
                                                  Case Keys.W, Keys.Up
                                                      Me.UiTextBox1.Text = 上一次发送的指令
                                                      Me.UiTextBox1.SelectionStart = Me.UiTextBox1.Text.Length
                                              End Select
                                              e1.Handled = True
                                          End Sub
    End Sub

    Private Sub 界面顶层_控制台_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        调整界面()
    End Sub

    Sub 调整界面()
        Me.RichTextBox1.Width = Me.RichTextBox1.Parent.Width - Me.RichTextBox1.Parent.Padding.Left - Me.RichTextBox1.Parent.Padding.Right
        Me.RichTextBox1.Height = Me.RichTextBox1.Parent.Height - Me.RichTextBox1.Parent.Padding.Top - Me.RichTextBox1.Parent.Padding.Bottom
    End Sub

    Private Sub UiButton关闭控制台_Click(sender As Object, e As EventArgs) Handles UiButton关闭控制台.Click
        Visible = False
        Form1.界面图层_顶层 = Nothing
    End Sub

    Dim 上一次发送的指令 As String = ""

    Private Sub UiButton发送指令_Click(sender As Object, e As EventArgs) Handles UiButton发送指令.Click
        If Me.UiTextBox1.Text.Replace(" ", "") = "" Then Exit Sub
        上一次发送的指令 = Me.UiTextBox1.Text
        DebugPrint(Me.UiTextBox1.Text, Color.Silver, False)
        指令系统.执行(Me.UiTextBox1.Text)
        Me.UiTextBox1.Text = ""
    End Sub


End Class
