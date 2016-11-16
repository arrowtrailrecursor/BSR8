<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearch
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
    Protected components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        txtPth = New AcidControls.AcidTextBox()
        txtPttn = New AcidControls.AcidTextBox()
        txtSlctd = New AcidControls.AcidTextBox()
        tmrSearchText = New System.Windows.Forms.Timer(components)
        abSearchingDir = New AcidControls.AcidButton()
        abPause = New AcidControls.AcidButton()
        abBrws = New AcidControls.AcidButton()
        abCncl = New AcidControls.AcidButton()
        abOk = New AcidControls.AcidButton()
        abSrch = New AcidControls.AcidButton()
        abBrdr = New AcidControls.AcidBorder()
        dsMain = New BSR.cmpDirectorySearcher()
        mcttMain = New AcidControls.AcidToolTip()
        SuspendLayout()
        '
        'txtPth
        '
        resources.ApplyResources(txtPth, "txtPth")
        txtPth.BackColor = System.Drawing.Color.Black
        txtPth.ForeColor = System.Drawing.Color.Lime
        txtPth.Name = "txtPth"
        '
        'txtPttn
        '
        resources.ApplyResources(txtPttn, "txtPttn")
        txtPttn.BackColor = System.Drawing.Color.Black
        txtPttn.ForeColor = System.Drawing.Color.Lime
        txtPttn.Name = "txtPttn"
        mcttMain.SetToolTip(txtPttn, resources.GetString("txtPttn.ToolTip"))
        '
        'txtSlctd
        '
        resources.ApplyResources(txtSlctd, "txtSlctd")
        txtSlctd.BackColor = System.Drawing.Color.Black
        txtSlctd.ForeColor = System.Drawing.Color.Lime
        txtSlctd.Name = "txtSlctd"
        '
        'tmrSearchText
        '
        tmrSearchText.Interval = 250
        '
        'abSearchingDir
        '
        resources.ApplyResources(abSearchingDir, "abSearchingDir")
        abSearchingDir.BackColor = System.Drawing.Color.Transparent
        abSearchingDir.Color1 = System.Drawing.Color.Empty
        abSearchingDir.Color2 = System.Drawing.Color.Empty
        abSearchingDir.Cursor = System.Windows.Forms.Cursors.Arrow
        abSearchingDir.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abSearchingDir.LineSize = 2.0!
        abSearchingDir.Name = "abSearchingDir"
        abSearchingDir.RoundedRadius = 10.0!
        abSearchingDir.Shadow = False
        abSearchingDir.ShiftAllOnClick = False
        abSearchingDir.ShadowAllWithMouseEnter = False
        abSearchingDir.ShadowColor = System.Drawing.Color.Green
        abSearchingDir.TextShadowDisplacement = 1.0!
        abSearchingDir.ShiftOnClick = False
        abSearchingDir.ShadowWithMouseEnter = False
        abSearchingDir.ShiftForeColor = System.Drawing.Color.Green
        abSearchingDir.ShiftShadowColor = System.Drawing.Color.Lime
        abSearchingDir.ShowBorder = False
        abSearchingDir.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abSearchingDir.UseCompatibleTextRendering = True
        '
        'abPause
        '
        resources.ApplyResources(abPause, "abPause")
        abPause.BackColor = System.Drawing.Color.Transparent
        abPause.Color1 = System.Drawing.Color.Empty
        abPause.Color2 = System.Drawing.Color.Empty
        abPause.Cursor = System.Windows.Forms.Cursors.Hand
        abPause.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abPause.LineSize = 2.0!
        abPause.Name = "abPause"
        abPause.RoundedRadius = 10.0!
        abPause.Shadow = False
        abPause.ShiftAllOnClick = False
        abPause.ShadowAllWithMouseEnter = False
        abPause.ShadowColor = System.Drawing.Color.Green
        abPause.TextShadowDisplacement = 1.0!
        abPause.ShiftOnClick = True
        abPause.ShadowWithMouseEnter = True
        abPause.ShiftForeColor = System.Drawing.Color.Green
        abPause.ShiftShadowColor = System.Drawing.Color.Lime
        abPause.ShowBorder = True
        abPause.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abPause, resources.GetString("abPause.ToolTip"))
        abPause.UseCompatibleTextRendering = True
        '
        'abBrws
        '
        resources.ApplyResources(abBrws, "abBrws")
        abBrws.BackColor = System.Drawing.Color.Transparent
        abBrws.Color1 = System.Drawing.Color.Empty
        abBrws.Color2 = System.Drawing.Color.Empty
        abBrws.Cursor = System.Windows.Forms.Cursors.Hand
        abBrws.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abBrws.LineSize = 2.0!
        abBrws.Name = "abBrws"
        abBrws.RoundedRadius = 10.0!
        abBrws.Shadow = False
        abBrws.ShiftAllOnClick = False
        abBrws.ShadowAllWithMouseEnter = False
        abBrws.ShadowColor = System.Drawing.Color.Green
        abBrws.TextShadowDisplacement = 1.0!
        abBrws.ShiftOnClick = True
        abBrws.ShadowWithMouseEnter = True
        abBrws.ShiftForeColor = System.Drawing.Color.Green
        abBrws.ShiftShadowColor = System.Drawing.Color.Lime
        abBrws.ShowBorder = True
        abBrws.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abBrws, resources.GetString("abBrws.ToolTip"))
        abBrws.UseCompatibleTextRendering = True
        '
        'abCncl
        '
        resources.ApplyResources(abCncl, "abCncl")
        abCncl.BackColor = System.Drawing.Color.Transparent
        abCncl.Color1 = System.Drawing.Color.Empty
        abCncl.Color2 = System.Drawing.Color.Empty
        abCncl.Cursor = System.Windows.Forms.Cursors.Hand
        abCncl.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abCncl.LineSize = 2.0!
        abCncl.Name = "abCncl"
        abCncl.RoundedRadius = 10.0!
        abCncl.Shadow = False
        abCncl.ShiftAllOnClick = True
        abCncl.ShadowAllWithMouseEnter = True
        abCncl.ShadowColor = System.Drawing.Color.Green
        abCncl.TextShadowDisplacement = 1.0!
        abCncl.ShiftOnClick = False
        abCncl.ShadowWithMouseEnter = False
        abCncl.ShiftForeColor = System.Drawing.Color.Green
        abCncl.ShiftShadowColor = System.Drawing.Color.Lime
        abCncl.ShowBorder = True
        abCncl.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abCncl, resources.GetString("abCncl.ToolTip"))
        abCncl.UseCompatibleTextRendering = True
        '
        'abOk
        '
        resources.ApplyResources(abOk, "abOk")
        abOk.BackColor = System.Drawing.Color.Transparent
        abOk.Color1 = System.Drawing.Color.Empty
        abOk.Color2 = System.Drawing.Color.Empty
        abOk.Cursor = System.Windows.Forms.Cursors.Hand
        abOk.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abOk.LineSize = 2.0!
        abOk.Name = "abOk"
        abOk.RoundedRadius = 10.0!
        abOk.Shadow = False
        abOk.ShiftAllOnClick = True
        abOk.ShadowAllWithMouseEnter = True
        abOk.ShadowColor = System.Drawing.Color.Green
        abOk.TextShadowDisplacement = 1.0!
        abOk.ShiftOnClick = False
        abOk.ShadowWithMouseEnter = False
        abOk.ShiftForeColor = System.Drawing.Color.Green
        abOk.ShiftShadowColor = System.Drawing.Color.Lime
        abOk.ShowBorder = True
        abOk.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abOk, resources.GetString("abOk.ToolTip"))
        abOk.UseCompatibleTextRendering = True
        '
        'abSrch
        '
        resources.ApplyResources(abSrch, "abSrch")
        abSrch.BackColor = System.Drawing.Color.Transparent
        abSrch.Color1 = System.Drawing.Color.Empty
        abSrch.Color2 = System.Drawing.Color.Empty
        abSrch.Cursor = System.Windows.Forms.Cursors.Hand
        abSrch.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abSrch.LineSize = 2.0!
        abSrch.Name = "abSrch"
        abSrch.RoundedRadius = 10.0!
        abSrch.Shadow = False
        abSrch.ShiftAllOnClick = False
        abSrch.ShadowAllWithMouseEnter = False
        abSrch.ShadowColor = System.Drawing.Color.Green
        abSrch.TextShadowDisplacement = 1.0!
        abSrch.ShiftOnClick = True
        abSrch.ShadowWithMouseEnter = True
        abSrch.ShiftForeColor = System.Drawing.Color.Green
        abSrch.ShiftShadowColor = System.Drawing.Color.Lime
        abSrch.ShowBorder = True
        abSrch.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abSrch, resources.GetString("abSrch.ToolTip"))
        abSrch.UseCompatibleTextRendering = True
        '
        'abBrdr
        '
        resources.ApplyResources(abBrdr, "abBrdr")
        abBrdr.BackColor = System.Drawing.Color.Transparent
        abBrdr.Color1 = System.Drawing.Color.Empty
        abBrdr.Color2 = System.Drawing.Color.Empty
        abBrdr.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abBrdr.LineSize = 2.0!
        abBrdr.Name = "abBrdr"
        abBrdr.RoundedRadius = 5.0!
        abBrdr.Shadow = False
        abBrdr.ShiftAllOnClick = False
        abBrdr.ShadowAllWithMouseEnter = False
        abBrdr.ShadowColor = System.Drawing.Color.Green
        abBrdr.TextShadowDisplacement = 1.0!
        abBrdr.ShiftOnClick = False
        abBrdr.ShadowWithMouseEnter = False
        abBrdr.ShiftForeColor = System.Drawing.Color.Green
        abBrdr.ShiftShadowColor = System.Drawing.Color.Lime
        abBrdr.ShowBorder = True
        abBrdr.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abBrdr.UseCompatibleTextRendering = True
        '
        'dsMain
        '
        resources.ApplyResources(dsMain, "dsMain")
        dsMain.BackColor = System.Drawing.Color.Black
        dsMain.ForeColor = System.Drawing.Color.Lime
        dsMain.Name = "dsMain"
        dsMain.SearchCriteria = Nothing
        dsMain.UseCompatibleStateImageBehavior = False
        dsMain.View = System.Windows.Forms.View.Details
        '
        'mcttMain
        '
        mcttMain.BackColor = System.Drawing.Color.Black
        mcttMain.ForeColor = System.Drawing.Color.Lime
        mcttMain.OwnerDraw = True
        mcttMain.ShowAlways = True
        mcttMain.UseAnimation = False
        mcttMain.UseFading = False
        mcttMain.UseTransparentFading = True
        '
        'frmSearch
        '
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Black
        Controls.Add(abSearchingDir)
        Controls.Add(dsMain)
        Controls.Add(abPause)
        Controls.Add(abBrws)
        Controls.Add(txtSlctd)
        Controls.Add(abCncl)
        Controls.Add(abOk)
        Controls.Add(abSrch)
        Controls.Add(txtPttn)
        Controls.Add(txtPth)
        Controls.Add(abBrdr)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmSearch"
        Opacity = 0.8R
        ShowInTaskbar = False
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Protected Friend WithEvents txtPth As AcidControls.AcidTextBox
    Protected Friend WithEvents txtPttn As AcidControls.AcidTextBox
    Protected Friend WithEvents abSrch As AcidControls.AcidButton
    Protected Friend WithEvents abOk As AcidControls.AcidButton
    Protected Friend WithEvents abBrdr As AcidControls.AcidButton
    Protected Friend WithEvents abCncl As AcidControls.AcidButton
    Protected Friend WithEvents txtSlctd As AcidControls.AcidTextBox
    Protected Friend WithEvents abBrws As AcidControls.AcidButton
    Protected Friend WithEvents tmrSearchText As System.Windows.Forms.Timer
    Protected Friend WithEvents abPause As AcidControls.AcidButton
    Protected Friend WithEvents dsMain As BSR.cmpDirectorySearcher
    Protected Friend WithEvents abSearchingDir As AcidControls.AcidButton
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip

End Class
