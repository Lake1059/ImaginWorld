<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 界面二层_科技
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
        Panel18 = New Panel()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        Panel3 = New Panel()
        UiTextBox1 = New Sunny.UI.UITextBox()
        Label2 = New Label()
        UiButton1 = New Sunny.UI.UIButton()
        Label1 = New Label()
        UiComboBox13 = New Sunny.UI.UIComboBox()
        Label9 = New Label()
        Panel16 = New Panel()
        UiButton11 = New Sunny.UI.UIButton()
        Label36 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Panel18.SuspendLayout()
        Panel3.SuspendLayout()
        Panel16.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
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
        Panel1.TabIndex = 5
        ' 
        ' Label27
        ' 
        Label27.Dock = DockStyle.Fill
        Label27.Font = New Font("微软雅黑", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label27.Location = New Point(201, 10)
        Label27.Name = "Label27"
        Label27.Padding = New Padding(0, 0, 20, 0)
        Label27.Size = New Size(919, 40)
        Label27.TabIndex = 38
        Label27.Text = "科技需要通过世界探索、完成任务、推进故事来解锁，而不是传统的工作量解锁" & vbCrLf & "只显示已解锁的，不会显示未解锁的！可以批量同步至您控制的其他殖民地"
        Label27.TextAlign = ContentAlignment.MiddleLeft
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
        Label殖民地名称.Size = New Size(181, 40)
        Label殖民地名称.TabIndex = 25
        Label殖民地名称.Text = "科技"
        Label殖民地名称.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel18
        ' 
        Panel18.Controls.Add(ListView1)
        Panel18.Controls.Add(Panel3)
        Panel18.Dock = DockStyle.Fill
        Panel18.Location = New Point(650, 60)
        Panel18.Name = "Panel18"
        Panel18.Padding = New Padding(20)
        Panel18.Size = New Size(630, 660)
        Panel18.TabIndex = 9
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        ListView1.BorderStyle = BorderStyle.None
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1})
        ListView1.Dock = DockStyle.Left
        ListView1.ForeColor = Color.Silver
        ListView1.HeaderStyle = ColumnHeaderStyle.None
        ListView1.Location = New Point(20, 75)
        ListView1.Name = "ListView1"
        ListView1.OwnerDraw = True
        ListView1.Size = New Size(513, 565)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(UiTextBox1)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(UiButton1)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(UiComboBox13)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(20, 20)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 0, 0, 20)
        Panel3.Size = New Size(590, 55)
        Panel3.TabIndex = 2
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
        UiTextBox1.Location = New Point(210, 0)
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
        UiTextBox1.Size = New Size(270, 35)
        UiTextBox1.TabIndex = 4
        UiTextBox1.TextAlignment = ContentAlignment.MiddleLeft
        UiTextBox1.Watermark = "搜索科技名称"
        UiTextBox1.WatermarkActiveColor = Color.DimGray
        UiTextBox1.WatermarkColor = Color.DimGray
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Right
        Label2.Location = New Point(480, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(10, 35)
        Label2.TabIndex = 24
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
        UiButton1.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiButton1.ForeColor = Color.Silver
        UiButton1.ForeDisableColor = Color.Silver
        UiButton1.ForeHoverColor = Color.Silver
        UiButton1.ForePressColor = Color.Silver
        UiButton1.ForeSelectedColor = Color.Silver
        UiButton1.Location = New Point(490, 0)
        UiButton1.MinimumSize = New Size(1, 1)
        UiButton1.Name = "UiButton1"
        UiButton1.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.Size = New Size(100, 35)
        UiButton1.TabIndex = 23
        UiButton1.Text = "搜索"
        UiButton1.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Left
        Label1.Location = New Point(200, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(10, 35)
        Label1.TabIndex = 5
        ' 
        ' UiComboBox13
        ' 
        UiComboBox13.DataSource = Nothing
        UiComboBox13.Dock = DockStyle.Left
        UiComboBox13.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList
        UiComboBox13.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox13.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox13.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox13.Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        UiComboBox13.ForeColor = Color.Silver
        UiComboBox13.ForeDisableColor = Color.Silver
        UiComboBox13.ItemFillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiComboBox13.ItemForeColor = Color.Silver
        UiComboBox13.ItemHeight = 30
        UiComboBox13.ItemHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiComboBox13.ItemRectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiComboBox13.Items.AddRange(New Object() {"（建议）仅限本机加入可使用单人模式位", "（危险）允许其他玩家使用单人模式位"})
        UiComboBox13.ItemSelectBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBox13.ItemSelectForeColor = Color.Silver
        UiComboBox13.Location = New Point(0, 0)
        UiComboBox13.Margin = New Padding(4, 5, 4, 5)
        UiComboBox13.MaxDropDownItems = 17
        UiComboBox13.MinimumSize = New Size(63, 0)
        UiComboBox13.Name = "UiComboBox13"
        UiComboBox13.Padding = New Padding(0, 0, 30, 2)
        UiComboBox13.RectColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBox13.RectDisableColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBox13.ScrollBarBackColor = Color.FromArgb(CByte(80), CByte(80), CByte(80))
        UiComboBox13.ScrollBarColor = Color.Silver
        UiComboBox13.ScrollBarHandleWidth = 20
        UiComboBox13.ScrollBarStyleInherited = False
        UiComboBox13.Size = New Size(200, 35)
        UiComboBox13.SymbolSize = 24
        UiComboBox13.TabIndex = 3
        UiComboBox13.TextAlignment = ContentAlignment.MiddleLeft
        UiComboBox13.Watermark = "分组"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Dock = DockStyle.Top
        Label9.Font = New Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        Label9.Location = New Point(20, 20)
        Label9.Name = "Label9"
        Label9.Size = New Size(122, 22)
        Label9.TabIndex = 1
        Label9.Text = "选中科技的标题"
        ' 
        ' Panel16
        ' 
        Panel16.Controls.Add(UiButton11)
        Panel16.Dock = DockStyle.Bottom
        Panel16.Location = New Point(20, 600)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(310, 40)
        Panel16.TabIndex = 63
        ' 
        ' UiButton11
        ' 
        UiButton11.Dock = DockStyle.Fill
        UiButton11.FillColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton11.FillColor2 = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton11.FillDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton11.FillHoverColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton11.FillPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton11.FillSelectedColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        UiButton11.Font = New Font("微软雅黑", 12F)
        UiButton11.ForeColor = Color.DarkGray
        UiButton11.ForeDisableColor = Color.DarkGray
        UiButton11.ForeHoverColor = Color.DarkGray
        UiButton11.ForePressColor = Color.DarkGray
        UiButton11.ForeSelectedColor = Color.DarkGray
        UiButton11.Location = New Point(0, 0)
        UiButton11.MinimumSize = New Size(1, 1)
        UiButton11.Name = "UiButton11"
        UiButton11.Radius = 1
        UiButton11.RectColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        UiButton11.RectDisableColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton11.RectHoverColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton11.RectPressColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton11.RectSelectedColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        UiButton11.RectSize = 2
        UiButton11.Size = New Size(310, 40)
        UiButton11.TabIndex = 41
        UiButton11.Text = "同步到其他殖民地"
        UiButton11.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label36
        ' 
        Label36.Dock = DockStyle.Fill
        Label36.Font = New Font("微软雅黑", 10F)
        Label36.ForeColor = Color.Gray
        Label36.Location = New Point(20, 42)
        Label36.Name = "Label36"
        Label36.Padding = New Padding(0, 10, 0, 20)
        Label36.Size = New Size(310, 558)
        Label36.TabIndex = 62
        Label36.Text = "选中科技的描述"
        ' 
        ' Panel2
        ' 
        Panel2.AutoScroll = True
        Panel2.BackColor = Color.FromArgb(CByte(48), CByte(48), CByte(48))
        Panel2.Controls.Add(Label36)
        Panel2.Controls.Add(Panel16)
        Panel2.Controls.Add(Label9)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 60)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(20)
        Panel2.Size = New Size(350, 660)
        Panel2.TabIndex = 8
        ' 
        ' Panel4
        ' 
        Panel4.AutoScroll = True
        Panel4.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Label4)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(350, 60)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(20)
        Panel4.Size = New Size(300, 660)
        Panel4.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Fill
        Label3.Font = New Font("微软雅黑", 10F)
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(20, 42)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(0, 10, 0, 20)
        Label3.Size = New Size(260, 598)
        Label3.TabIndex = 62
        Label3.Text = "描述"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Dock = DockStyle.Top
        Label4.Font = New Font("微软雅黑", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        Label4.Location = New Point(20, 20)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 22)
        Label4.TabIndex = 1
        Label4.Text = "解锁的内容"
        ' 
        ' 界面二层_科技
        ' 
        AutoScaleDimensions = New SizeF(96F, 96F)
        AutoScaleMode = AutoScaleMode.Dpi
        BackColor = Color.FromArgb(CByte(24), CByte(24), CByte(24))
        Controls.Add(Panel18)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ForeColor = Color.Silver
        Name = "界面二层_科技"
        Size = New Size(1280, 720)
        Panel1.ResumeLayout(False)
        Panel18.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel16.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents UiButton22 As Sunny.UI.UIButton
    Friend WithEvents Label殖民地名称 As Label
    Friend WithEvents Panel18 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Panel3 As Panel
    Friend WithEvents UiComboBox13 As Sunny.UI.UIComboBox
    Friend WithEvents UiTextBox1 As Sunny.UI.UITextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents UiButton1 As Sunny.UI.UIButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents UiButton11 As Sunny.UI.UIButton
    Friend WithEvents Label36 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

End Class
