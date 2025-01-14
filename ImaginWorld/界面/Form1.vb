Imports System.ComponentModel

Public Class Form1
    Protected Overrides Sub WndProc(ByRef m As Message)
        Const WM_NCHITTEST As Integer = &H84
        Const HTCAPTION As Integer = 2
        Const HTBOTTOM As Integer = 15
        Const HTBOTTOMLEFT As Integer = 16
        Const HTBOTTOMRIGHT As Integer = 17
        Const HTLEFT As Integer = 10
        Const HTRIGHT As Integer = 11
        Const HTTOP As Integer = 12
        Const HTTOPLEFT As Integer = 13
        Const HTTOPRIGHT As Integer = 14

        MyBase.WndProc(m)
        If m.Msg = WM_NCHITTEST Then
            Dim result As Integer = m.Result.ToInt32()
            Select Case result
                Case HTBOTTOM, HTBOTTOMLEFT, HTBOTTOMRIGHT, HTLEFT, HTRIGHT, HTTOP, HTTOPLEFT, HTTOPRIGHT
                    m.Result = CType(HTCAPTION, IntPtr)
            End Select
        End If
    End Sub

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Shared Property DPI As Single = Form1.CreateGraphics.DpiX / 96

    Public 界面图层_主层 As Control = Nothing
    Public 界面图层_二层 As Control = Nothing
    Public 界面图层_三层 As Control = Nothing
    Public 界面图层_顶层 As Control = Nothing

    Public 加载时间计时器 As New Stopwatch()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Screen.PrimaryScreen.Bounds.Width < 1280 Or Screen.PrimaryScreen.Bounds.Height < 720 Then
            MsgBox($"主屏幕分辨率不足 1280x720，请更换或调整主显示器后再启动游戏！{vbCrLf & vbCrLf} The main screen resolution is less than 1280x720. Please change or adjust the main monitor before launching the game.", MsgBoxStyle.Critical)
            End
        End If

        全局键盘钩子.SetHook()
        游戏设置.加载()
        If 游戏设置.实例对象.FullScreenNoBorders Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.WindowState = FormWindowState.Maximized
        End If
        Steam通讯维持.开始初始化Steam接口()
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        控制台界面实例.禁用可操作区域()
        界面控制.切换界面(界面控制.主界面图层.顶层, 控制台界面实例)

        Application.DoEvents()

        加载时间计时器.Start()
        DebugPrint($"开始启动", Color.Silver)

        指令系统.初始化()
        声音控制.初始化()

        模组管理.启动时扫描模组()
    End Sub

    Private Sub Form1_DpiChanged(sender As Object, e As DpiChangedEventArgs) Handles Me.DpiChanged
        DPI = e.DeviceDpiNew / 96
        Me.MinimumSize = New Size(0, 0)
        Me.ClientSize = New Size(1280 * DPI, 720 * DPI)
        Me.MinimumSize = Me.Size
    End Sub

    Public Sub 重新创建句柄()
        If Not Me.IsHandleCreated Then Me.CreateHandle()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        全局键盘钩子.Unhook()
        End
    End Sub

    Public Sub 释放所有资源回主菜单()
        界面图层_主层?.Dispose()
        界面图层_二层?.Dispose()
        界面图层_三层?.Dispose()
        If 界面图层_顶层 IsNot Nothing Then
            If 界面图层_顶层.GetType = GetType(界面顶层_控制台) Then
                控制台界面实例.UiButton关闭控制台.PerformClick()
            Else
                界面图层_顶层?.Dispose()
            End If
        End If
        界面控制.切换界面(界面控制.主界面图层.主层, New 界面主层_主菜单)
    End Sub


End Class
