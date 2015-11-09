﻿Imports System.IO

Public Class LoadFile
    Public Shared Sub LoadFromVSMBX(Path As String)
        Dim RC As RectangleConverter
        RC = New RectangleConverter

        Blocks.Tiles.Clear()
        Blocks.TileRects.Clear()
        Backgrounds.BGOs.Clear()
        Backgrounds.bgorects.Clear()
        NPC.NPCsets.Clear()
        NPC.NPCrects.Clear()

        Dim fs As New System.IO.FileStream(Path, FileMode.Open)

        Dim CurTag As String = ""

        Dim sr As New StreamReader(fs)

        Level.Music = sr.ReadLine()
        Level.BGid = sr.ReadLine()

        LevelSettings.PlayM.StopPlayback()
        Level.Song = "custom"
        LevelSettings.SetLevelMusic()

        Level.LevelW = sr.ReadLine()
        Level.LevelH = sr.ReadLine()

        Level.HeightInc = ((Level.LevelH - (19 * 32)) + 32) / 32

        Form2.SetBG()

        Form2.AutoScrollMinSize = New Size(Level.LevelW, Level.LevelH)

        Level.LevelWrap = sr.ReadLine()
        Level.NoTurnBack = sr.ReadLine()
        Level.OffscreenExit = sr.ReadLine()
        Level.Underwater = sr.ReadLine()

        If Player.P1.Graphic Is Nothing And Directory.Exists(Form1.FilePath & "\graphics\mario\") Then
            Player.P1.Graphic = New Bitmap(Form1.FilePath & "\graphics\mario\mario-2.png")
        ElseIf Player.P2.Graphic Is Nothing And Directory.Exists(Form1.FilePath & "\graphics\luigi") Then
            Player.P2.Graphic = New Bitmap(Form1.FilePath & "\graphics\luigi\luigi-2.png")
        End If

        Level.P1start = RC.ConvertFromString(sr.ReadLine())

        Play.DrawX = Level.P1start.X
        Play.DrawY = Level.P1start.Y

        Level.P2start = RC.ConvertFromString(sr.ReadLine())
        Level.Time = sr.ReadLine()
        Play.GravityLevel = sr.ReadLine()
        Level.Brightness = sr.ReadLine()

        Dim CurLine As String = ""

        Dim b As New Block
        Dim bg As New BGO
        Dim n As New NPCsets

        'TODO: Error checking, and section based loading.

        CurLine = sr.ReadLine().ToString()
        If CurLine = "[BLOCK]" Then
            CurTag = "[BLOCK]"
        End If

        If CurTag = "[BLOCK]" Then
            Do While CurTag = "[BLOCK]"

                Try
                    b.Animated = sr.ReadLine()
                    b.ContainItem = sr.ReadLine()
                    b.FrameSpeed = sr.ReadLine()
                    b.gfxHeight = sr.ReadLine()
                    b.gfxWidth = sr.ReadLine()
                    b.Height = sr.ReadLine()
                    b.Width = sr.ReadLine()
                    b.ID = sr.ReadLine()
                    b.Invisible = sr.ReadLine()
                    b.Lava = sr.ReadLine()
                    b.rectangle = RC.ConvertFromString(sr.ReadLine())
                    b.SizeH = sr.ReadLine()
                    b.SizeW = sr.ReadLine()
                    b.Slip = sr.ReadLine()
                    b.TotalFrames = sr.ReadLine()
                    b.X = sr.ReadLine()
                    b.Y = sr.ReadLine()
                    b.R = sr.ReadLine()
                    b.G = sr.ReadLine()
                    b.B = sr.ReadLine()
                    b.Glow = sr.ReadLine()
                    b.Breakable = sr.ReadLine()

                    Blocks.GetBlock(b.ID)

                    b.IMG = Form2.TB.Image

                    Blocks.Tiles.Add(b)
                    Blocks.TileRects.Add(b.rectangle)
                Catch ex As Exception
                    CurTag = "[BGO]"
                    Exit Do
                End Try
            Loop
        End If

        If CurTag = "[BGO]" Then
            Do While CurTag = "[BGO]"
                Try
                    bg.Animated = sr.ReadLine()
                    bg.ForeGround = sr.ReadLine()
                    bg.FrameSpeed = sr.ReadLine()
                    bg.gfxHeight = sr.ReadLine()
                    bg.gfxWidth = sr.ReadLine()
                    bg.Height = sr.ReadLine()
                    bg.Width = sr.ReadLine()
                    bg.ID = sr.ReadLine()
                    bg.rectangle = RC.ConvertFromString(sr.ReadLine())
                    bg.TotalFrames = sr.ReadLine()
                    bg.X = sr.ReadLine()
                    bg.Y = sr.ReadLine()

                    If bg.ID >= 1 Then
                        Form2.SelectedBGO = bg.ID
                        Backgrounds.GetBGO()

                        bg.IMG = Form2.TB.Image

                        Backgrounds.BGOs.Add(bg)
                        Backgrounds.bgorects.Add(bg.rectangle)
                    End If
                Catch ex As Exception
                    CurTag = "[NPC]"
                    Exit Do
                End Try
            Loop
        End If

        Do While sr.Peek() > -1
            If CurTag = "[NPC]" Then
                n.AI = sr.ReadLine()
                n.Animated = sr.ReadLine()
                n.Direction = sr.ReadLine()
                n.FrameSpeed = sr.ReadLine()
                n.FrameStyle = sr.ReadLine()
                n.gfxHeight = sr.ReadLine()
                n.gfxWidth = sr.ReadLine()
                n.HasGravity = sr.ReadLine()
                n.Height = sr.ReadLine()
                n.Width = sr.ReadLine()
                n.ID = sr.ReadLine()
                n.MSG = sr.ReadLine()
                n.MetroidGlass = sr.ReadLine()
                n.MoveSpeed = sr.ReadLine()
                n.rectangle = RC.ConvertFromString(sr.ReadLine())
                n.TotalFrames = sr.ReadLine()
                n.X = sr.ReadLine()
                n.Y = sr.ReadLine()
                n.NPCcollide = sr.ReadLine()

                If n.ID >= 1 Then
                    Form2.SelectedNPC = n.ID
                    NPC.GetNPC()

                    n.IMG = Form2.TB.Image

                    NPC.NPCsets.Add(n)
                    NPC.NPCrects.Add(n.rectangle)
                End If
            End If
        Loop

        sr.Close()
        sr.Dispose()
    End Sub

    Public Sub LoadFromPGE(Path As String)

    End Sub
End Class
