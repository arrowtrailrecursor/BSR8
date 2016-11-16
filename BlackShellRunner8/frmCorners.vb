Imports System.Drawing.Drawing2D

Public Class frmCorners

    Dim FormsCollected As New List(Of Form)

    Sub New()
        On Error Resume Next
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        MakeMyRegion()
        'ResizeRedraw = True
    End Sub

    Private Sub MakeMyRegion()
        Dim gp As New GraphicsPath
        Dim m_intxAxis As Integer = 0
        Dim m_intyAxis As Integer = 0
        Dim m_intWidth As Integer = Math.Floor(My.Computer.Screen.WorkingArea.Width / 2)
        Dim m_intHeight As Integer = Math.Floor(My.Computer.Screen.WorkingArea.Height / 2)
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

    Private Sub tmrFade_Tick(sender As System.Object, e As System.EventArgs) Handles tmrFadeIn.Tick
        Opacity += (0.01 * frmMain.Opacity)
        If Opacity >= frmMain.Opacity Then
            tmrFadeIn.Enabled = False
            tmrFadeIn.Stop()
            tmrFadeOut.Enabled = True
            tmrFadeOut.Start()
        End If
        Refresh()
    End Sub

    Private Sub tmrFadeOut_Tick(sender As Object, e As System.EventArgs) Handles tmrFadeOut.Tick
        Opacity -= (0.01 * frmMain.Opacity)
        If Opacity <= 0 Then
            tmrFadeOut.Enabled = False
            tmrFadeOut.Stop()
            tmrFadeIn.Enabled = True
            tmrFadeIn.Start()
        End If
    End Sub

    Sub HideAllFormsButMeAnd1()
        FormsCollected.Clear()
        For Each Frm As Form In TheBlackShellRunnerProject.Forms
            If Not Frm.Name = frmMain.Name And Not Frm.Name = Name Then
                If Frm.Visible Then
                    FormsCollected.Add(Frm)
                    Frm.Hide()
                End If
            End If
        Next
    End Sub

    Sub ShowAllFormsButMeAnd1()
        For Each Frm As Form In FormsCollected
            Frm.Show()
        Next
        frmMain.BringToFront()
        FormsCollected.Clear()
    End Sub

    Private Sub StartForm()
        Width = (My.Computer.Screen.WorkingArea.Width / 2)
        Height = (My.Computer.Screen.WorkingArea.Height / 2)
        MakeMyRegion()
        BringToFront()
        frmMain.BringToFront()
        Opacity = frmMain.Opacity
        tmrFadeIn.Interval = 10
        tmrFadeIn.Enabled = True
        tmrFadeIn.Start()
    End Sub

    Private Sub frmCorners_Load(sender As Object, e As EventArgs) Handles Me.Load
        Opacity = frmMain.Opacity
    End Sub

    Private Sub frmCorners_Start(sender As Object, e As System.EventArgs) Handles Me.Activated, Me.LocationChanged, Me.Shown
        StartForm()
    End Sub

    Sub HideFormCorners()
        If tmrFadeIn.Enabled Then
            tmrFadeIn.Enabled = False
            tmrFadeIn.Stop()
        End If
        If tmrFadeOut.Enabled Then
            tmrFadeOut.Enabled = False
            tmrFadeOut.Stop()
        End If
        Opacity = 0
        Hide()
    End Sub

    Private Sub Me_LocationChanged(sender As Object, e As System.EventArgs) Handles Me.LocationChanged
        SetShadows()
    End Sub

    Private Sub frmCorners_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        abbrdr.Invalidate()
    End Sub
End Class