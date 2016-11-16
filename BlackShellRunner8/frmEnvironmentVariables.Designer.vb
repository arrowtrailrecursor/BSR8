<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvironmentVariables
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
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnvironmentVariables))
        abBrdr = New AcidControls.AcidBorder()
        abAddPathExt = New AcidControls.AcidButton()
        abRemovePathExt = New AcidControls.AcidButton()
        abApply = New AcidControls.AcidButton()
        txtPATHEXT = New AcidControls.AcidTextBox()
        txtPATH = New AcidControls.AcidTextBox()
        abAddPath = New AcidControls.AcidButton()
        LblshpRemovePath = New AcidControls.AcidButton()
        abBrws = New AcidControls.AcidButton()
        alPATH = New AcidControls.AcidButton()
        alPATHEXT = New AcidControls.AcidButton()
        abCncl = New AcidControls.AcidButton()
        scMain = New System.Windows.Forms.SplitContainer()
        lvPATH = New System.Windows.Forms.ListView()
        colPath = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        lvPATHEXT = New System.Windows.Forms.ListView()
        colPATHEXT = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        abRevert = New AcidControls.AcidButton()
        mcttMain = New AcidControls.AcidToolTip(components)
        abReboot = New AcidControls.AcidButton()
        CType(scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        scMain.Panel1.SuspendLayout()
        scMain.Panel2.SuspendLayout()
        scMain.SuspendLayout()
        SuspendLayout()
        '
        'abBrdr
        '
        abBrdr.ClickHidesParent = False
        abBrdr.Color1 = System.Drawing.Color.Empty
        abBrdr.Color2 = System.Drawing.Color.Empty
        abBrdr.Cursor = System.Windows.Forms.Cursors.Default
        abBrdr.Dock = System.Windows.Forms.DockStyle.Fill
        abBrdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        abBrdr.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abBrdr.HasRoundedRectangle = True
        abBrdr.HasSound = False
        abBrdr.ImeMode = System.Windows.Forms.ImeMode.NoControl
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
        abBrdr.Size = New System.Drawing.Size(556, 348)
        abBrdr.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBrdr.TabIndex = 35
        abBrdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBrdr.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBrdr.TextShadowDisplacement = 1
        abBrdr.UseCompatibleTextRendering = True
        '
        'abAddPathExt
        '
        abAddPathExt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abAddPathExt.ClickHidesParent = False
        abAddPathExt.Color1 = System.Drawing.Color.Empty
        abAddPathExt.Color2 = System.Drawing.Color.Empty
        abAddPathExt.Cursor = System.Windows.Forms.Cursors.Hand
        abAddPathExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abAddPathExt.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abAddPathExt.HasRoundedRectangle = True
        abAddPathExt.HasSound = False
        abAddPathExt.LineSize = 2
        abAddPathExt.Location = New System.Drawing.Point(366, 283)
        abAddPathExt.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abAddPathExt.MouseClickSound = ""
        abAddPathExt.MouseClickSoundResource = Nothing
        abAddPathExt.MouseClickSoundResourcePath = ""
        abAddPathExt.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abAddPathExt.MouseEnterSound = ""
        abAddPathExt.MouseEnterSoundResource = Nothing
        abAddPathExt.MouseEnterSoundResourcePath = ""
        abAddPathExt.Name = "abAddPathExt"
        abAddPathExt.ResizeTextFontOnResize = False
        abAddPathExt.RoundedRadius = 10.0!
        abAddPathExt.Shadow = False
        abAddPathExt.ShadowAllWithMouseEnter = False
        abAddPathExt.ShadowColor = System.Drawing.Color.Green
        abAddPathExt.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abAddPathExt.ShadowDivisor = 2
        abAddPathExt.ShadowWithMouseEnter = True
        abAddPathExt.ShiftAllOnClick = False
        abAddPathExt.ShiftForeColor = System.Drawing.Color.Green
        abAddPathExt.ShiftOnClick = True
        abAddPathExt.ShiftShadowColor = System.Drawing.Color.Lime
        abAddPathExt.ShowBorder = True
        abAddPathExt.Size = New System.Drawing.Size(86, 21)
        abAddPathExt.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abAddPathExt.TabIndex = 37
        abAddPathExt.Text = "Add"
        abAddPathExt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abAddPathExt.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abAddPathExt.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abAddPathExt, "Add Path Extension")
        abAddPathExt.UseCompatibleTextRendering = True
        '
        'abRemovePathExt
        '
        abRemovePathExt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abRemovePathExt.ClickHidesParent = False
        abRemovePathExt.Color1 = System.Drawing.Color.Empty
        abRemovePathExt.Color2 = System.Drawing.Color.Empty
        abRemovePathExt.Cursor = System.Windows.Forms.Cursors.Hand
        abRemovePathExt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abRemovePathExt.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abRemovePathExt.HasRoundedRectangle = True
        abRemovePathExt.HasSound = False
        abRemovePathExt.LineSize = 2
        abRemovePathExt.Location = New System.Drawing.Point(458, 283)
        abRemovePathExt.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abRemovePathExt.MouseClickSound = ""
        abRemovePathExt.MouseClickSoundResource = Nothing
        abRemovePathExt.MouseClickSoundResourcePath = ""
        abRemovePathExt.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abRemovePathExt.MouseEnterSound = ""
        abRemovePathExt.MouseEnterSoundResource = Nothing
        abRemovePathExt.MouseEnterSoundResourcePath = ""
        abRemovePathExt.Name = "abRemovePathExt"
        abRemovePathExt.ResizeTextFontOnResize = False
        abRemovePathExt.RoundedRadius = 10.0!
        abRemovePathExt.Shadow = False
        abRemovePathExt.ShadowAllWithMouseEnter = False
        abRemovePathExt.ShadowColor = System.Drawing.Color.Green
        abRemovePathExt.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abRemovePathExt.ShadowDivisor = 2
        abRemovePathExt.ShadowWithMouseEnter = True
        abRemovePathExt.ShiftAllOnClick = False
        abRemovePathExt.ShiftForeColor = System.Drawing.Color.Green
        abRemovePathExt.ShiftOnClick = True
        abRemovePathExt.ShiftShadowColor = System.Drawing.Color.Lime
        abRemovePathExt.ShowBorder = True
        abRemovePathExt.Size = New System.Drawing.Size(86, 21)
        abRemovePathExt.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abRemovePathExt.TabIndex = 38
        abRemovePathExt.Text = "Remove"
        abRemovePathExt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abRemovePathExt.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abRemovePathExt.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abRemovePathExt, "Remove Path Extension")
        abRemovePathExt.UseCompatibleTextRendering = True
        '
        'abApply
        '
        abApply.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        abApply.ClickHidesParent = False
        abApply.Color1 = System.Drawing.Color.Empty
        abApply.Color2 = System.Drawing.Color.Empty
        abApply.Cursor = System.Windows.Forms.Cursors.Hand
        abApply.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abApply.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abApply.HasRoundedRectangle = True
        abApply.HasSound = False
        abApply.LineSize = 2
        abApply.Location = New System.Drawing.Point(282, 315)
        abApply.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abApply.MouseClickSound = ""
        abApply.MouseClickSoundResource = Nothing
        abApply.MouseClickSoundResourcePath = ""
        abApply.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abApply.MouseEnterSound = ""
        abApply.MouseEnterSoundResource = Nothing
        abApply.MouseEnterSoundResourcePath = ""
        abApply.Name = "abApply"
        abApply.ResizeTextFontOnResize = False
        abApply.RoundedRadius = 10.0!
        abApply.Shadow = False
        abApply.ShadowAllWithMouseEnter = True
        abApply.ShadowColor = System.Drawing.Color.Green
        abApply.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abApply.ShadowDivisor = 2
        abApply.ShadowWithMouseEnter = True
        abApply.ShiftAllOnClick = True
        abApply.ShiftForeColor = System.Drawing.Color.Green
        abApply.ShiftOnClick = True
        abApply.ShiftShadowColor = System.Drawing.Color.Lime
        abApply.ShowBorder = True
        abApply.Size = New System.Drawing.Size(94, 21)
        abApply.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abApply.TabIndex = 39
        abApply.Text = "Apply"
        abApply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abApply.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abApply.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abApply, "Apply Variables")
        abApply.UseCompatibleTextRendering = True
        '
        'txtPATHEXT
        '
        txtPATHEXT.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtPATHEXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtPATHEXT.LineSize = 2
        txtPATHEXT.Location = New System.Drawing.Point(89, 283)
        txtPATHEXT.Name = "txtPATHEXT"
        txtPATHEXT.PasteMultilineJoiningCharacter = " "
        txtPATHEXT.Shadow = False
        txtPATHEXT.ShadowColor = System.Drawing.Color.Green
        txtPATHEXT.ShadowDivisor = 2
        txtPATHEXT.ShadowOnMouseEnter = False
        txtPATHEXT.ShiftForeColor = System.Drawing.Color.Green
        txtPATHEXT.ShiftOnClick = False
        txtPATHEXT.ShiftShadowColor = System.Drawing.Color.Lime
        txtPATHEXT.Size = New System.Drawing.Size(271, 20)
        txtPATHEXT.TabIndex = 40
        mcttMain.SetToolTip(txtPATHEXT, "Add Or Remove This Path Extension")
        '
        'txtPATH
        '
        txtPATH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtPATH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtPATH.LineSize = 2
        txtPATH.Location = New System.Drawing.Point(60, 257)
        txtPATH.Name = "txtPATH"
        txtPATH.PasteMultilineJoiningCharacter = " "
        txtPATH.Shadow = False
        txtPATH.ShadowColor = System.Drawing.Color.Green
        txtPATH.ShadowDivisor = 2
        txtPATH.ShadowOnMouseEnter = False
        txtPATH.ShiftForeColor = System.Drawing.Color.Green
        txtPATH.ShiftOnClick = False
        txtPATH.ShiftShadowColor = System.Drawing.Color.Lime
        txtPATH.Size = New System.Drawing.Size(260, 20)
        txtPATH.TabIndex = 41
        mcttMain.SetToolTip(txtPATH, "Add Or Remove This Directory")
        '
        'abAddPath
        '
        abAddPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abAddPath.ClickHidesParent = False
        abAddPath.Color1 = System.Drawing.Color.Empty
        abAddPath.Color2 = System.Drawing.Color.Empty
        abAddPath.Cursor = System.Windows.Forms.Cursors.Hand
        abAddPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abAddPath.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abAddPath.HasRoundedRectangle = True
        abAddPath.HasSound = False
        abAddPath.LineSize = 2
        abAddPath.Location = New System.Drawing.Point(366, 257)
        abAddPath.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abAddPath.MouseClickSound = ""
        abAddPath.MouseClickSoundResource = Nothing
        abAddPath.MouseClickSoundResourcePath = ""
        abAddPath.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abAddPath.MouseEnterSound = ""
        abAddPath.MouseEnterSoundResource = Nothing
        abAddPath.MouseEnterSoundResourcePath = ""
        abAddPath.Name = "abAddPath"
        abAddPath.ResizeTextFontOnResize = False
        abAddPath.RoundedRadius = 10.0!
        abAddPath.Shadow = False
        abAddPath.ShadowAllWithMouseEnter = False
        abAddPath.ShadowColor = System.Drawing.Color.Green
        abAddPath.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abAddPath.ShadowDivisor = 2
        abAddPath.ShadowWithMouseEnter = True
        abAddPath.ShiftAllOnClick = False
        abAddPath.ShiftForeColor = System.Drawing.Color.Green
        abAddPath.ShiftOnClick = True
        abAddPath.ShiftShadowColor = System.Drawing.Color.Lime
        abAddPath.ShowBorder = True
        abAddPath.Size = New System.Drawing.Size(86, 21)
        abAddPath.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abAddPath.TabIndex = 42
        abAddPath.Text = "Add"
        abAddPath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abAddPath.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abAddPath.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abAddPath, "Add Path")
        abAddPath.UseCompatibleTextRendering = True
        '
        'LblshpRemovePath
        '
        LblshpRemovePath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        LblshpRemovePath.ClickHidesParent = False
        LblshpRemovePath.Color1 = System.Drawing.Color.Empty
        LblshpRemovePath.Color2 = System.Drawing.Color.Empty
        LblshpRemovePath.Cursor = System.Windows.Forms.Cursors.Hand
        LblshpRemovePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LblshpRemovePath.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        LblshpRemovePath.HasRoundedRectangle = True
        LblshpRemovePath.HasSound = False
        LblshpRemovePath.LineSize = 2
        LblshpRemovePath.Location = New System.Drawing.Point(458, 257)
        LblshpRemovePath.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        LblshpRemovePath.MouseClickSound = ""
        LblshpRemovePath.MouseClickSoundResource = Nothing
        LblshpRemovePath.MouseClickSoundResourcePath = ""
        LblshpRemovePath.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        LblshpRemovePath.MouseEnterSound = ""
        LblshpRemovePath.MouseEnterSoundResource = Nothing
        LblshpRemovePath.MouseEnterSoundResourcePath = ""
        LblshpRemovePath.Name = "LblshpRemovePath"
        LblshpRemovePath.ResizeTextFontOnResize = False
        LblshpRemovePath.RoundedRadius = 10.0!
        LblshpRemovePath.Shadow = False
        LblshpRemovePath.ShadowAllWithMouseEnter = False
        LblshpRemovePath.ShadowColor = System.Drawing.Color.Green
        LblshpRemovePath.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        LblshpRemovePath.ShadowDivisor = 2
        LblshpRemovePath.ShadowWithMouseEnter = True
        LblshpRemovePath.ShiftAllOnClick = False
        LblshpRemovePath.ShiftForeColor = System.Drawing.Color.Green
        LblshpRemovePath.ShiftOnClick = True
        LblshpRemovePath.ShiftShadowColor = System.Drawing.Color.Lime
        LblshpRemovePath.ShowBorder = True
        LblshpRemovePath.Size = New System.Drawing.Size(86, 21)
        LblshpRemovePath.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        LblshpRemovePath.TabIndex = 43
        LblshpRemovePath.Text = "Remove"
        LblshpRemovePath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        LblshpRemovePath.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        LblshpRemovePath.TextShadowDisplacement = 1
        mcttMain.SetToolTip(LblshpRemovePath, "Remove Path")
        LblshpRemovePath.UseCompatibleTextRendering = True
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
        abBrws.Location = New System.Drawing.Point(326, 256)
        abBrws.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abBrws.MouseClickSound = ""
        abBrws.MouseClickSoundResource = Nothing
        abBrws.MouseClickSoundResourcePath = ""
        abBrws.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
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
        abBrws.Size = New System.Drawing.Size(34, 21)
        abBrws.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBrws.TabIndex = 44
        abBrws.Text = "..."
        abBrws.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBrws.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBrws.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abBrws, "Browse For Folder")
        abBrws.UseCompatibleTextRendering = True
        '
        'alPATH
        '
        alPATH.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        alPATH.ClickHidesParent = False
        alPATH.Color1 = System.Drawing.Color.Empty
        alPATH.Color2 = System.Drawing.Color.Empty
        alPATH.Cursor = System.Windows.Forms.Cursors.Hand
        alPATH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        alPATH.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        alPATH.HasRoundedRectangle = True
        alPATH.HasSound = False
        alPATH.LineSize = 2
        alPATH.Location = New System.Drawing.Point(12, 257)
        alPATH.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        alPATH.MouseClickSound = ""
        alPATH.MouseClickSoundResource = Nothing
        alPATH.MouseClickSoundResourcePath = ""
        alPATH.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        alPATH.MouseEnterSound = ""
        alPATH.MouseEnterSoundResource = Nothing
        alPATH.MouseEnterSoundResourcePath = ""
        alPATH.Name = "alPATH"
        alPATH.ResizeTextFontOnResize = False
        alPATH.RoundedRadius = 5.0!
        alPATH.Shadow = False
        alPATH.ShadowAllWithMouseEnter = False
        alPATH.ShadowColor = System.Drawing.Color.Green
        alPATH.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        alPATH.ShadowDivisor = 2
        alPATH.ShadowWithMouseEnter = False
        alPATH.ShiftAllOnClick = False
        alPATH.ShiftForeColor = System.Drawing.Color.DarkGreen
        alPATH.ShiftOnClick = False
        alPATH.ShiftShadowColor = System.Drawing.Color.Lime
        alPATH.ShowBorder = False
        alPATH.Size = New System.Drawing.Size(41, 21)
        alPATH.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        alPATH.TabIndex = 45
        alPATH.Text = "Path >"
        alPATH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        alPATH.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        alPATH.TextShadowDisplacement = 1
        alPATH.UseCompatibleTextRendering = True
        '
        'alPATHEXT
        '
        alPATHEXT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        alPATHEXT.ClickHidesParent = False
        alPATHEXT.Color1 = System.Drawing.Color.Empty
        alPATHEXT.Color2 = System.Drawing.Color.Empty
        alPATHEXT.Cursor = System.Windows.Forms.Cursors.Hand
        alPATHEXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        alPATHEXT.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        alPATHEXT.HasRoundedRectangle = True
        alPATHEXT.HasSound = False
        alPATHEXT.LineSize = 2
        alPATHEXT.Location = New System.Drawing.Point(12, 282)
        alPATHEXT.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        alPATHEXT.MouseClickSound = ""
        alPATHEXT.MouseClickSoundResource = Nothing
        alPATHEXT.MouseClickSoundResourcePath = ""
        alPATHEXT.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        alPATHEXT.MouseEnterSound = ""
        alPATHEXT.MouseEnterSoundResource = Nothing
        alPATHEXT.MouseEnterSoundResourcePath = ""
        alPATHEXT.Name = "alPATHEXT"
        alPATHEXT.ResizeTextFontOnResize = False
        alPATHEXT.RoundedRadius = 5.0!
        alPATHEXT.Shadow = False
        alPATHEXT.ShadowAllWithMouseEnter = False
        alPATHEXT.ShadowColor = System.Drawing.Color.Green
        alPATHEXT.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        alPATHEXT.ShadowDivisor = 2
        alPATHEXT.ShadowWithMouseEnter = False
        alPATHEXT.ShiftAllOnClick = False
        alPATHEXT.ShiftForeColor = System.Drawing.Color.DarkGreen
        alPATHEXT.ShiftOnClick = False
        alPATHEXT.ShiftShadowColor = System.Drawing.Color.Lime
        alPATHEXT.ShowBorder = False
        alPATHEXT.Size = New System.Drawing.Size(71, 21)
        alPATHEXT.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        alPATHEXT.TabIndex = 46
        alPATHEXT.Text = "PATHEXT >"
        alPATHEXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        alPATHEXT.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        alPATHEXT.TextShadowDisplacement = 1
        alPATHEXT.UseCompatibleTextRendering = True
        '
        'abCncl
        '
        abCncl.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        abCncl.ClickHidesParent = False
        abCncl.Color1 = System.Drawing.Color.Empty
        abCncl.Color2 = System.Drawing.Color.Empty
        abCncl.Cursor = System.Windows.Forms.Cursors.Hand
        abCncl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abCncl.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abCncl.HasRoundedRectangle = True
        abCncl.HasSound = False
        abCncl.LineSize = 2
        abCncl.Location = New System.Drawing.Point(182, 315)
        abCncl.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abCncl.MouseClickSound = ""
        abCncl.MouseClickSoundResource = Nothing
        abCncl.MouseClickSoundResourcePath = ""
        abCncl.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abCncl.MouseEnterSound = ""
        abCncl.MouseEnterSoundResource = Nothing
        abCncl.MouseEnterSoundResourcePath = ""
        abCncl.Name = "abCncl"
        abCncl.ResizeTextFontOnResize = False
        abCncl.RoundedRadius = 10.0!
        abCncl.Shadow = False
        abCncl.ShadowAllWithMouseEnter = True
        abCncl.ShadowColor = System.Drawing.Color.Green
        abCncl.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abCncl.ShadowDivisor = 2
        abCncl.ShadowWithMouseEnter = True
        abCncl.ShiftAllOnClick = True
        abCncl.ShiftForeColor = System.Drawing.Color.Green
        abCncl.ShiftOnClick = True
        abCncl.ShiftShadowColor = System.Drawing.Color.Lime
        abCncl.ShowBorder = True
        abCncl.Size = New System.Drawing.Size(94, 21)
        abCncl.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abCncl.TabIndex = 47
        abCncl.Text = "Cancel"
        abCncl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abCncl.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abCncl.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abCncl, "Cancel")
        abCncl.UseCompatibleTextRendering = True
        '
        'scMain
        '
        scMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        scMain.Location = New System.Drawing.Point(13, 13)
        scMain.Name = "scMain"
        '
        'scMain.Panel1
        '
        scMain.Panel1.Controls.Add(lvPATH)
        '
        'scMain.Panel2
        '
        scMain.Panel2.Controls.Add(lvPATHEXT)
        scMain.Size = New System.Drawing.Size(531, 238)
        scMain.SplitterDistance = 274
        scMain.TabIndex = 48
        '
        'lvPATH
        '
        lvPATH.BackColor = System.Drawing.Color.Black
        lvPATH.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {colPath})
        lvPATH.Cursor = System.Windows.Forms.Cursors.Hand
        lvPATH.Dock = System.Windows.Forms.DockStyle.Fill
        lvPATH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lvPATH.ForeColor = System.Drawing.Color.Lime
        lvPATH.Location = New System.Drawing.Point(0, 0)
        lvPATH.Name = "lvPATH"
        lvPATH.Size = New System.Drawing.Size(274, 238)
        lvPATH.TabIndex = 0
        mcttMain.SetToolTip(lvPATH, "Path")
        lvPATH.UseCompatibleStateImageBehavior = False
        lvPATH.View = System.Windows.Forms.View.Details
        '
        'colPath
        '
        colPath.Text = "Path"
        colPath.Width = 278
        '
        'lvPATHEXT
        '
        lvPATHEXT.BackColor = System.Drawing.Color.Black
        lvPATHEXT.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {colPATHEXT})
        lvPATHEXT.Cursor = System.Windows.Forms.Cursors.Hand
        lvPATHEXT.Dock = System.Windows.Forms.DockStyle.Fill
        lvPATHEXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lvPATHEXT.ForeColor = System.Drawing.Color.Lime
        lvPATHEXT.Location = New System.Drawing.Point(0, 0)
        lvPATHEXT.Name = "lvPATHEXT"
        lvPATHEXT.Size = New System.Drawing.Size(253, 238)
        lvPATHEXT.TabIndex = 1
        mcttMain.SetToolTip(lvPATHEXT, "PATHEXT")
        lvPATHEXT.UseCompatibleStateImageBehavior = False
        lvPATHEXT.View = System.Windows.Forms.View.Details
        '
        'colPATHEXT
        '
        colPATHEXT.Text = "PATHEXT"
        colPATHEXT.Width = 145
        '
        'abRevert
        '
        abRevert.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        abRevert.ClickHidesParent = False
        abRevert.Color1 = System.Drawing.Color.Empty
        abRevert.Color2 = System.Drawing.Color.Empty
        abRevert.Cursor = System.Windows.Forms.Cursors.Hand
        abRevert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abRevert.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abRevert.HasRoundedRectangle = True
        abRevert.HasSound = False
        abRevert.LineSize = 2
        abRevert.Location = New System.Drawing.Point(82, 315)
        abRevert.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abRevert.MouseClickSound = ""
        abRevert.MouseClickSoundResource = Nothing
        abRevert.MouseClickSoundResourcePath = ""
        abRevert.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abRevert.MouseEnterSound = ""
        abRevert.MouseEnterSoundResource = Nothing
        abRevert.MouseEnterSoundResourcePath = ""
        abRevert.Name = "abRevert"
        abRevert.ResizeTextFontOnResize = False
        abRevert.RoundedRadius = 10.0!
        abRevert.Shadow = False
        abRevert.ShadowAllWithMouseEnter = True
        abRevert.ShadowColor = System.Drawing.Color.Green
        abRevert.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abRevert.ShadowDivisor = 2
        abRevert.ShadowWithMouseEnter = True
        abRevert.ShiftAllOnClick = True
        abRevert.ShiftForeColor = System.Drawing.Color.Green
        abRevert.ShiftOnClick = True
        abRevert.ShiftShadowColor = System.Drawing.Color.Lime
        abRevert.ShowBorder = True
        abRevert.Size = New System.Drawing.Size(94, 21)
        abRevert.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abRevert.TabIndex = 49
        abRevert.Text = "Revert"
        abRevert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abRevert.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abRevert.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abRevert, "Revert To Original Variables")
        abRevert.UseCompatibleTextRendering = True
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
        'abReboot
        '
        abReboot.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        abReboot.ClickHidesParent = False
        abReboot.Color1 = System.Drawing.Color.Empty
        abReboot.Color2 = System.Drawing.Color.Empty
        abReboot.Cursor = System.Windows.Forms.Cursors.Hand
        abReboot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abReboot.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abReboot.HasRoundedRectangle = True
        abReboot.HasSound = False
        abReboot.LineSize = 2
        abReboot.Location = New System.Drawing.Point(382, 315)
        abReboot.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abReboot.MouseClickSound = ""
        abReboot.MouseClickSoundResource = Nothing
        abReboot.MouseClickSoundResourcePath = ""
        abReboot.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abReboot.MouseEnterSound = ""
        abReboot.MouseEnterSoundResource = Nothing
        abReboot.MouseEnterSoundResourcePath = ""
        abReboot.Name = "abReboot"
        abReboot.ResizeTextFontOnResize = False
        abReboot.RoundedRadius = 10.0!
        abReboot.Shadow = False
        abReboot.ShadowAllWithMouseEnter = True
        abReboot.ShadowColor = System.Drawing.Color.Green
        abReboot.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abReboot.ShadowDivisor = 2
        abReboot.ShadowWithMouseEnter = True
        abReboot.ShiftAllOnClick = True
        abReboot.ShiftForeColor = System.Drawing.Color.Green
        abReboot.ShiftOnClick = True
        abReboot.ShiftShadowColor = System.Drawing.Color.Lime
        abReboot.ShowBorder = True
        abReboot.Size = New System.Drawing.Size(94, 21)
        abReboot.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abReboot.TabIndex = 50
        abReboot.Text = "Restart"
        abReboot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abReboot.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abReboot.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abReboot, "Restart Computer Some Envronment Variables Need To Have Computer Restart To Take " &
        "Effect")
        abReboot.UseCompatibleTextRendering = True
        '
        'frmEnvironmentVariables
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Black
        ClientSize = New System.Drawing.Size(556, 348)
        Controls.Add(abReboot)
        Controls.Add(abRevert)
        Controls.Add(scMain)
        Controls.Add(abCncl)
        Controls.Add(alPATHEXT)
        Controls.Add(alPATH)
        Controls.Add(abBrws)
        Controls.Add(LblshpRemovePath)
        Controls.Add(abAddPath)
        Controls.Add(txtPATH)
        Controls.Add(txtPATHEXT)
        Controls.Add(abApply)
        Controls.Add(abRemovePathExt)
        Controls.Add(abAddPathExt)
        Controls.Add(abBrdr)
        ForeColor = System.Drawing.Color.Lime
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Name = "frmEnvironmentVariables"
        Text = "Machine Level Environment Variables"
        scMain.Panel1.ResumeLayout(False)
        scMain.Panel2.ResumeLayout(False)
        CType(scMain, System.ComponentModel.ISupportInitialize).EndInit()
        scMain.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Protected Friend WithEvents abAddPathExt As AcidControls.AcidButton
    Protected Friend WithEvents abRemovePathExt As AcidControls.AcidButton
    Protected Friend WithEvents abApply As AcidControls.AcidButton
    Protected Friend WithEvents txtPATHEXT As AcidControls.AcidTextBox
    Protected Friend WithEvents txtPATH As AcidControls.AcidTextBox
    Protected Friend WithEvents abAddPath As AcidControls.AcidButton
    Protected Friend WithEvents LblshpRemovePath As AcidControls.AcidButton
    Protected Friend WithEvents abBrws As AcidControls.AcidButton
    Protected Friend WithEvents alPATH As AcidControls.AcidButton
    Protected Friend WithEvents alPATHEXT As AcidControls.AcidButton
    Protected Friend WithEvents abCncl As AcidControls.AcidButton
    Protected Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Protected Friend WithEvents lvPATH As System.Windows.Forms.ListView
    Protected Friend WithEvents colPath As System.Windows.Forms.ColumnHeader
    Protected Friend WithEvents lvPATHEXT As System.Windows.Forms.ListView
    Protected Friend WithEvents colPATHEXT As System.Windows.Forms.ColumnHeader
    Protected Friend WithEvents abRevert As AcidControls.AcidButton
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip
    Protected Friend WithEvents abReboot As AcidControls.AcidButton
    Private components As System.ComponentModel.IContainer
    Protected Friend WithEvents abBrdr As AcidControls.AcidBorder
End Class
