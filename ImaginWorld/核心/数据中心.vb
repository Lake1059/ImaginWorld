Imports System.IO
Imports System.Text.Json
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports Newtonsoft.Json

Public Class 数据中心
    Public Shared Property 所有图像 As New Dictionary(Of String, Image)
    Public Shared Property 所有背景音乐 As New Dictionary(Of String, String)
    Public Shared Property 所有特效声音 As New Dictionary(Of String, Byte())

    <Serializable>
    Public Class 物品数据结构
        Public Property ID As String = ""
        Public Property Type As Integer = 0
        Public Property UseWeights As Single = 0
        Public Property Effects As New List(Of 消耗品效果单片结构)
        Public Property ScriptKey As String = ""
        Public Property PlantingKey As String = ""
        <Serializable>
        Public Class 消耗品效果单片结构
            Public Property Type As Integer = 0
            Public Property Value As Single = 0
        End Class
    End Class
    Public Shared Property 所有物品 As New Dictionary(Of String, 物品数据结构)

    <Serializable>
    Public Class 武器数据结构
        Public Property ID As String = ""
        Public Property Type As 武器类型 = 0
        Public Property UseWeights As Single = 0
        Public Property StarRating As Integer = 0
        Public Property CharacterProperty As New 角色基本属性数据结构
        Enum 武器类型
            未指定 = 0
            近战 = 1
            投掷 = 2
            弓箭 = 3
            法器 = 4
            火器 = 5
        End Enum
    End Class
    Public Shared Property 所有武器 As New Dictionary(Of String, 武器数据结构)

    <Serializable>
    Public Class 角色基本属性数据结构
        Public Property Health As Integer = 0
        Public Property Attack As Integer = 0
        Public Property Defense As Integer = 0
        Public Property Speed As Integer = 0
        Public Property CriticalHitRate As Single = 0
        Public Property CriticalDamage As Single = 0
        Public Property ResistRate As Single = 0
        Public Property FillingEfficiency As Single = 0
        Public Property ShieldBonus As Single = 0
        Public Property HealingBonus As Single = 0
        Public Property PhysicalDamageBonus As Single = 0
        Public Property MagicDamageBonus As Single = 0
        Public Property BiochemicalDamageBonus As Single = 0
        Public Property MysticDamageBonus As Single = 0
        Public Property MaterialDamageBonus As Single = 0
        Public Property DarkDamageBonus As Single = 0
        Public Property PhysicalResistance As Single = 0
        Public Property MagicResistance As Single = 0
        Public Property BiochemicalResistance As Single = 0
        Public Property MysticResistance As Single = 0
        Public Property MaterialResistance As Single = 0
        Public Property DarkResistance As Single = 0
        Public Property WeightProvided As Integer = 0
    End Class

    <Serializable>
    Public Class 装备数据结构
        Public Property ID As String = ""
        Public Property Type As 装备部件类型 = 0
        Public Property UseWeights As Single = 0
        Public Property CharacterProperty As New 角色基本属性数据结构
        Enum 装备部件类型
            未指定 = 0
            头部 = 1
            躯干 = 2
            腿部 = 3
            奇物 = 5
        End Enum
    End Class
    Public Shared Property 所有装备 As New Dictionary(Of String, 装备数据结构)

    <Serializable>
    Public Class 角色数据结构
        Public Property ID As String = ""
        Public Property StarRating As Integer = 0
        Public Property ProfessionType As 职业类型 = 0
        Public Property PropertyType As 属性类型 = 0
        Public Property PropertyData As New 角色基本属性数据结构
        Public Property UseWeaponType As 武器数据结构.武器类型 = 0
        Public Property Skill_TB_Normal As New List(Of 技能数据单级结构)
        Public Property Skill_TB_Tactics As New List(Of 技能数据单级结构)
        Public Property Skill_TB_End As New List(Of 技能数据单级结构)
        Public Property Skill_TB_NormalToEnd_AddValue As Integer = 10
        Public Property Skill_TB_TacticsToEnd_AddValue As Integer = 10
        Public Property Skill_TB_EndCostValue As Integer = 50

        Public Property Skill_RT_Normal As New List(Of 技能数据单级结构)
        Public Property Skill_RT_Tactics As New List(Of 技能数据单级结构)
        Public Property Skill_RT_End As New List(Of 技能数据单级结构)
        Public Property Skill_RT_TimeSpeed_Millisecond As Integer = 500
        Public Property Skill_RT_NormalToTacticsNumber As Integer = 2
        Public Property Skill_RT_NormalToEnd_AddValue As Single = 0.1
        Public Property Skill_RT_TacticsToEnd_AddValue As Single = 0.1

        Public Property Talent1 As New List(Of 天赋单级结构)
        Public Property Talent2 As New List(Of 天赋单级结构)
        Public Property Talent3 As New List(Of 天赋单级结构)

        Public Property Story As New List(Of KeyValuePair(Of String, String))

        <Serializable>
        Public Class 技能数据单级结构
            Public Property SkillContent As New List(Of 技能单段动作结构)
            Public Property UpgradeRequirements As New List(Of KeyValuePair(Of String, Integer))
        End Class
        <Serializable>
        Public Class 技能单段动作结构
            Public Property SkillType As 技能类型 = 0
            Public Property PropertyType As 属性类型 = 0
            Public Property ValueType As 基准数值类型 = 0
            Public Property Value As Object = Nothing
            Public Property FinalValueAdd As Integer = 0
        End Class
        <Serializable>
        Public Class 天赋单级结构
            Public Property TalentContent As New 角色基本属性数据结构
            Public Property UpgradeRequirements As New List(Of KeyValuePair(Of String, Integer))
        End Class

        Enum 职业类型
            未指定 = 0
            生存 = 1
            强攻 = 2
            群攻 = 3
            辅助 = 4
            治疗 = 5
        End Enum
        Enum 属性类型
            未指定 = 0
            物理 = 1
            法术 = 2
            生化 = 3
            神秘 = 4
            物质 = 5
            黑暗 = 6
        End Enum
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
            即时制_对敌全体伤害 = 209
            即时制_对敌生命值百分比最低一位伤害 = 211
            即时制_对敌防御力最低一位伤害 = 212
            即时制_对友生命值百分比最低一位治疗 = 221
            即时制_对友全体治疗 = 222
            即时制_对友全体加盾 = 231
            即时制_对友全体BUFF = 241
        End Enum
        Enum 基准数值类型
            未指定 = 0
            生命 = 1
            攻击 = 2
            防御 = 3
        End Enum
    End Class
    Public Shared Property 所有角色 As New Dictionary(Of String, 角色数据结构)

    <Serializable>
    Public Class 建筑数据结构
        Public Property ID As String = ""



    End Class





    Public Shared Async Sub 启动时加载全部模组的数据()
        DebugPrint($"开始加载数据", Color.Silver)

        Dim 计时器 As New Stopwatch()
        计时器.Start()

        DebugPrint($"SVG 矢量图以 {Form1.DPI * 100}% 的倍率进行绘制", Color.Silver)
        Await Task.Run(Sub()
                           所有图像("WorkShopMods") = LoadImageFromFile(Path.Combine(Application.StartupPath, "Image", "WorkShopMods.png"))
                           所有图像("LocalMods") = LoadImageFromFile(Path.Combine(Application.StartupPath, "Image", "LocalMods.png"))
                           所有图像("DLCMods") = LoadImageFromFile(Path.Combine(Application.StartupPath, "Image", "DLCMods.png"))
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 图像文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Image")
                               If Not DirectoryExists(图像文件夹路径) Then Continue For
                               For Each 图像文件路径 In Directory.GetFiles(图像文件夹路径, "*.svg")
                                   Dim 图像名 = Path.GetFileNameWithoutExtension(图像文件路径)
                                   Dim 图像 = LaunchSvgToImage(图像文件路径)
                                   If 图像 IsNot Nothing Then 所有图像(图像名) = 图像
                               Next
                               For Each 图像文件路径 In Directory.GetFiles(图像文件夹路径, "*.png")
                                   Dim 图像名 = Path.GetFileNameWithoutExtension(图像文件路径)
                                   Using fs As New FileStream(图像文件路径, FileMode.Open, FileAccess.Read)
                                       Dim 图像 = Image.FromStream(fs)
                                       If 图像 IsNot Nothing Then 所有图像(图像名) = 图像
                                       fs.Close()
                                   End Using
                               Next
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"图像加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {所有图像.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 音乐文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Music")
                               If Not DirectoryExists(音乐文件夹路径) Then Exit For
                               For Each 音乐文件路径 In Directory.GetFiles(音乐文件夹路径, "*.mp3")
                                   所有背景音乐(Path.GetFileNameWithoutExtension(音乐文件路径)) = 音乐文件路径
                               Next
                               For Each 音乐文件路径 In Directory.GetFiles(音乐文件夹路径, "*.flac")
                                   所有背景音乐(Path.GetFileNameWithoutExtension(音乐文件路径)) = 音乐文件路径
                               Next
                               For Each 音乐文件路径 In Directory.GetFiles(音乐文件夹路径, "*.wav")
                                   所有背景音乐(Path.GetFileNameWithoutExtension(音乐文件路径)) = 音乐文件路径
                               Next
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"音乐加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {所有背景音乐.Count}", Color.ForestGreen)
        计时器.Restart()


        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 特效音文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Sound")
                               If Not DirectoryExists(特效音文件夹路径) Then Exit For
                               For Each 特效音文件路径 In Directory.GetFiles(特效音文件夹路径, "*.wav")
                                   所有特效声音(Path.GetFileNameWithoutExtension(特效音文件路径)) = ReadAllBytes(特效音文件路径)
                               Next
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"音效加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {所有特效声音.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 物品文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Item")
                               If Not DirectoryExists(物品文件夹路径) Then Exit For
                               For Each 物品文件路径 In Directory.GetFiles(物品文件夹路径, "*.json")
                                   Try
                                       Dim a As New List(Of 物品数据结构)(JsonConvert.DeserializeObject(Of List(Of 物品数据结构))(ReadAllText(物品文件路径)))
                                       For Each item In a
                                           所有物品(item.ID) = item
                                       Next
                                   Catch ex As Exception
                                       Form1.Invoke(Sub() DebugPrint($"加载物品失败：{ex.Message}，位于文件：{物品文件路径}", Color.Tomato))
                                   End Try
                               Next
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"物品加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {所有物品.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 武器文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Weapon")
                               If Not DirectoryExists(武器文件夹路径) Then Exit For
                               For Each 武器文件路径 In Directory.GetFiles(武器文件夹路径, "*.json")
                                   Try
                                       Dim a As New List(Of 武器数据结构)(JsonConvert.DeserializeObject(Of List(Of 武器数据结构))(ReadAllText(武器文件路径)))
                                       For Each item In a
                                           Select Case item.Type
                                               Case 1, 2, 3, 4, 5
                                                   所有武器(item.ID) = item
                                           End Select
                                       Next
                                   Catch ex As Exception
                                       Form1.Invoke(Sub() DebugPrint($"加载武器失败：{ex.Message}，位于文件：{武器文件路径}", Color.Tomato))
                                   End Try
                               Next
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"武器加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {所有武器.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 装备文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Equipment")
                               If Not DirectoryExists(装备文件夹路径) Then Exit For
                               For Each 装备文件路径 In Directory.GetFiles(装备文件夹路径, "*.json")
                                   Try
                                       Dim a As New List(Of 装备数据结构)(JsonConvert.DeserializeObject(Of List(Of 装备数据结构))(ReadAllText(装备文件路径)))
                                       For Each item In a
                                           Select Case item.Type
                                               Case 1, 2, 3, 5
                                                   所有装备(item.ID) = item
                                           End Select
                                       Next
                                   Catch ex As Exception
                                       Form1.Invoke(Sub() DebugPrint($"加载装备失败：{ex.Message}，位于文件：{装备文件路径}", Color.Tomato))
                                   End Try
                               Next
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"装备加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {所有装备.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 角色文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Character")
                               If Not DirectoryExists(角色文件夹路径) Then Exit For
                               For Each 角色文件路径 In Directory.GetFiles(角色文件夹路径, "*.json")
                                   Try
                                       Dim a As New 角色数据结构
                                       a = JsonConvert.DeserializeObject(Of 角色数据结构)(ReadAllText(角色文件路径))
                                       If a.ID = "" Then Continue For
                                       所有角色(a.ID) = a
                                   Catch ex As Exception
                                       Form1.Invoke(Sub() DebugPrint($"加载角色失败：{ex.Message}，位于文件：{角色文件路径}", Color.Tomato))
                                   End Try
                               Next
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"角色加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {所有角色.Count}", Color.ForestGreen)
        '计时器.Restart()








        DebugPrint($"加载完毕，总耗时：{Form1.加载时间计时器.ElapsedMilliseconds / 1000} 秒", Color.Silver)
        DebugPrint($"初始化 ...", Color.Silver)
        Application.DoEvents()
        全局键盘钩子.初始化全局键盘事件()
        Await Task.Run(Sub() Threading.Thread.Sleep(2000))

        控制台界面实例.Visible = False
        控制台界面实例.启用可操作区域()


        界面控制.切换界面(界面控制.主界面图层.主层, New 界面主层_主菜单)
        DebugPrint($"启动流程结束", Color.CornflowerBlue)
    End Sub





End Class
