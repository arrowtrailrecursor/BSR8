'<-{----------------------------------------------------}->
'<-{-Acid Button Label Shape William Stanley Davis 2015-}->
'<-{----------------------------------------------------}->

Public Class AcidButton

    'Inherits a .Net Label Attributes
    Inherits System.Windows.Forms.Label

#Region "Enumerators"

    Public Enum enumTextOrientation
        Normal = 0
        Vertical = 1
    End Enum

    Public Enum AudioMode
        Background = AudioPlayMode.Background
        WaitToComplete = AudioPlayMode.WaitToComplete
    End Enum

    Public Enum ShadowCorner
        TopLeft = 0
        TopRight = 1
        BottomLeft = 2
        BottomRight = 3
    End Enum

    Public Enum GraphicSmoothingMode
        DefaultSmoothing = 0
        HighSpeedSmoothing = 1
        HighQualitySmoothing = 2
        NoSmoothing = 3
        AntiAliasSmoothing = 4
    End Enum

#End Region
#Region "Static Variables"

    Private vFimage As Image
    Private vg_color1 As Color
    Private vg_color2 As Color
    Private vText_Orient As enumTextOrientation = 0
    Private vg_mode As LinearGradientMode
    Private vShadow As Boolean = False
    Private vRoundedRadius As Single = 5
    Private vLineSize As Single = 2
    Private vShowBorder As Boolean = True
    Private vShadowPointDisplacement As Point = New Point(0, 0)
    Private vShadowCorner As ShadowCorner = ShadowCorner.TopLeft
    Private vShadowWithMouseEnter As Boolean = False
    Private vShiftOnClick As Boolean = False
    Private vForeColor As Color = Color.Lime
    Private vShadowColor As Color = Color.Green
    Private vShadowAllLabelShapesOnParentWithMouseEnter As Boolean = False
    Private vShadowAllLabelShapesOnParentWithClick As Boolean = False
    Private vForeColorShift As Color = Color.Green
    Private vShadowColorShift As Color = Color.Lime
    Private vHasSound As Boolean = False
    Private vMouseClickSoundRes As System.IO.Stream = Nothing
    Private vMouseEnterSoundRes As System.IO.Stream = Nothing
    Private vMouseClickSoundResPath As String = ""
    Private vMouseEnterSoundResPath As String = ""
    Private vMouseClickSoundPath As String = ""
    Private vMouseEnterSoundPath As String = ""
    Private vClickAudioPlayMode As AudioMode = 0
    Private vEnterAudioPlayMode As AudioMode = 0
    Private vClickHidesParent As Boolean = False
    Private vResizeFont As Boolean = False
    Private vBackColor As Color = Color.Transparent
    Private vTextShadowDisplacement As Integer = 1
    Private vMouseEnterShadow As Boolean = True
    Private vShadowDivisionFactor As Integer = 2
    Private vBottomShadowDivisionFactor As Integer = 2
    Private vTopShadowDivisionFactor As Integer = 2
    Private vBorderLineWidth As Integer = 2
    Private vHasRoundedRectangle As Boolean = True
    Private vSmoothingMode As SmoothingMode = Drawing2D.SmoothingMode.HighQuality
    Private vAutoSize As Boolean

#End Region
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        SetStyle(ControlStyles.ResizeRedraw, True)
        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'Add any initialization after the InitializeComponent() call
        vAutoSize = False
        ForeColor = Color.Lime
        BackColor = Color.Black
        ShadowColor = Color.Green
        ShiftShadowColor = Color.Lime
        ShiftForeColor = Color.Green
        Cursor = Cursors.Hand
    End Sub

    'UserControl overrides dispose to clean up the component list.
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        SuspendLayout()
        '
        'ab
        '
        BackColor = System.Drawing.Color.Transparent
        Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ForeColor = System.Drawing.Color.Lime
        Size = New System.Drawing.Size(100, 50)
        TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        UseCompatibleTextRendering = True
        ResumeLayout(False)

    End Sub

#End Region
#Region "Properties"

