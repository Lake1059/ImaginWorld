Imports NAudio.Wave
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports NAudio.Wave.SampleProviders
Imports System.IO

Public Class 声音控制

    Public Shared Sub 初始化()
        AddHandler 自动播放BGM定时器.Tick, Sub() 自动选择下一首BGM进行播放(False)
    End Sub

    Public Shared Property 待切换BGM名称 As String = ""
    Public Shared Property BGM过渡时间 As Integer = 3000
    Public Shared Property BGM正在过渡中 As Boolean = False
    Public Shared Property BGM输出设备 As WaveOutEvent
    Public Shared Property BGM音量控制器 As VolumeSampleProvider
    Public Shared Async Sub 切换BGM(BGMKey As String)
        If Not 数据中心.所有背景音乐.ContainsKey(BGMKey) Then Exit Sub
        待切换BGM名称 = BGMKey
        Dim BGMPath = 数据中心.所有背景音乐(BGMKey)
        If Not FileExists(BGMPath) Then Exit Sub
        If BGM正在过渡中 Then Exit Sub
        If BGM输出设备 IsNot Nothing AndAlso BGM输出设备.PlaybackState = PlaybackState.Playing Then
            BGM正在过渡中 = True
            Dim 初始音量 As Single = BGM音量控制器.Volume
            Dim 递减步长 As Single
            Dim 休眠间隔 As Integer = 50
            If 初始音量 < 0.1F Then
                递减步长 = 0.005F
                休眠间隔 = 30
            ElseIf 初始音量 < 0.3F Then
                递减步长 = 0.01F
                休眠间隔 = 40
            Else
                递减步长 = Math.Max(0.01F, 初始音量 / (BGM过渡时间 / 休眠间隔))
            End If
            Await Task.Run(Sub()
                               Dim 结束时间 = Now.AddMilliseconds(BGM过渡时间)
                               Do Until BGM音量控制器.Volume <= 0.01F OrElse DateTime.Now >= 结束时间
                                   BGM音量控制器.Volume -= 递减步长
                                   If BGM音量控制器.Volume < 0 Then BGM音量控制器.Volume = 0
                                   Threading.Thread.Sleep(休眠间隔)
                               Loop
                           End Sub)
            BGM正在过渡中 = False
        End If
        Dim 最终BGMPath = 数据中心.所有背景音乐(待切换BGM名称)
        If Not FileExists(最终BGMPath) Then Exit Sub
        Application.DoEvents()
        Await Task.Run(Sub()
                           Dim audioFile = New AudioFileReader(最终BGMPath)
                           BGM音量控制器 = New VolumeSampleProvider(audioFile) With {.Volume = 游戏设置.实例对象.BgmVolume}
                           If BGM输出设备 IsNot Nothing Then BGM输出设备.Dispose()
                           BGM输出设备 = New WaveOutEvent
                           BGM输出设备.Init(BGM音量控制器)
                           BGM输出设备.Play()
                           待切换BGM名称 = ""
                       End Sub)
    End Sub

    Public Shared Property 特效声音输出设备 As WaveOutEvent
    Public Shared Property 特效声音音量控制器 As VolumeSampleProvider

    Public Shared Sub 播放特效音(Key As String)
        If Not 数据中心.所有特效声音.ContainsKey(Key) Then Exit Sub
        Dim audioStream = New MemoryStream(数据中心.所有特效声音(Key))
        Dim waveProvider = New WaveFileReader(audioStream)
        Dim sampleProvider = waveProvider.ToSampleProvider()
        特效声音音量控制器 = New VolumeSampleProvider(sampleProvider) With {
            .Volume = 游戏设置.实例对象.EsVolume
        }
        If 特效声音输出设备 IsNot Nothing Then 特效声音输出设备.Dispose()
        特效声音输出设备 = New WaveOutEvent
        特效声音输出设备.Init(特效声音音量控制器)
        特效声音输出设备.Play()
    End Sub

    Public Shared Property 自动播放BGM定时器 As New Timer With {.Interval = 10000}

    Public Shared Sub 自动选择下一首BGM进行播放(Optional 强制切换 As Boolean = False)
        If 强制切换 Then GoTo jx1
        If BGM输出设备.PlaybackState = PlaybackState.Playing Then Exit Sub
jx1:
        If Form1.界面图层_主层.GetType Is GetType(界面主层_主菜单) Then
            Dim random As New Random()
            Dim keys = 数据中心.所有背景音乐.Keys.ToList()
            Dim BGMKey = keys(random.Next(keys.Count))
            切换BGM(BGMKey)
        Else




        End If
    End Sub






End Class
