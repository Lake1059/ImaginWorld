Imports System.IO
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports Newtonsoft.Json

Public Class 启动流程
    Public Shared Async Sub 启动时加载全部模组的数据()
        DebugPrint($"开始加载数据", Color.Silver)

        Dim 计时器 As New Stopwatch()
        计时器.Start()

        DebugPrint($"SVG 矢量图以 {Form1.DPI * 100}% 的倍率进行绘制", Color.Silver)
        Await Task.Run(Sub()
                           数据中心.所有图像("WorkShopMods") = LoadImageFromFile(Path.Combine(Application.StartupPath, "Image", "WorkShopMods.png"))
                           数据中心.所有图像("LocalMods") = LoadImageFromFile(Path.Combine(Application.StartupPath, "Image", "LocalMods.png"))
                           数据中心.所有图像("DLCMods") = LoadImageFromFile(Path.Combine(Application.StartupPath, "Image", "DLCMods.png"))
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 图像文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Image")
                               If Not DirectoryExists(图像文件夹路径) Then Continue For
                               For Each 图像文件路径 In Directory.GetFiles(图像文件夹路径, "*.svg")
                                   Dim 图像名 = Path.GetFileNameWithoutExtension(图像文件路径)
                                   Dim 图像 = LaunchSvgToImage(图像文件路径)
                                   If 图像 IsNot Nothing Then 数据中心.所有图像(图像名) = 图像
                               Next
                               For Each 图像文件路径 In Directory.GetFiles(图像文件夹路径, "*.png")
                                   Dim 图像名 = Path.GetFileNameWithoutExtension(图像文件路径)
                                   Using fs As New FileStream(图像文件路径, FileMode.Open, FileAccess.Read)
                                       Dim 图像 = Image.FromStream(fs)
                                       If 图像 IsNot Nothing Then 数据中心.所有图像(图像名) = 图像
                                       fs.Close()
                                   End Using
                               Next
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"图像加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有图像.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 音乐文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Music")
                               If Not DirectoryExists(音乐文件夹路径) Then Exit For
                               For Each 音乐文件路径 In Directory.GetFiles(音乐文件夹路径, "*.mp3")
                                   数据中心.所有背景音乐(Path.GetFileNameWithoutExtension(音乐文件路径)) = 音乐文件路径
                               Next
                               For Each 音乐文件路径 In Directory.GetFiles(音乐文件夹路径, "*.flac")
                                   数据中心.所有背景音乐(Path.GetFileNameWithoutExtension(音乐文件路径)) = 音乐文件路径
                               Next
                               For Each 音乐文件路径 In Directory.GetFiles(音乐文件夹路径, "*.wav")
                                   数据中心.所有背景音乐(Path.GetFileNameWithoutExtension(音乐文件路径)) = 音乐文件路径
                               Next
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"音乐加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有背景音乐.Count}", Color.ForestGreen)
        计时器.Restart()


        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 特效音文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Sound")
                               If Not DirectoryExists(特效音文件夹路径) Then Exit For
                               For Each 特效音文件路径 In Directory.GetFiles(特效音文件夹路径, "*.wav")
                                   数据中心.所有特效声音(Path.GetFileNameWithoutExtension(特效音文件路径)) = ReadAllBytes(特效音文件路径)
                               Next
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"音效加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有特效声音.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 物品文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Item")
                               If Not DirectoryExists(物品文件夹路径) Then Exit For
                               For Each 物品文件路径 In Directory.GetFiles(物品文件夹路径, "*.json")
                                   Try
                                       Dim a As New List(Of 数据中心.物品数据结构)(JsonConvert.DeserializeObject(Of List(Of 数据中心.物品数据结构))(ReadAllText(物品文件路径)))
                                       For Each item In a
                                           数据中心.所有物品(item.ID) = item
                                       Next
                                   Catch ex As Exception
                                       DebugPrint($"加载物品失败：{ex.Message}，位于文件：{物品文件路径}", Color.Tomato)
                                   End Try
                               Next
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"物品加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有物品.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 武器文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Combat System", "Weapon")
                               If DirectoryExists(武器文件夹路径) Then
                                   For Each 武器文件路径 In Directory.GetFiles(武器文件夹路径, "*.json")
                                       Try
                                           Dim a As New List(Of 数据中心.武器数据结构)(JsonConvert.DeserializeObject(Of List(Of 数据中心.武器数据结构))(ReadAllText(武器文件路径)))
                                           For Each item In a
                                               数据中心.所有武器(item.ID) = item
                                           Next
                                       Catch ex As Exception
                                           DebugPrint($"加载武器失败：{ex.Message}，位于文件：{武器文件路径}", Color.Tomato)
                                       End Try
                                   Next
                               End If
                               Dim 武器类型文件路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Combat System", "WeaponType.json")
                               If FileExists(武器类型文件路径) Then
                                   Try
                                       数据中心.所有武器类型.AddRange(JsonConvert.DeserializeObject(Of List(Of String))(ReadAllText(武器类型文件路径)))
                                   Catch ex As Exception
                                       DebugPrint($"加载武器类型失败：{ex.Message}，位于文件：{武器类型文件路径}", Color.Tomato)
                                   End Try
                               End If
                           Next
                       End Sub)
        数据中心.所有武器类型 = 数据中心.所有武器类型.Distinct().ToList()

        计时器.Stop()
        DebugPrint($"武器加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有武器.Count}，武器类型共计 {数据中心.所有武器类型.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 装备文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Equipment")
                               If DirectoryExists(装备文件夹路径) Then
                                   For Each 装备文件路径 In Directory.GetFiles(装备文件夹路径, "*.json")
                                       Try
                                           Dim a As New List(Of 数据中心.装备数据结构)(JsonConvert.DeserializeObject(Of List(Of 数据中心.装备数据结构))(ReadAllText(装备文件路径)))
                                           For Each item In a
                                               Select Case item.Type
                                                   Case 1, 2, 3, 5
                                                       数据中心.所有装备(item.ID) = item
                                               End Select
                                           Next
                                       Catch ex As Exception
                                           DebugPrint($"加载装备失败：{ex.Message}，位于文件：{装备文件路径}", Color.Tomato)
                                       End Try
                                   Next
                               End If
                               Dim 装备类型文件路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Combat System", "EquipmentType.json")
                               If FileExists(装备类型文件路径) Then
                                   Try
                                       数据中心.所有装备类型.AddRange(JsonConvert.DeserializeObject(Of List(Of String))(ReadAllText(装备类型文件路径)))
                                   Catch ex As Exception
                                       DebugPrint($"加载装备类型失败：{ex.Message}，位于文件：{装备类型文件路径}", Color.Tomato)
                                   End Try
                               End If
                           Next
                       End Sub)
        数据中心.所有装备类型 = 数据中心.所有装备类型.Distinct().ToList()

        计时器.Stop()
        DebugPrint($"装备加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有装备.Count}，装备类型共计 {数据中心.所有装备类型.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 角色文件夹路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Character")
                               If DirectoryExists(角色文件夹路径) Then
                                   For Each 角色文件路径 In Directory.GetFiles(角色文件夹路径, "*.json")
                                       Try
                                           Dim a = JsonConvert.DeserializeObject(Of 数据中心.角色数据结构)(ReadAllText(角色文件路径))
                                           If a.ID = "" Then Continue For
                                           数据中心.所有角色(a.ID) = a
                                       Catch ex As Exception
                                           DebugPrint($"加载角色失败：{ex.Message}，位于文件：{角色文件路径}", Color.Tomato)
                                       End Try
                                   Next
                               End If
                               Dim 角色职业类型文件路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Combat System", "ProfessionType.json")
                               If FileExists(角色职业类型文件路径) Then
                                   Try
                                       数据中心.所有角色职业类型.AddRange(JsonConvert.DeserializeObject(Of List(Of String))(ReadAllText(角色职业类型文件路径)))
                                   Catch ex As Exception
                                       DebugPrint($"加载角色职业类型失败：{ex.Message}，位于文件：{角色职业类型文件路径}", Color.Tomato)
                                   End Try
                               End If
                               Dim 角色属性类型文件路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Combat System", "PropertyType.json")
                               If FileExists(角色属性类型文件路径) Then
                                   Try
                                       数据中心.所有角色属性类型.AddRange(JsonConvert.DeserializeObject(Of List(Of String))(ReadAllText(角色属性类型文件路径)))
                                   Catch ex As Exception
                                       DebugPrint($"加载角色属性类型失败：{ex.Message}，位于文件：{角色属性类型文件路径}", Color.Tomato)
                                   End Try
                               End If
                           Next
                       End Sub)
        数据中心.所有角色职业类型 = 数据中心.所有角色职业类型.Distinct().ToList()
        数据中心.所有角色属性类型 = 数据中心.所有角色属性类型.Distinct().ToList()

        计时器.Stop()
        DebugPrint($"角色加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有角色.Count}，职业类型共计 {数据中心.所有角色职业类型.Count}，属性类型共计 {数据中心.所有角色属性类型.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 岗位文件路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Production System", "Job.json")
                               If Not FileExists(岗位文件路径) Then Exit For
                               Try
                                   Dim a As New List(Of 数据中心.岗位数据结构)(JsonConvert.DeserializeObject(Of List(Of 数据中心.岗位数据结构))(ReadAllText(岗位文件路径)))
                                   For Each item In a
                                       数据中心.所有岗位(item.ID) = item
                                   Next
                               Catch ex As Exception
                                   DebugPrint($"加载岗位失败：{ex.Message}，位于文件：{岗位文件路径}", Color.Tomato)
                               End Try
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"岗位加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有岗位.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 建筑文件路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Production System", "Building.json")
                               If Not FileExists(建筑文件路径) Then Exit For
                               Try
                                   Dim a As New List(Of 数据中心.建筑数据结构)(JsonConvert.DeserializeObject(Of List(Of 数据中心.建筑数据结构))(ReadAllText(建筑文件路径)))
                                   For Each item In a
                                       数据中心.所有建筑(item.ID) = item
                                   Next
                               Catch ex As Exception
                                   DebugPrint($"加载建筑失败：{ex.Message}，位于文件：{建筑文件路径}", Color.Tomato)
                               End Try
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"建筑加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有建筑.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 环境文件路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Production System", "Environment.json")
                               If Not FileExists(环境文件路径) Then Exit For
                               Try
                                   Dim a As New List(Of 数据中心.环境数据结构)(JsonConvert.DeserializeObject(Of List(Of 数据中心.环境数据结构))(ReadAllText(环境文件路径)))
                                   For Each item In a
                                       数据中心.所有环境(item.ID) = item
                                   Next
                               Catch ex As Exception
                                   DebugPrint($"加载环境失败：{ex.Message}，位于文件：{环境文件路径}", Color.Tomato)
                               End Try
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"环境加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有环境.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 物种文件路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Production System", "Species.json")
                               If Not FileExists(物种文件路径) Then Exit For
                               Try
                                   Dim a As New List(Of 数据中心.物种数据结构)(JsonConvert.DeserializeObject(Of List(Of 数据中心.物种数据结构))(ReadAllText(物种文件路径)))
                                   For Each item In a
                                       数据中心.所有物种(item.ID) = item
                                   Next
                               Catch ex As Exception
                                   DebugPrint($"加载物种失败：{ex.Message}，位于文件：{物种文件路径}", Color.Tomato)
                               End Try
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"物种加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有物种.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 科技文件路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Production System", "Technology.json")
                               If Not FileExists(科技文件路径) Then Exit For
                               Try
                                   Dim a As New List(Of 数据中心.科技数据结构)(JsonConvert.DeserializeObject(Of List(Of 数据中心.科技数据结构))(ReadAllText(科技文件路径)))
                                   For Each item In a
                                       数据中心.所有科技(item.ID) = item
                                   Next
                               Catch ex As Exception
                                   DebugPrint($"加载科技失败：{ex.Message}，位于文件：{科技文件路径}", Color.Tomato)
                               End Try
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"科技加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有科技.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 合成配方文件路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Production System", "CraftingRecipe.json")
                               If Not FileExists(合成配方文件路径) Then Exit For
                               Try
                                   Dim a As New List(Of 数据中心.合成配方数据结构)(JsonConvert.DeserializeObject(Of List(Of 数据中心.合成配方数据结构))(ReadAllText(合成配方文件路径)))
                                   For Each item In a
                                       数据中心.所有合成配方(item.ID) = item
                                   Next
                               Catch ex As Exception
                                   DebugPrint($"加载合成配方失败：{ex.Message}，位于文件：{合成配方文件路径}", Color.Tomato)
                               End Try
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"合成配方加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有合成配方.Count}", Color.ForestGreen)
        计时器.Restart()

        Await Task.Run(Sub()
                           For Each ModString In 模组管理.实际加载的模组列表
                               Dim 载具文件路径 = Path.Combine(模组管理.所有模组列表(ModString).ModPath, "Production System", "Vehicle.json")
                               If Not FileExists(载具文件路径) Then Exit For
                               Try
                                   Dim a As New List(Of 数据中心.载具数据结构)(JsonConvert.DeserializeObject(Of List(Of 数据中心.载具数据结构))(ReadAllText(载具文件路径)))
                                   For Each item In a
                                       数据中心.所有载具(item.ID) = item
                                   Next
                               Catch ex As Exception
                                   DebugPrint($"加载载具失败：{ex.Message}，位于文件：{载具文件路径}", Color.Tomato)
                               End Try
                           Next
                       End Sub)

        计时器.Stop()
        DebugPrint($"载具加载完成，耗时 {计时器.ElapsedMilliseconds / 1000} 秒，共计 {数据中心.所有载具.Count}", Color.ForestGreen)
        '计时器.Restart()






        Form1.加载时间计时器.Stop()
        DebugPrint($"加载完毕，总耗时：{Form1.加载时间计时器.ElapsedMilliseconds / 1000} 秒", Color.Silver)
        DebugPrint($"初始化 ...", Color.Silver)
        Application.DoEvents()

        全局键盘钩子.初始化全局键盘事件()
        服务器的消息响应.初始化()
        客户端的消息响应.初始化()

        Application.DoEvents()
        DebugPrint($"启动流程结束，2 秒后调出主菜单", Color.CornflowerBlue)
        Application.DoEvents()
        Await Task.Run(Sub() Threading.Thread.Sleep(2000))
        控制台界面实例.Visible = False
        控制台界面实例.启用可操作区域()
        界面控制.切换界面(界面控制.主界面图层.主层, New 界面主层_主菜单)
        声音控制.自动播放BGM定时器.Start()
    End Sub
End Class
