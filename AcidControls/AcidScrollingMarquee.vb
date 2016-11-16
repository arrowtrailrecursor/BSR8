'<-{-----------------------------------------------------------------}->
'<-{-Acid Scrolling Marquee William Stanley Davis 2015-}->
'<-{-----------------------------------------------------------------}->

Public Class AcidScrollingMarquee

    'Inherits a .Net User Controls Attributes
    Inherits System.Windows.Forms.UserControl

#Region "Enumerators"

    Public Enum ShadowCorner
        TopLeft = 0
        TopRight = 1
        BottomLeft = 3
        BottomRight = 4
    End Enum

    Public Enum TextOrientation
        Left = 0
        Middle = 1
        Right = 2
        Random = 3
    End Enum

#End Region
#Region "Static Variables"

#Region "Regular Variants"

#Region "Public Regular Variants"

    Public StartPosition As Integer = 1

#End Region
#Region "Private Regular variants"

    Private szf As Single
    Private szfWidth As Single
    Private vDelaySeconds As Double = 0.1
#End Region

#End Region
#Region "Property Variants"

    Private vMarqueeText As String = "Acid Marquee By: William Stanley Davis"
    Private vShadowPointDisplacement As Point = New Point(0, 0)
    Private vShadowCorner As ShadowCorner = ShadowCorner.TopLeft
    Private vTextShadowDisplacement As Integer = 1
    Private vStop As Boolean = True
    Private vOrientation As TextOrientation = TextOrientation.Left
    Private vResizeFont As Boolean = False
    Private vShadowColorShift As Color = Color.Lime
    Private vForeColorShift As Color = Color.Green
    Private vScrollSpeed As Integer = 1
    Private vTextShadow As Boolean = False
    Private vShadowColor As Color = Color.Green
    Private vSmoothingMode As GraphicSmoothingMode = GraphicSmoothingMode.HighQualitySmoothing
    Private vForeColor As Color = Color.Lime
    Friend WithEvents bwMain As BackgroundWorker
    Private vBackColor As Color = Color.Transparent

#End Region

#End Region
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        AddHandler MyBase.Paint, AddressOf OnPaint
        Stopped = True
        ForeColor = Color.Lime
        BackColor = Color.Black
        ShadowColor = Color.Green
        ShiftShadowColor = Color.Lime
        ShiftForeColor = Color.Green
    End Sub

    'UserControl1 overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Private components As System.ComponentModel.IContainer

    'Required by the Windows Form Designer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        tmrMain = New System.Windows.Forms.Timer(components)
        bwMain = New System.ComponentModel.BackgroundWorker()
        SuspendLayout()
        '
        'tmrMain
        '
        tmrMain.Enabled = True
        tmrMain.Interval = 10
        '
        'bwMain
        '
        '
        'AcidScrollingMarquee
        '
        BackColor = System.Drawing.Color.Black
        ForeColor = System.Drawing.Color.Lime
        Name = "AcidScrollingMarquee"
        Size = New System.Drawing.Size(100, 32)
        ResumeLayout(False)

    End Sub

#End Region
#Region "Properties"

#Region "Appearance"

    Public Property ResizeTextFontOnResize As Boolean
        Get
            Return vResizeFont
        End Get
        Set(value As Boolean)
            vResizeFont = value
            Invalidate()
        End Set
    End Property

