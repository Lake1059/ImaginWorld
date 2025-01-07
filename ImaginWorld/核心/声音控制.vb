Imports NAudio.Wave
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports NAudio.Wave.SampleProviders
Imports System.IO

Public Class 声音控制

    Public Shared Sub 初始化()
        AddHandler 自动播放BGM定时器.Tick, Sub() 自动选择下一首BGM进行播放(False)
    End Sub

    Public Shared Property BGM输出设备 As WaveOutEvent
    Public Shared Property BGM音量控制器 As VolumeSampleProvider
    Public Shared Async Sub 切换BGM(BGMKey As String)
        If Not 数据中心.所有背景音乐.ContainsKey(BGMKey) Then Exit Sub
        Dim BGMPath = 数据中心.所有背景音乐(BGMKey)
        If Not FileExists(BGMPath) Then Exit Sub

        If BGM输出设备 IsNot Nothing Then
            If BGM输出设备.PlaybackState = PlaybackState.Playing Then
                Await Task.Run(Sub()
                                   Do Until BGM音量控制器.Volume <= 0.01F
                                       BGM音量控制器.Volume -= 0.01F
                                       Threading.Thread.Sleep(50)
                                   Loop
                               End Sub)
            End If
        End If
        Application.DoEvents()
        Dim audioFile = New AudioFileReader(BGMPath)

        BGM音量控制器 = New VolumeSampleProvider(audioFile) With {
            .Volume = 游戏设置.实例对象.BgmVolume
        }
        If BGM输出设备 IsNot Nothing Then BGM输出设备.Dispose()
        BGM输出设备 = New WaveOutEvent
        BGM输出设备.Init(BGM音量控制器)
        BGM输出设备.Play()
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