#Region "Override Properties"

#Region "AutoSize Override"

    Public Overrides Property AutoSize() As Boolean
        Get
            Return MyBase.AutoSize
        End Get

        Set(ByVal Value As Boolean)
            If vAutoSize <> Value And vAutoSize = False Then
                MyBase.AutoSize = False
                vAutoSize = Value
            Else
                MyBase.AutoSize = Value
            End If
        End Set
    End Property

#End Region

#End Region

#Region "Public Properties"

#Region "MouseEffects Properties"

    <Category("Mouse Effects")>
    <Description("Sets whether the control has sound or not")>
    Public Property ClickHidesParent As Boolean
        Get
            Return vClickHidesParent
        End Get
        Set(ByVal value As Boolean)
            vClickHidesParent = value
        End Set
    End Property

    <Category("Mouse Effects")>
    <Description("Sets whether the all labelshape controls emits a shadow when mouse hovers over it.")>
    Public Property ShadowAllWithMouseEnter As Boolean
        Get
            Return vShadowAllLabelShapesOnParentWithMouseEnter
        End Get
        Set(ByVal value As Boolean)
            vShadowAllLabelShapesOnParentWithMouseEnter = value
            Invalidate()
        End Set
    End Property

    <Category("Mouse Effects")>
    Public Property ShadowWithMouseEnter As Boolean
        Get
            Return vShadowWithMouseEnter
        End Get
        Set(value As Boolean)
            vShadowWithMouseEnter = value
        End Set
    End Property

    <Category("Mouse Effects")>
    <Description("Sets whether the forecolor and shadow color are toggled during a mouse click.")>
    Public Property ShiftOnClick As Boolean
        Get
            Return vShiftOnClick
        End Get
        Set(ByVal value As Boolean)
            vShiftOnClick = value
            Invalidate()
        End Set
    End Property

    <Category("Mouse Effects")>
    <Description("Sets whether the forecolor and shadow color of all labelshapes are toggled during a mouse click.")>
    Public Property ShiftAllOnClick As Boolean
        Get
            Return vShadowAllLabelShapesOnParentWithClick
        End Get
        Set(ByVal value As Boolean)
            vShadowAllLabelShapesOnParentWithClick = value
            Invalidate()
        End Set
    End Property

#End Region

