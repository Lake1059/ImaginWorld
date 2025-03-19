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
        Panel1 = New Panel()
        Label1 = New Label()
        UiButton1 = New Sunny.UI.UIButton()
        Label2 = New Label()
        Panel2 = New Panel()
        Panel71 = New Panel()
        Label21 = New Label()
        UiButton2 = New Sunny.UI.UIButton()
        Label3 = New Label()
        Panel3 = New Panel()
        Panel5 = New Panel()
        Panel9 = New Panel()
        ListView2 = New ListView()
        ColumnHeader2 = New ColumnHeader()
        Panel7 = New Panel()
        UiTextBox2 = New Sunny.UI.UITextBox()
        Label8 = New Label()
        UiButton4 = New Sunny.UI.UIButton()
        Label5 = New Label()
        Panel38 = New Panel()
        Label39 = New Label()
        Panel4 = New Panel()
        Panel19 = New Panel()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        Panel6 = New Panel()
        Label6 = New Label()
        UiButton3 = New Sunny.UI.UIButton()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel71.SuspendLayout()
        Panel3.SuspendLayout()
        Panel5.SuspendLayout()
        Panel9.SuspendLayout()
        Panel7.SuspendLayout()
        Panel38.SuspendLayout()
        Panel4.SuspendLayout()
        Panel19.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.AutoSize = True
        Panel1.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(UiButton1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(10)
        Panel1.Size = New Size(1280, 61)
        Panel1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Fill
        Label1.Location = New Point(10, 10)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(10)
        Label1.Size = New Size(577, 41)
        Label1.TabIndex = 0
        Label1.Text = "服务器名称：？？？   地址端口：0.0.0.0   在线玩家：0 / 0   位置占用：0 / 0"
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
        UiButton1.Location = New Point(1070, 10)
        UiButton1.MinimumSize = New Size(1, 1)
        UiButton1.Name = "UiButton1"
        UiButton1.Radius = 1
        UiButton1.RectColor = SystemColors.WindowFrame
        UiButton1.RectDisableColor = SystemColors.WindowFrame
        UiButton1.RectHoverColor = SystemColors.WindowFrame
        UiButton1.RectPressColor = SystemColors.WindowFrame
        UiButton1.RectSelectedColor = SystemColors.WindowFrame
        UiButton1.Size = New Size(200, 41)
        UiButton1.TabIndex = 24
        UiButton1.Text = "取消并返回主菜单"
        UiButton1.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Dock = DockStyle.Top
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(0, 61)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(20, 20, 20, 0)
        Label2.Size = New Size(130, 41)
        Label2.TabIndex = 4
        Label2.Text = "服务器描述"
        ' 
        ' Panel2
        ' 
        Panel2.AutoSize = True
        Panel2.Controls.Add(Panel71)
        Panel2.Controls.Add(Label3)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 102)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(20, 20, 20, 0)
        Panel2.Size = New Size(1280, 91)
        Panel2.TabIndex = 5
        ' 
        ' Panel71
        ' 
        Panel71.Controls.Add(Label21)
        Panel71.Controls.Add(UiButton2)
        Panel71.Dock = DockStyle.Top
        Panel71.Location = New Point(20, 56)
        Panel71.Name = "Panel71"
        Panel71.Size = New Size(1240, 35)
        Panel71.TabIndex = 47
        ' 
        ' Label21
        ' 
        Label21.Dock = DockStyle.Fill
        Label21.ForeColor = Color.Gray
        Label21.Location = New Point(150, 0)
        Label21.Name = "Label21"
        Label21.Padding = New Padding(15, 0, 0, 0)
        Label21.Size = New Size(1090, 35)
        Label21.TabIndex = 24
        Label21.Text = "玩家名称：？？？   最后的场景位置：？？？   拥有殖民地数量：0"
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
        UiButton2.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiButton2.ForeColor = Color.Silver
        UiButton2.ForeDisableColor = Color.Silver
        UiButton2.ForeHoverColor = Color.Silver
        UiButton2.ForePressColor = Color.Silver
        UiButton2.ForeSelectedColor = Color.Silver
        UiButton2.Location = New Point(0, 0)
        UiButton2.MinimumSize = New Size(1, 1)
        UiButton2.Name = "UiButton2"
        UiButton2.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.Size = New Size(150, 35)
        UiButton2.TabIndex = 22
        UiButton2.Text = "状态"
        UiButton2.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Top
        Label3.Location = New Point(20, 20)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(0, 0, 0, 15)
        Label3.Size = New Size(682, 36)
        Label3.TabIndex = 32
        Label3.Text = "该服务器公开了单人模式的数据位，如果现在没有玩家在该位置进行游戏，则你可以选择此位置"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Panel38)
        Panel3.Controls.Add(Panel4)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 193)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1280, 527)
        Panel3.TabIndex = 6
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel9)
        Panel5.Controls.Add(Panel7)
        Panel5.Controls.Add(Label5)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(660, 0)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(0, 20, 20, 20)
        Panel5.Size = New Size(620, 527)
        Panel5.TabIndex = 7
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        Panel9.Controls.Add(ListView2)
        Panel9.Dock = DockStyle.Fill
        Panel9.Location = New Point(0, 111)
        Panel9.Name = "Panel9"
        Panel9.Padding = New Padding(0, 5, 0, 5)
        Panel9.Size = New Size(600, 396)
        Panel9.TabIndex = 52
        ' 
        ' ListView2
        ' 
        ListView2.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ListView2.BorderStyle = BorderStyle.None
        ListView2.Columns.AddRange(New ColumnHeader() {ColumnHeader2})
        ListView2.Dock = DockStyle.Left
        ListView2.ForeColor = Color.Silver
        ListView2.HeaderStyle = ColumnHeaderStyle.None
        ListView2.Location = New Point(0, 5)
        ListView2.MultiSelect = False
        ListView2.Name = "ListView2"
        ListView2.OwnerDraw = True
        ListView2.Size = New Size(479, 386)
        ListView2.TabIndex = 0
        ListView2.UseCompatibleStateImageBehavior = False
        ListView2.View = View.Details
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(UiTextBox2)
        Panel7.Controls.Add(Label8)
        Panel7.Controls.Add(UiButton4)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(0, 61)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(0, 0, 0, 15)
        Panel7.Size = New Size(600, 50)
        Panel7.TabIndex = 49
        ' 
        ' UiTextBox2
        ' 
        UiTextBox2.Dock = DockStyle.Left
        UiTextBox2.FillColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox2.FillColor2 = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox2.FillDisableColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox2.FillReadOnlyColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiTextBox2.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTextBox2.ForeColor = Color.DarkGray
        UiTextBox2.ForeDisableColor = Color.DarkGray
        UiTextBox2.ForeReadOnlyColor = Color.DarkGray
        UiTextBox2.Location = New Point(160, 0)
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
        UiTextBox2.Size = New Size(200, 35)
        UiTextBox2.TabIndex = 25
        UiTextBox2.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox2.Watermark = "玩家名称"
        UiTextBox2.WatermarkActiveColor = Color.DimGray
        UiTextBox2.WatermarkColor = Color.DimGray
        ' 
        ' Label8
        ' 
        Label8.Dock = DockStyle.Left
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(150, 0)
        Label8.Name = "Label8"
        Label8.Padding = New Padding(15, 0, 0, 0)
        Label8.Size = New Size(10, 35)
        Label8.TabIndex = 26
        Label8.Text = "玩家名称"
        Label8.TextAlign = ContentAlignment.MiddleLeft
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
        UiButton4.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiButton4.ForeColor = Color.Silver
        UiButton4.ForeDisableColor = Color.Silver
        UiButton4.ForeHoverColor = Color.Silver
        UiButton4.ForePressColor = Color.Silver
        UiButton4.ForeSelectedColor = Color.Silver
        UiButton4.Location = New Point(0, 0)
        UiButton4.MinimumSize = New Size(1, 1)
        UiButton4.Name = "UiButton4"
        UiButton4.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.Size = New Size(150, 35)
        UiButton4.TabIndex = 22
        UiButton4.Text = "创建"
        UiButton4.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Dock = DockStyle.Top
        Label5.Font = New Font("微软雅黑", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        Label5.Location = New Point(0, 20)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(0, 0, 0, 15)
        Label5.Size = New Size(259, 41)
        Label5.TabIndex = 32
        Label5.Text = "选择空闲数据位来创建新玩家"
        ' 
        ' Panel38
        ' 
        Panel38.Controls.Add(Label39)
        Panel38.Dock = DockStyle.Left
        Panel38.Location = New Point(618, 0)
        Panel38.Name = "Panel38"
        Panel38.Padding = New Padding(20)
        Panel38.Size = New Size(42, 527)
        Panel38.TabIndex = 6
        ' 
        ' Label39
        ' 
        Label39.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Label39.Dock = DockStyle.Fill
        Label39.Location = New Point(20, 20)
        Label39.Name = "Label39"
        Label39.Size = New Size(2, 487)
        Label39.TabIndex = 4
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel19)
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(Label4)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(20, 20, 0, 20)
        Panel4.Size = New Size(618, 527)
        Panel4.TabIndex = 0
        ' 
        ' Panel19
        ' 
        Panel19.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        Panel19.Controls.Add(ListView1)
        Panel19.Dock = DockStyle.Fill
        Panel19.Location = New Point(20, 111)
        Panel19.Name = "Panel19"
        Panel19.Padding = New Padding(0, 5, 0, 5)
        Panel19.Size = New Size(598, 396)
        Panel19.TabIndex = 33
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.FromArgb(CByte(32), CByte(32), CByte(32))
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1})
        ListView1.Dock = DockStyle.Left
        ListView1.ForeColor = Color.Silver
        ListView1.HeaderStyle = ColumnHeaderStyle.None
        ListView1.Location = New Point(0, 5)
        ListView1.MultiSelect = False
        ListView1.Name = "ListView1"
        ListView1.OwnerDraw = True
        ListView1.Size = New Size(500, 386)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Label6)
        Panel6.Controls.Add(UiButton3)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(20, 61)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(0, 0, 0, 15)
        Panel6.Size = New Size(598, 50)
        Panel6.TabIndex = 48
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Fill
        Label6.ForeColor = Color.Gray
        Label6.Location = New Point(150, 0)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(15, 0, 0, 0)
        Label6.Size = New Size(448, 35)
        Label6.TabIndex = 24
        Label6.Text = "或使用双击来确认"
        Label6.TextAlign = ContentAlignment.MiddleLeft
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
        UiButton3.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiButton3.ForeColor = Color.Silver
        UiButton3.ForeDisableColor = Color.Silver
        UiButton3.ForeHoverColor = Color.Silver
        UiButton3.ForePressColor = Color.Silver
        UiButton3.ForeSelectedColor = Color.Silver
        UiButton3.Location = New Point(0, 0)
        UiButton3.MinimumSize = New Size(1, 1)
        UiButton3.Name = "UiButton3"
        UiButton3.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.Size = New Size(150, 35)
        UiButton3.TabIndex = 22
        UiButton3.Text = "状态"
        UiButton3.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Dock = DockStyle.Top
        Label4.Font = New Font("微软雅黑", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        Label4.Location = New Point(20, 20)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(0, 0, 0, 15)
        Label4.Size = New Size(164, 41)
        Label4.TabIndex = 32
        Label4.Text = "选择已创建的玩家"
        ' 
        ' 界面二层_多人模式角色列表
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Font = New Font("微软雅黑", 12F)
        ForeColor = Color.Silver
        Name = "界面二层_多人模式角色列表"
        Size = New Size(1280, 720)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel71.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel38.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel19.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents UiButton1 As Sunny.UI.UIButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel71 As Panel
    Friend WithEvents UiButton2 As Sunny.UI.UIButton
    Friend WithEvents Label21 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel38 As Panel
    Friend WithEvents Label39 As Label
    Friend WithEvents Panel19 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents UiButton3 As Sunny.UI.UIButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents UiButton4 As Sunny.UI.UIButton
    Friend WithEvents Panel9 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents UiTextBox2 As Sunny.UI.UITextBox
    Friend WithEvents Label8 As Label

End Class
