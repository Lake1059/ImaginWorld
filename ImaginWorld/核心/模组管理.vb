Imports System.IO
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports Newtonsoft.Json
Public Class 模组管理

    <Serializable>
    Public Class 清单文件数据结构
        Public Property ModPath As String
        Public Property ModName As String
        Public Property Author As String
        Public Property Version As String
        Public Property UniqueID As String
        Public Property Description As String
        Public Property SupportedGameVersion As New List(Of String)
        Public Property UnSupportedGameVersion As New List(Of String)
        Public Property AgeRating As String
        Public Property Tag As New List(Of String)
        Public Property Dependencies As New List(Of String)
        Public Property LoadDll As New List(Of String)
    End Class

    ''' <summary>
    ''' 来源.UniqueID
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property 所有模组列表 As New Dictionary(Of String, 清单文件数据结构)
    ''' <summary>
    ''' 来源.UniqueID
    ''' </summary>
    ''' <returns></returns>
    Public Shared Property 实际加载的模组列表 As New List(Of String)

    Public Shared Async Sub 启动时扫描模组()
        所有模组列表.Clear()
        Dim FinalTown清单文件路径 = Path.Combine(Application.StartupPath, "DLC", "FinalTown", "Manifest.json")
        If FileExists(FinalTown清单文件路径) Then
            Try
                Dim 模组清单数据 As 清单文件数据结构 = JsonConvert.DeserializeObject(Of 清单文件数据结构)(ReadAllText(FinalTown清单文件路径))
                If 模组清单数据 Is Nothing Then GoTo 开始扫描创意工坊模组
                If 模组清单数据.UniqueID Is Nothing Then GoTo 开始扫描创意工坊模组
                模组清单数据.ModPath = Path.Combine(Application.StartupPath, "DLC", "FinalTown")
                所有模组列表.Add("DLC." & 模组清单数据.UniqueID, 模组清单数据)
                DebugPrint($"已加载清单：{模组清单数据.ModName}", Color.Silver)
            Catch ex As Exception
                DebugPrint($"转换清单数据失败：{ex.Message}，位于：FinalTown", Color.Tomato)
            End Try
        End If
        Application.DoEvents()

开始扫描创意工坊模组:

        If 状态信息.Steam_是否完成了初始化 Then
            Dim 创意工坊模组文件夹列表 As New List(Of String)(创意工坊.获取已订阅物品的安装路径())
            Await Task.Run(Sub()
                               Form1.重新创建句柄()
                               For Each ModPath In 创意工坊模组文件夹列表
                                   Dim 清单文件路径 = Path.Combine(ModPath, "Manifest.json")
                                   If Not FileExists(清单文件路径) Then Continue For
                                   Try
                                       Dim 模组清单数据 As 清单文件数据结构 = JsonConvert.DeserializeObject(Of 清单文件数据结构)(ReadAllText(清单文件路径))
                                       If 模组清单数据 Is Nothing Then Continue For
                                       If 模组清单数据.UniqueID Is Nothing Then Continue For
                                       模组清单数据.ModPath = ModPath
                                       所有模组列表.Add("SteamWorkShop." & 模组清单数据.UniqueID, 模组清单数据)
                                       Form1.Invoke(Sub() DebugPrint($"已加载清单：{模组清单数据.ModName}", Color.Silver))
                                   Catch ex As Exception
                                       Form1.Invoke(Sub() DebugPrint($"转换清单数据失败：{ex.Message}，位于模组：{ModPath}", Color.Tomato))
                                   End Try
                               Next
                           End Sub)
        End If
        Application.DoEvents()

        Dim 本地模组文件夹列表 As New List(Of String)(GetDirectories(Path.Combine(Application.StartupPath, "Mods")))
        Await Task.Run(Sub()
                           Form1.重新创建句柄()
                           For Each ModPath In 本地模组文件夹列表
                               Dim 清单文件路径 = Path.Combine(ModPath, "Manifest.json")
                               If Not FileExists(清单文件路径) Then Continue For
                               Try
                                   Dim 模组清单数据 As 清单文件数据结构 = JsonConvert.DeserializeObject(Of 清单文件数据结构)(ReadAllText(清单文件路径))
                                   If 模组清单数据 Is Nothing Then Continue For
                                   If 模组清单数据.UniqueID Is Nothing Then Continue For
                                   模组清单数据.ModPath = ModPath
                                   所有模组列表.Add("Local." & 模组清单数据.UniqueID, 模组清单数据)
                                   Form1.Invoke(Sub() DebugPrint($"已加载清单：{模组清单数据.ModName}", Color.Silver))
                               Catch ex As Exception
                                   Form1.Invoke(Sub() DebugPrint($"转换清单数据失败：{ex.Message}，位于模组：{ModPath}", Color.Tomato))
                               End Try
                           Next
                       End Sub)

        Application.DoEvents()

        实际加载的模组列表.Clear()
        Dim 排序文件路径 = Path.Combine(Application.StartupPath, "PlayerData", "ModsSort.json")
        Dim 读取到的排序 As New List(Of String)
        If Not FileExists(排序文件路径) Then GoTo 开始检查排序
        Try
            读取到的排序 = JsonConvert.DeserializeObject(Of List(Of String))(ReadAllText(排序文件路径))
        Catch ex As Exception
            Form1.Invoke(Sub() DebugPrint($"加载模组排序失败：{ex.Message}", Color.Tomato))
        End Try
