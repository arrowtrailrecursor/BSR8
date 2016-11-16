Imports System.Drawing.Drawing2D

Public Class frmHidden

    Private Sub abShow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles abShow.Click
        frmMain.ShowAllForms()
        Hide()
    End Sub

    Private Sub tmrMoveToCorner_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmrMoveToCorner.Tick
        tmrMoveToCorner.Enabled = False
        tmrMoveToCorner.Stop()
        Width = 60
        Height = 21
        If TopLeft() Then
            GoTopLeft()
        End If
        If TopRight() Then
            GoTopRight()
        End If
        If BottomLeft() Then
            GoBottomLeft()
        End If
        If BottomRight() Then
            GoBottomRight()
        End If
    End Sub

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Height = 21
        Width = 60
    End Sub

    Private Sub frmHidden_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Width = 60
        Height = 21
        Dim gp As New GraphicsPath
        Dim m_intxAxis As Integer = 0
        Dim m_intyAxis As Integer = 0
        Dim m_intWidth As Integer = Width
        Dim m_intHeight As Integer = Height
        Dim m_diameter As Integer = 12
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
        Region = New Region(gp)
    End Sub

    Private Sub Me_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        SetShadows()
    End Sub

End Class