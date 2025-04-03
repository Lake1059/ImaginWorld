Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.Timers
Imports ImaginWorld.模组管理
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports Newtonsoft.Json
Imports Windows.System

Public Class 界面主层_主菜单

    Public 是否已初始化 As Boolean = False

    Private Sub 模板_主菜单_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetControlFont(Me)
        暗黑列表视图自绘制.绑定列表视图事件(ListView1)
        暗黑列表视图自绘制.绑定列表视图事件(ListView2)
        暗黑列表视图自绘制.绑定模组列表的列表视图事件(ListView3)
        暗黑列表视图自绘制.绑定模组列表的列表视图事件(ListView4)
        暗黑列表视图自绘制.绑定列表视图事件(ListView5)
        暗黑列表视图自绘制.绑定列表视图事件(ListView6)

        Label1.Text = "正在初始化主菜单数据 ..."
        Application.DoEvents()

        Me.UiComboBox13.Items.Clear()
        For Each item In 数据中心.所有背景音乐
            Me.UiComboBox13.Items.Add(item.Key)
        Next
        AddHandler Me.UiButton17.Click, Sub() 指令系统.切换BGM(New List(Of String) From {Me.UiComboBox13.Text})
        Me.UiComboBox16.Items.Clear()
        For Each item In 数据中心.所有特效声音
            Me.UiComboBox16.Items.Add(item.Key)
        Next
        AddHandler Me.UiButton19.Click, Sub() 声音控制.播放特效音(Me.UiComboBox16.Text)

        AddHandler UiButton重新扫描.Click, AddressOf 刷新模组列表
        AddHandler UiButton启用模组.Click, AddressOf 启用选中模组
        AddHandler UiButton禁用模组.Click, AddressOf 禁用所选模组
        AddHandler ListView3.DoubleClick, AddressOf 启用选中模组
        AddHandler ListView3.SelectedIndexChanged, Sub()
                                                       If ListView3.SelectedItems.Count <> 1 Then
                                                           重置模组信息显示()
                                                       Else
                                                           显示选中模组信息(未启用的模组列表(ListView3.SelectedIndices(0)), False)
                                                       End If
                                                   End Sub
        AddHandler ListView4.DoubleClick, AddressOf 禁用所选模组
        AddHandler ListView4.SelectedIndexChanged, Sub()
                                                       If ListView4.SelectedItems.Count <> 1 Then
                                                           重置模组信息显示()
                                                       Else
                                                           显示选中模组信息(已启用的模组列表(ListView4.SelectedIndices(0)), True)
                                                       End If
                                                   End Sub
        AddHandler ListView4.KeyDown, Sub(s1, e1)
                                          Select Case e1.KeyData
                                              Case Keys.W
                                                  上移模组()
                                              Case Keys.S
                                                  下移模组()
                                          End Select
                                      End Sub
        AddHandler UiButton打开文件夹.Click, Sub() Process.Start("explorer.exe", 当前正在查看的模组路径)

        AddHandler UiButton上移.Click, AddressOf 上移模组
        AddHandler UiButton下移.Click, AddressOf 下移模组
        AddHandler UiButton导入排序.Click, AddressOf 导入排序
        AddHandler UiButton导出排序.Click, AddressOf 导出排序
        AddHandler UiButton应用模组排序并重启.Click, AddressOf 应用模组排序并重启
        AddHandler UiButton取消订阅选中模组.Click, AddressOf 取消订阅
        AddHandler UiButton在创意工坊中查看.Click, AddressOf 在创意工坊中查看
        AddHandler LinkLabel4.LinkClicked, Async Sub() Await Launcher.LaunchUriAsync(New Uri("https://steamcommunity.com/sharedfiles/workshoplegalagreement"))
        AddHandler UiButton打开创意工坊.Click, Async Sub() Await Launcher.LaunchUriAsync(New Uri("https://steamcommunity.com/app/2577690/workshop"))
        AddHandler UiButton转到教程页.Click, Async Sub() Await Launcher.LaunchUriAsync(New Uri("https://steamcommunity.com/sharedfiles/filedetails/?id=3030078761"))
        AddHandler UiButtonKOOK频道.Click, Async Sub() Await Launcher.LaunchUriAsync(New Uri("https://kook.top/C7XWyz"))
        AddHandler UiButton开发者群.Click, Async Sub() Await Launcher.LaunchUriAsync(New Uri("https://qm.qq.com/cgi-bin/qm/qr?k=Q9iyczf0U4Vevro4YX-x1kczATQDLbHq&jump_from=webapi&authKey=Q8CIt3aEn+mltj2NjnLTJiku6T7GUAgGysyfkQ2W7q0a3wDcXbyWismuKSlViek4"))

        AddHandler UiButton7.Click, Async Sub() Await Launcher.LaunchUriAsync(New Uri("https://steamcommunity.com/id/1059Studio/"))
        AddHandler UiButton8.Click, Async Sub() Await Launcher.LaunchUriAsync(New Uri("https://space.bilibili.com/319785096"))
        AddHandler UiButton10.Click, Async Sub() Await Launcher.LaunchUriAsync(New Uri("https://github.com/Lake1059/ImaginWorld"))

        AddHandler Me.UiButton9.Click, Sub() 界面控制.切换界面(界面控制.主界面图层.主层, New 界面主层_殖民地)



        AddHandler Me.UiButton22.Click, Sub() 界面控制.显示控制台()
        AddHandler Me.UiButton上传创意工坊.Click, AddressOf 上传创意工坊
        初始化设置选项卡内容()

        AddHandler Me.UiButton15.Click, AddressOf 保存设置

        AddHandler Me.UiButton11.Click, AddressOf 启动服务器
        AddHandler Me.UiButton16.Click, AddressOf 保存服务器选项卡设置
        AddHandler Me.UiButton14.Click, AddressOf 开始寻找广播服务器
        AddHandler Me.UiButton13.Click, AddressOf 连接选中的服务器
        AddHandler Me.ListView6.DoubleClick, Sub() If Me.ListView6.SelectedItems.Count = 1 Then 连接选中的服务器()
        AddHandler Me.UiButton12.Click, AddressOf 连接自定义输入的服务器

        Me.ImageList1.ImageSize = New Size(1, 35 * Form1.DPI)
        Me.ImageList2.ImageSize = New Size(1, 30 * Form1.DPI)
        调整界面()
        Me.Label1.Text = $"ImaginWorld Dev3 - 已加载 {模组管理.实际加载的模组列表.Count} 个模组 - {If(状态信息.Steam_是否完成了初始化, "Steamworks 已连接", "Steamworks 未连接")}"
        Me.PictureBox2.Image = LoadImageFromFile(Path.Combine(Application.StartupPath, "Image", "FinalTown.png"))
        'Me.PictureBox3.Image = LoadImageFromFile(Path.Combine(Application.StartupPath, "Image", "UnderJourney.png"))

        界面控制.根据标签宽度计算并设置显示高度(Me.Label69)
        界面控制.根据标签宽度计算并设置显示高度(Me.Label85)
        界面控制.根据标签宽度计算并设置显示高度(Me.Label131)
        界面控制.根据标签宽度计算并设置显示高度(Me.Label79)
        界面控制.根据标签宽度计算并设置显示高度(Me.Label116)

        Me.UiComboBox1.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox2.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox3.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox4.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox5.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox6.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox7.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox8.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox9.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox10.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox11.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox12.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox13.ItemHeight = 30 * Form1.DPI
        Me.UiComboBox14.ItemHeight = 30 * Form1.DPI
        Me.UiCheckBox1.CheckBoxSize = 25 * Form1.DPI
        Me.UiCheckBox2.CheckBoxSize = 23 * Form1.DPI
        Me.UiCheckBox3.CheckBoxSize = 23 * Form1.DPI
        Me.UiCheckBox4.CheckBoxSize = 23 * Form1.DPI
        Me.UiTrackBar1.BarSize = 20 * Form1.DPI
        Me.UiTrackBar2.BarSize = 20 * Form1.DPI
        Me.UiTrackBar3.BarSize = 20 * Form1.DPI
        Me.UiTrackBar4.BarSize = 20 * Form1.DPI
        Me.UiTrackBar5.BarSize = 20 * Form1.DPI
        是否已初始化 = True
        If 声音控制.特效声音输出设备 Is Nothing Then
            If 数据中心.所有背景音乐.ContainsKey("MainTheme") Then
                声音控制.切换BGM("MainTheme")
            Else
                声音控制.自动选择下一首BGM进行播放(True)
            End If
        Else
            声音控制.自动选择下一首BGM进行播放(True)
        End If

    End Sub
    Private Sub 模板_主菜单_DpiChangedAfterParent(sender As Object, e As EventArgs) Handles Me.DpiChangedAfterParent
        调整界面()
    End Sub
    Private Sub 模板_主菜单_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not 是否已初始化 Then Exit Sub
        If Me.ParentForm.WindowState = FormWindowState.Minimized Then Exit Sub
        调整界面()
    End Sub

    Public Sub 调整界面()
        Me.UiTabControlMenu1.ItemSize = New Size(151 * Form1.DPI, 50 * Form1.DPI)
        调整选项卡页面()
    End Sub

    Public Sub 调整选项卡页面()
        Dim 子选项卡 As TabPage = Me.UiTabControlMenu1.SelectedTab
        Select Case True
            Case 子选项卡.IsEqual(TabPage欢迎)
                Panel模组管理顶部功能区.Visible = False
                Panel73.Width = (Panel73.Parent.Width - Panel73.Parent.Padding.Left * 2) * 0.5
            Case 子选项卡.IsEqual(TabPage新游戏)
                Panel模组管理顶部功能区.Visible = False
            Case 子选项卡.IsEqual(TabPage载入存档)
                Panel模组管理顶部功能区.Visible = False
                Panel22.Width = Panel22.Parent.Width * 0.2
                Panel18.Width = Panel18.Parent.Width * 0.4
                Me.ListView1.Width = Me.ListView1.Parent.Width + SystemInformation.VerticalScrollBarWidth * Form1.DPI
                Me.ListView1.Columns(0).Width = Me.ListView1.Parent.Width
                Me.ListView2.Width = Me.ListView2.Parent.Width + SystemInformation.VerticalScrollBarWidth * Form1.DPI
                Me.ListView2.Columns(0).Width = Me.ListView2.Parent.Width
            Case 子选项卡.IsEqual(TabPage服务器)
                Panel模组管理顶部功能区.Visible = False
            Case 子选项卡.IsEqual(TabPage连接主机)
                Panel模组管理顶部功能区.Visible = False
                Me.ListView6.Width = Me.ListView6.Parent.Width + SystemInformation.VerticalScrollBarWidth * Form1.DPI
                Me.ListView6.Columns(0).Width = Me.ListView6.Parent.Width * 0.2
                Me.ListView6.Columns(1).Width = Me.ListView6.Parent.Width * 0.1
                Me.ListView6.Columns(2).Width = Me.ListView6.Parent.Width * 0.2
                Me.ListView6.Columns(3).Width = Me.ListView6.Parent.Width * 0.3
                Me.ListView6.Columns(4).Width = Me.ListView6.Parent.Width * 0.2
                Me.Label103.Text = "或使用双击来连接"
            Case 子选项卡.IsEqual(TabPage模组)
                Panel模组管理顶部功能区.Visible = True
                Panel24.Width = Panel24.Parent.Width * 0.35
                Panel26.Width = Panel26.Parent.Width * 0.35
                Me.ListView3.Width = Me.ListView3.Parent.Width + SystemInformation.VerticalScrollBarWidth * Form1.DPI
                Me.ListView3.Columns(0).Width = Me.ListView3.Parent.Width
                Me.ListView4.Width = Me.ListView4.Parent.Width + SystemInformation.VerticalScrollBarWidth * Form1.DPI
                Me.ListView4.Columns(0).Width = Me.ListView4.Parent.Width
                PictureBox1.Height = PictureBox1.Width
            Case 子选项卡.IsEqual(TabPage模组设置)
                Panel模组管理顶部功能区.Visible = False
            Case 子选项卡.IsEqual(TabPage游戏设置)
                Panel模组管理顶部功能区.Visible = False
            Case 子选项卡.IsEqual(TabPageDLC)
                Panel模组管理顶部功能区.Visible = False
            Case 子选项卡.IsEqual(TabPage创意工坊)
                Panel模组管理顶部功能区.Visible = False
                Me.ListView5.Width = Me.ListView5.Parent.Width + SystemInformation.VerticalScrollBarWidth * Form1.DPI
                Me.ListView5.Columns(0).Width = Me.ListView5.Parent.Width
            Case 子选项卡.IsEqual(TabPage关于)
                Panel模组管理顶部功能区.Visible = False
        End Select
    End Sub
    Private Sub UiTabControlMenu1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UiTabControlMenu1.SelectedIndexChanged
        Dim 子选项卡 As TabPage = Me.UiTabControlMenu1.SelectedTab
        Select Case True
            Case 子选项卡.IsEqual(TabPage欢迎)
                调整选项卡页面()
            Case 子选项卡.IsEqual(TabPage新游戏)
                调整选项卡页面()
            Case 子选项卡.IsEqual(TabPage载入存档)
                调整选项卡页面()
            Case 子选项卡.IsEqual(TabPage服务器)
                调整选项卡页面()
            Case 子选项卡.IsEqual(TabPage连接主机)
                调整选项卡页面()
            Case 子选项卡.IsEqual(TabPage模组)
                调整选项卡页面()
                If Me.ListView3.Items.Count = 0 And Me.ListView4.Items.Count = 0 Then 刷新模组列表()
            Case 子选项卡.IsEqual(TabPage模组设置)
                调整选项卡页面()
            Case 子选项卡.IsEqual(TabPage游戏设置)
                调整选项卡页面()
            Case 子选项卡.IsEqual(TabPageDLC)
                调整选项卡页面()
            Case 子选项卡.IsEqual(TabPage创意工坊)
                调整选项卡页面()
                Me.ListView5.Items.Clear()
                Dim a As New List(Of String)(GetDirectories(Path.Combine(Application.StartupPath, "Mods")))
                For Each ModString In a
                    Me.ListView5.Items.Add(Path.GetFileName(ModString))
                    If FileExists(Path.Combine(ModString, "SteamWorkShopId")) Then
                        Me.ListView5.Items(Me.ListView5.Items.Count - 1).ForeColor = Color.ForestGreen
                    End If
                    If Not FileExists(Path.Combine(ModString, "Manifest.json")) Then
                        Me.ListView5.Items(Me.ListView5.Items.Count - 1).ForeColor = Color.Tomato
                    End If
                Next
            Case 子选项卡.IsEqual(TabPage关于)
                调整选项卡页面()
        End Select
    End Sub

