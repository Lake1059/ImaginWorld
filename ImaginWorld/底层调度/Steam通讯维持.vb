
Imports Steamworks

Public Class Steam通讯维持

    Public Shared ReadOnly 运行回调的定时器 As New Timer With {.Interval = 1000}

    Public Shared Sub 开始初始化Steam接口()
        状态信息.Steam_是否完成了初始化 = SteamAPI.Init
        If 状态信息.Steam_是否完成了初始化 Then
            AddHandler 运行回调的定时器.Tick,
                  Sub(sender, e)
                      SteamAPI.RunCallbacks()
                  End Sub
            运行回调的定时器.Enabled = True
            DebugPrint("已初始化 Steam 功能", Color.CornflowerBlue)
        Else
            DebugPrint("无法初始化 Steam 功能，请确保 Steam 正在运行并从 Steam 启动游戏", Color.Tomato)
        End If

    End Sub


End Class
