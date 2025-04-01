Imports System.Runtime.InteropServices
Public Class 全局键盘钩子

    Private Delegate Function HookProc(nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    Private Shared ReadOnly hookProc2 As HookProc = AddressOf HookCallback
    Private Shared hHook As IntPtr = IntPtr.Zero

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function SetWindowsHookEx(idHook As Integer, lpfn As HookProc, hMod As IntPtr, dwThreadId As UInteger) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function UnhookWindowsHookEx(hhk As IntPtr) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(hhk As IntPtr, nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function GetModuleHandle(lpModuleName As String) As IntPtr
    End Function

    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN As Integer = &H100
    Private Const WM_KEYUP As Integer = &H101

    Private Shared keyDown As Boolean = False

    Public Shared Sub SetHook()
        If hHook = IntPtr.Zero Then
            hHook = SetWindowsHookEx(WH_KEYBOARD_LL, hookProc2, GetModuleHandle(Nothing), 0)
        End If
    End Sub

    Public Shared Sub Unhook()
        If hHook <> IntPtr.Zero Then
            UnhookWindowsHookEx(hHook)
            hHook = IntPtr.Zero
        End If
    End Sub

    Private Shared Function HookCallback(nCode As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
        If nCode >= 0 Then
            Dim key As Keys = CType(Marshal.ReadInt32(lParam), Keys)
            If wParam = CType(WM_KEYDOWN, IntPtr) Then
                keyDown = True
            ElseIf wParam = CType(WM_KEYUP, IntPtr) AndAlso keyDown Then
                keyDown = False
                RaiseEvent 自定义全局键盘事件(key)
            End If
        End If
        Return CallNextHookEx(hHook, nCode, wParam, lParam)
    End Function

    Public Shared Event 自定义全局键盘事件(Key As Keys)

    Public Shared Sub 初始化全局键盘事件()
        AddHandler 自定义全局键盘事件, AddressOf 全局键盘钩子执行
        AddHandler Form1.Deactivate, AddressOf OnFormDeactivate
        AddHandler Form1.Activated, AddressOf OnFormActivated
        DebugPrint($"全局键盘钩子已初始化", Color.CornflowerBlue)
    End Sub

    Private Shared Sub OnFormDeactivate(sender As Object, e As EventArgs)
        Unhook()
    End Sub

    Private Shared Sub OnFormActivated(sender As Object, e As EventArgs)
        SetHook()
    End Sub

    Shared Sub 全局键盘钩子执行(Key As Keys)
        Select Case Key
            Case Keys.Oemtilde
                If 控制台界面实例.Visible Then
                    界面控制.隐藏控制台()
                Else
                    界面控制.显示控制台()
                End If
            Case Keys.P
                Dim bounds As Rectangle = Form1.ClientRectangle
                Using bitmap As New Bitmap(bounds.Width, bounds.Height)
                    Using g As Graphics = Graphics.FromImage(bitmap)
                        g.CopyFromScreen(Form1.PointToScreen(bounds.Location), Point.Empty, bounds.Size)
                        Clipboard.SetImage(bitmap)
                    End Using
                End Using
            Case Keys.Escape
                If Form1.界面图层_控制台 IsNot Nothing Then
                    界面控制.隐藏控制台()
                    Exit Sub
                End If
                If Form1.界面图层_顶层 IsNot Nothing Then
                    界面控制.关闭顶层界面()
                    Exit Sub
                End If
                If Form1.界面图层_三层 IsNot Nothing Then
                    界面控制.关闭三层界面()
                    Exit Sub
                End If
                If Form1.界面图层_二层 IsNot Nothing Then
                    界面控制.关闭二层界面()
                    Exit Sub
                End If
                If Form1.界面图层_主层.GetType <> GetType(界面主层_主菜单) Then
                    界面控制.切换界面(界面控制.主界面图层.顶层, New 界面顶层_暂停菜单)
                End If
        End Select
    End Sub

End Class
