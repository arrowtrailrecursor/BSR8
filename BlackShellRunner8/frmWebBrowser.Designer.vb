<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebBrowse
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWebBrowse))
        Panel1 = New System.Windows.Forms.Panel()
        ssMain = New System.Windows.Forms.StatusStrip()
        tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        wbMain = New System.Windows.Forms.WebBrowser()
        abUpDir = New AcidControls.AcidButton()
        abForwardSite = New AcidControls.AcidButton()
        abGoToHost = New AcidControls.AcidButton()
        abBackwardSite = New AcidControls.AcidButton()
        abRefresh = New AcidControls.AcidButton()
        abForward = New AcidControls.AcidButton()
        abBackward = New AcidControls.AcidButton()
        abHome = New AcidControls.AcidButton()
        cmbAddressBar = New AcidControls.AcidComboBox()
        mcttMain = New AcidControls.AcidToolTip()
        abPanic = New AcidControls.AcidButton()
        abGoURL = New AcidControls.AcidButton()
        Panel1.SuspendLayout()
        ssMain.SuspendLayout()
        SuspendLayout()
        '
        'Panel1
        '
        Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Panel1.Controls.Add(ssMain)
        Panel1.Controls.Add(wbMain)
        Panel1.Location = New System.Drawing.Point(1, 25)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(558, 291)
        Panel1.TabIndex = 6
        '
        'ssMain
        '
        ssMain.BackColor = System.Drawing.Color.Transparent
        ssMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {tsslStatus})
        ssMain.Location = New System.Drawing.Point(0, 269)
        ssMain.Name = "ssMain"
        ssMain.Size = New System.Drawing.Size(558, 22)
        ssMain.TabIndex = 2
        ssMain.Text = "StatusStrip1"
        '
        'tsslStatus
        '
        tsslStatus.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        tsslStatus.ForeColor = System.Drawing.Color.Lime
        tsslStatus.Name = "tsslStatus"
        tsslStatus.Size = New System.Drawing.Size(35, 17)
        tsslStatus.Text = "Done"
        '
        'wbMain
        '
        wbMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        wbMain.IsWebBrowserContextMenuEnabled = False
        wbMain.Location = New System.Drawing.Point(0, 0)
        wbMain.MinimumSize = New System.Drawing.Size(0, 0)
        wbMain.Name = "wbMain"
        wbMain.ScriptErrorsSuppressed = True
        wbMain.Size = New System.Drawing.Size(558, 266)
        wbMain.TabIndex = 1
        wbMain.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        wbMain.WebBrowserShortcutsEnabled = False
        '
        'abUpDir
        '
        abUpDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abUpDir.BackColor = System.Drawing.Color.Black
        abUpDir.ClickHidesParent = False
        abUpDir.Color1 = System.Drawing.Color.Empty
        abUpDir.Color2 = System.Drawing.Color.Empty
        abUpDir.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abUpDir.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abUpDir.HasSound = False
        abUpDir.LineSize = 2.0!
        abUpDir.Location = New System.Drawing.Point(404, 3)
        abUpDir.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abUpDir.MouseClickSound = ""
        abUpDir.MouseClickSoundResource = Nothing
        abUpDir.MouseClickSoundResourcePath = ""
        abUpDir.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abUpDir.MouseEnterSound = ""
        abUpDir.MouseEnterSoundResource = Nothing
        abUpDir.MouseEnterSoundResourcePath = ""
        abUpDir.Name = "abUpDir"
        abUpDir.ResizeTextFontOnResize = False
        abUpDir.RoundedRadius = 13.0!
        abUpDir.Shadow = False
        abUpDir.ShiftAllOnClick = False
        abUpDir.ShadowAllWithMouseEnter = False
        abUpDir.ShadowColor = System.Drawing.Color.Green
        abUpDir.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abUpDir.TextShadowDisplacement = 1.0!
        abUpDir.ShiftOnClick = True
        abUpDir.ShadowWithMouseEnter = True
        abUpDir.ShiftForeColor = System.Drawing.Color.Green
        abUpDir.ShiftShadowColor = System.Drawing.Color.Lime
        abUpDir.ShowBorder = True
        abUpDir.Size = New System.Drawing.Size(25, 21)
        abUpDir.TabIndex = 10
        abUpDir.Text = "^"
        abUpDir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        abUpDir.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abUpDir, "Up Site Path")
        abUpDir.UseCompatibleTextRendering = True
        '
        'abForwardSite
        '
        abForwardSite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abForwardSite.BackColor = System.Drawing.Color.Black
        abForwardSite.ClickHidesParent = False
        abForwardSite.Color1 = System.Drawing.Color.Empty
        abForwardSite.Color2 = System.Drawing.Color.Empty
        abForwardSite.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abForwardSite.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abForwardSite.HasSound = False
        abForwardSite.LineSize = 2.0!
        abForwardSite.Location = New System.Drawing.Point(482, 3)
        abForwardSite.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abForwardSite.MouseClickSound = ""
        abForwardSite.MouseClickSoundResource = Nothing
        abForwardSite.MouseClickSoundResourcePath = ""
        abForwardSite.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abForwardSite.MouseEnterSound = ""
        abForwardSite.MouseEnterSoundResource = Nothing
        abForwardSite.MouseEnterSoundResourcePath = ""
        abForwardSite.Name = "abForwardSite"
        abForwardSite.ResizeTextFontOnResize = False
        abForwardSite.RoundedRadius = 13.0!
        abForwardSite.Shadow = False
        abForwardSite.ShiftAllOnClick = False
        abForwardSite.ShadowAllWithMouseEnter = False
        abForwardSite.ShadowColor = System.Drawing.Color.Green
        abForwardSite.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abForwardSite.TextShadowDisplacement = 1.0!
        abForwardSite.ShiftOnClick = True
        abForwardSite.ShadowWithMouseEnter = True
        abForwardSite.ShiftForeColor = System.Drawing.Color.Green
        abForwardSite.ShiftShadowColor = System.Drawing.Color.Lime
        abForwardSite.ShowBorder = True
        abForwardSite.Size = New System.Drawing.Size(25, 21)
        abForwardSite.TabIndex = 9
        abForwardSite.Text = ">>"
        abForwardSite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abForwardSite.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abForwardSite, "Forward Entire Site")
        abForwardSite.UseCompatibleTextRendering = True
        '
        'abGoToHost
        '
        abGoToHost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abGoToHost.BackColor = System.Drawing.Color.Black
        abGoToHost.ClickHidesParent = False
        abGoToHost.Color1 = System.Drawing.Color.Empty
        abGoToHost.Color2 = System.Drawing.Color.Empty
        abGoToHost.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abGoToHost.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abGoToHost.HasSound = False
        abGoToHost.LineSize = 2.0!
        abGoToHost.Location = New System.Drawing.Point(378, 3)
        abGoToHost.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abGoToHost.MouseClickSound = ""
        abGoToHost.MouseClickSoundResource = Nothing
        abGoToHost.MouseClickSoundResourcePath = ""
        abGoToHost.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abGoToHost.MouseEnterSound = ""
        abGoToHost.MouseEnterSoundResource = Nothing
        abGoToHost.MouseEnterSoundResourcePath = ""
        abGoToHost.Name = "abGoToHost"
        abGoToHost.ResizeTextFontOnResize = False
        abGoToHost.RoundedRadius = 13.0!
        abGoToHost.Shadow = False
        abGoToHost.ShiftAllOnClick = False
        abGoToHost.ShadowAllWithMouseEnter = False
        abGoToHost.ShadowColor = System.Drawing.Color.Green
        abGoToHost.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abGoToHost.TextShadowDisplacement = 1.0!
        abGoToHost.ShiftOnClick = True
        abGoToHost.ShadowWithMouseEnter = True
        abGoToHost.ShiftForeColor = System.Drawing.Color.Green
        abGoToHost.ShiftShadowColor = System.Drawing.Color.Lime
        abGoToHost.ShowBorder = True
        abGoToHost.Size = New System.Drawing.Size(25, 21)
        abGoToHost.TabIndex = 8
        abGoToHost.Text = "%"
        abGoToHost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abGoToHost.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abGoToHost, "Root Host Site")
        abGoToHost.UseCompatibleTextRendering = True
        '
        'abBackwardSite
        '
        abBackwardSite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abBackwardSite.BackColor = System.Drawing.Color.Black
        abBackwardSite.ClickHidesParent = False
        abBackwardSite.Color1 = System.Drawing.Color.Empty
        abBackwardSite.Color2 = System.Drawing.Color.Empty
        abBackwardSite.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abBackwardSite.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abBackwardSite.HasSound = False
        abBackwardSite.LineSize = 2.0!
        abBackwardSite.Location = New System.Drawing.Point(456, 3)
        abBackwardSite.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBackwardSite.MouseClickSound = ""
        abBackwardSite.MouseClickSoundResource = Nothing
        abBackwardSite.MouseClickSoundResourcePath = ""
        abBackwardSite.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBackwardSite.MouseEnterSound = ""
        abBackwardSite.MouseEnterSoundResource = Nothing
        abBackwardSite.MouseEnterSoundResourcePath = ""
        abBackwardSite.Name = "abBackwardSite"
        abBackwardSite.ResizeTextFontOnResize = False
        abBackwardSite.RoundedRadius = 13.0!
        abBackwardSite.Shadow = False
        abBackwardSite.ShiftAllOnClick = False
        abBackwardSite.ShadowAllWithMouseEnter = False
        abBackwardSite.ShadowColor = System.Drawing.Color.Green
        abBackwardSite.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abBackwardSite.TextShadowDisplacement = 1.0!
        abBackwardSite.ShiftOnClick = True
        abBackwardSite.ShadowWithMouseEnter = True
        abBackwardSite.ShiftForeColor = System.Drawing.Color.Green
        abBackwardSite.ShiftShadowColor = System.Drawing.Color.Lime
        abBackwardSite.ShowBorder = True
        abBackwardSite.Size = New System.Drawing.Size(25, 21)
        abBackwardSite.TabIndex = 7
        abBackwardSite.Text = "<<"
        abBackwardSite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBackwardSite.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abBackwardSite, "Back Entire Site")
        abBackwardSite.UseCompatibleTextRendering = True
        '
        'abRefresh
        '
        abRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abRefresh.BackColor = System.Drawing.Color.Black
        abRefresh.ClickHidesParent = False
        abRefresh.Color1 = System.Drawing.Color.Empty
        abRefresh.Color2 = System.Drawing.Color.Empty
        abRefresh.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abRefresh.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abRefresh.HasSound = False
        abRefresh.LineSize = 2.0!
        abRefresh.Location = New System.Drawing.Point(326, 3)
        abRefresh.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abRefresh.MouseClickSound = ""
        abRefresh.MouseClickSoundResource = Nothing
        abRefresh.MouseClickSoundResourcePath = ""
        abRefresh.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abRefresh.MouseEnterSound = ""
        abRefresh.MouseEnterSoundResource = Nothing
        abRefresh.MouseEnterSoundResourcePath = ""
        abRefresh.Name = "abRefresh"
        abRefresh.ResizeTextFontOnResize = False
        abRefresh.RoundedRadius = 13.0!
        abRefresh.Shadow = False
        abRefresh.ShiftAllOnClick = False
        abRefresh.ShadowAllWithMouseEnter = False
        abRefresh.ShadowColor = System.Drawing.Color.Green
        abRefresh.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abRefresh.TextShadowDisplacement = 1.0!
        abRefresh.ShiftOnClick = True
        abRefresh.ShadowWithMouseEnter = True
        abRefresh.ShiftForeColor = System.Drawing.Color.Green
        abRefresh.ShiftShadowColor = System.Drawing.Color.Lime
        abRefresh.ShowBorder = True
        abRefresh.Size = New System.Drawing.Size(25, 21)
        abRefresh.TabIndex = 5
        abRefresh.Text = "+"
        abRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abRefresh.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abRefresh, "Refresh Page")
        abRefresh.UseCompatibleTextRendering = True
        '
        'abForward
        '
        abForward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abForward.BackColor = System.Drawing.Color.Black
        abForward.ClickHidesParent = False
        abForward.Color1 = System.Drawing.Color.Empty
        abForward.Color2 = System.Drawing.Color.Empty
        abForward.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abForward.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abForward.HasSound = False
        abForward.LineSize = 2.0!
        abForward.Location = New System.Drawing.Point(534, 3)
        abForward.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abForward.MouseClickSound = ""
        abForward.MouseClickSoundResource = Nothing
        abForward.MouseClickSoundResourcePath = ""
        abForward.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abForward.MouseEnterSound = ""
        abForward.MouseEnterSoundResource = Nothing
        abForward.MouseEnterSoundResourcePath = ""
        abForward.Name = "abForward"
        abForward.ResizeTextFontOnResize = False
        abForward.RoundedRadius = 13.0!
        abForward.Shadow = False
        abForward.ShiftAllOnClick = False
        abForward.ShadowAllWithMouseEnter = False
        abForward.ShadowColor = System.Drawing.Color.Green
        abForward.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abForward.TextShadowDisplacement = 1.0!
        abForward.ShiftOnClick = True
        abForward.ShadowWithMouseEnter = True
        abForward.ShiftForeColor = System.Drawing.Color.Green
        abForward.ShiftShadowColor = System.Drawing.Color.Lime
        abForward.ShowBorder = True
        abForward.Size = New System.Drawing.Size(25, 21)
        abForward.TabIndex = 4
        abForward.Text = ">"
        abForward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abForward.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abForward, "Forward Page")
        abForward.UseCompatibleTextRendering = True
        '
        'abBackward
        '
        abBackward.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abBackward.BackColor = System.Drawing.Color.Black
        abBackward.ClickHidesParent = False
        abBackward.Color1 = System.Drawing.Color.Empty
        abBackward.Color2 = System.Drawing.Color.Empty
        abBackward.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abBackward.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abBackward.HasSound = False
        abBackward.LineSize = 2.0!
        abBackward.Location = New System.Drawing.Point(508, 3)
        abBackward.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBackward.MouseClickSound = ""
        abBackward.MouseClickSoundResource = Nothing
        abBackward.MouseClickSoundResourcePath = ""
        abBackward.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abBackward.MouseEnterSound = ""
        abBackward.MouseEnterSoundResource = Nothing
        abBackward.MouseEnterSoundResourcePath = ""
        abBackward.Name = "abBackward"
        abBackward.ResizeTextFontOnResize = False
        abBackward.RoundedRadius = 13.0!
        abBackward.Shadow = False
        abBackward.ShiftAllOnClick = False
        abBackward.ShadowAllWithMouseEnter = False
        abBackward.ShadowColor = System.Drawing.Color.Green
        abBackward.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abBackward.TextShadowDisplacement = 1.0!
        abBackward.ShiftOnClick = True
        abBackward.ShadowWithMouseEnter = True
        abBackward.ShiftForeColor = System.Drawing.Color.Green
        abBackward.ShiftShadowColor = System.Drawing.Color.Lime
        abBackward.ShowBorder = True
        abBackward.Size = New System.Drawing.Size(25, 21)
        abBackward.TabIndex = 3
        abBackward.Text = "<"
        abBackward.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abBackward.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abBackward, "Back Page")
        abBackward.UseCompatibleTextRendering = True
        '
        'abHome
        '
        abHome.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abHome.BackColor = System.Drawing.Color.Black
        abHome.ClickHidesParent = False
        abHome.Color1 = System.Drawing.Color.Empty
        abHome.Color2 = System.Drawing.Color.Empty
        abHome.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abHome.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abHome.HasSound = False
        abHome.LineSize = 2.0!
        abHome.Location = New System.Drawing.Point(352, 3)
        abHome.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abHome.MouseClickSound = ""
        abHome.MouseClickSoundResource = Nothing
        abHome.MouseClickSoundResourcePath = ""
        abHome.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abHome.MouseEnterSound = ""
        abHome.MouseEnterSoundResource = Nothing
        abHome.MouseEnterSoundResourcePath = ""
        abHome.Name = "abHome"
        abHome.ResizeTextFontOnResize = False
        abHome.RoundedRadius = 13.0!
        abHome.Shadow = False
        abHome.ShiftAllOnClick = False
        abHome.ShadowAllWithMouseEnter = False
        abHome.ShadowColor = System.Drawing.Color.Green
        abHome.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abHome.TextShadowDisplacement = 1.0!
        abHome.ShiftOnClick = True
        abHome.ShadowWithMouseEnter = True
        abHome.ShiftForeColor = System.Drawing.Color.Green
        abHome.ShiftShadowColor = System.Drawing.Color.Lime
        abHome.ShowBorder = True
        abHome.Size = New System.Drawing.Size(25, 21)
        abHome.TabIndex = 2
        abHome.Text = "H"
        abHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abHome.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abHome, "Home Page")
        abHome.UseCompatibleTextRendering = True
        '
        'cmbAddressBar
        '
        cmbAddressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        cmbAddressBar.ArrowKeysDropList = True
        cmbAddressBar.AutomaticallyMoveMouseCursorToMiddleOfComboOnListDropDown = True
        cmbAddressBar.BackColor = System.Drawing.Color.Black
        cmbAddressBar.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        cmbAddressBar.DropDownWidth = 462
        cmbAddressBar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        cmbAddressBar.ForeColor = System.Drawing.Color.Lime
        cmbAddressBar.FormattingEnabled = True
        cmbAddressBar.ListSelectedItemRectanglement = True
        cmbAddressBar.Location = New System.Drawing.Point(2, 3)
        cmbAddressBar.Name = "cmbAddressBar"
        cmbAddressBar.PasteMultilineJoiningCharacter = " "
        cmbAddressBar.QuantumItemRectanglement = False
        cmbAddressBar.RegularRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbAddressBar.RegularShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Solid
        cmbAddressBar.SelectedItemFontStyle = System.Drawing.FontStyle.Regular
        cmbAddressBar.SelectedRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        cmbAddressBar.SelectedShadowRectangleStyle = System.Drawing.Drawing2D.DashStyle.Dash
        cmbAddressBar.SelectionBackColor = System.Drawing.Color.Lime
        cmbAddressBar.SelectionForeColor = System.Drawing.Color.Black
        cmbAddressBar.ShowExtenderToolTips = True
        cmbAddressBar.Size = New System.Drawing.Size(297, 21)
        cmbAddressBar.TabIndex = 1
        mcttMain.SetToolTip(cmbAddressBar, "Address Bar")
        '
        'mcttMain
        '
        mcttMain.BackColor = System.Drawing.Color.Black
        mcttMain.ForeColor = System.Drawing.Color.Lime
        mcttMain.OwnerDraw = True
        mcttMain.UseAnimation = False
        mcttMain.UseFading = False
        mcttMain.UseTransparentFading = True
        '
        'abPanic
        '
        abPanic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abPanic.BackColor = System.Drawing.Color.Black
        abPanic.ClickHidesParent = False
        abPanic.Color1 = System.Drawing.Color.Empty
        abPanic.Color2 = System.Drawing.Color.Empty
        abPanic.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abPanic.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abPanic.HasSound = False
        abPanic.LineSize = 2.0!
        abPanic.Location = New System.Drawing.Point(430, 3)
        abPanic.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abPanic.MouseClickSound = ""
        abPanic.MouseClickSoundResource = Nothing
        abPanic.MouseClickSoundResourcePath = ""
        abPanic.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abPanic.MouseEnterSound = ""
        abPanic.MouseEnterSoundResource = Nothing
        abPanic.MouseEnterSoundResourcePath = ""
        abPanic.Name = "abPanic"
        abPanic.ResizeTextFontOnResize = False
        abPanic.RoundedRadius = 13.0!
        abPanic.Shadow = False
        abPanic.ShiftAllOnClick = False
        abPanic.ShadowAllWithMouseEnter = False
        abPanic.ShadowColor = System.Drawing.Color.Green
        abPanic.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abPanic.TextShadowDisplacement = 1.0!
        abPanic.ShiftOnClick = True
        abPanic.ShadowWithMouseEnter = True
        abPanic.ShiftForeColor = System.Drawing.Color.Green
        abPanic.ShiftShadowColor = System.Drawing.Color.Lime
        abPanic.ShowBorder = True
        abPanic.Size = New System.Drawing.Size(25, 21)
        abPanic.TabIndex = 11
        abPanic.Text = "!"
        abPanic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abPanic.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abPanic, "Panic And Hide This Shit!")
        abPanic.UseCompatibleTextRendering = True
        '
        'abGoURL
        '
        abGoURL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        abGoURL.BackColor = System.Drawing.Color.Black
        abGoURL.ClickHidesParent = False
        abGoURL.Color1 = System.Drawing.Color.Empty
        abGoURL.Color2 = System.Drawing.Color.Empty
        abGoURL.Font = New System.Drawing.Font("Franklin Gothic Demi", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abGoURL.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abGoURL.HasSound = False
        abGoURL.LineSize = 2.0!
        abGoURL.Location = New System.Drawing.Point(300, 3)
        abGoURL.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.Background
        abGoURL.MouseClickSound = ""
        abGoURL.MouseClickSoundResource = Nothing
        abGoURL.MouseClickSoundResourcePath = ""
        abGoURL.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.Background
        abGoURL.MouseEnterSound = ""
        abGoURL.MouseEnterSoundResource = Nothing
        abGoURL.MouseEnterSoundResourcePath = ""
        abGoURL.Name = "abGoURL"
        abGoURL.ResizeTextFontOnResize = False
        abGoURL.RoundedRadius = 13.0!
        abGoURL.Shadow = False
        abGoURL.ShiftAllOnClick = False
        abGoURL.ShadowAllWithMouseEnter = False
        abGoURL.ShadowColor = System.Drawing.Color.Green
        abGoURL.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abGoURL.TextShadowDisplacement = 1.0!
        abGoURL.ShiftOnClick = True
        abGoURL.ShadowWithMouseEnter = True
        abGoURL.ShiftForeColor = System.Drawing.Color.Green
        abGoURL.ShiftShadowColor = System.Drawing.Color.Lime
        abGoURL.ShowBorder = True
        abGoURL.Size = New System.Drawing.Size(25, 21)
        abGoURL.TabIndex = 12
        abGoURL.Text = "*"
        abGoURL.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        abGoURL.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abGoURL, "Navigate To Address")
        abGoURL.UseCompatibleTextRendering = True
        '
        'frmWebBrowse
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Black
        ClientSize = New System.Drawing.Size(560, 317)
        Controls.Add(abGoURL)
        Controls.Add(abPanic)
        Controls.Add(abUpDir)
        Controls.Add(abForwardSite)
        Controls.Add(abGoToHost)
        Controls.Add(abBackwardSite)
        Controls.Add(Panel1)
        Controls.Add(abRefresh)
        Controls.Add(abForward)
        Controls.Add(abBackward)
        Controls.Add(abHome)
        Controls.Add(cmbAddressBar)
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Name = "frmWebBrowse"
        StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Text = "BlackShellRunner Safer Browser"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ssMain.ResumeLayout(False)
        ssMain.PerformLayout()
        ResumeLayout(False)

    End Sub
    Protected Friend WithEvents cmbAddressBar As AcidControls.AcidComboBox
    Protected Friend WithEvents abHome As AcidControls.AcidButton
    Protected Friend WithEvents abBackward As AcidControls.AcidButton
    Protected Friend WithEvents abForward As AcidControls.AcidButton
    Protected Friend WithEvents abRefresh As AcidControls.AcidButton
    Protected Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Protected Friend WithEvents wbMain As System.Windows.Forms.WebBrowser
    Protected Friend WithEvents abBackwardSite As AcidControls.AcidButton
    Protected Friend WithEvents abGoToHost As AcidControls.AcidButton
    Protected Friend WithEvents abForwardSite As AcidControls.AcidButton
    Protected Friend WithEvents abUpDir As AcidControls.AcidButton
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip
    Protected Friend WithEvents ssMain As System.Windows.Forms.StatusStrip
    Protected Friend WithEvents tsslStatus As System.Windows.Forms.ToolStripStatusLabel
    Protected Friend WithEvents abPanic As AcidControls.AcidButton
    Protected Friend WithEvents abGoURL As AcidControls.AcidButton
    Private components As System.ComponentModel.IContainer
End Class
