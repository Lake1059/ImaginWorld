Public Class 指令系统

    Public Shared Sub 初始化()
        指令字典.Add("help", AddressOf 列出全部指令)
        指令字典.Add("bgm", AddressOf 切换BGM)
        指令字典.Add("listbgm", AddressOf 列出BGM)
        指令字典.Add("nextbgm", AddressOf 下一首BGM)
        DebugPrint($"指令系统初始化完成，共 {指令字典.Count} 条原生命令", Color.Silver)
    End Sub


    Public Shared Sub 执行(Code As String)
        Dim CodeList As New List(Of String)(Code.Split(" ").ToList)
        If CodeList.Count = 0 Then Exit Sub

        Dim 指令名称 As String = CodeList(0)
        CodeList.RemoveAt(0)

        Dim value As Action(Of List(Of String)) = Nothing
        If 指令字典.TryGetValue(指令名称, value) Then
            value(CodeList)
        Else
            DebugPrint("未知指令: " & 指令名称, Color.Tomato)
        End If
    End Sub

    Public Shared Property 指令字典 As New Dictionary(Of String, Action(Of List(Of String)))

    Shared Sub 列出全部指令()
        For Each item In 指令字典.Keys
            DebugPrint(item, Color.Gray, False)
        Next
    End Sub

    Shared Sub 切换BGM(Args As List(Of String))
        If Args.Count <> 1 Then
            DebugPrint("参数错误，格式：bgm [Name]", Color.Tomato)
            Exit Sub
        End If
        If 数据中心.所有背景音乐.ContainsKey(Args(0)) Then
            声音控制.切换BGM(Args(0))
        Else
            DebugPrint($"未找到此音乐：{Args(0)}", Color.Tomato)
        End If
    End Sub

    Shared Sub 列出BGM()
        For Each item In 数据中心.所有背景音乐.Keys
            DebugPrint(item, Color.Gray, False)
        Next
    End Sub

    Shared Sub 下一首BGM()
        声音控制.自动选择下一首BGM进行播放(True)
    End Sub

End Class
