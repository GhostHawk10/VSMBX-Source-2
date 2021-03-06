﻿Public Class BlocksAndTiles
    Dim bmp As Bitmap
    Dim g As Graphics

    Private Sub BlocksAndTiles_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        g = Me.CreateGraphics
        LoadSMB3GFX()
    End Sub

    Public Sub LoadSMB3GFX()
        'SMB3 Wood
        Dim fs As New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-7.png", System.IO.FileMode.Open)
        Dim graphic As Image
        graphic = Image.FromStream(fs)
        Button29.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-3.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button30.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-6.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button31.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-128.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button32.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-127.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button33.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-129.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button34.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-600.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button35.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-601.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button36.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-604.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button37.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-605.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button38.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-15.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button40.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-16.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button41.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-17.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button42.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-1.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button43.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-92.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button44.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-602.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button45.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-603.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button46.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-606.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button47.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-607.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button48.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-274.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button49.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-276.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button50.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-275.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button51.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-595.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button52.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-596.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button53.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-597.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button54.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'SMB3 Grass
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-9.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button55.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-10.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button56.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-11.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button57.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-305.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button58.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-307.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button59.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-306.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button60.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-308.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button61.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-18.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button62.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-19.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button63.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-20.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button64.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-311.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button65.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-313.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button66.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-312.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button67.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-314.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button68.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-279.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button69.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-278.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button70.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-277.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button71.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-12.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button72.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-13.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button73.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-14.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button74.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 Cave
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-344.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button75.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-345.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button76.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-346.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button77.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-353.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button78.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-354.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button79.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-358.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button80.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-359.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button81.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-357.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button82.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-360.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button83.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-347.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button84.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-348.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button85.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-349.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button86.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-355.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button87.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-356.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button88.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-362.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button89.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-363.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button90.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-361.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button91.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-364.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button92.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-350.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button93.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-351.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button94.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-352.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button95.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 Desert
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-94.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button96.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-95.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button97.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-96.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button98.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-162.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button99.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-163.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button100.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-164.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button101.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-635.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button102.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-637.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button103.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-97.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button104.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-98.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button105.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-99.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button106.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-165.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button107.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-166.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button108.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-167.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button109.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-636.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button110.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-638.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button111.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-100.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button112.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-101.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button113.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-102.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button114.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-286.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button115.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-285.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button116.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-284.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button117.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-183.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button118.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 Bonus
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-49.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button119.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-52.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button120.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-610.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button121.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-50.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button122.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-54.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button123.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-47.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button124.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-611.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button125.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-612.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button126.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-608.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button127.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-48.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button128.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-609.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button129.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-51.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button130.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-53.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button131.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 House
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-219.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button132.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-220.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button133.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-221.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button134.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-222.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button135.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-217.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button136.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-218.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button137.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 dungeon
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-29.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button138.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-91.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button139.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-126.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button140.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-630.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button141.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-136.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button142.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 water
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-580.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button143.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-581.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button144.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-582.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button145.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-586.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button146.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-587.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button147.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-588.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button148.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-583.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button149.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-584.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button150.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-585.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button151.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-589.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button152.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-590.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button153.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-591.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button154.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-598.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 32, 32, 32), GraphicsUnit.Pixel)
        Button155.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-578.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button156.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-599.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button157.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-592.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button158.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-593.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button159.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-594.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button160.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 snow
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-270.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button161.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-272.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button162.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-271.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button163.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-633.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button164.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-634.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button165.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 airship
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-73.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button166.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-70.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button167.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-71.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button168.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-72.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button169.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-74.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button170.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-78.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button171.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-77.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button172.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-185.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button173.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-75.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button174.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-613.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button175.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-614.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button176.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-76.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button177.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 hurts
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-110.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button178.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-30.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 96, 32, 32), GraphicsUnit.Pixel)
        Button179.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-109.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 128, 32, 32), GraphicsUnit.Pixel)
        Button180.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-268.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button181.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-406.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button182.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-269.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button183.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-267.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button184.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 pipes
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-21.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button185.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-34.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button186.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-36.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button187.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-103.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button188.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-23.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button189.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-24.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button190.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-22.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button191.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-35.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button192.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-37.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button193.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-104.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button194.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-295.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button195.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-294.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button196.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-571.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button197.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-31.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button198.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-32.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button199.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-33.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button200.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-182.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button201.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-296.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button202.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-569.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button203.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-570.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button204.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 sizable
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-25.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button205.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-26.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button206.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-240.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button207.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-575.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button208.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-27.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button209.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-28.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button210.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-241.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button211.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-568.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button212.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-108.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button213.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-130.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button214.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-260.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button215.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-579.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button216.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 misc
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-8.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button217.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-280.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button218.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-187.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button219.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-112.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button220.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-458.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 160, 32, 32), GraphicsUnit.Pixel)
        Button221.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-132.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button222.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-290.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button223.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-107.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button224.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-289.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button225.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-111.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button226.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-160.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button227.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-457.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button228.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-106.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button229.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-105.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button230.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-168.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button231.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-184.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button232.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-223.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button233.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-572.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button234.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb3 special
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-5.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button235.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-2.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button236.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-4.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button237.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-621.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button238.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-224.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button239.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-225.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button240.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-226.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button241.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-620.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button242.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-55.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 32, 32, 32), GraphicsUnit.Pixel)
        Button243.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-186.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button244.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-159.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button245.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()
    End Sub

    Private Sub Button29_Click(sender As System.Object, e As System.EventArgs) Handles Button29.Click
        ObjectPlacement.SelectedBlock = 7
    End Sub

    Private Sub Button30_Click(sender As System.Object, e As System.EventArgs) Handles Button30.Click
        ObjectPlacement.SelectedBlock = 3
    End Sub

    Private Sub Button31_Click(sender As System.Object, e As System.EventArgs) Handles Button31.Click
        ObjectPlacement.SelectedBlock = 6
    End Sub

    Private Sub Button32_Click(sender As System.Object, e As System.EventArgs) Handles Button32.Click
        ObjectPlacement.SelectedBlock = 128
    End Sub

    Private Sub Button33_Click(sender As System.Object, e As System.EventArgs) Handles Button33.Click
        ObjectPlacement.SelectedBlock = 127
    End Sub

    Private Sub Button34_Click(sender As System.Object, e As System.EventArgs) Handles Button34.Click
        ObjectPlacement.SelectedBlock = 129
    End Sub

    Private Sub Button35_Click(sender As System.Object, e As System.EventArgs) Handles Button35.Click
        ObjectPlacement.SelectedBlock = 600
    End Sub

    Private Sub Button36_Click(sender As System.Object, e As System.EventArgs) Handles Button36.Click
        ObjectPlacement.SelectedBlock = 601
    End Sub

    Private Sub Button37_Click(sender As System.Object, e As System.EventArgs) Handles Button37.Click
        ObjectPlacement.SelectedBlock = 604
    End Sub

    Private Sub Button38_Click(sender As System.Object, e As System.EventArgs) Handles Button38.Click
        ObjectPlacement.SelectedBlock = 605
    End Sub

    Private Sub Button40_Click(sender As System.Object, e As System.EventArgs) Handles Button40.Click
        ObjectPlacement.SelectedBlock = 15
    End Sub

    Private Sub Button41_Click(sender As System.Object, e As System.EventArgs) Handles Button41.Click
        ObjectPlacement.SelectedBlock = 16
    End Sub

    Private Sub Button42_Click(sender As System.Object, e As System.EventArgs) Handles Button42.Click
        ObjectPlacement.SelectedBlock = 17
    End Sub

    Private Sub Button43_Click(sender As System.Object, e As System.EventArgs) Handles Button43.Click
        ObjectPlacement.SelectedBlock = 1
    End Sub

    Private Sub Button44_Click(sender As System.Object, e As System.EventArgs) Handles Button44.Click
        ObjectPlacement.SelectedBlock = 92
    End Sub

    Private Sub Button45_Click(sender As System.Object, e As System.EventArgs) Handles Button45.Click
        ObjectPlacement.SelectedBlock = 602
    End Sub

    Private Sub Button46_Click(sender As System.Object, e As System.EventArgs) Handles Button46.Click
        ObjectPlacement.SelectedBlock = 603
    End Sub

    Private Sub Button47_Click(sender As System.Object, e As System.EventArgs) Handles Button47.Click
        ObjectPlacement.SelectedBlock = 606
    End Sub

    Private Sub Button48_Click(sender As System.Object, e As System.EventArgs) Handles Button48.Click
        ObjectPlacement.SelectedBlock = 607
    End Sub

    Private Sub Button49_Click(sender As System.Object, e As System.EventArgs) Handles Button49.Click
        ObjectPlacement.SelectedBlock = 274
    End Sub

    Private Sub Button50_Click(sender As System.Object, e As System.EventArgs) Handles Button50.Click
        ObjectPlacement.SelectedBlock = 276
    End Sub

    Private Sub Button51_Click(sender As System.Object, e As System.EventArgs) Handles Button51.Click
        ObjectPlacement.SelectedBlock = 275
    End Sub

    Private Sub Button52_Click(sender As System.Object, e As System.EventArgs) Handles Button52.Click
        ObjectPlacement.SelectedBlock = 595
    End Sub

    Private Sub Button53_Click(sender As System.Object, e As System.EventArgs) Handles Button53.Click
        ObjectPlacement.SelectedBlock = 596
    End Sub

    Private Sub Button54_Click(sender As System.Object, e As System.EventArgs) Handles Button54.Click
        ObjectPlacement.SelectedBlock = 597
    End Sub

    Private Sub Button55_Click(sender As System.Object, e As System.EventArgs) Handles Button55.Click
        ObjectPlacement.SelectedBlock = 9
    End Sub

    Private Sub Button56_Click(sender As System.Object, e As System.EventArgs) Handles Button56.Click
        ObjectPlacement.SelectedBlock = 10
    End Sub

    Private Sub Button57_Click(sender As System.Object, e As System.EventArgs) Handles Button57.Click
        ObjectPlacement.SelectedBlock = 11
    End Sub

    Private Sub Button58_Click(sender As System.Object, e As System.EventArgs) Handles Button58.Click
        ObjectPlacement.SelectedBlock = 305
    End Sub

    Private Sub Button59_Click(sender As System.Object, e As System.EventArgs) Handles Button59.Click
        ObjectPlacement.SelectedBlock = 307
    End Sub

    Private Sub Button60_Click(sender As System.Object, e As System.EventArgs) Handles Button60.Click
        ObjectPlacement.SelectedBlock = 306
    End Sub

    Private Sub Button61_Click(sender As System.Object, e As System.EventArgs) Handles Button61.Click
        ObjectPlacement.SelectedBlock = 308
    End Sub

    Private Sub Button62_Click(sender As System.Object, e As System.EventArgs) Handles Button62.Click
        ObjectPlacement.SelectedBlock = 18
    End Sub

    Private Sub Button63_Click(sender As System.Object, e As System.EventArgs) Handles Button63.Click
        ObjectPlacement.SelectedBlock = 19
    End Sub

    Private Sub Button64_Click(sender As System.Object, e As System.EventArgs) Handles Button64.Click
        ObjectPlacement.SelectedBlock = 20
    End Sub

    Private Sub Button65_Click(sender As System.Object, e As System.EventArgs) Handles Button65.Click
        ObjectPlacement.SelectedBlock = 311
    End Sub

    Private Sub Button66_Click(sender As System.Object, e As System.EventArgs) Handles Button66.Click
        ObjectPlacement.SelectedBlock = 313
    End Sub

    Private Sub Button67_Click(sender As System.Object, e As System.EventArgs) Handles Button67.Click
        ObjectPlacement.SelectedBlock = 312
    End Sub

    Private Sub Button68_Click(sender As System.Object, e As System.EventArgs) Handles Button68.Click
        ObjectPlacement.SelectedBlock = 314
    End Sub

    Private Sub Button69_Click(sender As System.Object, e As System.EventArgs) Handles Button69.Click
        ObjectPlacement.SelectedBlock = 279
    End Sub

    Private Sub Button70_Click(sender As System.Object, e As System.EventArgs) Handles Button70.Click
        ObjectPlacement.SelectedBlock = 278
    End Sub

    Private Sub Button71_Click(sender As System.Object, e As System.EventArgs) Handles Button71.Click
        ObjectPlacement.SelectedBlock = 277
    End Sub

    Private Sub Button72_Click(sender As System.Object, e As System.EventArgs) Handles Button72.Click
        ObjectPlacement.SelectedBlock = 12
    End Sub

    Private Sub Button73_Click(sender As System.Object, e As System.EventArgs) Handles Button73.Click
        ObjectPlacement.SelectedBlock = 13
    End Sub

    Private Sub Button74_Click(sender As System.Object, e As System.EventArgs) Handles Button74.Click
        ObjectPlacement.SelectedBlock = 14
    End Sub

    Private Sub Button75_Click(sender As System.Object, e As System.EventArgs) Handles Button75.Click
        ObjectPlacement.SelectedBlock = 344
    End Sub

    Private Sub Button76_Click(sender As System.Object, e As System.EventArgs) Handles Button76.Click
        ObjectPlacement.SelectedBlock = 345
    End Sub

    Private Sub Button77_Click(sender As System.Object, e As System.EventArgs) Handles Button77.Click
        ObjectPlacement.SelectedBlock = 346
    End Sub

    Private Sub Button78_Click(sender As System.Object, e As System.EventArgs) Handles Button78.Click
        ObjectPlacement.SelectedBlock = 353
    End Sub

    Private Sub Button79_Click(sender As System.Object, e As System.EventArgs) Handles Button79.Click
        ObjectPlacement.SelectedBlock = 354
    End Sub

    Private Sub Button80_Click(sender As System.Object, e As System.EventArgs) Handles Button80.Click
        ObjectPlacement.SelectedBlock = 358
    End Sub

    Private Sub Button81_Click(sender As System.Object, e As System.EventArgs) Handles Button81.Click
        ObjectPlacement.SelectedBlock = 359
    End Sub

    Private Sub Button82_Click(sender As System.Object, e As System.EventArgs) Handles Button82.Click
        ObjectPlacement.SelectedBlock = 357
    End Sub

    Private Sub Button83_Click(sender As System.Object, e As System.EventArgs) Handles Button83.Click
        ObjectPlacement.SelectedBlock = 360
    End Sub

    Private Sub Button84_Click(sender As System.Object, e As System.EventArgs) Handles Button84.Click
        ObjectPlacement.SelectedBlock = 347
    End Sub

    Private Sub Button85_Click(sender As System.Object, e As System.EventArgs) Handles Button85.Click
        ObjectPlacement.SelectedBlock = 348
    End Sub

    Private Sub Button86_Click(sender As System.Object, e As System.EventArgs) Handles Button86.Click
        ObjectPlacement.SelectedBlock = 349
    End Sub

    Private Sub Button87_Click(sender As System.Object, e As System.EventArgs) Handles Button87.Click
        ObjectPlacement.SelectedBlock = 355
    End Sub

    Private Sub Button88_Click(sender As System.Object, e As System.EventArgs) Handles Button88.Click
        ObjectPlacement.SelectedBlock = 356
    End Sub

    Private Sub Button89_Click(sender As System.Object, e As System.EventArgs) Handles Button89.Click
        ObjectPlacement.SelectedBlock = 362
    End Sub

    Private Sub Button90_Click(sender As System.Object, e As System.EventArgs) Handles Button90.Click
        ObjectPlacement.SelectedBlock = 363
    End Sub

    Private Sub Button91_Click(sender As System.Object, e As System.EventArgs) Handles Button91.Click
        ObjectPlacement.SelectedBlock = 361
    End Sub

    Private Sub Button92_Click(sender As System.Object, e As System.EventArgs) Handles Button92.Click
        ObjectPlacement.SelectedBlock = 364
    End Sub

    Private Sub Button93_Click(sender As System.Object, e As System.EventArgs) Handles Button93.Click
        ObjectPlacement.SelectedBlock = 350
    End Sub

    Private Sub Button94_Click(sender As System.Object, e As System.EventArgs) Handles Button94.Click
        ObjectPlacement.SelectedBlock = 351
    End Sub

    Private Sub Button95_Click(sender As System.Object, e As System.EventArgs) Handles Button95.Click
        ObjectPlacement.SelectedBlock = 352
    End Sub

    Private Sub Button96_Click(sender As System.Object, e As System.EventArgs) Handles Button96.Click
        ObjectPlacement.SelectedBlock = 94
    End Sub

    Private Sub Button97_Click(sender As System.Object, e As System.EventArgs) Handles Button97.Click
        ObjectPlacement.SelectedBlock = 95
    End Sub

    Private Sub Button98_Click(sender As System.Object, e As System.EventArgs) Handles Button98.Click
        ObjectPlacement.SelectedBlock = 96
    End Sub

    Private Sub Button99_Click(sender As System.Object, e As System.EventArgs) Handles Button99.Click
        ObjectPlacement.SelectedBlock = 162
    End Sub

    Private Sub Button100_Click(sender As System.Object, e As System.EventArgs) Handles Button100.Click
        ObjectPlacement.SelectedBlock = 163
    End Sub

    Private Sub Button101_Click(sender As System.Object, e As System.EventArgs) Handles Button101.Click
        ObjectPlacement.SelectedBlock = 164
    End Sub

    Private Sub Button102_Click(sender As System.Object, e As System.EventArgs) Handles Button102.Click
        ObjectPlacement.SelectedBlock = 635
    End Sub

    Private Sub Button103_Click(sender As System.Object, e As System.EventArgs) Handles Button103.Click
        ObjectPlacement.SelectedBlock = 637
    End Sub

    Private Sub Button104_Click(sender As System.Object, e As System.EventArgs) Handles Button104.Click
        ObjectPlacement.SelectedBlock = 97
    End Sub

    Private Sub Button105_Click(sender As System.Object, e As System.EventArgs) Handles Button105.Click
        ObjectPlacement.SelectedBlock = 98
    End Sub

    Private Sub Button106_Click(sender As System.Object, e As System.EventArgs) Handles Button106.Click
        ObjectPlacement.SelectedBlock = 99
    End Sub

    Private Sub Button107_Click(sender As System.Object, e As System.EventArgs) Handles Button107.Click
        ObjectPlacement.SelectedBlock = 165
    End Sub

    Private Sub Button108_Click(sender As System.Object, e As System.EventArgs) Handles Button108.Click
        ObjectPlacement.SelectedBlock = 166
    End Sub

    Private Sub Button109_Click(sender As System.Object, e As System.EventArgs) Handles Button109.Click
        ObjectPlacement.SelectedBlock = 167
    End Sub

    Private Sub Button110_Click(sender As System.Object, e As System.EventArgs) Handles Button110.Click
        ObjectPlacement.SelectedBlock = 636
    End Sub

    Private Sub Button111_Click(sender As System.Object, e As System.EventArgs) Handles Button111.Click
        ObjectPlacement.SelectedBlock = 638
    End Sub

    Private Sub Button112_Click(sender As System.Object, e As System.EventArgs) Handles Button112.Click
        ObjectPlacement.SelectedBlock = 100
    End Sub

    Private Sub Button113_Click(sender As System.Object, e As System.EventArgs) Handles Button113.Click
        ObjectPlacement.SelectedBlock = 101
    End Sub

    Private Sub Button114_Click(sender As System.Object, e As System.EventArgs) Handles Button114.Click
        ObjectPlacement.SelectedBlock = 102
    End Sub

    Private Sub Button115_Click(sender As System.Object, e As System.EventArgs) Handles Button115.Click
        ObjectPlacement.SelectedBlock = 286
    End Sub

    Private Sub Button116_Click(sender As System.Object, e As System.EventArgs) Handles Button116.Click
        ObjectPlacement.SelectedBlock = 285
    End Sub

    Private Sub Button117_Click(sender As System.Object, e As System.EventArgs) Handles Button117.Click
        ObjectPlacement.SelectedBlock = 284
    End Sub

    Private Sub Button118_Click(sender As System.Object, e As System.EventArgs) Handles Button118.Click
        ObjectPlacement.SelectedBlock = 183
    End Sub

    Private Sub Button119_Click(sender As System.Object, e As System.EventArgs) Handles Button119.Click
        ObjectPlacement.SelectedBlock = 49
    End Sub

    Private Sub Button120_Click(sender As System.Object, e As System.EventArgs) Handles Button120.Click
        ObjectPlacement.SelectedBlock = 52
    End Sub

    Private Sub Button121_Click(sender As System.Object, e As System.EventArgs) Handles Button121.Click
        ObjectPlacement.SelectedBlock = 610
    End Sub

    Private Sub Button122_Click(sender As System.Object, e As System.EventArgs) Handles Button122.Click
        ObjectPlacement.SelectedBlock = 50
    End Sub

    Private Sub Button123_Click(sender As System.Object, e As System.EventArgs) Handles Button123.Click
        ObjectPlacement.SelectedBlock = 54
    End Sub

    Private Sub Button124_Click(sender As System.Object, e As System.EventArgs) Handles Button124.Click
        ObjectPlacement.SelectedBlock = 47
    End Sub

    Private Sub Button125_Click(sender As System.Object, e As System.EventArgs) Handles Button125.Click
        ObjectPlacement.SelectedBlock = 611
    End Sub

    Private Sub Button126_Click(sender As System.Object, e As System.EventArgs) Handles Button126.Click
        ObjectPlacement.SelectedBlock = 612
    End Sub

    Private Sub Button127_Click(sender As System.Object, e As System.EventArgs) Handles Button127.Click
        ObjectPlacement.SelectedBlock = 608
    End Sub

    Private Sub Button128_Click(sender As System.Object, e As System.EventArgs) Handles Button128.Click
        ObjectPlacement.SelectedBlock = 48
    End Sub

    Private Sub Button129_Click(sender As System.Object, e As System.EventArgs) Handles Button129.Click
        ObjectPlacement.SelectedBlock = 609
    End Sub

    Private Sub Button130_Click(sender As System.Object, e As System.EventArgs) Handles Button130.Click
        ObjectPlacement.SelectedBlock = 51
    End Sub

    Private Sub Button131_Click(sender As System.Object, e As System.EventArgs) Handles Button131.Click
        ObjectPlacement.SelectedBlock = 53
    End Sub

    Private Sub Button132_Click(sender As System.Object, e As System.EventArgs) Handles Button132.Click
        ObjectPlacement.SelectedBlock = 219
    End Sub

    Private Sub Button133_Click(sender As System.Object, e As System.EventArgs) Handles Button133.Click
        ObjectPlacement.SelectedBlock = 220
    End Sub

    Private Sub Button134_Click(sender As System.Object, e As System.EventArgs) Handles Button134.Click
        ObjectPlacement.SelectedBlock = 221
    End Sub

    Private Sub Button135_Click(sender As System.Object, e As System.EventArgs) Handles Button135.Click
        ObjectPlacement.SelectedBlock = 222
    End Sub

    Private Sub Button136_Click(sender As System.Object, e As System.EventArgs) Handles Button136.Click
        ObjectPlacement.SelectedBlock = 217
    End Sub

    Private Sub Button137_Click(sender As System.Object, e As System.EventArgs) Handles Button137.Click
        ObjectPlacement.SelectedBlock = 218
    End Sub

    Private Sub Button138_Click(sender As System.Object, e As System.EventArgs) Handles Button138.Click
        ObjectPlacement.SelectedBlock = 29
    End Sub

    Private Sub Button139_Click(sender As System.Object, e As System.EventArgs) Handles Button139.Click
        ObjectPlacement.SelectedBlock = 91
    End Sub

    Private Sub Button140_Click(sender As System.Object, e As System.EventArgs) Handles Button140.Click
        ObjectPlacement.SelectedBlock = 126
    End Sub

    Private Sub Button141_Click(sender As System.Object, e As System.EventArgs) Handles Button141.Click
        ObjectPlacement.SelectedBlock = 630
    End Sub

    Private Sub Button142_Click(sender As System.Object, e As System.EventArgs) Handles Button142.Click
        ObjectPlacement.SelectedBlock = 136
    End Sub

    Private Sub Button143_Click(sender As System.Object, e As System.EventArgs) Handles Button143.Click
        ObjectPlacement.SelectedBlock = 580
    End Sub

    Private Sub Button144_Click(sender As System.Object, e As System.EventArgs) Handles Button144.Click
        ObjectPlacement.SelectedBlock = 581
    End Sub

    Private Sub Button145_Click(sender As System.Object, e As System.EventArgs) Handles Button145.Click
        ObjectPlacement.SelectedBlock = 582
    End Sub

    Private Sub Button146_Click(sender As System.Object, e As System.EventArgs) Handles Button146.Click
        ObjectPlacement.SelectedBlock = 586
    End Sub

    Private Sub Button147_Click(sender As System.Object, e As System.EventArgs) Handles Button147.Click
        ObjectPlacement.SelectedBlock = 587
    End Sub

    Private Sub Button148_Click(sender As System.Object, e As System.EventArgs) Handles Button148.Click
        ObjectPlacement.SelectedBlock = 588
    End Sub

    Private Sub Button149_Click(sender As System.Object, e As System.EventArgs) Handles Button149.Click
        ObjectPlacement.SelectedBlock = 583
    End Sub

    Private Sub Button150_Click(sender As System.Object, e As System.EventArgs) Handles Button150.Click
        ObjectPlacement.SelectedBlock = 584
    End Sub

    Private Sub Button151_Click(sender As System.Object, e As System.EventArgs) Handles Button151.Click
        ObjectPlacement.SelectedBlock = 585
    End Sub

    Private Sub Button152_Click(sender As System.Object, e As System.EventArgs) Handles Button152.Click
        ObjectPlacement.SelectedBlock = 589
    End Sub

    Private Sub Button153_Click(sender As System.Object, e As System.EventArgs) Handles Button153.Click
        ObjectPlacement.SelectedBlock = 590
    End Sub

    Private Sub Button154_Click(sender As System.Object, e As System.EventArgs) Handles Button154.Click
        ObjectPlacement.SelectedBlock = 591
    End Sub

    Private Sub Button155_Click(sender As System.Object, e As System.EventArgs) Handles Button155.Click
        ObjectPlacement.SelectedBlock = 598
    End Sub

    Private Sub Button156_Click(sender As System.Object, e As System.EventArgs) Handles Button156.Click
        ObjectPlacement.SelectedBlock = 578
    End Sub

    Private Sub Button157_Click(sender As System.Object, e As System.EventArgs) Handles Button157.Click
        ObjectPlacement.SelectedBlock = 599
    End Sub

    Private Sub Button158_Click(sender As System.Object, e As System.EventArgs) Handles Button158.Click
        ObjectPlacement.SelectedBlock = 592
    End Sub

    Private Sub Button159_Click(sender As System.Object, e As System.EventArgs) Handles Button159.Click
        ObjectPlacement.SelectedBlock = 593
    End Sub

    Private Sub Button160_Click(sender As System.Object, e As System.EventArgs) Handles Button160.Click
        ObjectPlacement.SelectedBlock = 594
    End Sub

    Private Sub Button161_Click(sender As System.Object, e As System.EventArgs) Handles Button161.Click
        ObjectPlacement.SelectedBlock = 270
    End Sub

    Private Sub Button162_Click(sender As System.Object, e As System.EventArgs) Handles Button162.Click
        ObjectPlacement.SelectedBlock = 272
    End Sub

    Private Sub Button163_Click(sender As System.Object, e As System.EventArgs) Handles Button163.Click
        ObjectPlacement.SelectedBlock = 271
    End Sub

    Private Sub Button164_Click(sender As System.Object, e As System.EventArgs) Handles Button164.Click
        ObjectPlacement.SelectedBlock = 633
    End Sub

    Private Sub Button165_Click(sender As System.Object, e As System.EventArgs) Handles Button165.Click
        ObjectPlacement.SelectedBlock = 634
    End Sub

    Private Sub Button166_Click(sender As System.Object, e As System.EventArgs) Handles Button166.Click
        ObjectPlacement.SelectedBlock = 73
    End Sub

    Private Sub Button167_Click(sender As System.Object, e As System.EventArgs) Handles Button167.Click
        ObjectPlacement.SelectedBlock = 70
    End Sub

    Private Sub Button168_Click(sender As System.Object, e As System.EventArgs) Handles Button168.Click
        ObjectPlacement.SelectedBlock = 71
    End Sub

    Private Sub Button169_Click(sender As System.Object, e As System.EventArgs) Handles Button169.Click
        ObjectPlacement.SelectedBlock = 72
    End Sub

    Private Sub Button170_Click(sender As System.Object, e As System.EventArgs) Handles Button170.Click
        ObjectPlacement.SelectedBlock = 74
    End Sub

    Private Sub Button171_Click(sender As System.Object, e As System.EventArgs) Handles Button171.Click
        ObjectPlacement.SelectedBlock = 78
    End Sub

    Private Sub Button172_Click(sender As System.Object, e As System.EventArgs) Handles Button172.Click
        ObjectPlacement.SelectedBlock = 77
    End Sub

    Private Sub Button173_Click(sender As System.Object, e As System.EventArgs) Handles Button173.Click
        ObjectPlacement.SelectedBlock = 185
    End Sub

    Private Sub Button174_Click(sender As System.Object, e As System.EventArgs) Handles Button174.Click
        ObjectPlacement.SelectedBlock = 75
    End Sub

    Private Sub Button175_Click(sender As System.Object, e As System.EventArgs) Handles Button175.Click
        ObjectPlacement.SelectedBlock = 613
    End Sub

    Private Sub Button176_Click(sender As System.Object, e As System.EventArgs) Handles Button176.Click
        ObjectPlacement.SelectedBlock = 614
    End Sub

    Private Sub Button177_Click(sender As System.Object, e As System.EventArgs) Handles Button177.Click
        ObjectPlacement.SelectedBlock = 76
    End Sub

    Private Sub Button178_Click(sender As System.Object, e As System.EventArgs) Handles Button178.Click
        ObjectPlacement.SelectedBlock = 110
    End Sub

    Private Sub Button179_Click(sender As System.Object, e As System.EventArgs) Handles Button179.Click
        ObjectPlacement.SelectedBlock = 30
    End Sub

    Private Sub Button180_Click(sender As System.Object, e As System.EventArgs) Handles Button180.Click
        ObjectPlacement.SelectedBlock = 109
    End Sub

    Private Sub Button181_Click(sender As System.Object, e As System.EventArgs) Handles Button181.Click
        ObjectPlacement.SelectedBlock = 268
    End Sub

    Private Sub Button182_Click(sender As System.Object, e As System.EventArgs) Handles Button182.Click
        ObjectPlacement.SelectedBlock = 406
    End Sub

    Private Sub Button183_Click(sender As System.Object, e As System.EventArgs) Handles Button183.Click
        ObjectPlacement.SelectedBlock = 269
    End Sub

    Private Sub Button184_Click(sender As System.Object, e As System.EventArgs) Handles Button184.Click
        ObjectPlacement.SelectedBlock = 267
    End Sub

    Private Sub Button185_Click(sender As System.Object, e As System.EventArgs) Handles Button185.Click
        ObjectPlacement.SelectedBlock = 21
    End Sub

    Private Sub Button186_Click(sender As System.Object, e As System.EventArgs) Handles Button186.Click
        ObjectPlacement.SelectedBlock = 34
    End Sub

    Private Sub Button187_Click(sender As System.Object, e As System.EventArgs) Handles Button187.Click
        ObjectPlacement.SelectedBlock = 36
    End Sub

    Private Sub Button188_Click(sender As System.Object, e As System.EventArgs) Handles Button188.Click
        ObjectPlacement.SelectedBlock = 103
    End Sub

    Private Sub Button189_Click(sender As System.Object, e As System.EventArgs) Handles Button189.Click
        ObjectPlacement.SelectedBlock = 23
    End Sub

    Private Sub Button190_Click(sender As System.Object, e As System.EventArgs) Handles Button190.Click
        ObjectPlacement.SelectedBlock = 24
    End Sub

    Private Sub Button191_Click(sender As System.Object, e As System.EventArgs) Handles Button191.Click
        ObjectPlacement.SelectedBlock = 22
    End Sub

    Private Sub Button192_Click(sender As System.Object, e As System.EventArgs) Handles Button192.Click
        ObjectPlacement.SelectedBlock = 35
    End Sub

    Private Sub Button193_Click(sender As System.Object, e As System.EventArgs) Handles Button193.Click
        ObjectPlacement.SelectedBlock = 37
    End Sub

    Private Sub Button194_Click(sender As System.Object, e As System.EventArgs) Handles Button194.Click
        ObjectPlacement.SelectedBlock = 104
    End Sub

    Private Sub Button195_Click(sender As System.Object, e As System.EventArgs) Handles Button195.Click
        ObjectPlacement.SelectedBlock = 295
    End Sub

    Private Sub Button196_Click(sender As System.Object, e As System.EventArgs) Handles Button196.Click
        ObjectPlacement.SelectedBlock = 294
    End Sub

    Private Sub Button197_Click(sender As System.Object, e As System.EventArgs) Handles Button197.Click
        ObjectPlacement.SelectedBlock = 571
    End Sub

    Private Sub Button198_Click(sender As System.Object, e As System.EventArgs) Handles Button198.Click
        ObjectPlacement.SelectedBlock = 31
    End Sub

    Private Sub Button199_Click(sender As System.Object, e As System.EventArgs) Handles Button199.Click
        ObjectPlacement.SelectedBlock = 32
    End Sub

    Private Sub Button200_Click(sender As System.Object, e As System.EventArgs) Handles Button200.Click
        ObjectPlacement.SelectedBlock = 33
    End Sub

    Private Sub Button201_Click(sender As System.Object, e As System.EventArgs) Handles Button201.Click
        ObjectPlacement.SelectedBlock = 182
    End Sub

    Private Sub Button202_Click(sender As System.Object, e As System.EventArgs) Handles Button202.Click
        ObjectPlacement.SelectedBlock = 296
    End Sub

    Private Sub Button203_Click(sender As System.Object, e As System.EventArgs) Handles Button203.Click
        ObjectPlacement.SelectedBlock = 569
    End Sub

    Private Sub Button204_Click(sender As System.Object, e As System.EventArgs) Handles Button204.Click
        ObjectPlacement.SelectedBlock = 570
    End Sub

    Private Sub Button205_Click(sender As System.Object, e As System.EventArgs) Handles Button205.Click
        ObjectPlacement.SelectedBlock = 25
    End Sub

    Private Sub Button206_Click(sender As System.Object, e As System.EventArgs) Handles Button206.Click
        ObjectPlacement.SelectedBlock = 26
    End Sub

    Private Sub Button207_Click(sender As System.Object, e As System.EventArgs) Handles Button207.Click
        ObjectPlacement.SelectedBlock = 240
    End Sub

    Private Sub Button208_Click(sender As System.Object, e As System.EventArgs) Handles Button208.Click
        ObjectPlacement.SelectedBlock = 575
    End Sub

    Private Sub Button209_Click(sender As System.Object, e As System.EventArgs) Handles Button209.Click
        ObjectPlacement.SelectedBlock = 27
    End Sub

    Private Sub Button210_Click(sender As System.Object, e As System.EventArgs) Handles Button210.Click
        ObjectPlacement.SelectedBlock = 28
    End Sub

    Private Sub Button211_Click(sender As System.Object, e As System.EventArgs) Handles Button211.Click
        ObjectPlacement.SelectedBlock = 241
    End Sub

    Private Sub Button212_Click(sender As System.Object, e As System.EventArgs) Handles Button212.Click
        ObjectPlacement.SelectedBlock = 568
    End Sub

    Private Sub Button213_Click(sender As System.Object, e As System.EventArgs) Handles Button213.Click
        ObjectPlacement.SelectedBlock = 108
    End Sub

    Private Sub Button214_Click(sender As System.Object, e As System.EventArgs) Handles Button214.Click
        ObjectPlacement.SelectedBlock = 130
    End Sub

    Private Sub Button215_Click(sender As System.Object, e As System.EventArgs) Handles Button215.Click
        ObjectPlacement.SelectedBlock = 260
    End Sub

    Private Sub Button216_Click(sender As System.Object, e As System.EventArgs) Handles Button216.Click
        ObjectPlacement.SelectedBlock = 579
    End Sub

    Private Sub Button217_Click(sender As System.Object, e As System.EventArgs) Handles Button217.Click
        ObjectPlacement.SelectedBlock = 8
    End Sub

    Private Sub Button218_Click(sender As System.Object, e As System.EventArgs) Handles Button218.Click
        ObjectPlacement.SelectedBlock = 280
    End Sub

    Private Sub Button219_Click(sender As System.Object, e As System.EventArgs) Handles Button219.Click
        ObjectPlacement.SelectedBlock = 187
    End Sub

    Private Sub Button220_Click(sender As System.Object, e As System.EventArgs) Handles Button220.Click
        ObjectPlacement.SelectedBlock = 112
    End Sub

    Private Sub Button221_Click(sender As System.Object, e As System.EventArgs) Handles Button221.Click
        ObjectPlacement.SelectedBlock = 458
    End Sub

    Private Sub Button222_Click(sender As System.Object, e As System.EventArgs) Handles Button222.Click
        ObjectPlacement.SelectedBlock = 132
    End Sub

    Private Sub Button223_Click(sender As System.Object, e As System.EventArgs) Handles Button223.Click
        ObjectPlacement.SelectedBlock = 290
    End Sub

    Private Sub Button224_Click(sender As System.Object, e As System.EventArgs) Handles Button224.Click
        ObjectPlacement.SelectedBlock = 107
    End Sub

    Private Sub Button225_Click(sender As System.Object, e As System.EventArgs) Handles Button225.Click
        ObjectPlacement.SelectedBlock = 289
    End Sub

    Private Sub Button226_Click(sender As System.Object, e As System.EventArgs) Handles Button226.Click
        ObjectPlacement.SelectedBlock = 111
    End Sub

    Private Sub Button227_Click(sender As System.Object, e As System.EventArgs) Handles Button227.Click
        ObjectPlacement.SelectedBlock = 160
    End Sub

    Private Sub Button228_Click(sender As System.Object, e As System.EventArgs) Handles Button228.Click
        ObjectPlacement.SelectedBlock = 457
    End Sub

    Private Sub Button229_Click(sender As System.Object, e As System.EventArgs) Handles Button229.Click
        ObjectPlacement.SelectedBlock = 106
    End Sub

    Private Sub Button230_Click(sender As System.Object, e As System.EventArgs) Handles Button230.Click
        ObjectPlacement.SelectedBlock = 105
    End Sub

    Private Sub Button231_Click(sender As System.Object, e As System.EventArgs) Handles Button231.Click
        ObjectPlacement.SelectedBlock = 168
    End Sub

    Private Sub Button232_Click(sender As System.Object, e As System.EventArgs) Handles Button232.Click
        ObjectPlacement.SelectedBlock = 184
    End Sub

    Private Sub Button233_Click(sender As System.Object, e As System.EventArgs) Handles Button233.Click
        ObjectPlacement.SelectedBlock = 223
    End Sub

    Private Sub Button234_Click(sender As System.Object, e As System.EventArgs) Handles Button234.Click
        ObjectPlacement.SelectedBlock = 572
    End Sub

    Private Sub Button235_Click(sender As System.Object, e As System.EventArgs) Handles Button235.Click
        ObjectPlacement.SelectedBlock = 5
    End Sub

    Private Sub Button236_Click(sender As System.Object, e As System.EventArgs) Handles Button236.Click
        ObjectPlacement.SelectedBlock = 2
    End Sub

    Private Sub Button237_Click(sender As System.Object, e As System.EventArgs) Handles Button237.Click
        ObjectPlacement.SelectedBlock = 4
    End Sub

    Private Sub Button238_Click(sender As System.Object, e As System.EventArgs) Handles Button238.Click
        ObjectPlacement.SelectedBlock = 621
    End Sub

    Private Sub Button239_Click(sender As System.Object, e As System.EventArgs) Handles Button239.Click
        ObjectPlacement.SelectedBlock = 224
    End Sub

    Private Sub Button240_Click(sender As System.Object, e As System.EventArgs) Handles Button240.Click
        ObjectPlacement.SelectedBlock = 225
    End Sub

    Private Sub Button241_Click(sender As System.Object, e As System.EventArgs) Handles Button241.Click
        ObjectPlacement.SelectedBlock = 226
    End Sub

    Private Sub Button242_Click(sender As System.Object, e As System.EventArgs) Handles Button242.Click
        ObjectPlacement.SelectedBlock = 620
    End Sub

    Private Sub Button243_Click(sender As System.Object, e As System.EventArgs) Handles Button243.Click
        ObjectPlacement.SelectedBlock = 55
    End Sub

    Private Sub Button244_Click(sender As System.Object, e As System.EventArgs) Handles Button244.Click
        ObjectPlacement.SelectedBlock = 186
    End Sub

    Private Sub Button245_Click(sender As System.Object, e As System.EventArgs) Handles Button245.Click
        ObjectPlacement.SelectedBlock = 159
    End Sub

    Private Sub Button252_Click(sender As System.Object, e As System.EventArgs) Handles Button252.Click
        ObjectPlacement.SelectedBlock = 39
    End Sub

    Private Sub Button253_Click(sender As System.Object, e As System.EventArgs) Handles Button253.Click
        ObjectPlacement.SelectedBlock = 40
    End Sub

    Private Sub Button254_Click(sender As System.Object, e As System.EventArgs) Handles Button254.Click
        ObjectPlacement.SelectedBlock = 41
    End Sub

    Private Sub Button255_Click(sender As System.Object, e As System.EventArgs) Handles Button255.Click
        ObjectPlacement.SelectedBlock = 45
    End Sub

    Private Sub Button256_Click(sender As System.Object, e As System.EventArgs) Handles Button256.Click
        ObjectPlacement.SelectedBlock = 340
    End Sub

    Private Sub Button257_Click(sender As System.Object, e As System.EventArgs) Handles Button257.Click
        ObjectPlacement.SelectedBlock = 342
    End Sub

    Private Sub Button258_Click(sender As System.Object, e As System.EventArgs) Handles Button258.Click
        ObjectPlacement.SelectedBlock = 341
    End Sub

    Private Sub Button259_Click(sender As System.Object, e As System.EventArgs) Handles Button259.Click
        ObjectPlacement.SelectedBlock = 343
    End Sub

    Private Sub Button260_Click(sender As System.Object, e As System.EventArgs) Handles Button260.Click
        ObjectPlacement.SelectedBlock = 198
    End Sub

    Private Sub Button261_Click(sender As System.Object, e As System.EventArgs) Handles Button261.Click
        ObjectPlacement.SelectedBlock = 200
    End Sub

    Private Sub Button262_Click(sender As System.Object, e As System.EventArgs) Handles Button262.Click
        ObjectPlacement.SelectedBlock = 199
    End Sub

    Private Sub Button263_Click(sender As System.Object, e As System.EventArgs) Handles Button263.Click
        ObjectPlacement.SelectedBlock = 46
    End Sub

    Private Sub Button264_Click(sender As System.Object, e As System.EventArgs) Handles Button264.Click
        ObjectPlacement.SelectedBlock = 336
    End Sub

    Private Sub Button265_Click(sender As System.Object, e As System.EventArgs) Handles Button265.Click
        ObjectPlacement.SelectedBlock = 338
    End Sub

    Private Sub Button266_Click(sender As System.Object, e As System.EventArgs) Handles Button266.Click
        ObjectPlacement.SelectedBlock = 337
    End Sub

    Private Sub Button267_Click(sender As System.Object, e As System.EventArgs) Handles Button267.Click
        ObjectPlacement.SelectedBlock = 339
    End Sub

    Private Sub Button268_Click(sender As System.Object, e As System.EventArgs) Handles Button268.Click
        ObjectPlacement.SelectedBlock = 42
    End Sub

    Private Sub Button269_Click(sender As System.Object, e As System.EventArgs) Handles Button269.Click
        ObjectPlacement.SelectedBlock = 43
    End Sub

    Private Sub Button270_Click(sender As System.Object, e As System.EventArgs) Handles Button270.Click
        ObjectPlacement.SelectedBlock = 44
    End Sub

    Private Sub Button271_Click(sender As System.Object, e As System.EventArgs) Handles Button271.Click
        ObjectPlacement.SelectedBlock = 207
    End Sub

    Private Sub Button272_Click(sender As System.Object, e As System.EventArgs) Handles Button272.Click
        ObjectPlacement.SelectedBlock = 201
    End Sub

    Private Sub Button273_Click(sender As System.Object, e As System.EventArgs) Handles Button273.Click
        ObjectPlacement.SelectedBlock = 208
    End Sub

    Private Sub Button274_Click(sender As System.Object, e As System.EventArgs) Handles Button274.Click
        ObjectPlacement.SelectedBlock = 211
    End Sub

    Private Sub Button275_Click(sender As System.Object, e As System.EventArgs) Handles Button275.Click
        ObjectPlacement.SelectedBlock = 212
    End Sub

    Private Sub Button276_Click(sender As System.Object, e As System.EventArgs) Handles Button276.Click
        ObjectPlacement.SelectedBlock = 203
    End Sub

    Private Sub Button277_Click(sender As System.Object, e As System.EventArgs) Handles Button277.Click
        ObjectPlacement.SelectedBlock = 205
    End Sub

    Private Sub Button278_Click(sender As System.Object, e As System.EventArgs) Handles Button278.Click
        ObjectPlacement.SelectedBlock = 204
    End Sub

    Private Sub Button279_Click(sender As System.Object, e As System.EventArgs) Handles Button279.Click
        ObjectPlacement.SelectedBlock = 216
    End Sub

    Private Sub Button280_Click(sender As System.Object, e As System.EventArgs) Handles Button280.Click
        ObjectPlacement.SelectedBlock = 214
    End Sub

    Private Sub Button281_Click(sender As System.Object, e As System.EventArgs) Handles Button281.Click
        ObjectPlacement.SelectedBlock = 213
    End Sub

    Private Sub Button282_Click(sender As System.Object, e As System.EventArgs) Handles Button282.Click
        ObjectPlacement.SelectedBlock = 215
    End Sub

    Private Sub Button283_Click(sender As System.Object, e As System.EventArgs) Handles Button283.Click
        ObjectPlacement.SelectedBlock = 206
    End Sub

    Private Sub Button284_Click(sender As System.Object, e As System.EventArgs) Handles Button284.Click
        ObjectPlacement.SelectedBlock = 38
    End Sub

    Private Sub Button285_Click(sender As System.Object, e As System.EventArgs) Handles Button285.Click
        ObjectPlacement.SelectedBlock = 242
    End Sub

    Private Sub Button286_Click(sender As System.Object, e As System.EventArgs) Handles Button286.Click
        ObjectPlacement.SelectedBlock = 243
    End Sub

    Private Sub Button287_Click(sender As System.Object, e As System.EventArgs) Handles Button287.Click
        ObjectPlacement.SelectedBlock = 288
    End Sub

    Private Sub Button288_Click(sender As System.Object, e As System.EventArgs) Handles Button288.Click
        ObjectPlacement.SelectedBlock = 293
    End Sub

    Private Sub Button289_Click(sender As System.Object, e As System.EventArgs) Handles Button289.Click
        ObjectPlacement.SelectedBlock = 370
    End Sub

    Private Sub Button290_Click(sender As System.Object, e As System.EventArgs) Handles Button290.Click
        ObjectPlacement.SelectedBlock = 209
    End Sub

    Private Sub Button291_Click(sender As System.Object, e As System.EventArgs) Handles Button291.Click
        ObjectPlacement.SelectedBlock = 391
    End Sub

    Private Sub Button292_Click(sender As System.Object, e As System.EventArgs) Handles Button292.Click
        ObjectPlacement.SelectedBlock = 392
    End Sub

    Private Sub Button293_Click(sender As System.Object, e As System.EventArgs) Handles Button293.Click
        ObjectPlacement.SelectedBlock = 389
    End Sub

    Private Sub Button294_Click(sender As System.Object, e As System.EventArgs) Handles Button294.Click
        ObjectPlacement.SelectedBlock = 573
    End Sub

    Private Sub Button295_Click(sender As System.Object, e As System.EventArgs) Handles Button295.Click
        ObjectPlacement.SelectedBlock = 202
    End Sub

    Private Sub Button296_Click(sender As System.Object, e As System.EventArgs) Handles Button296.Click
        ObjectPlacement.SelectedBlock = 297
    End Sub

    Private Sub Button297_Click(sender As System.Object, e As System.EventArgs) Handles Button297.Click
        ObjectPlacement.SelectedBlock = 131
    End Sub

    Private Sub Button298_Click(sender As System.Object, e As System.EventArgs) Handles Button298.Click
        ObjectPlacement.SelectedBlock = 505
    End Sub

    Private Sub Button299_Click(sender As System.Object, e As System.EventArgs) Handles Button299.Click
        ObjectPlacement.SelectedBlock = 574
    End Sub

    Private Sub Button300_Click(sender As System.Object, e As System.EventArgs) Handles Button300.Click
        ObjectPlacement.SelectedBlock = 210
    End Sub

    Private Sub Button301_Click(sender As System.Object, e As System.EventArgs) Handles Button301.Click
        ObjectPlacement.SelectedBlock = 298
    End Sub

    Private Sub Button302_Click(sender As System.Object, e As System.EventArgs) Handles Button302.Click
        ObjectPlacement.SelectedBlock = 509
    End Sub

    Private Sub Button303_Click(sender As System.Object, e As System.EventArgs) Handles Button303.Click
        ObjectPlacement.SelectedBlock = 492
    End Sub

    Private Sub Button304_Click(sender As System.Object, e As System.EventArgs) Handles Button304.Click
        ObjectPlacement.SelectedBlock = 496
    End Sub

    Private Sub Button305_Click(sender As System.Object, e As System.EventArgs) Handles Button305.Click
        ObjectPlacement.SelectedBlock = 501
    End Sub

    Private Sub Button306_Click(sender As System.Object, e As System.EventArgs) Handles Button306.Click
        ObjectPlacement.SelectedBlock = 500
    End Sub

    Private Sub Button307_Click(sender As System.Object, e As System.EventArgs) Handles Button307.Click
        ObjectPlacement.SelectedBlock = 493
    End Sub

    Private Sub Button308_Click(sender As System.Object, e As System.EventArgs) Handles Button308.Click
        ObjectPlacement.SelectedBlock = 490
    End Sub

    Private Sub Button309_Click(sender As System.Object, e As System.EventArgs) Handles Button309.Click
        ObjectPlacement.SelectedBlock = 499
    End Sub

    Private Sub Button310_Click(sender As System.Object, e As System.EventArgs) Handles Button310.Click
        ObjectPlacement.SelectedBlock = 495
    End Sub

    Private Sub Button311_Click(sender As System.Object, e As System.EventArgs) Handles Button311.Click
        ObjectPlacement.SelectedBlock = 503
    End Sub

    Private Sub Button312_Click(sender As System.Object, e As System.EventArgs) Handles Button312.Click
        ObjectPlacement.SelectedBlock = 497
    End Sub

    Private Sub Button313_Click(sender As System.Object, e As System.EventArgs) Handles Button313.Click
        ObjectPlacement.SelectedBlock = 494
    End Sub

    Private Sub Button314_Click(sender As System.Object, e As System.EventArgs) Handles Button314.Click
        ObjectPlacement.SelectedBlock = 498
    End Sub

    Private Sub Button315_Click(sender As System.Object, e As System.EventArgs) Handles Button315.Click
        ObjectPlacement.SelectedBlock = 511
    End Sub

    Private Sub Button316_Click(sender As System.Object, e As System.EventArgs) Handles Button316.Click
        ObjectPlacement.SelectedBlock = 507
    End Sub

    Private Sub Button317_Click(sender As System.Object, e As System.EventArgs) Handles Button317.Click
        ObjectPlacement.SelectedBlock = 506
    End Sub

    Private Sub Button318_Click(sender As System.Object, e As System.EventArgs) Handles Button318.Click
        ObjectPlacement.SelectedBlock = 508
    End Sub

    Private Sub Button319_Click(sender As System.Object, e As System.EventArgs) Handles Button319.Click
        ObjectPlacement.SelectedBlock = 491
    End Sub

    Private Sub Button320_Click(sender As System.Object, e As System.EventArgs) Handles Button320.Click
        ObjectPlacement.SelectedBlock = 502
    End Sub

    Private Sub Button321_Click(sender As System.Object, e As System.EventArgs) Handles Button321.Click
        ObjectPlacement.SelectedBlock = 504
    End Sub

    Private Sub Button322_Click(sender As System.Object, e As System.EventArgs) Handles Button322.Click
        ObjectPlacement.SelectedBlock = 510
    End Sub

    Private Sub Button323_Click(sender As System.Object, e As System.EventArgs) Handles Button323.Click
        ObjectPlacement.SelectedBlock = 62
    End Sub

    Private Sub Button324_Click(sender As System.Object, e As System.EventArgs) Handles Button324.Click
        ObjectPlacement.SelectedBlock = 63
    End Sub

    Private Sub Button325_Click(sender As System.Object, e As System.EventArgs) Handles Button325.Click
        ObjectPlacement.SelectedBlock = 64
    End Sub

    Private Sub Button326_Click(sender As System.Object, e As System.EventArgs) Handles Button326.Click
        ObjectPlacement.SelectedBlock = 332
    End Sub

    Private Sub Button327_Click(sender As System.Object, e As System.EventArgs) Handles Button327.Click
        ObjectPlacement.SelectedBlock = 333
    End Sub

    Private Sub Button328_Click(sender As System.Object, e As System.EventArgs) Handles Button328.Click
        ObjectPlacement.SelectedBlock = 93
    End Sub

    Private Sub Button329_Click(sender As System.Object, e As System.EventArgs) Handles Button329.Click
        ObjectPlacement.SelectedBlock = 189
    End Sub

    Private Sub Button330_Click(sender As System.Object, e As System.EventArgs) Handles Button330.Click
        ObjectPlacement.SelectedBlock = 190
    End Sub

    Private Sub Button331_Click(sender As System.Object, e As System.EventArgs) Handles Button331.Click
        ObjectPlacement.SelectedBlock = 191
    End Sub

    Private Sub Button332_Click(sender As System.Object, e As System.EventArgs) Handles Button332.Click
        ObjectPlacement.SelectedBlock = 335
    End Sub

    Private Sub Button333_Click(sender As System.Object, e As System.EventArgs) Handles Button333.Click
        ObjectPlacement.SelectedBlock = 334
    End Sub

    Private Sub Button334_Click(sender As System.Object, e As System.EventArgs) Handles Button334.Click
        ObjectPlacement.SelectedBlock = 65
    End Sub

    Private Sub Button343_Click(sender As System.Object, e As System.EventArgs) Handles Button343.Click
        ObjectPlacement.SelectedBlock = 56
    End Sub

    Private Sub Button344_Click(sender As System.Object, e As System.EventArgs) Handles Button344.Click
        ObjectPlacement.SelectedBlock = 57
    End Sub

    Private Sub Button345_Click(sender As System.Object, e As System.EventArgs) Handles Button345.Click
        ObjectPlacement.SelectedBlock = 58
    End Sub

    Private Sub Button346_Click(sender As System.Object, e As System.EventArgs) Handles Button346.Click
        ObjectPlacement.SelectedBlock = 326
    End Sub

    Private Sub Button347_Click(sender As System.Object, e As System.EventArgs) Handles Button347.Click
        ObjectPlacement.SelectedBlock = 327
    End Sub

    Private Sub Button348_Click(sender As System.Object, e As System.EventArgs) Handles Button348.Click
        ObjectPlacement.SelectedBlock = 61
    End Sub

    Private Sub Button349_Click(sender As System.Object, e As System.EventArgs) Handles Button349.Click
        ObjectPlacement.SelectedBlock = 331
    End Sub

    Private Sub Button350_Click(sender As System.Object, e As System.EventArgs) Handles Button350.Click
        ObjectPlacement.SelectedBlock = 323
    End Sub

    Private Sub Button351_Click(sender As System.Object, e As System.EventArgs) Handles Button351.Click
        ObjectPlacement.SelectedBlock = 330
    End Sub

    Private Sub Button352_Click(sender As System.Object, e As System.EventArgs) Handles Button352.Click
        ObjectPlacement.SelectedBlock = 329
    End Sub

    Private Sub Button353_Click(sender As System.Object, e As System.EventArgs) Handles Button353.Click
        ObjectPlacement.SelectedBlock = 328
    End Sub

    Private Sub Button354_Click(sender As System.Object, e As System.EventArgs) Handles Button354.Click
        ObjectPlacement.SelectedBlock = 59
    End Sub

    Private Sub Button355_Click(sender As System.Object, e As System.EventArgs) Handles Button355.Click
        ObjectPlacement.SelectedBlock = 324
    End Sub

    Private Sub Button356_Click(sender As System.Object, e As System.EventArgs) Handles Button356.Click
        ObjectPlacement.SelectedBlock = 325
    End Sub

    Private Sub Button357_Click(sender As System.Object, e As System.EventArgs) Handles Button357.Click
        ObjectPlacement.SelectedBlock = 287
    End Sub

    Private Sub Button358_Click(sender As System.Object, e As System.EventArgs) Handles Button358.Click
        ObjectPlacement.SelectedBlock = 193
    End Sub

    Private Sub Button359_Click(sender As System.Object, e As System.EventArgs) Handles Button359.Click
        ObjectPlacement.SelectedBlock = 192
    End Sub

    Private Sub Button360_Click(sender As System.Object, e As System.EventArgs) Handles Button360.Click
        ObjectPlacement.SelectedBlock = 188
    End Sub

    Private Sub Button361_Click(sender As System.Object, e As System.EventArgs) Handles Button361.Click
        ObjectPlacement.SelectedBlock = 60
    End Sub

    Private Sub Button362_Click(sender As System.Object, e As System.EventArgs) Handles Button362.Click
        ObjectPlacement.SelectedBlock = 66
    End Sub

    Private Sub Button363_Click(sender As System.Object, e As System.EventArgs) Handles Button363.Click
        ObjectPlacement.SelectedBlock = 67
    End Sub

    Private Sub Button364_Click(sender As System.Object, e As System.EventArgs) Handles Button364.Click
        ObjectPlacement.SelectedBlock = 68
    End Sub

    Private Sub Button365_Click(sender As System.Object, e As System.EventArgs) Handles Button365.Click
        ObjectPlacement.SelectedBlock = 69
    End Sub

    Private Sub Button366_Click(sender As System.Object, e As System.EventArgs) Handles Button366.Click
        ObjectPlacement.SelectedBlock = 369
    End Sub

    Private Sub Button367_Click(sender As System.Object, e As System.EventArgs) Handles Button367.Click
        ObjectPlacement.SelectedBlock = 388
    End Sub

    Private Sub Button368_Click(sender As System.Object, e As System.EventArgs) Handles Button368.Click
        ObjectPlacement.SelectedBlock = 576
    End Sub

    Private Sub Button369_Click(sender As System.Object, e As System.EventArgs) Handles Button369.Click
        ObjectPlacement.SelectedBlock = 577
    End Sub

    Private Sub Button370_Click(sender As System.Object, e As System.EventArgs) Handles Button370.Click
        ObjectPlacement.SelectedBlock = 194
    End Sub

    Private Sub Button371_Click(sender As System.Object, e As System.EventArgs) Handles Button371.Click
        ObjectPlacement.SelectedBlock = 196
    End Sub

    Private Sub Button372_Click(sender As System.Object, e As System.EventArgs) Handles Button372.Click
        ObjectPlacement.SelectedBlock = 195
    End Sub

    Private Sub Button373_Click(sender As System.Object, e As System.EventArgs) Handles Button373.Click
        ObjectPlacement.SelectedBlock = 197
    End Sub

    Private Sub Button374_Click(sender As System.Object, e As System.EventArgs) Handles Button374.Click
        ObjectPlacement.SelectedBlock = 376
    End Sub

    Private Sub Button375_Click(sender As System.Object, e As System.EventArgs) Handles Button375.Click
        ObjectPlacement.SelectedBlock = 377
    End Sub

    Private Sub Button376_Click(sender As System.Object, e As System.EventArgs) Handles Button376.Click
        ObjectPlacement.SelectedBlock = 378
    End Sub

    Private Sub Button377_Click(sender As System.Object, e As System.EventArgs) Handles Button377.Click
        ObjectPlacement.SelectedBlock = 396
    End Sub

    Private Sub Button378_Click(sender As System.Object, e As System.EventArgs) Handles Button378.Click
        ObjectPlacement.SelectedBlock = 387
    End Sub

    Private Sub Button379_Click(sender As System.Object, e As System.EventArgs) Handles Button379.Click
        ObjectPlacement.SelectedBlock = 402
    End Sub

    Private Sub Button380_Click(sender As System.Object, e As System.EventArgs) Handles Button380.Click
        ObjectPlacement.SelectedBlock = 385
    End Sub

    Private Sub Button381_Click(sender As System.Object, e As System.EventArgs) Handles Button381.Click
        ObjectPlacement.SelectedBlock = 403
    End Sub

    Private Sub Button382_Click(sender As System.Object, e As System.EventArgs) Handles Button382.Click
        ObjectPlacement.SelectedBlock = 371
    End Sub

    Private Sub Button383_Click(sender As System.Object, e As System.EventArgs) Handles Button383.Click
        ObjectPlacement.SelectedBlock = 401
    End Sub

    Private Sub Button384_Click(sender As System.Object, e As System.EventArgs) Handles Button384.Click
        ObjectPlacement.SelectedBlock = 395
    End Sub

    Private Sub Button385_Click(sender As System.Object, e As System.EventArgs) Handles Button385.Click
        ObjectPlacement.SelectedBlock = 394
    End Sub

    Private Sub Button386_Click(sender As System.Object, e As System.EventArgs) Handles Button386.Click
        ObjectPlacement.SelectedBlock = 393
    End Sub

    Private Sub Button387_Click(sender As System.Object, e As System.EventArgs) Handles Button387.Click
        ObjectPlacement.SelectedBlock = 384
    End Sub

    Private Sub Button388_Click(sender As System.Object, e As System.EventArgs) Handles Button388.Click
        ObjectPlacement.SelectedBlock = 383
    End Sub

    Private Sub Button389_Click(sender As System.Object, e As System.EventArgs) Handles Button389.Click
        ObjectPlacement.SelectedBlock = 405
    End Sub

    Private Sub Button390_Click(sender As System.Object, e As System.EventArgs) Handles Button390.Click
        ObjectPlacement.SelectedBlock = 386
    End Sub

    Private Sub Button391_Click(sender As System.Object, e As System.EventArgs) Handles Button391.Click
        ObjectPlacement.SelectedBlock = 397
    End Sub

    Private Sub Button392_Click(sender As System.Object, e As System.EventArgs) Handles Button392.Click
        ObjectPlacement.SelectedBlock = 390
    End Sub

    Private Sub Button393_Click(sender As System.Object, e As System.EventArgs) Handles Button393.Click
        ObjectPlacement.SelectedBlock = 399
    End Sub

    Private Sub Button394_Click(sender As System.Object, e As System.EventArgs) Handles Button394.Click
        ObjectPlacement.SelectedBlock = 398
    End Sub

    Private Sub Button395_Click(sender As System.Object, e As System.EventArgs) Handles Button395.Click
        ObjectPlacement.SelectedBlock = 400
    End Sub

    Private Sub Button396_Click(sender As System.Object, e As System.EventArgs) Handles Button396.Click
        ObjectPlacement.SelectedBlock = 373
    End Sub

    Private Sub Button397_Click(sender As System.Object, e As System.EventArgs) Handles Button397.Click
        ObjectPlacement.SelectedBlock = 374
    End Sub

    Private Sub Button398_Click(sender As System.Object, e As System.EventArgs) Handles Button398.Click
        ObjectPlacement.SelectedBlock = 375
    End Sub

    Private Sub Button399_Click(sender As System.Object, e As System.EventArgs) Handles Button399.Click
        ObjectPlacement.SelectedBlock = 372
    End Sub

    Private Sub Button400_Click(sender As System.Object, e As System.EventArgs) Handles Button400.Click
        ObjectPlacement.SelectedBlock = 379
    End Sub

    Private Sub Button401_Click(sender As System.Object, e As System.EventArgs) Handles Button401.Click
        ObjectPlacement.SelectedBlock = 380
    End Sub

    Private Sub Button402_Click(sender As System.Object, e As System.EventArgs) Handles Button402.Click
        ObjectPlacement.SelectedBlock = 381
    End Sub

    Private Sub Button403_Click(sender As System.Object, e As System.EventArgs) Handles Button403.Click
        ObjectPlacement.SelectedBlock = 382
    End Sub

    Private Sub Button417_Click(sender As System.Object, e As System.EventArgs) Handles Button417.Click
        ObjectPlacement.SelectedBlock = 80
    End Sub

    Private Sub Button418_Click(sender As System.Object, e As System.EventArgs) Handles Button418.Click
        ObjectPlacement.SelectedBlock = 81
    End Sub

    Private Sub Button419_Click(sender As System.Object, e As System.EventArgs) Handles Button419.Click
        ObjectPlacement.SelectedBlock = 82
    End Sub

    Private Sub Button420_Click(sender As System.Object, e As System.EventArgs) Handles Button420.Click
        ObjectPlacement.SelectedBlock = 273
    End Sub

    Private Sub Button421_Click(sender As System.Object, e As System.EventArgs) Handles Button421.Click
        ObjectPlacement.SelectedBlock = 263
    End Sub

    Private Sub Button422_Click(sender As System.Object, e As System.EventArgs) Handles Button422.Click
        ObjectPlacement.SelectedBlock = 299
    End Sub

    Private Sub Button423_Click(sender As System.Object, e As System.EventArgs) Handles Button423.Click
        ObjectPlacement.SelectedBlock = 300
    End Sub

    Private Sub Button424_Click(sender As System.Object, e As System.EventArgs) Handles Button424.Click
        ObjectPlacement.SelectedBlock = 302
    End Sub

    Private Sub Button425_Click(sender As System.Object, e As System.EventArgs) Handles Button425.Click
        ObjectPlacement.SelectedBlock = 301
    End Sub

    Private Sub Button426_Click(sender As System.Object, e As System.EventArgs) Handles Button426.Click
        ObjectPlacement.SelectedBlock = 83
    End Sub

    Private Sub Button427_Click(sender As System.Object, e As System.EventArgs) Handles Button427.Click
        ObjectPlacement.SelectedBlock = 87
    End Sub

    Private Sub Button428_Click(sender As System.Object, e As System.EventArgs) Handles Button428.Click
        ObjectPlacement.SelectedBlock = 84
    End Sub

    Private Sub Button429_Click(sender As System.Object, e As System.EventArgs) Handles Button429.Click
        ObjectPlacement.SelectedBlock = 85
    End Sub

    Private Sub Button430_Click(sender As System.Object, e As System.EventArgs) Handles Button430.Click
        ObjectPlacement.SelectedBlock = 86
    End Sub

    Private Sub Button431_Click(sender As System.Object, e As System.EventArgs) Handles Button431.Click
        ObjectPlacement.SelectedBlock = 309
    End Sub

    Private Sub Button432_Click(sender As System.Object, e As System.EventArgs) Handles Button432.Click
        ObjectPlacement.SelectedBlock = 310
    End Sub

    Private Sub Button433_Click(sender As System.Object, e As System.EventArgs) Handles Button433.Click
        ObjectPlacement.SelectedBlock = 304
    End Sub

    Private Sub Button434_Click(sender As System.Object, e As System.EventArgs) Handles Button434.Click
        ObjectPlacement.SelectedBlock = 303
    End Sub

    Private Sub Button435_Click(sender As System.Object, e As System.EventArgs) Handles Button435.Click
        ObjectPlacement.SelectedBlock = 265
    End Sub

    Private Sub Button436_Click(sender As System.Object, e As System.EventArgs) Handles Button436.Click
        ObjectPlacement.SelectedBlock = 264
    End Sub

    Private Sub Button437_Click(sender As System.Object, e As System.EventArgs) Handles Button437.Click
        ObjectPlacement.SelectedBlock = 266
    End Sub

    Private Sub Button438_Click(sender As System.Object, e As System.EventArgs) Handles Button438.Click
        ObjectPlacement.SelectedBlock = 488
    End Sub

    Private Sub Button439_Click(sender As System.Object, e As System.EventArgs) Handles Button439.Click
        ObjectPlacement.SelectedBlock = 489
    End Sub

    Private Sub Button440_Click(sender As System.Object, e As System.EventArgs) Handles Button440.Click
        ObjectPlacement.SelectedBlock = 616
    End Sub

    Private Sub Button441_Click(sender As System.Object, e As System.EventArgs) Handles Button441.Click
        ObjectPlacement.SelectedBlock = 617
    End Sub

    Private Sub Button442_Click(sender As System.Object, e As System.EventArgs) Handles Button442.Click
        ObjectPlacement.SelectedBlock = 619
    End Sub

    Private Sub Button443_Click(sender As System.Object, e As System.EventArgs) Handles Button443.Click
        ObjectPlacement.SelectedBlock = 618
    End Sub

    Private Sub Button444_Click(sender As System.Object, e As System.EventArgs) Handles Button444.Click
        ObjectPlacement.SelectedBlock = 246
    End Sub

    Private Sub Button445_Click(sender As System.Object, e As System.EventArgs) Handles Button445.Click
        ObjectPlacement.SelectedBlock = 250
    End Sub

    Private Sub Button446_Click(sender As System.Object, e As System.EventArgs) Handles Button446.Click
        ObjectPlacement.SelectedBlock = 247
    End Sub

    Private Sub Button447_Click(sender As System.Object, e As System.EventArgs) Handles Button447.Click
        ObjectPlacement.SelectedBlock = 256
    End Sub

    Private Sub Button448_Click(sender As System.Object, e As System.EventArgs) Handles Button448.Click
        ObjectPlacement.SelectedBlock = 255
    End Sub

    Private Sub Button449_Click(sender As System.Object, e As System.EventArgs) Handles Button449.Click
        ObjectPlacement.SelectedBlock = 316
    End Sub

    Private Sub Button450_Click(sender As System.Object, e As System.EventArgs) Handles Button450.Click
        ObjectPlacement.SelectedBlock = 315
    End Sub

    Private Sub Button451_Click(sender As System.Object, e As System.EventArgs) Handles Button451.Click
        ObjectPlacement.SelectedBlock = 365
    End Sub

    Private Sub Button452_Click(sender As System.Object, e As System.EventArgs) Handles Button452.Click
        ObjectPlacement.SelectedBlock = 366
    End Sub

    Private Sub Button453_Click(sender As System.Object, e As System.EventArgs) Handles Button453.Click
        ObjectPlacement.SelectedBlock = 252
    End Sub

    Private Sub Button454_Click(sender As System.Object, e As System.EventArgs) Handles Button454.Click
        ObjectPlacement.SelectedBlock = 251
    End Sub

    Private Sub Button455_Click(sender As System.Object, e As System.EventArgs) Handles Button455.Click
        ObjectPlacement.SelectedBlock = 253
    End Sub

    Private Sub Button456_Click(sender As System.Object, e As System.EventArgs) Handles Button456.Click
        ObjectPlacement.SelectedBlock = 257
    End Sub

    Private Sub Button457_Click(sender As System.Object, e As System.EventArgs) Handles Button457.Click
        ObjectPlacement.SelectedBlock = 258
    End Sub

    Private Sub Button458_Click(sender As System.Object, e As System.EventArgs) Handles Button458.Click
        ObjectPlacement.SelectedBlock = 317
    End Sub

    Private Sub Button459_Click(sender As System.Object, e As System.EventArgs) Handles Button459.Click
        ObjectPlacement.SelectedBlock = 318
    End Sub

    Private Sub Button460_Click(sender As System.Object, e As System.EventArgs) Handles Button460.Click
        ObjectPlacement.SelectedBlock = 368
    End Sub

    Private Sub Button461_Click(sender As System.Object, e As System.EventArgs) Handles Button461.Click
        ObjectPlacement.SelectedBlock = 367
    End Sub

    Private Sub Button462_Click(sender As System.Object, e As System.EventArgs) Handles Button462.Click
        ObjectPlacement.SelectedBlock = 248
    End Sub

    Private Sub Button463_Click(sender As System.Object, e As System.EventArgs) Handles Button463.Click
        ObjectPlacement.SelectedBlock = 254
    End Sub

    Private Sub Button464_Click(sender As System.Object, e As System.EventArgs) Handles Button464.Click
        ObjectPlacement.SelectedBlock = 249
    End Sub

    Private Sub Button465_Click(sender As System.Object, e As System.EventArgs) Handles Button465.Click
        ObjectPlacement.SelectedBlock = 262
    End Sub

    Private Sub Button466_Click(sender As System.Object, e As System.EventArgs) Handles Button466.Click
        ObjectPlacement.SelectedBlock = 321
    End Sub

    Private Sub Button467_Click(sender As System.Object, e As System.EventArgs) Handles Button467.Click
        ObjectPlacement.SelectedBlock = 319
    End Sub

    Private Sub Button468_Click(sender As System.Object, e As System.EventArgs) Handles Button468.Click
        ObjectPlacement.SelectedBlock = 322
    End Sub

    Private Sub Button469_Click(sender As System.Object, e As System.EventArgs) Handles Button469.Click
        ObjectPlacement.SelectedBlock = 320
    End Sub

    Private Sub Button470_Click(sender As System.Object, e As System.EventArgs) Handles Button470.Click
        ObjectPlacement.SelectedBlock = 116
    End Sub

    Private Sub Button471_Click(sender As System.Object, e As System.EventArgs) Handles Button471.Click
        ObjectPlacement.SelectedBlock = 119
    End Sub

    Private Sub Button472_Click(sender As System.Object, e As System.EventArgs) Handles Button472.Click
        ObjectPlacement.SelectedBlock = 117
    End Sub

    Private Sub Button473_Click(sender As System.Object, e As System.EventArgs) Handles Button473.Click
        ObjectPlacement.SelectedBlock = 120
    End Sub

    Private Sub Button474_Click(sender As System.Object, e As System.EventArgs) Handles Button474.Click
        ObjectPlacement.SelectedBlock = 118
    End Sub

    Private Sub Button475_Click(sender As System.Object, e As System.EventArgs) Handles Button475.Click
        ObjectPlacement.SelectedBlock = 113
    End Sub

    Private Sub Button476_Click(sender As System.Object, e As System.EventArgs) Handles Button476.Click
        ObjectPlacement.SelectedBlock = 137
    End Sub

    Private Sub Button477_Click(sender As System.Object, e As System.EventArgs) Handles Button477.Click
        ObjectPlacement.SelectedBlock = 138
    End Sub

    Private Sub Button478_Click(sender As System.Object, e As System.EventArgs) Handles Button478.Click
        ObjectPlacement.SelectedBlock = 139
    End Sub

    Private Sub Button479_Click(sender As System.Object, e As System.EventArgs) Handles Button479.Click
        ObjectPlacement.SelectedBlock = 141
    End Sub

    Private Sub Button480_Click(sender As System.Object, e As System.EventArgs) Handles Button480.Click
        ObjectPlacement.SelectedBlock = 140
    End Sub

    Private Sub Button481_Click(sender As System.Object, e As System.EventArgs) Handles Button481.Click
        ObjectPlacement.SelectedBlock = 148
    End Sub

    Private Sub Button482_Click(sender As System.Object, e As System.EventArgs) Handles Button482.Click
        ObjectPlacement.SelectedBlock = 154
    End Sub

    Private Sub Button483_Click(sender As System.Object, e As System.EventArgs) Handles Button483.Click
        ObjectPlacement.SelectedBlock = 114
    End Sub

    Private Sub Button484_Click(sender As System.Object, e As System.EventArgs) Handles Button484.Click
        ObjectPlacement.SelectedBlock = 142
    End Sub

    Private Sub Button485_Click(sender As System.Object, e As System.EventArgs) Handles Button485.Click
        ObjectPlacement.SelectedBlock = 143
    End Sub

    Private Sub Button486_Click(sender As System.Object, e As System.EventArgs) Handles Button486.Click
        ObjectPlacement.SelectedBlock = 144
    End Sub

    Private Sub Button487_Click(sender As System.Object, e As System.EventArgs) Handles Button487.Click
        ObjectPlacement.SelectedBlock = 146
    End Sub

    Private Sub Button488_Click(sender As System.Object, e As System.EventArgs) Handles Button488.Click
        ObjectPlacement.SelectedBlock = 145
    End Sub

    Private Sub Button489_Click(sender As System.Object, e As System.EventArgs) Handles Button489.Click
        ObjectPlacement.SelectedBlock = 149
    End Sub

    Private Sub Button490_Click(sender As System.Object, e As System.EventArgs) Handles Button490.Click
        ObjectPlacement.SelectedBlock = 155
    End Sub

    Private Sub Button491_Click(sender As System.Object, e As System.EventArgs) Handles Button491.Click
        ObjectPlacement.SelectedBlock = 152
    End Sub

    Private Sub Button492_Click(sender As System.Object, e As System.EventArgs) Handles Button492.Click
        ObjectPlacement.SelectedBlock = 158
    End Sub

    Private Sub Button493_Click(sender As System.Object, e As System.EventArgs) Handles Button493.Click
        ObjectPlacement.SelectedBlock = 151
    End Sub

    Private Sub Button494_Click(sender As System.Object, e As System.EventArgs) Handles Button494.Click
        ObjectPlacement.SelectedBlock = 157
    End Sub

    Private Sub Button495_Click(sender As System.Object, e As System.EventArgs) Handles Button495.Click
        ObjectPlacement.SelectedBlock = 147
    End Sub

    Private Sub Button496_Click(sender As System.Object, e As System.EventArgs) Handles Button496.Click
        ObjectPlacement.SelectedBlock = 153
    End Sub

    Private Sub Button497_Click(sender As System.Object, e As System.EventArgs) Handles Button497.Click
        ObjectPlacement.SelectedBlock = 150
    End Sub

    Private Sub Button498_Click(sender As System.Object, e As System.EventArgs) Handles Button498.Click
        ObjectPlacement.SelectedBlock = 156
    End Sub

    Private Sub Button499_Click(sender As System.Object, e As System.EventArgs) Handles Button499.Click
        ObjectPlacement.SelectedBlock = 121
    End Sub

    Private Sub Button500_Click(sender As System.Object, e As System.EventArgs) Handles Button500.Click
        ObjectPlacement.SelectedBlock = 122
    End Sub

    Private Sub Button501_Click(sender As System.Object, e As System.EventArgs) Handles Button501.Click
        ObjectPlacement.SelectedBlock = 123
    End Sub

    Private Sub Button502_Click(sender As System.Object, e As System.EventArgs) Handles Button502.Click
        ObjectPlacement.SelectedBlock = 125
    End Sub

    Private Sub Button503_Click(sender As System.Object, e As System.EventArgs) Handles Button503.Click
        ObjectPlacement.SelectedBlock = 124
    End Sub

    Private Sub Button504_Click(sender As System.Object, e As System.EventArgs) Handles Button504.Click
        ObjectPlacement.SelectedBlock = 435
    End Sub

    Private Sub Button505_Click(sender As System.Object, e As System.EventArgs) Handles Button505.Click
        ObjectPlacement.SelectedBlock = 414
    End Sub

    Private Sub Button506_Click(sender As System.Object, e As System.EventArgs) Handles Button506.Click
        ObjectPlacement.SelectedBlock = 434
    End Sub

    Private Sub Button507_Click(sender As System.Object, e As System.EventArgs) Handles Button507.Click
        ObjectPlacement.SelectedBlock = 425
    End Sub

    Private Sub Button508_Click(sender As System.Object, e As System.EventArgs) Handles Button508.Click
        ObjectPlacement.SelectedBlock = 424
    End Sub

    Private Sub Button509_Click(sender As System.Object, e As System.EventArgs) Handles Button509.Click
        ObjectPlacement.SelectedBlock = 426
    End Sub

    Private Sub Button510_Click(sender As System.Object, e As System.EventArgs) Handles Button510.Click
        ObjectPlacement.SelectedBlock = 418
    End Sub

    Private Sub Button511_Click(sender As System.Object, e As System.EventArgs) Handles Button511.Click
        ObjectPlacement.SelectedBlock = 417
    End Sub

    Private Sub Button512_Click(sender As System.Object, e As System.EventArgs) Handles Button512.Click
        ObjectPlacement.SelectedBlock = 452
    End Sub

    Private Sub Button513_Click(sender As System.Object, e As System.EventArgs) Handles Button513.Click
        ObjectPlacement.SelectedBlock = 451
    End Sub

    Private Sub Button514_Click(sender As System.Object, e As System.EventArgs) Handles Button514.Click
        ObjectPlacement.SelectedBlock = 412
    End Sub

    Private Sub Button515_Click(sender As System.Object, e As System.EventArgs) Handles Button515.Click
        ObjectPlacement.SelectedBlock = 413
    End Sub

    Private Sub Button516_Click(sender As System.Object, e As System.EventArgs) Handles Button516.Click
        ObjectPlacement.SelectedBlock = 411
    End Sub

    Private Sub Button517_Click(sender As System.Object, e As System.EventArgs) Handles Button517.Click
        ObjectPlacement.SelectedBlock = 423
    End Sub

    Private Sub Button518_Click(sender As System.Object, e As System.EventArgs) Handles Button518.Click
        ObjectPlacement.SelectedBlock = 422
    End Sub

    Private Sub Button519_Click(sender As System.Object, e As System.EventArgs) Handles Button519.Click
        ObjectPlacement.SelectedBlock = 421
    End Sub

    Private Sub Button520_Click(sender As System.Object, e As System.EventArgs) Handles Button520.Click
        ObjectPlacement.SelectedBlock = 416
    End Sub

    Private Sub Button521_Click(sender As System.Object, e As System.EventArgs) Handles Button521.Click
        ObjectPlacement.SelectedBlock = 415
    End Sub

    Private Sub Button522_Click(sender As System.Object, e As System.EventArgs) Handles Button522.Click
        ObjectPlacement.SelectedBlock = 450
    End Sub

    Private Sub Button523_Click(sender As System.Object, e As System.EventArgs) Handles Button523.Click
        ObjectPlacement.SelectedBlock = 449
    End Sub

    Private Sub Button524_Click(sender As System.Object, e As System.EventArgs) Handles Button524.Click
        ObjectPlacement.SelectedBlock = 433
    End Sub

    Private Sub Button525_Click(sender As System.Object, e As System.EventArgs) Handles Button525.Click
        ObjectPlacement.SelectedBlock = 410
    End Sub

    Private Sub Button526_Click(sender As System.Object, e As System.EventArgs) Handles Button526.Click
        ObjectPlacement.SelectedBlock = 432
    End Sub

    Private Sub Button527_Click(sender As System.Object, e As System.EventArgs) Handles Button527.Click
        ObjectPlacement.SelectedBlock = 427
    End Sub

    Private Sub Button528_Click(sender As System.Object, e As System.EventArgs) Handles Button528.Click
        ObjectPlacement.SelectedBlock = 419
    End Sub

    Private Sub Button529_Click(sender As System.Object, e As System.EventArgs) Handles Button529.Click
        ObjectPlacement.SelectedBlock = 436
    End Sub

    Private Sub Button530_Click(sender As System.Object, e As System.EventArgs) Handles Button530.Click
        ObjectPlacement.SelectedBlock = 455
    End Sub

    Private Sub Button531_Click(sender As System.Object, e As System.EventArgs) Handles Button531.Click
        ObjectPlacement.SelectedBlock = 456
    End Sub

    Private Sub Button532_Click(sender As System.Object, e As System.EventArgs) Handles Button532.Click
        ObjectPlacement.SelectedBlock = 453
    End Sub

    Private Sub Button533_Click(sender As System.Object, e As System.EventArgs) Handles Button533.Click
        ObjectPlacement.SelectedBlock = 454
    End Sub

    Private Sub Button534_Click(sender As System.Object, e As System.EventArgs) Handles Button534.Click
        ObjectPlacement.SelectedBlock = 466
    End Sub

    Private Sub Button535_Click(sender As System.Object, e As System.EventArgs) Handles Button535.Click
        ObjectPlacement.SelectedBlock = 459
    End Sub

    Private Sub Button536_Click(sender As System.Object, e As System.EventArgs) Handles Button536.Click
        ObjectPlacement.SelectedBlock = 460
    End Sub

    Private Sub Button537_Click(sender As System.Object, e As System.EventArgs) Handles Button537.Click
        ObjectPlacement.SelectedBlock = 471
    End Sub

    Private Sub Button538_Click(sender As System.Object, e As System.EventArgs) Handles Button538.Click
        ObjectPlacement.SelectedBlock = 468
    End Sub

    Private Sub Button539_Click(sender As System.Object, e As System.EventArgs) Handles Button539.Click
        ObjectPlacement.SelectedBlock = 472
    End Sub

    Private Sub Button540_Click(sender As System.Object, e As System.EventArgs) Handles Button540.Click
        ObjectPlacement.SelectedBlock = 474
    End Sub

    Private Sub Button541_Click(sender As System.Object, e As System.EventArgs) Handles Button541.Click
        ObjectPlacement.SelectedBlock = 480
    End Sub

    Private Sub Button542_Click(sender As System.Object, e As System.EventArgs) Handles Button542.Click
        ObjectPlacement.SelectedBlock = 482
    End Sub

    Private Sub Button543_Click(sender As System.Object, e As System.EventArgs) Handles Button543.Click
        ObjectPlacement.SelectedBlock = 484
    End Sub

    Private Sub Button544_Click(sender As System.Object, e As System.EventArgs) Handles Button544.Click
        ObjectPlacement.SelectedBlock = 487
    End Sub

    Private Sub Button545_Click(sender As System.Object, e As System.EventArgs) Handles Button545.Click
        ObjectPlacement.SelectedBlock = 463
    End Sub

    Private Sub Button546_Click(sender As System.Object, e As System.EventArgs) Handles Button546.Click
        ObjectPlacement.SelectedBlock = 467
    End Sub

    Private Sub Button547_Click(sender As System.Object, e As System.EventArgs) Handles Button547.Click
        ObjectPlacement.SelectedBlock = 461
    End Sub

    Private Sub Button548_Click(sender As System.Object, e As System.EventArgs) Handles Button548.Click
        ObjectPlacement.SelectedBlock = 470
    End Sub

    Private Sub Button549_Click(sender As System.Object, e As System.EventArgs) Handles Button549.Click
        ObjectPlacement.SelectedBlock = 469
    End Sub

    Private Sub Button550_Click(sender As System.Object, e As System.EventArgs) Handles Button550.Click
        ObjectPlacement.SelectedBlock = 476
    End Sub

    Private Sub Button551_Click(sender As System.Object, e As System.EventArgs) Handles Button551.Click
        ObjectPlacement.SelectedBlock = 479
    End Sub

    Private Sub Button552_Click(sender As System.Object, e As System.EventArgs) Handles Button552.Click
        ObjectPlacement.SelectedBlock = 486
    End Sub

    Private Sub Button553_Click(sender As System.Object, e As System.EventArgs) Handles Button553.Click
        ObjectPlacement.SelectedBlock = 485
    End Sub

    Private Sub Button554_Click(sender As System.Object, e As System.EventArgs) Handles Button554.Click
        ObjectPlacement.SelectedBlock = 483
    End Sub

    Private Sub Button555_Click(sender As System.Object, e As System.EventArgs) Handles Button555.Click
        ObjectPlacement.SelectedBlock = 481
    End Sub

    Private Sub Button556_Click(sender As System.Object, e As System.EventArgs) Handles Button556.Click
        ObjectPlacement.SelectedBlock = 465
    End Sub

    Private Sub Button557_Click(sender As System.Object, e As System.EventArgs) Handles Button557.Click
        ObjectPlacement.SelectedBlock = 462
    End Sub

    Private Sub Button558_Click(sender As System.Object, e As System.EventArgs) Handles Button558.Click
        ObjectPlacement.SelectedBlock = 464
    End Sub

    Private Sub Button559_Click(sender As System.Object, e As System.EventArgs) Handles Button559.Click
        ObjectPlacement.SelectedBlock = 473
    End Sub

    Private Sub Button560_Click(sender As System.Object, e As System.EventArgs) Handles Button560.Click
        ObjectPlacement.SelectedBlock = 475
    End Sub

    Private Sub Button561_Click(sender As System.Object, e As System.EventArgs) Handles Button561.Click
        ObjectPlacement.SelectedBlock = 477
    End Sub

    Private Sub Button562_Click(sender As System.Object, e As System.EventArgs) Handles Button562.Click
        ObjectPlacement.SelectedBlock = 478
    End Sub

    Private Sub Button563_Click(sender As System.Object, e As System.EventArgs) Handles Button563.Click
        ObjectPlacement.SelectedBlock = 404
    End Sub

    Private Sub Button564_Click(sender As System.Object, e As System.EventArgs) Handles Button564.Click
        ObjectPlacement.SelectedBlock = 420
    End Sub

    Private Sub Button565_Click(sender As System.Object, e As System.EventArgs) Handles Button565.Click
        ObjectPlacement.SelectedBlock = 170
    End Sub

    Private Sub Button566_Click(sender As System.Object, e As System.EventArgs) Handles Button566.Click
        ObjectPlacement.SelectedBlock = 173
    End Sub

    Private Sub Button567_Click(sender As System.Object, e As System.EventArgs) Handles Button567.Click
        ObjectPlacement.SelectedBlock = 176
    End Sub

    Private Sub Button568_Click(sender As System.Object, e As System.EventArgs) Handles Button568.Click
        ObjectPlacement.SelectedBlock = 179
    End Sub

    Private Sub Button569_Click(sender As System.Object, e As System.EventArgs) Handles Button569.Click
        ObjectPlacement.SelectedBlock = 171
    End Sub

    Private Sub Button570_Click(sender As System.Object, e As System.EventArgs) Handles Button570.Click
        ObjectPlacement.SelectedBlock = 174
    End Sub

    Private Sub Button571_Click(sender As System.Object, e As System.EventArgs) Handles Button571.Click
        ObjectPlacement.SelectedBlock = 177
    End Sub

    Private Sub Button572_Click(sender As System.Object, e As System.EventArgs) Handles Button572.Click
        ObjectPlacement.SelectedBlock = 180
    End Sub

    Private Sub Button573_Click(sender As System.Object, e As System.EventArgs) Handles Button573.Click
        ObjectPlacement.SelectedBlock = 172
    End Sub

    Private Sub Button574_Click(sender As System.Object, e As System.EventArgs) Handles Button574.Click
        ObjectPlacement.SelectedBlock = 175
    End Sub

    Private Sub Button575_Click(sender As System.Object, e As System.EventArgs) Handles Button575.Click
        ObjectPlacement.SelectedBlock = 178
    End Sub

    Private Sub Button576_Click(sender As System.Object, e As System.EventArgs) Handles Button576.Click
        ObjectPlacement.SelectedBlock = 181
    End Sub

    Private Sub Button577_Click(sender As System.Object, e As System.EventArgs) Handles Button577.Click
        ObjectPlacement.SelectedBlock = 227
    End Sub

    Private Sub Button578_Click(sender As System.Object, e As System.EventArgs) Handles Button578.Click
        ObjectPlacement.SelectedBlock = 228
    End Sub

    Private Sub Button579_Click(sender As System.Object, e As System.EventArgs) Handles Button579.Click
        ObjectPlacement.SelectedBlock = 229
    End Sub

    Private Sub Button580_Click(sender As System.Object, e As System.EventArgs) Handles Button580.Click
        ObjectPlacement.SelectedBlock = 236
    End Sub

    Private Sub Button581_Click(sender As System.Object, e As System.EventArgs) Handles Button581.Click
        ObjectPlacement.SelectedBlock = 237
    End Sub

    Private Sub Button582_Click(sender As System.Object, e As System.EventArgs) Handles Button582.Click
        ObjectPlacement.SelectedBlock = 230
    End Sub

    Private Sub Button583_Click(sender As System.Object, e As System.EventArgs) Handles Button583.Click
        ObjectPlacement.SelectedBlock = 231
    End Sub

    Private Sub Button584_Click(sender As System.Object, e As System.EventArgs) Handles Button584.Click
        ObjectPlacement.SelectedBlock = 232
    End Sub

    Private Sub Button585_Click(sender As System.Object, e As System.EventArgs) Handles Button585.Click
        ObjectPlacement.SelectedBlock = 239
    End Sub

    Private Sub Button586_Click(sender As System.Object, e As System.EventArgs) Handles Button586.Click
        ObjectPlacement.SelectedBlock = 238
    End Sub

    Private Sub Button587_Click(sender As System.Object, e As System.EventArgs) Handles Button587.Click
        ObjectPlacement.SelectedBlock = 233
    End Sub

    Private Sub Button588_Click(sender As System.Object, e As System.EventArgs) Handles Button588.Click
        ObjectPlacement.SelectedBlock = 234
    End Sub

    Private Sub Button589_Click(sender As System.Object, e As System.EventArgs) Handles Button589.Click
        ObjectPlacement.SelectedBlock = 235
    End Sub

    Private Sub Button590_Click(sender As System.Object, e As System.EventArgs) Handles Button590.Click
        ObjectPlacement.SelectedBlock = 79
    End Sub

    Private Sub Button591_Click(sender As System.Object, e As System.EventArgs) Handles Button591.Click
        ObjectPlacement.SelectedBlock = 244
    End Sub

    Private Sub Button592_Click(sender As System.Object, e As System.EventArgs) Handles Button592.Click
        ObjectPlacement.SelectedBlock = 439
    End Sub

    Private Sub Button593_Click(sender As System.Object, e As System.EventArgs) Handles Button593.Click
        ObjectPlacement.SelectedBlock = 440
    End Sub

    Private Sub Button594_Click(sender As System.Object, e As System.EventArgs) Handles Button594.Click
        ObjectPlacement.SelectedBlock = 445
    End Sub

    Private Sub Button595_Click(sender As System.Object, e As System.EventArgs) Handles Button595.Click
        ObjectPlacement.SelectedBlock = 161
    End Sub

    Private Sub Button596_Click(sender As System.Object, e As System.EventArgs) Handles Button596.Click
        ObjectPlacement.SelectedBlock = 261
    End Sub

    Private Sub Button597_Click(sender As System.Object, e As System.EventArgs) Handles Button597.Click
        ObjectPlacement.SelectedBlock = 437
    End Sub

    Private Sub Button598_Click(sender As System.Object, e As System.EventArgs) Handles Button598.Click
        ObjectPlacement.SelectedBlock = 441
    End Sub

    Private Sub Button599_Click(sender As System.Object, e As System.EventArgs) Handles Button599.Click
        ObjectPlacement.SelectedBlock = 444
    End Sub

    Private Sub Button600_Click(sender As System.Object, e As System.EventArgs) Handles Button600.Click
        ObjectPlacement.SelectedBlock = 245
    End Sub

    Private Sub Button601_Click(sender As System.Object, e As System.EventArgs) Handles Button601.Click
        ObjectPlacement.SelectedBlock = 259
    End Sub

    Private Sub Button602_Click(sender As System.Object, e As System.EventArgs) Handles Button602.Click
        ObjectPlacement.SelectedBlock = 438
    End Sub

    Private Sub Button603_Click(sender As System.Object, e As System.EventArgs) Handles Button603.Click
        ObjectPlacement.SelectedBlock = 442
    End Sub

    Private Sub Button604_Click(sender As System.Object, e As System.EventArgs) Handles Button604.Click
        ObjectPlacement.SelectedBlock = 443
    End Sub

    Private Sub Button605_Click(sender As System.Object, e As System.EventArgs) Handles Button605.Click
        ObjectPlacement.SelectedBlock = 133
    End Sub

    Private Sub Button606_Click(sender As System.Object, e As System.EventArgs) Handles Button606.Click
        ObjectPlacement.SelectedBlock = 134
    End Sub

    Private Sub Button607_Click(sender As System.Object, e As System.EventArgs) Handles Button607.Click
        ObjectPlacement.SelectedBlock = 135
    End Sub

    Private Sub Button608_Click(sender As System.Object, e As System.EventArgs) Handles Button608.Click
        ObjectPlacement.SelectedBlock = 115
    End Sub

    Private Sub Button609_Click(sender As System.Object, e As System.EventArgs) Handles Button609.Click
        ObjectPlacement.SelectedBlock = 447
    End Sub

    Private Sub Button610_Click(sender As System.Object, e As System.EventArgs) Handles Button610.Click
        ObjectPlacement.SelectedBlock = 446
    End Sub

    Private Sub Button611_Click(sender As System.Object, e As System.EventArgs) Handles Button611.Click
        ObjectPlacement.SelectedBlock = 448
    End Sub

    Private Sub Button612_Click(sender As System.Object, e As System.EventArgs) Handles Button612.Click
        ObjectPlacement.SelectedBlock = 88
    End Sub

    Private Sub Button613_Click(sender As System.Object, e As System.EventArgs) Handles Button613.Click
        ObjectPlacement.SelectedBlock = 89
    End Sub

    Private Sub Button614_Click(sender As System.Object, e As System.EventArgs) Handles Button614.Click
        ObjectPlacement.SelectedBlock = 90
    End Sub

    Private Sub Button615_Click(sender As System.Object, e As System.EventArgs) Handles Button615.Click
        ObjectPlacement.SelectedBlock = 169
    End Sub

    Private Sub Button616_Click(sender As System.Object, e As System.EventArgs) Handles Button616.Click
        ObjectPlacement.SelectedBlock = 281
    End Sub

    Private Sub Button617_Click(sender As System.Object, e As System.EventArgs) Handles Button617.Click
        ObjectPlacement.SelectedBlock = 282
    End Sub

    Private Sub Button618_Click(sender As System.Object, e As System.EventArgs) Handles Button618.Click
        ObjectPlacement.SelectedBlock = 283
    End Sub

    Private Sub Button619_Click(sender As System.Object, e As System.EventArgs) Handles Button619.Click
        ObjectPlacement.SelectedBlock = 615
    End Sub

    Private Sub Button620_Click(sender As System.Object, e As System.EventArgs) Handles Button620.Click
        ObjectPlacement.SelectedBlock = 408
    End Sub

    Private Sub Button621_Click(sender As System.Object, e As System.EventArgs) Handles Button621.Click
        ObjectPlacement.SelectedBlock = 430
    End Sub

    Private Sub Button622_Click(sender As System.Object, e As System.EventArgs) Handles Button622.Click
        ObjectPlacement.SelectedBlock = 409
    End Sub

    Private Sub Button623_Click(sender As System.Object, e As System.EventArgs) Handles Button623.Click
        ObjectPlacement.SelectedBlock = 429
    End Sub

    Private Sub Button624_Click(sender As System.Object, e As System.EventArgs) Handles Button624.Click
        ObjectPlacement.SelectedBlock = 428
    End Sub

    Private Sub Button625_Click(sender As System.Object, e As System.EventArgs) Handles Button625.Click
        ObjectPlacement.SelectedBlock = 407
    End Sub

    Private Sub Button626_Click(sender As System.Object, e As System.EventArgs) Handles Button626.Click
        ObjectPlacement.SelectedBlock = 431
    End Sub

    Private Sub Button631_Click(sender As System.Object, e As System.EventArgs) Handles Button631.Click
        ObjectPlacement.SelectedBlock = 291
    End Sub

    Private Sub Button632_Click(sender As System.Object, e As System.EventArgs) Handles Button632.Click
        ObjectPlacement.SelectedBlock = 292
    End Sub

    Private Sub Button633_Click(sender As System.Object, e As System.EventArgs) Handles Button633.Click
        ObjectPlacement.SelectedBlock = 522
    End Sub

    Private Sub Button634_Click(sender As System.Object, e As System.EventArgs) Handles Button634.Click
        ObjectPlacement.SelectedBlock = 528
    End Sub

    Private Sub Button635_Click(sender As System.Object, e As System.EventArgs) Handles Button635.Click
        ObjectPlacement.SelectedBlock = 523
    End Sub

    Private Sub Button636_Click(sender As System.Object, e As System.EventArgs) Handles Button636.Click
        ObjectPlacement.SelectedBlock = 530
    End Sub

    Private Sub Button637_Click(sender As System.Object, e As System.EventArgs) Handles Button637.Click
        ObjectPlacement.SelectedBlock = 516
    End Sub

    Private Sub Button638_Click(sender As System.Object, e As System.EventArgs) Handles Button638.Click
        ObjectPlacement.SelectedBlock = 517
    End Sub

    Private Sub Button639_Click(sender As System.Object, e As System.EventArgs) Handles Button639.Click
        ObjectPlacement.SelectedBlock = 514
    End Sub

    Private Sub Button640_Click(sender As System.Object, e As System.EventArgs) Handles Button640.Click
        ObjectPlacement.SelectedBlock = 518
    End Sub

    Private Sub Button641_Click(sender As System.Object, e As System.EventArgs) Handles Button641.Click
        ObjectPlacement.SelectedBlock = 542
    End Sub

    Private Sub Button642_Click(sender As System.Object, e As System.EventArgs) Handles Button642.Click
        ObjectPlacement.SelectedBlock = 541
    End Sub

    Private Sub Button643_Click(sender As System.Object, e As System.EventArgs) Handles Button643.Click
        ObjectPlacement.SelectedBlock = 540
    End Sub

    Private Sub Button644_Click(sender As System.Object, e As System.EventArgs) Handles Button644.Click
        ObjectPlacement.SelectedBlock = 520
    End Sub

    Private Sub Button645_Click(sender As System.Object, e As System.EventArgs) Handles Button645.Click
        ObjectPlacement.SelectedBlock = 526
    End Sub

    Private Sub Button646_Click(sender As System.Object, e As System.EventArgs) Handles Button646.Click
        ObjectPlacement.SelectedBlock = 525
    End Sub

    Private Sub Button647_Click(sender As System.Object, e As System.EventArgs) Handles Button647.Click
        ObjectPlacement.SelectedBlock = 527
    End Sub

    Private Sub Button648_Click(sender As System.Object, e As System.EventArgs) Handles Button648.Click
        ObjectPlacement.SelectedBlock = 532
    End Sub

    Private Sub Button649_Click(sender As System.Object, e As System.EventArgs) Handles Button649.Click
        ObjectPlacement.SelectedBlock = 515
    End Sub

    Private Sub Button650_Click(sender As System.Object, e As System.EventArgs) Handles Button650.Click
        ObjectPlacement.SelectedBlock = 513
    End Sub

    Private Sub Button651_Click(sender As System.Object, e As System.EventArgs) Handles Button651.Click
        ObjectPlacement.SelectedBlock = 533
    End Sub

    Private Sub Button652_Click(sender As System.Object, e As System.EventArgs) Handles Button652.Click
        ObjectPlacement.SelectedBlock = 539
    End Sub

    Private Sub Button653_Click(sender As System.Object, e As System.EventArgs) Handles Button653.Click
        ObjectPlacement.SelectedBlock = 534
    End Sub

    Private Sub Button654_Click(sender As System.Object, e As System.EventArgs) Handles Button654.Click
        ObjectPlacement.SelectedBlock = 535
    End Sub

    Private Sub Button655_Click(sender As System.Object, e As System.EventArgs) Handles Button655.Click
        ObjectPlacement.SelectedBlock = 519
    End Sub

    Private Sub Button656_Click(sender As System.Object, e As System.EventArgs) Handles Button656.Click
        ObjectPlacement.SelectedBlock = 524
    End Sub

    Private Sub Button657_Click(sender As System.Object, e As System.EventArgs) Handles Button657.Click
        ObjectPlacement.SelectedBlock = 521
    End Sub

    Private Sub Button658_Click(sender As System.Object, e As System.EventArgs) Handles Button658.Click
        ObjectPlacement.SelectedBlock = 529
    End Sub

    Private Sub Button659_Click(sender As System.Object, e As System.EventArgs) Handles Button659.Click
        ObjectPlacement.SelectedBlock = 531
    End Sub

    Private Sub Button660_Click(sender As System.Object, e As System.EventArgs) Handles Button660.Click
        ObjectPlacement.SelectedBlock = 538
    End Sub

    Private Sub Button661_Click(sender As System.Object, e As System.EventArgs) Handles Button661.Click
        ObjectPlacement.SelectedBlock = 544
    End Sub

    Private Sub Button662_Click(sender As System.Object, e As System.EventArgs) Handles Button662.Click
        ObjectPlacement.SelectedBlock = 543
    End Sub

    Private Sub Button663_Click(sender As System.Object, e As System.EventArgs) Handles Button663.Click
        ObjectPlacement.SelectedBlock = 512
    End Sub

    Private Sub Button664_Click(sender As System.Object, e As System.EventArgs) Handles Button664.Click
        ObjectPlacement.SelectedBlock = 536
    End Sub

    Private Sub Button665_Click(sender As System.Object, e As System.EventArgs) Handles Button665.Click
        ObjectPlacement.SelectedBlock = 537
    End Sub

    Private Sub Button666_Click(sender As System.Object, e As System.EventArgs) Handles Button666.Click
        ObjectPlacement.SelectedBlock = 550
    End Sub

    Private Sub Button667_Click(sender As System.Object, e As System.EventArgs) Handles Button667.Click
        ObjectPlacement.SelectedBlock = 556
    End Sub

    Private Sub Button668_Click(sender As System.Object, e As System.EventArgs) Handles Button668.Click
        ObjectPlacement.SelectedBlock = 561
    End Sub

    Private Sub Button669_Click(sender As System.Object, e As System.EventArgs) Handles Button669.Click
        ObjectPlacement.SelectedBlock = 566
    End Sub

    Private Sub Button670_Click(sender As System.Object, e As System.EventArgs) Handles Button670.Click
        ObjectPlacement.SelectedBlock = 564
    End Sub

    Private Sub Button671_Click(sender As System.Object, e As System.EventArgs) Handles Button671.Click
        ObjectPlacement.SelectedBlock = 562
    End Sub

    Private Sub Button672_Click(sender As System.Object, e As System.EventArgs) Handles Button672.Click
        ObjectPlacement.SelectedBlock = 547
    End Sub

    Private Sub Button673_Click(sender As System.Object, e As System.EventArgs) Handles Button673.Click
        ObjectPlacement.SelectedBlock = 548
    End Sub

    Private Sub Button674_Click(sender As System.Object, e As System.EventArgs) Handles Button674.Click
        ObjectPlacement.SelectedBlock = 565
    End Sub

    Private Sub Button675_Click(sender As System.Object, e As System.EventArgs) Handles Button675.Click
        ObjectPlacement.SelectedBlock = 567
    End Sub

    Private Sub Button676_Click(sender As System.Object, e As System.EventArgs) Handles Button676.Click
        ObjectPlacement.SelectedBlock = 551
    End Sub

    Private Sub Button677_Click(sender As System.Object, e As System.EventArgs) Handles Button677.Click
        ObjectPlacement.SelectedBlock = 558
    End Sub

    Private Sub Button678_Click(sender As System.Object, e As System.EventArgs) Handles Button678.Click
        ObjectPlacement.SelectedBlock = 555
    End Sub

    Private Sub Button679_Click(sender As System.Object, e As System.EventArgs) Handles Button679.Click
        ObjectPlacement.SelectedBlock = 545
    End Sub

    Private Sub Button680_Click(sender As System.Object, e As System.EventArgs) Handles Button680.Click
        ObjectPlacement.SelectedBlock = 546
    End Sub

    Private Sub Button681_Click(sender As System.Object, e As System.EventArgs) Handles Button681.Click
        ObjectPlacement.SelectedBlock = 549
    End Sub

    Private Sub Button682_Click(sender As System.Object, e As System.EventArgs) Handles Button682.Click
        ObjectPlacement.SelectedBlock = 553
    End Sub

    Private Sub Button683_Click(sender As System.Object, e As System.EventArgs) Handles Button683.Click
        ObjectPlacement.SelectedBlock = 554
    End Sub

    Private Sub Button684_Click(sender As System.Object, e As System.EventArgs) Handles Button684.Click
        ObjectPlacement.SelectedBlock = 563
    End Sub

    Private Sub Button685_Click(sender As System.Object, e As System.EventArgs) Handles Button685.Click
        ObjectPlacement.SelectedBlock = 557
    End Sub

    Private Sub Button686_Click(sender As System.Object, e As System.EventArgs) Handles Button686.Click
        ObjectPlacement.SelectedBlock = 552
    End Sub

    Private Sub Button687_Click(sender As System.Object, e As System.EventArgs) Handles Button687.Click
        ObjectPlacement.SelectedBlock = 559
    End Sub

    Private Sub Button688_Click(sender As System.Object, e As System.EventArgs) Handles Button688.Click
        ObjectPlacement.SelectedBlock = 560
    End Sub

    Private Sub Button689_Click(sender As System.Object, e As System.EventArgs) Handles Button689.Click
        ObjectPlacement.SelectedBlock = 622
    End Sub

    Private Sub Button690_Click(sender As System.Object, e As System.EventArgs) Handles Button690.Click
        ObjectPlacement.SelectedBlock = 623
    End Sub

    Private Sub Button691_Click(sender As System.Object, e As System.EventArgs) Handles Button691.Click
        ObjectPlacement.SelectedBlock = 624
    End Sub

    Private Sub Button692_Click(sender As System.Object, e As System.EventArgs) Handles Button692.Click
        ObjectPlacement.SelectedBlock = 625
    End Sub

    Private Sub Button693_Click(sender As System.Object, e As System.EventArgs) Handles Button693.Click
        ObjectPlacement.SelectedBlock = 631
    End Sub

    Private Sub Button694_Click(sender As System.Object, e As System.EventArgs) Handles Button694.Click
        ObjectPlacement.SelectedBlock = 626
    End Sub

    Private Sub Button695_Click(sender As System.Object, e As System.EventArgs) Handles Button695.Click
        ObjectPlacement.SelectedBlock = 627
    End Sub

    Private Sub Button696_Click(sender As System.Object, e As System.EventArgs) Handles Button696.Click
        ObjectPlacement.SelectedBlock = 628
    End Sub

    Private Sub Button697_Click(sender As System.Object, e As System.EventArgs) Handles Button697.Click
        ObjectPlacement.SelectedBlock = 629
    End Sub

    Private Sub Button698_Click(sender As System.Object, e As System.EventArgs) Handles Button698.Click
        ObjectPlacement.SelectedBlock = 632
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Wood)
    End Sub

    <Flags()> Enum GameVisibility
        None = 0
        SuperMarioBros = 1
        SuperMarioBros2 = 2
        SuperMarioBros3 = 4
        SuperMarioWorld = 8
        Misc = 16
    End Enum

    <Flags()> Enum SMB3TilesetVisibility
        None = 0
        Wood = 1
        Grass = 2
        Cave = 4
        Desert = 8
        Bonus = 16
        House = 32
        Water = 64
        Snow = 128
        Airship = 256
        Dungeon = 512
        Hurts = 1024
        Pipes = 2048
        Sizable = 4096
        Misc = 8192
        Special = 16384
    End Enum

    Private Sub ToggleGameVisibility(visibility As GameVisibility)
        smb_tileset.Visible = visibility.HasFlag(GameVisibility.SuperMarioBros)
        smb2_tileset.Visible = visibility.HasFlag(GameVisibility.SuperMarioBros2)
        smb3_tileset.Visible = visibility.HasFlag(GameVisibility.SuperMarioBros3)
        smw_tileset.Visible = visibility.HasFlag(GameVisibility.SuperMarioWorld)
        misc_tileset.Visible = visibility.HasFlag(GameVisibility.Misc)
    End Sub

    Private Sub ToggleSMB3TilesetVisibility(visibility As SMB3TilesetVisibility)
        smb3_wood.Visible = visibility.HasFlag(SMB3TilesetVisibility.Wood)
        smb3_grass.Visible = visibility.HasFlag(SMB3TilesetVisibility.Grass)
        smb3_cave.Visible = visibility.HasFlag(SMB3TilesetVisibility.Cave)
        smb3_desert.Visible = visibility.HasFlag(SMB3TilesetVisibility.Desert)
        smb3_bonus.Visible = visibility.HasFlag(SMB3TilesetVisibility.Bonus)
        smb3_house.Visible = visibility.HasFlag(SMB3TilesetVisibility.House)
        smb3_water.Visible = visibility.HasFlag(SMB3TilesetVisibility.Water)
        smb3_snow.Visible = visibility.HasFlag(SMB3TilesetVisibility.Snow)
        smb3_airship.Visible = visibility.HasFlag(SMB3TilesetVisibility.Airship)
        smb3_dungeon.Visible = visibility.HasFlag(SMB3TilesetVisibility.Dungeon)
        smb3_hurts.Visible = visibility.HasFlag(SMB3TilesetVisibility.Hurts)
        smb3_pipes.Visible = visibility.HasFlag(SMB3TilesetVisibility.Pipes)
        smb3_sizable.Visible = visibility.HasFlag(SMB3TilesetVisibility.Sizable)
        smb3_misc.Visible = visibility.HasFlag(SMB3TilesetVisibility.Misc)
        smb3_special.Visible = visibility.HasFlag(SMB3TilesetVisibility.Special)
    End Sub

    Private Sub Button15_Click(sender As System.Object, e As System.EventArgs) Handles Button15.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Grass)
    End Sub

    Private Sub Button16_Click(sender As System.Object, e As System.EventArgs) Handles Button16.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Cave)
    End Sub

    Private Sub Button17_Click(sender As System.Object, e As System.EventArgs) Handles Button17.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Desert)
    End Sub

    Private Sub Button18_Click(sender As System.Object, e As System.EventArgs) Handles Button18.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Bonus)
    End Sub

    Private Sub Button19_Click(sender As System.Object, e As System.EventArgs) Handles Button19.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.House)
    End Sub

    Private Sub Button20_Click(sender As System.Object, e As System.EventArgs) Handles Button20.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Dungeon)
    End Sub

    Private Sub Button21_Click(sender As System.Object, e As System.EventArgs) Handles Button21.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Water)
    End Sub

    Private Sub Button22_Click(sender As System.Object, e As System.EventArgs) Handles Button22.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Snow)
    End Sub

    Private Sub Button23_Click(sender As System.Object, e As System.EventArgs) Handles Button23.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Airship)
    End Sub

    Private Sub Button24_Click(sender As System.Object, e As System.EventArgs) Handles Button24.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Hurts)
    End Sub

    Private Sub Button25_Click(sender As System.Object, e As System.EventArgs) Handles Button25.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Pipes)
    End Sub

    Private Sub Button26_Click(sender As System.Object, e As System.EventArgs) Handles Button26.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Sizable)
    End Sub

    Private Sub Button27_Click(sender As System.Object, e As System.EventArgs) Handles Button27.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Misc)
    End Sub

    Private Sub Button28_Click(sender As System.Object, e As System.EventArgs) Handles Button28.Click
        ToggleSMB3TilesetVisibility(SMB3TilesetVisibility.Special)
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        LoadSMB2GFX()
        ToggleGameVisibility(GameVisibility.SuperMarioBros2)
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        LoadSMB3GFX()
        ToggleGameVisibility(GameVisibility.SuperMarioBros3)
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        LoadSMBGFX()
        ToggleGameVisibility(GameVisibility.SuperMarioBros)
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        LoadSMWGFX()
        ToggleGameVisibility(GameVisibility.SuperMarioWorld)
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        LoadMiscGFX()
        ToggleGameVisibility(GameVisibility.Misc)
    End Sub

    Public Sub LoadSMB2GFX()
        'smb2 overworld
        Dim fs As New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-39.png", System.IO.FileMode.Open)
        Dim graphic As Image
        graphic = Image.FromStream(fs)
        Button252.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-40.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button253.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-41.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button254.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-45.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button255.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-340.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button256.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-342.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button257.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-341.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button258.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-343.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button259.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-198.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button260.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-200.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button261.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-199.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button262.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-46.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button263.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-336.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button264.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-338.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button265.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-337.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button266.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-339.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button267.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-42.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button268.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-43.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button269.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-44.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button270.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb2 underground
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-207.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button271.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-201.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button272.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-208.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button273.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-211.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button274.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-212.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button275.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-203.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button276.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-205.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button277.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-204.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button278.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-216.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button279.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-214.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button280.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-213.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button281.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-215.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button282.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-206.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button283.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb2 sizable
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-38.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button284.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-242.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button285.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-243.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button286.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-288.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button287.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb2 special
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-293.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button288.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-370.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button289.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb2 misc
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-209.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button290.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-391.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button291.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-392.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button292.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-389.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button293.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-573.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button294.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-202.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button295.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-297.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button296.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-131.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button297.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-505.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button298.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-574.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button299.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-210.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button300.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-298.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button301.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-509.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button302.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb2 castle
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-492.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button303.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-496.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button304.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-501.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button305.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-500.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button306.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-493.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button307.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-490.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button308.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-499.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button309.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-495.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button310.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-503.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button311.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-497.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button312.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-494.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button313.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-498.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button314.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-511.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button315.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-507.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button316.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-506.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button317.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-508.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button318.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-491.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button319.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-502.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button320.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-504.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button321.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-510.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button322.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()
    End Sub

    <Flags()> Enum SMB2TilesetVisibility
        None = 0
        Overworld = 1
        Underground = 2
        Sizable = 4
        Special = 8
        Misc = 16
        Castle = 32
    End Enum

    Private Sub ToggleSMB2TilesetVisibility(visibility As SMB2TilesetVisibility)
        smb2_overworld.Visible = visibility.HasFlag(SMB2TilesetVisibility.Overworld)
        smb2_underground.Visible = visibility.HasFlag(SMB2TilesetVisibility.Underground)
        smb2_sizable.Visible = visibility.HasFlag(SMB2TilesetVisibility.Sizable)
        smb2_special.Visible = visibility.HasFlag(SMB2TilesetVisibility.Special)
        smb2_misc.Visible = visibility.HasFlag(SMB2TilesetVisibility.Misc)
        smb2_castle.Visible = visibility.HasFlag(SMB2TilesetVisibility.Castle)
    End Sub

    Private Sub Button246_Click(sender As System.Object, e As System.EventArgs) Handles Button246.Click
        ToggleSMB2TilesetVisibility(SMB2TilesetVisibility.Overworld)
    End Sub

    Private Sub Button247_Click(sender As System.Object, e As System.EventArgs) Handles Button247.Click
        ToggleSMB2TilesetVisibility(SMB2TilesetVisibility.Underground)
    End Sub

    Private Sub Button248_Click(sender As System.Object, e As System.EventArgs) Handles Button248.Click
        ToggleSMB2TilesetVisibility(SMB2TilesetVisibility.Sizable)
    End Sub

    Private Sub Button249_Click(sender As System.Object, e As System.EventArgs) Handles Button249.Click
        ToggleSMB2TilesetVisibility(SMB2TilesetVisibility.Special)
    End Sub

    Private Sub Button250_Click(sender As System.Object, e As System.EventArgs) Handles Button250.Click
        ToggleSMB2TilesetVisibility(SMB2TilesetVisibility.Misc)
    End Sub

    Private Sub Button251_Click(sender As System.Object, e As System.EventArgs) Handles Button251.Click
        ToggleSMB2TilesetVisibility(SMB2TilesetVisibility.Castle)
    End Sub

    Public Sub LoadSMBGFX()
        'smb overworld
        Dim fs As New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-62.png", System.IO.FileMode.Open)
        Dim graphic As Image
        graphic = Image.FromStream(fs)
        Button323.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-63.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button324.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-64.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button325.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-332.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button326.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-333.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button327.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-93.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button328.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-189.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button329.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-190.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button330.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-191.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button331.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-335.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button332.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-334.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button333.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-65.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button334.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb underground
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-56.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button343.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-57.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button344.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-58.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button345.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-326.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button346.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-327.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button347.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-61.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button348.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-331.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button349.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-323.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button350.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-330.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button351.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-329.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button352.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-328.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button353.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-59.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button354.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-324.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button355.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-325.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button356.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb sizable
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-287.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button357.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb special
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-193.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button358.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-192.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button359.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-188.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button360.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-60.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button361.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb misc
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-66.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button362.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-67.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button363.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-68.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button364.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-69.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button365.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-369.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button366.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-388.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button367.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-576.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button368.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-577.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button369.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb pipes
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-194.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button370.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-196.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button371.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-195.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button372.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-197.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button373.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-376.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button374.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-377.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button375.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-378.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button376.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb dungeon
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-396.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button377.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-387.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button378.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-402.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button379.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-385.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button380.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-403.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button381.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-371.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button382.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-401.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button383.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-395.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button384.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-394.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button385.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-393.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button386.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-384.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button387.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-383.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button388.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-405.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button389.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-386.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button390.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-397.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button391.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-390.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button392.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-399.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button393.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-398.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button394.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-400.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button395.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smb clouds
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-373.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button396.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-374.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button397.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-375.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button398.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-372.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button399.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-379.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button400.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-380.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button401.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-381.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button402.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-382.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button403.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()
    End Sub

    <Flags()> Enum SMBTilesetVisibility
        None = 0
        Overworld = 1
        Underground = 2
        Sizable = 4
        Special = 8
        Misc = 16
        Pipes = 32
        Dungeon = 64
        Clouds = 128
    End Enum

    Private Sub ToggleSMBTilesetVisibility(visibility As SMBTilesetVisibility)
        smb_overworld.Visible = visibility.HasFlag(SMBTilesetVisibility.Overworld)
        smb_underground.Visible = visibility.HasFlag(SMBTilesetVisibility.Underground)
        smb_sizable.Visible = visibility.HasFlag(SMBTilesetVisibility.Sizable)
        smb_special.Visible = visibility.HasFlag(SMBTilesetVisibility.Special)
        smb_misc.Visible = visibility.HasFlag(SMBTilesetVisibility.Misc)
        smb_pipes.Visible = visibility.HasFlag(SMBTilesetVisibility.Pipes)
        smb_dungeon.Visible = visibility.HasFlag(SMBTilesetVisibility.Dungeon)
        smb_clouds.Visible = visibility.HasFlag(SMBTilesetVisibility.Clouds)
    End Sub

    Private Sub Button335_Click(sender As System.Object, e As System.EventArgs) Handles Button335.Click
        ToggleSMBTilesetVisibility(SMBTilesetVisibility.Overworld)
    End Sub

    Private Sub Button336_Click(sender As System.Object, e As System.EventArgs) Handles Button336.Click
        ToggleSMBTilesetVisibility(SMBTilesetVisibility.Underground)
    End Sub

    Private Sub Button337_Click(sender As System.Object, e As System.EventArgs) Handles Button337.Click
        ToggleSMBTilesetVisibility(SMBTilesetVisibility.Sizable)
    End Sub

    Private Sub Button338_Click(sender As System.Object, e As System.EventArgs) Handles Button338.Click
        ToggleSMBTilesetVisibility(SMBTilesetVisibility.Special)
    End Sub

    Private Sub Button339_Click(sender As System.Object, e As System.EventArgs) Handles Button339.Click
        ToggleSMBTilesetVisibility(SMBTilesetVisibility.Misc)
    End Sub

    Private Sub Button340_Click(sender As System.Object, e As System.EventArgs) Handles Button340.Click
        ToggleSMBTilesetVisibility(SMBTilesetVisibility.Pipes)
    End Sub

    Private Sub Button341_Click(sender As System.Object, e As System.EventArgs) Handles Button341.Click
        ToggleSMBTilesetVisibility(SMBTilesetVisibility.Dungeon)
    End Sub

    Private Sub Button342_Click(sender As System.Object, e As System.EventArgs) Handles Button342.Click
        ToggleSMBTilesetVisibility(SMBTilesetVisibility.Clouds)
    End Sub

    Public Sub LoadSMWGFX()
        'smw grass
        Dim fs As New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-80.png", System.IO.FileMode.Open)
        Dim graphic As Image
        graphic = Image.FromStream(fs)
        Button417.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-81.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button418.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-82.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button419.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-273.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button420.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-263.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button421.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-299.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button422.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-300.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button423.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-302.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button424.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-301.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button425.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-83.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button426.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-87.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button427.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-84.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button428.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-85.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button429.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-86.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button430.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-309.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button431.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-310.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button432.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-304.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button433.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-303.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button434.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-265.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button435.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-264.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button436.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-266.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button437.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-488.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button438.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-489.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button439.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-616.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button440.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-617.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button441.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-619.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button442.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-618.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button443.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw cave
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-246.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button444.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-250.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button445.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-247.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button446.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-256.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button447.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-255.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button448.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-316.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button449.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-315.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button450.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-365.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button451.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-366.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button452.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-252.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button453.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-251.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button454.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-253.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button455.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-257.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button456.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-258.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button457.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-317.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button458.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-318.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button459.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-368.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button460.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-367.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button461.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-248.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button462.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-254.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button463.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-249.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button464.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-262.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button465.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-321.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button466.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-319.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button467.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-322.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button468.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-320.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button469.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw woods
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-116.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button470.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-119.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button471.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-117.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button472.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-120.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button473.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-118.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button474.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw pipes
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-113.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button475.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-137.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button476.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-138.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button477.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-139.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button478.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-141.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button479.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-140.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button480.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-148.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button481.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-154.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button482.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-114.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button483.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-142.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button484.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-143.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button485.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-144.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button486.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-146.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button487.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-145.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button488.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-149.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button489.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-155.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button490.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-152.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button491.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-158.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button492.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-151.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button493.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-157.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button494.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-147.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button495.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-153.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button496.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-150.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button497.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-156.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button498.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw ghost
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-121.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button499.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-122.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button500.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-123.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button501.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-125.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button502.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-124.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button503.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw castle
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-435.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button504.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-414.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button505.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-434.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button506.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-425.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button507.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-424.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button508.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-426.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button509.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-418.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button510.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-417.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button511.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-452.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button512.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-451.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button513.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-412.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button514.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-413.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button515.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-411.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button516.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-423.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button517.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-422.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button518.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-421.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button519.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-416.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button520.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-415.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button521.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-450.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button522.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-449.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button523.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-433.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button524.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-410.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button525.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-432.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button526.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-427.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button527.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-419.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button528.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-436.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button529.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-455.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button530.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-456.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button531.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-453.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button532.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-454.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button533.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw lava
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-466.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button534.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-459.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button535.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-460.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button536.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-471.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button537.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-468.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button538.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-472.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 64, 32), GraphicsUnit.Pixel)
        Button539.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-474.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 64, 32), GraphicsUnit.Pixel)
        Button540.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-480.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button541.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-482.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button542.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-484.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button543.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-487.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button544.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-463.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button545.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-467.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button546.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-461.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button547.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-470.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button548.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-469.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button549.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-476.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 64, 32), GraphicsUnit.Pixel)
        Button550.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-479.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 64, 32), GraphicsUnit.Pixel)
        Button551.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-486.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button552.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-485.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button553.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-483.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button554.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-481.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button555.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-465.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button556.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-462.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button557.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-464.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button558.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-473.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button559.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-475.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button560.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-477.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button561.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-478.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button562.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-404.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button563.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-420.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button564.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        'smw switch
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-170.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button565.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-173.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button566.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-176.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button567.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-179.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button568.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-171.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button569.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-174.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button570.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-177.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button571.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-180.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button572.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-172.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button573.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-175.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button574.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-178.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button575.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-181.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button576.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw bonus
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-227.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button577.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-228.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button578.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-229.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button579.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-236.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button580.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-237.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button581.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-230.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button582.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-231.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button583.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-232.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button584.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-239.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button585.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-238.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button586.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-233.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button587.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-234.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button588.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-235.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button589.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw sizable
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-79.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button590.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-244.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button591.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-439.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button592.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-440.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button593.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-445.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button594.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-161.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button595.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-261.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button596.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-437.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button597.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-441.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button598.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-444.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button599.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-245.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button600.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-259.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button601.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-438.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button602.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-442.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button603.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-443.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button604.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw misc
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-133.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button605.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-134.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button606.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-135.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button607.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-115.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button608.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-447.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button609.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-446.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button610.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-448.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button611.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw special
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-88.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button612.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-89.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button613.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-90.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button614.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-169.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button615.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-281.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button616.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-282.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button617.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-283.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button618.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-615.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button619.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'smw hurts
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-408.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button620.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-430.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button621.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-409.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button622.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-429.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button623.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-428.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button624.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-407.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button625.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-431.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button626.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()
    End Sub

    <Flags()> Enum SMWTilesetVisibility
        None = 0
        Grass = 1
        Cave = 2
        Woods = 4
        Pipes = 8
        Ghost = 16
        Castle = 32
        Lava = 64
        Switch = 128
        Bonus = 256
        Sizable = 512
        Misc = 1024
        Special = 2048
        Hurts = 4096
    End Enum

    Private Sub ToggleSMWTilesetVisibility(visibility As SMWTilesetVisibility)
        smw_grass.Visible = visibility.HasFlag(SMWTilesetVisibility.Grass)
        smw_cave.Visible = visibility.HasFlag(SMWTilesetVisibility.Cave)
        smw_woods.Visible = visibility.HasFlag(SMWTilesetVisibility.Woods)
        smw_pipes.Visible = visibility.HasFlag(SMWTilesetVisibility.Pipes)
        smw_ghost.Visible = visibility.HasFlag(SMWTilesetVisibility.Ghost)
        smw_castle.Visible = visibility.HasFlag(SMWTilesetVisibility.Castle)
        smw_lava.Visible = visibility.HasFlag(SMWTilesetVisibility.Lava)
        smw_switch.Visible = visibility.HasFlag(SMWTilesetVisibility.Switch)
        smw_bonus.Visible = visibility.HasFlag(SMWTilesetVisibility.Bonus)
        smw_sizable.Visible = visibility.HasFlag(SMWTilesetVisibility.Sizable)
        smw_misc.Visible = visibility.HasFlag(SMWTilesetVisibility.Misc)
        smw_special.Visible = visibility.HasFlag(SMWTilesetVisibility.Special)
        smw_hurts.Visible = visibility.HasFlag(SMWTilesetVisibility.Hurts)
    End Sub

    Private Sub Button404_Click(sender As System.Object, e As System.EventArgs) Handles Button404.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Grass)
    End Sub

    Private Sub Button405_Click(sender As System.Object, e As System.EventArgs) Handles Button405.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Cave)
    End Sub

    Private Sub Button406_Click(sender As System.Object, e As System.EventArgs) Handles Button406.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Woods)
    End Sub

    Private Sub Button407_Click(sender As System.Object, e As System.EventArgs) Handles Button407.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Pipes)
    End Sub

    Private Sub Button408_Click(sender As System.Object, e As System.EventArgs) Handles Button408.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Ghost)
    End Sub

    Private Sub Button409_Click(sender As System.Object, e As System.EventArgs) Handles Button409.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Castle)
    End Sub

    Private Sub Button410_Click(sender As System.Object, e As System.EventArgs) Handles Button410.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Lava)
    End Sub

    Private Sub Button411_Click(sender As System.Object, e As System.EventArgs) Handles Button411.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Switch)
    End Sub

    Private Sub Button412_Click(sender As System.Object, e As System.EventArgs) Handles Button412.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Bonus)
    End Sub

    Private Sub Button413_Click(sender As System.Object, e As System.EventArgs) Handles Button413.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Sizable)
    End Sub

    Private Sub Button414_Click(sender As System.Object, e As System.EventArgs) Handles Button414.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Misc)
    End Sub

    Private Sub Button415_Click(sender As System.Object, e As System.EventArgs) Handles Button415.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Special)
    End Sub

    Private Sub Button416_Click(sender As System.Object, e As System.EventArgs) Handles Button416.Click
        ToggleSMWTilesetVisibility(SMWTilesetVisibility.Hurts)
    End Sub

    Public Sub LoadMiscGFX()
        'misc Zelda 2
        Dim fs As New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-291.png", System.IO.FileMode.Open)
        Dim graphic As Image
        graphic = Image.FromStream(fs)
        Button631.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-292.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button632.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'misc Metroid (A)
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-522.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button633.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-528.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button634.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-523.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button635.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-530.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button636.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-516.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button637.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-517.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button638.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-514.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button639.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-518.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button640.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-542.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button641.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-541.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button642.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-540.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button643.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-520.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button644.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-526.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button645.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-525.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button646.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-527.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button647.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-532.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button648.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-515.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button649.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-513.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button650.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-533.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button651.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-539.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button652.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-534.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button653.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-535.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button654.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-519.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button655.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-524.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button656.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-521.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button657.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-529.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button658.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-531.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button659.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-538.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button660.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-544.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button661.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-543.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button662.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-512.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button663.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-536.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button664.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-537.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button665.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'misc Metroid (B)
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-550.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button666.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-556.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button667.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-561.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button668.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-566.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button669.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-564.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button670.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-562.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button671.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-547.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button672.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-548.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button673.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-565.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button674.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-567.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button675.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-551.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button676.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-558.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button677.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-555.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button678.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-545.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button679.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-546.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button680.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-549.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button681.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-553.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button682.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-554.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button683.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-563.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button684.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-557.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button685.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-552.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button686.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-559.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button687.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-560.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        Button688.BackgroundImage = graphic
        fs.Close()
        fs.Dispose()

        'misc players
        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-622.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button689.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-623.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button690.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-624.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button691.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-625.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button692.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-631.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button693.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-626.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button694.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-627.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button695.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-628.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button696.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-629.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button697.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()

        fs = New System.IO.FileStream(Main.GetGamePath() & "\graphics\block\block-632.png", System.IO.FileMode.Open)
        graphic = Image.FromStream(fs)
        bmp = New Bitmap(32, 32)
        g = Graphics.FromImage(bmp)
        g.DrawImage(graphic, New Rectangle(0, 0, 32, 32), New Rectangle(0, 0, 32, 32), GraphicsUnit.Pixel)
        Button698.BackgroundImage = bmp
        fs.Close()
        fs.Dispose()
    End Sub

    <Flags()> Enum MiscTilesetVisibility
        None = 0
        Zelda = 1
        MetroidA = 2
        MetroidB = 4
        Players = 8
    End Enum

    Private Sub ToggleMiscTilesetVisibility(visibility As MiscTilesetVisibility)
        misc_zelda.Visible = visibility.HasFlag(MiscTilesetVisibility.Zelda)
        misc_metroidA.Visible = visibility.HasFlag(MiscTilesetVisibility.MetroidA)
        misc_metroidB.Visible = visibility.HasFlag(MiscTilesetVisibility.MetroidB)
        misc_players.Visible = visibility.HasFlag(MiscTilesetVisibility.Players)
    End Sub

    Private Sub Button627_Click(sender As System.Object, e As System.EventArgs) Handles Button627.Click
        ToggleMiscTilesetVisibility(MiscTilesetVisibility.Zelda)
    End Sub

    Private Sub Button628_Click(sender As System.Object, e As System.EventArgs) Handles Button628.Click
        ToggleMiscTilesetVisibility(MiscTilesetVisibility.MetroidA)
    End Sub

    Private Sub Button629_Click(sender As System.Object, e As System.EventArgs) Handles Button629.Click
        ToggleMiscTilesetVisibility(MiscTilesetVisibility.MetroidB)
    End Sub

    Private Sub Button630_Click(sender As System.Object, e As System.EventArgs) Handles Button630.Click
        ToggleMiscTilesetVisibility(MiscTilesetVisibility.Players)
    End Sub

    Private Sub Button39_Click(sender As System.Object, e As System.EventArgs) Handles Button39.Click
        If Not ObjectPlacement.Fill Then
            ObjectPlacement.Fill = True
            Button39.Text = "Fill: On"
        Else
            ObjectPlacement.Fill = False
            Button39.Text = "Fill: Off"
        End If
    End Sub

    Private Sub Button699_Click(sender As System.Object, e As System.EventArgs) Handles Button699.Click
        If Blocks.FillBlocks.Count > 0 Then
            For Each i As Block In Blocks.FillBlocks.ToList
                If Blocks.Tiles.Contains(i) Then
                    Blocks.Tiles.Remove(i)
                    Blocks.TileRects.Remove(i.PositionRect)
                End If
            Next
        End If
    End Sub

    Private Sub Button700_Click(sender As Object, e As EventArgs) Handles Button700.Click
        For i = 0 To Blocks.FillBlocks.Count - 1
            If Not Blocks.Tiles.Contains(Blocks.FillBlocks(i)) Then
                Blocks.Tiles.Add(Blocks.FillBlocks(i))
                Blocks.TileRects.Add(Blocks.FillBlocks(i).PositionRect)
            End If
        Next
    End Sub
End Class