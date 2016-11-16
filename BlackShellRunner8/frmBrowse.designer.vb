<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBrowse
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
    Protected Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBrowse))
        FileView = New LogicNP.FileViewControl.FileView(components)
        FolderView = New LogicNP.FolderViewControl.FolderView()
        txtFile = New AcidControls.AcidTextBox()
        SplitContainer = New System.Windows.Forms.SplitContainer()
        abBrdr = New AcidControls.AcidBorder()
        abOK = New AcidControls.AcidButton()
        abCncl = New AcidControls.AcidButton()
        mcttMain = New AcidControls.AcidToolTip(components)
        CType(SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer.Panel1.SuspendLayout()
        SplitContainer.Panel2.SuspendLayout()
        SplitContainer.SuspendLayout()
        SuspendLayout()
        '
        'FileView
        '
        FileView.AllowDragDrop = False
        FileView.AllowDragDropItemOrdering = False
        FileView.AllowFileExecution = False
        FileView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FileView.BackColor = System.Drawing.Color.Black
        FileView.Cursor = System.Windows.Forms.Cursors.Hand
        FileView.EnableVistaTheme = False
        FileView.ForeColor = System.Drawing.Color.Lime
        FileView.Location = New System.Drawing.Point(0, 0)
        FileView.Name = "FileView"
        FileView.ShowSortColumnShaded = False
        FileView.ShowSpecialFolders = False
        FileView.Size = New System.Drawing.Size(266, 294)
        FileView.TabIndex = 0
        mcttMain.SetToolTip(FileView, "Select A Path")
        FileView.ViewStyle = LogicNP.FileViewControl.ViewStyles.Report
        '
        'FolderView
        '
        FolderView.AllowDragDrop = False
        FolderView.AllowNodeRenaming = False
        FolderView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        FolderView.BackColor = System.Drawing.Color.Black
        FolderView.Cursor = System.Windows.Forms.Cursors.Hand
        FolderView.EnableVistaTheme = False
        FolderView.ExpandSelectedNode = True
        FolderView.FileView = FileView
        FolderView.ForeColor = System.Drawing.Color.Lime
        FolderView.FullRowSelect = True
        FolderView.HasLinesAtRoot = True
        FolderView.HideSelection = True
        FolderView.LineColor = System.Drawing.Color.Lime
        FolderView.Location = New System.Drawing.Point(0, 0)
        FolderView.Name = "FolderView"
        FolderView.NodeHeight = 16
        FolderView.RightToLeft = System.Windows.Forms.RightToLeft.No
        FolderView.ShowInfoTips = True
        FolderView.Size = New System.Drawing.Size(238, 294)
        FolderView.StartingPIDL = CType(resources.GetObject("FolderView.StartingPIDL"), LogicNP.FolderViewControl.PIDL)
        FolderView.TabIndex = 1
        mcttMain.SetToolTip(FolderView, "Select A Directory")
        '
        'txtFile
        '
        txtFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        txtFile.LineSize = 2
        txtFile.Location = New System.Drawing.Point(12, 315)
        txtFile.Name = "txtFile"
        txtFile.PasteMultilineJoiningCharacter = " "
        txtFile.Shadow = False
        txtFile.ShadowColor = System.Drawing.Color.Green
        txtFile.ShadowDivisor = 2
        txtFile.ShadowOnMouseEnter = False
        txtFile.ShiftForeColor = System.Drawing.Color.Green
        txtFile.ShiftOnClick = False
        txtFile.ShiftShadowColor = System.Drawing.Color.Lime
        txtFile.Size = New System.Drawing.Size(342, 20)
        txtFile.TabIndex = 2
        mcttMain.SetToolTip(txtFile, "Path")
        '
        'SplitContainer
        '
        SplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        SplitContainer.Location = New System.Drawing.Point(12, 12)
        SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        SplitContainer.Panel1.Controls.Add(FolderView)
        '
        'SplitContainer.Panel2
        '
        SplitContainer.Panel2.Controls.Add(FileView)
        SplitContainer.Size = New System.Drawing.Size(508, 294)
        SplitContainer.SplitterDistance = 238
        SplitContainer.TabIndex = 3
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
        abBrdr.Size = New System.Drawing.Size(532, 345)
        abBrdr.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBrdr.TabIndex = 4
        abBrdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBrdr.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBrdr.TextShadowDisplacement = 1
        abBrdr.UseCompatibleTextRendering = True
        '
        'abOK
        '
        abOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abOK.ClickHidesParent = False
        abOK.Color1 = System.Drawing.Color.Empty
        abOK.Color2 = System.Drawing.Color.Empty
        abOK.Cursor = System.Windows.Forms.Cursors.Hand
        abOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abOK.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abOK.HasRoundedRectangle = True
        abOK.HasSound = False
        abOK.LineSize = 2
        abOK.Location = New System.Drawing.Point(360, 315)
        abOK.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abOK.MouseClickSound = ""
        abOK.MouseClickSoundResource = Nothing
        abOK.MouseClickSoundResourcePath = ""
        abOK.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abOK.MouseEnterSound = ""
        abOK.MouseEnterSoundResource = Nothing
        abOK.MouseEnterSoundResourcePath = ""
        abOK.Name = "abOK"
        abOK.ResizeTextFontOnResize = False
        abOK.RoundedRadius = 10.0!
        abOK.Shadow = False
        abOK.ShadowAllWithMouseEnter = True
        abOK.ShadowColor = System.Drawing.Color.Green
        abOK.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abOK.ShadowDivisor = 2
        abOK.ShadowWithMouseEnter = False
        abOK.ShiftAllOnClick = True
        abOK.ShiftForeColor = System.Drawing.Color.Green
        abOK.ShiftOnClick = False
        abOK.ShiftShadowColor = System.Drawing.Color.Lime
        abOK.ShowBorder = True
        abOK.Size = New System.Drawing.Size(77, 20)
        abOK.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abOK.TabIndex = 5
        abOK.Text = "OK"
        abOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abOK.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abOK.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abOK, "OK")
        abOK.UseCompatibleTextRendering = True
        '
        'abCncl
        '
        abCncl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abCncl.ClickHidesParent = False
        abCncl.Color1 = System.Drawing.Color.Empty
        abCncl.Color2 = System.Drawing.Color.Empty
        abCncl.Cursor = System.Windows.Forms.Cursors.Hand
        abCncl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abCncl.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abCncl.HasRoundedRectangle = True
        abCncl.HasSound = False
        abCncl.LineSize = 2
        abCncl.Location = New System.Drawing.Point(443, 315)
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
        abCncl.ShadowWithMouseEnter = False
        abCncl.ShiftAllOnClick = True
        abCncl.ShiftForeColor = System.Drawing.Color.Green
        abCncl.ShiftOnClick = False
        abCncl.ShiftShadowColor = System.Drawing.Color.Lime
        abCncl.ShowBorder = True
        abCncl.Size = New System.Drawing.Size(77, 20)
        abCncl.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abCncl.TabIndex = 6
        abCncl.Text = "Cancel"
        abCncl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abCncl.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abCncl.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abCncl, "Cancel")
        abCncl.UseCompatibleTextRendering = True
        '
        'mcttMain
        '
        mcttMain.AutoPopDelay = 5000
        mcttMain.BackColor = System.Drawing.Color.Black
        mcttMain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        mcttMain.ForeColor = System.Drawing.Color.Lime
        mcttMain.InitialDelay = 100
        mcttMain.OwnerDraw = True
        mcttMain.ReshowDelay = 100
        mcttMain.ShowAlways = True
        mcttMain.UseAnimation = False
        mcttMain.UseTransparentFading = True
        '
        'frmBrowse
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        AutoValidate = System.Windows.Forms.AutoValidate.Disable
        BackColor = System.Drawing.Color.Black
        ClientSize = New System.Drawing.Size(532, 345)
        Controls.Add(abCncl)
        Controls.Add(abOK)
        Controls.Add(SplitContainer)
        Controls.Add(txtFile)
        Controls.Add(abBrdr)
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmBrowse"
        ShowInTaskbar = False
        Text = "BlackShellRunner Browse For Path"
        SplitContainer.Panel1.ResumeLayout(False)
        SplitContainer.Panel2.ResumeLayout(False)
        CType(SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        SplitContainer.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Protected Friend WithEvents FileView As LogicNP.FileViewControl.FileView
    Protected Friend WithEvents FolderView As LogicNP.FolderViewControl.FolderView
    Protected Friend WithEvents txtFile As AcidControls.AcidTextBox
    Protected Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Protected Friend WithEvents abOK As AcidControls.AcidButton
    Protected Friend WithEvents abCncl As AcidControls.AcidButton
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip
    Private components As System.ComponentModel.IContainer
    Protected Friend WithEvents abBrdr As AcidControls.AcidBorder

End Class
