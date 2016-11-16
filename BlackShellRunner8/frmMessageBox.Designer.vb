<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageBox
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMessageBox))
        pbPics = New System.Windows.Forms.PictureBox()
        txtMessage = New System.Windows.Forms.TextBox()
        abBrdr = New AcidControls.AcidBorder()
        CType(pbPics, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'pbPics
        '
        pbPics.BackColor = System.Drawing.Color.Black
        pbPics.Image = CType(resources.GetObject("pbPics.Image"), System.Drawing.Image)
        pbPics.Location = New System.Drawing.Point(12, 12)
        pbPics.Name = "pbPics"
        pbPics.Size = New System.Drawing.Size(48, 48)
        pbPics.TabIndex = 0
        pbPics.TabStop = False
        '
        'txtMessage
        '
        txtMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtMessage.BackColor = System.Drawing.Color.Black
        txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        txtMessage.ForeColor = System.Drawing.Color.Lime
        txtMessage.Location = New System.Drawing.Point(86, 18)
        txtMessage.Multiline = True
        txtMessage.Name = "txtMessage"
        txtMessage.ReadOnly = True
        txtMessage.Size = New System.Drawing.Size(158, 42)
        txtMessage.TabIndex = 3
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
        abBrdr.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBrdr.MouseClickSound = ""
        abBrdr.MouseClickSoundResource = Nothing
        abBrdr.MouseClickSoundResourcePath = ""
        abBrdr.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
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
        abBrdr.Size = New System.Drawing.Size(256, 87)
        abBrdr.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBrdr.TabIndex = 2
        abBrdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBrdr.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBrdr.TextShadowDisplacement = 0
        abBrdr.UseCompatibleTextRendering = True
        '
        'frmMessageBox
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(256, 87)
        Controls.Add(txtMessage)
        Controls.Add(pbPics)
        Controls.Add(abBrdr)
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmMessageBox"
        ShowInTaskbar = False
        StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        TopMost = True
        CType(pbPics, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Protected Friend WithEvents pbPics As System.Windows.Forms.PictureBox
    Protected Friend WithEvents txtMessage As System.Windows.Forms.TextBox
    Private components As System.ComponentModel.IContainer
    Protected Friend WithEvents abBrdr As AcidControls.AcidBorder
End Class
