Public Class AcidLabel
    Inherits AcidButton

    Private vg_color1 As Color
    Private vg_color2 As Color
    ' Protected Overloads Property ShowBorder
    'Get
    ''Return False
    'End Get
    'Set(value)
    '       value = False
    ' End Set
    'End Property
    Private Sub AcidButton_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim i As Graphics = e.Graphics
        i.SmoothingMode = SmoothingMode
        Dim lgb As LinearGradientBrush = New LinearGradientBrush(e.ClipRectangle, vg_color1, vg_color2, GradiantMode)
        i.FillRectangle(lgb, e.ClipRectangle)
        i.Clear(BackColor)
        If ShowBorder Then
            DrawTheText(i)
        Else
            DrawTheText(i)
        End If

    End Sub

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
End Class