#Region "设置"
    Sub 初始化设置选项卡内容()
        Dim 字体列表 As New List(Of String)
        For Each 字体 As FontFamily In FontFamily.Families
            字体列表.Add(字体.Name)
        Next
        字体列表.Sort()
        Me.UiComboBox2.Items.AddRange(字体列表.ToArray)

        AddHandler UiTrackBar1.ValueChanged, Sub(s1, e1)
                                                 Label4.Text = s1.Value
                                                 If 声音控制.BGM输出设备 IsNot Nothing Then
                                                     声音控制.BGM音量控制器.Volume = s1.Value / 100
                                                 End If
                                             End Sub
        AddHandler UiTrackBar2.ValueChanged, Sub(s1, e1)
                                                 Label9.Text = s1.Value
                                                 If 声音控制.特效声音输出设备 IsNot Nothing Then
                                                     声音控制.特效声音音量控制器.Volume = s1.Value / 100
                                                 End If
                                             End Sub
        AddHandler UiTrackBar3.ValueChanged, Sub(s1, e1) Label11.Text = s1.Value
        AddHandler UiTrackBar4.ValueChanged, Sub(s1, e1) Label13.Text = s1.Value
        AddHandler UiTrackBar5.ValueChanged, Sub(s1, e1) Label17.Text = s1.Value

        Select Case 游戏设置.实例对象.GameLanguage
            Case "zh"
                UiComboBox1.Text = "简体中文"
            Case "en"
                UiComboBox1.Text = "English"
        End Select
        UiComboBox2.Text = 游戏设置.实例对象.Font
        UiComboBox3.Text = 游戏设置.实例对象.WindowSize.Width & "x" & 游戏设置.实例对象.WindowSize.Height
        UiCheckBox1.Checked = 游戏设置.实例对象.FullScreenNoBorders
        UiTrackBar1.Value = 游戏设置.实例对象.BgmVolume * 100
        UiTrackBar2.Value = 游戏设置.实例对象.EsVolume * 100
        UiTrackBar3.Value = 游戏设置.实例对象.ColonyCalculationThreads
        UiTrackBar4.Value = 游戏设置.实例对象.WorldStateCalculationThreads
        UiTrackBar5.Value = 游戏设置.实例对象.RandomEventsTriggerCalculationThreads
        UiComboBox12.SelectedIndex = 游戏设置.实例对象.BattleModeSelection
        UiComboBox14.SelectedIndex = 游戏设置.实例对象.PlotDisplayDirection

        UiTextBox4.Text = 游戏设置.实例对象.Sever_Port
        UiTextBox5.Text = 游戏设置.实例对象.Sever_Name
        UiTextBox6.Text = 游戏设置.实例对象.Sever_Description
        UiComboBox6.SelectedIndex = 游戏设置.实例对象.Sever_DefaultPermission
        UiComboBox8.SelectedIndex = 游戏设置.实例对象.Sever_MaxPing
        UiComboBox9.SelectedIndex = 游戏设置.实例对象.Sever_Broadcast
        UiComboBox10.SelectedIndex = 游戏设置.实例对象.Sever_AllowedConnection
        UiComboBox11.SelectedIndex = 游戏设置.实例对象.Sever_MessageProcessMultithread
        UiComboBox7.SelectedIndex = 游戏设置.实例对象.Sever_OpenSinglePlayerLocation
        UiComboBox15.SelectedIndex = 游戏设置.实例对象.Client_MessageProcessMultithread
        UiTextBox3.Text = 游戏设置.实例对象.ConnectSever_IP
        UiTextBox7.Text = 游戏设置.实例对象.ConnectSever_Port
    End Sub

    Sub 保存设置()
        Select Case UiComboBox1.SelectedIndex
            Case 0
                游戏设置.实例对象.GameLanguage = "zh"
            Case 1
                游戏设置.实例对象.GameLanguage = "en"
        End Select
        游戏设置.实例对象.Font = UiComboBox2.Text
        游戏设置.实例对象.WindowSize = New Size(UiComboBox3.Text.Split("x"c)(0), UiComboBox3.Text.Split("x"c)(1))
        游戏设置.实例对象.FullScreenNoBorders = UiCheckBox1.Checked
        游戏设置.实例对象.BgmVolume = UiTrackBar1.Value / 100
        游戏设置.实例对象.EsVolume = UiTrackBar2.Value / 100
        游戏设置.实例对象.ColonyCalculationThreads = UiTrackBar3.Value
        游戏设置.实例对象.WorldStateCalculationThreads = UiTrackBar4.Value
        游戏设置.实例对象.RandomEventsTriggerCalculationThreads = UiTrackBar5.Value
        游戏设置.实例对象.BattleModeSelection = UiComboBox12.SelectedIndex
        游戏设置.实例对象.PlotDisplayDirection = UiComboBox14.SelectedIndex
        游戏设置.保存()
        SetControlFont(Me)
        SetControlFont(控制台界面实例, {控制台界面实例.RichTextBox1})
        Form1.ClientSize = 游戏设置.实例对象.WindowSize
    End Sub

