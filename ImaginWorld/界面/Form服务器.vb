
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Threading
Imports System.Timers

Public Class Form服务器

    Private 网络适配器监视器 As System.Timers.Timer
    Private previousSentBytes As Long
    Private previousReceivedBytes As Long
    Private Sub 初始化网络适配器监视器()
        网络适配器监视器 = New System.Timers.Timer With {.Interval = 1000}
        AddHandler 网络适配器监视器.Elapsed, AddressOf 网络适配器监视器动作
        网络适配器监视器.Start()
        previousSentBytes = 获取网络适配器已发送()
        previousReceivedBytes = 获取网络适配器已接收()
    End Sub
    Private Sub 网络适配器监视器动作(sender As Object, e As ElapsedEventArgs)
        Dim currentSentBytes As Long = 获取网络适配器已发送()
        Dim currentReceivedBytes As Long = 获取网络适配器已接收()
        网络适配器每秒发送 = currentSentBytes - previousSentBytes
        网络适配器每秒接收 = currentReceivedBytes - previousReceivedBytes
        previousSentBytes = currentSentBytes
        previousReceivedBytes = currentReceivedBytes
    End Sub
    Private Function 获取网络适配器已发送() As Long
        Return NetworkInterface.GetAllNetworkInterfaces() _
            .Where(Function(nic) nic.OperationalStatus = OperationalStatus.Up) _
            .Sum(Function(nic) nic.GetIPv4Statistics().BytesSent)
    End Function
    Private Function 获取网络适配器已接收() As Long
        Return NetworkInterface.GetAllNetworkInterfaces() _
            .Where(Function(nic) nic.OperationalStatus = OperationalStatus.Up) _
            .Sum(Function(nic) nic.GetIPv4Statistics().BytesReceived)
    End Function
    Public 网络适配器每秒发送 As Long
    Public 网络适配器每秒接收 As Long

    Public CPU性能计数器 As PerformanceCounter

    Private Sub Form服务器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetControlFont(Me)
        初始化网络适配器监视器()
        暗黑列表视图自绘制.绑定列表视图事件(ListView1)
        Me.UiTabControl1.ItemSize = New Size(100 * Form1.DPI, 50 * Form1.DPI)
        Me.ImageList1.ImageSize = New Size(1, 30 * Form1.DPI)
        Me.Label1.Text = $"{服务器.获取本地IPv4()}：{服务器.服务器端口}"
        顶部显示的地址端口 = Me.Label1.Text
        Me.UiSwitch2.Active = 服务器.广播任务.Status = TaskStatus.Running
        Me.UiTextBox1.Text = 服务器.服务器名称
        Me.UiTextBox2.Text = 服务器.服务器描述
        Me.UiSwitch1.Active = 服务器.是否允许新地址加入
        Me.UiSwitch3.Active = 服务器.开放单人数据位
        Select Case 服务器.玩家默认权限
            Case 服务器.玩家权限类型.普通玩家
                Me.UiComboBox6.SelectedIndex = 0
            Case 服务器.玩家权限类型.管理员
                Me.UiComboBox6.SelectedIndex = 1
            Case 服务器.玩家权限类型.超级管理员
                Me.UiComboBox6.SelectedIndex = 2
        End Select
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
        AddHandler 成员列表刷新计时器.Elapsed, AddressOf 刷新成员列表
        成员列表刷新计时器.Start()
    End Sub

    Private Async Sub Form服务器_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Await Task.Run(Sub() CPU性能计数器 = New PerformanceCounter("Process", "% Processor Time", Process.GetCurrentProcess().ProcessName, True))
    End Sub

    Private Sub Form服务器_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        调整界面()
    End Sub

    Private Sub Form服务器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim a As New 多项单选对话框("", {"确认关闭服务器", "取消"}, "确认关闭服务器？")
        If a.ShowDialog(Me) = 0 Then
            网络适配器监视器.Close()
            网络适配器监视器.Dispose()
            每秒刷新计时器.Close()
            每秒刷新计时器.Dispose()
            成员列表刷新计时器.Close()
            成员列表刷新计时器.Dispose()
            CPU性能计数器?.Close()
            CPU性能计数器?.Dispose()
            服务器.停止服务器()
            e.Cancel = False
        Else
            e.Cancel = True
            Exit Sub
        End If
    End Sub

    Private Sub UiTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UiTabControl1.SelectedIndexChanged
        调整界面()
    End Sub

    Sub 调整界面()
        Me.UiButton选中执行.Width = (Me.Panel21.Width - Me.Label12.Width * 4) * 0.2
        Me.UiButton全部执行.Width = Me.UiButton选中执行.Width
        Me.UiButton权限.Width = Me.UiButton选中执行.Width
        Me.UiButton移出.Width = Me.UiButton选中执行.Width
        Me.UiButton封禁.Width = Me.UiButton选中执行.Width
        Me.ListView1.Width = Me.ListView1.Parent.Width + SystemInformation.VerticalScrollBarWidth * Form1.DPI
        Me.ListView1.Columns(0).Width = Me.ListView1.Parent.Width * 0.3
        Me.ListView1.Columns(1).Width = Me.ListView1.Parent.Width * 0.2
        Me.ListView1.Columns(2).Width = Me.ListView1.Parent.Width * 0.2
        Me.ListView1.Columns(3).Width = Me.ListView1.Parent.Width * 0.3
    End Sub

    Public 顶部显示的地址端口 As String
    Public 玩家位置占用数量 As String = "0/0"

    Public 服务器上一秒发送总量 As Long = 0
    Public 服务器上一秒接收总量 As Long = 0

    Public 每秒刷新计时器 As New System.Timers.Timer With {.Interval = 1000}
    Public 成员列表刷新计时器 As New System.Timers.Timer With {.Interval = 3000}

    Sub 每秒刷新界面()
        Me.Invoke(Sub()
                      If Not 服务器.是否正在运行 Then Exit Sub
                      Dim 要显示的服务器发送速度 As String
                      Select Case 服务器.已发送字节 - 服务器上一秒发送总量
                          Case >= 1024 * 1024
                              要显示的服务器发送速度 = Format((服务器.已发送字节 - 服务器上一秒发送总量) / 1024 / 1024, "0.00") & " MB/s"
                          Case >= 1024
                              要显示的服务器发送速度 = Format((服务器.已发送字节 - 服务器上一秒发送总量) / 1024, "0.0") & " KB/s"
                          Case Else
                              要显示的服务器发送速度 = Format(服务器.已发送字节 - 服务器上一秒发送总量, "0") & " Byte/s"
                      End Select
                      服务器上一秒发送总量 = 服务器.已发送字节
                      Dim 要显示的服务器接收速度 As String
                      Select Case 服务器.已接收字节 - 服务器上一秒接收总量
                          Case >= 1024 * 1024
                              要显示的服务器接收速度 = Format((服务器.已接收字节 - 服务器上一秒接收总量) / 1024 / 1024, "0.00") & " MB/s"
                          Case >= 1024
                              要显示的服务器接收速度 = Format((服务器.已接收字节 - 服务器上一秒接收总量) / 1024, "0.0") & " KB/s"
                          Case Else
                              要显示的服务器接收速度 = Format(服务器.已接收字节 - 服务器上一秒接收总量, "0") & " Byte/s"
                      End Select
                      服务器上一秒接收总量 = 服务器.已接收字节
                      Dim 要显示的网络适配器发送速度 As String
                      Select Case 网络适配器每秒发送
                          Case >= 1024 * 1024
                              要显示的网络适配器发送速度 = Format(网络适配器每秒发送 / 1024 / 1024, "0.00") & " MB/s"
                          Case >= 1024
                              要显示的网络适配器发送速度 = Format(网络适配器每秒发送 / 1024, "0.0") & " KB/s"
                          Case Else
                              要显示的网络适配器发送速度 = 网络适配器每秒发送 & " Byte/s"
                      End Select
                      Dim 要显示的网络适配器接收速度 As String
                      Select Case 网络适配器每秒接收
                          Case >= 1024 * 1024
                              要显示的网络适配器接收速度 = Format(网络适配器每秒接收 / 1024 / 1024, "0.00") & " MB/s"
                          Case >= 1024
                              要显示的网络适配器接收速度 = Format(网络适配器每秒接收 / 1024, "0.0") & " KB/s"
                          Case Else
                              要显示的网络适配器接收速度 = 网络适配器每秒接收 & " Byte/s"
                      End Select

                      Me.Label1.Text = 顶部显示的地址端口 & "   " & 玩家位置占用数量 & "   ↑" & 要显示的服务器发送速度 & "   ↓" & 要显示的服务器接收速度
                      Me.Label21.Text = $"服务器消息 发送速度：{要显示的服务器发送速度}"
                      Me.Label22.Text = $"服务器消息 接收速度：{要显示的服务器接收速度}"
                      Me.Label23.Text = $"网络适配器 发送速度：{要显示的网络适配器发送速度}"
                      Me.Label25.Text = $"网络适配器 接收速度：{要显示的网络适配器接收速度}"
                      Me.Label3.Text = $"服务器发送总量：{服务器.已发送个数} 个 - {服务器.已发送字节} 字节"
                      Me.Label29.Text = $"服务器接收总量：{服务器.已接收个数} 个 - {服务器.已接收字节} 字节"

                      Try
                          If CPU性能计数器 IsNot Nothing Then
                              Me.UiRoundProcess1.Value = Math.Truncate(CPU性能计数器.NextValue)
                          Else
                              Me.UiRoundProcess1.Value = 0
                          End If
                      Catch ex As Exception
                          DebugPrint(ex.Message, Color.Tomato)
                      End Try

                      Dim 总内存 As Long = My.Computer.Info.TotalPhysicalMemory
                      Dim 可用内存 As Long = My.Computer.Info.AvailablePhysicalMemory
                      Dim 内存占用率 As Double = 1 - 可用内存 / 总内存
                      Me.UiRoundProcess2.Value = 内存占用率 * 100

                      If 服务器.最近处理时长.Count > 0 Then
                          Dim 平均处理时长 As Integer = 服务器.最近处理时长.Average
                          Me.UiRoundProcess3.Value = 平均处理时长
                          Me.UiRoundProcess3.Text = 平均处理时长 & "ms"
                      Else
                          Me.UiRoundProcess3.Value = 0
                      End If

                      Select Case Me.UiRoundProcess1.Value
                          Case > 90
                              Me.UiRoundProcess1.ProcessColor = Color.DarkRed
                          Case > 75
                              Me.UiRoundProcess1.ProcessColor = Color.DarkOrange
                          Case > 50
                              Me.UiRoundProcess1.ProcessColor = Color.DarkBlue
                          Case Else
                              Me.UiRoundProcess1.ProcessColor = Color.DarkGreen
                      End Select
                      Select Case Me.UiRoundProcess2.Value
                          Case > 90
                              Me.UiRoundProcess2.ProcessColor = Color.DarkRed
                          Case > 75
                              Me.UiRoundProcess2.ProcessColor = Color.DarkOrange
                          Case > 50
                              Me.UiRoundProcess2.ProcessColor = Color.DarkBlue
                          Case Else
                              Me.UiRoundProcess2.ProcessColor = Color.DarkGreen
                      End Select
                      Select Case Me.UiRoundProcess3.Value
                          Case > 750
                              Me.UiRoundProcess3.ProcessColor = Color.DarkRed
                          Case > 500
                              Me.UiRoundProcess3.ProcessColor = Color.DarkOrange
                          Case > 100
                              Me.UiRoundProcess3.ProcessColor = Color.DarkBlue
                          Case Else
                              Me.UiRoundProcess3.ProcessColor = Color.DarkGreen
                      End Select
                  End Sub)
    End Sub

    Sub 刷新成员列表()
        Me.Invoke(Sub()
                      Dim keys = 服务器.客户端列表.Keys.ToList()

                      ' 遍历字典中的每一项
                      For i As Integer = 0 To keys.Count - 1
                          Dim key = keys(i)
                          Dim client = 服务器.客户端列表(key)
                          Dim item As ListViewItem

                          If i < ListView1.Items.Count Then
                              item = ListView1.Items(i)
                              ' 更新显示信息
                              item.Name = key.ToString()
                              item.Text = key.ToString()
                              item.SubItems(1).Text = client.权限.ToString
                              If client.延迟 >= 服务器.自动踢出延迟 Then
                                  item.SubItems(2).Text = $"已超时 ({client.连续超时次数})"
                              Else
                                  item.SubItems(2).Text = client.延迟 & "ms"
                              End If
                              item.SubItems(3).Text = client.玩家所在主场景
                          Else
                              ' 创建一个新的项并添加
                              item = New ListViewItem(key.ToString()) With {.Name = key.ToString()}
                              item.SubItems.Add(client.权限.ToString)
                              If client.延迟 >= 服务器.自动踢出延迟 Then
                                  item.SubItems.Add($"已超时 ({client.连续超时次数})")
                              Else
                                  item.SubItems.Add(client.延迟 & "ms")
                              End If
                              item.SubItems.Add(client.玩家所在主场景)
                              ListView1.Items.Add(item)
                          End If
                      Next

                      ' 移除多余的项
                      While ListView1.Items.Count > keys.Count
                          ListView1.Items.RemoveAt(ListView1.Items.Count - 1)
                      End While
                  End Sub)
    End Sub

    Private Sub UiButton11_Click(sender As Object, e As EventArgs) Handles UiButton11.Click
        Me.Close()
    End Sub

    Private Async Sub UiSwitch2_Click(sender As Object, e As EventArgs) Handles UiSwitch2.Click
        Select Case UiSwitch2.Active
            Case True
                If 服务器.UDP广播 IsNot Nothing Then Exit Sub
                服务器.取消广播任务令牌源 = New CancellationTokenSource()
                服务器.UDP广播 = New Net.Sockets.UdpClient
                服务器.广播任务 = Task.Run(AddressOf 服务器.广播服务器游戏信息, 服务器.取消广播任务令牌源.Token)
            Case False
                If 服务器.取消广播任务令牌源 IsNot Nothing Then
                    服务器.取消广播任务令牌源.Cancel()
                    Await 服务器.广播任务
                    If 服务器.取消广播任务令牌源 IsNot Nothing Then
                        服务器.取消广播任务令牌源.Dispose()
                        服务器.取消广播任务令牌源 = Nothing
                    End If
                End If
                服务器.UDP广播?.Close()
                服务器.UDP广播 = Nothing
        End Select
    End Sub

    Private Sub UiButton5_Click(sender As Object, e As EventArgs) Handles UiButton5.Click
        服务器.服务器名称 = UiTextBox1.Text
        服务器.服务器描述 = UiTextBox2.Text
    End Sub

    Private Sub UiSwitch1_Click(sender As Object, e As EventArgs) Handles UiSwitch1.Click
        服务器.是否允许新地址加入 = UiSwitch1.Active
    End Sub

    Private Sub UiSwitch3_Click(sender As Object, e As EventArgs) Handles UiSwitch3.Click
        服务器.开放单人数据位 = UiSwitch3.Active
    End Sub

    Private Sub UiButton4_Click(sender As Object, e As EventArgs) Handles UiButton4.Click
        Select Case UiComboBox6.SelectedIndex
            Case 0
                服务器.玩家默认权限 = 服务器.玩家权限类型.普通玩家
            Case 1
                服务器.玩家默认权限 = 服务器.玩家权限类型.管理员
            Case 2
                服务器.玩家默认权限 = 服务器.玩家权限类型.超级管理员
        End Select
        Select Case UiComboBox8.SelectedIndex
            Case 0
                服务器.自动踢出延迟 = Integer.MaxValue
            Case 1
                服务器.自动踢出延迟 = 500
            Case 2
                服务器.自动踢出延迟 = 1000
            Case 3
                服务器.自动踢出延迟 = 2000
            Case 4
                服务器.自动踢出延迟 = 3000
        End Select
    End Sub

    Private Sub Form服务器_DpiChanged(sender As Object, e As DpiChangedEventArgs) Handles Me.DpiChanged

    End Sub

    Private Sub UiButton选中执行_Click(sender As Object, e As EventArgs) Handles UiButton选中执行.Click
        If ListView1.SelectedItems.Count = 0 Then Exit Sub
        If Me.UiComboBox1.SelectedIndex < 0 Then Exit Sub
        If Me.UiComboBox1.Text = "" Then Exit Sub
        For Each item In ListView1.SelectedItems
            Dim data As New List(Of String) From {Me.UiComboBox1.Text}
            For Each line In Me.UiTextBox3.Lines
                data.Add(line)
            Next
            服务器.发送消息(服务器.客户端列表(item.Name).IP, data)
        Next
    End Sub

    Private Sub UiButton全部执行_Click(sender As Object, e As EventArgs) Handles UiButton全部执行.Click
        If ListView1.Items.Count = 0 Then Exit Sub
        If Me.UiComboBox1.SelectedIndex < 0 Then Exit Sub
        If Me.UiComboBox1.Text = "" Then Exit Sub
        For Each item In ListView1.Items
            Dim data As New List(Of String) From {Me.UiComboBox1.Text}
            For Each line In Me.UiTextBox3.Lines
                data.Add(line)
            Next
            服务器.发送消息(服务器.客户端列表(item.Name).IP, data)
        Next
    End Sub

    Private Sub UiButton权限_Click(sender As Object, e As EventArgs) Handles UiButton权限.Click
        Dim a As New 暗黑菜单条控件本体
        AddHandler a.Items.Add("普通玩家").Click, Sub()
                                                  For Each item As ListViewItem In ListView1.SelectedItems
                                                      Dim ipPortParts = item.Text.Split(":"c)
                                                      服务器.客户端列表(New IPEndPoint(IPAddress.Parse(ipPortParts(0)), ipPortParts(1))).权限 = 服务器.玩家权限类型.普通玩家
                                                      item.SubItems(1).Text = "普通玩家"
                                                  Next
                                              End Sub
        AddHandler a.Items.Add("管理员").Click, Sub()
                                                 For Each item As ListViewItem In ListView1.SelectedItems
                                                     Dim ipPortParts = item.Text.Split(":"c)
                                                     服务器.客户端列表(New IPEndPoint(IPAddress.Parse(ipPortParts(0)), ipPortParts(1))).权限 = 服务器.玩家权限类型.管理员
                                                     item.SubItems(1).Text = "管理员"
                                                 Next
                                             End Sub
        AddHandler a.Items.Add("超级管理员").Click, Sub()
                                                   For Each item As ListViewItem In ListView1.SelectedItems
                                                       Dim ipPortParts = item.Text.Split(":"c)
                                                       服务器.客户端列表(New IPEndPoint(IPAddress.Parse(ipPortParts(0)), ipPortParts(1))).权限 = 服务器.玩家权限类型.超级管理员
                                                       item.SubItems(1).Text = "超级管理员"
                                                   Next
                                               End Sub
        a.Show(MousePosition)
    End Sub

    Private Sub UiButton移出_Click(sender As Object, e As EventArgs) Handles UiButton移出.Click
        Dim a As New 多项单选对话框("", {"确认移出", "取消"}, "确认移出选中的玩家？")
        If a.ShowDialog(Me) <> 0 Then Exit Sub
        For Each item As ListViewItem In ListView1.SelectedItems
            Dim ipPortParts = item.Text.Split(":"c)
            服务器.发送消息(New IPEndPoint(IPAddress.Parse(ipPortParts(0)), ipPortParts(1)), New List(Of String) From {"iw_sever_remove"})
            服务器.客户端列表.Remove(New IPEndPoint(IPAddress.Parse(ipPortParts(0)), ipPortParts(1)))
            item.Remove()
        Next
    End Sub

    Private Sub UiButton封禁_Click(sender As Object, e As EventArgs) Handles UiButton封禁.Click
        Dim a As New 多项单选对话框("", {"确认封禁", "取消"}, $"确认封禁选中玩家？{vbCrLf & vbCrLf}请详细了解这些：封禁文件位于 PlayerData\SeverBan.json，若要解封，请先关闭服务器，然后手动编辑 json 文件后再重启服务器。{vbCrLf & vbCrLf}关于内网穿透的远程客户端：如果该玩家通过内网穿透服务连接，则封禁是无效的，因为内网穿透的技术原理导致其地址是本机地址，封禁该地址等同于封禁本机，请从内网穿透服务、宣传途径、平台人员管理等途径进行安排，而不是在这里操作。{vbCrLf & vbCrLf}由于客户端每次启动都会随机一个新的端口，因此封禁是直接封禁 IP 地址，不管其端口，所以请谨慎决定封禁，避免误伤正常玩家。", 300, 500)
        If a.ShowDialog(Me) <> 0 Then Exit Sub
        For Each item As ListViewItem In ListView1.SelectedItems
            Dim ipPortParts = item.Text.Split(":"c)
            If Not 服务器.黑名单.Contains(ipPortParts(0)) Then 服务器.黑名单.Add(ipPortParts(0))
            服务器.发送消息(New IPEndPoint(ipPortParts(0), ipPortParts(1)), New List(Of String) From {"iw_sever_ban"})
            服务器.客户端列表.Remove(New IPEndPoint(IPAddress.Parse(ipPortParts(0)), ipPortParts(1)))
            item.Remove()
        Next
    End Sub



End Class