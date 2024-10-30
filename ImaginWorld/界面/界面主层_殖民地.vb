
Public Class 界面主层_殖民地

    Public Property 是否已初始化 As Boolean = False
    Public Property DPI As Single

    Private Sub 模板_殖民地_Load(sender As Object, e As EventArgs) Handles Me.Load
        'AddHandler UiTabControlMenu1.SelectedIndexChanged, AddressOf 触发主选项卡切换事件

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
        'Me.Panel1.Height = 90 * DPI
        'Me.Panel1.Padding = New Padding(20 * DPI)
        'Dim Panel1内部宽度 As Integer = Me.Panel1.Width - Me.Panel1.Padding.Left * 2
        'Me.Panel2.Width = Panel1内部宽度 * 0.15
        'Me.Panel4.Width = Panel1内部宽度 * 0.15
        'Me.Panel3.Width = 22 * DPI : Me.Panel3.Padding = New Padding(10 * DPI, 0, 10 * DPI, 0)
        'Me.Panel7.Width = Panel1内部宽度 * 0.15
        'Me.Panel6.Width = 22 * DPI : Me.Panel6.Padding = New Padding(10 * DPI, 0, 10 * DPI, 0)
        'Me.Panel9.Width = Panel1内部宽度 * 0.15
        'Me.Panel10.Width = 22 * DPI : Me.Panel10.Padding = New Padding(10 * DPI, 0, 10 * DPI, 0)
        'Me.UiButton1.Width = Panel1内部宽度 * 0.15
        'Me.UiButton1.Parent.Width = Me.UiButton1.Width + 10 * DPI
        '触发主选项卡切换事件()
    End Sub

    Public Sub 设置殖民地名称(文本 As String)
        '界面控制.根据宽度显示单行文本(Label殖民地名称, 文本, Panel2.Width)
    End Sub

    'Public Sub 触发主选项卡切换事件()
    '    Me.UiTabControlMenu1.ItemSize = New Size(150 * DPI, 50 * DPI)
    '    Dim 子选项卡 As TabPage = Me.UiTabControlMenu1.SelectedTab
    '    Select Case True
    '        Case 子选项卡.IsEqual(TabPage概览)
    '            Me.Panel8.Width = 570 * DPI

    '        Case 子选项卡.IsEqual(TabPage仓库)
    '            'Me.Label26.Width = 1 * DPI

    '    End Select
    'End Sub

End Class
