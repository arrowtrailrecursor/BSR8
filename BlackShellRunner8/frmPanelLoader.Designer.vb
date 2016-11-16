<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPanelLoader
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPanelLoader))
        pnlMain = New System.Windows.Forms.Panel()
        SuspendLayout()
        '
        'pnlMain
        '
        pnlMain.BackgroundImage = Global.BSR.Resources.PiratesGreen
        pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        pnlMain.Dock = System.Windows.Forms.DockStyle.Fill
        pnlMain.Location = New System.Drawing.Point(0, 0)
        pnlMain.Name = "pnlMain"
        pnlMain.Size = New System.Drawing.Size(606, 356)
        pnlMain.TabIndex = 0
        '
        'frmPanelLoader
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(606, 356)
        Controls.Add(pnlMain)
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Name = "frmPanelLoader"
        Text = "BlackCrestSoft Panel Loader"
        TopMost = True
        ResumeLayout(False)

    End Sub

    Friend WithEvents pnlMain As Panel
End Class
