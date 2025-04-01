
Public Class 界面控制

    Enum 主界面图层
        主层 = 1
        二层 = 2
        三层 = 3
        顶层 = 10
        控制台 = 99
    End Enum

    Public Shared Sub 切换界面(w As 主界面图层, c As Control)
        Select Case w
            Case 主界面图层.主层
                If Form1.界面图层_主层 IsNot Nothing Then Form1.界面图层_主层.Dispose()
                Form1.界面图层_主层 = c
                c.Dock = DockStyle.Fill
                Form1.Controls.Add(c)
                Form1.界面图层_主层?.SendToBack()
            Case 主界面图层.二层
                If Form1.界面图层_二层 IsNot Nothing Then Form1.界面图层_二层.Dispose()
                Form1.界面图层_二层 = c
                c.Dock = DockStyle.Fill
                Form1.Controls.Add(c)
                Form1.界面图层_主层?.SendToBack()
                Form1.界面图层_顶层?.BringToFront()
                Form1.界面图层_控制台?.BringToFront()
            Case 主界面图层.三层
                If Form1.界面图层_三层 IsNot Nothing Then Form1.界面图层_三层.Dispose()
                Form1.界面图层_三层 = c
                c.Dock = DockStyle.Fill
                Form1.Controls.Add(c)
                Form1.界面图层_顶层?.BringToFront()
                Form1.界面图层_控制台?.BringToFront()
                Form1.界面图层_二层?.SendToBack()
                Form1.界面图层_主层?.SendToBack()
            Case 主界面图层.顶层
                If Form1.界面图层_顶层 IsNot Nothing Then Form1.界面图层_顶层.Dispose()
                Form1.界面图层_顶层 = c
                c.Dock = DockStyle.Fill
                Form1.Controls.Add(c)
                Form1.界面图层_控制台?.BringToFront()
                Form1.界面图层_三层?.SendToBack()
                Form1.界面图层_二层?.SendToBack()
                Form1.界面图层_主层?.SendToBack()
        End Select
        c.Visible = True
    End Sub

    Public Shared Sub 显示控制台()
        Form1.界面图层_控制台 = 控制台界面实例
        控制台界面实例.Visible = True
        控制台界面实例.Dock = DockStyle.Fill
        Form1.Controls.Add(Form1.界面图层_控制台)
        Form1.界面图层_控制台.BringToFront()
    End Sub

    Public Shared Sub 隐藏控制台()
        Form1.界面图层_控制台 = Nothing
        控制台界面实例.Visible = False
        Form1.Controls.Remove(Form1.界面图层_控制台)
        控制台界面实例.UiButton关闭控制台.PerformClick()
    End Sub

    Public Shared Sub 关闭顶层界面()
        If Form1.界面图层_顶层 IsNot Nothing Then Form1.界面图层_顶层?.Dispose()
    End Sub

    Public Shared Sub 关闭三层界面()
        If Form1.界面图层_三层 IsNot Nothing Then Form1.界面图层_三层.Dispose()
    End Sub

    Public Shared Sub 关闭二层界面()
        If Form1.界面图层_二层 IsNot Nothing Then Form1.界面图层_二层.Dispose()
    End Sub



    Public Shared Sub 根据宽度显示单行文本(标签控件 As Label, 文本 As String, 宽度 As Integer)
        Dim 文字显示所需尺寸 As Size = TextRenderer.MeasureText(文本, 标签控件.Font)
        Dim 实际文本 As String = 文本
        If 文字显示所需尺寸.Width > 宽度 Then
            Dim 点号所占用的宽度 As Integer = TextRenderer.MeasureText("...", 标签控件.Font).Width
            Dim 实际文本可用宽度 As Integer = 宽度 - 点号所占用的宽度
            Dim 左 As Integer = 0
            Dim 右 As Integer = 实际文本.Length - 1
            While 左 <= 右
                Dim 中 As Integer = (左 + 右) \ 2
                Dim 中文本 As String = 实际文本.Substring(0, 中 + 1)
                Dim 中宽度 As Integer = TextRenderer.MeasureText(中文本, 标签控件.Font).Width
                If 中宽度 <= 实际文本可用宽度 Then
                    左 = 中 + 1
                Else
                    右 = 中 - 1
                End If
            End While
            实际文本 = String.Concat(实际文本.AsSpan(0, 右 + 1), "...")
        End If
        标签控件.Text = 实际文本
    End Sub

    Public Shared Sub 根据标签宽度计算并设置显示高度(标签控件 As Label)
        Dim g As Graphics = Form1.CreateGraphics()
        Dim size As SizeF = g.MeasureString(标签控件.Text, 标签控件.Font, 标签控件.Width - 标签控件.Padding.Left - 标签控件.Padding.Right)
        g.Dispose()
        标签控件.Height = size.Height + 标签控件.Padding.Top + 标签控件.Padding.Bottom
    End Sub



End Class
