Public Class frmMessageBox

    Public Sub BtnClick(ByVal sender As Object, ByVal e As EventArgs)
        ' set the name of the button to the result
        result = CType(sender, AcidControls.AcidButton).Text
        ' set clicked to be True
        clicked = True
        ' close the form
        Hide()
    End Sub

    Public Sub ShowMsg(Message As String, Title As String)
        clicked = False
        Text = ""
        Text = Title
        Dim InitialTextSize As Size = TextRenderer.MeasureText(Message, Font)
        Dim InitialWindowWidth As Integer = ((InitialTextSize.Width + txtMessage.Left) + (Width - txtMessage.Right))
        Dim MaxSize = (My.Computer.Screen.WorkingArea.Width / 3)
            If InitialWindowWidth > MaxSize Then
            Width = MaxSize
        Else
            Width = InitialWindowWidth
        End If
        With txtMessage
            .Text = ""
            .Text = Message
            .SelectionLength = 0
            .SelectionStart = .Text.LN
            Dim sz As Graphics = .CreateGraphics
            Height = sz.MeasureString(Message, .Font, .Width).Height + ((Height - .Height) + .Location.Y)
            sz.Dispose()
        End With
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Public Sub ShowBtn()
        Dim x As Integer, y As Integer
        x = txtMessage.Location.X
        y = txtMessage.Location.Y + txtMessage.Size.Height - 1
        Dim btns(names.Count - 1) As AcidControls.AcidButton
        Dim i As Integer
        For i = 0 To btns.Count - 1
            btns(i) = New AcidControls.AcidButton()
            With btns(i)
                .Text = names(i)
                .Size = New Size(btns(i).Text.Length * 15, 25)
                AddHandler .Click, AddressOf BtnClick
                If i > 0 Then
                    If (Width - (btns(i - 1).Location.X + btns(i - 1).Size.Width + 10)) < .Size.Width Then
                        x = txtMessage.Location.X
                        y = txtMessage.Location.Y + txtMessage.Size.Height
                    End If
                End If
                Controls.Add(btns(i))
                .BringToFront()
                .Location = New Point(x, y)
                .Height = 21
                .BackColor = frmOptions.picBackColor.BackColor
                .ForeColor = frmOptions.picForeColor.BackColor
                .ShadowColor = frmOptions.picShadowColor.BackColor
                .ShiftForeColor = frmOptions.picShadowColor.BackColor
                .ShiftShadowColor = frmOptions.picForeColor.BackColor
                .Cursor = Cursors.Hand
                .ShiftAllOnClick = True
                .ShadowAllWithMouseEnter = True
                .MouseEnterSoundResource = My.Resources.BSRbtnSel
                .MouseEnterSoundResourcePath = SelectSound
                .MouseEnterAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
                .MouseClickSoundResource = My.Resources.BSRbtnClose
                .MouseClickSoundResourcePath = CloseSound
                .MouseClickAudioMode = AcidControls.AcidButton.AudioMode.WaitToComplete
                .HasSound = frmOptions.chkSound.Checked
                .RoundedRadius = 10
                .TextShadowDisplacement = 0.5
                .Width = 60
                .Font = New Font("Microsoft Sans Serif", 8, FontStyle.Bold)
                .Invalidate()
                x += .Size.Width + 4
            End With
        Next
    End Sub

    Public Sub ShowPic(icon As MessageBoxIcon)
        Select Case icon
            Case 16 'Circle with Red X
                pbPics.Image = SystemIcons.Error.ToBitmap
                Me.Icon = SystemIcons.Error.ToIcon
                If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(ErrorSound, AudioPlayMode.WaitToComplete)
            Case 32 'Question Mark Circle
                pbPics.Image = SystemIcons.Question.ToBitmap
                Me.Icon = SystemIcons.Question
                If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(InfoSound, AudioPlayMode.WaitToComplete)
            Case 48 'Exclamation Mark Circle
                pbPics.Image = SystemIcons.Warning.ToBitmap
                Me.Icon = SystemIcons.Warning
                If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(ErrorSound, AudioPlayMode.WaitToComplete)
            Case 64 'Info Circle with i
                pbPics.Image = SystemIcons.Information.ToBitmap
                Me.Icon = SystemIcons.Information
                If frmOptions.chkSound.Checked Then My.Computer.Audio.Play(InfoSound, AudioPlayMode.WaitToComplete)
        End Select
    End Sub

    Private Sub frmMessageBox_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
    End Sub

    Private Sub CustomMessageBox_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        BackColor = frmOptions.picBackColor.BackColor
        ForeColor = frmOptions.picForeColor.BackColor
        txtMessage.BackColor = frmOptions.picBackColor.BackColor
        txtMessage.ForeColor = frmOptions.picForeColor.BackColor
        abBrdr.BackColor = frmOptions.picBackColor.BackColor
        abBrdr.ForeColor = frmOptions.picForeColor.BackColor
        abBrdr.ShadowColor = frmOptions.picShadowColor.BackColor
        abBrdr.ShiftForeColor = frmOptions.picShadowColor.BackColor
        abBrdr.ShiftShadowColor = frmOptions.picForeColor.BackColor
        abBrdr.TextShadowDisplacement = 0.5
        pbPics.BackColor = frmOptions.picBackColor.BackColor
        BringToFront()
        StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class