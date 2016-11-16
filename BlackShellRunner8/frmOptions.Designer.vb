<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOptions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOptions))
        picShadowColor = New System.Windows.Forms.PictureBox()
        picBackColor = New System.Windows.Forms.PictureBox()
        picForeColor = New System.Windows.Forms.PictureBox()
        chkGraphics = New System.Windows.Forms.CheckBox()
        chkSound = New System.Windows.Forms.CheckBox()
        tbTransparency = New System.Windows.Forms.TrackBar()
        chkStartHidden = New System.Windows.Forms.CheckBox()
        chkDOSPause = New System.Windows.Forms.CheckBox()
        chkRunAtStartUp = New System.Windows.Forms.CheckBox()
        chkClassicHide = New System.Windows.Forms.CheckBox()
        tbGraphicStrength = New System.Windows.Forms.TrackBar()
        rbListItems = New System.Windows.Forms.RadioButton()
        rbFileSystem = New System.Windows.Forms.RadioButton()
        chkSnap = New System.Windows.Forms.CheckBox()
        chkShowCorner = New System.Windows.Forms.CheckBox()
        tbSpeed = New System.Windows.Forms.TrackBar()
        abMoveSpeed = New AcidControls.AcidButton()
        abShowCorner = New AcidControls.AcidButton()
        abSnap = New AcidControls.AcidButton()
        abConsole = New AcidControls.AcidButton()
        abFileOrList = New AcidControls.AcidButton()
        abAutoCompleteMode = New AcidControls.AcidButton()
        abGraphicStrength = New AcidControls.AcidButton()
        abClassicHide = New AcidControls.AcidButton()
        abRunAtStartUp = New AcidControls.AcidButton()
        abDosPauseChk = New AcidControls.AcidButton()
        abStartHidden = New AcidControls.AcidButton()
        abAbout = New AcidControls.AcidButton()
        abGraphics = New AcidControls.AcidButton()
        abSound = New AcidControls.AcidButton()
        abTrans = New AcidControls.AcidButton()
        abCstCmds = New AcidControls.AcidButton()
        abHstry = New AcidControls.AcidButton()
        abShadowColor = New AcidControls.AcidButton()
        abBackColor = New AcidControls.AcidButton()
        abForeColor = New AcidControls.AcidButton()
        abOk = New AcidControls.AcidButton()
        mcttMain = New AcidControls.AcidToolTip(components)
        PicBackPic = New System.Windows.Forms.PictureBox()
        tbPicOpacity = New System.Windows.Forms.TrackBar()
        abMakeShellExtension = New AcidControls.AcidButton()
        abINI = New AcidControls.AcidButton()
        abBSRDir = New AcidControls.AcidButton()
        colPicker = New System.Windows.Forms.ColorDialog()
        AcidButton1 = New AcidControls.AcidButton()
        ofdPic = New System.Windows.Forms.OpenFileDialog()
        abPicLayerTrans = New AcidControls.AcidButton()
        chkPic = New System.Windows.Forms.CheckBox()
        abBrdr = New AcidControls.AcidBorder()
        colPicker2 = New System.Windows.Forms.ColorDialog()
        colPicker3 = New System.Windows.Forms.ColorDialog()
        CType(picShadowColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(picBackColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(picForeColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(tbTransparency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(tbGraphicStrength, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(tbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBackPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(tbPicOpacity, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'picShadowColor
        '
        picShadowColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        picShadowColor.BackColor = System.Drawing.Color.Green
        picShadowColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        picShadowColor.Cursor = System.Windows.Forms.Cursors.Hand
        picShadowColor.Location = New System.Drawing.Point(200, 490)
        picShadowColor.Name = "picShadowColor"
        picShadowColor.Size = New System.Drawing.Size(24, 25)
        picShadowColor.TabIndex = 9
        picShadowColor.TabStop = False
        mcttMain.SetToolTip(picShadowColor, "ShadowColor")
        '
        'picBackColor
        '
        picBackColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        picBackColor.BackColor = System.Drawing.Color.Black
        picBackColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        picBackColor.Cursor = System.Windows.Forms.Cursors.Hand
        picBackColor.Location = New System.Drawing.Point(200, 463)
        picBackColor.Name = "picBackColor"
        picBackColor.Size = New System.Drawing.Size(24, 25)
        picBackColor.TabIndex = 8
        picBackColor.TabStop = False
        mcttMain.SetToolTip(picBackColor, "BackColor")
        '
        'picForeColor
        '
        picForeColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        picForeColor.BackColor = System.Drawing.Color.Lime
        picForeColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        picForeColor.Cursor = System.Windows.Forms.Cursors.Hand
        picForeColor.Location = New System.Drawing.Point(200, 436)
        picForeColor.Name = "picForeColor"
        picForeColor.Size = New System.Drawing.Size(24, 25)
        picForeColor.TabIndex = 7
        picForeColor.TabStop = False
        mcttMain.SetToolTip(picForeColor, "ForeColor")
        '
        'chkGraphics
        '
        chkGraphics.Anchor = System.Windows.Forms.AnchorStyles.Top
        chkGraphics.AutoSize = True
        chkGraphics.BackColor = System.Drawing.Color.Black
        chkGraphics.Cursor = System.Windows.Forms.Cursors.Hand
        chkGraphics.ForeColor = System.Drawing.Color.Lime
        chkGraphics.Location = New System.Drawing.Point(159, 158)
        chkGraphics.Name = "chkGraphics"
        chkGraphics.Size = New System.Drawing.Size(15, 14)
        chkGraphics.TabIndex = 15
        mcttMain.SetToolTip(chkGraphics, "Do You Want To Display Screen Effects?")
        chkGraphics.UseVisualStyleBackColor = False
        '
        'chkSound
        '
        chkSound.Anchor = System.Windows.Forms.AnchorStyles.Top
        chkSound.AutoSize = True
        chkSound.BackColor = System.Drawing.Color.Black
        chkSound.Cursor = System.Windows.Forms.Cursors.Hand
        chkSound.ForeColor = System.Drawing.Color.Lime
        chkSound.Location = New System.Drawing.Point(176, 176)
        chkSound.Name = "chkSound"
        chkSound.Size = New System.Drawing.Size(15, 14)
        chkSound.TabIndex = 16
        mcttMain.SetToolTip(chkSound, "Do You Want To Hear Sound?")
        chkSound.UseVisualStyleBackColor = False
        '
        'tbTransparency
        '
        tbTransparency.Anchor = System.Windows.Forms.AnchorStyles.Top
        tbTransparency.BackColor = System.Drawing.Color.Black
        tbTransparency.Cursor = System.Windows.Forms.Cursors.Hand
        tbTransparency.LargeChange = 1
        tbTransparency.Location = New System.Drawing.Point(71, 246)
        tbTransparency.Maximum = 100
        tbTransparency.Minimum = 1
        tbTransparency.Name = "tbTransparency"
        tbTransparency.Size = New System.Drawing.Size(285, 45)
        tbTransparency.TabIndex = 17
        tbTransparency.TickStyle = System.Windows.Forms.TickStyle.Both
        mcttMain.SetToolTip(tbTransparency, "The Transparency Of BlackShellRunner Windows")
        tbTransparency.Value = 100
        '
        'chkStartHidden
        '
        chkStartHidden.Anchor = System.Windows.Forms.AnchorStyles.Top
        chkStartHidden.AutoSize = True
        chkStartHidden.BackColor = System.Drawing.Color.Black
        chkStartHidden.Cursor = System.Windows.Forms.Cursors.Hand
        chkStartHidden.ForeColor = System.Drawing.Color.Lime
        chkStartHidden.Location = New System.Drawing.Point(164, 139)
        chkStartHidden.Name = "chkStartHidden"
        chkStartHidden.Size = New System.Drawing.Size(15, 14)
        chkStartHidden.TabIndex = 24
        mcttMain.SetToolTip(chkStartHidden, "Run As Classic Button Or In System Tray At Program StartUp")
        chkStartHidden.UseVisualStyleBackColor = False
        '
        'chkDOSPause
        '
        chkDOSPause.Anchor = System.Windows.Forms.AnchorStyles.Top
        chkDOSPause.AutoSize = True
        chkDOSPause.BackColor = System.Drawing.Color.Black
        chkDOSPause.Cursor = System.Windows.Forms.Cursors.Hand
        chkDOSPause.ForeColor = System.Drawing.Color.Lime
        chkDOSPause.Location = New System.Drawing.Point(108, 123)
        chkDOSPause.Name = "chkDOSPause"
        chkDOSPause.Size = New System.Drawing.Size(15, 14)
        chkDOSPause.TabIndex = 23
        mcttMain.SetToolTip(chkDOSPause, "Show The MS-DOS Pause Check Box On Main Form Or Not")
        chkDOSPause.UseVisualStyleBackColor = False
        '
        'chkRunAtStartUp
        '
        chkRunAtStartUp.Anchor = System.Windows.Forms.AnchorStyles.Top
        chkRunAtStartUp.AutoSize = True
        chkRunAtStartUp.BackColor = System.Drawing.Color.Black
        chkRunAtStartUp.Cursor = System.Windows.Forms.Cursors.Hand
        chkRunAtStartUp.ForeColor = System.Drawing.Color.Lime
        chkRunAtStartUp.Location = New System.Drawing.Point(133, 103)
        chkRunAtStartUp.Name = "chkRunAtStartUp"
        chkRunAtStartUp.Size = New System.Drawing.Size(15, 14)
        chkRunAtStartUp.TabIndex = 27
        mcttMain.SetToolTip(chkRunAtStartUp, "Run BlackShellRunner At System StartUp")
        chkRunAtStartUp.UseVisualStyleBackColor = False
        '
        'chkClassicHide
        '
        chkClassicHide.Anchor = System.Windows.Forms.AnchorStyles.Top
        chkClassicHide.AutoSize = True
        chkClassicHide.BackColor = System.Drawing.Color.Black
        chkClassicHide.Cursor = System.Windows.Forms.Cursors.Hand
        chkClassicHide.ForeColor = System.Drawing.Color.Lime
        chkClassicHide.Location = New System.Drawing.Point(142, 84)
        chkClassicHide.Name = "chkClassicHide"
        chkClassicHide.Size = New System.Drawing.Size(15, 14)
        chkClassicHide.TabIndex = 29
        mcttMain.SetToolTip(chkClassicHide, "Hide BlackShellRunner As Classic Button Or In System Tray")
        chkClassicHide.UseVisualStyleBackColor = False
        '
        'tbGraphicStrength
        '
        tbGraphicStrength.Anchor = System.Windows.Forms.AnchorStyles.Top
        tbGraphicStrength.BackColor = System.Drawing.Color.Black
        tbGraphicStrength.Cursor = System.Windows.Forms.Cursors.Hand
        tbGraphicStrength.LargeChange = 1
        tbGraphicStrength.Location = New System.Drawing.Point(71, 190)
        tbGraphicStrength.Maximum = 60
        tbGraphicStrength.Name = "tbGraphicStrength"
        tbGraphicStrength.Size = New System.Drawing.Size(285, 45)
        tbGraphicStrength.TabIndex = 31
        tbGraphicStrength.TickStyle = System.Windows.Forms.TickStyle.Both
        mcttMain.SetToolTip(tbGraphicStrength, "How Long It Takes The Command Execution Screen Graphics To Complete")
        '
        'rbListItems
        '
        rbListItems.Anchor = System.Windows.Forms.AnchorStyles.Top
        rbListItems.AutoSize = True
        rbListItems.Cursor = System.Windows.Forms.Cursors.Hand
        rbListItems.ForeColor = System.Drawing.Color.Lime
        rbListItems.Location = New System.Drawing.Point(124, 9)
        rbListItems.Name = "rbListItems"
        rbListItems.Size = New System.Drawing.Size(14, 13)
        rbListItems.TabIndex = 35
        mcttMain.SetToolTip(rbListItems, "List Items Auto Complete")
        rbListItems.UseCompatibleTextRendering = True
        rbListItems.UseVisualStyleBackColor = True
        '
        'rbFileSystem
        '
        rbFileSystem.Anchor = System.Windows.Forms.AnchorStyles.Top
        rbFileSystem.AutoSize = True
        rbFileSystem.Cursor = System.Windows.Forms.Cursors.Hand
        rbFileSystem.ForeColor = System.Drawing.Color.Lime
        rbFileSystem.Location = New System.Drawing.Point(304, 9)
        rbFileSystem.Name = "rbFileSystem"
        rbFileSystem.Size = New System.Drawing.Size(14, 13)
        rbFileSystem.TabIndex = 36
        mcttMain.SetToolTip(rbFileSystem, "File System Auto Complete")
        rbFileSystem.UseCompatibleTextRendering = True
        rbFileSystem.UseVisualStyleBackColor = True
        '
        'chkSnap
        '
        chkSnap.Anchor = System.Windows.Forms.AnchorStyles.Top
        chkSnap.AutoSize = True
        chkSnap.BackColor = System.Drawing.Color.Black
        chkSnap.Cursor = System.Windows.Forms.Cursors.Hand
        chkSnap.ForeColor = System.Drawing.Color.Lime
        chkSnap.Location = New System.Drawing.Point(147, 65)
        chkSnap.Name = "chkSnap"
        chkSnap.Size = New System.Drawing.Size(15, 14)
        chkSnap.TabIndex = 41
        mcttMain.SetToolTip(chkSnap, "Snap To Corners")
        chkSnap.UseVisualStyleBackColor = False
        '
        'chkShowCorner
        '
        chkShowCorner.Anchor = System.Windows.Forms.AnchorStyles.Top
        chkShowCorner.AutoSize = True
        chkShowCorner.BackColor = System.Drawing.Color.Black
        chkShowCorner.Cursor = System.Windows.Forms.Cursors.Hand
        chkShowCorner.ForeColor = System.Drawing.Color.Lime
        chkShowCorner.Location = New System.Drawing.Point(145, 46)
        chkShowCorner.Name = "chkShowCorner"
        chkShowCorner.Size = New System.Drawing.Size(15, 14)
        chkShowCorner.TabIndex = 43
        mcttMain.SetToolTip(chkShowCorner, "Show Corner Grid")
        chkShowCorner.UseVisualStyleBackColor = False
        '
        'tbSpeed
        '
        tbSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top
        tbSpeed.BackColor = System.Drawing.Color.Black
        tbSpeed.Cursor = System.Windows.Forms.Cursors.Hand
        tbSpeed.LargeChange = 1
        tbSpeed.Location = New System.Drawing.Point(33, 135)
        tbSpeed.Maximum = 20
        tbSpeed.Minimum = 2
        tbSpeed.Name = "tbSpeed"
        tbSpeed.Orientation = System.Windows.Forms.Orientation.Vertical
        tbSpeed.Size = New System.Drawing.Size(45, 167)
        tbSpeed.TabIndex = 44
        tbSpeed.TickStyle = System.Windows.Forms.TickStyle.Both
        mcttMain.SetToolTip(tbSpeed, "How fast the main BSR window moves (up, down, left, right) on the screen when gra" &
        "phics are enabled")
        tbSpeed.Value = 7
        '
        'abMoveSpeed
        '
        abMoveSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top
        abMoveSpeed.ClickHidesParent = False
        abMoveSpeed.Color1 = System.Drawing.Color.Empty
        abMoveSpeed.Color2 = System.Drawing.Color.Empty
        abMoveSpeed.Cursor = System.Windows.Forms.Cursors.Hand
        abMoveSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abMoveSpeed.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abMoveSpeed.HasRoundedRectangle = True
        abMoveSpeed.HasSound = False
        abMoveSpeed.LineSize = 2
        abMoveSpeed.Location = New System.Drawing.Point(14, 143)
        abMoveSpeed.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abMoveSpeed.MouseClickSound = ""
        abMoveSpeed.MouseClickSoundResource = Nothing
        abMoveSpeed.MouseClickSoundResourcePath = ""
        abMoveSpeed.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abMoveSpeed.MouseEnterSound = ""
        abMoveSpeed.MouseEnterSoundResource = Nothing
        abMoveSpeed.MouseEnterSoundResourcePath = ""
        abMoveSpeed.Name = "abMoveSpeed"
        abMoveSpeed.ResizeTextFontOnResize = False
        abMoveSpeed.RoundedRadius = 5.0!
        abMoveSpeed.Shadow = False
        abMoveSpeed.ShadowAllWithMouseEnter = False
        abMoveSpeed.ShadowColor = System.Drawing.Color.Green
        abMoveSpeed.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abMoveSpeed.ShadowDivisor = 2
        abMoveSpeed.ShadowWithMouseEnter = False
        abMoveSpeed.ShiftAllOnClick = False
        abMoveSpeed.ShiftForeColor = System.Drawing.Color.DarkGreen
        abMoveSpeed.ShiftOnClick = False
        abMoveSpeed.ShiftShadowColor = System.Drawing.Color.Lime
        abMoveSpeed.ShowBorder = False
        abMoveSpeed.Size = New System.Drawing.Size(13, 147)
        abMoveSpeed.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abMoveSpeed.TabIndex = 45
        abMoveSpeed.Text = " ^ Window  Move  Speed ^"
        abMoveSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abMoveSpeed.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Vertical
        abMoveSpeed.TextShadowDisplacement = 1
        abMoveSpeed.UseCompatibleTextRendering = True
        '
        'abShowCorner
        '
        abShowCorner.Anchor = System.Windows.Forms.AnchorStyles.Top
        abShowCorner.ClickHidesParent = False
        abShowCorner.Color1 = System.Drawing.Color.Empty
        abShowCorner.Color2 = System.Drawing.Color.Empty
        abShowCorner.Cursor = System.Windows.Forms.Cursors.Hand
        abShowCorner.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abShowCorner.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abShowCorner.HasRoundedRectangle = True
        abShowCorner.HasSound = False
        abShowCorner.LineSize = 2
        abShowCorner.Location = New System.Drawing.Point(163, 42)
        abShowCorner.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abShowCorner.MouseClickSound = ""
        abShowCorner.MouseClickSoundResource = Nothing
        abShowCorner.MouseClickSoundResourcePath = ""
        abShowCorner.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abShowCorner.MouseEnterSound = ""
        abShowCorner.MouseEnterSoundResource = Nothing
        abShowCorner.MouseEnterSoundResourcePath = ""
        abShowCorner.Name = "abShowCorner"
        abShowCorner.ResizeTextFontOnResize = False
        abShowCorner.RoundedRadius = 5.0!
        abShowCorner.Shadow = False
        abShowCorner.ShadowAllWithMouseEnter = False
        abShowCorner.ShadowColor = System.Drawing.Color.Green
        abShowCorner.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abShowCorner.ShadowDivisor = 2
        abShowCorner.ShadowWithMouseEnter = False
        abShowCorner.ShiftAllOnClick = False
        abShowCorner.ShiftForeColor = System.Drawing.Color.DarkGreen
        abShowCorner.ShiftOnClick = False
        abShowCorner.ShiftShadowColor = System.Drawing.Color.Lime
        abShowCorner.ShowBorder = False
        abShowCorner.Size = New System.Drawing.Size(103, 21)
        abShowCorner.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abShowCorner.TabIndex = 42
        abShowCorner.Text = "< Show Corner Grid"
        abShowCorner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abShowCorner.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abShowCorner.TextShadowDisplacement = 1
        abShowCorner.UseCompatibleTextRendering = True
        '
        'abSnap
        '
        abSnap.Anchor = System.Windows.Forms.AnchorStyles.Top
        abSnap.ClickHidesParent = False
        abSnap.Color1 = System.Drawing.Color.Empty
        abSnap.Color2 = System.Drawing.Color.Empty
        abSnap.Cursor = System.Windows.Forms.Cursors.Hand
        abSnap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abSnap.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abSnap.HasRoundedRectangle = True
        abSnap.HasSound = False
        abSnap.LineSize = 2
        abSnap.Location = New System.Drawing.Point(158, 61)
        abSnap.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abSnap.MouseClickSound = ""
        abSnap.MouseClickSoundResource = Nothing
        abSnap.MouseClickSoundResourcePath = ""
        abSnap.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abSnap.MouseEnterSound = ""
        abSnap.MouseEnterSoundResource = Nothing
        abSnap.MouseEnterSoundResourcePath = ""
        abSnap.Name = "abSnap"
        abSnap.ResizeTextFontOnResize = False
        abSnap.RoundedRadius = 5.0!
        abSnap.Shadow = False
        abSnap.ShadowAllWithMouseEnter = False
        abSnap.ShadowColor = System.Drawing.Color.Green
        abSnap.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abSnap.ShadowDivisor = 2
        abSnap.ShadowWithMouseEnter = False
        abSnap.ShiftAllOnClick = False
        abSnap.ShiftForeColor = System.Drawing.Color.DarkGreen
        abSnap.ShiftOnClick = False
        abSnap.ShiftShadowColor = System.Drawing.Color.Lime
        abSnap.ShowBorder = False
        abSnap.Size = New System.Drawing.Size(117, 21)
        abSnap.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abSnap.TabIndex = 40
        abSnap.Text = "< Snap To Corners"
        abSnap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abSnap.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abSnap.TextShadowDisplacement = 1
        abSnap.UseCompatibleTextRendering = True
        '
        'abConsole
        '
        abConsole.Anchor = System.Windows.Forms.AnchorStyles.Top
        abConsole.ClickHidesParent = False
        abConsole.Color1 = System.Drawing.Color.Empty
        abConsole.Color2 = System.Drawing.Color.Empty
        abConsole.Cursor = System.Windows.Forms.Cursors.Hand
        abConsole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abConsole.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abConsole.HasRoundedRectangle = True
        abConsole.HasSound = False
        abConsole.LineSize = 2
        abConsole.Location = New System.Drawing.Point(223, 335)
        abConsole.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abConsole.MouseClickSound = ""
        abConsole.MouseClickSoundResource = Nothing
        abConsole.MouseClickSoundResourcePath = ""
        abConsole.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abConsole.MouseEnterSound = ""
        abConsole.MouseEnterSoundResource = Nothing
        abConsole.MouseEnterSoundResourcePath = ""
        abConsole.Name = "abConsole"
        abConsole.ResizeTextFontOnResize = False
        abConsole.RoundedRadius = 10.0!
        abConsole.Shadow = False
        abConsole.ShadowAllWithMouseEnter = False
        abConsole.ShadowColor = System.Drawing.Color.Green
        abConsole.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abConsole.ShadowDivisor = 2
        abConsole.ShadowWithMouseEnter = True
        abConsole.ShiftAllOnClick = False
        abConsole.ShiftForeColor = System.Drawing.Color.Green
        abConsole.ShiftOnClick = True
        abConsole.ShiftShadowColor = System.Drawing.Color.Lime
        abConsole.ShowBorder = True
        abConsole.Size = New System.Drawing.Size(189, 20)
        abConsole.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abConsole.TabIndex = 38
        abConsole.Text = "Console Programs"
        abConsole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abConsole.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abConsole.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abConsole, "Console Programs Window")
        abConsole.UseCompatibleTextRendering = True
        '
        'abFileOrList
        '
        abFileOrList.Anchor = System.Windows.Forms.AnchorStyles.Top
        abFileOrList.ClickHidesParent = False
        abFileOrList.Color1 = System.Drawing.Color.Empty
        abFileOrList.Color2 = System.Drawing.Color.Empty
        abFileOrList.Cursor = System.Windows.Forms.Cursors.Hand
        abFileOrList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abFileOrList.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abFileOrList.HasRoundedRectangle = True
        abFileOrList.HasSound = False
        abFileOrList.LineSize = 2
        abFileOrList.Location = New System.Drawing.Point(139, 5)
        abFileOrList.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abFileOrList.MouseClickSound = ""
        abFileOrList.MouseClickSoundResource = Nothing
        abFileOrList.MouseClickSoundResourcePath = ""
        abFileOrList.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abFileOrList.MouseEnterSound = ""
        abFileOrList.MouseEnterSoundResource = Nothing
        abFileOrList.MouseEnterSoundResourcePath = ""
        abFileOrList.Name = "abFileOrList"
        abFileOrList.ResizeTextFontOnResize = False
        abFileOrList.RoundedRadius = 5.0!
        abFileOrList.Shadow = False
        abFileOrList.ShadowAllWithMouseEnter = False
        abFileOrList.ShadowColor = System.Drawing.Color.Green
        abFileOrList.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abFileOrList.ShadowDivisor = 2
        abFileOrList.ShadowWithMouseEnter = False
        abFileOrList.ShiftAllOnClick = False
        abFileOrList.ShiftForeColor = System.Drawing.Color.DarkGreen
        abFileOrList.ShiftOnClick = False
        abFileOrList.ShiftShadowColor = System.Drawing.Color.Lime
        abFileOrList.ShowBorder = False
        abFileOrList.Size = New System.Drawing.Size(154, 21)
        abFileOrList.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abFileOrList.TabIndex = 37
        abFileOrList.Text = "< List Items | File System >"
        abFileOrList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abFileOrList.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abFileOrList.TextShadowDisplacement = 1
        abFileOrList.UseCompatibleTextRendering = True
        '
        'abAutoCompleteMode
        '
        abAutoCompleteMode.Anchor = System.Windows.Forms.AnchorStyles.Top
        abAutoCompleteMode.ClickHidesParent = False
        abAutoCompleteMode.Color1 = System.Drawing.Color.Empty
        abAutoCompleteMode.Color2 = System.Drawing.Color.Empty
        abAutoCompleteMode.Cursor = System.Windows.Forms.Cursors.Hand
        abAutoCompleteMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abAutoCompleteMode.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abAutoCompleteMode.HasRoundedRectangle = True
        abAutoCompleteMode.HasSound = False
        abAutoCompleteMode.LineSize = 2
        abAutoCompleteMode.Location = New System.Drawing.Point(84, 25)
        abAutoCompleteMode.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abAutoCompleteMode.MouseClickSound = ""
        abAutoCompleteMode.MouseClickSoundResource = Nothing
        abAutoCompleteMode.MouseClickSoundResourcePath = ""
        abAutoCompleteMode.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abAutoCompleteMode.MouseEnterSound = ""
        abAutoCompleteMode.MouseEnterSoundResource = Nothing
        abAutoCompleteMode.MouseEnterSoundResourcePath = ""
        abAutoCompleteMode.Name = "abAutoCompleteMode"
        abAutoCompleteMode.ResizeTextFontOnResize = False
        abAutoCompleteMode.RoundedRadius = 5.0!
        abAutoCompleteMode.Shadow = False
        abAutoCompleteMode.ShadowAllWithMouseEnter = False
        abAutoCompleteMode.ShadowColor = System.Drawing.Color.Green
        abAutoCompleteMode.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abAutoCompleteMode.ShadowDivisor = 2
        abAutoCompleteMode.ShadowWithMouseEnter = False
        abAutoCompleteMode.ShiftAllOnClick = False
        abAutoCompleteMode.ShiftForeColor = System.Drawing.Color.DarkGreen
        abAutoCompleteMode.ShiftOnClick = False
        abAutoCompleteMode.ShiftShadowColor = System.Drawing.Color.Lime
        abAutoCompleteMode.ShowBorder = False
        abAutoCompleteMode.Size = New System.Drawing.Size(261, 19)
        abAutoCompleteMode.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abAutoCompleteMode.TabIndex = 34
        abAutoCompleteMode.Text = "^ Auto Complete List ^"
        abAutoCompleteMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abAutoCompleteMode.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abAutoCompleteMode.TextShadowDisplacement = 1
        abAutoCompleteMode.UseCompatibleTextRendering = True
        '
        'abGraphicStrength
        '
        abGraphicStrength.Anchor = System.Windows.Forms.AnchorStyles.Top
        abGraphicStrength.ClickHidesParent = False
        abGraphicStrength.Color1 = System.Drawing.Color.Empty
        abGraphicStrength.Color2 = System.Drawing.Color.Empty
        abGraphicStrength.Cursor = System.Windows.Forms.Cursors.Hand
        abGraphicStrength.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abGraphicStrength.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abGraphicStrength.HasRoundedRectangle = True
        abGraphicStrength.HasSound = False
        abGraphicStrength.LineSize = 2
        abGraphicStrength.Location = New System.Drawing.Point(80, 227)
        abGraphicStrength.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abGraphicStrength.MouseClickSound = ""
        abGraphicStrength.MouseClickSoundResource = Nothing
        abGraphicStrength.MouseClickSoundResourcePath = ""
        abGraphicStrength.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abGraphicStrength.MouseEnterSound = ""
        abGraphicStrength.MouseEnterSoundResource = Nothing
        abGraphicStrength.MouseEnterSoundResourcePath = ""
        abGraphicStrength.Name = "abGraphicStrength"
        abGraphicStrength.ResizeTextFontOnResize = False
        abGraphicStrength.RoundedRadius = 5.0!
        abGraphicStrength.Shadow = False
        abGraphicStrength.ShadowAllWithMouseEnter = False
        abGraphicStrength.ShadowColor = System.Drawing.Color.Green
        abGraphicStrength.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abGraphicStrength.ShadowDivisor = 2
        abGraphicStrength.ShadowWithMouseEnter = False
        abGraphicStrength.ShiftAllOnClick = False
        abGraphicStrength.ShiftForeColor = System.Drawing.Color.DarkGreen
        abGraphicStrength.ShiftOnClick = False
        abGraphicStrength.ShiftShadowColor = System.Drawing.Color.Lime
        abGraphicStrength.ShowBorder = False
        abGraphicStrength.Size = New System.Drawing.Size(276, 21)
        abGraphicStrength.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abGraphicStrength.TabIndex = 32
        abGraphicStrength.Text = "^ Command Graphic Strength ^"
        abGraphicStrength.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abGraphicStrength.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abGraphicStrength.TextShadowDisplacement = 1
        abGraphicStrength.UseCompatibleTextRendering = True
        '
        'abClassicHide
        '
        abClassicHide.Anchor = System.Windows.Forms.AnchorStyles.Top
        abClassicHide.ClickHidesParent = False
        abClassicHide.Color1 = System.Drawing.Color.Empty
        abClassicHide.Color2 = System.Drawing.Color.Empty
        abClassicHide.Cursor = System.Windows.Forms.Cursors.Hand
        abClassicHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abClassicHide.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abClassicHide.HasRoundedRectangle = True
        abClassicHide.HasSound = False
        abClassicHide.LineSize = 2
        abClassicHide.Location = New System.Drawing.Point(158, 80)
        abClassicHide.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abClassicHide.MouseClickSound = ""
        abClassicHide.MouseClickSoundResource = Nothing
        abClassicHide.MouseClickSoundResourcePath = ""
        abClassicHide.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abClassicHide.MouseEnterSound = ""
        abClassicHide.MouseEnterSoundResource = Nothing
        abClassicHide.MouseEnterSoundResourcePath = ""
        abClassicHide.Name = "abClassicHide"
        abClassicHide.ResizeTextFontOnResize = False
        abClassicHide.RoundedRadius = 5.0!
        abClassicHide.Shadow = False
        abClassicHide.ShadowAllWithMouseEnter = False
        abClassicHide.ShadowColor = System.Drawing.Color.Green
        abClassicHide.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abClassicHide.ShadowDivisor = 2
        abClassicHide.ShadowWithMouseEnter = False
        abClassicHide.ShiftAllOnClick = False
        abClassicHide.ShiftForeColor = System.Drawing.Color.DarkGreen
        abClassicHide.ShiftOnClick = False
        abClassicHide.ShiftShadowColor = System.Drawing.Color.Lime
        abClassicHide.ShowBorder = False
        abClassicHide.Size = New System.Drawing.Size(113, 21)
        abClassicHide.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abClassicHide.TabIndex = 30
        abClassicHide.Text = "< Classic Hide Mode"
        abClassicHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abClassicHide.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abClassicHide.TextShadowDisplacement = 1
        abClassicHide.UseCompatibleTextRendering = True
        '
        'abRunAtStartUp
        '
        abRunAtStartUp.Anchor = System.Windows.Forms.AnchorStyles.Top
        abRunAtStartUp.ClickHidesParent = False
        abRunAtStartUp.Color1 = System.Drawing.Color.Empty
        abRunAtStartUp.Color2 = System.Drawing.Color.Empty
        abRunAtStartUp.Cursor = System.Windows.Forms.Cursors.Hand
        abRunAtStartUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abRunAtStartUp.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abRunAtStartUp.HasRoundedRectangle = True
        abRunAtStartUp.HasSound = False
        abRunAtStartUp.LineSize = 2
        abRunAtStartUp.Location = New System.Drawing.Point(150, 99)
        abRunAtStartUp.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abRunAtStartUp.MouseClickSound = ""
        abRunAtStartUp.MouseClickSoundResource = Nothing
        abRunAtStartUp.MouseClickSoundResourcePath = ""
        abRunAtStartUp.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abRunAtStartUp.MouseEnterSound = ""
        abRunAtStartUp.MouseEnterSoundResource = Nothing
        abRunAtStartUp.MouseEnterSoundResourcePath = ""
        abRunAtStartUp.Name = "abRunAtStartUp"
        abRunAtStartUp.ResizeTextFontOnResize = False
        abRunAtStartUp.RoundedRadius = 5.0!
        abRunAtStartUp.Shadow = False
        abRunAtStartUp.ShadowAllWithMouseEnter = False
        abRunAtStartUp.ShadowColor = System.Drawing.Color.Green
        abRunAtStartUp.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abRunAtStartUp.ShadowDivisor = 2
        abRunAtStartUp.ShadowWithMouseEnter = False
        abRunAtStartUp.ShiftAllOnClick = False
        abRunAtStartUp.ShiftForeColor = System.Drawing.Color.DarkGreen
        abRunAtStartUp.ShiftOnClick = False
        abRunAtStartUp.ShiftShadowColor = System.Drawing.Color.Lime
        abRunAtStartUp.ShowBorder = False
        abRunAtStartUp.Size = New System.Drawing.Size(135, 21)
        abRunAtStartUp.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abRunAtStartUp.TabIndex = 28
        abRunAtStartUp.Text = "< Run At System StartUp"
        abRunAtStartUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abRunAtStartUp.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abRunAtStartUp.TextShadowDisplacement = 1
        abRunAtStartUp.UseCompatibleTextRendering = True
        '
        'abDosPauseChk
        '
        abDosPauseChk.Anchor = System.Windows.Forms.AnchorStyles.Top
        abDosPauseChk.ClickHidesParent = False
        abDosPauseChk.Color1 = System.Drawing.Color.Empty
        abDosPauseChk.Color2 = System.Drawing.Color.Empty
        abDosPauseChk.Cursor = System.Windows.Forms.Cursors.Hand
        abDosPauseChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abDosPauseChk.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abDosPauseChk.HasRoundedRectangle = True
        abDosPauseChk.HasSound = False
        abDosPauseChk.LineSize = 2
        abDosPauseChk.Location = New System.Drawing.Point(124, 117)
        abDosPauseChk.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abDosPauseChk.MouseClickSound = ""
        abDosPauseChk.MouseClickSoundResource = Nothing
        abDosPauseChk.MouseClickSoundResourcePath = ""
        abDosPauseChk.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abDosPauseChk.MouseEnterSound = ""
        abDosPauseChk.MouseEnterSoundResource = Nothing
        abDosPauseChk.MouseEnterSoundResourcePath = ""
        abDosPauseChk.Name = "abDosPauseChk"
        abDosPauseChk.ResizeTextFontOnResize = False
        abDosPauseChk.RoundedRadius = 5.0!
        abDosPauseChk.Shadow = False
        abDosPauseChk.ShadowAllWithMouseEnter = False
        abDosPauseChk.ShadowColor = System.Drawing.Color.Green
        abDosPauseChk.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abDosPauseChk.ShadowDivisor = 2
        abDosPauseChk.ShadowWithMouseEnter = False
        abDosPauseChk.ShiftAllOnClick = False
        abDosPauseChk.ShiftForeColor = System.Drawing.Color.DarkGreen
        abDosPauseChk.ShiftOnClick = False
        abDosPauseChk.ShiftShadowColor = System.Drawing.Color.Lime
        abDosPauseChk.ShowBorder = False
        abDosPauseChk.Size = New System.Drawing.Size(197, 21)
        abDosPauseChk.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abDosPauseChk.TabIndex = 26
        abDosPauseChk.Text = "< Don't Show DOS Pause Check Box "
        abDosPauseChk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abDosPauseChk.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abDosPauseChk.TextShadowDisplacement = 1
        abDosPauseChk.UseCompatibleTextRendering = True
        '
        'abStartHidden
        '
        abStartHidden.Anchor = System.Windows.Forms.AnchorStyles.Top
        abStartHidden.ClickHidesParent = False
        abStartHidden.Color1 = System.Drawing.Color.Empty
        abStartHidden.Color2 = System.Drawing.Color.Empty
        abStartHidden.Cursor = System.Windows.Forms.Cursors.Hand
        abStartHidden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abStartHidden.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abStartHidden.HasRoundedRectangle = True
        abStartHidden.HasSound = False
        abStartHidden.LineSize = 2
        abStartHidden.Location = New System.Drawing.Point(180, 135)
        abStartHidden.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abStartHidden.MouseClickSound = ""
        abStartHidden.MouseClickSoundResource = Nothing
        abStartHidden.MouseClickSoundResourcePath = ""
        abStartHidden.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abStartHidden.MouseEnterSound = ""
        abStartHidden.MouseEnterSoundResource = Nothing
        abStartHidden.MouseEnterSoundResourcePath = ""
        abStartHidden.Name = "abStartHidden"
        abStartHidden.ResizeTextFontOnResize = False
        abStartHidden.RoundedRadius = 5.0!
        abStartHidden.Shadow = False
        abStartHidden.ShadowAllWithMouseEnter = False
        abStartHidden.ShadowColor = System.Drawing.Color.Green
        abStartHidden.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abStartHidden.ShadowDivisor = 2
        abStartHidden.ShadowWithMouseEnter = False
        abStartHidden.ShiftAllOnClick = False
        abStartHidden.ShiftForeColor = System.Drawing.Color.DarkGreen
        abStartHidden.ShiftOnClick = False
        abStartHidden.ShiftShadowColor = System.Drawing.Color.Lime
        abStartHidden.ShowBorder = False
        abStartHidden.Size = New System.Drawing.Size(81, 21)
        abStartHidden.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abStartHidden.TabIndex = 25
        abStartHidden.Text = "< Start Hidden"
        abStartHidden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abStartHidden.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abStartHidden.TextShadowDisplacement = 1
        abStartHidden.UseCompatibleTextRendering = True
        '
        'abAbout
        '
        abAbout.Anchor = System.Windows.Forms.AnchorStyles.Top
        abAbout.ClickHidesParent = False
        abAbout.Color1 = System.Drawing.Color.Empty
        abAbout.Color2 = System.Drawing.Color.Empty
        abAbout.Cursor = System.Windows.Forms.Cursors.Hand
        abAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abAbout.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abAbout.HasRoundedRectangle = True
        abAbout.HasSound = False
        abAbout.LineSize = 2
        abAbout.Location = New System.Drawing.Point(25, 305)
        abAbout.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abAbout.MouseClickSound = ""
        abAbout.MouseClickSoundResource = Nothing
        abAbout.MouseClickSoundResourcePath = ""
        abAbout.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abAbout.MouseEnterSound = ""
        abAbout.MouseEnterSoundResource = Nothing
        abAbout.MouseEnterSoundResourcePath = ""
        abAbout.Name = "abAbout"
        abAbout.ResizeTextFontOnResize = False
        abAbout.RoundedRadius = 10.0!
        abAbout.Shadow = False
        abAbout.ShadowAllWithMouseEnter = False
        abAbout.ShadowColor = System.Drawing.Color.Green
        abAbout.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abAbout.ShadowDivisor = 2
        abAbout.ShadowWithMouseEnter = True
        abAbout.ShiftAllOnClick = False
        abAbout.ShiftForeColor = System.Drawing.Color.Green
        abAbout.ShiftOnClick = True
        abAbout.ShiftShadowColor = System.Drawing.Color.Lime
        abAbout.ShowBorder = True
        abAbout.Size = New System.Drawing.Size(176, 20)
        abAbout.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abAbout.TabIndex = 21
        abAbout.Text = "About And Help"
        abAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abAbout.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abAbout.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abAbout, "About And Help Window For BlackShellRunner")
        abAbout.UseCompatibleTextRendering = True
        '
        'abGraphics
        '
        abGraphics.Anchor = System.Windows.Forms.AnchorStyles.Top
        abGraphics.ClickHidesParent = False
        abGraphics.Color1 = System.Drawing.Color.Empty
        abGraphics.Color2 = System.Drawing.Color.Empty
        abGraphics.Cursor = System.Windows.Forms.Cursors.Hand
        abGraphics.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abGraphics.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abGraphics.HasRoundedRectangle = True
        abGraphics.HasSound = False
        abGraphics.LineSize = 2
        abGraphics.Location = New System.Drawing.Point(176, 153)
        abGraphics.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abGraphics.MouseClickSound = ""
        abGraphics.MouseClickSoundResource = Nothing
        abGraphics.MouseClickSoundResourcePath = ""
        abGraphics.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abGraphics.MouseEnterSound = ""
        abGraphics.MouseEnterSoundResource = Nothing
        abGraphics.MouseEnterSoundResourcePath = ""
        abGraphics.Name = "abGraphics"
        abGraphics.ResizeTextFontOnResize = False
        abGraphics.RoundedRadius = 5.0!
        abGraphics.Shadow = False
        abGraphics.ShadowAllWithMouseEnter = False
        abGraphics.ShadowColor = System.Drawing.Color.Green
        abGraphics.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abGraphics.ShadowDivisor = 2
        abGraphics.ShadowWithMouseEnter = False
        abGraphics.ShiftAllOnClick = False
        abGraphics.ShiftForeColor = System.Drawing.Color.DarkGreen
        abGraphics.ShiftOnClick = False
        abGraphics.ShiftShadowColor = System.Drawing.Color.Lime
        abGraphics.ShowBorder = False
        abGraphics.Size = New System.Drawing.Size(98, 21)
        abGraphics.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abGraphics.TabIndex = 20
        abGraphics.Text = "< Screen Graphics"
        abGraphics.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abGraphics.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abGraphics.TextShadowDisplacement = 1
        abGraphics.UseCompatibleTextRendering = True
        '
        'abSound
        '
        abSound.Anchor = System.Windows.Forms.AnchorStyles.Top
        abSound.ClickHidesParent = False
        abSound.Color1 = System.Drawing.Color.Empty
        abSound.Color2 = System.Drawing.Color.Empty
        abSound.Cursor = System.Windows.Forms.Cursors.Hand
        abSound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abSound.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abSound.HasRoundedRectangle = True
        abSound.HasSound = False
        abSound.LineSize = 2
        abSound.Location = New System.Drawing.Point(192, 171)
        abSound.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abSound.MouseClickSound = ""
        abSound.MouseClickSoundResource = Nothing
        abSound.MouseClickSoundResourcePath = ""
        abSound.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abSound.MouseEnterSound = ""
        abSound.MouseEnterSoundResource = Nothing
        abSound.MouseEnterSoundResourcePath = ""
        abSound.Name = "abSound"
        abSound.ResizeTextFontOnResize = False
        abSound.RoundedRadius = 5.0!
        abSound.Shadow = False
        abSound.ShadowAllWithMouseEnter = False
        abSound.ShadowColor = System.Drawing.Color.Green
        abSound.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abSound.ShadowDivisor = 2
        abSound.ShadowWithMouseEnter = False
        abSound.ShiftAllOnClick = False
        abSound.ShiftForeColor = System.Drawing.Color.DarkGreen
        abSound.ShiftOnClick = False
        abSound.ShiftShadowColor = System.Drawing.Color.Lime
        abSound.ShowBorder = False
        abSound.Size = New System.Drawing.Size(48, 21)
        abSound.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abSound.TabIndex = 19
        abSound.Text = "< Sound"
        abSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abSound.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abSound.TextShadowDisplacement = 1
        abSound.UseCompatibleTextRendering = True
        '
        'abTrans
        '
        abTrans.Anchor = System.Windows.Forms.AnchorStyles.Top
        abTrans.ClickHidesParent = False
        abTrans.Color1 = System.Drawing.Color.Empty
        abTrans.Color2 = System.Drawing.Color.Empty
        abTrans.Cursor = System.Windows.Forms.Cursors.Hand
        abTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abTrans.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abTrans.HasRoundedRectangle = True
        abTrans.HasSound = False
        abTrans.LineSize = 2
        abTrans.Location = New System.Drawing.Point(155, 283)
        abTrans.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abTrans.MouseClickSound = ""
        abTrans.MouseClickSoundResource = Nothing
        abTrans.MouseClickSoundResourcePath = ""
        abTrans.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abTrans.MouseEnterSound = ""
        abTrans.MouseEnterSoundResource = Nothing
        abTrans.MouseEnterSoundResourcePath = ""
        abTrans.Name = "abTrans"
        abTrans.ResizeTextFontOnResize = False
        abTrans.RoundedRadius = 5.0!
        abTrans.Shadow = False
        abTrans.ShadowAllWithMouseEnter = False
        abTrans.ShadowColor = System.Drawing.Color.Green
        abTrans.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abTrans.ShadowDivisor = 2
        abTrans.ShadowWithMouseEnter = False
        abTrans.ShiftAllOnClick = False
        abTrans.ShiftForeColor = System.Drawing.Color.DarkGreen
        abTrans.ShiftOnClick = False
        abTrans.ShiftShadowColor = System.Drawing.Color.Lime
        abTrans.ShowBorder = False
        abTrans.Size = New System.Drawing.Size(115, 21)
        abTrans.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abTrans.TabIndex = 18
        abTrans.Text = " ^ Transparency ^"
        abTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abTrans.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abTrans.TextShadowDisplacement = 1
        abTrans.UseCompatibleTextRendering = True
        '
        'abCstCmds
        '
        abCstCmds.Anchor = System.Windows.Forms.AnchorStyles.Top
        abCstCmds.ClickHidesParent = False
        abCstCmds.Color1 = System.Drawing.Color.Empty
        abCstCmds.Color2 = System.Drawing.Color.Empty
        abCstCmds.Cursor = System.Windows.Forms.Cursors.Hand
        abCstCmds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abCstCmds.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abCstCmds.HasRoundedRectangle = True
        abCstCmds.HasSound = False
        abCstCmds.LineSize = 2
        abCstCmds.Location = New System.Drawing.Point(223, 305)
        abCstCmds.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abCstCmds.MouseClickSound = ""
        abCstCmds.MouseClickSoundResource = Nothing
        abCstCmds.MouseClickSoundResourcePath = ""
        abCstCmds.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abCstCmds.MouseEnterSound = ""
        abCstCmds.MouseEnterSoundResource = Nothing
        abCstCmds.MouseEnterSoundResourcePath = ""
        abCstCmds.Name = "abCstCmds"
        abCstCmds.ResizeTextFontOnResize = False
        abCstCmds.RoundedRadius = 10.0!
        abCstCmds.Shadow = False
        abCstCmds.ShadowAllWithMouseEnter = False
        abCstCmds.ShadowColor = System.Drawing.Color.Green
        abCstCmds.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abCstCmds.ShadowDivisor = 2
        abCstCmds.ShadowWithMouseEnter = True
        abCstCmds.ShiftAllOnClick = False
        abCstCmds.ShiftForeColor = System.Drawing.Color.Green
        abCstCmds.ShiftOnClick = True
        abCstCmds.ShiftShadowColor = System.Drawing.Color.Lime
        abCstCmds.ShowBorder = True
        abCstCmds.Size = New System.Drawing.Size(189, 20)
        abCstCmds.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abCstCmds.TabIndex = 14
        abCstCmds.Text = "Custom Commands"
        abCstCmds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abCstCmds.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abCstCmds.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abCstCmds, "BlackShellRunner Custom Commands Window")
        abCstCmds.UseCompatibleTextRendering = True
        '
        'abHstry
        '
        abHstry.Anchor = System.Windows.Forms.AnchorStyles.Top
        abHstry.ClickHidesParent = False
        abHstry.Color1 = System.Drawing.Color.Empty
        abHstry.Color2 = System.Drawing.Color.Empty
        abHstry.Cursor = System.Windows.Forms.Cursors.Hand
        abHstry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abHstry.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abHstry.HasRoundedRectangle = True
        abHstry.HasSound = False
        abHstry.LineSize = 2
        abHstry.Location = New System.Drawing.Point(25, 335)
        abHstry.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abHstry.MouseClickSound = ""
        abHstry.MouseClickSoundResource = Nothing
        abHstry.MouseClickSoundResourcePath = ""
        abHstry.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abHstry.MouseEnterSound = ""
        abHstry.MouseEnterSoundResource = Nothing
        abHstry.MouseEnterSoundResourcePath = ""
        abHstry.Name = "abHstry"
        abHstry.ResizeTextFontOnResize = False
        abHstry.RoundedRadius = 10.0!
        abHstry.Shadow = False
        abHstry.ShadowAllWithMouseEnter = False
        abHstry.ShadowColor = System.Drawing.Color.Green
        abHstry.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abHstry.ShadowDivisor = 2
        abHstry.ShadowWithMouseEnter = True
        abHstry.ShiftAllOnClick = False
        abHstry.ShiftForeColor = System.Drawing.Color.Green
        abHstry.ShiftOnClick = True
        abHstry.ShiftShadowColor = System.Drawing.Color.Lime
        abHstry.ShowBorder = True
        abHstry.Size = New System.Drawing.Size(176, 20)
        abHstry.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abHstry.TabIndex = 13
        abHstry.Text = "History"
        abHstry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abHstry.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abHstry.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abHstry, "History Window")
        abHstry.UseCompatibleTextRendering = True
        '
        'abShadowColor
        '
        abShadowColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        abShadowColor.ClickHidesParent = False
        abShadowColor.Color1 = System.Drawing.Color.Empty
        abShadowColor.Color2 = System.Drawing.Color.Empty
        abShadowColor.Cursor = System.Windows.Forms.Cursors.Hand
        abShadowColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abShadowColor.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abShadowColor.HasRoundedRectangle = True
        abShadowColor.HasSound = False
        abShadowColor.LineSize = 2
        abShadowColor.Location = New System.Drawing.Point(103, 491)
        abShadowColor.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abShadowColor.MouseClickSound = ""
        abShadowColor.MouseClickSoundResource = Nothing
        abShadowColor.MouseClickSoundResourcePath = ""
        abShadowColor.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abShadowColor.MouseEnterSound = ""
        abShadowColor.MouseEnterSoundResource = Nothing
        abShadowColor.MouseEnterSoundResourcePath = ""
        abShadowColor.Name = "abShadowColor"
        abShadowColor.ResizeTextFontOnResize = False
        abShadowColor.RoundedRadius = 5.0!
        abShadowColor.Shadow = False
        abShadowColor.ShadowAllWithMouseEnter = False
        abShadowColor.ShadowColor = System.Drawing.Color.Green
        abShadowColor.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abShadowColor.ShadowDivisor = 2
        abShadowColor.ShadowWithMouseEnter = False
        abShadowColor.ShiftAllOnClick = False
        abShadowColor.ShiftForeColor = System.Drawing.Color.DarkGreen
        abShadowColor.ShiftOnClick = False
        abShadowColor.ShiftShadowColor = System.Drawing.Color.Lime
        abShadowColor.ShowBorder = False
        abShadowColor.Size = New System.Drawing.Size(86, 21)
        abShadowColor.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abShadowColor.TabIndex = 12
        abShadowColor.Text = "ShadowColor >"
        abShadowColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abShadowColor.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abShadowColor.TextShadowDisplacement = 1
        abShadowColor.UseCompatibleTextRendering = True
        '
        'abBackColor
        '
        abBackColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        abBackColor.ClickHidesParent = False
        abBackColor.Color1 = System.Drawing.Color.Empty
        abBackColor.Color2 = System.Drawing.Color.Empty
        abBackColor.Cursor = System.Windows.Forms.Cursors.Hand
        abBackColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abBackColor.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abBackColor.HasRoundedRectangle = True
        abBackColor.HasSound = False
        abBackColor.LineSize = 2
        abBackColor.Location = New System.Drawing.Point(233, 464)
        abBackColor.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBackColor.MouseClickSound = ""
        abBackColor.MouseClickSoundResource = Nothing
        abBackColor.MouseClickSoundResourcePath = ""
        abBackColor.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBackColor.MouseEnterSound = ""
        abBackColor.MouseEnterSoundResource = Nothing
        abBackColor.MouseEnterSoundResourcePath = ""
        abBackColor.Name = "abBackColor"
        abBackColor.ResizeTextFontOnResize = False
        abBackColor.RoundedRadius = 5.0!
        abBackColor.Shadow = False
        abBackColor.ShadowAllWithMouseEnter = False
        abBackColor.ShadowColor = System.Drawing.Color.Green
        abBackColor.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abBackColor.ShadowDivisor = 2
        abBackColor.ShadowWithMouseEnter = False
        abBackColor.ShiftAllOnClick = False
        abBackColor.ShiftForeColor = System.Drawing.Color.DarkGreen
        abBackColor.ShiftOnClick = False
        abBackColor.ShiftShadowColor = System.Drawing.Color.Lime
        abBackColor.ShowBorder = False
        abBackColor.Size = New System.Drawing.Size(64, 21)
        abBackColor.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBackColor.TabIndex = 11
        abBackColor.Text = "< BackColor "
        abBackColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBackColor.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBackColor.TextShadowDisplacement = 1
        abBackColor.UseCompatibleTextRendering = True
        '
        'abForeColor
        '
        abForeColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        abForeColor.ClickHidesParent = False
        abForeColor.Color1 = System.Drawing.Color.Empty
        abForeColor.Color2 = System.Drawing.Color.Empty
        abForeColor.Cursor = System.Windows.Forms.Cursors.Hand
        abForeColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abForeColor.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abForeColor.HasRoundedRectangle = True
        abForeColor.HasSound = False
        abForeColor.LineSize = 2
        abForeColor.Location = New System.Drawing.Point(121, 438)
        abForeColor.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abForeColor.MouseClickSound = ""
        abForeColor.MouseClickSoundResource = Nothing
        abForeColor.MouseClickSoundResourcePath = ""
        abForeColor.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abForeColor.MouseEnterSound = ""
        abForeColor.MouseEnterSoundResource = Nothing
        abForeColor.MouseEnterSoundResourcePath = ""
        abForeColor.Name = "abForeColor"
        abForeColor.ResizeTextFontOnResize = False
        abForeColor.RoundedRadius = 5.0!
        abForeColor.Shadow = False
        abForeColor.ShadowAllWithMouseEnter = False
        abForeColor.ShadowColor = System.Drawing.Color.Green
        abForeColor.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abForeColor.ShadowDivisor = 2
        abForeColor.ShadowWithMouseEnter = False
        abForeColor.ShiftAllOnClick = False
        abForeColor.ShiftForeColor = System.Drawing.Color.DarkGreen
        abForeColor.ShiftOnClick = False
        abForeColor.ShiftShadowColor = System.Drawing.Color.Lime
        abForeColor.ShowBorder = False
        abForeColor.Size = New System.Drawing.Size(64, 21)
        abForeColor.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abForeColor.TabIndex = 10
        abForeColor.Text = "ForeColor >"
        abForeColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abForeColor.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abForeColor.TextShadowDisplacement = 1
        abForeColor.UseCompatibleTextRendering = True
        '
        'abOk
        '
        abOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        abOk.ClickHidesParent = False
        abOk.Color1 = System.Drawing.Color.Empty
        abOk.Color2 = System.Drawing.Color.Empty
        abOk.Cursor = System.Windows.Forms.Cursors.Hand
        abOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abOk.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abOk.HasRoundedRectangle = True
        abOk.HasSound = False
        abOk.LineSize = 2
        abOk.Location = New System.Drawing.Point(159, 553)
        abOk.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abOk.MouseClickSound = ""
        abOk.MouseClickSoundResource = Nothing
        abOk.MouseClickSoundResourcePath = ""
        abOk.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abOk.MouseEnterSound = ""
        abOk.MouseEnterSoundResource = Nothing
        abOk.MouseEnterSoundResourcePath = ""
        abOk.Name = "abOk"
        abOk.ResizeTextFontOnResize = False
        abOk.RoundedRadius = 10.0!
        abOk.Shadow = False
        abOk.ShadowAllWithMouseEnter = True
        abOk.ShadowColor = System.Drawing.Color.Green
        abOk.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abOk.ShadowDivisor = 2
        abOk.ShadowWithMouseEnter = False
        abOk.ShiftAllOnClick = True
        abOk.ShiftForeColor = System.Drawing.Color.Green
        abOk.ShiftOnClick = False
        abOk.ShiftShadowColor = System.Drawing.Color.Lime
        abOk.ShowBorder = True
        abOk.Size = New System.Drawing.Size(103, 20)
        abOk.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abOk.TabIndex = 6
        abOk.Text = "Ok"
        abOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abOk.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abOk.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abOk, "OK")
        abOk.UseCompatibleTextRendering = True
        '
        'mcttMain
        '
        mcttMain.BackColor = System.Drawing.Color.Black
        mcttMain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        mcttMain.ForeColor = System.Drawing.Color.Lime
        mcttMain.OwnerDraw = True
        mcttMain.UseAnimation = False
        mcttMain.UseTransparentFading = True
        '
        'PicBackPic
        '
        PicBackPic.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        PicBackPic.BackColor = System.Drawing.Color.Black
        PicBackPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        PicBackPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PicBackPic.Cursor = System.Windows.Forms.Cursors.Hand
        PicBackPic.Location = New System.Drawing.Point(200, 517)
        PicBackPic.Name = "PicBackPic"
        PicBackPic.Size = New System.Drawing.Size(24, 25)
        PicBackPic.TabIndex = 46
        PicBackPic.TabStop = False
        mcttMain.SetToolTip(PicBackPic, "ShadowColor")
        '
        'tbPicOpacity
        '
        tbPicOpacity.Anchor = System.Windows.Forms.AnchorStyles.Top
        tbPicOpacity.BackColor = System.Drawing.Color.Black
        tbPicOpacity.Cursor = System.Windows.Forms.Cursors.Hand
        tbPicOpacity.LargeChange = 1
        tbPicOpacity.Location = New System.Drawing.Point(374, 137)
        tbPicOpacity.Maximum = 100
        tbPicOpacity.Name = "tbPicOpacity"
        tbPicOpacity.Orientation = System.Windows.Forms.Orientation.Vertical
        tbPicOpacity.Size = New System.Drawing.Size(45, 159)
        tbPicOpacity.TabIndex = 48
        tbPicOpacity.TickStyle = System.Windows.Forms.TickStyle.Both
        mcttMain.SetToolTip(tbPicOpacity, "How fast the main BSR window moves (up, down, left, right) on the screen when gra" &
        "phics are enabled")
        tbPicOpacity.Value = 50
        '
        'abMakeShellExtension
        '
        abMakeShellExtension.Anchor = System.Windows.Forms.AnchorStyles.Top
        abMakeShellExtension.ClickHidesParent = False
        abMakeShellExtension.Color1 = System.Drawing.Color.Empty
        abMakeShellExtension.Color2 = System.Drawing.Color.Empty
        abMakeShellExtension.Cursor = System.Windows.Forms.Cursors.Hand
        abMakeShellExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abMakeShellExtension.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abMakeShellExtension.HasRoundedRectangle = True
        abMakeShellExtension.HasSound = False
        abMakeShellExtension.LineSize = 2
        abMakeShellExtension.Location = New System.Drawing.Point(25, 365)
        abMakeShellExtension.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abMakeShellExtension.MouseClickSound = ""
        abMakeShellExtension.MouseClickSoundResource = Nothing
        abMakeShellExtension.MouseClickSoundResourcePath = ""
        abMakeShellExtension.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abMakeShellExtension.MouseEnterSound = ""
        abMakeShellExtension.MouseEnterSoundResource = Nothing
        abMakeShellExtension.MouseEnterSoundResourcePath = ""
        abMakeShellExtension.Name = "abMakeShellExtension"
        abMakeShellExtension.ResizeTextFontOnResize = False
        abMakeShellExtension.RoundedRadius = 10.0!
        abMakeShellExtension.Shadow = False
        abMakeShellExtension.ShadowAllWithMouseEnter = False
        abMakeShellExtension.ShadowColor = System.Drawing.Color.Green
        abMakeShellExtension.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abMakeShellExtension.ShadowDivisor = 2
        abMakeShellExtension.ShadowWithMouseEnter = True
        abMakeShellExtension.ShiftAllOnClick = False
        abMakeShellExtension.ShiftForeColor = System.Drawing.Color.Green
        abMakeShellExtension.ShiftOnClick = True
        abMakeShellExtension.ShiftShadowColor = System.Drawing.Color.Lime
        abMakeShellExtension.ShowBorder = True
        abMakeShellExtension.Size = New System.Drawing.Size(176, 20)
        abMakeShellExtension.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abMakeShellExtension.TabIndex = 53
        abMakeShellExtension.Text = "Make Shell Extension"
        abMakeShellExtension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abMakeShellExtension.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abMakeShellExtension.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abMakeShellExtension, "Make Shell Extension and associate STP File Extension")
        abMakeShellExtension.UseCompatibleTextRendering = True
        '
        'abINI
        '
        abINI.Anchor = System.Windows.Forms.AnchorStyles.Top
        abINI.ClickHidesParent = False
        abINI.Color1 = System.Drawing.Color.Empty
        abINI.Color2 = System.Drawing.Color.Empty
        abINI.Cursor = System.Windows.Forms.Cursors.Hand
        abINI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abINI.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abINI.HasRoundedRectangle = True
        abINI.HasSound = False
        abINI.LineSize = 2
        abINI.Location = New System.Drawing.Point(223, 365)
        abINI.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abINI.MouseClickSound = ""
        abINI.MouseClickSoundResource = Nothing
        abINI.MouseClickSoundResourcePath = ""
        abINI.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abINI.MouseEnterSound = ""
        abINI.MouseEnterSoundResource = Nothing
        abINI.MouseEnterSoundResourcePath = ""
        abINI.Name = "abINI"
        abINI.ResizeTextFontOnResize = False
        abINI.RoundedRadius = 10.0!
        abINI.Shadow = False
        abINI.ShadowAllWithMouseEnter = False
        abINI.ShadowColor = System.Drawing.Color.Green
        abINI.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abINI.ShadowDivisor = 2
        abINI.ShadowWithMouseEnter = True
        abINI.ShiftAllOnClick = False
        abINI.ShiftForeColor = System.Drawing.Color.Green
        abINI.ShiftOnClick = True
        abINI.ShiftShadowColor = System.Drawing.Color.Lime
        abINI.ShowBorder = True
        abINI.Size = New System.Drawing.Size(189, 20)
        abINI.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abINI.TabIndex = 54
        abINI.Text = "Open Config INI"
        abINI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abINI.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abINI.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abINI, "Open User Configuration File")
        abINI.UseCompatibleTextRendering = True
        '
        'abBSRDir
        '
        abBSRDir.Anchor = System.Windows.Forms.AnchorStyles.Top
        abBSRDir.ClickHidesParent = False
        abBSRDir.Color1 = System.Drawing.Color.Empty
        abBSRDir.Color2 = System.Drawing.Color.Empty
        abBSRDir.Cursor = System.Windows.Forms.Cursors.Hand
        abBSRDir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abBSRDir.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abBSRDir.HasRoundedRectangle = True
        abBSRDir.HasSound = False
        abBSRDir.LineSize = 2
        abBSRDir.Location = New System.Drawing.Point(117, 399)
        abBSRDir.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBSRDir.MouseClickSound = ""
        abBSRDir.MouseClickSoundResource = Nothing
        abBSRDir.MouseClickSoundResourcePath = ""
        abBSRDir.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBSRDir.MouseEnterSound = ""
        abBSRDir.MouseEnterSoundResource = Nothing
        abBSRDir.MouseEnterSoundResourcePath = ""
        abBSRDir.Name = "abBSRDir"
        abBSRDir.ResizeTextFontOnResize = False
        abBSRDir.RoundedRadius = 10.0!
        abBSRDir.Shadow = False
        abBSRDir.ShadowAllWithMouseEnter = False
        abBSRDir.ShadowColor = System.Drawing.Color.Green
        abBSRDir.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abBSRDir.ShadowDivisor = 2
        abBSRDir.ShadowWithMouseEnter = True
        abBSRDir.ShiftAllOnClick = False
        abBSRDir.ShiftForeColor = System.Drawing.Color.Green
        abBSRDir.ShiftOnClick = True
        abBSRDir.ShiftShadowColor = System.Drawing.Color.Lime
        abBSRDir.ShowBorder = True
        abBSRDir.Size = New System.Drawing.Size(189, 20)
        abBSRDir.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBSRDir.TabIndex = 55
        abBSRDir.Text = "Open BSR Directory"
        abBSRDir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBSRDir.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBSRDir.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abBSRDir, "Open User Configuration File")
        abBSRDir.UseCompatibleTextRendering = True
        '
        'colPicker
        '
        colPicker.AnyColor = True
        colPicker.FullOpen = True
        '
        'AcidButton1
        '
        AcidButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        AcidButton1.ClickHidesParent = False
        AcidButton1.Color1 = System.Drawing.Color.Empty
        AcidButton1.Color2 = System.Drawing.Color.Empty
        AcidButton1.Cursor = System.Windows.Forms.Cursors.Hand
        AcidButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AcidButton1.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        AcidButton1.HasRoundedRectangle = True
        AcidButton1.HasSound = False
        AcidButton1.LineSize = 2
        AcidButton1.Location = New System.Drawing.Point(234, 518)
        AcidButton1.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        AcidButton1.MouseClickSound = ""
        AcidButton1.MouseClickSoundResource = Nothing
        AcidButton1.MouseClickSoundResourcePath = ""
        AcidButton1.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        AcidButton1.MouseEnterSound = ""
        AcidButton1.MouseEnterSoundResource = Nothing
        AcidButton1.MouseEnterSoundResourcePath = ""
        AcidButton1.Name = "AcidButton1"
        AcidButton1.ResizeTextFontOnResize = False
        AcidButton1.RoundedRadius = 5.0!
        AcidButton1.Shadow = False
        AcidButton1.ShadowAllWithMouseEnter = False
        AcidButton1.ShadowColor = System.Drawing.Color.Green
        AcidButton1.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        AcidButton1.ShadowDivisor = 2
        AcidButton1.ShadowWithMouseEnter = False
        AcidButton1.ShiftAllOnClick = False
        AcidButton1.ShiftForeColor = System.Drawing.Color.DarkGreen
        AcidButton1.ShiftOnClick = False
        AcidButton1.ShiftShadowColor = System.Drawing.Color.Lime
        AcidButton1.ShowBorder = False
        AcidButton1.Size = New System.Drawing.Size(64, 21)
        AcidButton1.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        AcidButton1.TabIndex = 47
        AcidButton1.Text = "< Animation"
        AcidButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        AcidButton1.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        AcidButton1.TextShadowDisplacement = 1
        AcidButton1.UseCompatibleTextRendering = True
        '
        'ofdPic
        '
        ofdPic.Filter = "Gif Images Animations|*.gif"
        '
        'abPicLayerTrans
        '
        abPicLayerTrans.Anchor = System.Windows.Forms.AnchorStyles.Top
        abPicLayerTrans.ClickHidesParent = False
        abPicLayerTrans.Color1 = System.Drawing.Color.Empty
        abPicLayerTrans.Color2 = System.Drawing.Color.Empty
        abPicLayerTrans.Cursor = System.Windows.Forms.Cursors.Hand
        abPicLayerTrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abPicLayerTrans.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abPicLayerTrans.HasRoundedRectangle = True
        abPicLayerTrans.HasSound = False
        abPicLayerTrans.LineSize = 2
        abPicLayerTrans.Location = New System.Drawing.Point(357, 143)
        abPicLayerTrans.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abPicLayerTrans.MouseClickSound = ""
        abPicLayerTrans.MouseClickSoundResource = Nothing
        abPicLayerTrans.MouseClickSoundResourcePath = ""
        abPicLayerTrans.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abPicLayerTrans.MouseEnterSound = ""
        abPicLayerTrans.MouseEnterSoundResource = Nothing
        abPicLayerTrans.MouseEnterSoundResourcePath = ""
        abPicLayerTrans.Name = "abPicLayerTrans"
        abPicLayerTrans.ResizeTextFontOnResize = False
        abPicLayerTrans.RoundedRadius = 5.0!
        abPicLayerTrans.Shadow = False
        abPicLayerTrans.ShadowAllWithMouseEnter = False
        abPicLayerTrans.ShadowColor = System.Drawing.Color.Green
        abPicLayerTrans.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abPicLayerTrans.ShadowDivisor = 2
        abPicLayerTrans.ShadowWithMouseEnter = False
        abPicLayerTrans.ShiftAllOnClick = False
        abPicLayerTrans.ShiftForeColor = System.Drawing.Color.DarkGreen
        abPicLayerTrans.ShiftOnClick = False
        abPicLayerTrans.ShiftShadowColor = System.Drawing.Color.Lime
        abPicLayerTrans.ShowBorder = False
        abPicLayerTrans.Size = New System.Drawing.Size(13, 147)
        abPicLayerTrans.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abPicLayerTrans.TabIndex = 49
        abPicLayerTrans.Text = "^ Image Transparency ^"
        abPicLayerTrans.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abPicLayerTrans.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Vertical
        abPicLayerTrans.TextShadowDisplacement = 1
        abPicLayerTrans.UseCompatibleTextRendering = True
        '
        'chkPic
        '
        chkPic.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        chkPic.AutoSize = True
        chkPic.Enabled = False
        chkPic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        chkPic.ForeColor = System.Drawing.Color.Lime
        chkPic.Location = New System.Drawing.Point(161, 521)
        chkPic.Name = "chkPic"
        chkPic.Size = New System.Drawing.Size(37, 17)
        chkPic.TabIndex = 51
        chkPic.Text = " >"
        chkPic.UseVisualStyleBackColor = True
        '
        'abBrdr
        '
        abBrdr.ClickHidesParent = False
        abBrdr.Color1 = System.Drawing.Color.Empty
        abBrdr.Color2 = System.Drawing.Color.Empty
        abBrdr.Cursor = System.Windows.Forms.Cursors.Default
        abBrdr.Dock = System.Windows.Forms.DockStyle.Fill
        abBrdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abBrdr.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abBrdr.HasRoundedRectangle = True
        abBrdr.HasSound = False
        abBrdr.LineSize = 2
        abBrdr.Location = New System.Drawing.Point(0, 0)
        abBrdr.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abBrdr.MouseClickSound = ""
        abBrdr.MouseClickSoundResource = Nothing
        abBrdr.MouseClickSoundResourcePath = ""
        abBrdr.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abBrdr.MouseEnterSound = ""
        abBrdr.MouseEnterSoundResource = Nothing
        abBrdr.MouseEnterSoundResourcePath = ""
        abBrdr.Name = "abBrdr"
        abBrdr.ResizeTextFontOnResize = False
        abBrdr.RoundedRadius = 5.0!
        abBrdr.Shadow = False
        abBrdr.ShadowAllWithMouseEnter = False
        abBrdr.ShadowColor = System.Drawing.Color.Green
        abBrdr.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abBrdr.ShadowDivisor = 2
        abBrdr.ShadowWithMouseEnter = False
        abBrdr.ShiftAllOnClick = False
        abBrdr.ShiftForeColor = System.Drawing.Color.Green
        abBrdr.ShiftOnClick = False
        abBrdr.ShiftShadowColor = System.Drawing.Color.Lime
        abBrdr.ShowBorder = True
        abBrdr.Size = New System.Drawing.Size(434, 587)
        abBrdr.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBrdr.TabIndex = 56
        abBrdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBrdr.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBrdr.TextShadowDisplacement = 1
        abBrdr.UseCompatibleTextRendering = True
        '
        'colPicker2
        '
        colPicker2.AnyColor = True
        colPicker2.FullOpen = True
        '
        'colPicker3
        '
        colPicker3.AnyColor = True
        colPicker3.FullOpen = True
        '
        'frmOptions
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Black
        ClientSize = New System.Drawing.Size(434, 587)
        Controls.Add(abBSRDir)
        Controls.Add(abINI)
        Controls.Add(abMakeShellExtension)
        Controls.Add(PicBackPic)
        Controls.Add(chkPic)
        Controls.Add(abPicLayerTrans)
        Controls.Add(tbPicOpacity)
        Controls.Add(AcidButton1)
        Controls.Add(abMoveSpeed)
        Controls.Add(tbSpeed)
        Controls.Add(chkShowCorner)
        Controls.Add(abShowCorner)
        Controls.Add(chkSnap)
        Controls.Add(abSnap)
        Controls.Add(abConsole)
        Controls.Add(abFileOrList)
        Controls.Add(rbFileSystem)
        Controls.Add(rbListItems)
        Controls.Add(abAutoCompleteMode)
        Controls.Add(abGraphicStrength)
        Controls.Add(tbGraphicStrength)
        Controls.Add(abClassicHide)
        Controls.Add(chkClassicHide)
        Controls.Add(abRunAtStartUp)
        Controls.Add(chkRunAtStartUp)
        Controls.Add(abDosPauseChk)
        Controls.Add(abStartHidden)
        Controls.Add(chkStartHidden)
        Controls.Add(chkDOSPause)
        Controls.Add(abAbout)
        Controls.Add(abGraphics)
        Controls.Add(abSound)
        Controls.Add(abTrans)
        Controls.Add(tbTransparency)
        Controls.Add(chkSound)
        Controls.Add(chkGraphics)
        Controls.Add(abCstCmds)
        Controls.Add(abHstry)
        Controls.Add(abShadowColor)
        Controls.Add(abBackColor)
        Controls.Add(abForeColor)
        Controls.Add(picShadowColor)
        Controls.Add(picBackColor)
        Controls.Add(picForeColor)
        Controls.Add(abOk)
        Controls.Add(abBrdr)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmOptions"
        Opacity = 0.8R
        ShowInTaskbar = False
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "BlackShellRunner Options"
        CType(picShadowColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(picBackColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(picForeColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(tbTransparency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(tbGraphicStrength, System.ComponentModel.ISupportInitialize).EndInit()
        CType(tbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(PicBackPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(tbPicOpacity, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Protected Friend WithEvents picShadowColor As System.Windows.Forms.PictureBox
    Protected Friend WithEvents picBackColor As System.Windows.Forms.PictureBox
    Protected Friend WithEvents picForeColor As System.Windows.Forms.PictureBox
    Protected Friend WithEvents abOk As AcidControls.AcidButton
    Protected Friend WithEvents abForeColor As AcidControls.AcidButton
    Protected Friend WithEvents abBackColor As AcidControls.AcidButton
    Protected Friend WithEvents abShadowColor As AcidControls.AcidButton
    Protected Friend WithEvents abHstry As AcidControls.AcidButton
    Protected Friend WithEvents abCstCmds As AcidControls.AcidButton
    Protected Friend WithEvents chkGraphics As System.Windows.Forms.CheckBox
    Protected Friend WithEvents chkSound As System.Windows.Forms.CheckBox
    Protected Friend WithEvents tbTransparency As System.Windows.Forms.TrackBar
    Protected Friend WithEvents abTrans As AcidControls.AcidButton
    Protected Friend WithEvents abSound As AcidControls.AcidButton
    Protected Friend WithEvents abGraphics As AcidControls.AcidButton
    Protected Friend WithEvents abAbout As AcidControls.AcidButton
    Protected Friend WithEvents abDosPauseChk As AcidControls.AcidButton
    Protected Friend WithEvents abStartHidden As AcidControls.AcidButton
    Protected Friend WithEvents chkStartHidden As System.Windows.Forms.CheckBox
    Protected Friend WithEvents chkDOSPause As System.Windows.Forms.CheckBox
    Protected Friend WithEvents abRunAtStartUp As AcidControls.AcidButton
    Protected Friend WithEvents chkRunAtStartUp As System.Windows.Forms.CheckBox
    Protected Friend WithEvents chkClassicHide As System.Windows.Forms.CheckBox
    Protected Friend WithEvents abClassicHide As AcidControls.AcidButton
    Protected Friend WithEvents tbGraphicStrength As System.Windows.Forms.TrackBar
    Protected Friend WithEvents abGraphicStrength As AcidControls.AcidButton
    Protected Friend WithEvents abAutoCompleteMode As AcidControls.AcidButton
    Protected Friend WithEvents rbListItems As System.Windows.Forms.RadioButton
    Protected Friend WithEvents rbFileSystem As System.Windows.Forms.RadioButton
    Protected Friend WithEvents abFileOrList As AcidControls.AcidButton
    Protected Friend WithEvents abConsole As AcidControls.AcidButton
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip
    Protected Friend WithEvents abSnap As AcidControls.AcidButton
    Protected Friend WithEvents chkSnap As System.Windows.Forms.CheckBox
    Protected Friend WithEvents abShowCorner As AcidControls.AcidButton
    Protected Friend WithEvents chkShowCorner As System.Windows.Forms.CheckBox
    Protected Friend WithEvents tbSpeed As System.Windows.Forms.TrackBar
    Protected Friend WithEvents abMoveSpeed As AcidControls.AcidButton
    Private components As System.ComponentModel.IContainer
    Friend WithEvents colPicker As System.Windows.Forms.ColorDialog
    Protected Friend WithEvents PicBackPic As System.Windows.Forms.PictureBox
    Protected Friend WithEvents AcidButton1 As AcidControls.AcidButton
    Friend WithEvents ofdPic As System.Windows.Forms.OpenFileDialog
    Protected Friend WithEvents tbPicOpacity As System.Windows.Forms.TrackBar
    Protected Friend WithEvents abPicLayerTrans As AcidControls.AcidButton
    Friend WithEvents chkPic As CheckBox
    Protected Friend WithEvents abMakeShellExtension As AcidControls.AcidButton
    Protected Friend WithEvents abINI As AcidControls.AcidButton
    Protected Friend WithEvents abBSRDir As AcidControls.AcidButton
    Friend WithEvents abBrdr As AcidControls.AcidBorder
    Friend WithEvents colPicker2 As ColorDialog
    Friend WithEvents colPicker3 As ColorDialog
End Class