开始检查排序:
        If 读取到的排序.Count = 0 And 所有模组列表.ContainsKey("DLC.Lake1059.FinalTown") Then
            实际加载的模组列表.Add("DLC.Lake1059.FinalTown")
        End If
        For Each ModSort In 读取到的排序
            If 所有模组列表.ContainsKey(ModSort) Then
                实际加载的模组列表.Add(ModSort)
            End If
        Next
        If 实际加载的模组列表.Count = 0 And 所有模组列表.ContainsKey("DLC.Lake1059.FinalTown") Then
            实际加载的模组列表.Add("DLC.Lake1059.FinalTown")
        End If
        Form1.Invoke(Sub() DebugPrint($"已识别模组数量：{所有模组列表.Count}，在启动列表中的模组数量：{实际加载的模组列表.Count}", Color.CornflowerBlue))

        启动流程.启动时加载全部模组的数据()
    End Sub


    Public Shared Property 临时所有模组列表 As New Dictionary(Of String, 清单文件数据结构)

    Public Shared Async Sub 重新扫描模组()
        临时所有模组列表.Clear()
        Dim value As 清单文件数据结构 = Nothing
        If 所有模组列表.TryGetValue("DLC.Lake1059.FinalTown", value) Then 临时所有模组列表.Add("DLC.Lake1059.FinalTown", value)

        If 状态信息.Steam_是否完成了初始化 Then
            Dim 创意工坊模组文件夹列表 As New List(Of String)(创意工坊.获取已订阅物品的安装路径())
            Await Task.Run(Sub()
                               For Each ModPath In 创意工坊模组文件夹列表
                                   Dim 清单文件路径 = Path.Combine(ModPath, "Manifest.json")
                                   If Not FileExists(清单文件路径) Then Continue For
                                   Try
                                       Dim 模组清单数据 As 清单文件数据结构 = JsonConvert.DeserializeObject(Of 清单文件数据结构)(ReadAllText(清单文件路径))
                                       If 模组清单数据 Is Nothing Then Continue For
                                       If 模组清单数据.UniqueID Is Nothing Then Continue For
                                       模组清单数据.ModPath = ModPath
                                       临时所有模组列表.Add("SteamWorkShop." & 模组清单数据.UniqueID, 模组清单数据)
                                   Catch ex As Exception
                                       Form1.Invoke(Sub() DebugPrint($"转换清单数据失败：{ex.Message}，位于模组：{ModPath}", Color.Tomato))
                                   End Try
                               Next
                           End Sub)
        End If

        Dim 本地模组文件夹列表 As New List(Of String)(GetDirectories(Path.Combine(Application.StartupPath, "Mods")))
        Await Task.Run(Sub()
                           For Each ModPath In 本地模组文件夹列表
                               Dim 清单文件路径 = Path.Combine(ModPath, "Manifest.json")
                               If Not FileExists(清单文件路径) Then Continue For
                               Try
                                   Dim 模组清单数据 As 清单文件数据结构 = JsonConvert.DeserializeObject(Of 清单文件数据结构)(ReadAllText(清单文件路径))
                                   If 模组清单数据 Is Nothing Then Continue For
                                   If 模组清单数据.UniqueID Is Nothing Then Continue For
                                   模组清单数据.ModPath = ModPath
                                   临时所有模组列表.Add("Local." & 模组清单数据.UniqueID, 模组清单数据)
                               Catch ex As Exception
                                   Form1.Invoke(Sub() DebugPrint($"转换清单数据失败：{ex.Message}，位于模组：{ModPath}", Color.Tomato))
                               End Try
                           Next
                       End Sub)

    End Sub


End Class
