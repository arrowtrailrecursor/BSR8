<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOutput))
        txtOutput = New AcidControls.AcidTextBox()
        abOK = New AcidControls.AcidButton()
        abBorder = New AcidControls.AcidButton()
        mcttMain = New AcidControls.AcidToolTip(components)
        SuspendLayout()
        '
        'txtOutput
        '
        txtOutput.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtOutput.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txtOutput.LineSize = 2
        txtOutput.Location = New System.Drawing.Point(13, 13)
        txtOutput.Multiline = True
        txtOutput.Name = "txtOutput"
        txtOutput.PasteMultilineJoiningCharacter = " "
        txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        txtOutput.Shadow = False
        txtOutput.ShadowColor = System.Drawing.Color.Green
        txtOutput.ShadowDivisor = 2
        txtOutput.ShadowOnMouseEnter = False
        txtOutput.ShiftForeColor = System.Drawing.Color.Green
        txtOutput.ShiftOnClick = False
        txtOutput.ShiftShadowColor = System.Drawing.Color.Lime
        txtOutput.Size = New System.Drawing.Size(393, 191)
        txtOutput.TabIndex = 2
        mcttMain.SetToolTip(txtOutput, "PowerShell Output")
        txtOutput.WordWrap = False
        '
        'abOK
        '
        abOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        abOK.ClickHidesParent = False
        abOK.Color1 = System.Drawing.Color.Empty
        abOK.Color2 = System.Drawing.Color.Empty
        abOK.Cursor = System.Windows.Forms.Cursors.Hand
        abOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abOK.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abOK.HasRoundedRectangle = True
        abOK.HasSound = False
        abOK.LineSize = 2
        abOK.Location = New System.Drawing.Point(164, 209)
        abOK.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abOK.MouseClickSound = ""
        abOK.MouseClickSoundResource = Nothing
        abOK.MouseClickSoundResourcePath = ""
        abOK.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abOK.MouseEnterSound = ""
        abOK.MouseEnterSoundResource = Nothing
        abOK.MouseEnterSoundResourcePath = ""
        abOK.Name = "abOK"
        abOK.ResizeTextFontOnResize = False
        abOK.RoundedRadius = 10.0!
        abOK.Shadow = False
        abOK.ShadowAllWithMouseEnter = True
        abOK.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        abOK.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abOK.ShadowDivisor = 2
        abOK.ShadowWithMouseEnter = False
        abOK.ShiftAllOnClick = True
        abOK.ShiftForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        abOK.ShiftOnClick = False
        abOK.ShiftShadowColor = System.Drawing.Color.White
        abOK.ShowBorder = True
        abOK.Size = New System.Drawing.Size(91, 20)
        abOK.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abOK.TabIndex = 1
        abOK.Text = "OK"
        abOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abOK.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abOK.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abOK, "OK")
        abOK.UseCompatibleTextRendering = True
        '
        'abBorder
        '
        abBorder.ClickHidesParent = False
        abBorder.Color1 = System.Drawing.Color.Empty
        abBorder.Color2 = System.Drawing.Color.Empty
        abBorder.Cursor = System.Windows.Forms.Cursors.Hand
        abBorder.Dock = System.Windows.Forms.DockStyle.Fill
        abBorder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abBorder.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abBorder.HasRoundedRectangle = True
        abBorder.HasSound = False
        abBorder.LineSize = 2
        abBorder.Location = New System.Drawing.Point(0, 0)
        abBorder.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBorder.MouseClickSound = ""
        abBorder.MouseClickSoundResource = Nothing
        abBorder.MouseClickSoundResourcePath = ""
        abBorder.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBorder.MouseEnterSound = ""
        abBorder.MouseEnterSoundResource = Nothing
        abBorder.MouseEnterSoundResourcePath = ""
        abBorder.Name = "abBorder"
        abBorder.ResizeTextFontOnResize = False
        abBorder.RoundedRadius = 5.0!
        abBorder.Shadow = False
        abBorder.ShadowAllWithMouseEnter = False
        abBorder.ShadowColor = System.Drawing.Color.DodgerBlue
        abBorder.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abBorder.ShadowDivisor = 2
        abBorder.ShadowWithMouseEnter = False
        abBorder.ShiftAllOnClick = False
        abBorder.ShiftForeColor = System.Drawing.Color.DodgerBlue
        abBorder.ShiftOnClick = False
        abBorder.ShiftShadowColor = System.Drawing.Color.White
        abBorder.ShowBorder = True
        abBorder.Size = New System.Drawing.Size(418, 236)
        abBorder.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBorder.TabIndex = 0
        abBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBorder.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBorder.TextShadowDisplacement = 1
        abBorder.UseCompatibleTextRendering = True
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
        'frmOutput
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Black
        ClientSize = New System.Drawing.Size(418, 236)
        Controls.Add(txtOutput)
        Controls.Add(abOK)
        Controls.Add(abBorder)
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        MinimizeBox = False
        Name = "frmOutput"
        StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Text = "Microsoft Windows PowerShell "
        TopMost = True
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Protected Friend WithEvents abBorder As AcidControls.AcidButton
    Protected Friend WithEvents abOK As AcidControls.AcidButton
    Protected Friend WithEvents txtOutput As AcidControls.AcidTextBox
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip
    Private components As System.ComponentModel.IContainer
End Class
