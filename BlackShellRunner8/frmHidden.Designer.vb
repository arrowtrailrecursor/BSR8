<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHidden
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
    Protected components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        abShow = New AcidControls.AcidButton()
        tmrMoveToCorner = New System.Windows.Forms.Timer(components)
        mcttMain = New AcidControls.AcidToolTip()
        SuspendLayout()
        '
        'abShow
        '
        abShow.BackColor = System.Drawing.Color.Black
        abShow.Color1 = System.Drawing.Color.Empty
        abShow.Color2 = System.Drawing.Color.Empty
        abShow.Cursor = System.Windows.Forms.Cursors.Hand
        abShow.Dock = System.Windows.Forms.DockStyle.Fill
        abShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        abShow.GradiantMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        abShow.LineSize = 2.0!
        abShow.Location = New System.Drawing.Point(0, 0)
        abShow.Name = "abShow"
        abShow.RoundedRadius = 10.0!
        abShow.Shadow = False
        abShow.ShiftAllOnClick = False
        abShow.ShadowAllWithMouseEnter = False
        abShow.ShadowColor = System.Drawing.Color.Green
        abShow.TextShadowDisplacement = 1.0!
        abShow.ShiftOnClick = True
        abShow.ShadowWithMouseEnter = True
        abShow.ShiftForeColor = System.Drawing.Color.Green
        abShow.ShiftShadowColor = System.Drawing.Color.Lime
        abShow.ShowBorder = True
        abShow.Size = New System.Drawing.Size(60, 21)
        abShow.TabIndex = 32
        abShow.Text = "Show"
        abShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        abShow.TextOrientation = AcidControls.AcidButton.enumTextOrientation.Normal
        mcttMain.SetToolTip(abShow, "Show BlackShellRunner")
        abShow.UseCompatibleTextRendering = True
        '
        'tmrMoveToCorner
        '
        tmrMoveToCorner.Interval = 1000
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
        'frmHidden
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Black
        ClientSize = New System.Drawing.Size(60, 21)
        Controls.Add(abShow)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Name = "frmHidden"
        ShowIcon = False
        ShowInTaskbar = False
        StartPosition = System.Windows.Forms.FormStartPosition.Manual
        ResumeLayout(False)

    End Sub
    Protected Friend WithEvents abShow As AcidControls.AcidButton
    Protected Friend WithEvents tmrMoveToCorner As System.Windows.Forms.Timer
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip
End Class
