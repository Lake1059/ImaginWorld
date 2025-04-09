Imports System.Net
Imports System.Text.Json
Imports ImaginWorld.多人模式通信数据类

Public Class 服务器的消息响应

    Public Shared Property 消息字典 As New Dictionary(Of String, Action(Of List(Of String), IPEndPoint))

    Public Shared Sub 初始化()
        消息字典.Add(通信指令.客户端回应Ping, AddressOf 收到客户端Ping响应)
        消息字典.Add(通信指令.客户端请求连接服务器, AddressOf 收到客户端连接请求)
        消息字典.Add(通信指令.客户端主动断开连接, AddressOf 收到客户端断开连接)

        DebugPrint($"服务器消息响应初始化完成，共计 {消息字典.Count } 个消息处理方法", Color.Silver)
    End Sub

    Public Shared Sub 执行消息(消息 As List(Of String), 发送者地址 As IPEndPoint)
        Dim 消息名称 As String = 消息(0)
        Dim value As Action(Of List(Of String), IPEndPoint) = Nothing
        If 消息字典.TryGetValue(消息名称, value) Then
            value(消息, 发送者地址)
        Else
            DebugPrint("未知服务器指令：" & 消息名称, Color.Tomato)
        End If
    End Sub

    Public Shared Sub 收到客户端Ping响应(消息 As List(Of String), 发送者地址 As IPEndPoint)
        Dim value As 服务器.玩家信息单片结构 = Nothing
        If 服务器.客户端列表.TryGetValue(发送者地址, value) Then
            value.心跳包接收时间 = Now
        End If
    End Sub

    Public Shared Sub 收到客户端连接请求(消息 As List(Of String), 发送者地址 As IPEndPoint)
        DebugPrint("客户端连接请求：" & 发送者地址.ToString, Color.YellowGreen)
        Dim a As New 玩家角色位信息表 With {
            .服务器名称 = 服务器.服务器名称,
            .玩家在线数量 = 服务器.客户端列表.Count,
            .所有玩家数量 = 存档系统.GameSave.MultiPlayerData.Count + 1,
            .单人模式数据位是否可用 = 服务器.开放单人数据位,
            .可用于创建新玩家的殖民地列表 = 存档系统.GameSave.MultiPlayerColonyNameList
        }
        If 存档系统.GameSave.SinglePlayerData.OwnColony.Count > 0 Then
            For Each item In 存档系统.GameSave.SinglePlayerData.OwnColony
                a.可用于创建新玩家的殖民地列表.Remove(item)
            Next
        End If
        For Each item In 存档系统.GameSave.MultiPlayerData
            If item.Value.OwnColony.Count > 0 Then
                For Each item2 In item.Value.OwnColony
                    a.可用于创建新玩家的殖民地列表.Remove(item2)
                Next
            End If
        Next

        For Each item In 存档系统.GameSave.MultiPlayerData
            If item.Value.IsHide Then Continue For
            Dim d1 As New 玩家基本信息结构 With {
                .玩家名称 = item.Value.PlayerName,
                .是否有密码 = item.Value.PlayerPassword = ""
            }
            Select Case item.Value.ScenarioType
                Case 存档系统.场景类型.世界地图
                    d1.最后的场景名称 = 数据中心.所有世界地图(item.Value.Scenario).ToString
                Case 存档系统.场景类型.殖民地
                    d1.最后的场景名称 = 数据中心.所有殖民地(item.Value.Scenario).ToString
            End Select
            d1.拥有的殖民地数量 = item.Value.OwnColony.Count
            d1.远行队中的角色数量 = item.Value.TravelData.Characters.Count
            a.可登录的玩家列表.Add(d1)
        Next
        服务器.发送消息(发送者地址, {通信指令.服务器发送玩家位信息, JsonSerializer.Serialize(a)})
    End Sub

    Public Shared Sub 收到客户端断开连接(消息 As List(Of String), 发送者地址 As IPEndPoint)
        DebugPrint("客户端主动离线：" & 发送者地址.ToString, Color.YellowGreen)
        服务器.客户端列表.Remove(发送者地址)
    End Sub






End Class
