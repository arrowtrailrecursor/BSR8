<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCorners
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
        tmrFadeIn = New System.Windows.Forms.Timer(components)
        tmrFadeOut = New System.Windows.Forms.Timer(components)
        tmrAlawaysAtYourBack = New System.Windows.Forms.Timer(components)
        abbrdr = New AcidControls.AcidButton()
        SuspendLayout()
        '
        'tmrFadeIn
        '
        tmrFadeIn.Interval = 10
        '
        'tmrFadeOut
        '
        tmrFadeOut.Interval = 10
        '
        'tmrAlawaysAtYourBack
        '
        tmrAlawaysAtYourBack.Interval = 500
        '
        'abbrdr
        '
        abbrdr.ClickHidesParent = False
        abbrdr.Color1 = System.Drawing.Color.Empty
        abbrdr.Color2 = System.Drawing.Color.Empty
        abbrdr.Cursor = System.Windows.Forms.Cursors.Hand
        abbrdr.Dock = System.Windows.Forms.DockStyle.Fill
        abbrdr.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abbrdr.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abbrdr.HasRoundedRectangle = True
        abbrdr.HasSound = False
        abbrdr.LineSize = 2
        abbrdr.Location = New System.Drawing.Point(0, 0)
        abbrdr.MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abbrdr.MouseClickSound = ""
        abbrdr.MouseClickSoundResource = Nothing
        abbrdr.MouseClickSoundResourcePath = ""
        abbrdr.MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
        abbrdr.MouseEnterSound = ""
        abbrdr.MouseEnterSoundResource = Nothing
        abbrdr.MouseEnterSoundResourcePath = ""
        abbrdr.Name = "abbrdr"
        abbrdr.ResizeTextFontOnResize = False
        abbrdr.RoundedRadius = 5.0!
        abbrdr.Shadow = False
        abbrdr.ShadowAllWithMouseEnter = False
        abbrdr.ShadowColor = System.Drawing.Color.Green
        abbrdr.ShadowCornerPlacement = AcidControls.AcidButton.ShadowCorner.TopLeft
        abbrdr.ShadowDivisor = 2
        abbrdr.ShadowWithMouseEnter = False
        abbrdr.ShiftAllOnClick = False
        abbrdr.ShiftForeColor = System.Drawing.Color.Green
        abbrdr.ShiftOnClick = False
        abbrdr.ShiftShadowColor = System.Drawing.Color.Lime
        abbrdr.ShowBorder = True
        abbrdr.Size = New System.Drawing.Size(422, 255)
        abbrdr.SmoothingMode = AcidControls.AcidButton.GraphicSmoothingMode.HighQualitySmoothing
        abbrdr.TabIndex = 0
        abbrdr.Text = "Top, Left"
        abbrdr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abbrdr.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        abbrdr.TextShadowDisplacement = 1
        abbrdr.UseCompatibleTextRendering = True
        '
        'frmCorners
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Black
        ClientSize = New System.Drawing.Size(422, 255)
        Controls.Add(abbrdr)
        ForeColor = System.Drawing.Color.Lime
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Name = "frmCorners"
        Opacity = 0R
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Text = "Top, Left"
        ResumeLayout(False)

    End Sub
    Protected Friend WithEvents tmrFadeIn As System.Windows.Forms.Timer
    Protected Friend WithEvents tmrFadeOut As System.Windows.Forms.Timer
    Protected Friend WithEvents tmrAlawaysAtYourBack As System.Windows.Forms.Timer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents abbrdr As AcidControls.AcidButton
End Class
