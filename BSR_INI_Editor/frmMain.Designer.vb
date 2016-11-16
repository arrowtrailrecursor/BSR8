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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        abBrdr = New AcidControls.AcidBorder()
        txtINI = New AcidControls.AcidTextBox()
        abSave = New AcidControls.AcidButton()
        abSaveReload = New AcidControls.AcidButton()
        abReload = New AcidControls.AcidButton()
        abExit = New AcidControls.AcidButton()
        SuspendLayout()
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
        abBrdr.Size = New System.Drawing.Size(524, 315)
        abBrdr.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBrdr.TabIndex = 0
        abBrdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBrdr.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBrdr.TextShadowDisplacement = 1
        abBrdr.UseCompatibleTextRendering = True
        '
        'txtINI
        '
        txtINI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtINI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtINI.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtINI.LineSize = 2
        txtINI.Location = New System.Drawing.Point(13, 13)
        txtINI.Multiline = True
        txtINI.Name = "txtINI"
        txtINI.PasteMultilineJoiningCharacter = " "
        txtINI.ScrollBars = System.Windows.Forms.ScrollBars.Both
        txtINI.Shadow = False
        txtINI.ShadowColor = System.Drawing.Color.Green
        txtINI.ShadowDivisor = 2
        txtINI.ShadowOnMouseEnter = False
        txtINI.ShiftForeColor = System.Drawing.Color.Green
        txtINI.ShiftOnClick = False
        txtINI.ShiftShadowColor = System.Drawing.Color.Lime
        txtINI.Size = New System.Drawing.Size(499, 256)
        txtINI.TabIndex = 1
        txtINI.WordWrap = False
        '
        'abSave
        '
        abSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        abSave.ClickHidesParent = False
        abSave.Color1 = System.Drawing.Color.Empty
        abSave.Color2 = System.Drawing.Color.Empty
        abSave.Cursor = System.Windows.Forms.Cursors.Hand
        abSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abSave.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abSave.HasRoundedRectangle = True
        abSave.HasSound = False
        abSave.LineSize = 2
        abSave.Location = New System.Drawing.Point(13, 281)
        abSave.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abSave.MouseClickSound = ""
        abSave.MouseClickSoundResource = Nothing
        abSave.MouseClickSoundResourcePath = ""
        abSave.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abSave.MouseEnterSound = ""
        abSave.MouseEnterSoundResource = Nothing
        abSave.MouseEnterSoundResourcePath = ""
        abSave.Name = "abSave"
        abSave.ResizeTextFontOnResize = False
        abSave.RoundedRadius = 15.0!
        abSave.Shadow = False
        abSave.ShadowAllWithMouseEnter = False
        abSave.ShadowColor = System.Drawing.Color.Green
        abSave.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abSave.ShadowDivisor = 2
        abSave.ShadowWithMouseEnter = True
        abSave.ShiftAllOnClick = False
        abSave.ShiftForeColor = System.Drawing.Color.Green
        abSave.ShiftOnClick = True
        abSave.ShiftShadowColor = System.Drawing.Color.Lime
        abSave.ShowBorder = True
        abSave.Size = New System.Drawing.Size(115, 25)
        abSave.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abSave.TabIndex = 3
        abSave.Text = "Save BSR INI"
        abSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abSave.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abSave.TextShadowDisplacement = 1
        abSave.UseCompatibleTextRendering = True
        '
        'abSaveReload
        '
        abSaveReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abSaveReload.ClickHidesParent = False
        abSaveReload.Color1 = System.Drawing.Color.Empty
        abSaveReload.Color2 = System.Drawing.Color.Empty
        abSaveReload.Cursor = System.Windows.Forms.Cursors.Hand
        abSaveReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abSaveReload.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abSaveReload.HasRoundedRectangle = True
        abSaveReload.HasSound = False
        abSaveReload.LineSize = 2
        abSaveReload.Location = New System.Drawing.Point(261, 281)
        abSaveReload.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abSaveReload.MouseClickSound = ""
        abSaveReload.MouseClickSoundResource = Nothing
        abSaveReload.MouseClickSoundResourcePath = ""
        abSaveReload.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abSaveReload.MouseEnterSound = ""
        abSaveReload.MouseEnterSoundResource = Nothing
        abSaveReload.MouseEnterSoundResourcePath = ""
        abSaveReload.Name = "abSaveReload"
        abSaveReload.ResizeTextFontOnResize = False
        abSaveReload.RoundedRadius = 15.0!
        abSaveReload.Shadow = False
        abSaveReload.ShadowAllWithMouseEnter = False
        abSaveReload.ShadowColor = System.Drawing.Color.Green
        abSaveReload.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abSaveReload.ShadowDivisor = 2
        abSaveReload.ShadowWithMouseEnter = False
        abSaveReload.ShiftAllOnClick = True
        abSaveReload.ShiftForeColor = System.Drawing.Color.Green
        abSaveReload.ShiftOnClick = True
        abSaveReload.ShiftShadowColor = System.Drawing.Color.Lime
        abSaveReload.ShowBorder = True
        abSaveReload.Size = New System.Drawing.Size(123, 25)
        abSaveReload.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abSaveReload.TabIndex = 4
        abSaveReload.Text = "Save Reload BSR"
        abSaveReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abSaveReload.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abSaveReload.TextShadowDisplacement = 1
        abSaveReload.UseCompatibleTextRendering = True
        '
        'abReload
        '
        abReload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        abReload.ClickHidesParent = False
        abReload.Color1 = System.Drawing.Color.Empty
        abReload.Color2 = System.Drawing.Color.Empty
        abReload.Cursor = System.Windows.Forms.Cursors.Hand
        abReload.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abReload.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abReload.HasRoundedRectangle = True
        abReload.HasSound = False
        abReload.LineSize = 2
        abReload.Location = New System.Drawing.Point(132, 281)
        abReload.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abReload.MouseClickSound = ""
        abReload.MouseClickSoundResource = Nothing
        abReload.MouseClickSoundResourcePath = ""
        abReload.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abReload.MouseEnterSound = ""
        abReload.MouseEnterSoundResource = Nothing
        abReload.MouseEnterSoundResourcePath = ""
        abReload.Name = "abReload"
        abReload.ResizeTextFontOnResize = False
        abReload.RoundedRadius = 15.0!
        abReload.Shadow = False
        abReload.ShadowAllWithMouseEnter = False
        abReload.ShadowColor = System.Drawing.Color.Green
        abReload.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abReload.ShadowDivisor = 2
        abReload.ShadowWithMouseEnter = False
        abReload.ShiftAllOnClick = True
        abReload.ShiftForeColor = System.Drawing.Color.Green
        abReload.ShiftOnClick = True
        abReload.ShiftShadowColor = System.Drawing.Color.Lime
        abReload.ShowBorder = True
        abReload.Size = New System.Drawing.Size(123, 25)
        abReload.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abReload.TabIndex = 5
        abReload.Text = "Reload BSR"
        abReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abReload.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abReload.TextShadowDisplacement = 1
        abReload.UseCompatibleTextRendering = True
        '
        'abExit
        '
        abExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abExit.ClickHidesParent = False
        abExit.Color1 = System.Drawing.Color.Empty
        abExit.Color2 = System.Drawing.Color.Empty
        abExit.Cursor = System.Windows.Forms.Cursors.Hand
        abExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abExit.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abExit.HasRoundedRectangle = True
        abExit.HasSound = False
        abExit.LineSize = 2
        abExit.Location = New System.Drawing.Point(390, 281)
        abExit.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abExit.MouseClickSound = ""
        abExit.MouseClickSoundResource = Nothing
        abExit.MouseClickSoundResourcePath = ""
        abExit.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abExit.MouseEnterSound = ""
        abExit.MouseEnterSoundResource = Nothing
        abExit.MouseEnterSoundResourcePath = ""
        abExit.Name = "abExit"
        abExit.ResizeTextFontOnResize = False
        abExit.RoundedRadius = 15.0!
        abExit.Shadow = False
        abExit.ShadowAllWithMouseEnter = True
        abExit.ShadowColor = System.Drawing.Color.Green
        abExit.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abExit.ShadowDivisor = 2
        abExit.ShadowWithMouseEnter = True
        abExit.ShiftAllOnClick = True
        abExit.ShiftForeColor = System.Drawing.Color.Green
        abExit.ShiftOnClick = True
        abExit.ShiftShadowColor = System.Drawing.Color.Lime
        abExit.ShowBorder = True
        abExit.Size = New System.Drawing.Size(123, 25)
        abExit.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abExit.TabIndex = 6
        abExit.Text = "Exit"
        abExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abExit.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abExit.TextShadowDisplacement = 1
        abExit.UseCompatibleTextRendering = True
        '
        'frmMain
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(524, 315)
        Controls.Add(abExit)
        Controls.Add(abReload)
        Controls.Add(abSaveReload)
        Controls.Add(abSave)
        Controls.Add(txtINI)
        Controls.Add(abBrdr)
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Name = "frmMain"
        Opacity = 0.75R
        Text = "BlackCrestSoft INI Ultra Lite"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents abBrdr As AcidControls.AcidBorder
    Friend WithEvents txtINI As AcidControls.AcidTextBox
    Friend WithEvents abSave As AcidControls.AcidButton
    Friend WithEvents abSaveReload As AcidControls.AcidButton
    Friend WithEvents abReload As AcidControls.AcidButton
    Friend WithEvents abExit As AcidControls.AcidButton
End Class
