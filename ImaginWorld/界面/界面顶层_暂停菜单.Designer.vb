<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 界面顶层_暂停菜单
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
        Panel5 = New Panel()
        Label2 = New Label()
        UiButton断开连接 = New Sunny.UI.UIButton()
        Panel7 = New Panel()
        Label4 = New Label()
        UiButton保存并回主菜单 = New Sunny.UI.UIButton()
        Panel4 = New Panel()
        Label5 = New Label()
        UiButton4 = New Sunny.UI.UIButton()
        Panel3 = New Panel()
        Label6 = New Label()
        UiButton3 = New Sunny.UI.UIButton()
        Panel2 = New Panel()
        Label7 = New Label()
        UiButton2 = New Sunny.UI.UIButton()
        Panel6 = New Panel()
        Label8 = New Label()
        UiButton回到游戏 = New Sunny.UI.UIButton()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel7.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(120)
        Panel1.Size = New Size(1280, 720)
        Panel1.TabIndex = 0
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(UiButton断开连接)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(120, 480)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(10, 0, 0, 15)
        Panel5.Size = New Size(1040, 55)
        Panel5.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Fill
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(260, 0)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(20, 0, 0, 0)
        Label2.Size = New Size(780, 40)
        Label2.TabIndex = 23
        Label2.Text = "存档进度由服务器处理，直接退出不影响已经做出的更改"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButton断开连接
        ' 
        UiButton断开连接.Dock = DockStyle.Left
        UiButton断开连接.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton断开连接.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton断开连接.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton断开连接.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton断开连接.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton断开连接.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton断开连接.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiButton断开连接.ForeColor = Color.Silver
        UiButton断开连接.ForeDisableColor = Color.Silver
        UiButton断开连接.ForeHoverColor = Color.Silver
        UiButton断开连接.ForePressColor = Color.Silver
        UiButton断开连接.ForeSelectedColor = Color.Silver
        UiButton断开连接.Location = New Point(10, 0)
        UiButton断开连接.MinimumSize = New Size(1, 1)
        UiButton断开连接.Name = "UiButton断开连接"
        UiButton断开连接.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton断开连接.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton断开连接.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton断开连接.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton断开连接.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton断开连接.Size = New Size(250, 40)
        UiButton断开连接.TabIndex = 22
        UiButton断开连接.Text = "  断开连接"
        UiButton断开连接.TextAlign = ContentAlignment.MiddleLeft
        UiButton断开连接.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(Label4)
        Panel7.Controls.Add(UiButton保存并回主菜单)
        Panel7.Dock = DockStyle.Top
        Panel7.Location = New Point(120, 425)
        Panel7.Name = "Panel7"
        Panel7.Padding = New Padding(10, 0, 0, 15)
        Panel7.Size = New Size(1040, 55)
        Panel7.TabIndex = 27
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Fill
        Label4.ForeColor = Color.Gray
        Label4.Location = New Point(260, 0)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(20, 0, 0, 0)
        Label4.Size = New Size(780, 40)
        Label4.TabIndex = 24
        Label4.Text = "若不需要保存，请通过任务管理器结束进程，点叉或关机都会保存"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButton保存并回主菜单
        ' 
        UiButton保存并回主菜单.Dock = DockStyle.Left
        UiButton保存并回主菜单.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton保存并回主菜单.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton保存并回主菜单.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton保存并回主菜单.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton保存并回主菜单.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton保存并回主菜单.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton保存并回主菜单.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiButton保存并回主菜单.ForeColor = Color.Silver
        UiButton保存并回主菜单.ForeDisableColor = Color.Silver
        UiButton保存并回主菜单.ForeHoverColor = Color.Silver
        UiButton保存并回主菜单.ForePressColor = Color.Silver
        UiButton保存并回主菜单.ForeSelectedColor = Color.Silver
        UiButton保存并回主菜单.Location = New Point(10, 0)
        UiButton保存并回主菜单.MinimumSize = New Size(1, 1)
        UiButton保存并回主菜单.Name = "UiButton保存并回主菜单"
        UiButton保存并回主菜单.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton保存并回主菜单.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton保存并回主菜单.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton保存并回主菜单.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton保存并回主菜单.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton保存并回主菜单.Size = New Size(250, 40)
        UiButton保存并回主菜单.TabIndex = 22
        UiButton保存并回主菜单.Text = "  保存并回主菜单"
        UiButton保存并回主菜单.TextAlign = ContentAlignment.MiddleLeft
        UiButton保存并回主菜单.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(UiButton4)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(120, 370)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(10, 0, 0, 15)
        Panel4.Size = New Size(1040, 55)
        Panel4.TabIndex = 25
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Fill
        Label5.ForeColor = Color.Gray
        Label5.Location = New Point(260, 0)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(20, 0, 0, 0)
        Label5.Size = New Size(780, 40)
        Label5.TabIndex = 24
        Label5.Text = "汇报错误时请带上这些调试信息"
        Label5.TextAlign = ContentAlignment.MiddleLeft
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
        UiButton4.Location = New Point(10, 0)
        UiButton4.MinimumSize = New Size(1, 1)
        UiButton4.Name = "UiButton4"
        UiButton4.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton4.Size = New Size(250, 40)
        UiButton4.TabIndex = 22
        UiButton4.Text = "  控制台（波浪键）"
        UiButton4.TextAlign = ContentAlignment.MiddleLeft
        UiButton4.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(UiButton3)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(120, 315)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(10, 0, 0, 15)
        Panel3.Size = New Size(1040, 55)
        Panel3.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.Dock = DockStyle.Fill
        Label6.ForeColor = Color.Gray
        Label6.Location = New Point(260, 0)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(20, 0, 0, 0)
        Label6.Size = New Size(780, 40)
        Label6.TabIndex = 24
        Label6.Text = "仅限主窗口，其他窗口无法通过此功能截取"
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
        UiButton3.Location = New Point(10, 0)
        UiButton3.MinimumSize = New Size(1, 1)
        UiButton3.Name = "UiButton3"
        UiButton3.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton3.Size = New Size(250, 40)
        UiButton3.TabIndex = 22
        UiButton3.Text = "  截图（P 键）"
        UiButton3.TextAlign = ContentAlignment.MiddleLeft
        UiButton3.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(UiButton2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(120, 260)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10, 0, 0, 15)
        Panel2.Size = New Size(1040, 55)
        Panel2.TabIndex = 23
        ' 
        ' Label7
        ' 
        Label7.Dock = DockStyle.Fill
        Label7.ForeColor = Color.Gray
        Label7.Location = New Point(260, 0)
        Label7.Name = "Label7"
        Label7.Padding = New Padding(20, 0, 0, 0)
        Label7.Size = New Size(780, 40)
        Label7.TabIndex = 24
        Label7.Text = "自动保存将在每日结束时和脚本指定时"
        Label7.TextAlign = ContentAlignment.MiddleLeft
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
        UiButton2.Location = New Point(10, 0)
        UiButton2.MinimumSize = New Size(1, 1)
        UiButton2.Name = "UiButton2"
        UiButton2.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton2.Size = New Size(250, 40)
        UiButton2.TabIndex = 22
        UiButton2.Text = "  保存"
        UiButton2.TextAlign = ContentAlignment.MiddleLeft
        UiButton2.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Label8)
        Panel6.Controls.Add(UiButton回到游戏)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(120, 205)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(10, 0, 0, 15)
        Panel6.Size = New Size(1040, 55)
        Panel6.TabIndex = 22
        ' 
        ' Label8
        ' 
        Label8.Dock = DockStyle.Fill
        Label8.ForeColor = Color.Gray
        Label8.Location = New Point(260, 0)
        Label8.Name = "Label8"
        Label8.Padding = New Padding(20, 0, 0, 0)
        Label8.Size = New Size(780, 40)
        Label8.TabIndex = 24
        Label8.Text = "若处于多人模式下，此界面无法暂停游戏"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiButton回到游戏
        ' 
        UiButton回到游戏.Dock = DockStyle.Left
        UiButton回到游戏.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton回到游戏.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton回到游戏.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton回到游戏.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton回到游戏.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton回到游戏.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton回到游戏.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiButton回到游戏.ForeColor = Color.Silver
        UiButton回到游戏.ForeDisableColor = Color.Silver
        UiButton回到游戏.ForeHoverColor = Color.Silver
        UiButton回到游戏.ForePressColor = Color.Silver
        UiButton回到游戏.ForeSelectedColor = Color.Silver
        UiButton回到游戏.Location = New Point(10, 0)
        UiButton回到游戏.MinimumSize = New Size(1, 1)
        UiButton回到游戏.Name = "UiButton回到游戏"
        UiButton回到游戏.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton回到游戏.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton回到游戏.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton回到游戏.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton回到游戏.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton回到游戏.Size = New Size(250, 40)
        UiButton回到游戏.TabIndex = 22
        UiButton回到游戏.Text = "  回到游戏"
        UiButton回到游戏.TextAlign = ContentAlignment.MiddleLeft
        UiButton回到游戏.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("微软雅黑", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label1.Location = New Point(120, 120)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(0, 0, 0, 50)
        Label1.Size = New Size(123, 85)
        Label1.TabIndex = 0
        Label1.Text = "暂停菜单"
        ' 
        ' 界面顶层_暂停菜单
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(Panel1)
        Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ForeColor = Color.Silver
        Name = "界面顶层_暂停菜单"
        Size = New Size(1280, 720)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents UiButton3 As Sunny.UI.UIButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UiButton2 As Sunny.UI.UIButton
    Friend WithEvents Panel6 As Panel
    Friend WithEvents UiButton回到游戏 As Sunny.UI.UIButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents UiButton4 As Sunny.UI.UIButton
    Friend WithEvents Panel7 As Panel
    Friend WithEvents UiButton保存并回主菜单 As Sunny.UI.UIButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents UiButton断开连接 As Sunny.UI.UIButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

End Class
