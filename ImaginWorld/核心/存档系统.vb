Public Class 存档系统

    Public Shared Property GameSave As New 存档结构

    <Serializable>
    Public Class 存档结构
        Public Property SinglePlayerData As New 玩家数据单片结构 '单人模式玩家数据 
        Public Property MultiPlayerColonyNameList As New List(Of String) '多人模式可用的殖民地列表
        Public Property MultiPlayerData As New Dictionary(Of String, 玩家数据单片结构) '多人模式玩家数据
        Public Property ColonyData As New Dictionary(Of String, 殖民地单片结构) '所有殖民地数据

    End Class






    <Serializable>
    Public Class 玩家数据单片结构
        Public Property PlayerName As String '玩家名称
        Public Property PlayerPassword As String '玩家密码
        Public Property IsHide As Boolean '玩家是否在登录列表中隐藏
        Public Property TravelData As New 远行队单片结构 '玩家的远行队数据
        Public Property OwnColony As New List(Of String) '玩家拥有的殖民地名称 
        Public Property Scenario As String '玩家所在场景名称
        Public Property ScenarioType As 场景类型 '玩家所在场景类型
        Public Property WorldLocation As New Point(0, 0) '如果在世界地图，玩家的地图坐标
        Public Property FinishedMission As New List(Of String) '玩家已完成的任务
        Public Property ActiveMission As New List(Of String) '玩家正在进行的任务 
        Public Property TrackingMissionId As String '玩家正在追踪的任务ID
        Public Property Tag  As New Dictionary(Of String, Object)
    End Class

    <Serializable>
    Public Class 远行队单片结构
        Public Property Inventory_ImportantSupplies As Dictionary(Of String, Integer)
        Public Property Inventory_Materials As Dictionary(Of String, Integer)
        Public Property Inventory_CharacterProps As Dictionary(Of String, Integer)
        Public Property Inventory_Consumables As Dictionary(Of String, Integer)
        Public Property Inventory_Weapon As Dictionary(Of String, String)
        Public Property Inventory_Equipment As Dictionary(Of String, String)
        Public Property Inventory_QuestItems As Dictionary(Of String, Integer)
        Public Property Inventory_Collectible As Dictionary(Of String, Integer)
        Public Property Characters As New Dictionary(Of String, 角色单片结构) '远行队的角色数据  
    End Class

    <Serializable>
    Public Class 殖民地单片结构
        Public Property Inventory As New Dictionary(Of String, Integer) '殖民地的物品库存
        Public Property Characters As New Dictionary(Of String, 角色单片结构) '殖民地的角色数据


    End Class

    <Serializable>
    Public Class 角色单片结构
        Public Property Used_Weapon As String
        Public Property Used_Equipment_Head As String
        Public Property Used_Equipment_Body As String
        Public Property Used_Equipment_Leg As String
        Public Property Used_Equipment_Relic1 As String
        Public Property Used_Equipment_Relic2 As String
        Public Property Skill_TB_Normal_Level As Integer
        Public Property Skill_TB_Tactics_Level As Integer
        Public Property Skill_TB_End_Level As Integer
        Public Property Skill_RT_Normal_Level As Integer
        Public Property Skill_RT_Tactics_Level As Integer
        Public Property Skill_RT_End_Level As Integer
        Public Property Talent1_Level As Integer
        Public Property Talent2_Level As Integer
        Public Property Talent3_Level As Integer
        Public Property ProfileUnlock As New List(Of String)
    End Class


    Enum 场景类型
        世界地图 = 1
        殖民地 = 2
    End Enum




End Class