#End Region

#Region "模组管理"
    Dim 未启用的模组列表 As New List(Of String)
    Dim 已启用的模组列表 As New List(Of String)

    Async Sub 刷新模组列表()
        If 已启用的模组列表.Count = 0 Then 已启用的模组列表 = 模组管理.实际加载的模组列表
        Await Task.Run(Sub() 模组管理.重新扫描模组())
        未启用的模组列表.Clear()
        Me.ListView3.Items.Clear()
        重置模组信息显示()
        Application.DoEvents()

        If 已启用的模组列表.Count > 0 Then
            Dim i As Integer = 0
            Do Until i = 已启用的模组列表.Count
                If Not 模组管理.临时所有模组列表.ContainsKey(已启用的模组列表(i)) Then
                    已启用的模组列表.RemoveAt(i)
                    i -= 1
                End If
                i += 1
            Loop
            Me.ListView4.Items.Clear()
            For Each ModString In 已启用的模组列表
                Me.ListView4.Items.Add(模组管理.临时所有模组列表(ModString).ModName)
                Me.ListView4.Items(Me.ListView4.Items.Count - 1).Tag = ModString.Split("."c)(0)
            Next
        Else
            Me.ListView4.Items.Clear()
        End If

        Dim modKeys = 模组管理.临时所有模组列表.Keys.ToList()
        For Each ModString In modKeys
            If Not 模组管理.实际加载的模组列表.Contains(ModString) Then
                Me.ListView3.Items.Add(模组管理.临时所有模组列表(ModString).ModName)
                Me.ListView3.Items(Me.ListView3.Items.Count - 1).Tag = ModString.Split("."c)(0)
                未启用的模组列表.Add(ModString)
            End If
        Next
        检查模组依赖_仅反映到列表视图()
    End Sub

    Sub 重置模组信息显示()
        当前正在查看的模组路径 = ""
        PictureBox1.Image = Nothing
        Label模组名称.Text = ""
        Label作者.Text = ""
        LabelUniqueID.Text = ""
        Label模组安装错误信息.Text = ""
        Label模组安装错误信息.Visible = False
        Label简介.Text = ""
        UiButton在创意工坊中查看.Visible = False
        GC.Collect()
    End Sub

    Dim 当前正在查看的模组路径 As String

    Sub 显示选中模组信息(ModString As String, Installed As Boolean)
        重置模组信息显示()
        当前正在查看的模组路径 = 模组管理.临时所有模组列表(ModString).ModPath
        Dim 封面图路径 = Path.Combine(模组管理.临时所有模组列表(ModString).ModPath, "Cover.jpg")
        If FileExists(封面图路径) Then
            PictureBox1.Image = LoadImageFromFile(封面图路径)
            PictureBox1.Visible = True
        Else
            PictureBox1.Image = Nothing
            PictureBox1.Visible = False
        End If
        Label模组名称.Text = 模组管理.临时所有模组列表(ModString).ModName
        Label作者.Text = 模组管理.临时所有模组列表(ModString).Version & " - " & 模组管理.临时所有模组列表(ModString).Author
        LabelUniqueID.Text = 模组管理.临时所有模组列表(ModString).UniqueID
        界面控制.根据标签宽度计算并设置显示高度(Label模组名称)
        界面控制.根据标签宽度计算并设置显示高度(Label作者)
        界面控制.根据标签宽度计算并设置显示高度(LabelUniqueID)

        Dim 是否有安装错误 As Boolean = False
        If Installed Then
            For Each ModString In 模组管理.临时所有模组列表(ModString).Dependencies
                Dim prefixList As String() = {"DLC.", "SteamWorkShop.", "Local."}
                If Not prefixList.Any(Function(prefix) 已启用的模组列表.Contains(prefix & ModString)) Then
                    If Label模组安装错误信息.Text = "" Then
                        Label模组安装错误信息.Text = "未安装依赖：" & 模组管理.临时所有模组列表(ModString).UniqueID
                    Else
                        Label模组安装错误信息.Text &= vbCrLf & "未安装依赖：" & 模组管理.临时所有模组列表(ModString).UniqueID
                    End If
                    是否有安装错误 = True
                End If
            Next
            If 是否有安装错误 Then
                Label模组安装错误信息.Visible = True
                界面控制.根据标签宽度计算并设置显示高度(Label模组安装错误信息)
            Else
                Label模组安装错误信息.Visible = False
            End If
        Else
            Label模组安装错误信息.Visible = False
        End If

        Label简介.Text = 模组管理.临时所有模组列表(ModString).Description

        Dim 创意工坊ID文件路径 = Path.Combine(当前正在查看的模组路径, "SteamWorkShopId")
        If FileExists(创意工坊ID文件路径) Then
            UiButton在创意工坊中查看.Visible = True
        End If
    End Sub

    Sub 检查模组依赖_仅反映到列表视图()
        For i = 0 To 已启用的模组列表.Count - 1
            For Each 依赖项 In 模组管理.临时所有模组列表(已启用的模组列表(i)).Dependencies
                Dim prefixList As String() = {"DLC.", "SteamWorkShop.", "Local."}
                If Not prefixList.Any(Function(prefix) 已启用的模组列表.Contains(prefix & 依赖项)) Then
                    Me.ListView4.Items(i).ForeColor = Color.Tomato
                    Exit For
                End If
            Next
        Next
    End Sub

    Sub 上移模组()
        If Me.ListView4.SelectedIndices.Count > 0 Then
            For i = 0 To Me.ListView4.SelectedIndices.Count - 1
                Dim index As Integer = Me.ListView4.SelectedIndices(i)
                If index > 0 Then
                    If Me.ListView4.SelectedIndices.Contains(index - 1) Then Continue For
                    Dim 变动排序的列表视图项 As ListViewItem = Me.ListView4.Items(index)
                    Me.ListView4.Items.RemoveAt(index)
                    Me.ListView4.Items.Insert(index - 1, 变动排序的列表视图项)
                    Me.ListView4.Items(index - 1).Focused = True
                    Dim 变动排序的文本 As String = 已启用的模组列表(index)
                    已启用的模组列表.RemoveAt(index)
                    已启用的模组列表.Insert(index - 1, 变动排序的文本)
                End If
            Next
            检查模组依赖_仅反映到列表视图()
        End If
    End Sub

    Sub 下移模组()
        If Me.ListView4.SelectedIndices.Count > 0 Then
            For i = Me.ListView4.SelectedIndices.Count - 1 To 0 Step -1
                Dim index As Integer = Me.ListView4.SelectedIndices(i)
                If index < Me.ListView4.Items.Count - 1 Then
                    If Me.ListView4.SelectedIndices.Contains(index + 1) Then Continue For
                    Dim 变动排序的列表视图项 As ListViewItem = Me.ListView4.Items(index)
                    Me.ListView4.Items.RemoveAt(index)
                    Me.ListView4.Items.Insert(index + 1, 变动排序的列表视图项)
                    Me.ListView4.Items(index + 1).Focused = True
                    Dim 变动排序的文本 As String = 已启用的模组列表(index)
                    已启用的模组列表.RemoveAt(index)
                    已启用的模组列表.Insert(index + 1, 变动排序的文本)
                End If
            Next
            检查模组依赖_仅反映到列表视图()
        End If
    End Sub

    Sub 启用选中模组()
        If Me.ListView3.SelectedItems.Count = 0 Then Exit Sub
        Dim i As Integer = 0
        Do Until i = Me.ListView3.Items.Count
            If Me.ListView3.Items(i).Selected Then
                Me.ListView4.Items.Add(模组管理.临时所有模组列表(未启用的模组列表(i)).ModName)
                Me.ListView4.Items(Me.ListView4.Items.Count - 1).Tag = Me.ListView3.Items(i).Tag
                已启用的模组列表.Add(未启用的模组列表(i))
                Me.ListView3.Items(i).Remove()
                未启用的模组列表.RemoveAt(i)
                i -= 1
            End If
            i += 1
        Loop
        检查模组依赖_仅反映到列表视图()
    End Sub

    Sub 禁用所选模组()
        If Me.ListView4.SelectedItems.Count = 0 Then Exit Sub
        Dim i As Integer = 0
        Do Until i = Me.ListView4.Items.Count
            If Me.ListView4.Items(i).Selected Then
                Me.ListView3.Items.Add(模组管理.临时所有模组列表(已启用的模组列表(i)).ModName)
                Me.ListView3.Items(Me.ListView3.Items.Count - 1).Tag = Me.ListView4.Items(i).Tag
                Me.ListView3.Items(Me.ListView3.Items.Count - 1).ForeColor = Me.ListView3.ForeColor
                未启用的模组列表.Add(已启用的模组列表(i))
                Me.ListView4.Items(i).Remove()
                已启用的模组列表.RemoveAt(i)
                i -= 1
            End If
            i += 1
        Loop
        检查模组依赖_仅反映到列表视图()
    End Sub

    Sub 应用模组排序并重启()
        Dim 排序文件路径 = Path.Combine(Application.StartupPath, "PlayerData", "ModsSort.json")
        WriteAllText(排序文件路径, JsonConvert.SerializeObject(已启用的模组列表), False)
        Application.Restart()
    End Sub
    Sub 导入排序()
        Dim a As New OpenFileDialog With {.AddExtension = True, .Filter = "JSON|*.json"}
        If a.ShowDialog(Form1) = DialogResult.OK Then
            Dim 读取到的排序 As New List(Of String)
            Try
                读取到的排序 = JsonConvert.DeserializeObject(Of List(Of String))(ReadAllText(a.FileName))
            Catch ex As Exception
                DebugPrint($"加载模组排序失败：{ex.Message}", Color.Tomato)
                界面控制.切换界面(界面控制.主界面图层.顶层, 控制台界面实例)
            End Try
            If 读取到的排序.Count > 0 Then
                已启用的模组列表 = 读取到的排序
                刷新模组列表()
            End If
        End If
    End Sub

    Sub 导出排序()
        Dim a As New SaveFileDialog With {.AddExtension = True, .Filter = "JSON|*.json"}
        If a.ShowDialog(Form1) = DialogResult.OK Then
            WriteAllText(a.FileName, JsonConvert.SerializeObject(已启用的模组列表), False)
        End If
    End Sub

    Sub 取消订阅()
        Dim 要取消订阅的模组的创意工坊ID As New List(Of String)
        Dim 要取消订阅的模组的名称 As New List(Of String)
        For i = 0 To Me.ListView3.Items.Count - 1
            If Not Me.ListView3.Items(i).Selected Then Continue For
            Dim 创意工坊ID文件路径 = Path.Combine(模组管理.临时所有模组列表(未启用的模组列表(i)).ModPath, "SteamWorkShopId")
            If FileExists(创意工坊ID文件路径) Then
                要取消订阅的模组的创意工坊ID.Add(ReadAllText(创意工坊ID文件路径))
            Else
                Continue For
            End If
            要取消订阅的模组的名称.Add(模组管理.临时所有模组列表(未启用的模组列表(i)).ModName)
        Next

        Dim a As String = ""
        For i = 0 To 要取消订阅的模组的创意工坊ID.Count - 1
            If a = "" Then
                a = 要取消订阅的模组的名称(i) & " (" & 要取消订阅的模组的创意工坊ID(i) & ")"
            Else
                a &= vbCrLf & 要取消订阅的模组的名称(i) & " (" & 要取消订阅的模组的创意工坊ID(i) & ")"
            End If
        Next
        If MsgBox("取消订阅以下模组？" & vbCrLf & vbCrLf & a, MsgBoxStyle.OkCancel) <> MsgBoxResult.Ok Then Exit Sub

        For Each 创意工坊ID In 要取消订阅的模组的创意工坊ID
            Dim 创意工坊ID数字 As ULong = 创意工坊ID
            创意工坊.取消订阅创意工坊物品(创意工坊ID数字)
            Application.DoEvents()
        Next

        重新扫描模组()
    End Sub

    Async Sub 在创意工坊中查看()
        Dim 创意工坊ID文件路径 = Path.Combine(当前正在查看的模组路径, "SteamWorkShopId")
        If FileExists(创意工坊ID文件路径) Then
            Await Launcher.LaunchUriAsync(New Uri($"https://steamcommunity.com/sharedfiles/filedetails/?id={ReadAllText(创意工坊ID文件路径)}"))
        End If
    End Sub

