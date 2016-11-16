Public Module ParentAcidGraphicsPath

    Public Sub SetParentFormGraphicsRectanglePath(ParentForm As Form, BorderAcidLabel As AcidControls.AcidBorder)
        Dim gp As New GraphicsPath
        Dim m_intxAxis As Integer
        Dim m_intyAxis As Integer
        Dim m_intWidth As Integer
        Dim m_intHeight As Integer
        Dim m_diameter As Integer
        With BorderAcidLabel
            With .Location
                m_intxAxis = .X + 1
                m_intyAxis = .Y + 1
            End With
            m_intWidth = .Width - 1
            m_intHeight = .Height - 1
            m_diameter = .RoundedRadius
        End With
        If BorderAcidLabel.HasRoundedRectangle Then
            Dim BaseRect As New RectangleF(m_intxAxis, m_intyAxis, m_intWidth, m_intHeight)
            Dim ArcRect As New RectangleF(BaseRect.Location, New SizeF(m_diameter - 1, m_diameter - 1))
            'top left Arc
            gp.AddArc(ArcRect, 180, 90)
            gp.AddLine(m_intxAxis + CInt(m_diameter / 2), m_intyAxis, m_intxAxis + m_intWidth - CInt(m_diameter / 2), m_intyAxis)
            'top right arc
            ArcRect.X = BaseRect.Right - m_diameter
            gp.AddArc(ArcRect, 270, 90)
            gp.AddLine(m_intxAxis + m_intWidth, m_intyAxis + CInt(m_diameter / 2), m_intxAxis + m_intWidth, m_intyAxis + m_intHeight - CInt(m_diameter / 2))
            'bottom right arc
            ArcRect.Y = BaseRect.Bottom - m_diameter
            gp.AddArc(ArcRect, 0, 90)
            gp.AddLine(m_intxAxis + CInt(m_diameter / 2), m_intyAxis + m_intHeight, m_intxAxis + m_intWidth - CInt(m_diameter / 2), m_intyAxis + m_intHeight)
            'bottom left arc
            ArcRect.X = BaseRect.Left
            gp.AddArc(ArcRect, 90, 90)
            gp.AddLine(m_intxAxis, m_intyAxis + CInt(m_diameter / 2), m_intxAxis, m_intyAxis + m_intHeight - CInt(m_diameter / 2))
            ParentForm.Region = New Region(gp)
        Else
            Dim OffSetValue As Integer = 2
            m_intxAxis -= OffSetValue
            m_intyAxis -= OffSetValue
            m_intWidth += (OffSetValue * 2)
            m_intWidth += (OffSetValue * 2)
            gp.AddRectangle(New Rectangle(New Point(m_intxAxis, m_intyAxis), New Size(m_intWidth, m_intHeight)))
        End If
    End Sub

End Module