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
    End Class
    <Serializable>
    Public Class 消耗品效果单片结构
        Public Property Type As Integer = 0
        Public Property Value As Single = 0
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
            单手剑 = 1
            双手剑 = 2
            弓箭 = 3
            法器 = 4
            火器 = 5
        End Enum
    End Class
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
    Public Shared Property 所有武器 As New Dictionary(Of String, 武器数据结构)






    Public Shared Async Sub 启动时加载全部模组的数据()
        DebugPrint($"开始加载数据", Color.Silver)

        Dim 计时器 As New Stopwatch()
        计时器.Start()

        DebugPrint($"SVG 矢量图以 {Form1.DPI * 100}% 的倍率进行绘制", Color.Silver)
        Await Task.Run(Sub()
                           所有图像.Add("WorkShopMods", LoadImageFromFile(Path.Combine(Application.StartupPath, "Image", "WorkShopMods.png")))
                           所有图像.Add("LocalMods", LoadImageFromFile(Path.Combine(Application.StartupPath, "Image", "LocalMods.png")))
                           所有图像.Add("DLCMods", LoadImageFromFile(Path.Combine(Application.StartupPath, "Image", "DLCMods.png")))
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 图像文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Image")
                               If Not DirectoryExists(图像文件夹路径) Then Continue For
                               For Each 图像文件路径 In Directory.GetFiles(图像文件夹路径, "*.svg")
                                   Dim 图像名 = Path.GetFileNameWithoutExtension(图像文件路径)
                                   Dim 图像 = LaunchSvgToImage(图像文件路径)
                                   If 图像 IsNot Nothing Then 所有图像.Add(图像名, 图像)
                               Next
                               For Each 图像文件路径 In Directory.GetFiles(图像文件夹路径, "*.png")
                                   Dim 图像名 = Path.GetFileNameWithoutExtension(图像文件路径)
                                   Using fs As New FileStream(图像文件路径, FileMode.Open, FileAccess.Read)
                                       Dim 图像 = Image.FromStream(fs)
                                       If 图像 IsNot Nothing Then 所有图像.Add(图像名, 图像)
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
                               For Each 音乐文件路径 In Directory.GetFiles(音乐文件夹路径, "*.*")
                                   所有背景音乐.Add(Path.GetFileNameWithoutExtension(音乐文件路径), 音乐文件路径)
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
                                   所有特效声音.Add(Path.GetFileNameWithoutExtension(特效音文件路径), ReadAllBytes(特效音文件路径))
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
                                           所有物品.Add(item.ID, item)
                                       Next
                                   Catch ex As Exception
                                       Form1.Invoke(Sub() DebugPrint($"加载物品文件失败：{ex.Message}，位于文件：{物品文件路径}", Color.Tomato))
                                   End Try
                               Next
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"物品加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {所有物品.Count}", Color.ForestGreen)
        '计时器.Restart()











        DebugPrint($"加载完毕，总耗时：{Form1.加载时间计时器.ElapsedMilliseconds / 1000} 秒", Color.Silver)
        DebugPrint($"等待主菜单 ...", Color.Silver)
        Application.DoEvents()
        Await Task.Run(Sub() Threading.Thread.Sleep(2000))

        控制台界面实例.Visible = False
        控制台界面实例.启用可操作区域()

        界面控制.切换界面(界面控制.主界面图层.主层, New 界面主层_主菜单)
        DebugPrint($"启动流程结束", Color.CornflowerBlue)
    End Sub





End Class