#End Region

#Region "创意工坊"
    Sub 上传创意工坊()
        If Me.ListView5.SelectedItems.Count <> 1 Then Exit Sub
        Dim m1 As New 多项单选对话框("", {"确认上传", "取消"}, "确认上传选中的模组到创意工坊？")
        If m1.ShowDialog(Form1) <> 0 Then Exit Sub
        Dim a As New 创意工坊
        a.上传(Me.ListView5.SelectedItems(0).Text)
        界面控制.切换界面(界面控制.主界面图层.顶层, 控制台界面实例)
    End Sub

#End Region

#Region "服务器"
    Sub 启动服务器()
        If 服务器.是否正在运行 Then
            Dim a1 As New 多项单选对话框("", {"了解"}, "服务器正在运行中，若要关闭服务器请在服务器管理窗口上操作！")
            a1.ShowDialog(Form1)
            Exit Sub
        End If
        Dim a As New 多项单选对话框("", {"确认启动", "取消"}, "确认启动服务器？")
        If a.ShowDialog(Form1) <> 0 Then Exit Sub
        服务器.服务器端口 = If(Me.UiTextBox4.Text = "", Me.UiTextBox4.Watermark, Me.UiTextBox4.Text)
        服务器.服务器名称 = If(Me.UiTextBox5.Text = "", Me.UiTextBox5.Watermark, Me.UiTextBox5.Text)
        服务器.服务器描述 = If(Me.UiTextBox6.Text = "", Me.UiTextBox6.Watermark, Me.UiTextBox6.Text)
        Select Case Me.UiComboBox6.SelectedIndex
            Case 0
                服务器.玩家默认权限 = 服务器.玩家权限类型.普通玩家
            Case 1
                服务器.玩家默认权限 = 服务器.玩家权限类型.管理员
            Case 2
                服务器.玩家默认权限 = 服务器.玩家权限类型.超级管理员
            Case Else
                服务器.玩家默认权限 = 服务器.玩家权限类型.普通玩家
        End Select
        Select Case Me.UiComboBox8.SelectedIndex
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
            Case Else
                服务器.自动踢出延迟 = Integer.MaxValue
        End Select
        Select Case Me.UiComboBox9.SelectedIndex
            Case 0
                服务器.自动开始广播 = True
            Case 1
                服务器.自动开始广播 = False
            Case Else
                服务器.自动开始广播 = True
        End Select
        Select Case Me.UiComboBox10.SelectedIndex
            Case 0
                服务器.是否允许新地址加入 = True
            Case 1
                服务器.是否允许新地址加入 = False
            Case Else
                服务器.是否允许新地址加入 = True
        End Select
        Select Case Me.UiComboBox10.SelectedIndex
            Case 0
                服务器.响应线程数量 = 1
            Case 1
                服务器.响应线程数量 = 2
            Case 2
                服务器.响应线程数量 = 4
            Case 3
                服务器.响应线程数量 = 8
            Case 4
                服务器.响应线程数量 = 16
            Case 5
                服务器.响应线程数量 = 32
            Case 6
                服务器.响应线程数量 = 64
            Case 7
                服务器.响应线程数量 = 128
            Case Else
                服务器.响应线程数量 = 1
        End Select
        服务器.开放单人数据位 = Me.UiComboBox7.SelectedIndex = 1
        服务器.启动服务器()
    End Sub

    Private 广播接收端 As UdpClient
    Private 广播接收任务 As Task
    Private 广播接收任务取消令牌源 As CancellationTokenSource
    Private 广播接收计时器 As Timers.Timer

    Sub 开始寻找广播服务器()
        Try
            Me.ListView6.Items.Clear()
            广播接收端 = New UdpClient(1059)
            广播接收端.Client.ReceiveTimeout = 1000
            广播接收任务取消令牌源 = New CancellationTokenSource
            广播接收任务 = Task.Run(AddressOf 寻找广播服务器, 广播接收任务取消令牌源.Token)
            广播接收计时器 = New Timers.Timer(10000)
            AddHandler 广播接收计时器.Elapsed, AddressOf 停止寻找广播服务器
            广播接收计时器.AutoReset = False
            广播接收计时器.Start()
            Me.UiButton14.Enabled = False
        Catch ex As Exception
            DebugPrint(ex.Message, Color.Tomato)
        End Try
    End Sub

    Sub 寻找广播服务器()
        UI同步上下文.Post(Sub() Label101.Text = "正在你的本地网络中搜索游戏 ...", Nothing)
        While True AndAlso Not 广播接收任务取消令牌源.Token.IsCancellationRequested
            Try
                Dim remoteEndPoint As New IPEndPoint(IPAddress.Any, 1059)
                Dim data = 广播接收端.Receive(remoteEndPoint)
                Dim message = Encoding.UTF8.GetString(data)
                If message.StartsWith("ImaginWorldSever") Then
                    Dim severinfo As New List(Of String)(message.Split("|"c))
                    UI同步上下文.Post(Sub() 向服务器列表添加信息(severinfo), Nothing)
                End If
                If 广播接收计时器.Enabled = False Then Exit While
            Catch ex As SocketException When ex.SocketErrorCode = SocketError.TimedOut
            Catch ex As Exception
                DebugPrint(ex.Message, Color.Tomato)
                If 广播接收计时器.Enabled = False Then Exit While
            End Try
            Thread.Sleep(500)
        End While
    End Sub

    Async Sub 停止寻找广播服务器(sender As Object, e As ElapsedEventArgs)
        If 广播接收任务取消令牌源 IsNot Nothing Then
            广播接收任务取消令牌源.Cancel()
            Await 广播接收任务
            If 广播接收任务取消令牌源 IsNot Nothing Then
                广播接收任务取消令牌源.Dispose()
                广播接收任务取消令牌源 = Nothing
            End If
        End If
        广播接收任务 = Nothing
        广播接收端?.Close()
        广播接收端?.Dispose()
        广播接收计时器?.Dispose()
        Form1.重新创建句柄()
        UI同步上下文.Post(Sub()
                         Label101.Text = "搜索结束，按刷新来重新搜索"
                         UiButton14.Enabled = True
                     End Sub, Nothing)
    End Sub

    Sub 向服务器列表添加信息(info As List(Of String))
        For i3 = 0 To Me.ListView6.Items.Count - 1
            If Me.ListView6.Items(i3).Text = info(1) AndAlso Me.ListView6.Items(i3).SubItems(1).Text = info(2) Then
                Return
            End If
        Next
        Dim item As New ListViewItem(info(1))
        item.SubItems.Add(info(2))
        item.SubItems.Add(info(3))
        item.SubItems.Add(info(4))
        item.SubItems.Add(info(5))
        Me.ListView6.Items.Add(item)
    End Sub

    Sub 保存服务器选项卡设置()
        游戏设置.实例对象.Sever_Port = UiTextBox4.Text
        游戏设置.实例对象.Sever_Name = UiTextBox5.Text
        游戏设置.实例对象.Sever_Description = UiTextBox6.Text
        游戏设置.实例对象.Sever_DefaultPermission = UiComboBox6.SelectedIndex
        游戏设置.实例对象.Sever_MaxPing = UiComboBox8.SelectedIndex
        游戏设置.实例对象.Sever_Broadcast = UiComboBox9.SelectedIndex
        游戏设置.实例对象.Sever_AllowedConnection = UiComboBox10.SelectedIndex
        游戏设置.实例对象.Sever_MessageProcessMultithread = UiComboBox11.SelectedIndex
        游戏设置.实例对象.Sever_OpenSinglePlayerLocation = UiComboBox7.SelectedIndex
        游戏设置.实例对象.ConnectSever_IP = UiTextBox3.Text
        游戏设置.实例对象.ConnectSever_Port = UiTextBox7.Text
        游戏设置.保存()
    End Sub