#Region "Sound"

    <Category("Sound")>
    <Description("Sets mode to play audio.")>
    Public Property MouseClickAudioMode As AudioMode
        Get
            Return vClickAudioPlayMode
        End Get
        Set(value As AudioMode)
            vClickAudioPlayMode = value
        End Set
    End Property

    <Category("Sound")>
    <Description("Sets mode to play audio.")>
    Public Property MouseEnterAudioMode As AudioMode
        Get
            Return vEnterAudioPlayMode
        End Get
        Set(value As AudioMode)
            vEnterAudioPlayMode = value
        End Set
    End Property

    <Category("Sound")>
    <Description("Sets whether the control has sound or not")>
    Public Property HasSound As Boolean
        Get
            Return vHasSound
        End Get
        Set(ByVal value As Boolean)
            vHasSound = value
        End Set
    End Property

    <Category("Sound")>
    <Description("Sets sound stream played during a mouse click.")>
    <Browsable(False)>
    Public Property MouseClickSoundResource As System.IO.Stream
        Get
            Return vMouseClickSoundRes
        End Get
        Set(ByVal value As System.IO.Stream)
            vMouseClickSoundRes = value
        End Set
    End Property

    <Category("Sound")>
    <Description("Sets sound stream played during a mouse enter")>
    <Browsable(False)>
    Public Property MouseEnterSoundResource As System.IO.Stream
        Get
            Return vMouseEnterSoundRes
        End Get
        Set(ByVal value As System.IO.Stream)
            vMouseEnterSoundRes = value
        End Set
    End Property

    <Category("Sound")>
    <Description("Sets path to extract stream for sound played during a mouse click.")>
    <Browsable(False)>
    Public Property MouseClickSoundResourcePath As String
        Get
            Return vMouseClickSoundResPath
        End Get
        Set(ByVal value As String)
            vMouseClickSoundResPath = value
            If vMouseClickSoundResPath = String.Empty Then Exit Property
            If Not PathExists(value, TypeOfPath.File) Then
                If Not MouseClickSoundResource Is Nothing Then
                    Dim bytes(MouseClickSoundResource.Length) As Byte
                    MouseClickSoundResource.Read(bytes, 0, bytes.Length)
                    IO.File.WriteAllBytes(value, bytes)
                End If
            End If
            MouseClickAudioMode = AudioMode.Background
            MouseClickSound = value
        End Set
    End Property

    <Category("Sound")>
    <Description("Sets path to extract stream for sound played during a mouse enter")>
    <Browsable(False)>
    Public Property MouseEnterSoundResourcePath As String
        Get
            Return vMouseEnterSoundResPath
        End Get
        Set(ByVal value As String)
            vMouseEnterSoundResPath = value
            If vMouseEnterSoundResPath = String.Empty Then Exit Property
            If Not PathExists(value, TypeOfPath.File) Then
                If Not MouseEnterSoundResource Is Nothing Then
                    Dim bytes(MouseEnterSoundResource.Length) As Byte
                    MouseEnterSoundResource.Read(bytes, 0, bytes.Length)
                    IO.File.WriteAllBytes(vMouseEnterSoundResPath, bytes)
                End If
            End If
            MouseEnterAudioMode = AudioPlayMode.Background
            MouseEnterSound = value
        End Set
    End Property

    <Category("Sound")>
    <Description("Sets sound played during a mouse click.")>
    Public Property MouseClickSound As String
        Get
            Return vMouseClickSoundPath
        End Get
        Set(ByVal value As String)
            vMouseClickSoundPath = value
        End Set
    End Property

    <Category("Sound")>
    <Description("Sets sound played during a mouse enter")>
    Public Property MouseEnterSound As String
        Get
            Return vMouseEnterSoundPath
        End Get
        Set(ByVal value As String)
            vMouseEnterSoundPath = value
        End Set
    End Property

#End Region

#Region "Border"

    <Category("Border")>
    <Description("Determines whether a rounded rectangle is shown around control text or not.")>
    Public Property ShowBorder As Boolean
        Get
            Return vShowBorder
        End Get
        Set(ByVal value As Boolean)
            vShowBorder = value
            Invalidate()
        End Set
    End Property

    <Category("Border")>
    <Description("Sets Whether Text Will Be Resized With Control Resize")>
    Public Property HasRoundedRectangle As Boolean
        Get
            Return vHasRoundedRectangle
        End Get
        Set(value As Boolean)
            vHasRoundedRectangle = value
            Invalidate()
        End Set
    End Property

    <Category("Border")>
    <Description("Determines the diameter of the curves of the rounded rectangles when the property ShowBorder is set to True.")>
    Public Property RoundedRadius As Single
        Get
            Return vRoundedRadius
        End Get
        Set(ByVal value As Single)
            If value < 2 Then value = 2
            vRoundedRadius = value
            Invalidate()
        End Set
    End Property

    <Category("Border")>
    Public Property LineSize As Integer
        Get
            Return vBorderLineWidth
        End Get
        Set(value As Integer)
            vBorderLineWidth = value
            vTopShadowDivisionFactor = value
            vBottomShadowDivisionFactor = 2
            Invalidate()
        End Set
    End Property

#End Region

#Region "Appearance Properties"

    <Category("Appearance")>
    <Description("Sets Whether Text Will Be Resized With Control Resize")>
    Public Property ResizeTextFontOnResize As Boolean
        Get
            Return vResizeFont
        End Get
        Set(value As Boolean)
            vResizeFont = value
            Invalidate()
        End Set
    End Property

    <Category("Appearance")>
    <Description("Determines the position of where the text will show on the control.")>
    Public Property TextOrientation() As enumTextOrientation
        Get
            Return vText_Orient
        End Get
        Set(ByVal Value As enumTextOrientation)
            vText_Orient = Value
            Invalidate()
        End Set
    End Property

