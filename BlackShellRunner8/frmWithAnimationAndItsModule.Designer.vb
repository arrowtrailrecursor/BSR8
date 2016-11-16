<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWithAniAndITSmod
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
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        picBG = New System.Windows.Forms.PictureBox()
        CType(picBG, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        'picBG
        '
        picBG.BackColor = System.Drawing.Color.Black
        picBG.Dock = System.Windows.Forms.DockStyle.Fill
        picBG.InitialImage = Nothing
        picBG.Location = New System.Drawing.Point(0, 0)
        picBG.Name = "picBG"
        picBG.Size = New System.Drawing.Size(260, 152)
        picBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        picBG.TabIndex = 0
        picBG.TabStop = False
        picBG.WaitOnLoad = True
        '
        'frmWithAniAndITSmod
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(260, 152)
        Controls.Add(picBG)
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Name = "frmWithAniAndITSmod"
        ShowIcon = False
        ShowInTaskbar = False
        CType(picBG, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub
    Friend WithEvents picBG As System.Windows.Forms.PictureBox

End Class
