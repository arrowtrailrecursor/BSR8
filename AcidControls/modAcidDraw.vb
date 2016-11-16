Module modAcidDraw

    Sub DrawRectangle(ByVal g As Graphics, ByVal pen As Pen, ByVal rec As Rectangle, Optional ByVal SmoothingMode As SmoothingMode = SmoothingMode.None)
        ' g.SmoothingMode = SmoothingMode
        g.DrawRectangle(pen, rec)
    End Sub

    Public Sub DrawRoundedRectangle(ByVal g As Graphics, ByVal p As Pen, rec As Rectangle, ByVal radius As Integer, Optional ByVal SmoothingMode As SmoothingMode = SmoothingMode.None)
        Dim x As Integer = rec.X
        Dim y As Integer = rec.Y
        Dim Wid As Integer = rec.Width
        Dim Hie As Integer = rec.Height
        radius = radius / 2
        Dim gp As New GraphicsPath()
        ' g.SmoothingMode = SmoothingMode.HighQuality
        gp.AddLine(x + radius, y, x + Wid - (radius * 2), y) ' Line
        gp.AddArc(x + Wid - (radius * 2), y, radius * 2, radius * 2, 270, 90) ' Corner
        gp.AddLine(x + Wid, y + radius, x + Wid, y + Hie - (radius * 2)) ' Line
        gp.AddArc(x + Wid - (radius * 2), y + Hie - (radius * 2), radius * 2, radius * 2, 0, 90) ' Corner
        gp.AddLine(x + Wid - (radius * 2), y + Hie, x + radius, y + Hie) ' Line
        gp.AddArc(x, y + Hie - (radius * 2), radius * 2, radius * 2, 90, 90) ' Corner
        gp.AddLine(x, y + Hie - (radius * 2), x, y + radius) ' Line
        gp.AddArc(x, y, radius * 2, radius * 2, 180, 90) ' Corner
        gp.CloseFigure()
        g.DrawPath(p, gp)
        gp.Dispose()
    End Sub

    Public Sub ShiftColors(ByVal Obj As Object, ByVal ForeColor As Color, ByVal ShadowColor As Color)
        Obj.ForeColor = ShadowColor
        Obj.ShadowColor = ForeColor
    End Sub

End Module