<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomCommads
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomCommads))
        SplitContainer = New System.Windows.Forms.SplitContainer()
        lstCstCmds = New AcidControls.AcidListBox()
        SplitContainer1 = New System.Windows.Forms.SplitContainer()
        abOverCommand = New AcidControls.AcidButton()
        SplitContainer2 = New System.Windows.Forms.SplitContainer()
        lstCstCmdsCmds = New AcidControls.AcidListBox()
        abMinus = New AcidControls.AcidButton()
        abDownLastToBelow = New AcidControls.AcidButton()
        abExpandFromOneCommand = New AcidControls.AcidButton()
        abCollapseToOneCommand = New AcidControls.AcidButton()
        cmbSep = New AcidControls.AcidComboBox()
        abUpBelowToLast = New AcidControls.AcidButton()
        abFrontToBack = New AcidControls.AcidButton()
        abBackToFront = New AcidControls.AcidButton()
        abPlus = New AcidControls.AcidButton()
        picMain = New System.Windows.Forms.PictureBox()
        tmrSetIcon = New System.Windows.Forms.Timer(components)
        abTestCstmCmdCmd = New AcidControls.AcidButton()
        abTestCstmCmd = New AcidControls.AcidButton()
        alRunThisCommandAtStartUp = New AcidControls.AcidButton()
        cmbStartUpCommand = New AcidControls.AcidComboBox()
        abOk = New AcidControls.AcidButton()
        abRm = New AcidControls.AcidButton()
        abAdd = New AcidControls.AcidButton()
        cmbCstCmdsCmds = New AcidControls.AcidComboBox()
        abRmCst = New AcidControls.AcidButton()
        abAddCst = New AcidControls.AcidButton()
        cmbCstCmds = New AcidControls.AcidComboBox()
        abBrdr = New AcidControls.AcidBorder()
        mcttMain = New AcidControls.AcidToolTip(components)
        CType(SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer.Panel1.SuspendLayout()
        SplitContainer.Panel2.SuspendLayout()
        SplitContainer.SuspendLayout()
        CType(SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer2.Panel1.SuspendLayout()
        SplitContainer2.Panel2.SuspendLayout()
        SplitContainer2.SuspendLayout()
        CType(picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'SplitContainer
        '
        SplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        SplitContainer.ForeColor = System.Drawing.Color.Lime
        SplitContainer.Location = New System.Drawing.Point(7, 32)
        SplitContainer.Name = "SplitContainer"
        '
        'SplitContainer.Panel1
        '
        SplitContainer.Panel1.Controls.Add(lstCstCmds)
        '
        'SplitContainer.Panel2
        '
        SplitContainer.Panel2.Controls.Add(SplitContainer1)
        SplitContainer.Size = New System.Drawing.Size(530, 226)
        SplitContainer.SplitterDistance = 180
        SplitContainer.TabIndex = 10
        '
        'lstCstCmds
        '
        lstCstCmds.BorderStyle = System.Windows.Forms.BorderStyle.None
        lstCstCmds.Cursor = System.Windows.Forms.Cursors.Hand
        lstCstCmds.Dock = System.Windows.Forms.DockStyle.Fill
        lstCstCmds.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        lstCstCmds.FocusRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dot
        lstCstCmds.FormattingEnabled = True
        lstCstCmds.HasRoundedRectangle = False
        lstCstCmds.HorizontalScrollbar = True
        lstCstCmds.IntegralHeight = False
        lstCstCmds.LineSize = 2
        lstCstCmds.ListSelectedItemRectanglement = True
        lstCstCmds.Location = New System.Drawing.Point(0, 0)
        lstCstCmds.Name = "lstCstCmds"
        lstCstCmds.QuantumItemRectanglement = False
        lstCstCmds.RegularRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        lstCstCmds.RegularShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        lstCstCmds.SelectedItemFontStyle = System.Drawing.FontStyle.Bold
        lstCstCmds.SelectedItemHasShadow = True
        lstCstCmds.SelectedRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        lstCstCmds.SelectedShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        lstCstCmds.SelectionBackColor = System.Drawing.Color.Green
        lstCstCmds.SelectionForeColor = System.Drawing.Color.Lime
        lstCstCmds.Shadow = False
        lstCstCmds.ShadowColor = System.Drawing.Color.Green
        lstCstCmds.ShadowDivisor = 2
        lstCstCmds.ShadowOnMouseEnter = False
        lstCstCmds.ShiftForeColor = System.Drawing.Color.Green
        lstCstCmds.ShiftOnClick = False
        lstCstCmds.ShiftShadowColor = System.Drawing.Color.Lime
        lstCstCmds.ShowExtenderToolTips = True
        lstCstCmds.Size = New System.Drawing.Size(180, 226)
        lstCstCmds.TabIndex = 6
        lstCstCmds.TextShadowDisplacement = 1
        '
        'SplitContainer1
        '
        SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        SplitContainer1.Location = New System.Drawing.Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        SplitContainer1.Panel1.Controls.Add(abOverCommand)
        SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        SplitContainer1.Panel2.Controls.Add(SplitContainer2)
        SplitContainer1.Size = New System.Drawing.Size(346, 226)
        SplitContainer1.SplitterDistance = 31
        SplitContainer1.TabIndex = 0
        '
        'abOverCommand
        '
        abOverCommand.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abOverCommand.ClickHidesParent = False
        abOverCommand.Color1 = System.Drawing.Color.Empty
        abOverCommand.Color2 = System.Drawing.Color.Empty
        abOverCommand.Cursor = System.Windows.Forms.Cursors.Hand
        abOverCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abOverCommand.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abOverCommand.HasRoundedRectangle = True
        abOverCommand.HasSound = False
        abOverCommand.LineSize = 2
        abOverCommand.Location = New System.Drawing.Point(0, 0)
        abOverCommand.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abOverCommand.MouseClickSound = ""
        abOverCommand.MouseClickSoundResource = Nothing
        abOverCommand.MouseClickSoundResourcePath = ""
        abOverCommand.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abOverCommand.MouseEnterSound = ""
        abOverCommand.MouseEnterSoundResource = Nothing
        abOverCommand.MouseEnterSoundResourcePath = ""
        abOverCommand.Name = "abOverCommand"
        abOverCommand.ResizeTextFontOnResize = False
        abOverCommand.RoundedRadius = 10.0!
        abOverCommand.Shadow = False
        abOverCommand.ShadowAllWithMouseEnter = False
        abOverCommand.ShadowColor = System.Drawing.Color.Green
        abOverCommand.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abOverCommand.ShadowDivisor = 2
        abOverCommand.ShadowWithMouseEnter = True
        abOverCommand.ShiftAllOnClick = False
        abOverCommand.ShiftForeColor = System.Drawing.Color.Green
        abOverCommand.ShiftOnClick = True
        abOverCommand.ShiftShadowColor = System.Drawing.Color.Lime
        abOverCommand.ShowBorder = True
        abOverCommand.Size = New System.Drawing.Size(29, 226)
        abOverCommand.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abOverCommand.TabIndex = 20
        abOverCommand.Text = ">>"
        abOverCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abOverCommand.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abOverCommand.TextShadowDisplacement = 1
        abOverCommand.UseCompatibleTextRendering = True
        '
        'SplitContainer2
        '
        SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        SplitContainer2.Location = New System.Drawing.Point(0, 0)
        SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        SplitContainer2.Panel1.Controls.Add(lstCstCmdsCmds)
        SplitContainer2.Panel1MinSize = 50
        '
        'SplitContainer2.Panel2
        '
        SplitContainer2.Panel2.Controls.Add(abMinus)
        SplitContainer2.Panel2.Controls.Add(abDownLastToBelow)
        SplitContainer2.Panel2.Controls.Add(abExpandFromOneCommand)
        SplitContainer2.Panel2.Controls.Add(abCollapseToOneCommand)
        SplitContainer2.Panel2.Controls.Add(cmbSep)
        SplitContainer2.Panel2.Controls.Add(abUpBelowToLast)
        SplitContainer2.Panel2.Controls.Add(abFrontToBack)
        SplitContainer2.Panel2.Controls.Add(abBackToFront)
        SplitContainer2.Panel2.Controls.Add(abPlus)
        SplitContainer2.Panel2MinSize = 65
        SplitContainer2.Size = New System.Drawing.Size(346, 226)
        SplitContainer2.SplitterDistance = 276
        SplitContainer2.TabIndex = 0
        '
        'lstCstCmdsCmds
        '
        lstCstCmdsCmds.BorderStyle = System.Windows.Forms.BorderStyle.None
        lstCstCmdsCmds.Cursor = System.Windows.Forms.Cursors.Hand
        lstCstCmdsCmds.Dock = System.Windows.Forms.DockStyle.Fill
        lstCstCmdsCmds.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        lstCstCmdsCmds.FocusRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        lstCstCmdsCmds.FormattingEnabled = True
        lstCstCmdsCmds.HasRoundedRectangle = False
        lstCstCmdsCmds.HorizontalScrollbar = True
        lstCstCmdsCmds.IntegralHeight = False
        lstCstCmdsCmds.LineSize = 2
        lstCstCmdsCmds.ListSelectedItemRectanglement = True
        lstCstCmdsCmds.Location = New System.Drawing.Point(0, 0)
        lstCstCmdsCmds.Name = "lstCstCmdsCmds"
        lstCstCmdsCmds.QuantumItemRectanglement = False
        lstCstCmdsCmds.RegularRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        lstCstCmdsCmds.RegularShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        lstCstCmdsCmds.SelectedItemFontStyle = System.Drawing.FontStyle.Bold
        lstCstCmdsCmds.SelectedItemHasShadow = True
        lstCstCmdsCmds.SelectedRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        lstCstCmdsCmds.SelectedShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        lstCstCmdsCmds.SelectionBackColor = System.Drawing.Color.Green
        lstCstCmdsCmds.SelectionForeColor = System.Drawing.Color.Lime
        lstCstCmdsCmds.Shadow = False
        lstCstCmdsCmds.ShadowColor = System.Drawing.Color.Green
        lstCstCmdsCmds.ShadowDivisor = 2
        lstCstCmdsCmds.ShadowOnMouseEnter = False
        lstCstCmdsCmds.ShiftForeColor = System.Drawing.Color.Green
        lstCstCmdsCmds.ShiftOnClick = False
        lstCstCmdsCmds.ShiftShadowColor = System.Drawing.Color.Lime
        lstCstCmdsCmds.ShowExtenderToolTips = True
        lstCstCmdsCmds.Size = New System.Drawing.Size(276, 226)
        lstCstCmdsCmds.TabIndex = 11
        lstCstCmdsCmds.TextShadowDisplacement = 0
        '
        'abMinus
        '
        abMinus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abMinus.ClickHidesParent = False
        abMinus.Color1 = System.Drawing.Color.Empty
        abMinus.Color2 = System.Drawing.Color.Empty
        abMinus.Cursor = System.Windows.Forms.Cursors.Hand
        abMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abMinus.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abMinus.HasRoundedRectangle = True
        abMinus.HasSound = False
        abMinus.LineSize = 2
        abMinus.Location = New System.Drawing.Point(0, 0)
        abMinus.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abMinus.MouseClickSound = ""
        abMinus.MouseClickSoundResource = Nothing
        abMinus.MouseClickSoundResourcePath = ""
        abMinus.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abMinus.MouseEnterSound = ""
        abMinus.MouseEnterSoundResource = Nothing
        abMinus.MouseEnterSoundResourcePath = ""
        abMinus.Name = "abMinus"
        abMinus.ResizeTextFontOnResize = False
        abMinus.RoundedRadius = 10.0!
        abMinus.Shadow = False
        abMinus.ShadowAllWithMouseEnter = False
        abMinus.ShadowColor = System.Drawing.Color.Green
        abMinus.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abMinus.ShadowDivisor = 2
        abMinus.ShadowWithMouseEnter = True
        abMinus.ShiftAllOnClick = False
        abMinus.ShiftForeColor = System.Drawing.Color.Green
        abMinus.ShiftOnClick = True
        abMinus.ShiftShadowColor = System.Drawing.Color.Lime
        abMinus.ShowBorder = True
        abMinus.Size = New System.Drawing.Size(65, 21)
        abMinus.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abMinus.TabIndex = 20
        abMinus.Text = "/\"
        abMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abMinus.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abMinus.TextShadowDisplacement = 1
        abMinus.UseCompatibleTextRendering = True
        '
        'abDownLastToBelow
        '
        abDownLastToBelow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abDownLastToBelow.ClickHidesParent = False
        abDownLastToBelow.Color1 = System.Drawing.Color.Empty
        abDownLastToBelow.Color2 = System.Drawing.Color.Empty
        abDownLastToBelow.Cursor = System.Windows.Forms.Cursors.Hand
        abDownLastToBelow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abDownLastToBelow.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abDownLastToBelow.HasRoundedRectangle = True
        abDownLastToBelow.HasSound = False
        abDownLastToBelow.LineSize = 2
        abDownLastToBelow.Location = New System.Drawing.Point(0, 204)
        abDownLastToBelow.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abDownLastToBelow.MouseClickSound = ""
        abDownLastToBelow.MouseClickSoundResource = Nothing
        abDownLastToBelow.MouseClickSoundResourcePath = ""
        abDownLastToBelow.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abDownLastToBelow.MouseEnterSound = ""
        abDownLastToBelow.MouseEnterSoundResource = Nothing
        abDownLastToBelow.MouseEnterSoundResourcePath = ""
        abDownLastToBelow.Name = "abDownLastToBelow"
        abDownLastToBelow.ResizeTextFontOnResize = False
        abDownLastToBelow.RoundedRadius = 10.0!
        abDownLastToBelow.Shadow = False
        abDownLastToBelow.ShadowAllWithMouseEnter = False
        abDownLastToBelow.ShadowColor = System.Drawing.Color.Green
        abDownLastToBelow.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abDownLastToBelow.ShadowDivisor = 2
        abDownLastToBelow.ShadowWithMouseEnter = True
        abDownLastToBelow.ShiftAllOnClick = False
        abDownLastToBelow.ShiftForeColor = System.Drawing.Color.Green
        abDownLastToBelow.ShiftOnClick = True
        abDownLastToBelow.ShiftShadowColor = System.Drawing.Color.Lime
        abDownLastToBelow.ShowBorder = True
        abDownLastToBelow.Size = New System.Drawing.Size(65, 21)
        abDownLastToBelow.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abDownLastToBelow.TabIndex = 23
        abDownLastToBelow.Text = "\/->"
        abDownLastToBelow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abDownLastToBelow.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abDownLastToBelow.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abDownLastToBelow, "Drops Last Command On End Of Command To The Line Below")
        abDownLastToBelow.UseCompatibleTextRendering = True
        '
        'abExpandFromOneCommand
        '
        abExpandFromOneCommand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abExpandFromOneCommand.ClickHidesParent = False
        abExpandFromOneCommand.Color1 = System.Drawing.Color.Empty
        abExpandFromOneCommand.Color2 = System.Drawing.Color.Empty
        abExpandFromOneCommand.Cursor = System.Windows.Forms.Cursors.Hand
        abExpandFromOneCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abExpandFromOneCommand.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abExpandFromOneCommand.HasRoundedRectangle = True
        abExpandFromOneCommand.HasSound = False
        abExpandFromOneCommand.LineSize = 2
        abExpandFromOneCommand.Location = New System.Drawing.Point(0, 75)
        abExpandFromOneCommand.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abExpandFromOneCommand.MouseClickSound = ""
        abExpandFromOneCommand.MouseClickSoundResource = Nothing
        abExpandFromOneCommand.MouseClickSoundResourcePath = ""
        abExpandFromOneCommand.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abExpandFromOneCommand.MouseEnterSound = ""
        abExpandFromOneCommand.MouseEnterSoundResource = Nothing
        abExpandFromOneCommand.MouseEnterSoundResourcePath = ""
        abExpandFromOneCommand.Name = "abExpandFromOneCommand"
        abExpandFromOneCommand.ResizeTextFontOnResize = False
        abExpandFromOneCommand.RoundedRadius = 10.0!
        abExpandFromOneCommand.Shadow = False
        abExpandFromOneCommand.ShadowAllWithMouseEnter = False
        abExpandFromOneCommand.ShadowColor = System.Drawing.Color.Green
        abExpandFromOneCommand.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abExpandFromOneCommand.ShadowDivisor = 2
        abExpandFromOneCommand.ShadowWithMouseEnter = True
        abExpandFromOneCommand.ShiftAllOnClick = False
        abExpandFromOneCommand.ShiftForeColor = System.Drawing.Color.Green
        abExpandFromOneCommand.ShiftOnClick = True
        abExpandFromOneCommand.ShiftShadowColor = System.Drawing.Color.Lime
        abExpandFromOneCommand.ShowBorder = True
        abExpandFromOneCommand.Size = New System.Drawing.Size(65, 21)
        abExpandFromOneCommand.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abExpandFromOneCommand.TabIndex = 27
        abExpandFromOneCommand.Text = "+"
        abExpandFromOneCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abExpandFromOneCommand.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abExpandFromOneCommand.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abExpandFromOneCommand, "Put All Separated Commands Into Separate Lines")
        abExpandFromOneCommand.UseCompatibleTextRendering = True
        '
        'abCollapseToOneCommand
        '
        abCollapseToOneCommand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abCollapseToOneCommand.ClickHidesParent = False
        abCollapseToOneCommand.Color1 = System.Drawing.Color.Empty
        abCollapseToOneCommand.Color2 = System.Drawing.Color.Empty
        abCollapseToOneCommand.Cursor = System.Windows.Forms.Cursors.Hand
        abCollapseToOneCommand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abCollapseToOneCommand.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abCollapseToOneCommand.HasRoundedRectangle = True
        abCollapseToOneCommand.HasSound = False
        abCollapseToOneCommand.LineSize = 2
        abCollapseToOneCommand.Location = New System.Drawing.Point(0, 50)
        abCollapseToOneCommand.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abCollapseToOneCommand.MouseClickSound = ""
        abCollapseToOneCommand.MouseClickSoundResource = Nothing
        abCollapseToOneCommand.MouseClickSoundResourcePath = ""
        abCollapseToOneCommand.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abCollapseToOneCommand.MouseEnterSound = ""
        abCollapseToOneCommand.MouseEnterSoundResource = Nothing
        abCollapseToOneCommand.MouseEnterSoundResourcePath = ""
        abCollapseToOneCommand.Name = "abCollapseToOneCommand"
        abCollapseToOneCommand.ResizeTextFontOnResize = False
        abCollapseToOneCommand.RoundedRadius = 10.0!
        abCollapseToOneCommand.Shadow = False
        abCollapseToOneCommand.ShadowAllWithMouseEnter = False
        abCollapseToOneCommand.ShadowColor = System.Drawing.Color.Green
        abCollapseToOneCommand.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abCollapseToOneCommand.ShadowDivisor = 2
        abCollapseToOneCommand.ShadowWithMouseEnter = True
        abCollapseToOneCommand.ShiftAllOnClick = False
        abCollapseToOneCommand.ShiftForeColor = System.Drawing.Color.Green
        abCollapseToOneCommand.ShiftOnClick = True
        abCollapseToOneCommand.ShiftShadowColor = System.Drawing.Color.Lime
        abCollapseToOneCommand.ShowBorder = True
        abCollapseToOneCommand.Size = New System.Drawing.Size(64, 21)
        abCollapseToOneCommand.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abCollapseToOneCommand.TabIndex = 26
        abCollapseToOneCommand.Text = "-"
        abCollapseToOneCommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abCollapseToOneCommand.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abCollapseToOneCommand.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abCollapseToOneCommand, "Collapse All To One Command")
        abCollapseToOneCommand.UseCompatibleTextRendering = True
        '
        'cmbSep
        '
        cmbSep.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cmbSep.ArrowKeysDropList = True
        cmbSep.AutomaticallyMoveMouseCursorToMiddleOfComboOnListDropDown = True
        cmbSep.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        cmbSep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cmbSep.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        cmbSep.FocusRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dot
        cmbSep.FormattingEnabled = True
        cmbSep.IntegralHeight = False
        cmbSep.Items.AddRange(New Object() {"; ", "&&"})
        cmbSep.ListSelectedItemRectanglement = True
        cmbSep.Location = New System.Drawing.Point(0, 103)
        cmbSep.MaxDropDownItems = 100
        cmbSep.Name = "cmbSep"
        cmbSep.PasteMultilineJoiningCharacter = " "
        cmbSep.QuantumItemRectanglement = False
        cmbSep.RegularRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbSep.RegularShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbSep.SelectedItemFontStyle = System.Drawing.FontStyle.Bold
        cmbSep.SelectedItemHasShadow = False
        cmbSep.SelectedRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        cmbSep.SelectedShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        cmbSep.SelectionBackColor = System.Drawing.Color.Green
        cmbSep.SelectionForeColor = System.Drawing.Color.Lime
        cmbSep.Shadow = False
        cmbSep.ShadowColor = System.Drawing.Color.Green
        cmbSep.ShadowOnMouseEnter = False
        cmbSep.ShiftForeColor = System.Drawing.Color.Green
        cmbSep.ShiftOnClick = False
        cmbSep.ShiftShadowColor = System.Drawing.Color.Lime
        cmbSep.ShowExtenderToolTips = False
        cmbSep.Size = New System.Drawing.Size(65, 21)
        cmbSep.TabIndex = 25
        mcttMain.SetToolTip(cmbSep, "Use This Separator For The Buttons Below")
        '
        'abUpBelowToLast
        '
        abUpBelowToLast.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abUpBelowToLast.ClickHidesParent = False
        abUpBelowToLast.Color1 = System.Drawing.Color.Empty
        abUpBelowToLast.Color2 = System.Drawing.Color.Empty
        abUpBelowToLast.Cursor = System.Windows.Forms.Cursors.Hand
        abUpBelowToLast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abUpBelowToLast.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abUpBelowToLast.HasRoundedRectangle = True
        abUpBelowToLast.HasSound = False
        abUpBelowToLast.LineSize = 2
        abUpBelowToLast.Location = New System.Drawing.Point(0, 179)
        abUpBelowToLast.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abUpBelowToLast.MouseClickSound = ""
        abUpBelowToLast.MouseClickSoundResource = Nothing
        abUpBelowToLast.MouseClickSoundResourcePath = ""
        abUpBelowToLast.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abUpBelowToLast.MouseEnterSound = ""
        abUpBelowToLast.MouseEnterSoundResource = Nothing
        abUpBelowToLast.MouseEnterSoundResourcePath = ""
        abUpBelowToLast.Name = "abUpBelowToLast"
        abUpBelowToLast.ResizeTextFontOnResize = False
        abUpBelowToLast.RoundedRadius = 10.0!
        abUpBelowToLast.Shadow = False
        abUpBelowToLast.ShadowAllWithMouseEnter = False
        abUpBelowToLast.ShadowColor = System.Drawing.Color.Green
        abUpBelowToLast.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abUpBelowToLast.ShadowDivisor = 2
        abUpBelowToLast.ShadowWithMouseEnter = True
        abUpBelowToLast.ShiftAllOnClick = False
        abUpBelowToLast.ShiftForeColor = System.Drawing.Color.Green
        abUpBelowToLast.ShiftOnClick = True
        abUpBelowToLast.ShiftShadowColor = System.Drawing.Color.Lime
        abUpBelowToLast.ShowBorder = True
        abUpBelowToLast.Size = New System.Drawing.Size(65, 21)
        abUpBelowToLast.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abUpBelowToLast.TabIndex = 24
        abUpBelowToLast.Text = "<-/\"
        abUpBelowToLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abUpBelowToLast.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abUpBelowToLast.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abUpBelowToLast, "Append Command To Command Line Above It")
        abUpBelowToLast.UseCompatibleTextRendering = True
        '
        'abFrontToBack
        '
        abFrontToBack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abFrontToBack.ClickHidesParent = False
        abFrontToBack.Color1 = System.Drawing.Color.Empty
        abFrontToBack.Color2 = System.Drawing.Color.Empty
        abFrontToBack.Cursor = System.Windows.Forms.Cursors.Hand
        abFrontToBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abFrontToBack.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abFrontToBack.HasRoundedRectangle = True
        abFrontToBack.HasSound = False
        abFrontToBack.LineSize = 2
        abFrontToBack.Location = New System.Drawing.Point(0, 129)
        abFrontToBack.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abFrontToBack.MouseClickSound = ""
        abFrontToBack.MouseClickSoundResource = Nothing
        abFrontToBack.MouseClickSoundResourcePath = ""
        abFrontToBack.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abFrontToBack.MouseEnterSound = ""
        abFrontToBack.MouseEnterSoundResource = Nothing
        abFrontToBack.MouseEnterSoundResourcePath = ""
        abFrontToBack.Name = "abFrontToBack"
        abFrontToBack.ResizeTextFontOnResize = False
        abFrontToBack.RoundedRadius = 10.0!
        abFrontToBack.Shadow = False
        abFrontToBack.ShadowAllWithMouseEnter = False
        abFrontToBack.ShadowColor = System.Drawing.Color.Green
        abFrontToBack.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abFrontToBack.ShadowDivisor = 2
        abFrontToBack.ShadowWithMouseEnter = True
        abFrontToBack.ShiftAllOnClick = False
        abFrontToBack.ShiftForeColor = System.Drawing.Color.Green
        abFrontToBack.ShiftOnClick = True
        abFrontToBack.ShiftShadowColor = System.Drawing.Color.Lime
        abFrontToBack.ShowBorder = True
        abFrontToBack.Size = New System.Drawing.Size(65, 21)
        abFrontToBack.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abFrontToBack.TabIndex = 22
        abFrontToBack.Text = ">-"
        abFrontToBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abFrontToBack.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abFrontToBack.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abFrontToBack, "Put Last Most Command In Line At Front Of Line")
        abFrontToBack.UseCompatibleTextRendering = True
        '
        'abBackToFront
        '
        abBackToFront.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abBackToFront.ClickHidesParent = False
        abBackToFront.Color1 = System.Drawing.Color.Empty
        abBackToFront.Color2 = System.Drawing.Color.Empty
        abBackToFront.Cursor = System.Windows.Forms.Cursors.Hand
        abBackToFront.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abBackToFront.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abBackToFront.HasRoundedRectangle = True
        abBackToFront.HasSound = False
        abBackToFront.LineSize = 2
        abBackToFront.Location = New System.Drawing.Point(0, 154)
        abBackToFront.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBackToFront.MouseClickSound = ""
        abBackToFront.MouseClickSoundResource = Nothing
        abBackToFront.MouseClickSoundResourcePath = ""
        abBackToFront.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBackToFront.MouseEnterSound = ""
        abBackToFront.MouseEnterSoundResource = Nothing
        abBackToFront.MouseEnterSoundResourcePath = ""
        abBackToFront.Name = "abBackToFront"
        abBackToFront.ResizeTextFontOnResize = False
        abBackToFront.RoundedRadius = 10.0!
        abBackToFront.Shadow = False
        abBackToFront.ShadowAllWithMouseEnter = False
        abBackToFront.ShadowColor = System.Drawing.Color.Green
        abBackToFront.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abBackToFront.ShadowDivisor = 2
        abBackToFront.ShadowWithMouseEnter = True
        abBackToFront.ShiftAllOnClick = False
        abBackToFront.ShiftForeColor = System.Drawing.Color.Green
        abBackToFront.ShiftOnClick = True
        abBackToFront.ShiftShadowColor = System.Drawing.Color.Lime
        abBackToFront.ShowBorder = True
        abBackToFront.Size = New System.Drawing.Size(65, 21)
        abBackToFront.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBackToFront.TabIndex = 21
        abBackToFront.Text = "-<"
        abBackToFront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBackToFront.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBackToFront.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abBackToFront, "Put Front Most Command In Line At Back Of Line")
        abBackToFront.UseCompatibleTextRendering = True
        '
        'abPlus
        '
        abPlus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abPlus.ClickHidesParent = False
        abPlus.Color1 = System.Drawing.Color.Empty
        abPlus.Color2 = System.Drawing.Color.Empty
        abPlus.Cursor = System.Windows.Forms.Cursors.Hand
        abPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abPlus.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abPlus.HasRoundedRectangle = True
        abPlus.HasSound = False
        abPlus.LineSize = 2
        abPlus.Location = New System.Drawing.Point(0, 25)
        abPlus.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abPlus.MouseClickSound = ""
        abPlus.MouseClickSoundResource = Nothing
        abPlus.MouseClickSoundResourcePath = ""
        abPlus.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abPlus.MouseEnterSound = ""
        abPlus.MouseEnterSoundResource = Nothing
        abPlus.MouseEnterSoundResourcePath = ""
        abPlus.Name = "abPlus"
        abPlus.ResizeTextFontOnResize = False
        abPlus.RoundedRadius = 10.0!
        abPlus.Shadow = False
        abPlus.ShadowAllWithMouseEnter = False
        abPlus.ShadowColor = System.Drawing.Color.Green
        abPlus.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abPlus.ShadowDivisor = 2
        abPlus.ShadowWithMouseEnter = True
        abPlus.ShiftAllOnClick = False
        abPlus.ShiftForeColor = System.Drawing.Color.Green
        abPlus.ShiftOnClick = True
        abPlus.ShiftShadowColor = System.Drawing.Color.Lime
        abPlus.ShowBorder = True
        abPlus.Size = New System.Drawing.Size(65, 21)
        abPlus.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abPlus.TabIndex = 19
        abPlus.Text = "\/"
        abPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abPlus.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abPlus.TextShadowDisplacement = 1
        abPlus.UseCompatibleTextRendering = True
        '
        'picMain
        '
        picMain.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        picMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        picMain.Cursor = System.Windows.Forms.Cursors.Hand
        picMain.Location = New System.Drawing.Point(9, 259)
        picMain.Name = "picMain"
        picMain.Size = New System.Drawing.Size(24, 24)
        picMain.TabIndex = 15
        picMain.TabStop = False
        mcttMain.SetToolTip(picMain, "Change Custom Command Icon")
        '
        'tmrSetIcon
        '
        tmrSetIcon.Enabled = True
        '
        'abTestCstmCmdCmd
        '
        abTestCstmCmdCmd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abTestCstmCmdCmd.ClickHidesParent = False
        abTestCstmCmdCmd.Color1 = System.Drawing.Color.Empty
        abTestCstmCmdCmd.Color2 = System.Drawing.Color.Empty
        abTestCstmCmdCmd.Cursor = System.Windows.Forms.Cursors.Hand
        abTestCstmCmdCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abTestCstmCmdCmd.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abTestCstmCmdCmd.HasRoundedRectangle = True
        abTestCstmCmdCmd.HasSound = False
        abTestCstmCmdCmd.LineSize = 2
        abTestCstmCmdCmd.Location = New System.Drawing.Point(471, 289)
        abTestCstmCmdCmd.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abTestCstmCmdCmd.MouseClickSound = ""
        abTestCstmCmdCmd.MouseClickSoundResource = Nothing
        abTestCstmCmdCmd.MouseClickSoundResourcePath = ""
        abTestCstmCmdCmd.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abTestCstmCmdCmd.MouseEnterSound = ""
        abTestCstmCmdCmd.MouseEnterSoundResource = Nothing
        abTestCstmCmdCmd.MouseEnterSoundResourcePath = ""
        abTestCstmCmdCmd.Name = "abTestCstmCmdCmd"
        abTestCstmCmdCmd.ResizeTextFontOnResize = False
        abTestCstmCmdCmd.RoundedRadius = 10.0!
        abTestCstmCmdCmd.Shadow = False
        abTestCstmCmdCmd.ShadowAllWithMouseEnter = False
        abTestCstmCmdCmd.ShadowColor = System.Drawing.Color.Green
        abTestCstmCmdCmd.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abTestCstmCmdCmd.ShadowDivisor = 2
        abTestCstmCmdCmd.ShadowWithMouseEnter = True
        abTestCstmCmdCmd.ShiftAllOnClick = False
        abTestCstmCmdCmd.ShiftForeColor = System.Drawing.Color.Green
        abTestCstmCmdCmd.ShiftOnClick = True
        abTestCstmCmdCmd.ShiftShadowColor = System.Drawing.Color.Lime
        abTestCstmCmdCmd.ShowBorder = True
        abTestCstmCmdCmd.Size = New System.Drawing.Size(65, 21)
        abTestCstmCmdCmd.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abTestCstmCmdCmd.TabIndex = 17
        abTestCstmCmdCmd.Text = "Test"
        abTestCstmCmdCmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abTestCstmCmdCmd.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abTestCstmCmdCmd.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abTestCstmCmdCmd, "Test Custom Sub Command")
        abTestCstmCmdCmd.UseCompatibleTextRendering = True
        '
        'abTestCstmCmd
        '
        abTestCstmCmd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abTestCstmCmd.ClickHidesParent = False
        abTestCstmCmd.Color1 = System.Drawing.Color.Empty
        abTestCstmCmd.Color2 = System.Drawing.Color.Empty
        abTestCstmCmd.Cursor = System.Windows.Forms.Cursors.Hand
        abTestCstmCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abTestCstmCmd.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abTestCstmCmd.HasRoundedRectangle = True
        abTestCstmCmd.HasSound = False
        abTestCstmCmd.LineSize = 2
        abTestCstmCmd.Location = New System.Drawing.Point(471, 263)
        abTestCstmCmd.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abTestCstmCmd.MouseClickSound = ""
        abTestCstmCmd.MouseClickSoundResource = Nothing
        abTestCstmCmd.MouseClickSoundResourcePath = ""
        abTestCstmCmd.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abTestCstmCmd.MouseEnterSound = ""
        abTestCstmCmd.MouseEnterSoundResource = Nothing
        abTestCstmCmd.MouseEnterSoundResourcePath = ""
        abTestCstmCmd.Name = "abTestCstmCmd"
        abTestCstmCmd.ResizeTextFontOnResize = False
        abTestCstmCmd.RoundedRadius = 10.0!
        abTestCstmCmd.Shadow = False
        abTestCstmCmd.ShadowAllWithMouseEnter = False
        abTestCstmCmd.ShadowColor = System.Drawing.Color.Green
        abTestCstmCmd.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abTestCstmCmd.ShadowDivisor = 2
        abTestCstmCmd.ShadowWithMouseEnter = True
        abTestCstmCmd.ShiftAllOnClick = False
        abTestCstmCmd.ShiftForeColor = System.Drawing.Color.Green
        abTestCstmCmd.ShiftOnClick = True
        abTestCstmCmd.ShiftShadowColor = System.Drawing.Color.Lime
        abTestCstmCmd.ShowBorder = True
        abTestCstmCmd.Size = New System.Drawing.Size(65, 21)
        abTestCstmCmd.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abTestCstmCmd.TabIndex = 16
        abTestCstmCmd.Text = "Test"
        abTestCstmCmd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abTestCstmCmd.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abTestCstmCmd.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abTestCstmCmd, "Test Custom Command")
        abTestCstmCmd.UseCompatibleTextRendering = True
        '
        'alRunThisCommandAtStartUp
        '
        alRunThisCommandAtStartUp.ClickHidesParent = False
        alRunThisCommandAtStartUp.Color1 = System.Drawing.Color.Empty
        alRunThisCommandAtStartUp.Color2 = System.Drawing.Color.Empty
        alRunThisCommandAtStartUp.Cursor = System.Windows.Forms.Cursors.Hand
        alRunThisCommandAtStartUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        alRunThisCommandAtStartUp.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        alRunThisCommandAtStartUp.HasRoundedRectangle = True
        alRunThisCommandAtStartUp.HasSound = False
        alRunThisCommandAtStartUp.LineSize = 2
        alRunThisCommandAtStartUp.Location = New System.Drawing.Point(4, 5)
        alRunThisCommandAtStartUp.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        alRunThisCommandAtStartUp.MouseClickSound = ""
        alRunThisCommandAtStartUp.MouseClickSoundResource = Nothing
        alRunThisCommandAtStartUp.MouseClickSoundResourcePath = ""
        alRunThisCommandAtStartUp.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        alRunThisCommandAtStartUp.MouseEnterSound = ""
        alRunThisCommandAtStartUp.MouseEnterSoundResource = Nothing
        alRunThisCommandAtStartUp.MouseEnterSoundResourcePath = ""
        alRunThisCommandAtStartUp.Name = "alRunThisCommandAtStartUp"
        alRunThisCommandAtStartUp.ResizeTextFontOnResize = False
        alRunThisCommandAtStartUp.RoundedRadius = 5.0!
        alRunThisCommandAtStartUp.Shadow = False
        alRunThisCommandAtStartUp.ShadowAllWithMouseEnter = False
        alRunThisCommandAtStartUp.ShadowColor = System.Drawing.Color.Green
        alRunThisCommandAtStartUp.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        alRunThisCommandAtStartUp.ShadowDivisor = 2
        alRunThisCommandAtStartUp.ShadowWithMouseEnter = False
        alRunThisCommandAtStartUp.ShiftAllOnClick = False
        alRunThisCommandAtStartUp.ShiftForeColor = System.Drawing.Color.DarkGreen
        alRunThisCommandAtStartUp.ShiftOnClick = False
        alRunThisCommandAtStartUp.ShiftShadowColor = System.Drawing.Color.Lime
        alRunThisCommandAtStartUp.ShowBorder = False
        alRunThisCommandAtStartUp.Size = New System.Drawing.Size(182, 21)
        alRunThisCommandAtStartUp.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        alRunThisCommandAtStartUp.TabIndex = 13
        alRunThisCommandAtStartUp.Text = "Run This Command At StartUp >"
        alRunThisCommandAtStartUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        alRunThisCommandAtStartUp.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        alRunThisCommandAtStartUp.TextShadowDisplacement = 1
        alRunThisCommandAtStartUp.UseCompatibleTextRendering = True
        '
        'cmbStartUpCommand
        '
        cmbStartUpCommand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cmbStartUpCommand.ArrowKeysDropList = True
        cmbStartUpCommand.AutomaticallyMoveMouseCursorToMiddleOfComboOnListDropDown = True
        cmbStartUpCommand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        cmbStartUpCommand.DropDownWidth = 345
        cmbStartUpCommand.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        cmbStartUpCommand.FocusRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dot
        cmbStartUpCommand.IntegralHeight = False
        cmbStartUpCommand.ListSelectedItemRectanglement = True
        cmbStartUpCommand.Location = New System.Drawing.Point(191, 7)
        cmbStartUpCommand.MaxDropDownItems = 100
        cmbStartUpCommand.Name = "cmbStartUpCommand"
        cmbStartUpCommand.PasteMultilineJoiningCharacter = " "
        cmbStartUpCommand.QuantumItemRectanglement = False
        cmbStartUpCommand.RegularRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbStartUpCommand.RegularShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbStartUpCommand.SelectedItemFontStyle = System.Drawing.FontStyle.Bold
        cmbStartUpCommand.SelectedItemHasShadow = False
        cmbStartUpCommand.SelectedRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        cmbStartUpCommand.SelectedShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        cmbStartUpCommand.SelectionBackColor = System.Drawing.Color.Green
        cmbStartUpCommand.SelectionForeColor = System.Drawing.Color.Lime
        cmbStartUpCommand.Shadow = False
        cmbStartUpCommand.ShadowColor = System.Drawing.Color.Green
        cmbStartUpCommand.ShadowOnMouseEnter = False
        cmbStartUpCommand.ShiftForeColor = System.Drawing.Color.Green
        cmbStartUpCommand.ShiftOnClick = False
        cmbStartUpCommand.ShiftShadowColor = System.Drawing.Color.Lime
        cmbStartUpCommand.ShowExtenderToolTips = True
        cmbStartUpCommand.Size = New System.Drawing.Size(345, 21)
        cmbStartUpCommand.TabIndex = 11
        mcttMain.SetToolTip(cmbStartUpCommand, "Startup Command")
        '
        'abOk
        '
        abOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        abOk.ClickHidesParent = False
        abOk.Color1 = System.Drawing.Color.Empty
        abOk.Color2 = System.Drawing.Color.Empty
        abOk.Cursor = System.Windows.Forms.Cursors.Hand
        abOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abOk.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abOk.HasRoundedRectangle = True
        abOk.HasSound = False
        abOk.LineSize = 2
        abOk.Location = New System.Drawing.Point(238, 315)
        abOk.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abOk.MouseClickSound = ""
        abOk.MouseClickSoundResource = Nothing
        abOk.MouseClickSoundResourcePath = ""
        abOk.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
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
        abOk.ShadowWithMouseEnter = True
        abOk.ShiftAllOnClick = True
        abOk.ShiftForeColor = System.Drawing.Color.Green
        abOk.ShiftOnClick = True
        abOk.ShiftShadowColor = System.Drawing.Color.Lime
        abOk.ShowBorder = True
        abOk.Size = New System.Drawing.Size(65, 21)
        abOk.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abOk.TabIndex = 9
        abOk.Text = "OK"
        abOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abOk.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abOk.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abOk, "OK")
        abOk.UseCompatibleTextRendering = True
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
        abRm.Location = New System.Drawing.Point(437, 289)
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
        abRm.TabIndex = 5
        abRm.Text = "-"
        abRm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abRm.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abRm.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abRm, "Remove This From Custom Command")
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
        abAdd.Location = New System.Drawing.Point(403, 289)
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
        abAdd.TabIndex = 4
        abAdd.Text = "+"
        abAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abAdd.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abAdd.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abAdd, "Add This To Custom Command")
        abAdd.UseCompatibleTextRendering = True
        '
        'cmbCstCmdsCmds
        '
        cmbCstCmdsCmds.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cmbCstCmdsCmds.ArrowKeysDropList = True
        cmbCstCmdsCmds.AutomaticallyMoveMouseCursorToMiddleOfComboOnListDropDown = True
        cmbCstCmdsCmds.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        cmbCstCmdsCmds.DropDownWidth = 392
        cmbCstCmdsCmds.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        cmbCstCmdsCmds.FocusRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dot
        cmbCstCmdsCmds.IntegralHeight = False
        cmbCstCmdsCmds.ListSelectedItemRectanglement = True
        cmbCstCmdsCmds.Location = New System.Drawing.Point(7, 289)
        cmbCstCmdsCmds.MaxDropDownItems = 100
        cmbCstCmdsCmds.Name = "cmbCstCmdsCmds"
        cmbCstCmdsCmds.PasteMultilineJoiningCharacter = " "
        cmbCstCmdsCmds.QuantumItemRectanglement = False
        cmbCstCmdsCmds.RegularRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbCstCmdsCmds.RegularShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbCstCmdsCmds.SelectedItemFontStyle = System.Drawing.FontStyle.Bold
        cmbCstCmdsCmds.SelectedItemHasShadow = False
        cmbCstCmdsCmds.SelectedRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        cmbCstCmdsCmds.SelectedShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        cmbCstCmdsCmds.SelectionBackColor = System.Drawing.Color.Green
        cmbCstCmdsCmds.SelectionForeColor = System.Drawing.Color.Lime
        cmbCstCmdsCmds.Shadow = False
        cmbCstCmdsCmds.ShadowColor = System.Drawing.Color.Green
        cmbCstCmdsCmds.ShadowOnMouseEnter = False
        cmbCstCmdsCmds.ShiftForeColor = System.Drawing.Color.Green
        cmbCstCmdsCmds.ShiftOnClick = False
        cmbCstCmdsCmds.ShiftShadowColor = System.Drawing.Color.Lime
        cmbCstCmdsCmds.ShowExtenderToolTips = True
        cmbCstCmdsCmds.Size = New System.Drawing.Size(392, 21)
        cmbCstCmdsCmds.TabIndex = 3
        mcttMain.SetToolTip(cmbCstCmdsCmds, "Add Or Remove Custom Command Sub Command")
        '
        'abRmCst
        '
        abRmCst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abRmCst.ClickHidesParent = False
        abRmCst.Color1 = System.Drawing.Color.Empty
        abRmCst.Color2 = System.Drawing.Color.Empty
        abRmCst.Cursor = System.Windows.Forms.Cursors.Hand
        abRmCst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abRmCst.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abRmCst.HasRoundedRectangle = True
        abRmCst.HasSound = False
        abRmCst.LineSize = 2
        abRmCst.Location = New System.Drawing.Point(437, 263)
        abRmCst.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abRmCst.MouseClickSound = ""
        abRmCst.MouseClickSoundResource = Nothing
        abRmCst.MouseClickSoundResourcePath = ""
        abRmCst.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abRmCst.MouseEnterSound = ""
        abRmCst.MouseEnterSoundResource = Nothing
        abRmCst.MouseEnterSoundResourcePath = ""
        abRmCst.Name = "abRmCst"
        abRmCst.ResizeTextFontOnResize = False
        abRmCst.RoundedRadius = 10.0!
        abRmCst.Shadow = False
        abRmCst.ShadowAllWithMouseEnter = False
        abRmCst.ShadowColor = System.Drawing.Color.Green
        abRmCst.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abRmCst.ShadowDivisor = 2
        abRmCst.ShadowWithMouseEnter = True
        abRmCst.ShiftAllOnClick = False
        abRmCst.ShiftForeColor = System.Drawing.Color.Green
        abRmCst.ShiftOnClick = True
        abRmCst.ShiftShadowColor = System.Drawing.Color.Lime
        abRmCst.ShowBorder = True
        abRmCst.Size = New System.Drawing.Size(30, 21)
        abRmCst.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abRmCst.TabIndex = 2
        abRmCst.Text = "-"
        abRmCst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abRmCst.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abRmCst.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abRmCst, "Remove Custom")
        abRmCst.UseCompatibleTextRendering = True
        '
        'abAddCst
        '
        abAddCst.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abAddCst.ClickHidesParent = False
        abAddCst.Color1 = System.Drawing.Color.Empty
        abAddCst.Color2 = System.Drawing.Color.Empty
        abAddCst.Cursor = System.Windows.Forms.Cursors.Hand
        abAddCst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abAddCst.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abAddCst.HasRoundedRectangle = True
        abAddCst.HasSound = False
        abAddCst.LineSize = 2
        abAddCst.Location = New System.Drawing.Point(403, 263)
        abAddCst.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abAddCst.MouseClickSound = ""
        abAddCst.MouseClickSoundResource = Nothing
        abAddCst.MouseClickSoundResourcePath = ""
        abAddCst.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abAddCst.MouseEnterSound = ""
        abAddCst.MouseEnterSoundResource = Nothing
        abAddCst.MouseEnterSoundResourcePath = ""
        abAddCst.Name = "abAddCst"
        abAddCst.ResizeTextFontOnResize = False
        abAddCst.RoundedRadius = 10.0!
        abAddCst.Shadow = False
        abAddCst.ShadowAllWithMouseEnter = False
        abAddCst.ShadowColor = System.Drawing.Color.Green
        abAddCst.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abAddCst.ShadowDivisor = 2
        abAddCst.ShadowWithMouseEnter = True
        abAddCst.ShiftAllOnClick = False
        abAddCst.ShiftForeColor = System.Drawing.Color.Green
        abAddCst.ShiftOnClick = True
        abAddCst.ShiftShadowColor = System.Drawing.Color.Lime
        abAddCst.ShowBorder = True
        abAddCst.Size = New System.Drawing.Size(30, 21)
        abAddCst.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abAddCst.TabIndex = 1
        abAddCst.Text = "+"
        abAddCst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abAddCst.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abAddCst.TextShadowDisplacement = 1
        mcttMain.SetToolTip(abAddCst, "Add Custom")
        abAddCst.UseCompatibleTextRendering = True
        '
        'cmbCstCmds
        '
        cmbCstCmds.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cmbCstCmds.ArrowKeysDropList = True
        cmbCstCmds.AutomaticallyMoveMouseCursorToMiddleOfComboOnListDropDown = True
        cmbCstCmds.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        cmbCstCmds.DropDownWidth = 392
        cmbCstCmds.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        cmbCstCmds.FocusRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dot
        cmbCstCmds.IntegralHeight = False
        cmbCstCmds.ListSelectedItemRectanglement = True
        cmbCstCmds.Location = New System.Drawing.Point(39, 263)
        cmbCstCmds.MaxDropDownItems = 100
        cmbCstCmds.Name = "cmbCstCmds"
        cmbCstCmds.PasteMultilineJoiningCharacter = " "
        cmbCstCmds.QuantumItemRectanglement = False
        cmbCstCmds.RegularRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbCstCmds.RegularShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbCstCmds.SelectedItemFontStyle = System.Drawing.FontStyle.Bold
        cmbCstCmds.SelectedItemHasShadow = False
        cmbCstCmds.SelectedRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        cmbCstCmds.SelectedShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        cmbCstCmds.SelectionBackColor = System.Drawing.Color.Green
        cmbCstCmds.SelectionForeColor = System.Drawing.Color.Lime
        cmbCstCmds.Shadow = False
        cmbCstCmds.ShadowColor = System.Drawing.Color.Green
        cmbCstCmds.ShadowOnMouseEnter = False
        cmbCstCmds.ShiftForeColor = System.Drawing.Color.Green
        cmbCstCmds.ShiftOnClick = False
        cmbCstCmds.ShiftShadowColor = System.Drawing.Color.Lime
        cmbCstCmds.ShowExtenderToolTips = True
        cmbCstCmds.Size = New System.Drawing.Size(360, 21)
        cmbCstCmds.TabIndex = 0
        mcttMain.SetToolTip(cmbCstCmds, "Add Or Remove This Custom Command")
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
        abBrdr.Size = New System.Drawing.Size(543, 342)
        abBrdr.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abBrdr.TabIndex = 7
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
        'frmCustomCommads
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Black
        ClientSize = New System.Drawing.Size(543, 342)
        Controls.Add(abTestCstmCmdCmd)
        Controls.Add(abTestCstmCmd)
        Controls.Add(alRunThisCommandAtStartUp)
        Controls.Add(cmbStartUpCommand)
        Controls.Add(SplitContainer)
        Controls.Add(abOk)
        Controls.Add(abRm)
        Controls.Add(abAdd)
        Controls.Add(cmbCstCmdsCmds)
        Controls.Add(abRmCst)
        Controls.Add(abAddCst)
        Controls.Add(cmbCstCmds)
        Controls.Add(abBrdr)
        Controls.Add(picMain)
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmCustomCommads"
        Opacity = 0.8R
        ShowInTaskbar = False
        Text = "BlackShellRunner Custom Commands"
        SplitContainer.Panel1.ResumeLayout(False)
        SplitContainer.Panel2.ResumeLayout(False)
        CType(SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        SplitContainer.ResumeLayout(False)
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        SplitContainer2.Panel1.ResumeLayout(False)
        SplitContainer2.Panel2.ResumeLayout(False)
        CType(SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        SplitContainer2.ResumeLayout(False)
        CType(picMain, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Protected Friend WithEvents cmbCstCmds As AcidControls.AcidComboBox
    Protected Friend WithEvents abAddCst As AcidControls.AcidButton
    Protected Friend WithEvents abRmCst As AcidControls.AcidButton
    Protected Friend WithEvents cmbCstCmdsCmds As AcidControls.AcidComboBox
    Protected Friend WithEvents abAdd As AcidControls.AcidButton
    Protected Friend WithEvents abRm As AcidControls.AcidButton
    Protected Friend WithEvents lstCstCmds As AcidControls.AcidListBox
    Protected Friend WithEvents abOk As AcidControls.AcidButton
    Protected Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Protected Friend WithEvents cmbStartUpCommand As AcidControls.AcidComboBox
    Protected Friend WithEvents alRunThisCommandAtStartUp As AcidControls.AcidButton
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip
    Protected Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Protected Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Protected Friend WithEvents lstCstCmdsCmds As AcidControls.AcidListBox
    Protected Friend WithEvents abOverCommand As AcidControls.AcidButton
    Protected Friend WithEvents abMinus As AcidControls.AcidButton
    Protected Friend WithEvents abPlus As AcidControls.AcidButton
    Protected Friend WithEvents abBackToFront As AcidControls.AcidButton
    Protected Friend WithEvents abFrontToBack As AcidControls.AcidButton
    Protected Friend WithEvents abUpBelowToLast As AcidControls.AcidButton
    Protected Friend WithEvents abDownLastToBelow As AcidControls.AcidButton
    Protected Friend WithEvents picMain As System.Windows.Forms.PictureBox
    Protected Friend WithEvents abTestCstmCmd As AcidControls.AcidButton
    Protected Friend WithEvents abTestCstmCmdCmd As AcidControls.AcidButton
    Protected Friend WithEvents tmrSetIcon As System.Windows.Forms.Timer
    Protected Friend WithEvents cmbSep As AcidControls.AcidComboBox
    Protected Friend WithEvents abExpandFromOneCommand As AcidControls.AcidButton
    Protected Friend WithEvents abCollapseToOneCommand As AcidControls.AcidButton
    Private components As System.ComponentModel.IContainer
    Protected Friend WithEvents abBrdr As AcidControls.AcidBorder
End Class
