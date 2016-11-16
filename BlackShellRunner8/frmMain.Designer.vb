<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        imglstIcons = New System.Windows.Forms.ImageList(components)
        tmrSetIcon = New System.Windows.Forms.Timer(components)
        picMain = New System.Windows.Forms.PictureBox()
        tmrInfo = New System.Windows.Forms.Timer(components)
        notico = New System.Windows.Forms.NotifyIcon(components)
        chkPws = New System.Windows.Forms.CheckBox()
        pnlResizeRightBottom = New System.Windows.Forms.Panel()
        tmrReturnTxt = New System.Windows.Forms.Timer(components)
        alHide = New AcidControls.AcidLabel()
        scrmrMain = New AcidControls.AcidScrollingMarquee()
        alDOSPause = New AcidControls.AcidButton()
        cmbCmd = New AcidControls.AcidComboBox()
        abSrch = New AcidControls.AcidButton()
        abOptns = New AcidControls.AcidButton()
        abBrws = New AcidControls.AcidButton()
        abRn = New AcidControls.AcidButton()
        abX = New AcidControls.AcidButton()
        mcttMain = New AcidControls.AcidToolTip(components)
        abBrdr = New AcidControls.AcidBorder()
        CType(picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'imglstIcons
        '
        imglstIcons.ImageStream = CType(resources.GetObject("imglstIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        imglstIcons.TransparentColor = System.Drawing.Color.Transparent
        imglstIcons.Images.SetKeyName(0, "folder_open.ico")
        imglstIcons.Images.SetKeyName(1, "Generic_Document.ico")
        imglstIcons.Images.SetKeyName(2, "cmd.ico")
        imglstIcons.Images.SetKeyName(3, "1382_cogs.ico")
        imglstIcons.Images.SetKeyName(4, "Folder_stuffed.ico")
        imglstIcons.Images.SetKeyName(5, "ControlPanel.ico")
        imglstIcons.Images.SetKeyName(6, "Drive.ico")
        imglstIcons.Images.SetKeyName(7, "PSIcon.ico")
        imglstIcons.Images.SetKeyName(8, "tile1.ico")
        imglstIcons.Images.SetKeyName(9, "tile2.ico")
        imglstIcons.Images.SetKeyName(10, "cas.ico")
        imglstIcons.Images.SetKeyName(11, "2uparrow.ico")
        imglstIcons.Images.SetKeyName(12, "2downarrow1.ico")
        imglstIcons.Images.SetKeyName(13, "shell32_14.ico")
        imglstIcons.Images.SetKeyName(14, "BlackShell.ico")
        '
        'tmrSetIcon
        '
        tmrSetIcon.Enabled = True
        tmrSetIcon.Interval = 10
        '
        'picMain
        '
        picMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        picMain.BackColor = System.Drawing.Color.Transparent
        picMain.Location = New System.Drawing.Point(7, 26)
        picMain.Name = "picMain"
        picMain.Size = New System.Drawing.Size(32, 32)
        picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        picMain.TabIndex = 24
        picMain.TabStop = False
        '
        'tmrInfo
        '
        tmrInfo.Enabled = True
        '
        'notico
        '
        notico.BalloonTipText = "Running"
        notico.BalloonTipTitle = "BlackShellRunner"
        notico.Icon = CType(resources.GetObject("notico.Icon"), System.Drawing.Icon)
        '
        'chkPws
        '
        chkPws.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        chkPws.AutoSize = True
        chkPws.BackColor = System.Drawing.Color.Black
        chkPws.Cursor = System.Windows.Forms.Cursors.Hand
        chkPws.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        chkPws.ForeColor = System.Drawing.Color.Lime
        chkPws.Location = New System.Drawing.Point(382, 7)
        chkPws.Name = "chkPws"
        chkPws.Size = New System.Drawing.Size(15, 14)
        chkPws.TabIndex = 32
        mcttMain.SetToolTip(chkPws, "Pause After MS-DOS Commands")
        chkPws.UseVisualStyleBackColor = False
        '
        'pnlResizeRightBottom
        '
        pnlResizeRightBottom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        pnlResizeRightBottom.BackColor = System.Drawing.Color.Black
        pnlResizeRightBottom.Cursor = System.Windows.Forms.Cursors.SizeNWSE
        pnlResizeRightBottom.Location = New System.Drawing.Point(605, 45)
        pnlResizeRightBottom.Name = "pnlResizeRightBottom"
        pnlResizeRightBottom.Size = New System.Drawing.Size(16, 16)
        pnlResizeRightBottom.TabIndex = 35
        '
        'tmrReturnTxt
        '
        '
        'alHide
        '
        alHide.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        alHide.ClickHidesParent = False
        alHide.Color1 = System.Drawing.Color.Empty
        alHide.Color2 = System.Drawing.Color.Empty
        alHide.Cursor = System.Windows.Forms.Cursors.Hand
        alHide.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        alHide.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        alHide.HasRoundedRectangle = True
        alHide.HasSound = False
        alHide.LineSize = 2
        alHide.Location = New System.Drawing.Point(592, 4)
        alHide.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        alHide.MouseClickSound = ""
        alHide.MouseClickSoundResource = Nothing
        alHide.MouseClickSoundResourcePath = ""
        alHide.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        alHide.MouseEnterSound = ""
        alHide.MouseEnterSoundResource = Nothing
        alHide.MouseEnterSoundResourcePath = ""
        alHide.Name = "alHide"
        alHide.ResizeTextFontOnResize = False
        alHide.RoundedRadius = 10.0!
        alHide.Shadow = False
        alHide.ShadowAllWithMouseEnter = True
        alHide.ShadowColor = System.Drawing.Color.Green
        alHide.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        alHide.ShadowDivisor = 2
        alHide.ShadowWithMouseEnter = True
        alHide.ShiftAllOnClick = True
        alHide.ShiftForeColor = System.Drawing.Color.Green
        alHide.ShiftOnClick = True
        alHide.ShiftShadowColor = System.Drawing.Color.Lime
        alHide.ShowBorder = True
        alHide.Size = New System.Drawing.Size(16, 15)
        alHide.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        alHide.TabIndex = 31
        alHide.Text = "_"
        alHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        alHide.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        alHide.TextShadowDisplacement = 1
        mcttMain.SetToolTip(alHide, "Hide BlackShellRunner")
        alHide.UseCompatibleTextRendering = True
        '
        'scrmrMain
        '
        scrmrMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        scrmrMain.DelaySeconds = 0.1R
        scrmrMain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        scrmrMain.GraphicSmoothingMode = AcidControls.modEnums.GraphicSmoothingMode.HighQualitySmoothing
        scrmrMain.Location = New System.Drawing.Point(44, 23)
        scrmrMain.MarqueeText = "Run PowerShell Program Path URL Or MS-DOS Command"
        scrmrMain.Name = "scrmrMain"
        scrmrMain.PixelsPerTick = 2
        scrmrMain.ResizeTextFontOnResize = True
        scrmrMain.Shadow = False
        scrmrMain.ShadowColor = System.Drawing.Color.Green
        scrmrMain.ShadowCornerPlacement = AcidControls.AcidScrollingMarquee.ShadowCorner.TopLeft
        scrmrMain.ShiftForeColor = System.Drawing.Color.Green
        scrmrMain.ShiftShadowColor = System.Drawing.Color.Lime
        scrmrMain.Size = New System.Drawing.Size(578, 12)
        scrmrMain.Stopped = True
        scrmrMain.StoppedTextOrientation = AcidControls.AcidScrollingMarquee.TextOrientation.Left
        scrmrMain.TabIndex = 30
        scrmrMain.TextShadowDisplacement = 1.0!
        '
        'alDOSPause
        '
        alDOSPause.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        alDOSPause.ClickHidesParent = False
        alDOSPause.Color1 = System.Drawing.Color.Empty
        alDOSPause.Color2 = System.Drawing.Color.Empty
        alDOSPause.Cursor = System.Windows.Forms.Cursors.Hand
        alDOSPause.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        alDOSPause.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        alDOSPause.HasRoundedRectangle = True
        alDOSPause.HasSound = False
        alDOSPause.LineSize = 2
        alDOSPause.Location = New System.Drawing.Point(399, 8)
        alDOSPause.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        alDOSPause.MouseClickSound = ""
        alDOSPause.MouseClickSoundResource = Nothing
        alDOSPause.MouseClickSoundResourcePath = ""
        alDOSPause.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        alDOSPause.MouseEnterSound = ""
        alDOSPause.MouseEnterSoundResource = Nothing
        alDOSPause.MouseEnterSoundResourcePath = ""
        alDOSPause.Name = "alDOSPause"
        alDOSPause.ResizeTextFontOnResize = False
        alDOSPause.RoundedRadius = 5.0!
        alDOSPause.Shadow = False
        alDOSPause.ShadowAllWithMouseEnter = False
        alDOSPause.ShadowColor = System.Drawing.Color.Green
        alDOSPause.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        alDOSPause.ShadowDivisor = 2
        alDOSPause.ShadowWithMouseEnter = False
        alDOSPause.ShiftAllOnClick = False
        alDOSPause.ShiftForeColor = System.Drawing.Color.Green
        alDOSPause.ShiftOnClick = False
        alDOSPause.ShiftShadowColor = System.Drawing.Color.Lime
        alDOSPause.ShowBorder = False
        alDOSPause.Size = New System.Drawing.Size(191, 10)
        alDOSPause.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        alDOSPause.TabIndex = 33
        alDOSPause.Text = "< Insert Pause After MS-DOS Commands"
        alDOSPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        alDOSPause.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        alDOSPause.TextShadowDisplacement = 1
        alDOSPause.UseCompatibleTextRendering = True
        '
        'cmbCmd
        '
        cmbCmd.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        cmbCmd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cmbCmd.ArrowKeysDropList = True
        cmbCmd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        cmbCmd.AutomaticallyMoveMouseCursorToMiddleOfComboOnListDropDown = True
        cmbCmd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        cmbCmd.DropDownHeight = 1000
        cmbCmd.DropDownWidth = 313
        cmbCmd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        cmbCmd.FocusRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dot
        cmbCmd.FormattingEnabled = True
        cmbCmd.IntegralHeight = False
        cmbCmd.ListSelectedItemRectanglement = True
        cmbCmd.Location = New System.Drawing.Point(43, 37)
        cmbCmd.MaxDropDownItems = 100
        cmbCmd.MaxLength = 50000
        cmbCmd.Name = "cmbCmd"
        cmbCmd.PasteMultilineJoiningCharacter = " "
        cmbCmd.QuantumItemRectanglement = False
        cmbCmd.RegularRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbCmd.RegularShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbCmd.SelectedItemFontStyle = System.Drawing.FontStyle.Bold
        cmbCmd.SelectedItemHasShadow = False
        cmbCmd.SelectedRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        cmbCmd.SelectedShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        cmbCmd.SelectionBackColor = System.Drawing.Color.Green
        cmbCmd.SelectionForeColor = System.Drawing.Color.Lime
        cmbCmd.Shadow = False
        cmbCmd.ShadowColor = System.Drawing.Color.Green
        cmbCmd.ShadowOnMouseEnter = False
        cmbCmd.ShiftForeColor = System.Drawing.Color.Green
        cmbCmd.ShiftOnClick = False
        cmbCmd.ShiftShadowColor = System.Drawing.Color.Lime
        cmbCmd.ShowExtenderToolTips = True
        cmbCmd.Size = New System.Drawing.Size(311, 21)
        cmbCmd.TabIndex = 0
        mcttMain.SetToolTip(cmbCmd, "Enter Your Command And Press Enter")
        '
        'abSrch
        '
        abSrch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abSrch.ClickHidesParent = False
        abSrch.Color1 = System.Drawing.Color.Empty
        abSrch.Color2 = System.Drawing.Color.Empty
        abSrch.Cursor = System.Windows.Forms.Cursors.Hand
        abSrch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abSrch.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abSrch.HasRoundedRectangle = True
        abSrch.HasSound = False
        abSrch.LineSize = 2
        abSrch.Location = New System.Drawing.Point(493, 37)
        abSrch.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abSrch.MouseClickSound = ""
        abSrch.MouseClickSoundResource = Nothing
        abSrch.MouseClickSoundResourcePath = ""
        abSrch.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abSrch.MouseEnterSound = ""
        abSrch.MouseEnterSoundResource = Nothing
        abSrch.MouseEnterSoundResourcePath = ""
        abSrch.Name = "abSrch"
        abSrch.ResizeTextFontOnResize = False
        abSrch.RoundedRadius = 10.0!
        abSrch.Shadow = False
        abSrch.ShadowAllWithMouseEnter = False
        abSrch.ShadowColor = System.Drawing.Color.Green
        abSrch.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abSrch.ShadowDivisor = 2
        abSrch.ShadowWithMouseEnter = True
        abSrch.ShiftAllOnClick = False
        abSrch.ShiftForeColor = System.Drawing.Color.Green
        abSrch.ShiftOnClick = True
        abSrch.ShiftShadowColor = System.Drawing.Color.Lime
        abSrch.ShowBorder = True
        abSrch.Size = New System.Drawing.Size(60, 21)
        abSrch.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abSrch.TabIndex = 29
        abSrch.Text = "Search"
        abSrch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abSrch.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abSrch.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abSrch, "Search For File")
        abSrch.UseCompatibleTextRendering = True
        '
        'abOptns
        '
        abOptns.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abOptns.ClickHidesParent = False
        abOptns.Color1 = System.Drawing.Color.Empty
        abOptns.Color2 = System.Drawing.Color.Empty
        abOptns.Cursor = System.Windows.Forms.Cursors.Hand
        abOptns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abOptns.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abOptns.HasRoundedRectangle = True
        abOptns.HasSound = False
        abOptns.LineSize = 2
        abOptns.Location = New System.Drawing.Point(559, 37)
        abOptns.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abOptns.MouseClickSound = ""
        abOptns.MouseClickSoundResource = Nothing
        abOptns.MouseClickSoundResourcePath = ""
        abOptns.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abOptns.MouseEnterSound = ""
        abOptns.MouseEnterSoundResource = Nothing
        abOptns.MouseEnterSoundResourcePath = ""
        abOptns.Name = "abOptns"
        abOptns.ResizeTextFontOnResize = False
        abOptns.RoundedRadius = 10.0!
        abOptns.Shadow = False
        abOptns.ShadowAllWithMouseEnter = False
        abOptns.ShadowColor = System.Drawing.Color.Green
        abOptns.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abOptns.ShadowDivisor = 2
        abOptns.ShadowWithMouseEnter = True
        abOptns.ShiftAllOnClick = False
        abOptns.ShiftForeColor = System.Drawing.Color.Green
        abOptns.ShiftOnClick = True
        abOptns.ShiftShadowColor = System.Drawing.Color.Lime
        abOptns.ShowBorder = True
        abOptns.Size = New System.Drawing.Size(60, 21)
        abOptns.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abOptns.TabIndex = 28
        abOptns.Text = "Options"
        abOptns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abOptns.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abOptns.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abOptns, "BlackShellRunner Options")
        abOptns.UseCompatibleTextRendering = True
        '
        'abBrws
        '
        abBrws.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abBrws.ClickHidesParent = False
        abBrws.Color1 = System.Drawing.Color.Empty
        abBrws.Color2 = System.Drawing.Color.Empty
        abBrws.Cursor = System.Windows.Forms.Cursors.Hand
        abBrws.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abBrws.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abBrws.HasRoundedRectangle = True
        abBrws.HasSound = False
        abBrws.LineSize = 2
        abBrws.Location = New System.Drawing.Point(426, 37)
        abBrws.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBrws.MouseClickSound = ""
        abBrws.MouseClickSoundResource = Nothing
        abBrws.MouseClickSoundResourcePath = ""
        abBrws.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBrws.MouseEnterSound = ""
        abBrws.MouseEnterSoundResource = Nothing
        abBrws.MouseEnterSoundResourcePath = ""
        abBrws.Name = "abBrws"
        abBrws.ResizeTextFontOnResize = False
        abBrws.RoundedRadius = 10.0!
        abBrws.Shadow = False
        abBrws.ShadowAllWithMouseEnter = False
        abBrws.ShadowColor = System.Drawing.Color.Green
        abBrws.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abBrws.ShadowDivisor = 2
        abBrws.ShadowWithMouseEnter = True
        abBrws.ShiftAllOnClick = False
        abBrws.ShiftForeColor = System.Drawing.Color.Green
        abBrws.ShiftOnClick = True
        abBrws.ShiftShadowColor = System.Drawing.Color.Lime
        abBrws.ShowBorder = True
        abBrws.Size = New System.Drawing.Size(60, 21)
        abBrws.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBrws.TabIndex = 26
        abBrws.Text = "Browse"
        abBrws.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBrws.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBrws.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abBrws, "Browse For File Or Folder")
        abBrws.UseCompatibleTextRendering = True
        '
        'abRn
        '
        abRn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abRn.ClickHidesParent = False
        abRn.Color1 = System.Drawing.Color.Empty
        abRn.Color2 = System.Drawing.Color.Empty
        abRn.Cursor = System.Windows.Forms.Cursors.Hand
        abRn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abRn.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abRn.HasRoundedRectangle = True
        abRn.HasSound = False
        abRn.LineSize = 2
        abRn.Location = New System.Drawing.Point(360, 37)
        abRn.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abRn.MouseClickSound = ""
        abRn.MouseClickSoundResource = Nothing
        abRn.MouseClickSoundResourcePath = ""
        abRn.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abRn.MouseEnterSound = ""
        abRn.MouseEnterSoundResource = Nothing
        abRn.MouseEnterSoundResourcePath = ""
        abRn.Name = "abRn"
        abRn.ResizeTextFontOnResize = False
        abRn.RoundedRadius = 10.0!
        abRn.Shadow = False
        abRn.ShadowAllWithMouseEnter = False
        abRn.ShadowColor = System.Drawing.Color.Green
        abRn.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abRn.ShadowDivisor = 2
        abRn.ShadowWithMouseEnter = True
        abRn.ShiftAllOnClick = False
        abRn.ShiftForeColor = System.Drawing.Color.Green
        abRn.ShiftOnClick = True
        abRn.ShiftShadowColor = System.Drawing.Color.Lime
        abRn.ShowBorder = True
        abRn.Size = New System.Drawing.Size(60, 21)
        abRn.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abRn.TabIndex = 25
        abRn.Text = "Run"
        abRn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abRn.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abRn.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abRn, "Run Program Path URL Or MS-DOS Command")
        abRn.UseCompatibleTextRendering = True
        '
        'abX
        '
        abX.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abX.ClickHidesParent = False
        abX.Color1 = System.Drawing.Color.Empty
        abX.Color2 = System.Drawing.Color.Empty
        abX.Cursor = System.Windows.Forms.Cursors.Hand
        abX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abX.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abX.HasRoundedRectangle = True
        abX.HasSound = False
        abX.LineSize = 2
        abX.Location = New System.Drawing.Point(609, 5)
        abX.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abX.MouseClickSound = ""
        abX.MouseClickSoundResource = Nothing
        abX.MouseClickSoundResourcePath = ""
        abX.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abX.MouseEnterSound = ""
        abX.MouseEnterSoundResource = Nothing
        abX.MouseEnterSoundResourcePath = ""
        abX.Name = "abX"
        abX.ResizeTextFontOnResize = False
        abX.RoundedRadius = 5.0!
        abX.Shadow = False
        abX.ShadowAllWithMouseEnter = True
        abX.ShadowColor = System.Drawing.Color.Green
        abX.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abX.ShadowDivisor = 2
        abX.ShadowWithMouseEnter = False
        abX.ShiftAllOnClick = True
        abX.ShiftForeColor = System.Drawing.Color.Green
        abX.ShiftOnClick = False
        abX.ShiftShadowColor = System.Drawing.Color.Lime
        abX.ShowBorder = False
        abX.Size = New System.Drawing.Size(13, 14)
        abX.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abX.TabIndex = 19
        abX.Tag = ""
        abX.Text = "X"
        abX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abX.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abX.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abX, "Exit BlackShellRunner")
        abX.UseCompatibleTextRendering = True
        '
        'mcttMain
        '
        mcttMain.BackColor = System.Drawing.Color.Black
        mcttMain.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        mcttMain.ForeColor = System.Drawing.Color.Lime
        mcttMain.OwnerDraw = True
        mcttMain.UseAnimation = False
        mcttMain.UseTransparentFading = True
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
        abBrdr.RoundedRadius = 10.0!
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
        abBrdr.Size = New System.Drawing.Size(627, 64)
        abBrdr.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBrdr.TabIndex = 36
        abBrdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBrdr.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBrdr.TextShadowDisplacement = 1
        abBrdr.UseCompatibleTextRendering = True
        '
        'frmMain
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Black
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        ClientSize = New System.Drawing.Size(627, 64)
        ControlBox = False
        Controls.Add(scrmrMain)
        Controls.Add(alDOSPause)
        Controls.Add(abOptns)
        Controls.Add(alHide)
        Controls.Add(pnlResizeRightBottom)
        Controls.Add(chkPws)
        Controls.Add(picMain)
        Controls.Add(cmbCmd)
        Controls.Add(abSrch)
        Controls.Add(abBrws)
        Controls.Add(abRn)
        Controls.Add(abX)
        Controls.Add(abBrdr)
        ForeColor = System.Drawing.Color.Lime
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        KeyPreview = True
        MaximizeBox = False
        MinimizeBox = False
        MinimumSize = New System.Drawing.Size(627, 64)
        Name = "frmMain"
        Opacity = 0.8R
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = System.Windows.Forms.FormStartPosition.Manual
        TopMost = True
        TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        CType(picMain, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Protected Friend WithEvents imglstIcons As System.Windows.Forms.ImageList
    Protected Friend WithEvents tmrSetIcon As System.Windows.Forms.Timer
    Protected Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Protected Friend WithEvents abRn As AcidControls.AcidButton
    Protected Friend WithEvents abBrws As AcidControls.AcidButton
    Protected Friend WithEvents abOptns As AcidControls.AcidButton
    Protected Friend WithEvents abSrch As AcidControls.AcidButton
    Protected Friend WithEvents scrmrMain As AcidControls.AcidScrollingMarquee
    Protected Friend WithEvents tmrInfo As System.Windows.Forms.Timer
    Protected Friend WithEvents notico As System.Windows.Forms.NotifyIcon
    Protected Friend WithEvents chkPws As System.Windows.Forms.CheckBox
    Protected Friend WithEvents cmbCmd As AcidControls.AcidComboBox
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip
    Protected Friend WithEvents alHide As AcidControls.AcidLabel
    Protected Friend WithEvents pnlResizeRightBottom As System.Windows.Forms.Panel
    Private components As System.ComponentModel.IContainer
    Protected Friend WithEvents tmrReturnTxt As System.Windows.Forms.Timer
    Friend WithEvents abBrdr As AcidControls.AcidBorder
    Protected Friend WithEvents abX As AcidControls.AcidButton
    Protected Friend WithEvents alDOSPause As AcidControls.AcidButton
End Class
