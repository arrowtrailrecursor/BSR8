<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFolderDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFolderDialog))
        abBrdr = New AcidControls.AcidBorder()
        abOk = New AcidControls.AcidButton()
        txtDir = New AcidControls.AcidTextBox()
        mcttMain = New AcidControls.AcidToolTip(components)
        FolderView = New LogicNP.FolderViewControl.FolderView()
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
        abBrdr.Size = New System.Drawing.Size(387, 321)
        abBrdr.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBrdr.TabIndex = 0
        abBrdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBrdr.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBrdr.TextShadowDisplacement = 1
        abBrdr.UseCompatibleTextRendering = True
        '
        'abOk
        '
        abOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abOk.ClickHidesParent = False
        abOk.Color1 = System.Drawing.Color.Empty
        abOk.Color2 = System.Drawing.Color.Empty
        abOk.Cursor = System.Windows.Forms.Cursors.Hand
        abOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abOk.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abOk.HasRoundedRectangle = True
        abOk.HasSound = False
        abOk.LineSize = 2
        abOk.Location = New System.Drawing.Point(294, 289)
        abOk.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abOk.MouseClickSound = ""
        abOk.MouseClickSoundResource = Nothing
        abOk.MouseClickSoundResourcePath = ""
        abOk.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
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
        abOk.Size = New System.Drawing.Size(81, 20)
        abOk.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abOk.TabIndex = 2
        abOk.Text = "OK"
        abOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abOk.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abOk.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abOk, "OK")
        abOk.UseCompatibleTextRendering = True
        '
        'txtDir
        '
        txtDir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtDir.LineSize = 2
        txtDir.Location = New System.Drawing.Point(12, 289)
        txtDir.Name = "txtDir"
        txtDir.PasteMultilineJoiningCharacter = " "
        txtDir.Shadow = False
        txtDir.ShadowColor = System.Drawing.Color.Green
        txtDir.ShadowDivisor = 2
        txtDir.ShadowOnMouseEnter = False
        txtDir.ShiftForeColor = System.Drawing.Color.Green
        txtDir.ShiftOnClick = False
        txtDir.ShiftShadowColor = System.Drawing.Color.Lime
        txtDir.Size = New System.Drawing.Size(275, 20)
        txtDir.TabIndex = 3
        mcttMain.SetToolTip(txtDir, "Directory Path")
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
        'FolderView
        '
        FolderView.BackColor = System.Drawing.Color.Black
        FolderView.EnableVistaTheme = False
        FolderView.ForeColor = System.Drawing.Color.Lime
        FolderView.LineColor = System.Drawing.Color.Lime
        FolderView.Location = New System.Drawing.Point(12, 12)
        FolderView.Name = "FolderView"
        FolderView.Size = New System.Drawing.Size(363, 271)
        FolderView.TabIndex = 4
        '
        'frmFolderDialog
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(387, 321)
        Controls.Add(FolderView)
        Controls.Add(txtDir)
        Controls.Add(abOk)
        Controls.Add(abBrdr)
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Name = "frmFolderDialog"
        Text = "Browse For Directory"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Protected Friend WithEvents abOk As AcidControls.AcidButton
    Protected Friend WithEvents txtDir As AcidControls.AcidTextBox
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip
    Private components As System.ComponentModel.IContainer
    Protected Friend WithEvents abBrdr As AcidControls.AcidBorder
    Friend WithEvents FolderView As LogicNP.FolderViewControl.FolderView
End Class
