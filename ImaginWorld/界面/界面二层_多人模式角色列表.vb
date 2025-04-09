
Public Class 界面二层_多人模式角色列表

    Public 是否已初始化 As Boolean = False

    Private Sub 界面二层_多人模式角色列表_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetControlFont(Me)
        暗黑列表视图自绘制.绑定列表视图事件(ListView1)
        暗黑列表视图自绘制.绑定列表视图事件(ListView2)
        Me.Label1.Text = $"{客户端.接收到的玩家角色位信息表.服务器名称}   {客户端.服务器地址}   在线玩家 {客户端.接收到的玩家角色位信息表.玩家在线数量}/{客户端.接收到的玩家角色位信息表.所有玩家数量}   新角色空位 {客户端.接收到的玩家角色位信息表.可用于创建新玩家的殖民地列表.Count}"
        '将可登录的角色信息写入到列表视图1
        For Each item In 客户端.接收到的玩家角色位信息表.可登录的玩家列表
            Dim a As New ListViewItem($"玩家 {item.玩家名称}   最后场景 {item.最后的场景名称}   {If(item.是否有密码, "加密", "公开")}   据点 {item.拥有的殖民地数量}   角色 {item.远行队中的角色数量}")
            ListView1.Items.Add(a)
        Next
        '将可创建的角色信息写入到列表视图2
        For Each item In 客户端.接收到的玩家角色位信息表.可用于创建新玩家的殖民地列表
            Dim a As New ListViewItem($"{item}")
            ListView2.Items.Add(a)
        Next
        是否已初始化 = True
        调整界面()
    End Sub

    Private Sub UiButton1_Click(sender As Object, e As EventArgs) Handles UiButton1.Click
        客户端.发送消息(New List(Of String) From {"iw_client_disconnect"})
        客户端.停止客户端()
        Me.Dispose()
    End Sub

    Private Sub 界面二层_多人模式角色列表_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not 是否已初始化 Then Exit Sub
        If Me.ParentForm.WindowState = FormWindowState.Minimized Then Exit Sub
        调整界面()
    End Sub

    Public Sub 调整界面()
        Me.UiTabControl1.ItemSize = New Size(150 * Form1.DPI, 50 * Form1.DPI)
        界面控制.根据标签宽度计算并设置显示高度(Label15)
        界面控制.根据标签宽度计算并设置显示高度(Label14)
        界面控制.根据标签宽度计算并设置显示高度(Label11)
        Panel3.Width = 350 * Form1.DPI
        Me.ColumnHeader1.Width = Me.ListView1.Width
        Me.ColumnHeader2.Width = Me.ListView2.Width

    End Sub


End Class
