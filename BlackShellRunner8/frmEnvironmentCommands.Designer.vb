<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvironmentCommands
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnvironmentCommands))
        Me.rbDOS = New System.Windows.Forms.RadioButton()
        Me.rbPowerShell = New System.Windows.Forms.RadioButton()
        Me.tmrFindingCommands = New System.Windows.Forms.Timer(Me.components)
        Me.cdMain = New BSR.cmpConsoleDetective()
        Me.abCncl = New AcidControls.AcidButton()
        Me.alParams = New AcidControls.AcidButton()
        Me.abCmd = New AcidControls.AcidButton()
        Me.abTest = New AcidControls.AcidButton()
        Me.txtParams = New AcidControls.AcidTextBox()
        Me.txtSelected = New AcidControls.AcidTextBox()
        Me.abHelp = New AcidControls.AcidButton()
        Me.alPowerShellOrDOS = New AcidControls.AcidButton()
        Me.alConsoleMode = New AcidControls.AcidButton()
        Me.abOK = New AcidControls.AcidButton()
        Me.abEnvironmet = New AcidControls.AcidButton()
        Me.abParameters = New AcidControls.AcidButton()
        Me.mcttMain = New AcidControls.AcidToolTip(Me.components)
        Me.SuspendLayout()
        '
        'rbDOS
        '
        Me.rbDOS.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.rbDOS.AutoSize = True
        Me.rbDOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbDOS.ForeColor = System.Drawing.Color.Lime
        Me.rbDOS.Location = New System.Drawing.Point(639, 250)
        Me.rbDOS.Name = "rbDOS"
        Me.rbDOS.Size = New System.Drawing.Size(14, 13)
        Me.rbDOS.TabIndex = 41
        Me.mcttMain.SetToolTip(Me.rbDOS, "Open Checked With Parameters In MS-DOS")
        Me.rbDOS.UseCompatibleTextRendering = True
        Me.rbDOS.UseVisualStyleBackColor = True
        '
        'rbPowerShell
        '
        Me.rbPowerShell.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.rbPowerShell.AutoSize = True
        Me.rbPowerShell.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbPowerShell.ForeColor = System.Drawing.Color.Lime
        Me.rbPowerShell.Location = New System.Drawing.Point(234, 250)
        Me.rbPowerShell.Name = "rbPowerShell"
        Me.rbPowerShell.Size = New System.Drawing.Size(14, 13)
        Me.rbPowerShell.TabIndex = 42
        Me.mcttMain.SetToolTip(Me.rbPowerShell, "Open Checked With Parameters In PowerShell")
        Me.rbPowerShell.UseCompatibleTextRendering = True
        Me.rbPowerShell.UseVisualStyleBackColor = True
        '
        'tmrFindingCommands
        '
        '
        'cdMain
        '
        Me.cdMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cdMain.BackColor = System.Drawing.Color.Black
        Me.cdMain.CheckBoxes = True
        Me.cdMain.ForeColor = System.Drawing.Color.Lime
        Me.cdMain.Location = New System.Drawing.Point(13, 13)
        Me.cdMain.Name = "cdMain"
        Me.cdMain.Size = New System.Drawing.Size(857, 230)
        Me.cdMain.TabIndex = 0
        Me.mcttMain.SetToolTip(Me.cdMain, "Environment Commands")
        Me.cdMain.UseCompatibleStateImageBehavior = False
        '
        'abCncl
        '
        Me.abCncl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.abCncl.ClickHidesParent = False
        Me.abCncl.Color1 = System.Drawing.Color.Empty
        Me.abCncl.Color2 = System.Drawing.Color.Empty
        Me.abCncl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abCncl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abCncl.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.abCncl.HasRoundedRectangle = True
        Me.abCncl.HasSound = False
        Me.abCncl.LineSize = 2
        Me.abCncl.Location = New System.Drawing.Point(537, 330)
        Me.abCncl.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abCncl.MouseClickSound = ""
        Me.abCncl.MouseClickSoundResource = Nothing
        Me.abCncl.MouseClickSoundResourcePath = ""
        Me.abCncl.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abCncl.MouseEnterSound = ""
        Me.abCncl.MouseEnterSoundResource = Nothing
        Me.abCncl.MouseEnterSoundResourcePath = ""
        Me.abCncl.Name = "abCncl"
        Me.abCncl.ResizeTextFontOnResize = False
        Me.abCncl.RoundedRadius = 10.0!
        Me.abCncl.Shadow = False
        Me.abCncl.ShadowAllWithMouseEnter = False
        Me.abCncl.ShadowColor = System.Drawing.Color.Green
        Me.abCncl.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.abCncl.ShadowDivisor = 2
        Me.abCncl.ShadowWithMouseEnter = True
        Me.abCncl.ShiftAllOnClick = False
        Me.abCncl.ShiftForeColor = System.Drawing.Color.Green
        Me.abCncl.ShiftOnClick = True
        Me.abCncl.ShiftShadowColor = System.Drawing.Color.Lime
        Me.abCncl.ShowBorder = True
        Me.abCncl.Size = New System.Drawing.Size(61, 21)
        Me.abCncl.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.abCncl.TabIndex = 49
        Me.abCncl.Text = "Cancel"
        Me.abCncl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.abCncl.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.abCncl.TextShadowDisplacement = 1
        Me.mcttMain.SetToolTip(Me.abCncl, "OK")
        Me.abCncl.UseCompatibleTextRendering = True
        '
        'alParams
        '
        Me.alParams.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.alParams.ClickHidesParent = False
        Me.alParams.Color1 = System.Drawing.Color.Empty
        Me.alParams.Color2 = System.Drawing.Color.Empty
        Me.alParams.Cursor = System.Windows.Forms.Cursors.Hand
        Me.alParams.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alParams.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.alParams.HasRoundedRectangle = True
        Me.alParams.HasSound = False
        Me.alParams.LineSize = 2
        Me.alParams.Location = New System.Drawing.Point(309, 294)
        Me.alParams.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.alParams.MouseClickSound = ""
        Me.alParams.MouseClickSoundResource = Nothing
        Me.alParams.MouseClickSoundResourcePath = ""
        Me.alParams.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.alParams.MouseEnterSound = ""
        Me.alParams.MouseEnterSoundResource = Nothing
        Me.alParams.MouseEnterSoundResourcePath = ""
        Me.alParams.Name = "alParams"
        Me.alParams.ResizeTextFontOnResize = False
        Me.alParams.RoundedRadius = 5.0!
        Me.alParams.Shadow = False
        Me.alParams.ShadowAllWithMouseEnter = False
        Me.alParams.ShadowColor = System.Drawing.Color.Green
        Me.alParams.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.alParams.ShadowDivisor = 2
        Me.alParams.ShadowWithMouseEnter = False
        Me.alParams.ShiftAllOnClick = False
        Me.alParams.ShiftForeColor = System.Drawing.Color.DarkGreen
        Me.alParams.ShiftOnClick = False
        Me.alParams.ShiftShadowColor = System.Drawing.Color.Lime
        Me.alParams.ShowBorder = False
        Me.alParams.Size = New System.Drawing.Size(76, 14)
        Me.alParams.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.alParams.TabIndex = 48
        Me.alParams.Text = "Parameters >"
        Me.alParams.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.alParams.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.alParams.TextShadowDisplacement = 1
        Me.alParams.UseCompatibleTextRendering = True
        '
        'abCmd
        '
        Me.abCmd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.abCmd.ClickHidesParent = False
        Me.abCmd.Color1 = System.Drawing.Color.Empty
        Me.abCmd.Color2 = System.Drawing.Color.Empty
        Me.abCmd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abCmd.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.abCmd.HasRoundedRectangle = True
        Me.abCmd.HasSound = False
        Me.abCmd.LineSize = 2
        Me.abCmd.Location = New System.Drawing.Point(12, 294)
        Me.abCmd.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abCmd.MouseClickSound = ""
        Me.abCmd.MouseClickSoundResource = Nothing
        Me.abCmd.MouseClickSoundResourcePath = ""
        Me.abCmd.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abCmd.MouseEnterSound = ""
        Me.abCmd.MouseEnterSoundResource = Nothing
        Me.abCmd.MouseEnterSoundResourcePath = ""
        Me.abCmd.Name = "abCmd"
        Me.abCmd.ResizeTextFontOnResize = False
        Me.abCmd.RoundedRadius = 5.0!
        Me.abCmd.Shadow = False
        Me.abCmd.ShadowAllWithMouseEnter = False
        Me.abCmd.ShadowColor = System.Drawing.Color.Green
        Me.abCmd.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.abCmd.ShadowDivisor = 2
        Me.abCmd.ShadowWithMouseEnter = False
        Me.abCmd.ShiftAllOnClick = False
        Me.abCmd.ShiftForeColor = System.Drawing.Color.DarkGreen
        Me.abCmd.ShiftOnClick = False
        Me.abCmd.ShiftShadowColor = System.Drawing.Color.Lime
        Me.abCmd.ShowBorder = False
        Me.abCmd.Size = New System.Drawing.Size(71, 14)
        Me.abCmd.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.abCmd.TabIndex = 47
        Me.abCmd.Text = "Command >"
        Me.abCmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.abCmd.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.abCmd.TextShadowDisplacement = 1
        Me.abCmd.UseCompatibleTextRendering = True
        '
        'abTest
        '
        Me.abTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.abTest.ClickHidesParent = False
        Me.abTest.Color1 = System.Drawing.Color.Empty
        Me.abTest.Color2 = System.Drawing.Color.Empty
        Me.abTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abTest.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.abTest.HasRoundedRectangle = True
        Me.abTest.HasSound = False
        Me.abTest.LineSize = 2
        Me.abTest.Location = New System.Drawing.Point(802, 291)
        Me.abTest.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abTest.MouseClickSound = ""
        Me.abTest.MouseClickSoundResource = Nothing
        Me.abTest.MouseClickSoundResourcePath = ""
        Me.abTest.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abTest.MouseEnterSound = ""
        Me.abTest.MouseEnterSoundResource = Nothing
        Me.abTest.MouseEnterSoundResourcePath = ""
        Me.abTest.Name = "abTest"
        Me.abTest.ResizeTextFontOnResize = False
        Me.abTest.RoundedRadius = 10.0!
        Me.abTest.Shadow = False
        Me.abTest.ShadowAllWithMouseEnter = False
        Me.abTest.ShadowColor = System.Drawing.Color.Green
        Me.abTest.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.abTest.ShadowDivisor = 2
        Me.abTest.ShadowWithMouseEnter = True
        Me.abTest.ShiftAllOnClick = False
        Me.abTest.ShiftForeColor = System.Drawing.Color.Green
        Me.abTest.ShiftOnClick = True
        Me.abTest.ShiftShadowColor = System.Drawing.Color.Lime
        Me.abTest.ShowBorder = True
        Me.abTest.Size = New System.Drawing.Size(68, 21)
        Me.abTest.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.abTest.TabIndex = 46
        Me.abTest.Text = "Test"
        Me.abTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.abTest.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.abTest.TextShadowDisplacement = 1
        Me.mcttMain.SetToolTip(Me.abTest, "Test Command")
        Me.abTest.UseCompatibleTextRendering = True
        '
        'txtParams
        '
        Me.txtParams.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtParams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtParams.LineSize = 2
        Me.txtParams.Location = New System.Drawing.Point(391, 290)
        Me.txtParams.Name = "txtParams"
        Me.txtParams.PasteMultilineJoiningCharacter = " "
        Me.txtParams.Shadow = False
        Me.txtParams.ShadowColor = System.Drawing.Color.Green
        Me.txtParams.ShadowDivisor = 2
        Me.txtParams.ShadowOnMouseEnter = False
        Me.txtParams.ShiftForeColor = System.Drawing.Color.Green
        Me.txtParams.ShiftOnClick = False
        Me.txtParams.ShiftShadowColor = System.Drawing.Color.Lime
        Me.txtParams.Size = New System.Drawing.Size(405, 20)
        Me.txtParams.TabIndex = 45
        Me.mcttMain.SetToolTip(Me.txtParams, "Parameters To Test")
        '
        'txtSelected
        '
        Me.txtSelected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSelected.LineSize = 2
        Me.txtSelected.Location = New System.Drawing.Point(89, 291)
        Me.txtSelected.Name = "txtSelected"
        Me.txtSelected.PasteMultilineJoiningCharacter = " "
        Me.txtSelected.Shadow = False
        Me.txtSelected.ShadowColor = System.Drawing.Color.Green
        Me.txtSelected.ShadowDivisor = 2
        Me.txtSelected.ShadowOnMouseEnter = False
        Me.txtSelected.ShiftForeColor = System.Drawing.Color.Green
        Me.txtSelected.ShiftOnClick = False
        Me.txtSelected.ShiftShadowColor = System.Drawing.Color.Lime
        Me.txtSelected.Size = New System.Drawing.Size(140, 20)
        Me.txtSelected.TabIndex = 44
        Me.mcttMain.SetToolTip(Me.txtSelected, "Command")
        '
        'abHelp
        '
        Me.abHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.abHelp.ClickHidesParent = False
        Me.abHelp.Color1 = System.Drawing.Color.Empty
        Me.abHelp.Color2 = System.Drawing.Color.Empty
        Me.abHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abHelp.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.abHelp.HasRoundedRectangle = True
        Me.abHelp.HasSound = False
        Me.abHelp.LineSize = 2
        Me.abHelp.Location = New System.Drawing.Point(235, 290)
        Me.abHelp.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abHelp.MouseClickSound = ""
        Me.abHelp.MouseClickSoundResource = Nothing
        Me.abHelp.MouseClickSoundResourcePath = ""
        Me.abHelp.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abHelp.MouseEnterSound = ""
        Me.abHelp.MouseEnterSoundResource = Nothing
        Me.abHelp.MouseEnterSoundResourcePath = ""
        Me.abHelp.Name = "abHelp"
        Me.abHelp.ResizeTextFontOnResize = False
        Me.abHelp.RoundedRadius = 10.0!
        Me.abHelp.Shadow = False
        Me.abHelp.ShadowAllWithMouseEnter = False
        Me.abHelp.ShadowColor = System.Drawing.Color.Green
        Me.abHelp.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.abHelp.ShadowDivisor = 2
        Me.abHelp.ShadowWithMouseEnter = True
        Me.abHelp.ShiftAllOnClick = False
        Me.abHelp.ShiftForeColor = System.Drawing.Color.Green
        Me.abHelp.ShiftOnClick = True
        Me.abHelp.ShiftShadowColor = System.Drawing.Color.Lime
        Me.abHelp.ShowBorder = True
        Me.abHelp.Size = New System.Drawing.Size(68, 21)
        Me.abHelp.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.abHelp.TabIndex = 43
        Me.abHelp.Text = "Help"
        Me.abHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.abHelp.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.abHelp.TextShadowDisplacement = 1
        Me.mcttMain.SetToolTip(Me.abHelp, "Help With This Command")
        Me.abHelp.UseCompatibleTextRendering = True
        '
        'alPowerShellOrDOS
        '
        Me.alPowerShellOrDOS.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.alPowerShellOrDOS.ClickHidesParent = False
        Me.alPowerShellOrDOS.Color1 = System.Drawing.Color.Empty
        Me.alPowerShellOrDOS.Color2 = System.Drawing.Color.Empty
        Me.alPowerShellOrDOS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.alPowerShellOrDOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alPowerShellOrDOS.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.alPowerShellOrDOS.HasRoundedRectangle = True
        Me.alPowerShellOrDOS.HasSound = False
        Me.alPowerShellOrDOS.LineSize = 2
        Me.alPowerShellOrDOS.Location = New System.Drawing.Point(260, 248)
        Me.alPowerShellOrDOS.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.alPowerShellOrDOS.MouseClickSound = ""
        Me.alPowerShellOrDOS.MouseClickSoundResource = Nothing
        Me.alPowerShellOrDOS.MouseClickSoundResourcePath = ""
        Me.alPowerShellOrDOS.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.alPowerShellOrDOS.MouseEnterSound = ""
        Me.alPowerShellOrDOS.MouseEnterSoundResource = Nothing
        Me.alPowerShellOrDOS.MouseEnterSoundResourcePath = ""
        Me.alPowerShellOrDOS.Name = "alPowerShellOrDOS"
        Me.alPowerShellOrDOS.ResizeTextFontOnResize = False
        Me.alPowerShellOrDOS.RoundedRadius = 5.0!
        Me.alPowerShellOrDOS.Shadow = False
        Me.alPowerShellOrDOS.ShadowAllWithMouseEnter = False
        Me.alPowerShellOrDOS.ShadowColor = System.Drawing.Color.Green
        Me.alPowerShellOrDOS.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.alPowerShellOrDOS.ShadowDivisor = 2
        Me.alPowerShellOrDOS.ShadowWithMouseEnter = False
        Me.alPowerShellOrDOS.ShiftAllOnClick = False
        Me.alPowerShellOrDOS.ShiftForeColor = System.Drawing.Color.DarkGreen
        Me.alPowerShellOrDOS.ShiftOnClick = False
        Me.alPowerShellOrDOS.ShiftShadowColor = System.Drawing.Color.Lime
        Me.alPowerShellOrDOS.ShowBorder = False
        Me.alPowerShellOrDOS.Size = New System.Drawing.Size(362, 17)
        Me.alPowerShellOrDOS.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.alPowerShellOrDOS.TabIndex = 40
        Me.alPowerShellOrDOS.Text = "<                                PowerShell | MS-DOS                             " &
    "       >"
        Me.alPowerShellOrDOS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.alPowerShellOrDOS.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.alPowerShellOrDOS.TextShadowDisplacement = 1
        Me.alPowerShellOrDOS.UseCompatibleTextRendering = True
        '
        'alConsoleMode
        '
        Me.alConsoleMode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.alConsoleMode.ClickHidesParent = False
        Me.alConsoleMode.Color1 = System.Drawing.Color.Empty
        Me.alConsoleMode.Color2 = System.Drawing.Color.Empty
        Me.alConsoleMode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.alConsoleMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alConsoleMode.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.alConsoleMode.HasRoundedRectangle = True
        Me.alConsoleMode.HasSound = False
        Me.alConsoleMode.LineSize = 2
        Me.alConsoleMode.Location = New System.Drawing.Point(12, 267)
        Me.alConsoleMode.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.alConsoleMode.MouseClickSound = ""
        Me.alConsoleMode.MouseClickSoundResource = Nothing
        Me.alConsoleMode.MouseClickSoundResourcePath = ""
        Me.alConsoleMode.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.alConsoleMode.MouseEnterSound = ""
        Me.alConsoleMode.MouseEnterSoundResource = Nothing
        Me.alConsoleMode.MouseEnterSoundResourcePath = ""
        Me.alConsoleMode.Name = "alConsoleMode"
        Me.alConsoleMode.ResizeTextFontOnResize = False
        Me.alConsoleMode.RoundedRadius = 5.0!
        Me.alConsoleMode.Shadow = False
        Me.alConsoleMode.ShadowAllWithMouseEnter = False
        Me.alConsoleMode.ShadowColor = System.Drawing.Color.Green
        Me.alConsoleMode.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.alConsoleMode.ShadowDivisor = 2
        Me.alConsoleMode.ShadowWithMouseEnter = False
        Me.alConsoleMode.ShiftAllOnClick = False
        Me.alConsoleMode.ShiftForeColor = System.Drawing.Color.DarkGreen
        Me.alConsoleMode.ShiftOnClick = False
        Me.alConsoleMode.ShiftShadowColor = System.Drawing.Color.Lime
        Me.alConsoleMode.ShowBorder = False
        Me.alConsoleMode.Size = New System.Drawing.Size(858, 14)
        Me.alConsoleMode.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.alConsoleMode.TabIndex = 39
        Me.alConsoleMode.Text = "^ I would like to open checked console commands that have parameters with ^"
        Me.alConsoleMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.alConsoleMode.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.alConsoleMode.TextShadowDisplacement = 1
        Me.alConsoleMode.UseCompatibleTextRendering = True
        '
        'abOK
        '
        Me.abOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.abOK.ClickHidesParent = False
        Me.abOK.Color1 = System.Drawing.Color.Empty
        Me.abOK.Color2 = System.Drawing.Color.Empty
        Me.abOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abOK.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.abOK.HasRoundedRectangle = True
        Me.abOK.HasSound = False
        Me.abOK.LineSize = 2
        Me.abOK.Location = New System.Drawing.Point(470, 330)
        Me.abOK.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abOK.MouseClickSound = ""
        Me.abOK.MouseClickSoundResource = Nothing
        Me.abOK.MouseClickSoundResourcePath = ""
        Me.abOK.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abOK.MouseEnterSound = ""
        Me.abOK.MouseEnterSoundResource = Nothing
        Me.abOK.MouseEnterSoundResourcePath = ""
        Me.abOK.Name = "abOK"
        Me.abOK.ResizeTextFontOnResize = False
        Me.abOK.RoundedRadius = 10.0!
        Me.abOK.Shadow = False
        Me.abOK.ShadowAllWithMouseEnter = False
        Me.abOK.ShadowColor = System.Drawing.Color.Green
        Me.abOK.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.abOK.ShadowDivisor = 2
        Me.abOK.ShadowWithMouseEnter = True
        Me.abOK.ShiftAllOnClick = False
        Me.abOK.ShiftForeColor = System.Drawing.Color.Green
        Me.abOK.ShiftOnClick = True
        Me.abOK.ShiftShadowColor = System.Drawing.Color.Lime
        Me.abOK.ShowBorder = True
        Me.abOK.Size = New System.Drawing.Size(61, 21)
        Me.abOK.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.abOK.TabIndex = 38
        Me.abOK.Text = "OK"
        Me.abOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.abOK.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.abOK.TextShadowDisplacement = 1
        Me.mcttMain.SetToolTip(Me.abOK, "OK")
        Me.abOK.UseCompatibleTextRendering = True
        '
        'abEnvironmet
        '
        Me.abEnvironmet.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.abEnvironmet.ClickHidesParent = False
        Me.abEnvironmet.Color1 = System.Drawing.Color.Empty
        Me.abEnvironmet.Color2 = System.Drawing.Color.Empty
        Me.abEnvironmet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abEnvironmet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abEnvironmet.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.abEnvironmet.HasRoundedRectangle = True
        Me.abEnvironmet.HasSound = False
        Me.abEnvironmet.LineSize = 2
        Me.abEnvironmet.Location = New System.Drawing.Point(283, 330)
        Me.abEnvironmet.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abEnvironmet.MouseClickSound = ""
        Me.abEnvironmet.MouseClickSoundResource = Nothing
        Me.abEnvironmet.MouseClickSoundResourcePath = ""
        Me.abEnvironmet.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abEnvironmet.MouseEnterSound = ""
        Me.abEnvironmet.MouseEnterSoundResource = Nothing
        Me.abEnvironmet.MouseEnterSoundResourcePath = ""
        Me.abEnvironmet.Name = "abEnvironmet"
        Me.abEnvironmet.ResizeTextFontOnResize = False
        Me.abEnvironmet.RoundedRadius = 10.0!
        Me.abEnvironmet.Shadow = False
        Me.abEnvironmet.ShadowAllWithMouseEnter = False
        Me.abEnvironmet.ShadowColor = System.Drawing.Color.Green
        Me.abEnvironmet.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.abEnvironmet.ShadowDivisor = 2
        Me.abEnvironmet.ShadowWithMouseEnter = True
        Me.abEnvironmet.ShiftAllOnClick = False
        Me.abEnvironmet.ShiftForeColor = System.Drawing.Color.Green
        Me.abEnvironmet.ShiftOnClick = True
        Me.abEnvironmet.ShiftShadowColor = System.Drawing.Color.Lime
        Me.abEnvironmet.ShowBorder = True
        Me.abEnvironmet.Size = New System.Drawing.Size(181, 21)
        Me.abEnvironmet.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.abEnvironmet.TabIndex = 36
        Me.abEnvironmet.Text = "Set Environment Variables"
        Me.abEnvironmet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.abEnvironmet.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.abEnvironmet.TextShadowDisplacement = 1
        Me.mcttMain.SetToolTip(Me.abEnvironmet, "Open Environment Variables Dialog")
        Me.abEnvironmet.UseCompatibleTextRendering = True
        '
        'abParameters
        '
        Me.abParameters.ClickHidesParent = False
        Me.abParameters.Color1 = System.Drawing.Color.Empty
        Me.abParameters.Color2 = System.Drawing.Color.Empty
        Me.abParameters.Cursor = System.Windows.Forms.Cursors.Hand
        Me.abParameters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.abParameters.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.abParameters.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.abParameters.HasRoundedRectangle = True
        Me.abParameters.HasSound = False
        Me.abParameters.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.abParameters.LineSize = 2
        Me.abParameters.Location = New System.Drawing.Point(0, 0)
        Me.abParameters.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abParameters.MouseClickSound = ""
        Me.abParameters.MouseClickSoundResource = Nothing
        Me.abParameters.MouseClickSoundResourcePath = ""
        Me.abParameters.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        Me.abParameters.MouseEnterSound = ""
        Me.abParameters.MouseEnterSoundResource = Nothing
        Me.abParameters.MouseEnterSoundResourcePath = ""
        Me.abParameters.Name = "abParameters"
        Me.abParameters.ResizeTextFontOnResize = False
        Me.abParameters.RoundedRadius = 5.0!
        Me.abParameters.Shadow = False
        Me.abParameters.ShadowAllWithMouseEnter = False
        Me.abParameters.ShadowColor = System.Drawing.Color.Green
        Me.abParameters.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.abParameters.ShadowDivisor = 2
        Me.abParameters.ShadowWithMouseEnter = False
        Me.abParameters.ShiftAllOnClick = False
        Me.abParameters.ShiftForeColor = System.Drawing.Color.Green
        Me.abParameters.ShiftOnClick = False
        Me.abParameters.ShiftShadowColor = System.Drawing.Color.Lime
        Me.abParameters.ShowBorder = True
        Me.abParameters.Size = New System.Drawing.Size(882, 360)
        Me.abParameters.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.abParameters.TabIndex = 34
        Me.abParameters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.abParameters.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.abParameters.TextShadowDisplacement = 1
        Me.abParameters.UseCompatibleTextRendering = True
        '
        'mcttMain
        '
        Me.mcttMain.BackColor = System.Drawing.Color.Black
        Me.mcttMain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        Me.mcttMain.ForeColor = System.Drawing.Color.Lime
        Me.mcttMain.OwnerDraw = True
        Me.mcttMain.UseAnimation = False
        Me.mcttMain.UseTransparentFading = True
        '
        'frmEnvironmentCommands
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(882, 360)
        Me.Controls.Add(Me.abCncl)
        Me.Controls.Add(Me.alParams)
        Me.Controls.Add(Me.abCmd)
        Me.Controls.Add(Me.abTest)
        Me.Controls.Add(Me.txtParams)
        Me.Controls.Add(Me.txtSelected)
        Me.Controls.Add(Me.abHelp)
        Me.Controls.Add(Me.rbPowerShell)
        Me.Controls.Add(Me.rbDOS)
        Me.Controls.Add(Me.alPowerShellOrDOS)
        Me.Controls.Add(Me.alConsoleMode)
        Me.Controls.Add(Me.abOK)
        Me.Controls.Add(Me.abEnvironmet)
        Me.Controls.Add(Me.cdMain)
        Me.Controls.Add(Me.abParameters)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmEnvironmentCommands"
        Me.ShowInTaskbar = False
        Me.Text = "Machine Level Environment Commands"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected Friend WithEvents cdMain As BSR.cmpConsoleDetective
    Protected Friend WithEvents abParameters As AcidControls.AcidButton
    Protected Friend WithEvents abEnvironmet As AcidControls.AcidButton
    Protected Friend WithEvents abOK As AcidControls.AcidButton
    Protected Friend WithEvents alConsoleMode As AcidControls.AcidButton
    Protected Friend WithEvents alPowerShellOrDOS As AcidControls.AcidButton
    Protected Friend WithEvents rbDOS As System.Windows.Forms.RadioButton
    Protected Friend WithEvents rbPowerShell As System.Windows.Forms.RadioButton
    Protected Friend WithEvents tmrFindingCommands As System.Windows.Forms.Timer
    Protected Friend WithEvents abHelp As AcidControls.AcidButton
    Protected Friend WithEvents txtSelected As AcidControls.AcidTextBox
    Protected Friend WithEvents txtParams As AcidControls.AcidTextBox
    Protected Friend WithEvents abTest As AcidControls.AcidButton
    Protected Friend WithEvents abCmd As AcidControls.AcidButton
    Protected Friend WithEvents alParams As AcidControls.AcidButton
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip
    Protected Friend WithEvents abCncl As AcidControls.AcidButton
    Private components As System.ComponentModel.IContainer
End Class