#End Region

#Region "Color Properties"

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

    <Category("Color")>
    Public Property ShiftShadowColor() As Color
        Get
            Return vShadowColorShift
        End Get
        Set(ByVal Value As Color)
            vShadowColorShift = Value
            Invalidate()
        End Set
    End Property

    <Category("Color")>
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
    Public Property SmoothingMode As GraphicSmoothingMode
        Get
            Return vSmoothingMode
        End Get
        Set(value As GraphicSmoothingMode)
            vSmoothingMode = value
            Invalidate()
        End Set
    End Property

#End Region

#Region "Gradient Properties"

    <Category("Gradient")>
    <Description("Determines the color 1 of gradient while using a gradient on the control.")>
    Public Property Color1() As Color
        Get
            Return vg_color1
        End Get
        Set(ByVal Value As Color)
            vg_color1 = Value
            Invalidate()
        End Set
    End Property

    <Category("Gradient")>
    <Description("Determines the color 2 of gradient while using a gradient on the control.")>
    Public Property Color2() As Color
        Get
            Return vg_color2
        End Get
        Set(ByVal Value As Color)
            vg_color2 = Value
            Invalidate()
        End Set
    End Property

    <Category("Gradient")>
    <Description("Determines whether and what kind of gradient is shown on the control.")>
    Public Property GradiantMode() As LinearGradientMode
        Get
            Return vg_mode
        End Get
        Set(ByVal Value As LinearGradientMode)
            vg_mode = Value
            Invalidate()
        End Set
    End Property

#End Region

#Region "Shadow Properties"

    <Category("Shadow")>
    <Description("Sets Corner Shadow Appears")>
    Public Property ShadowCornerPlacement As ShadowCorner
        Get
            Return vShadowCorner
        End Get
        Set(value As ShadowCorner)
            vShadowCorner = value
            Invalidate()
        End Set
    End Property

    <Category("Shadow")>
    <Description("Determines whether a shadow shows behind text and border or not.")>
    Public Property Shadow() As Boolean
        Get
            Return vShadow
        End Get
        Set(ByVal Value As Boolean)
            vShadow = Value
            Invalidate()
        End Set
    End Property

    <Category("Shadow")>
    <Description("Sets the negative shadow offset when Shadow property is set to True.")>
    Public Property TextShadowDisplacement As Integer
        Get
            Return vTextShadowDisplacement
        End Get
        Set(value As Integer)
            vTextShadowDisplacement = value
            Invalidate()
        End Set
    End Property

    <Category("Shadow")>
    Public Property ShadowDivisor As Integer
        Get
            Return vShadowDivisionFactor
        End Get
        Set(value As Integer)
            If value < ShadowDivisorMinValue Then
                value = ShadowDivisorMinValue
            End If
            If value > ShadowDivisorMaxValue Then
                value = ShadowDivisorMaxValue
            End If
            vShadowDivisionFactor = value
            Invalidate()
        End Set
    End Property

    <Category("Shadow")>
    Public ReadOnly Property ShadowDivisorMaxValue As Integer
        Get
            Return vTopShadowDivisionFactor
        End Get
    End Property

    <Category("Shadow")>
    Public ReadOnly Property ShadowDivisorMinValue As Integer
        Get
            Return vBottomShadowDivisionFactor
        End Get
    End Property

#End Region

#End Region

#End Region
#Region "Methods"

