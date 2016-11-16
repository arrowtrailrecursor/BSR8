Partial Class AcidToolTip
    Inherits System.Windows.Forms.ToolTip

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New(ByVal container As System.ComponentModel.IContainer)
        MyClass.New()

        'Required for Windows.Forms Class Composition Designer support
        If (container IsNot Nothing) Then
            container.Add(Me)
        End If

    End Sub

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()
        'This call is required by the Component Designer.
        InitializeComponent()
        ForeColor = Color.Lime
        BackColor = Color.Black
    End Sub

    'Component overrides dispose to clean up the component list.
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

    'Required by the Component Designer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        tmrOpacity = New System.Windows.Forms.Timer(components)
        '
        'tmrOpacity
        '
        tmrOpacity.Interval = 5
        '
        'AcidToolTip
        '
        BackColor = System.Drawing.Color.Navy
        ForeColor = System.Drawing.Color.Cyan
        OwnerDraw = True
        UseAnimation = False
        UseFading = False

    End Sub
    Friend WithEvents tmrOpacity As System.Windows.Forms.Timer
    Private components As System.ComponentModel.IContainer

End Class
