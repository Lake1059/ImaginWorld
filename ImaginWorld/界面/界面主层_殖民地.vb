Public Class 界面主层_殖民地

    Public 是否已初始化 As Boolean = False

    Private Sub 模板_殖民地_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetControlFont(Me)
        是否已初始化 = True
        调整界面()
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
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
        Panel39.Height = (Panel39.Height + Panel40.Height) * 0.5
        RichTextBox1.Width = RichTextBox1.Parent.Width + SystemInformation.VerticalScrollBarWidth
        RichTextBox2.Width = RichTextBox2.Parent.Width + SystemInformation.VerticalScrollBarWidth
        RichTextBox1.Height = RichTextBox1.Parent.Height
        RichTextBox2.Height = RichTextBox2.Parent.Height
        RichTextBox1.RightMargin = RichTextBox1.Parent.Width
        RichTextBox2.RightMargin = RichTextBox2.Parent.Width
    End Sub

    Private Sub UiButton仓库_Click(sender As Object, e As EventArgs) Handles UiButton仓库.Click
        界面控制.切换界面(界面控制.主界面图层.二层, New 界面二层_仓库)
    End Sub

    Private Sub UiButton建筑_Click(sender As Object, e As EventArgs) Handles UiButton建筑.Click
        界面控制.切换界面(界面控制.主界面图层.二层, New 界面二层_建筑和生产)
    End Sub

    Private Sub UiButton角色_Click(sender As Object, e As EventArgs) Handles UiButton角色.Click
        界面控制.切换界面(界面控制.主界面图层.二层, New 界面二层_角色详情)
    End Sub

    Private Sub UiButton菜单_Click(sender As Object, e As EventArgs) Handles UiButton菜单.Click
        界面控制.切换界面(界面控制.主界面图层.顶层, New 界面顶层_暂停菜单)
    End Sub


    Sub 向资源正在增加的面板添加瓷砖(名称 As String, 数值 As Single)
        Dim 名称文本长度 = Len(名称)
        Dim 将输出的数值文本 As String = 数值.ToString("+#;-#;0")
        Dim 数值文本长度 = Len(将输出的数值文本)
        RichTextBox1.SelectionColor = RichTextBox1.ForeColor
        If RichTextBox1.Text = "" Then
            RichTextBox1.AppendText(名称 & " " & 将输出的数值文本)
        Else
            RichTextBox1.AppendText(" " & 名称 & " " & 将输出的数值文本)
        End If
        Dim 数值文本起始位 As Integer = RichTextBox1.TextLength - 数值文本长度
        RichTextBox1.Select(数值文本起始位, 数值文本长度)
        RichTextBox1.SelectionColor = Color.ForestGreen
        RichTextBox1.Select(RichTextBox1.TextLength, 0)

    End Sub

    Sub 向资源正在减少的面板添加瓷砖(名称 As String, 数值 As Single)
        Dim 名称文本长度 = Len(名称)
        Dim 将输出的数值文本 As String = 数值.ToString("+#;-#;0")
        Dim 数值文本长度 = Len(将输出的数值文本)
        RichTextBox2.SelectionColor = RichTextBox2.ForeColor
        If RichTextBox2.Text = "" Then
            RichTextBox2.AppendText(名称 & " " & 将输出的数值文本)
        Else
            RichTextBox2.AppendText(" " & 名称 & " " & 将输出的数值文本)
        End If
        Dim 数值文本起始位 As Integer = RichTextBox2.TextLength - 数值文本长度
        RichTextBox2.Select(数值文本起始位, 数值文本长度)
        RichTextBox2.SelectionColor = ColorTranslator.FromWin32(RGB(128, 64, 64))
        RichTextBox2.Select(RichTextBox2.TextLength, 0)

    End Sub

    Private Sub UiButton离开据点_Click(sender As Object, e As EventArgs) Handles UiButton离开据点.Click
        向资源正在增加的面板添加瓷砖("资源" & RichTextBox1.TextLength, Math.Round(Rnd() * 1000, 2))
        向资源正在减少的面板添加瓷砖("资源" & RichTextBox2.TextLength, -Math.Round(Rnd() * 1000, 2))
    End Sub
End Class