#Region "Shadow And Text Paint And Graphics Methods"

    Private Sub DrawTheText(ByVal e As Graphics)
        Dim x, y As Integer
        Dim strsize As SizeF = e.MeasureString(Text, Font)
        Dim stringFormat As New StringFormat()
        If TextOrientation = enumTextOrientation.Normal Then
            stringFormat.FormatFlags = StringFormatFlags.NoWrap
        Else
            stringFormat.FormatFlags = StringFormatFlags.DirectionVertical
        End If
        Select Case TextAlign
            Case ContentAlignment.BottomCenter
                If stringFormat.FormatFlags = StringFormatFlags.DirectionVertical Then
                    x = (Width - strsize.Height) / 2
                    y = Height - strsize.Width
                Else
                    x = (Width - strsize.Width) / 2
                    y = Height - strsize.Height
                End If
            Case ContentAlignment.BottomLeft
                If stringFormat.FormatFlags = StringFormatFlags.DirectionVertical Then
                    x = 0
                    y = Height - strsize.Width
                Else
                    x = 0
                    y = Height - strsize.Width
                End If
            Case ContentAlignment.BottomRight
                If stringFormat.FormatFlags = StringFormatFlags.DirectionVertical Then
                    x = Width - strsize.Height
                    y = Height - strsize.Width
                Else
                    x = Width - strsize.Width
                    y = Height - strsize.Height
                End If
            Case ContentAlignment.MiddleCenter
                If stringFormat.FormatFlags = StringFormatFlags.DirectionVertical Then
                    x = (Width - strsize.Height) / 2
                    y = (Height - strsize.Width) / 2
                Else
                    x = (Width - strsize.Width) / 2
                    y = (Height - strsize.Height) / 2
                End If
            Case ContentAlignment.MiddleLeft
                If stringFormat.FormatFlags = StringFormatFlags.DirectionVertical Then
                    x = 0
                    y = (Height - strsize.Width) / 2
                Else
                    x = 0
                    y = (Height - strsize.Height) / 2
                End If
            Case ContentAlignment.MiddleRight
                If stringFormat.FormatFlags = StringFormatFlags.DirectionVertical Then
                    x = Width - strsize.Height
                    y = (Height - strsize.Width) / 2
                Else
                    x = Width - strsize.Width
                    y = (Height - strsize.Height) / 2
                End If
            Case ContentAlignment.TopCenter
                If stringFormat.FormatFlags = StringFormatFlags.DirectionVertical Then
                    x = (Width - strsize.Height) / 2
                    y = 0
                Else
                    x = (Width - strsize.Width) / 2
                    y = 0
                End If
            Case ContentAlignment.TopLeft
                If stringFormat.FormatFlags = StringFormatFlags.DirectionVertical Then
                    x = 0
                    y = 0
                Else
                    x = 0
                    y = 0
                End If
            Case ContentAlignment.TopRight
                If stringFormat.FormatFlags = StringFormatFlags.DirectionVertical Then
                    x = Width - strsize.Height
                    y = 0
                Else
                    x = Width - strsize.Width
                    y = 0
                End If
        End Select
        Dim fc, sc As Color
        fc = ForeColor
        sc = ShadowColor
        Dim fcb, scb As SolidBrush
        fcb = New SolidBrush(fc)
        scb = New SolidBrush(sc)
        Dim dpx, dpy As Integer
        Select Case ShadowCornerPlacement
            Case ShadowCorner.TopLeft
                dpx = -TextShadowDisplacement
                dpy = -TextShadowDisplacement
            Case ShadowCorner.TopRight
                dpx = TextShadowDisplacement
                dpy = -TextShadowDisplacement
            Case ShadowCorner.BottomLeft
                dpx = -TextShadowDisplacement
                dpy = TextShadowDisplacement
            Case ShadowCorner.BottomRight
                dpx = TextShadowDisplacement
                dpy = TextShadowDisplacement
        End Select
        If Not Shadow Then
            e.DrawString(Text, Font, fcb, New Point(x, y), stringFormat)
        Else
            'Shadow
            e.DrawString(Text, Font, scb, New Point(x + dpx, y + dpy), stringFormat)
            'Regular
            e.DrawString(Text, Font, fcb, New Point(x, y), stringFormat)
        End If
    End Sub

    Public Shared Sub ShadowAll(ByVal Value As Boolean, ByVal Form As Control)
        For Each obj As Object In Form.Controls
            If (TypeOf obj Is AcidControls.AcidButton) _
                Or (TypeOf obj Is AcidControls.AcidScrollingMarquee) _
                Or (TypeOf obj Is AcidControls.AcidListBox) _
                Or (TypeOf obj Is AcidControls.AcidTextBox) _
                Or (TypeOf obj Is AcidControls.AcidComboBox) _
                Or (TypeOf obj Is AcidControls.AcidBorder) Then
                obj.Shadow = Value
            End If
            Try
                ShadowAll(Value, obj)
            Catch ex As Exception
            End Try
        Next
    End Sub

    Public Sub ShiftAll(ByVal Value As Boolean, ByVal Form As Control)
        Dim col1 As Color
        Dim col2 As Color
        col1 = ShiftShadowColor
        col2 = ShiftForeColor
        Try
            For Each obj As Object In Form.Controls
                If (TypeOf obj Is AcidControls.AcidButton) _
                    Or (TypeOf obj Is AcidControls.AcidScrollingMarquee) _
                    Or (TypeOf obj Is AcidControls.AcidListBox) _
                    Or (TypeOf obj Is AcidControls.AcidTextBox) _
                    Or (TypeOf obj Is AcidControls.AcidComboBox) _
                    Or (TypeOf obj Is AcidControls.AcidBorder) Then
                    If Value Then
                        obj.ForeColor = obj.ShiftForeColor
                        obj.ShadowColor = obj.ShiftShadowColor
                    Else
                        obj.ForeColor = obj.ShiftShadowColor
                        obj.ShadowColor = obj.ShiftForeColor
                    End If
                End If
                If (TypeOf obj Is AcidTextBox) Then
                    If Not Value Then
                        obj.ForeColor = col1
                    Else
                        obj.ForeColor = col2
                    End If
                End If
                ShiftAll(Value, obj)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Function GetAdjustedFont(ByVal GraphicRef As Graphics, ByVal GraphicString As String, ByVal OriginalFont As Font, ByVal ContainerWidth As Integer, ByVal ContainerHeight As Integer, ByVal MaxFontSize As Integer, ByVal MinFontSize As Integer, ByVal SmallestOnFail As Boolean) As Font
        For AdjustedSize As Integer = MaxFontSize To MinFontSize Step -1
            Dim TestFont As New Font(OriginalFont.Name, AdjustedSize, OriginalFont.Style)
            Dim AdjustedSizeNew As SizeF = GraphicRef.MeasureString(GraphicString, TestFont)
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

    Private Sub DrawTheBorder(ByVal e As Graphics)
        Dim g As Graphics = e
        Dim sf, lw, ww, hw, sw, sh, sx, sy, x, y, w, h As Integer
        Dim nsr, cr As Rectangle
        Dim p, sp As Pen
        Dim fc, sc As Color
        fc = ForeColor
        sc = ShadowColor
        cr = ClientRectangle
        sf = ShadowDivisor
        lw = LineSize
        ww = lw * sf
        hw = lw / sf
        If Not Shadow Then
            nsr = ClientRectangle
            p = New Pen(fc, lw)
            'Regular Color Pen
            If HasRoundedRectangle Then
                With cr
                    nsr.X = cr.X + lw
                    nsr.Y = cr.Y + lw
                    nsr.Width = cr.Width - lw * 2
                    nsr.Height = cr.Height - lw * 2
                End With
                DrawRoundedRectangle(g, p, nsr, RoundedRadius, vSmoothingMode)
            Else
                nsr = ClientRectangle
                With cr
                    nsr.X = cr.X
                    nsr.Y = cr.Y
                    nsr.Width = cr.Width
                    nsr.Height = cr.Height
                End With
                p = New Pen(fc, lw)
                'Regular Color Pen
                DrawRectangle(g, p, nsr, vSmoothingMode)
            End If
        Else
            'Border Draw With Shadow
            With cr
                sx = .X + hw
                sy = .Y + hw
                sw = ((.Width - (hw * 2)) - lw)
                sh = ((.Height - (hw * 2)) - lw)
                x = (.X + hw) + hw
                y = (.Y + hw) + hw
                w = sw
                h = sh
            End With
            'Regular Color Pen
            p = New Pen(fc, lw)
            'Shadow Color Pen
            sp = New Pen(sc, lw)
            Dim srec As New Rectangle(New Point(sx, sy), New Size(sw, sh))
            Dim rec As New Rectangle(New Point(x, y), New Size(w, h))
            If HasRoundedRectangle Then
                'Shadow
                DrawRoundedRectangle(g, sp, srec, RoundedRadius, vSmoothingMode)
                'Regular
                DrawRoundedRectangle(g, p, rec, RoundedRadius, vSmoothingMode)
            Else
                'Shadow
                DrawRectangle(g, sp, srec, vSmoothingMode)
                'Regular
                DrawRectangle(g, p, rec, vSmoothingMode)
            End If
        End If
    End Sub

