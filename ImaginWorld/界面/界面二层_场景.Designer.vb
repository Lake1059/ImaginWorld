<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 界面二层_场景
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
        Panel2 = New Panel()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        Panel3 = New Panel()
        Panel5 = New Panel()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        UiButton1 = New Sunny.UI.UIButton()
        Label3 = New Label()
        Label2 = New Label()
        Panel4 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        UiButton仓库 = New Sunny.UI.UIButton()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel5.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        Panel4.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
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
        Panel1.Padding = New Padding(20, 10, 10, 10)
        Panel1.Size = New Size(1280, 60)
        Panel1.TabIndex = 3
        ' 
        ' Label27
        ' 
        Label27.Dock = DockStyle.Fill
        Label27.Location = New Point(350, 10)
        Label27.Name = "Label27"
        Label27.Padding = New Padding(0, 0, 20, 0)
        Label27.Size = New Size(770, 40)
        Label27.TabIndex = 38
        Label27.Text = "单人模式时间已暂停 / 多人模式下场景界面不能暂停时间"
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
        UiButton22.Location = New Point(1120, 10)
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
        Label殖民地名称.Size = New Size(330, 40)
        Label殖民地名称.TabIndex = 25
        Label殖民地名称.Text = "场景"
        Label殖民地名称.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel2.Controls.Add(ListView1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 60)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(20)
        Panel2.Size = New Size(350, 660)
        Panel2.TabIndex = 4
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1})
        ListView1.Dock = DockStyle.Left
        ListView1.ForeColor = Color.Silver
        ListView1.HeaderStyle = ColumnHeaderStyle.None
        ListView1.Location = New Point(20, 20)
        ListView1.Name = "ListView1"
        ListView1.OwnerDraw = True
        ListView1.Size = New Size(315, 620)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Panel3
        ' 
        Panel3.AutoScroll = True
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Panel4)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(350, 60)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(20)
        Panel3.Size = New Size(930, 660)
        Panel3.TabIndex = 5
        ' 
        ' Panel5
        ' 
        Panel5.AutoSize = True
        Panel5.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        Panel5.Controls.Add(FlowLayoutPanel2)
        Panel5.Controls.Add(Label3)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(20, 249)
        Panel5.Name = "Panel5"
        Panel5.Padding = New Padding(20)
        Panel5.Size = New Size(890, 209)
        Panel5.TabIndex = 2
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.Controls.Add(UiButton1)
        FlowLayoutPanel2.Dock = DockStyle.Top
        FlowLayoutPanel2.Location = New Point(20, 61)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Padding = New Padding(3)
        FlowLayoutPanel2.Size = New Size(850, 128)
        FlowLayoutPanel2.TabIndex = 1
        ' 
        ' UiButton1
        ' 
        UiButton1.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton1.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton1.Font = New Font("微软雅黑", 12F)
        UiButton1.ForeColor = Color.Silver
        UiButton1.ForeDisableColor = Color.Silver
        UiButton1.ForeHoverColor = Color.Silver
        UiButton1.ForePressColor = Color.Silver
        UiButton1.ForeSelectedColor = Color.Silver
        UiButton1.Location = New Point(6, 6)
        UiButton1.MinimumSize = New Size(1, 1)
        UiButton1.Name = "UiButton1"
        UiButton1.Radius = 1
        UiButton1.RectColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButton1.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.RectHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.RectPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.RectSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton1.Size = New Size(191, 35)
        UiButton1.TabIndex = 38
        UiButton1.Text = "触发器名称"
        UiButton1.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Top
        Label3.Location = New Point(20, 20)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(0, 0, 0, 20)
        Label3.Size = New Size(154, 41)
        Label3.TabIndex = 0
        Label3.Text = "该场景中的区域名称"
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Top
        Label2.Location = New Point(20, 229)
        Label2.Name = "Label2"
        Label2.Size = New Size(890, 20)
        Label2.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.AutoSize = True
        Panel4.BackColor = Color.FromArgb(CByte(12), CByte(12), CByte(12))
        Panel4.Controls.Add(FlowLayoutPanel1)
        Panel4.Controls.Add(Label1)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(20, 20)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(20)
        Panel4.Size = New Size(890, 209)
        Panel4.TabIndex = 0
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(UiButton仓库)
        FlowLayoutPanel1.Dock = DockStyle.Top
        FlowLayoutPanel1.Location = New Point(20, 61)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Padding = New Padding(3)
        FlowLayoutPanel1.Size = New Size(850, 128)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' UiButton仓库
        ' 
        UiButton仓库.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton仓库.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton仓库.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton仓库.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton仓库.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton仓库.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton仓库.Font = New Font("微软雅黑", 12F)
        UiButton仓库.ForeColor = Color.Silver
        UiButton仓库.ForeDisableColor = Color.Silver
        UiButton仓库.ForeHoverColor = Color.Silver
        UiButton仓库.ForePressColor = Color.Silver
        UiButton仓库.ForeSelectedColor = Color.Silver
        UiButton仓库.Location = New Point(6, 6)
        UiButton仓库.MinimumSize = New Size(1, 1)
        UiButton仓库.Name = "UiButton仓库"
        UiButton仓库.Radius = 1
        UiButton仓库.RectColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButton仓库.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton仓库.RectHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton仓库.RectPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton仓库.RectSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton仓库.Size = New Size(191, 35)
        UiButton仓库.TabIndex = 38
        UiButton仓库.Text = "触发器名称"
        UiButton仓库.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Location = New Point(20, 20)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(0, 0, 0, 20)
        Label1.Size = New Size(154, 41)
        Label1.TabIndex = 0
        Label1.Text = "该场景中的区域名称"
        ' 
        ' 界面二层_场景
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ForeColor = Color.Silver
        Name = "界面二层_场景"
        Size = New Size(1280, 720)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        FlowLayoutPanel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents UiButton22 As Sunny.UI.UIButton
    Friend WithEvents Label殖民地名称 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents UiButton仓库 As Sunny.UI.UIButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents UiButton1 As Sunny.UI.UIButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label

End Class