#End Region

#Region "连接主机"
    Async Sub 连接选中的服务器()
        If Me.ListView6.SelectedItems.Count <> 1 Then Exit Sub
        If 客户端.是否正在运行 Then
            Dim a As New 多项单选对话框("", {"新的连接", "取消"}, "客户端服务正在运行，是否关闭当前连接并开始新的连接？")
            If a.ShowDialog(Form1) <> 0 Then Exit Sub
        End If
        Me.Label103.Text = "客户端服务已启动，已发送请求"
        Select Case Me.UiComboBox15.SelectedIndex
            Case 0
                客户端.响应线程数量 = 1
            Case 1
                客户端.响应线程数量 = 2
            Case 2
                客户端.响应线程数量 = 4
            Case 3
                客户端.响应线程数量 = 8
            Case 4
                客户端.响应线程数量 = 16
            Case 5
                客户端.响应线程数量 = 32
            Case Else
                客户端.响应线程数量 = 1
        End Select
        客户端.启动客户端(Me.ListView6.SelectedItems(0).Text, Me.ListView6.SelectedItems(0).SubItems(1).Text)
        客户端.发送消息(New List(Of String) From {"iw_client_login_beta3"})
        Await Task.Run(Sub()
                           Thread.Sleep(5000)
                       End Sub)
        If 客户端.是否收到响应 Then
            Me.Label103.Text = $"已连接到 {客户端.服务器地址}"
        Else
            客户端.停止客户端()
            Me.Label103.Text = "由于没有收到服务器消息，客户端服务已自动停止"
        End If
    End Sub

    Async Sub 连接自定义输入的服务器()
        If Me.UiTextBox3.Text = "" Then Exit Sub
        Dim ip As String = Me.UiTextBox3.Text
        Dim ipArray As String() = ip.Split("."c)
        If ipArray.Length <> 4 Then
            Dim a As New 多项单选对话框("", {"了解"}, "IPv4 地址格式错误！")
            a.ShowDialog(Form1)
            Exit Sub
        End If
        If Me.UiTextBox7.Text = "" Then Exit Sub
        Dim port As Integer
        If Not Integer.TryParse(Me.UiTextBox7.Text, port) OrElse port < 0 OrElse port > 65535 Then
            Dim a As New 多项单选对话框("", {"了解"}, "端口号格式错误！")
            a.ShowDialog(Form1)
            Exit Sub
        End If
        If 客户端.是否正在运行 Then
            Dim a As New 多项单选对话框("", {"新的连接", "取消"}, "客户端服务正在运行，是否关闭当前连接并开始新的连接？")
            If a.ShowDialog(Form1) <> 0 Then Exit Sub
        End If
        Me.Label103.Text = "客户端服务已启动，已发送请求"
        游戏设置.实例对象.ConnectSever_IP = UiTextBox3.Text
        游戏设置.实例对象.ConnectSever_Port = UiTextBox7.Text
        游戏设置.保存()
        客户端.启动客户端(Me.UiTextBox3.Text, Me.UiTextBox7.Text)
        客户端.发送消息(New List(Of String) From {"iw_client_login_beta3"})
        Await Task.Run(Sub()
                           Thread.Sleep(5000)
                       End Sub)
        If 客户端.是否收到响应 Then
            Me.Label103.Text = $"已连接到 {客户端.服务器地址}"
        Else
            客户端.停止客户端()
            Me.Label103.Text = "由于没有收到服务器消息，客户端服务已自动停止"
        End If
    End Sub


#End Region



End Class