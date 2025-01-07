Imports System.ComponentModel
Imports System.Net.NetworkInformation
Imports System.Timers

Public Class Form服务器

    Private timer As Timer
    Private previousSentBytes As Long
    Private previousReceivedBytes As Long

    Private Sub InitializeNetworkMonitor()
        timer = New Timer With {
            .Interval = 1000 ' 每秒更新一次
            }
        AddHandler timer.Elapsed, AddressOf Timer_Elapsed
        timer.Start()

        ' 初始化上一次的字节数
        previousSentBytes = GetTotalBytesSent()
        previousReceivedBytes = GetTotalBytesReceived()
    End Sub

    Private Sub Timer_Elapsed(sender As Object, e As ElapsedEventArgs)
        Dim currentSentBytes As Long = GetTotalBytesSent()
        Dim currentReceivedBytes As Long = GetTotalBytesReceived()
        Dim sentBytesPerSecond As Long = currentSentBytes - previousSentBytes
        Dim receivedBytesPerSecond As Long = currentReceivedBytes - previousReceivedBytes
        previousSentBytes = currentSentBytes
        previousReceivedBytes = currentReceivedBytes
        每秒上传KB = sentBytesPerSecond / 1024.0
        每秒下载KB = receivedBytesPerSecond / 1024.0
    End Sub

    Private Function GetTotalBytesSent() As Long
        Return NetworkInterface.GetAllNetworkInterfaces() _
            .Where(Function(nic) nic.OperationalStatus = OperationalStatus.Up) _
            .Sum(Function(nic) nic.GetIPv4Statistics().BytesSent)
    End Function

    Private Function GetTotalBytesReceived() As Long
        Return NetworkInterface.GetAllNetworkInterfaces() _
            .Where(Function(nic) nic.OperationalStatus = OperationalStatus.Up) _
            .Sum(Function(nic) nic.GetIPv4Statistics().BytesReceived)
    End Function

    Public 每秒上传KB As Long
    Public 每秒下载KB As Long

    Private Sub Form服务器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetControlFont(Me)
        InitializeNetworkMonitor()
        暗黑列表视图自绘制.绑定列表视图事件(ListView1)
        Me.Label1.Text = $"{服务器.获取本地IPv4()}：{服务器.服务器端口}"
        顶部显示的地址端口 = Me.Label1.Text
        Me.UiSwitch2.Active = 服务器.广播任务.Status = TaskStatus.Running
        Me.UiTextBox1.Text = 服务器.服务器名称
        Me.UiTextBox2.Text = 服务器.服务器描述
        Me.UiSwitch1.Active = 服务器.是否允许新地址加入
        Me.UiSwitch3.Active = 服务器.开放单人数据位
        Me.UiComboBox6.SelectedIndex = 服务器.玩家默认权限
        Select Case 服务器.自动踢出延迟
            Case -1
                Me.UiComboBox8.SelectedIndex = 0
            Case 500
                Me.UiComboBox8.SelectedIndex = 1
            Case 1000
                Me.UiComboBox8.SelectedIndex = 2
            Case 2000
                Me.UiComboBox8.SelectedIndex = 3
            Case 3000
                Me.UiComboBox8.SelectedIndex = 4
            Case Else
                Me.UiComboBox8.SelectedIndex = 0
        End Select
        AddHandler 每秒刷新计时器.Elapsed, AddressOf 每秒刷新界面
        每秒刷新计时器.Start()
    End Sub

    Private Sub Form服务器_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        调整界面()
    End Sub

    Private Sub UiTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UiTabControl1.SelectedIndexChanged
        调整界面()
    End Sub

    Sub 调整界面()
        Me.UiButton9.Width = (Me.Panel21.Width - Me.Label12.Width) * 0.5
        Me.UiButton7.Width = (Me.Panel11.Width - Me.Label18.Width * 2) / 3
        Me.UiButton2.Width = Me.UiButton7.Width
        Me.UiButton3.Width = Me.UiButton7.Width
    End Sub

    Public 顶部显示的地址端口 As String
    Public 玩家位置占用数量 As String = "0/0"

    Public 每秒刷新计时器 As New Timer With {
        .Interval = 1000
    }
    Sub 每秒刷新界面()
        Me.Invoke(Sub() Me.Label1.Text = 顶部显示的地址端口 & "   " & 玩家位置占用数量 & "   ↑" & 每秒上传KB & "KB/s" & "   ↓" & 每秒下载KB & "KB/s")
    End Sub

    Private Sub Form服务器_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        timer.Dispose()
        每秒刷新计时器.Dispose()
    End Sub
End Class