#End Region
#Region "Marquee Specific"
    Public Property DelaySeconds As Double
        Get
            Return vDelaySeconds
        End Get
        Set(value As Double)
            vDelaySeconds = value
            Invalidate()
        End Set
    End Property

    Public Property StoppedTextOrientation As TextOrientation
        Get
            Return vOrientation
        End Get
        Set(Value As TextOrientation)
            vOrientation = Value
            Invalidate()
        End Set
    End Property

    <Description("Gets/Sets the text that scrolls across the marquee.")>
    Public Property MarqueeText() As String
        Get
            MarqueeText = vMarqueeText
        End Get
        Set(ByVal Value As String)
            Stopped = True
            vMarqueeText = Value
            Stopped = False
            Invalidate()
        End Set
    End Property

    <Description("Gets/Sets whether the text is marquee or not.")>
    Public Property Stopped() As Boolean
        Get
            Return vStop
        End Get
        Set(ByVal Value As Boolean)
            vStop = Value
            If vStop Then
                StartPosition = 1
                Dim wdth As Integer = TextRenderer.MeasureText(vMarqueeText, Font).Width
                Select Case vOrientation
                    Case TextOrientation.Left
                        StartPosition = 1
                    Case TextOrientation.Middle
                        StartPosition = ((Width / 2) - (wdth / 2))
                    Case TextOrientation.Right
                        StartPosition = (Width - wdth)
                    Case TextOrientation.Random
                        Dim Random As Integer = GenerateRandomNumber(1, 3)
                        Select Case Random
                            Case 1
                                StartPosition = 1
                            Case 2
                                StartPosition = ((Width / 2) - (wdth / 2))
                            Case 3
                                StartPosition = (Width - wdth)
                        End Select
                End Select
                tmrMain.Stop()
            Else
                StartPosition = Width
                tmrMain.Start()
            End If
            Invalidate()
        End Set
    End Property
    Public PixelTick As Integer
    Public Property PixelsPerTick() As Integer
        Get
            Return PixelTick
        End Get
        Set(value As Integer)
            PixelTick = value
        End Set
    End Property
#End Region
#Region "Shadow"

    <Description("Sets the negative shadow offset when Shadow property is set to True.")>
    Public Property TextShadowDisplacement As Single
        Get
            Return vTextShadowDisplacement
        End Get
        Set(ByVal value As Single)
            vTextShadowDisplacement = value
            Invalidate()
        End Set
    End Property

    <Description("Sets Corner Shadow Appears")>
    Public Property ShadowCornerPlacement As ShadowCorner
        Get
            Return vShadowCorner
        End Get
        Set(value As ShadowCorner)
            If value = ShadowCorner.TopLeft Then
                vShadowPointDisplacement.X = 0
                vShadowPointDisplacement.Y = 0
            ElseIf value = ShadowCorner.TopRight Then
                vShadowPointDisplacement.X = vTextShadowDisplacement
                vShadowPointDisplacement.Y = 0
            ElseIf value = ShadowCorner.BottomLeft Then
                vShadowPointDisplacement.X = 0
                vShadowPointDisplacement.Y = vTextShadowDisplacement
            ElseIf value = ShadowCorner.BottomRight Then
                vShadowPointDisplacement.X = vTextShadowDisplacement
                vShadowPointDisplacement.Y = vTextShadowDisplacement
            End If
            Invalidate()
        End Set
    End Property

    <Description("Boolean property that determines if the text will have a shadow.")>
    Public Property Shadow() As Boolean
        Get
            Shadow = vTextShadow
        End Get
        Set(ByVal Value As Boolean)
            vTextShadow = Value
            Invalidate()
        End Set
    End Property

#End Region
#Region "Color"

    <Category("Color")>
    <Description("Sets the color of the shadow behind text and border.")>
    Public Property ShadowColor() As Color
        Get
            Return vShadowColor
        End Get
        Set(ByVal Value As Color)
            vShadowColor = Value
            Invalidate()
        End Set
    End Property

    <Category("Color")>
    Public Overrides Property ForeColor() As Color
        Get
            Return vForeColor
        End Get
        Set(ByVal value As Color)
            vForeColor = value
            Invalidate()
        End Set
    End Property

    <Category("Color")>
    Public Overrides Property BackColor() As Color
        Get
            Return vBackColor
        End Get
        Set(ByVal value As Color)
            vBackColor = value
            Invalidate()
        End Set
    End Property

    Public Property ShiftShadowColor() As Color
        Get
            Return vShadowColorShift
        End Get
        Set(ByVal Value As Color)
            vShadowColorShift = Value
            Invalidate()
        End Set
    End Property

    Public Property ShiftForeColor() As Color
        Get
            Return vForeColorShift
        End Get
        Set(ByVal value As Color)
            vForeColorShift = value
            Invalidate()
        End Set
    End Property

    <Category("Color")>
    Public Property GraphicSmoothingMode As GraphicSmoothingMode
        Get
            Return vSmoothingMode
        End Get
        Set(value As GraphicSmoothingMode)
            vSmoothingMode = value
            Invalidate()
        End Set
    End Property