#End Region
#Region "Handled Private Event Methods"

#Region "Mouse Event Methods"

    Private Sub Me_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseLeave
        If vShadowWithMouseEnter Then Shadow = False
        If vShadowAllLabelShapesOnParentWithMouseEnter Then ShadowAll(False, FindForm)
        If vShadowAllLabelShapesOnParentWithClick Then ShiftAll(False, FindForm)
        ForeColor = vForeColor
        ShadowColor = vShadowColor
    End Sub

    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseDown
        If vShiftOnClick Then
            ForeColor = vForeColorShift
            ShadowColor = vShadowColorShift
        End If
        If vShadowAllLabelShapesOnParentWithClick Then ShiftAll(True, FindForm)
        Invalidate()
    End Sub

    Private Sub Me_MouseUp(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseUp
        If vShiftOnClick Then
            ForeColor = vShadowColorShift
            ShadowColor = vForeColorShift
        End If
        If vShadowAllLabelShapesOnParentWithClick Then ShiftAll(False, FindForm)
        ' Refresh()
        Invalidate()
    End Sub

    Private Sub Me_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Click
        If vShiftOnClick And vHasSound And Not vMouseClickSoundPath = "" _
            Or
            vShadowAllLabelShapesOnParentWithClick And vHasSound And Not vMouseClickSoundPath = "" _
            Then
            If vClickHidesParent Then
                Parent.Hide()
            End If
            My.Computer.Audio.Play(vMouseClickSoundPath, vClickAudioPlayMode)
        End If
        Me_MouseUp(sender, New MouseEventArgs(MouseButtons.Left, 1, (Width / 2), (Height / 2), 120))
    End Sub

    Private Sub Me_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        If vShadowWithMouseEnter Then Shadow = True
        If vShadowAllLabelShapesOnParentWithMouseEnter Then ShadowAll(True, FindForm)
        If vShadowWithMouseEnter And vHasSound And Not vMouseEnterSoundPath = "" _
            Or
            vShadowAllLabelShapesOnParentWithMouseEnter And vHasSound And Not vMouseEnterSoundPath = "" _
            Then
            If PathExists(vMouseEnterSoundPath, TypeOfPath.File) Then My.Computer.Audio.Play(vMouseEnterSoundPath, vEnterAudioPlayMode)
        End If
    End Sub

    Private Sub Me_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Move
        ForeColor = vForeColor
        ShadowColor = vShadowColor
    End Sub

#End Region
#Region "Text Size Adjust On Resize Event Method"

    Private Sub Me_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        If vResizeFont Then Font = GetAdjustedFont(CreateGraphics, Text, Font, Width, Height, 72, 8, True)
    End Sub

#End Region
#Region "Paint Event Method"

    Private Sub AcidButton_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim i As Graphics = e.Graphics
        i.SmoothingMode = SmoothingMode
        Dim lgb As LinearGradientBrush = New LinearGradientBrush(e.ClipRectangle, vg_color1, vg_color2, GradiantMode)
        i.FillRectangle(lgb, e.ClipRectangle)
        i.Clear(BackColor)
        If ShowBorder Then
            DrawTheBorder(i)
            DrawTheText(i)
        Else
            DrawTheText(i)
        End If

    End Sub

#End Region

#End Region

#End Region

End Class