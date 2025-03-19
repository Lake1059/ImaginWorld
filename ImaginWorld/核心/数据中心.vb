Imports ImaginWorld.数据中心.角色数据结构

Public Class 数据中心
    Public Shared Property 所有图像 As New Dictionary(Of String, Image)
    Public Shared Property 所有背景音乐 As New Dictionary(Of String, String)
    Public Shared Property 所有特效声音 As New Dictionary(Of String, Byte())

    <Serializable>
    Public Class 列出物品单片结构
        Public Property TypeID As String = ""
        Public Property ItemID As String = ""
        Public Property Quantity As Object = 0
    End Class

    <Serializable>
    Public Class 物品数据结构
        Public Property ID As String = ""
        Public Property Type As String = ""
        Public Property UseSpace As Single = 0
        Public Property Effects As New List(Of 消耗品效果单片结构)
        Public Property ScriptKey As String = ""
        Public Property PlantingKey As String = ""
        <Serializable>
        Public Class 消耗品效果单片结构
            Public Property Type As Integer = 0
            Public Property Value As Object = 0
            Public Property Attribute As String = ""
        End Class
        Enum 消耗品效果类型
            恢复远行队中所有无法作战角色并增加指定的生命值 = 1
            恢复远行队中所有非无法作战角色生命值 = 2
            增加远行队中全体角色攻击力最终数值 = 3
            增加远行队中全体角色防御力最终数值 = 4
            增加远行队中全体角色速度最终数值 = 5
            增加远行队中全体角色暴击率最终数值 = 6
            增加远行队中全体角色暴击伤害最终数值 = 7
            增加远行队中全体角色自定义属性最终数值 = 10
        End Enum
    End Class
    Public Shared Property 所有物品 As New Dictionary(Of String, 物品数据结构)

    <Serializable>
    Public Class 武器数据结构
        Public Property ID As String = ""
        Public Property Type As String = ""
        Public Property UseSpace As Integer = 0
        Public Property StarRating As Integer = 0
        Public Property P_Attributes As New Dictionary(Of String, Object)
        Public Property P_Resistances As New Dictionary(Of String, Single)
    End Class
    Public Shared Property 所有武器 As New Dictionary(Of String, 武器数据结构)
    Public Shared Property 所有武器类型 As New List(Of String)

    <Serializable>
    Public Class 装备数据结构
        Public Property ID As String = ""
        Public Property Type As String = ""
        Public Property UseSpace As Integer = 0
        Public Property P_Attributes As New Dictionary(Of String, Object)
        Public Property P_Resistances As New Dictionary(Of String, Single)
    End Class
    Public Shared Property 所有装备 As New Dictionary(Of String, 装备数据结构)
    Public Shared Property 所有装备类型 As New List(Of String)

    <Serializable>
    Public Class 角色数据结构
        Public Property ID As String = ""
        Public Property StarRating As Integer = 0
        Public Property ProfessionType As String = ""
        Public Property PropertyType As String = ""
        Public Property P_Attributes As New Dictionary(Of String, Object) From {{"Health", 1000}, {"Attack", 100}, {"Defense", 100}, {"TB_Speed", 50}, {"RT_TimeSpeed_ms", 1000}, {"CriticalHitRate", 0}, {"CriticalDamage", 0}, {"SpaceProvided", 0}}
        Public Property P_Resistances As New Dictionary(Of String, Single)
        Public Property UseWeaponType As String = ""
        Public Property EquipmentSlots As New List(Of String)
        Public Property Skill_TB_Normal As New List(Of 技能数据单级结构)
        Public Property Skill_TB_Tactics As New List(Of 技能数据单级结构)
        Public Property Skill_TB_End As New List(Of 技能数据单级结构)
        Public Property Skill_RT_Normal As New List(Of 技能数据单级结构)
        Public Property Skill_RT_Tactics As New List(Of 技能数据单级结构)
        Public Property Skill_RT_End As New List(Of 技能数据单级结构)
        Public Property Talent1 As New List(Of 天赋单级结构)
        Public Property Talent2 As New List(Of 天赋单级结构)
        Public Property Talent3 As New List(Of 天赋单级结构)
        Public Property Story As New List(Of 资料单条结构)
        Public Property Consumption_InLocation As New List(Of 列出物品单片结构)
        Public Property Consumption_OnMap As New List(Of 列出物品单片结构)

        <Serializable>
        Public Class 技能数据单级结构
            Public Property ID As String = ""
            Public Property SkillContent As New List(Of 技能单段动作结构)
            Public Property TB_TacticsRequireSkillSlots As Integer = 0 '回合制的战技需要的技能槽数值
            Public Property TB_SkillSlotsChange As Integer = 0 '回合制执行此技能后技能槽要如何变化
            Public Property TB_SkillEndSlotsChange As Single = 0 '回合制执行此技能后终结技充能进度要如何变化
            Public Property RT_NormalToTacticsNumber As Integer = 0 '即时模式执行几次普通攻击后执行一次战技
            Public Property AutoBattleFlag As String = ""
            Public Property UpgradeRequirements As New List(Of 列出物品单片结构)
        End Class
        <Serializable>
        Public Class 技能单段动作结构
            Public Property SkillType As 技能类型 = 0
            Public Property PropertyType As String = ""
            Public Property ValueType As String = ""
            Public Property Value As Single = 0
            Public Property FinalValueAdd As Integer = 0
            Public Property BuffID As String = ""
            Public Property BuffTime As Integer = 0
        End Class
        <Serializable>
        Public Class 天赋单级结构
            Public Property ID As String = ""
            Public Property P_Attributes As New Dictionary(Of String, Object)
            Public Property P_Resistances As New Dictionary(Of String, Single)
            Public Property UpgradeRequirements As New List(Of 列出物品单片结构)
        End Class
        <Serializable>
        Public Class 资料单条结构
            Public Property StoryID As String = ""
            Public Property Unlock As Boolean = False
        End Class
        Enum 技能类型
            未指定 = 0
            回合制_对敌单体伤害 = 101
            回合制_对敌相邻两位伤害 = 102
            回合制_对敌相邻四位伤害 = 103
            回合制_对敌全体伤害 = 104
            回合制_对敌单体Buff = 111
            回合制_对敌相邻两位Buff = 112
            回合制_对敌相邻四位Buff = 113
            回合制_对敌全体Buff = 114
            回合制_对友单体治疗 = 121
            回合制_对友相邻两位治疗 = 122
            回合制_对友全体治疗 = 123
            回合制_对友单体加盾 = 131
            回合制_对友全体加盾 = 132
            回合制_对友单体BUFF = 141
            回合制_对友全体BUFF = 142
            即时制_对敌前排一位伤害 = 201
            即时制_对敌前排两位伤害 = 202
            即时制_对敌前排三位伤害 = 203
            即时制_对敌前排四位伤害 = 204
            即时制_对敌前排五位伤害 = 205
            即时制_对敌前排全体伤害 = 209
            即时制_对敌前排生命值百分比最低一位伤害 = 211
            即时制_对敌前排防御力最低一位伤害 = 222
            即时制_对友生命值百分比最低一位治疗 = 231
            即时制_对友全体治疗 = 232
            即时制_对友全体加盾 = 241
            即时制_对友全体BUFF = 251
        End Enum
        Enum 自动战斗系统标记
            回合制_普通的单体攻击_优先打血量最少的目标 = 1001
            回合制_强大的单体攻击_优先打血量最多的目标 = 1002
            回合制_强大的单体攻击_优先打血量最少的目标 = 1003
            回合制_普通的群体攻击_优先覆盖最多目标数量 = 1011
            回合制_强大的群体攻击_优先打血量最多的目标 = 1012
            回合制_强大的群体攻击_优先打位于中心的目标 = 1013
            回合制_普通的单体加盾_优先给血量最少的角色 = 1021
            回合制_普通的单体加盾_优先给防御最低的角色 = 1022
            回合制_强大的单体加盾_优先给血量最少的角色 = 1023
            回合制_普通的全体加盾_优先使用 = 1024
            回合制_普通的全体加盾_不要优先使用 = 1025
            回合制_强大的全体加盾_优先使用 = 1026
            回合制_强大的全体加盾_不要优先使用 = 1027
            回合制_通的单体治疗_只给低于三分之二血的角色 = 1031
            回合制_强大的单体治疗_只给低于三分之一血的角色 = 1032
            回合制_普通的全体治疗_优先使用 = 1033
            回合制_强大的全体治疗_有角色低于三分之一血再用 = 1034
            回合制_普通的DEBUFF_技能槽超过一半再用 = 1041
            回合制_强大的DEBUFF_能用就用 = 1042
            回合制_普通的BUFF_技能槽超过一半再用 = 1051
            回合制_强大的BUFF_能用就用 = 1052
            回合制_通用囤积技能槽模式 = 1111
            即时制_单体攻击_有精英及以上的目标才用 = 2001
            即时制_群体攻击_至少3个目标才用 = 2011
            即时制_加盾_有角色盾量不足则立即使用 = 2021
            即时制_治疗_有角色低于四分之一血则立即使用 = 2031
            即时制_疗_有角色低于半血则立即使用 = 2032
            即时制_DEBUFF_有不带的目标则立即使用 = 2041
            即时制_BUFF_有不带的角色则立即使用 = 2051
        End Enum
    End Class
    Public Shared Property 所有角色 As New Dictionary(Of String, 角色数据结构)
    Public Shared Property 所有角色自定义属性 As New List(Of String)
    Public Shared Property 所有角色职业类型 As New List(Of String)
    Public Shared Property 所有角色属性类型 As New List(Of String)

    Public Class 敌人数据结构
        Public Property ID As String = ""
        Public Property StarRating As Integer = 0
        Public Property PropertyType As String = ""
        Public Property P_Attributes As New Dictionary(Of String, Object) From {{"Health", 1000}, {"Attack", 100}, {"Defense", 100}, {"TB_Speed", 10}, {"RT_TimeSpeed_ms", 1000}, {"CriticalHitRate", 0}, {"CriticalDamage", 0}}
        Public Property P_Resistances As New Dictionary(Of String, Single)
        Public Property Skill_TB_Normal As 敌人技能数据结构
        Public Property Skill_TB_Tactics As 敌人技能数据结构
        Public Property Skill_TB_End As 敌人技能数据结构
        Public Property Skill_RT_Normal As 敌人技能数据结构
        Public Property Skill_RT_Tactics As 敌人技能数据结构
        Public Property Skill_RT_End As 敌人技能数据结构
        Public Property IsBoss As Boolean = False
        <Serializable>
        Public Class 敌人技能数据结构
            Public Property ID As String = ""
            Public Property SkillContent As New List(Of 技能单段动作结构)
            Public Property TB_TacticsRequireSkillSlots As Integer = 0
            Public Property TB_SkillSlotsChange As Integer = 0
            Public Property TB_SkillEndSlotsChange As Single = 0
            Public Property RT_NormalToTacticsNumber As Integer = 0
            Public Property AutoBattleFlag As String = ""
        End Class
        Enum 敌人技能类型
            回合制_对玩家单体伤害 = 101
            回合制_对玩家相邻两位伤害 = 102
            回合制_对玩家全体伤害 = 104
            回合制_对玩家单体BUFF = 111
            回合制_对玩家相邻两位BUFF = 112
            回合制_对玩家全体Buff = 114
            回合制_对友单体治疗 = 121
            回合制_对友相邻两位治疗 = 122
            回合制_对友全体治疗 = 123
            回合制_对友单体加盾 = 131
            回合制_对友全体加盾 = 132
            回合制_对友单体BUFF = 141
            回合制_对友全体BUFF = 142
            即时制_对玩家一位伤害 = 201
            即时制_对玩家两位伤害 = 202
            即时制_对玩家三位伤害 = 203
            即时制_对玩家四位伤害 = 204
            即时制_对玩家全体伤害 = 209
            即时制_对玩家全体BUFF = 219
            即时制_对友生命值百分比最低一位治疗 = 231
            即时制_对友全体治疗 = 232
            即时制_对友全体加盾 = 241
            即时制_对友全体BUFF = 251
        End Enum
    End Class
    Public Shared Property 所有敌人 As New Dictionary(Of String, 敌人数据结构)

    <Serializable>
    Public Class BUFF数据结构
        Public Property ID As String = ""
        Public Property ValueChanges As New Dictionary(Of String, Object)
        Public Property PercentChanges As New Dictionary(Of String, Object)
    End Class
    Public Shared Property 所有BUFF As New Dictionary(Of String, BUFF数据结构)


    <Serializable>
    Public Class 回合制对局单场结构

    End Class






    <Serializable>
    Public Class 岗位数据结构
        Public Property ID As String = ""
        Public Property ResourcesProducedPerHour As New List(Of 列出物品单片结构)
        Public Property ResourcesConsumptionPerHour As New List(Of 列出物品单片结构)
    End Class
    Public Shared Property 所有岗位 As New Dictionary(Of String, 岗位数据结构)

        <Serializable>
        Public Class 建筑数据结构
            Public Property ID As String = ""
            Public Property Jobs As New List(Of KeyValuePair(Of String, Integer))
            Public Property ConstructionTimeHour As Integer = 0
        End Class
        Public Shared Property 所有建筑 As New Dictionary(Of String, 建筑数据结构)

        <Serializable>
        Public Class 环境数据结构
            Public Property ID As String = ""
            Public Property Jobs As New List(Of KeyValuePair(Of String, Integer))
        End Class
        Public Shared Property 所有环境 As New Dictionary(Of String, 环境数据结构)

        <Serializable>
        Public Class 物种数据结构
            Public Property ID As String = ""
            Public Property ProductionRatio As Single = 1
            Public Property ConsumptionRatio As Single = 1
            Public Property TotalWarHealthBonus As Single = 1
            Public Property TotalWarAttackBonus As Single = 1
            Public Property TotalWarDefenseBonus As Single = 1
        End Class
        Public Shared Property 所有物种 As New Dictionary(Of String, 物种数据结构)

        <Serializable>
        Public Class 科技数据结构
            Public Property ID As String = ""
            Public Property DeliverCost As New List(Of KeyValuePair(Of String, Integer))
            Public Property ForcedUnlockCraftingRecipe As New List(Of String)
            Public Property ForcedUnlockBuildings As New List(Of String)
        End Class
        Public Shared Property 所有科技 As New Dictionary(Of String, 科技数据结构)

        <Serializable>
        Public Class 合成配方数据结构
            Public Property ID As String = ""
            Public Property Cost As New List(Of KeyValuePair(Of String, Integer))
        End Class
        Public Shared Property 所有合成配方 As New Dictionary(Of String, 合成配方数据结构)

        <Serializable>
        Public Class 载具数据结构
            Public Property ID As String = ""
            Public Property SpaceProvided As Single = 100
            Public Property ItemConsumed As String = ""
            Public Property ConsumptionPerGrid As Single = 0.001
        End Class
        Public Shared Property 所有载具 As New Dictionary(Of String, 载具数据结构)


















    End Class
