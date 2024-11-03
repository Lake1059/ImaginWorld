Imports System.IO
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports Newtonsoft.Json
Imports Steamworks

Class 创意工坊
    Class SteamWorkshopItem
        Public ContentFolderPath As String
        Public Description As String
        Public PreviewImagePath As String
        Public Tags As New List(Of String)
        Public Title As String
        Public Visibility As ERemoteStoragePublishedFileVisibility
    End Class

    Public Shared Function 获取已订阅物品的安装路径() As List(Of String)
        Dim subscribedCount = SteamUGC.GetNumSubscribedItems()
        Dim subscribedFiles(subscribedCount - 1) As PublishedFileId_t
        SteamUGC.GetSubscribedItems(subscribedFiles, subscribedFiles.Length)

        Dim installLocations As New List(Of String)()
        For Each file In subscribedFiles
            Dim installLocation As String = String.Empty
            SteamUGC.GetItemInstallInfo(file, 0UL, installLocation, 1024, 0)
            installLocations.Add(installLocation)
        Next

        Return installLocations
    End Function

    Public 当前创意工坊物品对象 As New SteamWorkshopItem

    Public 当前创意工坊物品ID对象 As PublishedFileId_t

    Public Sub 上传(模组文件夹名称 As String)
        If Not 状态信息.Steam_是否完成了初始化 Then
            DebugPrint("Steamworks 未连接！", Color.Tomato)
        End If
        Dim 清单文件路径 = Path.Combine(Application.StartupPath, "Mods", 模组文件夹名称, "Manifest.json")
        If Not FileExists(清单文件路径) Then Exit Sub
        Dim 模组清单数据 As 模组管理.清单文件数据结构 = JsonConvert.DeserializeObject(Of 模组管理.清单文件数据结构)(ReadAllText(清单文件路径))
        Dim 创意工坊物品ID文件 = Path.Combine(Application.StartupPath, "Mods", 模组文件夹名称, "SteamWorkShopId")
        Dim 新建还是更新 As String = If(FileExists(创意工坊物品ID文件), "更新", "新建")
        If 新建还是更新 = "更新" Then 当前创意工坊物品ID对象 = New PublishedFileId_t With {.m_PublishedFileId = ReadAllText(创意工坊物品ID文件)}
        当前创意工坊物品对象.ContentFolderPath = Path.Combine(Application.StartupPath, "Mods", 模组文件夹名称)
        If 新建还是更新 = "新建" Then 当前创意工坊物品对象.Description = 模组清单数据.Description
        If 新建还是更新 = "新建" Then 当前创意工坊物品对象.Title = 模组清单数据.ModName
        Dim 物品封面图片文件 = Path.Combine(Application.StartupPath, "Mods", 模组文件夹名称, "Cover.jpg")
        If FileExists(物品封面图片文件) Then 当前创意工坊物品对象.PreviewImagePath = 物品封面图片文件
        Select Case 模组清单数据.AgeRating
            Case "Everyone", "Parent Guide", "Aldult"
                当前创意工坊物品对象.Tags.Add(模组清单数据.AgeRating)
            Case Else
                DebugPrint("未设定有效的年龄分级，禁止上传！", Color.Tomato)
                Exit Sub
        End Select
        For Each Tag In 模组清单数据.Tag
            当前创意工坊物品对象.Tags.Add(Tag)
        Next
        For Each Tag In 模组清单数据.SupportedGameVersion
            当前创意工坊物品对象.Tags.Add(Tag)
        Next
        Select Case 新建还是更新
            Case "新建"
                当前创意工坊物品对象.Visibility = ERemoteStoragePublishedFileVisibility.k_ERemoteStoragePublishedFileVisibilityPrivate
                CreateItem()
            Case "更新"
                UpdateItem2()
        End Select
    End Sub

    'Public Sub 创建新的创意工坊物品并上传(物品标题 As String, 物品描述 As String, 包含内容的文件夹 As String, 标签 As List(Of String), 预览图路径 As String, 可见性 As ERemoteStoragePublishedFileVisibility)
    '    当前创意工坊物品对象 = New SteamWorkshopItem With {
    '        .Title = 物品标题,
    '        .Description = 物品描述,
    '        .ContentFolderPath = 包含内容的文件夹,
    '        .Tags = 标签,
    '        .PreviewImagePath = 预览图路径,
    '        .Visibility = 可见性
    '    }
    '    CreateItem()
    'End Sub

    'Public Sub 更新创意工坊物品并上传(创意工坊物品ID As ULong, 物品标题 As String, 包含内容的文件夹 As String, 标签 As List(Of String), 预览图路径 As String)
    '    当前创意工坊物品对象 = New SteamWorkshopItem With {
    '        .Title = 物品标题,
    '        .ContentFolderPath = 包含内容的文件夹,
    '        .Tags = 标签,
    '        .PreviewImagePath = 预览图路径
    '    }
    '    当前创意工坊物品ID对象 = New PublishedFileId_t With {.m_PublishedFileId = 创意工坊物品ID}
    '    UpdateItem2()
    'End Sub

    Private Sub CreateItem()
        Dim steamAPICall = SteamUGC.CreateItem(SteamUtils.GetAppID(), EWorkshopFileType.k_EWorkshopFileTypeCommunity)
        Dim steamAPICallResult = CallResult(Of CreateItemResult_t).Create()
        steamAPICallResult.Set(steamAPICall, AddressOf CreateItemResult)
        DebugPrint("创建执行完毕", Color.Silver)
    End Sub

    Private Sub CreateItemResult(param As CreateItemResult_t, bIOFailure As Boolean)
        DebugPrint("触发创建判断", Color.Silver)
        If param.m_eResult = EResult.k_EResultOK Then
            WriteAllText(Path.Combine(当前创意工坊物品对象.ContentFolderPath, "SteamWorkShopId"), param.m_nPublishedFileId.m_PublishedFileId, False)
            当前创意工坊物品ID对象 = param.m_nPublishedFileId
            DebugPrint("已创建物品：" & param.m_nPublishedFileId.m_PublishedFileId, Color.Silver)
            Application.DoEvents()
            UpdateItem()
        Else
            DebugPrint("创建失败，错误类型为：" & param.m_eResult.ToString, Color.Tomato)
        End If
    End Sub

    Private Sub UpdateItem()
        Dim updateHandle = SteamUGC.StartItemUpdate(SteamUtils.GetAppID(), 当前创意工坊物品ID对象)
        SteamUGC.SetItemTitle(updateHandle, 当前创意工坊物品对象.Title)
        SteamUGC.SetItemDescription(updateHandle, 当前创意工坊物品对象.Description)
        SteamUGC.SetItemContent(updateHandle, 当前创意工坊物品对象.ContentFolderPath)
        SteamUGC.SetItemTags(updateHandle, 当前创意工坊物品对象.Tags)
        SteamUGC.SetItemPreview(updateHandle, 当前创意工坊物品对象.PreviewImagePath)
        SteamUGC.SetItemVisibility(updateHandle, 当前创意工坊物品对象.Visibility)
        DebugPrint("已设置物品内容，开始上传：" & 当前创意工坊物品对象.Title, Color.Silver)
        DebugPrint("上传由 Steam 执行，游戏退出不影响上传，请勿重复操作", Color.ForestGreen)
        DebugPrint("中途不能取消或暂停，请关注网络流量", Color.ForestGreen)
        Dim steamAPICall = SteamUGC.SubmitItemUpdate(updateHandle, Nothing)
        Dim steamAPICallResult = CallResult(Of SubmitItemUpdateResult_t).Create()
        steamAPICallResult.[Set](steamAPICall, AddressOf UpdateItemResult)
    End Sub

    Private Sub UpdateItem2()
        Dim updateHandle = SteamUGC.StartItemUpdate(SteamUtils.GetAppID(), 当前创意工坊物品ID对象)
        SteamUGC.SetItemContent(updateHandle, 当前创意工坊物品对象.ContentFolderPath)
        SteamUGC.SetItemTags(updateHandle, 当前创意工坊物品对象.Tags)
        SteamUGC.SetItemPreview(updateHandle, 当前创意工坊物品对象.PreviewImagePath)
        DebugPrint("已更新物品内容，开始上传更新：" & 当前创意工坊物品ID对象.m_PublishedFileId, Color.Silver)
        DebugPrint("上传由 Steam 执行，游戏退出不影响上传，请勿重复操作", Color.ForestGreen)
        DebugPrint("中途不能取消或暂停，请关注网络流量", Color.ForestGreen)
        Dim steamAPICall = SteamUGC.SubmitItemUpdate(updateHandle, Nothing)
        Dim steamAPICallResult = CallResult(Of SubmitItemUpdateResult_t).Create()
        steamAPICallResult.[Set](steamAPICall, AddressOf UpdateItemResult)
    End Sub

    Private Sub UpdateItemResult(param As SubmitItemUpdateResult_t, bIOFailure As Boolean)
        If param.m_eResult = EResult.k_EResultOK Then
            DebugPrint($"{当前创意工坊物品ID对象} 上传成功", Color.Silver)
            SteamFriends.ActivateGameOverlayToWebPage($"steam://url/CommunityFilePage/{当前创意工坊物品ID对象}")
        Else
            DebugPrint("上传失败，错误类型为：" & param.m_eResult.ToString, Color.Tomato)
        End If
    End Sub

    Public Shared Sub 取消订阅创意工坊物品(itemID As ULong)
        On Error Resume Next
        Dim PFT As New PublishedFileId_t With {.m_PublishedFileId = itemID}
        SteamUGC.UnsubscribeItem(PFT)
    End Sub


End Class
