Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Text.Json
Imports Svg
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports System.IO
Imports Sunny.UI
Imports System.Threading

Module Module1

    Public 控制台界面实例 As New 界面顶层_控制台

    Public JSON序列化选项 As New JsonSerializerOptions With {.WriteIndented = True}

    Public UI同步上下文 As SynchronizationContext = SynchronizationContext.Current


    <Extension>
    Public Sub DoubleBuffer(control As Control)
        Dim propertyInfo As PropertyInfo = control.GetType().GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
        propertyInfo?.SetValue(control, True, Nothing)
    End Sub
    <Extension>
    Public Function IsEqual(page1 As TabPage, page2 As TabPage) As Boolean
        If page1 Is page2 Then Return True
        If page1 Is Nothing OrElse page2 Is Nothing Then Return False
        Return page1.Name = page2.Name
    End Function

    Public Sub DebugPrint(文本 As String, 颜色 As Color, Optional 时间戳 As Boolean = True, Optional 强制切换到控制台 As Boolean = False)
        If String.IsNullOrEmpty(文本) Then Exit Sub
        If 时间戳 Then 文本 = $"{TimeString} " & 文本
        Dim 文本长度 = Len(文本)
        UI同步上下文.Post(Sub()
                         控制台界面实例.RichTextBox1.AppendText(vbCrLf & 文本)
                         Dim 添加起始位 As Integer = 控制台界面实例.RichTextBox1.TextLength - 文本长度
                         控制台界面实例.RichTextBox1.Select(添加起始位, 文本长度)
                         控制台界面实例.RichTextBox1.SelectionColor = 颜色
                         控制台界面实例.RichTextBox1.Select(控制台界面实例.RichTextBox1.TextLength, 0)
                         控制台界面实例.RichTextBox1.ScrollToCaret()
                         If 强制切换到控制台 Then 界面控制.切换界面(界面控制.主界面图层.顶层, 控制台界面实例)
                     End Sub, Nothing)
    End Sub

    Public Function LaunchSvgToImage(SvgPath As String) As Image
        Try
            Dim svgDoc As SvgDocument = SvgDocument.Open(SvgPath)
            Return svgDoc.Draw(48 * Form1.DPI, 48 * Form1.DPI)
        Catch ex As Exception
            DebugPrint($"转换 SVG 图像错误：{ex.Message}", Color.Tomato)
            Return Nothing
        End Try
    End Function

    '扫描文件夹下的所有文件夹不包含子目录
    Public Function GetDirectories(path As String) As List(Of String)
        Dim dirs As New List(Of String)
        For Each dir As String In IO.Directory.GetDirectories(path)
            dirs.Add(dir)
        Next
        Return dirs
    End Function

    Public Function LoadImageFromFile(File As String) As Image
        Using fs As New FileStream(File, FileMode.Open, FileAccess.Read)
            Return Image.FromStream(fs)
            fs.Dispose()
        End Using
    End Function

    Public Sub SetControlFont(C As Control, Optional ExcludeContorl As Control() = Nothing)
        If 游戏设置.实例对象.Font = "微软雅黑" Then Exit Sub
        For Each ctrl As Control In C.Controls
            If ExcludeContorl IsNot Nothing Then
                If ExcludeContorl.Contains(ctrl) Then Continue For
            End If
            Dim controlType As Type = C.GetType()
            Dim propInfo As PropertyInfo = controlType.GetProperty("Font")
            If propInfo IsNot Nothing Then ctrl.Font = New Font(游戏设置.实例对象.Font, ctrl.Font.Size, ctrl.Font.Style)
            If ctrl.HasChildren Then SetControlFont(ctrl, ExcludeContorl)
        Next
    End Sub

    Public Sub 显示模式窗体(哪个窗口 As Form, 以谁为基准显示 As Form)
        哪个窗口.Left = (以谁为基准显示.Width - 哪个窗口.Width) * 0.5 + 以谁为基准显示.ScreenLocation.X
        哪个窗口.Top = (以谁为基准显示.Height - 哪个窗口.Height) * 0.5 + 以谁为基准显示.ScreenLocation.Y
        以谁为基准显示.Focus()
        哪个窗口.ShowDialog(以谁为基准显示)
    End Sub


    Public Sub 显示窗体(哪个窗口 As Form, 以谁为基准显示 As Form)
        If 哪个窗口.Visible = True Then
            哪个窗口.Focus()
            哪个窗口.Left = (以谁为基准显示.Width - 哪个窗口.Width) * 0.5 + 以谁为基准显示.Left
            哪个窗口.Top = (以谁为基准显示.Height - 哪个窗口.Height) * 0.5 + 以谁为基准显示.Top
        Else
            哪个窗口.Left = (以谁为基准显示.Width - 哪个窗口.Width) * 0.5 + 以谁为基准显示.Left
            哪个窗口.Top = (以谁为基准显示.Height - 哪个窗口.Height) * 0.5 + 以谁为基准显示.Top
            哪个窗口.Show(以谁为基准显示)
        End If
    End Sub

End Module