<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 界面二层_多人模式角色列表
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写释放以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Label1 = New Label()
        UiButton1 = New Sunny.UI.UIButton()
        Panel2 = New Panel()
        UiTabControl1 = New Sunny.UI.UITabControl()
        TabPage1 = New TabPage()
        Panel6 = New Panel()
        Panel19 = New Panel()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ImageList1 = New ImageList(components)
        Panel7 = New Panel()
        UiTextBox3 = New Sunny.UI.UITextBox()
        Label10 = New Label()
        UiButton3 = New Sunny.UI.UIButton()
        Label8 = New Label()
        Label5 = New Label()
        Panel3 = New Panel()
        Label7 = New Label()
        Label6 = New Label()
        Panel8 = New Panel()
        Label21 = New Label()
        UiButton2 = New Sunny.UI.UIButton()
        Label9 = New Label()
        Panel4 = New Panel()
        UiTextBox2 = New Sunny.UI.UITextBox()
        Label4 = New Label()
        Panel5 = New Panel()
        UiTextBox1 = New Sunny.UI.UITextBox()
        Label3 = New Label()
        Label2 = New Label()
        TabPage2 = New TabPage()
        Panel13 = New Panel()
        Panel15 = New Panel()
        ListView2 = New ListView()
        ColumnHeader2 = New ColumnHeader()
        Panel16 = New Panel()
        UiTextBox6 = New Sunny.UI.UITextBox()
        Label12 = New Label()
        UiButton5 = New Sunny.UI.UIButton()
        Label19 = New Label()
        Label20 = New Label()
        Panel9 = New Panel()
        Label18 = New Label()
        Panel10 = New Panel()
        Label13 = New Label()
        UiButton4 = New Sunny.UI.UIButton()
        Label11 = New Label()
        Panel14 = New Panel()
        UiTextBox7 = New Sunny.UI.UITextBox()
        Label14 = New Label()
        Panel11 = New Panel()
        UiTextBox4 = New Sunny.UI.UITextBox()
        Label15 = New Label()
        Panel12 = New Panel()
        UiTextBox5 = New Sunny.UI.UITextBox()
        Label16 = New Label()
        Label17 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        UiTabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel6.SuspendLayout()
        Panel19.SuspendLayout()
        Panel7.SuspendLayout()
        Panel3.SuspendLayout()
        Panel8.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel13.SuspendLayout()
        Panel15.SuspendLayout()
        Panel16.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        Panel14.SuspendLayout()
        Panel11.SuspendLayout()
        Panel12.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(UiButton1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(15, 10, 10, 10)
        Panel1.Size = New Size(1280, 55)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Fill
        Label1.Font = New Font("微软雅黑", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        Label1.Location = New Point(15, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(1105, 35)
        Label1.TabIndex = 0
        Label1.Text = "服务器名称   0.0.0.0:000   在线玩家 0/0   槽位使用 0/0"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButton1
        ' 
        UiButton1.Dock = DockStyle.Right
        UiButton1.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton1.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.Font = New Font("微软雅黑", 10F)
        UiButton1.ForeColor = Color.Silver
        UiButton1.ForeDisableColor = Color.Silver
        UiButton1.ForeHoverColor = Color.Silver
        UiButton1.ForePressColor = Color.Silver
        UiButton1.ForeSelectedColor = Color.Silver
        UiButton1.Location = New Point(1120, 10)
        UiButton1.MinimumSize = New Size(1, 1)
        UiButton1.Name = "UiButton1"
        UiButton1.Radius = 1
        UiButton1.RectColor = SystemColors.WindowFrame
        UiButton1.RectDisableColor = SystemColors.WindowFrame
        UiButton1.RectHoverColor = SystemColors.WindowFrame
        UiButton1.RectPressColor = SystemColors.WindowFrame
        UiButton1.RectSelectedColor = SystemColors.WindowFrame
        UiButton1.Size = New Size(150, 35)
        UiButton1.TabIndex = 24
        UiButton1.Text = "断开连接"
        UiButton1.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(UiTabControl1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 55)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(20, 0, 20, 20)
        Panel2.Size = New Size(1280, 665)
        Panel2.TabIndex = 5
        ' 
        ' UiTabControl1
        ' 
        UiTabControl1.Controls.Add(TabPage1)
        UiTabControl1.Controls.Add(TabPage2)
        UiTabControl1.Dock = DockStyle.Fill
        UiTabControl1.DrawMode = TabDrawMode.OwnerDrawFixed
        UiTabControl1.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControl1.Font = New Font("微软雅黑", 11F)
        UiTabControl1.ItemSize = New Size(150, 50)
        UiTabControl1.Location = New Point(20, 0)
        UiTabControl1.MainPage = ""
        UiTabControl1.MenuStyle = Sunny.UI.UIMenuStyle.Custom
        UiTabControl1.Name = "UiTabControl1"
        UiTabControl1.SelectedIndex = 0
        UiTabControl1.Size = New Size(1240, 645)
        UiTabControl1.SizeMode = TabSizeMode.Fixed
        UiTabControl1.TabBackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControl1.TabIndex = 5
        UiTabControl1.TabSelectedColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControl1.TabSelectedForeColor = Color.Silver
        UiTabControl1.TabSelectedHighColor = Color.Silver
        UiTabControl1.TabUnSelectedForeColor = Color.Silver
        UiTabControl1.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage1.Controls.Add(Panel6)
        TabPage1.Controls.Add(Panel3)
        TabPage1.Location = New Point(0, 50)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(1240, 595)
        TabPage1.TabIndex = 0
        TabPage1.Text = "继续游戏"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Panel19)
        Panel6.Controls.Add(Panel7)
        Panel6.Controls.Add(Label8)
        Panel6.Controls.Add(Label5)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(350, 0)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(20, 20, 0, 0)
        Panel6.Size = New Size(890, 595)
        Panel6.TabIndex = 1
        ' 
        ' Panel19
        ' 
        Panel19.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Panel19.Controls.Add(ListView1)
        Panel19.Dock = DockStyle.Fill
        Panel19.Location = New Point(20, 125)
        Panel19.Name = "Panel19"
        Panel19.Padding = New Padding(0, 10, 0, 0)
        Panel19.Size = New Size(870, 470)
        Panel19.TabIndex = 53
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1})
        ListView1.Dock = DockStyle.Left
        ListView1.ForeColor = Color.Silver
        ListView1.FullRowSelect = True
        ListView1.HeaderStyle = ColumnHeaderStyle.None
        ListView1.Location = New Point(0, 10)
        ListView1.MultiSelect = False
        ListView1.Name = "ListView1"
        ListView1.OwnerDraw = True
        ListView1.Size = New Size(856, 460)
        ListView1.SmallImageList = ImageList1
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(1, 30)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(UiTextBox3)
        Panel7.Controls.Add(Label10)
        Panel7.Controls.Add(UiButton3)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(20, 90)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(5, 0, 0, 0)
        Panel7.Size = New Size(870, 35)
        Panel7.TabIndex = 52
        ' 
        ' UiTextBox3
        ' 
        UiTextBox3.Dock = DockStyle.Left
        UiTextBox3.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox3.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox3.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox3.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox3.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTextBox3.ForeColor = Color.DarkGray
        UiTextBox3.ForeDisableColor = Color.DarkGray
        UiTextBox3.ForeReadOnlyColor = Color.DarkGray
        UiTextBox3.Location = New Point(140, 0)
        UiTextBox3.Margin = New Padding(4, 5, 4, 5)
        UiTextBox3.MinimumSize = New Size(1, 16)
        UiTextBox3.Name = "UiTextBox3"
        UiTextBox3.Padding = New Padding(5)
        UiTextBox3.RectColor = Color.DimGray
        UiTextBox3.RectDisableColor = Color.DimGray
        UiTextBox3.RectReadOnlyColor = Color.DimGray
        UiTextBox3.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBox3.ScrollBarColor = Color.DimGray
        UiTextBox3.ScrollBarStyleInherited = False
        UiTextBox3.ShowText = False
        UiTextBox3.Size = New Size(300, 35)
        UiTextBox3.TabIndex = 0
        UiTextBox3.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox3.Watermark = "搜索角色（Enter）"
        UiTextBox3.WatermarkActiveColor = Color.DimGray
        UiTextBox3.WatermarkColor = Color.DimGray
        ' 
        ' Label10
        ' 
        Label10.Dock = DockStyle.Left
        Label10.Location = New Point(130, 0)
        Label10.Name = "Label10"
        Label10.Padding = New Padding(10, 0, 0, 0)
        Label10.Size = New Size(10, 35)
        Label10.TabIndex = 24
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButton3
        ' 
        UiButton3.Dock = DockStyle.Left
        UiButton3.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton3.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton3.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton3.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton3.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton3.Font = New Font("微软雅黑", 11F)
        UiButton3.ForeColor = Color.Silver
        UiButton3.ForeDisableColor = Color.Silver
        UiButton3.ForeHoverColor = Color.Silver
        UiButton3.ForePressColor = Color.Silver
        UiButton3.ForeSelectedColor = Color.Silver
        UiButton3.Location = New Point(5, 0)
        UiButton3.MinimumSize = New Size(1, 1)
        UiButton3.Name = "UiButton3"
        UiButton3.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.Size = New Size(125, 35)
        UiButton3.TabIndex = 23
        UiButton3.Text = "搜索"
        UiButton3.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Dock = DockStyle.Top
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(20, 55)
        Label8.Name = "Label8"
        Label8.Padding = New Padding(1, 0, 0, 15)
        Label8.Size = New Size(295, 35)
        Label8.TabIndex = 51
        Label8.Text = "选择目前尚未被登入的角色，不包含隐藏的"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Dock = DockStyle.Top
        Label5.Font = New Font("微软雅黑", 13F, FontStyle.Bold)
        Label5.Location = New Point(20, 20)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(0, 0, 0, 10)
        Label5.Size = New Size(138, 35)
        Label5.TabIndex = 50
        Label5.Text = "公开的角色存档"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Panel8)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 20, 0, 0)
        Panel3.Size = New Size(350, 595)
        Panel3.TabIndex = 0
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Dock = DockStyle.Fill
        Label7.ForeColor = Color.Gray
        Label7.Location = New Point(0, 280)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(1, 0, 0, 15)
        Label7.Size = New Size(350, 315)
        Label7.TabIndex = 55
        Label7.Text = "单人模式的角色一般由服务器登入，但也有一些例外情况需要远程或让其他玩家登入该角色。如果服务器启用了该功能则可以在上方手动登入，如果此设备就是服务器那么总是可以，前提是没有人已经登入该角色。" & vbCrLf & vbCrLf & "该角色的密码在存档创建时已经生成，可在存档文件中自行查看或编辑。"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Dock = DockStyle.Top
        Label6.Font = New Font("微软雅黑", 13F, FontStyle.Bold)
        Label6.Location = New Point(0, 215)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(0, 30, 0, 10)
        Label6.Size = New Size(120, 65)
        Label6.TabIndex = 54
        Label6.Text = "单人模式角色"
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(Label21)
        Panel8.Controls.Add(UiButton2)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 180)
        Panel8.Name = "Panel8"
        Panel8.Padding = New Padding(5, 0, 0, 0)
        Panel8.Size = New Size(350, 35)
        Panel8.TabIndex = 56
        ' 
        ' Label21
        ' 
        Label21.Dock = DockStyle.Fill
        Label21.Location = New Point(130, 0)
        Label21.Name = "Label21"
        Label21.Padding = New Padding(10, 0, 0, 0)
        Label21.Size = New Size(220, 35)
        Label21.TabIndex = 23
        Label21.Text = "选择"
        Label21.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButton2
        ' 
        UiButton2.Dock = DockStyle.Left
        UiButton2.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton2.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton2.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton2.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton2.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton2.Font = New Font("微软雅黑", 11F)
        UiButton2.ForeColor = Color.Silver
        UiButton2.ForeDisableColor = Color.Silver
        UiButton2.ForeHoverColor = Color.Silver
        UiButton2.ForePressColor = Color.Silver
        UiButton2.ForeSelectedColor = Color.Silver
        UiButton2.Location = New Point(5, 0)
        UiButton2.MinimumSize = New Size(1, 1)
        UiButton2.Name = "UiButton2"
        UiButton2.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.Size = New Size(125, 35)
        UiButton2.TabIndex = 22
        UiButton2.Text = "登入"
        UiButton2.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.Transparent
        Label9.Dock = DockStyle.Top
        Label9.ForeColor = Color.Gray
        Label9.Location = New Point(0, 170)
        Label9.Name = "Label9"
        Label9.Padding = New Padding(1, 0, 0, 10)
        Label9.Size = New Size(350, 10)
        Label9.TabIndex = 57
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(UiTextBox2)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 135)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(5, 0, 0, 0)
        Panel4.Size = New Size(350, 35)
        Panel4.TabIndex = 53
        ' 
        ' UiTextBox2
        ' 
        UiTextBox2.Dock = DockStyle.Fill
        UiTextBox2.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox2.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox2.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox2.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox2.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTextBox2.ForeColor = Color.DarkGray
        UiTextBox2.ForeDisableColor = Color.DarkGray
        UiTextBox2.ForeReadOnlyColor = Color.DarkGray
        UiTextBox2.Location = New Point(5, 0)
        UiTextBox2.Margin = New Padding(4, 5, 4, 5)
        UiTextBox2.MinimumSize = New Size(1, 16)
        UiTextBox2.Name = "UiTextBox2"
        UiTextBox2.Padding = New Padding(5)
        UiTextBox2.RectColor = Color.DimGray
        UiTextBox2.RectDisableColor = Color.DimGray
        UiTextBox2.RectReadOnlyColor = Color.DimGray
        UiTextBox2.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBox2.ScrollBarColor = Color.DimGray
        UiTextBox2.ScrollBarStyleInherited = False
        UiTextBox2.ShowText = False
        UiTextBox2.Size = New Size(345, 35)
        UiTextBox2.TabIndex = 0
        UiTextBox2.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox2.Watermark = "密码"
        UiTextBox2.WatermarkActiveColor = Color.DimGray
        UiTextBox2.WatermarkColor = Color.DimGray
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Dock = DockStyle.Top
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(0, 125)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(1, 0, 0, 10)
        Label4.Size = New Size(350, 10)
        Label4.TabIndex = 52
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(UiTextBox1)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 90)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(5, 0, 0, 0)
        Panel5.Size = New Size(350, 35)
        Panel5.TabIndex = 51
        ' 
        ' UiTextBox1
        ' 
        UiTextBox1.Dock = DockStyle.Fill
        UiTextBox1.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox1.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox1.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox1.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox1.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTextBox1.ForeColor = Color.DarkGray
        UiTextBox1.ForeDisableColor = Color.DarkGray
        UiTextBox1.ForeReadOnlyColor = Color.DarkGray
        UiTextBox1.Location = New Point(5, 0)
        UiTextBox1.Margin = New Padding(4, 5, 4, 5)
        UiTextBox1.MinimumSize = New Size(1, 16)
        UiTextBox1.Name = "UiTextBox1"
        UiTextBox1.Padding = New Padding(5)
        UiTextBox1.RectColor = Color.DimGray
        UiTextBox1.RectDisableColor = Color.DimGray
        UiTextBox1.RectReadOnlyColor = Color.DimGray
        UiTextBox1.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBox1.ScrollBarColor = Color.DimGray
        UiTextBox1.ScrollBarStyleInherited = False
        UiTextBox1.ShowText = False
        UiTextBox1.Size = New Size(345, 35)
        UiTextBox1.TabIndex = 0
        UiTextBox1.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox1.Watermark = "角色名称"
        UiTextBox1.WatermarkActiveColor = Color.DimGray
        UiTextBox1.WatermarkColor = Color.DimGray
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Dock = DockStyle.Top
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(0, 55)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(1, 0, 0, 15)
        Label3.Size = New Size(205, 35)
        Label3.TabIndex = 50
        Label3.Text = "可登入不在显示列表中的角色"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Dock = DockStyle.Top
        Label2.Font = New Font("微软雅黑", 13F, FontStyle.Bold)
        Label2.Location = New Point(0, 20)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(0, 0, 0, 10)
        Label2.Size = New Size(120, 35)
        Label2.TabIndex = 49
        Label2.Text = "登入指定角色"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage2.Controls.Add(Panel13)
        TabPage2.Controls.Add(Panel9)
        TabPage2.Location = New Point(0, 40)
        TabPage2.Name = "TabPage2"
        TabPage2.Size = New Size(200, 60)
        TabPage2.TabIndex = 1
        TabPage2.Text = "新玩家"
        ' 
        ' Panel13
        ' 
        Panel13.Controls.Add(Panel15)
        Panel13.Controls.Add(Panel16)
        Panel13.Controls.Add(Label19)
        Panel13.Controls.Add(Label20)
        Panel13.Dock = DockStyle.Fill
        Panel13.Location = New Point(350, 0)
        Panel13.Name = "Panel13"
        Panel13.Padding = New Padding(20, 20, 0, 0)
        Panel13.Size = New Size(0, 60)
        Panel13.TabIndex = 2
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Panel15.Controls.Add(ListView2)
        Panel15.Dock = DockStyle.Fill
        Panel15.Location = New Point(20, 125)
        Panel15.Name = "Panel15"
        Panel15.Padding = New Padding(0, 10, 0, 0)
        Panel15.Size = New Size(0, 0)
        Panel15.TabIndex = 57
        ' 
        ' ListView2
        ' 
        ListView2.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ListView2.BorderStyle = BorderStyle.None
        ListView2.Columns.AddRange(New ColumnHeader() {ColumnHeader2})
        ListView2.Dock = DockStyle.Left
        ListView2.ForeColor = Color.Silver
        ListView2.FullRowSelect = True
        ListView2.HeaderStyle = ColumnHeaderStyle.None
        ListView2.Location = New Point(0, 10)
        ListView2.MultiSelect = False
        ListView2.Name = "ListView2"
        ListView2.OwnerDraw = True
        ListView2.Size = New Size(856, 0)
        ListView2.SmallImageList = ImageList1
        ListView2.TabIndex = 0
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' Panel16
        ' 
        Panel16.Controls.Add(UiTextBox6)
        Panel16.Controls.Add(Label12)
        Panel16.Controls.Add(UiButton5)
        Panel16.Dock = DockStyle.Top
        Panel16.Location = New Point(20, 90)
        Panel16.Name = "Panel16"
        Panel16.Padding = New Padding(5, 0, 0, 0)
        Panel16.Size = New Size(0, 35)
        Panel16.TabIndex = 56
        ' 
        ' UiTextBox6
        ' 
        UiTextBox6.Dock = DockStyle.Left
        UiTextBox6.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox6.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox6.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox6.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox6.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTextBox6.ForeColor = Color.DarkGray
        UiTextBox6.ForeDisableColor = Color.DarkGray
        UiTextBox6.ForeReadOnlyColor = Color.DarkGray
        UiTextBox6.Location = New Point(140, 0)
        UiTextBox6.Margin = New Padding(4, 5, 4, 5)
        UiTextBox6.MinimumSize = New Size(1, 16)
        UiTextBox6.Name = "UiTextBox6"
        UiTextBox6.Padding = New Padding(5)
        UiTextBox6.RectColor = Color.DimGray
        UiTextBox6.RectDisableColor = Color.DimGray
        UiTextBox6.RectReadOnlyColor = Color.DimGray
        UiTextBox6.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBox6.ScrollBarColor = Color.DimGray
        UiTextBox6.ScrollBarStyleInherited = False
        UiTextBox6.ShowText = False
        UiTextBox6.Size = New Size(300, 35)
        UiTextBox6.TabIndex = 0
        UiTextBox6.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox6.Watermark = "搜索殖民地名称（Enter）"
        UiTextBox6.WatermarkActiveColor = Color.DimGray
        UiTextBox6.WatermarkColor = Color.DimGray
        ' 
        ' Label12
        ' 
        Label12.Dock = DockStyle.Left
        Label12.Location = New Point(130, 0)
        Label12.Name = "Label12"
        Label12.Padding = New Padding(10, 0, 0, 0)
        Label12.Size = New Size(10, 35)
        Label12.TabIndex = 24
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButton5
        ' 
        UiButton5.Dock = DockStyle.Left
        UiButton5.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton5.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton5.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton5.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton5.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton5.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton5.Font = New Font("微软雅黑", 11F)
        UiButton5.ForeColor = Color.Silver
        UiButton5.ForeDisableColor = Color.Silver
        UiButton5.ForeHoverColor = Color.Silver
        UiButton5.ForePressColor = Color.Silver
        UiButton5.ForeSelectedColor = Color.Silver
        UiButton5.Location = New Point(5, 0)
        UiButton5.MinimumSize = New Size(1, 1)
        UiButton5.Name = "UiButton5"
        UiButton5.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton5.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton5.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton5.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton5.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton5.Size = New Size(125, 35)
        UiButton5.TabIndex = 23
        UiButton5.Text = "搜索"
        UiButton5.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.BackColor = Color.Transparent
        Label19.Dock = DockStyle.Top
        Label19.ForeColor = Color.Gray
        Label19.Location = New Point(20, 55)
        Label19.Name = "Label19"
        Label19.Padding = New Padding(1, 0, 0, 15)
        Label19.Size = New Size(535, 35)
        Label19.TabIndex = 55
        Label19.Text = "每一个玩家都有自己的初始殖民地，但其中的内容会根据模组作者的设计而不同"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.BackColor = Color.Transparent
        Label20.Dock = DockStyle.Top
        Label20.Font = New Font("微软雅黑", 13F, FontStyle.Bold)
        Label20.Location = New Point(20, 20)
        Label20.Name = "Label20"
        Label20.Padding = New Padding(0, 0, 0, 10)
        Label20.Size = New Size(138, 35)
        Label20.TabIndex = 54
        Label20.Text = "选择起始殖民地"
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(Label18)
        Panel9.Controls.Add(Panel10)
        Panel9.Controls.Add(Label11)
        Panel9.Controls.Add(Panel14)
        Panel9.Controls.Add(Label14)
        Panel9.Controls.Add(Panel11)
        Panel9.Controls.Add(Label15)
        Panel9.Controls.Add(Panel12)
        Panel9.Controls.Add(Label16)
        Panel9.Controls.Add(Label17)
        Panel9.Dock = DockStyle.Left
        Panel9.Location = New Point(0, 0)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(0, 20, 0, 0)
        Panel9.Size = New Size(350, 60)
        Panel9.TabIndex = 1
        ' 
        ' Label18
        ' 
        Label18.BackColor = Color.Transparent
        Label18.Dock = DockStyle.Fill
        Label18.Font = New Font("微软雅黑", 10F)
        Label18.ForeColor = Color.DimGray
        Label18.Location = New Point(0, 430)
        Label18.Name = "Label18"
        Label18.Padding = New Padding(1, 5, 0, 15)
        Label18.Size = New Size(350, 0)
        Label18.TabIndex = 60
        Label18.Text = "是第一次游玩多人模式吗？" & vbCrLf & "我强烈建议阅读文档中这部分的介绍"
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(Label13)
        Panel10.Controls.Add(UiButton4)
        Panel10.Dock = DockStyle.Top
        Panel10.Location = New Point(0, 395)
        Panel10.Name = "Panel10"
        Panel10.Padding = New Padding(5, 0, 0, 0)
        Panel10.Size = New Size(350, 35)
        Panel10.TabIndex = 56
        ' 
        ' Label13
        ' 
        Label13.Dock = DockStyle.Fill
        Label13.Location = New Point(130, 0)
        Label13.Name = "Label13"
        Label13.Padding = New Padding(10, 0, 0, 0)
        Label13.Size = New Size(220, 35)
        Label13.TabIndex = 23
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButton4
        ' 
        UiButton4.Dock = DockStyle.Left
        UiButton4.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton4.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton4.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton4.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton4.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton4.Font = New Font("微软雅黑", 11F)
        UiButton4.ForeColor = Color.Silver
        UiButton4.ForeDisableColor = Color.Silver
        UiButton4.ForeHoverColor = Color.Silver
        UiButton4.ForePressColor = Color.Silver
        UiButton4.ForeSelectedColor = Color.Silver
        UiButton4.Location = New Point(5, 0)
        UiButton4.MinimumSize = New Size(1, 1)
        UiButton4.Name = "UiButton4"
        UiButton4.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.Size = New Size(125, 35)
        UiButton4.TabIndex = 22
        UiButton4.Text = "登入"
        UiButton4.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.Transparent
        Label11.Dock = DockStyle.Top
        Label11.Font = New Font("微软雅黑", 10F)
        Label11.ForeColor = Color.DimGray
        Label11.Location = New Point(0, 337)
        Label11.Name = "Label11"
        Label11.Padding = New Padding(1, 5, 0, 15)
        Label11.Size = New Size(350, 58)
        Label11.TabIndex = 59
        Label11.Text = "在右侧选择初始位置"
        ' 
        ' Panel14
        ' 
        Panel14.Controls.Add(UiTextBox7)
        Panel14.Dock = DockStyle.Top
        Panel14.Location = New Point(0, 302)
        Panel14.Name = "Panel14"
        Panel14.Padding = New Padding(5, 0, 0, 0)
        Panel14.Size = New Size(350, 35)
        Panel14.TabIndex = 58
        ' 
        ' UiTextBox7
        ' 
        UiTextBox7.Dock = DockStyle.Fill
        UiTextBox7.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox7.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox7.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox7.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox7.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTextBox7.ForeColor = Color.DarkGray
        UiTextBox7.ForeDisableColor = Color.DarkGray
        UiTextBox7.ForeReadOnlyColor = Color.DarkGray
        UiTextBox7.Location = New Point(5, 0)
        UiTextBox7.Margin = New Padding(4, 5, 4, 5)
        UiTextBox7.MinimumSize = New Size(1, 16)
        UiTextBox7.Name = "UiTextBox7"
        UiTextBox7.Padding = New Padding(5)
        UiTextBox7.RectColor = Color.DimGray
        UiTextBox7.RectDisableColor = Color.DimGray
        UiTextBox7.RectReadOnlyColor = Color.DimGray
        UiTextBox7.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBox7.ScrollBarColor = Color.DimGray
        UiTextBox7.ScrollBarStyleInherited = False
        UiTextBox7.ShowText = False
        UiTextBox7.Size = New Size(345, 35)
        UiTextBox7.TabIndex = 1
        UiTextBox7.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox7.Watermark = "初始殖民地对象名称"
        UiTextBox7.WatermarkActiveColor = Color.DimGray
        UiTextBox7.WatermarkColor = Color.DimGray
        ' 
        ' Label14
        ' 
        Label14.BackColor = Color.Transparent
        Label14.Dock = DockStyle.Top
        Label14.Font = New Font("微软雅黑", 10F)
        Label14.ForeColor = Color.DimGray
        Label14.Location = New Point(0, 217)
        Label14.Name = "Label14"
        Label14.Padding = New Padding(1, 5, 0, 15)
        Label14.Size = New Size(350, 85)
        Label14.TabIndex = 57
        Label14.Text = "密码只能由超级管理员身份的玩家用控制台更改，或者编辑存档文件来更改"
        ' 
        ' Panel11
        ' 
        Panel11.Controls.Add(UiTextBox4)
        Panel11.Dock = DockStyle.Top
        Panel11.Location = New Point(0, 182)
        Panel11.Name = "Panel11"
        Panel11.Padding = New Padding(5, 0, 0, 0)
        Panel11.Size = New Size(350, 35)
        Panel11.TabIndex = 53
        ' 
        ' UiTextBox4
        ' 
        UiTextBox4.Dock = DockStyle.Fill
        UiTextBox4.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox4.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox4.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox4.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox4.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTextBox4.ForeColor = Color.DarkGray
        UiTextBox4.ForeDisableColor = Color.DarkGray
        UiTextBox4.ForeReadOnlyColor = Color.DarkGray
        UiTextBox4.Location = New Point(5, 0)
        UiTextBox4.Margin = New Padding(4, 5, 4, 5)
        UiTextBox4.MinimumSize = New Size(1, 16)
        UiTextBox4.Name = "UiTextBox4"
        UiTextBox4.Padding = New Padding(5)
        UiTextBox4.RectColor = Color.DimGray
        UiTextBox4.RectDisableColor = Color.DimGray
        UiTextBox4.RectReadOnlyColor = Color.DimGray
        UiTextBox4.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBox4.ScrollBarColor = Color.DimGray
        UiTextBox4.ScrollBarStyleInherited = False
        UiTextBox4.ShowText = False
        UiTextBox4.Size = New Size(345, 35)
        UiTextBox4.TabIndex = 0
        UiTextBox4.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox4.Watermark = "密码"
        UiTextBox4.WatermarkActiveColor = Color.DimGray
        UiTextBox4.WatermarkColor = Color.DimGray
        ' 
        ' Label15
        ' 
        Label15.BackColor = Color.Transparent
        Label15.Dock = DockStyle.Top
        Label15.Font = New Font("微软雅黑", 10F)
        Label15.ForeColor = Color.DimGray
        Label15.Location = New Point(0, 125)
        Label15.Name = "Label15"
        Label15.Padding = New Padding(1, 5, 0, 15)
        Label15.Size = New Size(350, 57)
        Label15.TabIndex = 52
        Label15.Text = "名称不可包含特殊字符，全部区分大小写"
        ' 
        ' Panel12
        ' 
        Panel12.Controls.Add(UiTextBox5)
        Panel12.Dock = DockStyle.Top
        Panel12.Location = New Point(0, 90)
        Panel12.Name = "Panel12"
        Panel12.Padding = New Padding(5, 0, 0, 0)
        Panel12.Size = New Size(350, 35)
        Panel12.TabIndex = 51
        ' 
        ' UiTextBox5
        ' 
        UiTextBox5.Dock = DockStyle.Fill
        UiTextBox5.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox5.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox5.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox5.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox5.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTextBox5.ForeColor = Color.DarkGray
        UiTextBox5.ForeDisableColor = Color.DarkGray
        UiTextBox5.ForeReadOnlyColor = Color.DarkGray
        UiTextBox5.Location = New Point(5, 0)
        UiTextBox5.Margin = New Padding(4, 5, 4, 5)
        UiTextBox5.MinimumSize = New Size(1, 16)
        UiTextBox5.Name = "UiTextBox5"
        UiTextBox5.Padding = New Padding(5)
        UiTextBox5.RectColor = Color.DimGray
        UiTextBox5.RectDisableColor = Color.DimGray
        UiTextBox5.RectReadOnlyColor = Color.DimGray
        UiTextBox5.ScrollBarBackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiTextBox5.ScrollBarColor = Color.DimGray
        UiTextBox5.ScrollBarStyleInherited = False
        UiTextBox5.ShowText = False
        UiTextBox5.Size = New Size(345, 35)
        UiTextBox5.TabIndex = 0
        UiTextBox5.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox5.Watermark = "角色名称"
        UiTextBox5.WatermarkActiveColor = Color.DimGray
        UiTextBox5.WatermarkColor = Color.DimGray
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.BackColor = Color.Transparent
        Label16.Dock = DockStyle.Top
        Label16.ForeColor = Color.Gray
        Label16.Location = New Point(0, 55)
        Label16.Name = "Label16"
        Label16.Padding = New Padding(1, 0, 0, 15)
        Label16.Size = New Size(100, 35)
        Label16.TabIndex = 50
        Label16.Text = "你好，世界！"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.BackColor = Color.Transparent
        Label17.Dock = DockStyle.Top
        Label17.Font = New Font("微软雅黑", 13F, FontStyle.Bold)
        Label17.Location = New Point(0, 20)
        Label17.Name = "Label17"
        Label17.Padding = New Padding(0, 0, 0, 10)
        Label17.Size = New Size(84, 35)
        Label17.TabIndex = 49
        Label17.Text = "创建角色"
        ' 
        ' 界面二层_多人模式角色列表
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("微软雅黑", 11F)
        ForeColor = Color.Silver
        Name = "界面二层_多人模式角色列表"
        Size = New Size(1280, 720)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        UiTabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel19.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        Panel13.ResumeLayout(False)
        Panel13.PerformLayout()
        Panel15.ResumeLayout(False)
        Panel16.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel14.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        Panel12.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents UiButton1 As Sunny.UI.UIButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UiTabControl1 As Sunny.UI.UITabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents UiTextBox1 As Sunny.UI.UITextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents UiTextBox2 As Sunny.UI.UITextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents UiTextBox3 As Sunny.UI.UITextBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents UiButton2 As Sunny.UI.UIButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents UiButton3 As Sunny.UI.UIButton
    Friend WithEvents Panel19 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents UiButton4 As Sunny.UI.UIButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents UiTextBox4 As Sunny.UI.UITextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents UiTextBox5 As Sunny.UI.UITextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Panel16 As Panel
    Friend WithEvents UiTextBox6 As Sunny.UI.UITextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents UiButton5 As Sunny.UI.UIButton
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents UiTextBox7 As Sunny.UI.UITextBox
    Friend WithEvents ImageList1 As ImageList

End Class
