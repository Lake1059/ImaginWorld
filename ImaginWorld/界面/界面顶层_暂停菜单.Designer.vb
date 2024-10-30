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
        Panel4 = New Panel()
        UiButton4 = New Sunny.UI.UIButton()
        Panel3 = New Panel()
        UiButton3 = New Sunny.UI.UIButton()
        Panel2 = New Panel()
        UiButton2 = New Sunny.UI.UIButton()
        Panel6 = New Panel()
        UiButton1 = New Sunny.UI.UIButton()
        Label3 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(150)
        Panel1.Size = New Size(1280, 720)
        Panel1.TabIndex = 0
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(UiButton4)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(150, 472)
        Panel4.Name = "Panel4"
        Panel4.Padding = New Padding(10, 0, 0, 20)
        Panel4.Size = New Size(980, 65)
        Panel4.TabIndex = 25
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
        UiButton4.Size = New Size(250, 45)
        UiButton4.TabIndex = 22
        UiButton4.Text = "  放弃进度回主菜单"
        UiButton4.TextAlign = ContentAlignment.MiddleLeft
        UiButton4.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(UiButton3)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(150, 407)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(10, 0, 0, 20)
        Panel3.Size = New Size(980, 65)
        Panel3.TabIndex = 24
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
        UiButton3.Size = New Size(250, 45)
        UiButton3.TabIndex = 22
        UiButton3.Text = "  保存进度回主菜单"
        UiButton3.TextAlign = ContentAlignment.MiddleLeft
        UiButton3.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(UiButton2)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(150, 342)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(10, 0, 0, 20)
        Panel2.Size = New Size(980, 65)
        Panel2.TabIndex = 23
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
        UiButton2.Size = New Size(250, 45)
        UiButton2.TabIndex = 22
        UiButton2.Text = "  立即保存"
        UiButton2.TextAlign = ContentAlignment.MiddleLeft
        UiButton2.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(UiButton1)
        Panel6.Dock = DockStyle.Top
        Panel6.Location = New Point(150, 277)
        Panel6.Name = "Panel6"
        Panel6.Padding = New Padding(10, 0, 0, 20)
        Panel6.Size = New Size(980, 65)
        Panel6.TabIndex = 22
        ' 
        ' UiButton1
        ' 
        UiButton1.Dock = DockStyle.Left
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
        UiButton1.Location = New Point(10, 0)
        UiButton1.MinimumSize = New Size(1, 1)
        UiButton1.Name = "UiButton1"
        UiButton1.RectColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.RectDisableColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.RectHoverColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.RectPressColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.RectSelectedColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UiButton1.Size = New Size(250, 45)
        UiButton1.TabIndex = 22
        UiButton1.Text = "  回到游戏"
        UiButton1.TextAlign = ContentAlignment.MiddleLeft
        UiButton1.TipsFont = New Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Dock = DockStyle.Top
        Label3.ForeColor = Color.Gray
        Label3.Location = New Point(150, 205)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(5, 0, 0, 30)
        Label3.Size = New Size(639, 72)
        Label3.TabIndex = 26
        Label3.Text = "并不需要专门调出暂停菜单来暂停游戏，很多界面都会将时间暂停来得到暂停游戏的效果" & vbCrLf & "这样的界面例如：剧情、任务、角色详情、仓库、远行队、运输队等" & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Dock = DockStyle.Top
        Label1.Font = New Font("微软雅黑", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(134))
        Label1.Location = New Point(150, 150)
        Label1.Name = "Label1"
        Label1.Padding = New Padding(0, 0, 0, 20)
        Label1.Size = New Size(123, 55)
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
    Friend WithEvents UiButton1 As Sunny.UI.UIButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents UiButton4 As Sunny.UI.UIButton
    Friend WithEvents Label3 As Label

End Class
