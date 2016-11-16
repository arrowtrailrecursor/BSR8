Public Class frmWithAniAndITSmod
    Friend WithEvents vParent As Form
    Private vAnimation As Image
    Public Property Animation As Image
        Get
            Return vAnimation
        End Get
        Set(value As Image)
            vAnimation = value
            picBG.Image = value
            Invalidate()
        End Set
    End Property
    Property ParentOfAnimationForm As Form
        Get
            Return vParent
        End Get
        Set(value As Form)
            vParent = value
            Invalidate()
        End Set
    End Property
    Public Sub New(ByVal ParentForm As Form, ByVal Opacity As Double, ByVal BackColor As Color, ByVal Picture As Image)
        ' This call is required by the designer.
        InitializeComponent()
        picBG.Image = Picture
        picBG.BackColor = BackColor
        ParentOfAnimationForm = ParentForm
        Opacity = Opacity
        If ParentForm.FormBorderStyle = FormBorderStyle.None Then Region = ParentForm.Region
        'ParentOpacity = ParentOpacity
    End Sub
    Private Sub frmWithAni_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Hide()
    End Sub

    Private Sub ParentVisibleChanged() Handles vParent.VisibleChanged
        If vParent.Visible Then
            Show()
            Visible = True
            Opacity = (frmOptions.tbPicOpacity.Value / 100)
            KeepZOrderInCheck()
        Else
            Opacity = 0
            Visible = False
            Hide()
        End If
    End Sub

    Private Sub ParentSizeChanged() Handles vParent.SizeChanged
        Dim CRec As Rectangle = vParent.ClientRectangle
        Dim SizeTo As Size
        Dim PTS As Point = vParent.PointToScreen(CRec.Location)
        Static Pnt As Integer
        SizeTo = New Size(CRec.Width, CRec.Height)
        SizeTo = New Size(CRec.Width, CRec.Height)
        Size = SizeTo
        KeepZOrderInCheck()
        Region = vParent.Region
        Invalidate()
    End Sub

    Private Sub ParentLocationChanged() Handles vParent.LocationChanged
        Dim CRec As Rectangle = vParent.ClientRectangle
        Dim PTS As Point = vParent.PointToScreen(CRec.Location)
        Dim LocTo As Point
        LocTo = New Point(PTS.X, PTS.Y)
        Location = LocTo
        KeepZOrderInCheck()
    End Sub

    Private Sub frmWithAniAndITSmod_Load(sender As Object, e As EventArgs) Handles Me.Load
        ParentLocationChanged()
        ParentSizeChanged()
    End Sub
    Private Sub KeepZOrderInCheck()
        If vParent.TopMost Then
            TopMost = True
        Else
            TopMost = False
        End If
        BringToFront()
        vParent.BringToFront()
        'Refresh()
        vParent.Refresh()
    End Sub
    Private Sub vParent_Mouse(sender As Object, e As EventArgs) Handles vParent.MouseEnter, vParent.MouseLeave, vParent.MouseHover
        SendToBack()
        KeepZOrderInCheck()
    End Sub

    Private Sub frmWithAniAndITSmod_Mouse(sender As Object, e As EventArgs) Handles Me.MouseEnter, Me.MouseLeave, Me.MouseHover
        SendToBack()
        KeepZOrderInCheck()
    End Sub
End Class
'And Its Modules
Public Module WindowDecoration

    Public FormAnimationLayerForms As New List(Of frmWithAniAndITSmod)
    Public FormsToDecorate As List(Of Form)
    Public Animation As String = ""
    'Public Picture As Image
    Public Sub DecorateListOfForms(ByVal FGOpacity As Double, ByVal BGPicOpacity As Double, ByVal PicturePath As String)
        Animation = PicturePath
        Dim x As Integer = 0
        For x = 1 To FormsToDecorate.Count
            If Not PathExists(PicturePath & x, TypeOfPath.File) Then IO.File.Copy(PicturePath, PicturePath & x)
        Next
        If FormAnimationLayerForms.Count > 0 Then
            For Each Form As frmWithAniAndITSmod In FormAnimationLayerForms
                For Each TheParent As Form In FormsToDecorate
                    If Form.ParentOfAnimationForm Is TheParent Then Form.Hide() : GoTo after
                Next
                x += 1
                Form.Show()
                Form.Animation = New Bitmap(PicturePath & x)
after:
            Next
        End If
        FormAnimationLayerForms.Clear()
        x = 0
        For Each Form As Form In FormsToDecorate
            x += 1
            DecorateForm(Form, FGOpacity, BGPicOpacity, PicturePath & x)
        Next
    End Sub

    Public Sub DecorateForm(ByVal Form As Form, ByVal FGOpacity As Double, ByVal BGPicOpacity As Double, ByVal PicturePath As String)
        ' If Form IsNot frmHidden And Form IsNot frmCorners Then
        Dim TransAniForm As New frmWithAniAndITSmod(Form, FGOpacity, frmOptions.picBackColor.BackColor, New Bitmap(PicturePath))
        TransAniForm.Animation = New Bitmap(PicturePath)
        FormAnimationLayerForms.Add(TransAniForm)
        'End If
    End Sub
    Public Sub DisposeOfDecorationForms()
        For Each Form As frmWithAniAndITSmod In FormAnimationLayerForms
            Form.Visible = False
            Form.Animation = Nothing
        Next
    End Sub

End Module
Module modLayeredAnimation
    Public Sub SetFormAnimation(ByVal PicturePath As String, ByVal FGOpacity As Double, ByVal PicOpacity As Double, Optional ByVal ApplyToVisibleForms As Boolean = False)

        WindowDecoration.FormsToDecorate = TheBlackShellRunnerProject.Forms
        If PicturePath = "" Then
            WindowDecoration.DecorateListOfForms(FGOpacity, PicOpacity, Nothing)
        Else
            WindowDecoration.DecorateListOfForms(FGOpacity, PicOpacity, PicturePath)
        End If
        If ApplyToVisibleForms Then ApplyAnimation()
    End Sub

    Dim FrmVis As New List(Of Form)

    Public Sub ApplyAnimation()
        FrmVis.Clear()
        For Each Form As Form In TheBlackShellRunnerProject.Forms
            If Form.Visible Then
                FrmVis.Add(Form)
                Form.Hide()
            End If
        Next
        For Each Form As Form In FrmVis
            If Not Form.Visible Then
                Form.Show()
                Form.BringToFront()
            End If
        Next
    End Sub
End Module