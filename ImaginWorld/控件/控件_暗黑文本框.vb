Imports System.ComponentModel

<ToolboxItem(True)>
Public Class 控件_暗黑文本框

    Public Sub New()
        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        调整()
        Me.TextBox1.PasswordChar = PasswordChar
        Me.TextBox1.BackColor = Me.BackColor
        Me.TextBox1.ForeColor = Me.ForeColor
    End Sub


    Private _BackColor As Color = ColorTranslator.FromWin32(RGB(48, 48, 48))
    Private _ForeColor As Color = Color.Silver
    Private _Font As New Font("微软雅黑", 9.75)

    <Browsable(True), EditorBrowsable(EditorBrowsableState.Always), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overrides Property Text As String
        Get
            Return Me.TextBox1.Text
        End Get
        Set(value As String)
            Me.TextBox1.Text = value
        End Set
    End Property

    <Browsable(True), EditorBrowsable(EditorBrowsableState.Always), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overrides Property Font As Font
        Get
            Return _Font
        End Get
        Set(value As Font)
            _Font = value
            MyBase.Font = value
            Me.TextBox1.Font = value
            调整()
        End Set
    End Property

    ''' <summary>
    '''  密码字符
    ''' </summary>
    ''' <returns></returns>
    <Browsable(True), EditorBrowsable(EditorBrowsableState.Always), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property PasswordChar As String
        Get
            Return Me.TextBox1.PasswordChar
        End Get
        Set(value As String)
            Me.TextBox1.PasswordChar = value
        End Set
    End Property

    ''' <summary>
    ''' 当文本框为空时显示的提示文本
    ''' </summary>
    ''' <returns></returns>
    <Browsable(True), EditorBrowsable(EditorBrowsableState.Always), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Property PlaceholderText As String
        Get
            Return Me.TextBox1.PlaceholderText
        End Get
        Set(value As String)
            Me.TextBox1.PlaceholderText = value
        End Set
    End Property

    <Browsable(True), EditorBrowsable(EditorBrowsableState.Always), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overrides Property BackColor As Color
        Get
            Return _BackColor
        End Get
        Set(value As Color)
            _BackColor = value
            MyBase.BackColor = value
            Me.TextBox1.BackColor = value
            Invalidate()
        End Set
    End Property

    <Browsable(True), EditorBrowsable(EditorBrowsableState.Always), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Public Overrides Property ForeColor As Color
        Get
            Return _ForeColor
        End Get
        Set(value As Color)
            _ForeColor = value
            MyBase.ForeColor = value
            Me.TextBox1.ForeColor = value
            Invalidate()
        End Set
    End Property

    Sub 调整()
        Me.Padding = New Padding(Me.Padding.Left, (Me.Height - Me.TextBox1.Height) * 0.5, Me.Padding.Right, 0)
    End Sub

    Private Sub 暗黑文本框控件本体_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        调整()
    End Sub

    Private Sub 暗黑文本框控件本体_DpiChangedAfterParent(sender As Object, e As EventArgs) Handles Me.DpiChangedAfterParent

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        RaiseEvent KeyDown(sender, e)
    End Sub

    Private Sub 控件_暗黑文本框_Load(sender As Object, e As EventArgs) Handles Me.Load
        调整()
    End Sub

    Public Shadows Event KeyDown(sender As Object, e As KeyEventArgs)

End Class
