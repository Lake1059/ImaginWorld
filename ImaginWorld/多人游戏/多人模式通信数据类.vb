
Public Class 多人模式通信数据类

    Public Class 玩家数据位信息表
        Public Property 通信版本标识 As String
        Public Property 服务器名称 As String
        Public Property 服务器描述 As String
        Public Property 单人模式数据位是否可用 As Boolean
        Public Property 单人模式数据 As 玩家基本信息结构
        Public Property 可用的现存玩家数据列表 As New List(Of 玩家基本信息结构)
        Public Property 还可用于创建新玩家的殖民地列表 As New List(Of String)

        Public Class 玩家基本信息结构
            Public Property 玩家名称 As String
            Public Property 最后的场景名称 As String
            Public Property 拥有的殖民地数量 As Integer
        End Class

    End Class


End Class
