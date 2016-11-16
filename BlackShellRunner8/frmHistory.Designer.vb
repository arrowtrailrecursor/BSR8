<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHistory))
        tmrAutoCom = New System.Windows.Forms.Timer(components)
        abClear = New AcidControls.AcidButton()
        alInfo = New AcidControls.AcidButton()
        abTest = New AcidControls.AcidButton()
        cmbCmd = New AcidControls.AcidComboBox()
        abExit = New AcidControls.AcidButton()
        abRm = New AcidControls.AcidButton()
        abAdd = New AcidControls.AcidButton()
        lstCmds = New AcidControls.AcidListBox()
        abBrdr = New AcidControls.AcidBorder()
        mcttMain = New AcidControls.AcidToolTip(components)
        SuspendLayout()
        '
        'tmrAutoCom
        '
        tmrAutoCom.Interval = 1
        '
        'abClear
        '
        abClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abClear.ClickHidesParent = False
        abClear.Color1 = System.Drawing.Color.Empty
        abClear.Color2 = System.Drawing.Color.Empty
        abClear.Cursor = System.Windows.Forms.Cursors.Hand
        abClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abClear.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abClear.HasRoundedRectangle = True
        abClear.HasSound = False
        abClear.LineSize = 2
        abClear.Location = New System.Drawing.Point(366, 297)
        abClear.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abClear.MouseClickSound = ""
        abClear.MouseClickSoundResource = Nothing
        abClear.MouseClickSoundResourcePath = ""
        abClear.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abClear.MouseEnterSound = ""
        abClear.MouseEnterSoundResource = Nothing
        abClear.MouseEnterSoundResourcePath = ""
        abClear.Name = "abClear"
        abClear.ResizeTextFontOnResize = False
        abClear.RoundedRadius = 10.0!
        abClear.Shadow = False
        abClear.ShadowAllWithMouseEnter = False
        abClear.ShadowColor = System.Drawing.Color.Green
        abClear.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abClear.ShadowDivisor = 2
        abClear.ShadowWithMouseEnter = True
        abClear.ShiftAllOnClick = False
        abClear.ShiftForeColor = System.Drawing.Color.Green
        abClear.ShiftOnClick = True
        abClear.ShiftShadowColor = System.Drawing.Color.Lime
        abClear.ShowBorder = True
        abClear.Size = New System.Drawing.Size(65, 21)
        abClear.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abClear.TabIndex = 9
        abClear.Text = "Clear"
        abClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abClear.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abClear.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abClear, "Clear History")
        abClear.UseCompatibleTextRendering = True
        '
        'alInfo
        '
        alInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        alInfo.ClickHidesParent = False
        alInfo.Color1 = System.Drawing.Color.Empty
        alInfo.Color2 = System.Drawing.Color.Empty
        alInfo.Cursor = System.Windows.Forms.Cursors.Hand
        alInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        alInfo.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        alInfo.HasRoundedRectangle = True
        alInfo.HasSound = False
        alInfo.LineSize = 2
        alInfo.Location = New System.Drawing.Point(8, 6)
        alInfo.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        alInfo.MouseClickSound = ""
        alInfo.MouseClickSoundResource = Nothing
        alInfo.MouseClickSoundResourcePath = ""
        alInfo.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        alInfo.MouseEnterSound = ""
        alInfo.MouseEnterSoundResource = Nothing
        alInfo.MouseEnterSoundResourcePath = ""
        alInfo.Name = "alInfo"
        alInfo.ResizeTextFontOnResize = False
        alInfo.RoundedRadius = 10.0!
        alInfo.Shadow = False
        alInfo.ShadowAllWithMouseEnter = False
        alInfo.ShadowColor = System.Drawing.Color.Green
        alInfo.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        alInfo.ShadowDivisor = 2
        alInfo.ShadowWithMouseEnter = False
        alInfo.ShiftAllOnClick = False
        alInfo.ShiftForeColor = System.Drawing.Color.Green
        alInfo.ShiftOnClick = False
        alInfo.ShiftShadowColor = System.Drawing.Color.Lime
        alInfo.ShowBorder = False
        alInfo.Size = New System.Drawing.Size(492, 16)
        alInfo.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        alInfo.TabIndex = 8
        alInfo.Text = "BlackShellRunner Command List History"
        alInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        alInfo.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        alInfo.TextShadowDisplacement = 1
        mcttMain.SetToolTip(alInfo, "Exit")
        alInfo.UseCompatibleTextRendering = True
        '
        'abTest
        '
        abTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abTest.ClickHidesParent = False
        abTest.Color1 = System.Drawing.Color.Empty
        abTest.Color2 = System.Drawing.Color.Empty
        abTest.Cursor = System.Windows.Forms.Cursors.Hand
        abTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abTest.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abTest.HasRoundedRectangle = True
        abTest.HasSound = False
        abTest.LineSize = 2
        abTest.Location = New System.Drawing.Point(297, 297)
        abTest.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abTest.MouseClickSound = ""
        abTest.MouseClickSoundResource = Nothing
        abTest.MouseClickSoundResourcePath = ""
        abTest.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abTest.MouseEnterSound = ""
        abTest.MouseEnterSoundResource = Nothing
        abTest.MouseEnterSoundResourcePath = ""
        abTest.Name = "abTest"
        abTest.ResizeTextFontOnResize = False
        abTest.RoundedRadius = 10.0!
        abTest.Shadow = False
        abTest.ShadowAllWithMouseEnter = False
        abTest.ShadowColor = System.Drawing.Color.Green
        abTest.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abTest.ShadowDivisor = 2
        abTest.ShadowWithMouseEnter = True
        abTest.ShiftAllOnClick = False
        abTest.ShiftForeColor = System.Drawing.Color.Green
        abTest.ShiftOnClick = True
        abTest.ShiftShadowColor = System.Drawing.Color.Lime
        abTest.ShowBorder = True
        abTest.Size = New System.Drawing.Size(65, 21)
        abTest.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abTest.TabIndex = 7
        abTest.Text = "Test"
        abTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abTest.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abTest.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abTest, "Test Command")
        abTest.UseCompatibleTextRendering = True
        '
        'cmbCmd
        '
        cmbCmd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cmbCmd.ArrowKeysDropList = True
        cmbCmd.AutomaticallyMoveMouseCursorToMiddleOfComboOnListDropDown = True
        cmbCmd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        cmbCmd.DropDownWidth = 217
        cmbCmd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        cmbCmd.FocusRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dot
        cmbCmd.IntegralHeight = False
        cmbCmd.ListSelectedItemRectanglement = True
        cmbCmd.Location = New System.Drawing.Point(8, 297)
        cmbCmd.MaxDropDownItems = 100
        cmbCmd.Name = "cmbCmd"
        cmbCmd.PasteMultilineJoiningCharacter = " "
        cmbCmd.QuantumItemRectanglement = False
        cmbCmd.RegularRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbCmd.RegularShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbCmd.SelectedItemFontStyle = System.Drawing.FontStyle.Bold
        cmbCmd.SelectedItemHasShadow = True
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
        cmbCmd.Size = New System.Drawing.Size(217, 21)
        cmbCmd.TabIndex = 6
        mcttMain.SetToolTip(cmbCmd, "Text To Add Or Remove")
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
        abExit.Location = New System.Drawing.Point(435, 297)
        abExit.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abExit.MouseClickSound = ""
        abExit.MouseClickSoundResource = Nothing
        abExit.MouseClickSoundResourcePath = ""
        abExit.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abExit.MouseEnterSound = ""
        abExit.MouseEnterSoundResource = Nothing
        abExit.MouseEnterSoundResourcePath = ""
        abExit.Name = "abExit"
        abExit.ResizeTextFontOnResize = False
        abExit.RoundedRadius = 10.0!
        abExit.Shadow = False
        abExit.ShadowAllWithMouseEnter = True
        abExit.ShadowColor = System.Drawing.Color.Green
        abExit.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abExit.ShadowDivisor = 2
        abExit.ShadowWithMouseEnter = True
        abExit.ShiftAllOnClick = True
        abExit.ShiftForeColor = System.Drawing.Color.Green
        abExit.ShiftOnClick = False
        abExit.ShiftShadowColor = System.Drawing.Color.Lime
        abExit.ShowBorder = True
        abExit.Size = New System.Drawing.Size(65, 21)
        abExit.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abExit.TabIndex = 5
        abExit.Text = "Exit"
        abExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abExit.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abExit.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abExit, "Exit")
        abExit.UseCompatibleTextRendering = True
        '
        'abRm
        '
        abRm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abRm.ClickHidesParent = False
        abRm.Color1 = System.Drawing.Color.Empty
        abRm.Color2 = System.Drawing.Color.Empty
        abRm.Cursor = System.Windows.Forms.Cursors.Hand
        abRm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abRm.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abRm.HasRoundedRectangle = True
        abRm.HasSound = False
        abRm.LineSize = 2
        abRm.Location = New System.Drawing.Point(263, 297)
        abRm.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abRm.MouseClickSound = ""
        abRm.MouseClickSoundResource = Nothing
        abRm.MouseClickSoundResourcePath = ""
        abRm.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abRm.MouseEnterSound = ""
        abRm.MouseEnterSoundResource = Nothing
        abRm.MouseEnterSoundResourcePath = ""
        abRm.Name = "abRm"
        abRm.ResizeTextFontOnResize = False
        abRm.RoundedRadius = 10.0!
        abRm.Shadow = False
        abRm.ShadowAllWithMouseEnter = False
        abRm.ShadowColor = System.Drawing.Color.Green
        abRm.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abRm.ShadowDivisor = 2
        abRm.ShadowWithMouseEnter = True
        abRm.ShiftAllOnClick = False
        abRm.ShiftForeColor = System.Drawing.Color.Green
        abRm.ShiftOnClick = True
        abRm.ShiftShadowColor = System.Drawing.Color.Lime
        abRm.ShowBorder = True
        abRm.Size = New System.Drawing.Size(30, 21)
        abRm.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abRm.TabIndex = 4
        abRm.Text = "-"
        abRm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abRm.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abRm.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abRm, "Remove From List")
        abRm.UseCompatibleTextRendering = True
        '
        'abAdd
        '
        abAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abAdd.ClickHidesParent = False
        abAdd.Color1 = System.Drawing.Color.Empty
        abAdd.Color2 = System.Drawing.Color.Empty
        abAdd.Cursor = System.Windows.Forms.Cursors.Hand
        abAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abAdd.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abAdd.HasRoundedRectangle = True
        abAdd.HasSound = False
        abAdd.LineSize = 2
        abAdd.Location = New System.Drawing.Point(229, 297)
        abAdd.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abAdd.MouseClickSound = ""
        abAdd.MouseClickSoundResource = Nothing
        abAdd.MouseClickSoundResourcePath = ""
        abAdd.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abAdd.MouseEnterSound = ""
        abAdd.MouseEnterSoundResource = Nothing
        abAdd.MouseEnterSoundResourcePath = ""
        abAdd.Name = "abAdd"
        abAdd.ResizeTextFontOnResize = False
        abAdd.RoundedRadius = 10.0!
        abAdd.Shadow = False
        abAdd.ShadowAllWithMouseEnter = False
        abAdd.ShadowColor = System.Drawing.Color.Green
        abAdd.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abAdd.ShadowDivisor = 2
        abAdd.ShadowWithMouseEnter = True
        abAdd.ShiftAllOnClick = False
        abAdd.ShiftForeColor = System.Drawing.Color.Green
        abAdd.ShiftOnClick = True
        abAdd.ShiftShadowColor = System.Drawing.Color.Lime
        abAdd.ShowBorder = True
        abAdd.Size = New System.Drawing.Size(30, 21)
        abAdd.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abAdd.TabIndex = 3
        abAdd.Text = "+"
        abAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abAdd.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abAdd.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abAdd, "Add To List")
        abAdd.UseCompatibleTextRendering = True
        '
        'lstCmds
        '
        lstCmds.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        lstCmds.BorderStyle = System.Windows.Forms.BorderStyle.None
        lstCmds.Cursor = System.Windows.Forms.Cursors.Hand
        lstCmds.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        lstCmds.FocusRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        lstCmds.FormattingEnabled = True
        lstCmds.HasRoundedRectangle = False
        lstCmds.HorizontalScrollbar = True
        lstCmds.IntegralHeight = False
        lstCmds.LineSize = 2
        lstCmds.ListSelectedItemRectanglement = True
        lstCmds.Location = New System.Drawing.Point(8, 25)
        lstCmds.Name = "lstCmds"
        lstCmds.QuantumItemRectanglement = False
        lstCmds.RegularRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        lstCmds.RegularShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        lstCmds.SelectedItemFontStyle = System.Drawing.FontStyle.Bold
        lstCmds.SelectedItemHasShadow = True
        lstCmds.SelectedRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        lstCmds.SelectedShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        lstCmds.SelectionBackColor = System.Drawing.Color.Green
        lstCmds.SelectionForeColor = System.Drawing.Color.Lime
        lstCmds.Shadow = False
        lstCmds.ShadowColor = System.Drawing.Color.Green
        lstCmds.ShadowDivisor = 2
        lstCmds.ShadowOnMouseEnter = False
        lstCmds.ShiftForeColor = System.Drawing.Color.Green
        lstCmds.ShiftOnClick = False
        lstCmds.ShiftShadowColor = System.Drawing.Color.Lime
        lstCmds.ShowExtenderToolTips = False
        lstCmds.Size = New System.Drawing.Size(492, 266)
        lstCmds.TabIndex = 0
        lstCmds.TextShadowDisplacement = 1
        '
        'abBrdr
        '
        abBrdr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abBrdr.ClickHidesParent = False
        abBrdr.Color1 = System.Drawing.Color.Empty
        abBrdr.Color2 = System.Drawing.Color.Empty
        abBrdr.Cursor = System.Windows.Forms.Cursors.Default
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
        abBrdr.Size = New System.Drawing.Size(508, 325)
        abBrdr.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBrdr.TabIndex = 2
        abBrdr.Text = "Lblshp1"
        abBrdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBrdr.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBrdr.TextShadowDisplacement = 1
        abBrdr.UseCompatibleTextRendering = True
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
        'frmHistory
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(508, 325)
        Controls.Add(abClear)
        Controls.Add(alInfo)
        Controls.Add(abTest)
        Controls.Add(cmbCmd)
        Controls.Add(abExit)
        Controls.Add(abRm)
        Controls.Add(abAdd)
        Controls.Add(lstCmds)
        Controls.Add(abBrdr)
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmHistory"
        Opacity = 0.8R
        ShowInTaskbar = False
        Text = "BlackShellRunner History"
        ResumeLayout(False)

    End Sub
    Protected Friend WithEvents lstCmds As AcidControls.AcidListBox
    Protected Friend WithEvents abAdd As AcidControls.AcidButton
    Protected Friend WithEvents abRm As AcidControls.AcidButton
    Protected Friend WithEvents abExit As AcidControls.AcidButton
    Protected Friend WithEvents cmbCmd As AcidControls.AcidComboBox
    Protected Friend WithEvents tmrAutoCom As System.Windows.Forms.Timer
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip
    Protected Friend WithEvents abTest As AcidControls.AcidButton
    Protected Friend WithEvents alInfo As AcidControls.AcidButton
    Protected Friend WithEvents abClear As AcidControls.AcidButton
    Private components As System.ComponentModel.IContainer
    Protected Friend WithEvents abBrdr As AcidControls.AcidBorder
End Class
