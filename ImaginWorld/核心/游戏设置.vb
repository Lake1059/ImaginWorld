
Imports System.IO
Imports System.Text.Json
Imports Microsoft.VisualBasic.FileIO.FileSystem

Public Class 游戏设置
    Public Shared Property 实例对象 As New 游戏设置数据结构

    <Serializable>
    Public Class 游戏设置数据结构
        Public Property GameLanguage As String = "zh"
        Public Property Font As String = "微软雅黑"
        Public Property WindowSize As Size = New Size(1280, 720)
        Public Property FullScreenNoBorders As Boolean = False
        Public Property BgmVolume As Single = 0.75F
        Public Property EsVolume As Single = 0.75F
        Public Property ColonyCalculationThreads As Integer = 1
        Public Property WorldStateCalculationThreads As Integer = 1
        Public Property RandomEventsTriggerCalculationThreads As Integer = 1
        Public Property BattleModeSelection As Integer = 0

        Public Property Sever_Port As String = ""
        Public Property Sever_Name As String = ""
        Public Property Sever_Description As String = ""
        Public Property Sever_DefaultPermission As Integer = -1
        Public Property Sever_MaxPing As Integer = -1
        Public Property Sever_Broadcast As Integer = -1
        Public Property Sever_AllowedConnection As Integer = -1
        Public Property Sever_MessageProcessMultithread As Integer = -1
        Public Property Sever_OpenSinglePlayerLocation As Integer = -1
        Public Property ConnectSever_IP As String = ""
        Public Property ConnectSever_Port As String = ""

    End Class

    Public Shared Sub 保存()
        Try
            Dim a = Path.Combine(Application.StartupPath, "PlayerData", "Settings.json")
            If Not DirectoryExists(Path.GetDirectoryName(a)) Then
                CreateDirectory(Path.GetDirectoryName(a))
            End If
            WriteAllText(a, JsonSerializer.Serialize(实例对象, JSON序列化选项), False)
        Catch ex As Exception
            MsgBox($"保存游戏设置失败：{ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Shared Sub 加载()
        Try
            Dim a = Path.Combine(Application.StartupPath, "PlayerData", "Settings.json")
            If Not FileExists(a) Then
                保存()
                Exit Sub
            End If
            实例对象 = JsonSerializer.Deserialize(Of 游戏设置数据结构)(ReadAllText(a))
        Catch ex As Exception
            MsgBox($"加载游戏设置失败：{ex.Message}", MsgBoxStyle.Critical)
        End Try
    End Sub


End Class
