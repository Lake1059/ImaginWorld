<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 界面二层_图鉴
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
        Label27 = New Label()
        UiButton22 = New Sunny.UI.UIButton()
        Label殖民地名称 = New Label()
        UiTabControlMenu1 = New Sunny.UI.UITabControlMenu()
        TabPage据点历史 = New TabPage()
        TabPage派系故事 = New TabPage()
        TabPage敌人信息 = New TabPage()
        TabPage节日 = New TabPage()
        TabPage人物资料 = New TabPage()
        TabPage世界事件 = New TabPage()
        TabPage环境事件 = New TabPage()
        TabPageBUFF = New TabPage()
        Panel1.SuspendLayout()
        UiTabControlMenu1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Panel1.Controls.Add(Label27)
        Panel1.Controls.Add(UiButton22)
        Panel1.Controls.Add(Label殖民地名称)
        Panel1.Dock = DockStyle.Top
        Panel1.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(20, 10, 20, 10)
        Panel1.Size = New Size(1280, 60)
        Panel1.TabIndex = 1
        ' 
        ' Label27
        ' 
        Label27.Dock = DockStyle.Fill
        Label27.Location = New Point(202, 10)
        Label27.Name = "Label27"
        Label27.Padding = New Padding(0, 0, 20, 0)
        Label27.Size = New Size(908, 40)
        Label27.TabIndex = 38
        Label27.Text = "单人模式时间已暂停 / 多人模式下图鉴不能暂停时间"
        Label27.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' UiButton22
        ' 
        UiButton22.Dock = DockStyle.Right
        UiButton22.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton22.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton22.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton22.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton22.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton22.FillSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton22.Font = New Font("微软雅黑", 12F)
        UiButton22.ForeColor = Color.Silver
        UiButton22.ForeDisableColor = Color.Silver
        UiButton22.ForeHoverColor = Color.Silver
        UiButton22.ForePressColor = Color.Silver
        UiButton22.ForeSelectedColor = Color.Silver
        UiButton22.Location = New Point(1110, 10)
        UiButton22.MinimumSize = New Size(1, 1)
        UiButton22.Name = "UiButton22"
        UiButton22.Radius = 1
        UiButton22.RectColor = SystemColors.WindowFrame
        UiButton22.RectDisableColor = SystemColors.WindowFrame
        UiButton22.RectHoverColor = SystemColors.WindowFrame
        UiButton22.RectPressColor = SystemColors.WindowFrame
        UiButton22.RectSelectedColor = SystemColors.WindowFrame
        UiButton22.Size = New Size(150, 40)
        UiButton22.TabIndex = 42
        UiButton22.Text = "返回"
        UiButton22.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label殖民地名称
        ' 
        Label殖民地名称.Dock = DockStyle.Left
        Label殖民地名称.Font = New Font("微软雅黑", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        Label殖民地名称.Location = New Point(20, 10)
        Label殖民地名称.Name = "Label殖民地名称"
        Label殖民地名称.Size = New Size(182, 40)
        Label殖民地名称.TabIndex = 25
        Label殖民地名称.Text = "图鉴"
        Label殖民地名称.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UiTabControlMenu1
        ' 
        UiTabControlMenu1.Alignment = TabAlignment.Left
        UiTabControlMenu1.Controls.Add(TabPage据点历史)
        UiTabControlMenu1.Controls.Add(TabPage派系故事)
        UiTabControlMenu1.Controls.Add(TabPage敌人信息)
        UiTabControlMenu1.Controls.Add(TabPage节日)
        UiTabControlMenu1.Controls.Add(TabPage人物资料)
        UiTabControlMenu1.Controls.Add(TabPage世界事件)
        UiTabControlMenu1.Controls.Add(TabPage环境事件)
        UiTabControlMenu1.Controls.Add(TabPageBUFF)
        UiTabControlMenu1.Dock = DockStyle.Fill
        UiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed
        UiTabControlMenu1.FillColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        UiTabControlMenu1.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiTabControlMenu1.Location = New Point(0, 60)
        UiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom
        UiTabControlMenu1.Multiline = True
        UiTabControlMenu1.Name = "UiTabControlMenu1"
        UiTabControlMenu1.SelectedIndex = 0
        UiTabControlMenu1.Size = New Size(1280, 660)
        UiTabControlMenu1.SizeMode = TabSizeMode.Fixed
        UiTabControlMenu1.TabBackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTabControlMenu1.TabIndex = 2
        UiTabControlMenu1.TabSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiTabControlMenu1.TextAlignment = HorizontalAlignment.Left
        ' 
        ' TabPage据点历史
        ' 
        TabPage据点历史.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage据点历史.Location = New Point(201, 0)
        TabPage据点历史.Name = "TabPage据点历史"
        TabPage据点历史.Size = New Size(1079, 660)
        TabPage据点历史.TabIndex = 0
        TabPage据点历史.Text = "据点历史"
        ' 
        ' TabPage派系故事
        ' 
        TabPage派系故事.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage派系故事.Location = New Point(201, 0)
        TabPage派系故事.Name = "TabPage派系故事"
        TabPage派系故事.Size = New Size(1079, 660)
        TabPage派系故事.TabIndex = 1
        TabPage派系故事.Text = "派系故事"
        ' 
        ' TabPage敌人信息
        ' 
        TabPage敌人信息.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage敌人信息.Location = New Point(201, 0)
        TabPage敌人信息.Name = "TabPage敌人信息"
        TabPage敌人信息.Size = New Size(1079, 660)
        TabPage敌人信息.TabIndex = 2
        TabPage敌人信息.Text = "敌人信息"
        ' 
        ' TabPage节日
        ' 
        TabPage节日.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage节日.Location = New Point(201, 0)
        TabPage节日.Name = "TabPage节日"
        TabPage节日.Size = New Size(1079, 660)
        TabPage节日.TabIndex = 4
        TabPage节日.Text = "节日"
        ' 
        ' TabPage人物资料
        ' 
        TabPage人物资料.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage人物资料.Location = New Point(201, 0)
        TabPage人物资料.Name = "TabPage人物资料"
        TabPage人物资料.Size = New Size(1079, 660)
        TabPage人物资料.TabIndex = 5
        TabPage人物资料.Text = "人物资料"
        ' 
        ' TabPage世界事件
        ' 
        TabPage世界事件.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage世界事件.Location = New Point(201, 0)
        TabPage世界事件.Name = "TabPage世界事件"
        TabPage世界事件.Size = New Size(1079, 660)
        TabPage世界事件.TabIndex = 6
        TabPage世界事件.Text = "世界事件"
        ' 
        ' TabPage环境事件
        ' 
        TabPage环境事件.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPage环境事件.Location = New Point(201, 0)
        TabPage环境事件.Name = "TabPage环境事件"
        TabPage环境事件.Size = New Size(1079, 660)
        TabPage环境事件.TabIndex = 7
        TabPage环境事件.Text = "环境事件"
        ' 
        ' TabPageBUFF
        ' 
        TabPageBUFF.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        TabPageBUFF.Location = New Point(201, 0)
        TabPageBUFF.Name = "TabPageBUFF"
        TabPageBUFF.Size = New Size(1079, 660)
        TabPageBUFF.TabIndex = 8
        TabPageBUFF.Text = "BUFF"
        ' 
        ' 界面二层_图鉴
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(UiTabControlMenu1)
        Controls.Add(Panel1)
        Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ForeColor = Color.Silver
        Name = "界面二层_图鉴"
        Size = New Size(1280, 720)
        Panel1.ResumeLayout(False)
        UiTabControlMenu1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents Label殖民地名称 As Label
    Friend WithEvents UiTabControlMenu1 As Sunny.UI.UITabControlMenu
    Friend WithEvents TabPage据点历史 As TabPage
    Friend WithEvents TabPage派系故事 As TabPage
    Friend WithEvents TabPage敌人信息 As TabPage
    Friend WithEvents TabPage节日 As TabPage
    Friend WithEvents TabPage人物资料 As TabPage
    Friend WithEvents TabPage世界事件 As TabPage
    Friend WithEvents TabPage环境事件 As TabPage
    Friend WithEvents TabPageBUFF As TabPage
    Friend WithEvents UiButton22 As Sunny.UI.UIButton

End Class