#End Region

#End Region
#Region "Methods"

#Region "Handled Event Methods"

    Private Sub ScrollingMarque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.DoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
    End Sub

    Private Sub ScrollingMarque_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        'Just want to make sure that each time we move the control or resize it,
        'it re-renders correctly.
        Invalidate()
    End Sub

    Private Sub ScrollingMarque_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        'Just want to make sure that each time we move the control or resize it,
        'it re-renders correctly.
        Invalidate()
    End Sub

#End Region
#Region "Regular Event Methods"

    Private Overloads Sub OnPaint(ByVal sender As Object, ByVal e As PaintEventArgs)
        Dim str As String = vMarqueeText
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = GraphicSmoothingMode
        Dim szf As SizeF
        'Measure and draw the real message text.
        szf = g.MeasureString(vMarqueeText, Font)
        szfWidth = szf.ToSize.Width
        If vTextShadow = True Then
            szf = g.MeasureString(vMarqueeText, Font)
            g.DrawString(vMarqueeText,
                         Font,
                         New SolidBrush(vShadowColor),
                         StartPosition + vShadowPointDisplacement.X - vTextShadowDisplacement,
                         0 + (Height / 2) - (szf.Height / 2) + vShadowPointDisplacement.Y - vTextShadowDisplacement)
        End If
        g.DrawString(vMarqueeText,
                     Font,
                     New SolidBrush(ForeColor),
                     StartPosition - vShadowPointDisplacement.X,
                     0 + (Height / 2) - (szf.Height / 2) - vShadowPointDisplacement.Y) '
        FixSize()
    End Sub

    Private Sub FixSize(Optional ByVal JustTheHeight As Boolean = False)
        If vResizeFont And vStop Then
            Font = GetAdjustedFont(CreateGraphics, MarqueeText, Font, Width, Height, 72, DefaultFont.Size, True, False)
        Else
            Font = GetAdjustedFont(CreateGraphics, MarqueeText, Font, Width, Height, 72, DefaultFont.Size, True, True)
        End If
    End Sub

    Public Function GetAdjustedFont(ByVal GraphicRef As Graphics, ByVal GraphicString As String, ByVal OriginalFont As Font, ByVal ContainerWidth As Integer, ByVal ContainerHeight As Integer, ByVal MaxFontSize As Integer, ByVal MinFontSize As Integer, ByVal SmallestOnFail As Boolean, Optional ByVal JustTheHeight As Boolean = False) As Font
        For AdjustedSize As Integer = MaxFontSize To MinFontSize Step -1
            Dim TestFont As New Font(OriginalFont.Name, AdjustedSize, OriginalFont.Style)
            Dim AdjustedSizeNew As SizeF = GraphicRef.MeasureString(GraphicString, TestFont)
            If JustTheHeight And ContainerHeight > Convert.ToInt32(AdjustedSizeNew.Height) Then
                Return TestFont
            End If
            If ContainerWidth > Convert.ToInt32(AdjustedSizeNew.Width) And ContainerHeight > Convert.ToInt32(AdjustedSizeNew.Height) Then
                Return TestFont
            End If
        Next AdjustedSize
        If SmallestOnFail Then
            Return New Font(OriginalFont.Name, MinFontSize, OriginalFont.Style)
        Else
            Return OriginalFont
        End If
    End Function

    Private Function GenerateRandomNumber(ByVal StartInt As Integer, ByVal EndInt As Integer) As Integer
        Randomize()
        Static X As Integer = 1
        Dim Ret As Integer = 1
        Do Until Not X = Ret
            Ret = CInt(Math.Ceiling(Rnd() * EndInt) + StartInt)
        Loop
        X = Ret
        Return Ret
    End Function

    Private Sub bwMain_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwMain.DoWork

        'If the start position is greater that the width we want on the control,
        'then reset it the start
        Do Until vStop

            Delay(vDelaySeconds)
        Loop
    End Sub

    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        If StartPosition < 1 - szfWidth Then
            StartPosition = Width
        Else
            StartPosition -= PixelTick
        End If
        Invalidate()
    End Sub

#End Region

#End Region

End Class