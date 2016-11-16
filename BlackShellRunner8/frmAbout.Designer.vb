<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAbout
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
    Protected Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.picAbout = New System.Windows.Forms.PictureBox()
        Me.alDOS = New AcidControls.AcidLabel()
        Me.alPS = New AcidControls.AcidLabel()
        Me.alNote = New AcidControls.AcidLabel()
        Me.alSMDExample = New AcidControls.AcidLabel()
        Me.alExtraCmds = New AcidControls.AcidLabel()
        Me.alF1 = New AcidControls.AcidLabel()
        Me.alF2 = New AcidControls.AcidLabel()
        Me.alBSRCmds = New AcidControls.AcidLabel()
        Me.abOK = New AcidControls.AcidButton()
        Me.abBrdr = New AcidControls.AcidBorder()
        CType(Me.picAbout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picAbout
        '
        Me.picAbout.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picAbout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picAbout.Image = CType(resources.GetObject("picAbout.Image"), System.Drawing.Image)
        Me.picAbout.Location = New System.Drawing.Point(10, 12)
        Me.picAbout.Name = "picAbout"
        Me.picAbout.Size = New System.Drawing.Size(669, 268)
        Me.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAbout.TabIndex = 0
        Me.picAbout.TabStop = False
        '
        'alDOS
        '
        Me.alDOS.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.alDOS.ClickHidesParent = False
        Me.alDOS.Color1 = System.Drawing.Color.Empty
        Me.alDOS.Color2 = System.Drawing.Color.Empty
        Me.alDOS.Cursor = System.Windows.Forms.Cursors.Default
        Me.alDOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alDOS.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.alDOS.HasRoundedRectangle = True
        Me.alDOS.HasSound = False
        Me.alDOS.LineSize = 2
        Me.alDOS.Location = New System.Drawing.Point(10, 337)
        Me.alDOS.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alDOS.MouseClickSound = ""
        Me.alDOS.MouseClickSoundResource = Nothing
        Me.alDOS.MouseClickSoundResourcePath = ""
        Me.alDOS.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alDOS.MouseEnterSound = ""
        Me.alDOS.MouseEnterSoundResource = Nothing
        Me.alDOS.MouseEnterSoundResourcePath = ""
        Me.alDOS.Name = "alDOS"
        Me.alDOS.ResizeTextFontOnResize = False
        Me.alDOS.RoundedRadius = 5.0!
        Me.alDOS.Shadow = False
        Me.alDOS.ShadowAllWithMouseEnter = False
        Me.alDOS.ShadowColor = System.Drawing.Color.Green
        Me.alDOS.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.alDOS.ShadowDivisor = 2
        Me.alDOS.ShadowWithMouseEnter = False
        Me.alDOS.ShiftAllOnClick = False
        Me.alDOS.ShiftForeColor = System.Drawing.Color.Green
        Me.alDOS.ShiftOnClick = False
        Me.alDOS.ShiftShadowColor = System.Drawing.Color.Lime
        Me.alDOS.ShowBorder = True
        Me.alDOS.Size = New System.Drawing.Size(669, 21)
        Me.alDOS.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.alDOS.TabIndex = 34
        Me.alDOS.Text = "Multiple DOS commands can be separated with ""&&"".  Example: ""echo hello&&echo wor" &
    "ld"""
        Me.alDOS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.alDOS.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.alDOS.TextShadowDisplacement = 1
        Me.alDOS.UseCompatibleTextRendering = True
        '
        'alPS
        '
        Me.alPS.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.alPS.ClickHidesParent = False
        Me.alPS.Color1 = System.Drawing.Color.Empty
        Me.alPS.Color2 = System.Drawing.Color.Empty
        Me.alPS.Cursor = System.Windows.Forms.Cursors.Default
        Me.alPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alPS.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.alPS.HasRoundedRectangle = True
        Me.alPS.HasSound = False
        Me.alPS.LineSize = 2
        Me.alPS.Location = New System.Drawing.Point(10, 355)
        Me.alPS.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alPS.MouseClickSound = ""
        Me.alPS.MouseClickSoundResource = Nothing
        Me.alPS.MouseClickSoundResourcePath = ""
        Me.alPS.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alPS.MouseEnterSound = ""
        Me.alPS.MouseEnterSoundResource = Nothing
        Me.alPS.MouseEnterSoundResourcePath = ""
        Me.alPS.Name = "alPS"
        Me.alPS.ResizeTextFontOnResize = False
        Me.alPS.RoundedRadius = 5.0!
        Me.alPS.Shadow = False
        Me.alPS.ShadowAllWithMouseEnter = False
        Me.alPS.ShadowColor = System.Drawing.Color.Green
        Me.alPS.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.alPS.ShadowDivisor = 2
        Me.alPS.ShadowWithMouseEnter = False
        Me.alPS.ShiftAllOnClick = False
        Me.alPS.ShiftForeColor = System.Drawing.Color.Green
        Me.alPS.ShiftOnClick = False
        Me.alPS.ShiftShadowColor = System.Drawing.Color.Lime
        Me.alPS.ShowBorder = True
        Me.alPS.Size = New System.Drawing.Size(669, 21)
        Me.alPS.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.alPS.TabIndex = 35
        Me.alPS.Text = "Multiple PowerShell commands can be separated with ""; "".  Example: ""echo hello; e" &
    "cho world"
        Me.alPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.alPS.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.alPS.TextShadowDisplacement = 1
        Me.alPS.UseCompatibleTextRendering = True
        '
        'alNote
        '
        Me.alNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.alNote.ClickHidesParent = False
        Me.alNote.Color1 = System.Drawing.Color.Empty
        Me.alNote.Color2 = System.Drawing.Color.Empty
        Me.alNote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.alNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alNote.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.alNote.HasRoundedRectangle = True
        Me.alNote.HasSound = False
        Me.alNote.LineSize = 2
        Me.alNote.Location = New System.Drawing.Point(10, 281)
        Me.alNote.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alNote.MouseClickSound = ""
        Me.alNote.MouseClickSoundResource = Nothing
        Me.alNote.MouseClickSoundResourcePath = ""
        Me.alNote.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alNote.MouseEnterSound = ""
        Me.alNote.MouseEnterSoundResource = Nothing
        Me.alNote.MouseEnterSoundResourcePath = ""
        Me.alNote.Name = "alNote"
        Me.alNote.ResizeTextFontOnResize = False
        Me.alNote.RoundedRadius = 5.0!
        Me.alNote.Shadow = False
        Me.alNote.ShadowAllWithMouseEnter = False
        Me.alNote.ShadowColor = System.Drawing.Color.Green
        Me.alNote.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.alNote.ShadowDivisor = 2
        Me.alNote.ShadowWithMouseEnter = False
        Me.alNote.ShiftAllOnClick = False
        Me.alNote.ShiftForeColor = System.Drawing.Color.Green
        Me.alNote.ShiftOnClick = False
        Me.alNote.ShiftShadowColor = System.Drawing.Color.Lime
        Me.alNote.ShowBorder = True
        Me.alNote.Size = New System.Drawing.Size(669, 21)
        Me.alNote.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.alNote.TabIndex = 36
        Me.alNote.Text = "HELP :"
        Me.alNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.alNote.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.alNote.TextShadowDisplacement = 1
        Me.alNote.UseCompatibleTextRendering = True
        '
        'alSMDExample
        '
        Me.alSMDExample.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.alSMDExample.ClickHidesParent = False
        Me.alSMDExample.Color1 = System.Drawing.Color.Empty
        Me.alSMDExample.Color2 = System.Drawing.Color.Empty
        Me.alSMDExample.Cursor = System.Windows.Forms.Cursors.Default
        Me.alSMDExample.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alSMDExample.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.alSMDExample.HasRoundedRectangle = True
        Me.alSMDExample.HasSound = False
        Me.alSMDExample.LineSize = 2
        Me.alSMDExample.Location = New System.Drawing.Point(10, 320)
        Me.alSMDExample.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alSMDExample.MouseClickSound = ""
        Me.alSMDExample.MouseClickSoundResource = Nothing
        Me.alSMDExample.MouseClickSoundResourcePath = ""
        Me.alSMDExample.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alSMDExample.MouseEnterSound = ""
        Me.alSMDExample.MouseEnterSoundResource = Nothing
        Me.alSMDExample.MouseEnterSoundResourcePath = ""
        Me.alSMDExample.Name = "alSMDExample"
        Me.alSMDExample.ResizeTextFontOnResize = False
        Me.alSMDExample.RoundedRadius = 5.0!
        Me.alSMDExample.Shadow = False
        Me.alSMDExample.ShadowAllWithMouseEnter = False
        Me.alSMDExample.ShadowColor = System.Drawing.Color.Green
        Me.alSMDExample.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.alSMDExample.ShadowDivisor = 2
        Me.alSMDExample.ShadowWithMouseEnter = False
        Me.alSMDExample.ShiftAllOnClick = False
        Me.alSMDExample.ShiftForeColor = System.Drawing.Color.Green
        Me.alSMDExample.ShiftOnClick = False
        Me.alSMDExample.ShiftShadowColor = System.Drawing.Color.Lime
        Me.alSMDExample.ShowBorder = True
        Me.alSMDExample.Size = New System.Drawing.Size(673, 20)
        Me.alSMDExample.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.alSMDExample.TabIndex = 39
        Me.alSMDExample.Text = "smd Example: smd c:\newfolder\newfolder2\newfolder3, sod Example: smd c:\dir\dir2" &
    "%|%sod c:\dir\dir2"
        Me.alSMDExample.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.alSMDExample.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.alSMDExample.TextShadowDisplacement = 1
        Me.alSMDExample.UseCompatibleTextRendering = True
        '
        'alExtraCmds
        '
        Me.alExtraCmds.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.alExtraCmds.ClickHidesParent = False
        Me.alExtraCmds.Color1 = System.Drawing.Color.Empty
        Me.alExtraCmds.Color2 = System.Drawing.Color.Empty
        Me.alExtraCmds.Cursor = System.Windows.Forms.Cursors.Default
        Me.alExtraCmds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alExtraCmds.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.alExtraCmds.HasRoundedRectangle = True
        Me.alExtraCmds.HasSound = False
        Me.alExtraCmds.LineSize = 2
        Me.alExtraCmds.Location = New System.Drawing.Point(10, 302)
        Me.alExtraCmds.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alExtraCmds.MouseClickSound = ""
        Me.alExtraCmds.MouseClickSoundResource = Nothing
        Me.alExtraCmds.MouseClickSoundResourcePath = ""
        Me.alExtraCmds.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alExtraCmds.MouseEnterSound = ""
        Me.alExtraCmds.MouseEnterSoundResource = Nothing
        Me.alExtraCmds.MouseEnterSoundResourcePath = ""
        Me.alExtraCmds.Name = "alExtraCmds"
        Me.alExtraCmds.ResizeTextFontOnResize = False
        Me.alExtraCmds.RoundedRadius = 5.0!
        Me.alExtraCmds.Shadow = False
        Me.alExtraCmds.ShadowAllWithMouseEnter = False
        Me.alExtraCmds.ShadowColor = System.Drawing.Color.Green
        Me.alExtraCmds.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.alExtraCmds.ShadowDivisor = 2
        Me.alExtraCmds.ShadowWithMouseEnter = False
        Me.alExtraCmds.ShiftAllOnClick = False
        Me.alExtraCmds.ShiftForeColor = System.Drawing.Color.Green
        Me.alExtraCmds.ShiftOnClick = False
        Me.alExtraCmds.ShiftShadowColor = System.Drawing.Color.Lime
        Me.alExtraCmds.ShowBorder = True
        Me.alExtraCmds.Size = New System.Drawing.Size(669, 18)
        Me.alExtraCmds.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.alExtraCmds.TabIndex = 40
        Me.alExtraCmds.Text = "Extra commands are cascade, tilehorizontally, tilevertically, minimizeall, unmini" &
    "mizeall, supermkdir or smd. and superopendir or sod"
        Me.alExtraCmds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.alExtraCmds.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.alExtraCmds.TextShadowDisplacement = 1
        Me.alExtraCmds.UseCompatibleTextRendering = True
        '
        'alF1
        '
        Me.alF1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.alF1.ClickHidesParent = False
        Me.alF1.Color1 = System.Drawing.Color.Empty
        Me.alF1.Color2 = System.Drawing.Color.Empty
        Me.alF1.Cursor = System.Windows.Forms.Cursors.Default
        Me.alF1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alF1.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.alF1.HasRoundedRectangle = True
        Me.alF1.HasSound = False
        Me.alF1.LineSize = 2
        Me.alF1.Location = New System.Drawing.Point(10, 390)
        Me.alF1.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alF1.MouseClickSound = ""
        Me.alF1.MouseClickSoundResource = Nothing
        Me.alF1.MouseClickSoundResourcePath = ""
        Me.alF1.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alF1.MouseEnterSound = ""
        Me.alF1.MouseEnterSoundResource = Nothing
        Me.alF1.MouseEnterSoundResourcePath = ""
        Me.alF1.Name = "alF1"
        Me.alF1.ResizeTextFontOnResize = False
        Me.alF1.RoundedRadius = 5.0!
        Me.alF1.Shadow = False
        Me.alF1.ShadowAllWithMouseEnter = False
        Me.alF1.ShadowColor = System.Drawing.Color.Green
        Me.alF1.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.alF1.ShadowDivisor = 2
        Me.alF1.ShadowWithMouseEnter = False
        Me.alF1.ShiftAllOnClick = False
        Me.alF1.ShiftForeColor = System.Drawing.Color.Green
        Me.alF1.ShiftOnClick = False
        Me.alF1.ShiftShadowColor = System.Drawing.Color.Lime
        Me.alF1.ShowBorder = True
        Me.alF1.Size = New System.Drawing.Size(669, 21)
        Me.alF1.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.alF1.TabIndex = 41
        Me.alF1.Text = "F1 when BSR main window selected > Align To Screen If Not In Corner If In Corner " &
    "Move Clockwise On Screen"
        Me.alF1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.alF1.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.alF1.TextShadowDisplacement = 1
        Me.alF1.UseCompatibleTextRendering = True
        '
        'alF2
        '
        Me.alF2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.alF2.ClickHidesParent = False
        Me.alF2.Color1 = System.Drawing.Color.Empty
        Me.alF2.Color2 = System.Drawing.Color.Empty
        Me.alF2.Cursor = System.Windows.Forms.Cursors.Default
        Me.alF2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alF2.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.alF2.HasRoundedRectangle = True
        Me.alF2.HasSound = False
        Me.alF2.LineSize = 2
        Me.alF2.Location = New System.Drawing.Point(10, 409)
        Me.alF2.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alF2.MouseClickSound = ""
        Me.alF2.MouseClickSoundResource = Nothing
        Me.alF2.MouseClickSoundResourcePath = ""
        Me.alF2.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alF2.MouseEnterSound = ""
        Me.alF2.MouseEnterSoundResource = Nothing
        Me.alF2.MouseEnterSoundResourcePath = ""
        Me.alF2.Name = "alF2"
        Me.alF2.ResizeTextFontOnResize = False
        Me.alF2.RoundedRadius = 5.0!
        Me.alF2.Shadow = False
        Me.alF2.ShadowAllWithMouseEnter = False
        Me.alF2.ShadowColor = System.Drawing.Color.Green
        Me.alF2.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.alF2.ShadowDivisor = 2
        Me.alF2.ShadowWithMouseEnter = False
        Me.alF2.ShiftAllOnClick = False
        Me.alF2.ShiftForeColor = System.Drawing.Color.Green
        Me.alF2.ShiftOnClick = False
        Me.alF2.ShiftShadowColor = System.Drawing.Color.Lime
        Me.alF2.ShowBorder = True
        Me.alF2.Size = New System.Drawing.Size(669, 17)
        Me.alF2.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.alF2.TabIndex = 42
        Me.alF2.Text = "F2 when BSR main window selected > Align To Screen If Not In Corner If In Corner " &
    "Move Counter Clockwise On Screen"
        Me.alF2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.alF2.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.alF2.TextShadowDisplacement = 1
        Me.alF2.UseCompatibleTextRendering = True
        '
        'alBSRCmds
        '
        Me.alBSRCmds.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.alBSRCmds.ClickHidesParent = False
        Me.alBSRCmds.Color1 = System.Drawing.Color.Empty
        Me.alBSRCmds.Color2 = System.Drawing.Color.Empty
        Me.alBSRCmds.Cursor = System.Windows.Forms.Cursors.Default
        Me.alBSRCmds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alBSRCmds.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.alBSRCmds.HasRoundedRectangle = True
        Me.alBSRCmds.HasSound = False
        Me.alBSRCmds.LineSize = 2
        Me.alBSRCmds.Location = New System.Drawing.Point(10, 373)
        Me.alBSRCmds.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alBSRCmds.MouseClickSound = ""
        Me.alBSRCmds.MouseClickSoundResource = Nothing
        Me.alBSRCmds.MouseClickSoundResourcePath = ""
        Me.alBSRCmds.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.alBSRCmds.MouseEnterSound = ""
        Me.alBSRCmds.MouseEnterSoundResource = Nothing
        Me.alBSRCmds.MouseEnterSoundResourcePath = ""
        Me.alBSRCmds.Name = "alBSRCmds"
        Me.alBSRCmds.ResizeTextFontOnResize = False
        Me.alBSRCmds.RoundedRadius = 5.0!
        Me.alBSRCmds.Shadow = False
        Me.alBSRCmds.ShadowAllWithMouseEnter = False
        Me.alBSRCmds.ShadowColor = System.Drawing.Color.Green
        Me.alBSRCmds.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.alBSRCmds.ShadowDivisor = 2
        Me.alBSRCmds.ShadowWithMouseEnter = False
        Me.alBSRCmds.ShiftAllOnClick = False
        Me.alBSRCmds.ShiftForeColor = System.Drawing.Color.Green
        Me.alBSRCmds.ShiftOnClick = False
        Me.alBSRCmds.ShiftShadowColor = System.Drawing.Color.Lime
        Me.alBSRCmds.ShowBorder = True
        Me.alBSRCmds.Size = New System.Drawing.Size(669, 21)
        Me.alBSRCmds.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.alBSRCmds.TabIndex = 43
        Me.alBSRCmds.Text = "Multiple BlackShellRunner commands can be separated with ""%|%"" Example: echo hell" &
    "o; echo world%|%echo hello&&echo world"
        Me.alBSRCmds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.alBSRCmds.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.alBSRCmds.TextShadowDisplacement = 1
        Me.alBSRCmds.UseCompatibleTextRendering = True
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
        Me.abOK.Location = New System.Drawing.Point(297, 432)
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
        Me.abOK.ShadowAllWithMouseEnter = True
        Me.abOK.ShadowColor = System.Drawing.Color.Green
        Me.abOK.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.abOK.ShadowDivisor = 2
        Me.abOK.ShadowWithMouseEnter = False
        Me.abOK.ShiftAllOnClick = True
        Me.abOK.ShiftForeColor = System.Drawing.Color.Green
        Me.abOK.ShiftOnClick = False
        Me.abOK.ShiftShadowColor = System.Drawing.Color.Lime
        Me.abOK.ShowBorder = True
        Me.abOK.Size = New System.Drawing.Size(100, 20)
        Me.abOK.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.abOK.TabIndex = 44
        Me.abOK.Text = "Ok"
        Me.abOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.abOK.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.abOK.TextShadowDisplacement = 1
        Me.abOK.UseCompatibleTextRendering = True
        '
        'abBrdr
        '
        Me.abBrdr.ClickHidesParent = False
        Me.abBrdr.Color1 = System.Drawing.Color.Empty
        Me.abBrdr.Color2 = System.Drawing.Color.Empty
        Me.abBrdr.Cursor = System.Windows.Forms.Cursors.Default
        Me.abBrdr.Dock = System.Windows.Forms.DockStyle.Fill
        Me.abBrdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.abBrdr.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.abBrdr.HasRoundedRectangle = True
        Me.abBrdr.HasSound = False
        Me.abBrdr.LineSize = 2
        Me.abBrdr.Location = New System.Drawing.Point(0, 0)
        Me.abBrdr.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.abBrdr.MouseClickSound = ""
        Me.abBrdr.MouseClickSoundResource = Nothing
        Me.abBrdr.MouseClickSoundResourcePath = ""
        Me.abBrdr.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        Me.abBrdr.MouseEnterSound = ""
        Me.abBrdr.MouseEnterSoundResource = Nothing
        Me.abBrdr.MouseEnterSoundResourcePath = ""
        Me.abBrdr.Name = "abBrdr"
        Me.abBrdr.ResizeTextFontOnResize = False
        Me.abBrdr.RoundedRadius = 5.0!
        Me.abBrdr.Shadow = False
        Me.abBrdr.ShadowAllWithMouseEnter = False
        Me.abBrdr.ShadowColor = System.Drawing.Color.Green
        Me.abBrdr.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        Me.abBrdr.ShadowDivisor = 2
        Me.abBrdr.ShadowWithMouseEnter = False
        Me.abBrdr.ShiftAllOnClick = False
        Me.abBrdr.ShiftForeColor = System.Drawing.Color.Green
        Me.abBrdr.ShiftOnClick = False
        Me.abBrdr.ShiftShadowColor = System.Drawing.Color.Lime
        Me.abBrdr.ShowBorder = True
        Me.abBrdr.Size = New System.Drawing.Size(692, 462)
        Me.abBrdr.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        Me.abBrdr.TabIndex = 45
        Me.abBrdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.abBrdr.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        Me.abBrdr.TextShadowDisplacement = 1
        Me.abBrdr.UseCompatibleTextRendering = True
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(692, 462)
        Me.Controls.Add(Me.abOK)
        Me.Controls.Add(Me.alBSRCmds)
        Me.Controls.Add(Me.alF2)
        Me.Controls.Add(Me.alF1)
        Me.Controls.Add(Me.alExtraCmds)
        Me.Controls.Add(Me.alSMDExample)
        Me.Controls.Add(Me.alNote)
        Me.Controls.Add(Me.alPS)
        Me.Controls.Add(Me.alDOS)
        Me.Controls.Add(Me.picAbout)
        Me.Controls.Add(Me.abBrdr)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.ShowInTaskbar = False
        Me.Text = "About And Help"
        CType(Me.picAbout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Protected Friend WithEvents picAbout As System.Windows.Forms.PictureBox
    Protected Friend WithEvents abBrdr As AcidControls.AcidBorder
    Protected Friend WithEvents alDOS As AcidControls.AcidLabel
    Protected Friend WithEvents alPS As AcidControls.AcidLabel
    Protected Friend WithEvents alNote As AcidControls.AcidLabel
    Protected Friend WithEvents alSMDExample As AcidControls.AcidLabel
    Protected Friend WithEvents alExtraCmds As AcidControls.AcidLabel
    Protected Friend WithEvents alF1 As AcidControls.AcidLabel
    Protected Friend WithEvents alF2 As AcidControls.AcidLabel
    Protected Friend WithEvents alBSRCmds As AcidControls.AcidLabel
    Protected Friend WithEvents abOK As AcidControls.AcidButton
    Private components As System.ComponentModel.IContainer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
