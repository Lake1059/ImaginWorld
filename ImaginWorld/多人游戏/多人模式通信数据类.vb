
Public Class 多人模式通信数据类
    <Serializable>
    Public Class 玩家角色位信息表
        Public Property 通信版本标识 As String = Application.ProductVersion
        Public Property 服务器名称 As String
        Public Property 玩家在线数量 As Integer
        Public Property 所有玩家数量 As Integer
        Public Property 单人模式数据位是否可用 As Boolean
        Public Property 可登录的玩家列表 As New List(Of 玩家基本信息结构)
        Public Property 可用于创建新玩家的殖民地列表 As New List(Of String)

    End Class

    <Serializable>
    Public Class 玩家基本信息结构
        Public Property 玩家名称 As String
        Public Property 最后的场景名称 As String
        Public Property 拥有的殖民地数量 As Integer
        Public Property 远行队中的角色数量 As Integer
        Public Property 是否有密码 As Boolean
    End Class
End Class
