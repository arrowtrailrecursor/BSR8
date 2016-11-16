Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Module modSerial
    Private Sub OpenAndDeserialize(ByVal path As String, Optional ByVal OnLoad As Boolean = False)
        Dim filepath As String = path
        Dim MyProjectSettings As New ArrayList
        Dim BF As New BinaryFormatter
        Dim S As New FileStream(path, FileMode.Open)
        Try
            MyProjectSettings = CType(BF.Deserialize(S), ArrayList)
        Catch ex As Exception
            S.Close()
            MessageBox.Show("Deserialization Failed. The File May Be Corrupt.", "Cannot Open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        S.Close()
        frmOptions.picForeColor.BackColor = CType(MyProjectSettings(0), Color)
        frmOptions.picBackColor.BackColor = CType(MyProjectSettings(1), Color)
        frmOptions.picShadowColor.BackColor = CType(MyProjectSettings(2), Color)
        frmOptions.tbTransparency.Value = CType(MyProjectSettings(3), Integer)
        ColorFormsAndControls(frmOptions.picForeColor.BackColor, frmOptions.picBackColor.BackColor, frmOptions.picShadowColor.BackColor)
        If CType(MyProjectSettings(3), Integer) <> "" Then
            For Each Frms As Form In TheBlackShellRunnerProject.Forms
                Dim OPA As Integer = CType(MyProjectSettings(3), Integer)
                If Not Frms Is Nothing Then Frms.Opacity = OPA / 100
            Next
        Else
            For Each Frms As Form In TheBlackShellRunnerProject.Forms
                Dim OPA As Integer = 100
                If Not Frms Is Nothing Then Frms.Opacity = OPA / 100
            Next
        End If
        'frmOptions.
        'txtCode.Text = CType(MyProjectSettings(0), String)
        'txtIcon.Text = CType(MyProjectSettings(1), String)
        'txtOutputName.Text = CType(MyProjectSettings(2), String)
        'txtOutputPth.Text = CType(MyProjectSettings(3), String)
        'txtStartupObject.Text = CType(MyProjectSettings(4), String)
        'cmbDebugRelease.SelectedIndex = CType(MyProjectSettings(5), Integer)
        'cmbExeOrDll.SelectedIndex = CType(MyProjectSettings(6), Integer)
        'cmbMode.SelectedIndex = CType(MyProjectSettings(7), Integer)
        'Width = CType(MyProjectSettings(8), Integer)
        'Height = CType(MyProjectSettings(9), Integer)
        'Top = CType(MyProjectSettings(10), Integer)
        'Left = CType(MyProjectSettings(11), Integer)
        'If CType(MyProjectSettings(12), String) <> String.Empty Then
        Dim HistoryList() As String = CType(MyProjectSettings(4), String).SPT(Char.Parse(vbCr))
        'ClearReferences()
        'frmLib.lstLibsRefs.Items.Clear()
        frmMain.cmbCmd.Items.Clear()
        For Each l As String In HistoryList
            frmMain.cmbCmd.Items.Add(l)
        Next
        'If CType(MyProjectSettings(13), String) <> String.Empty Then
        'Dim Ress() As String = SPT(CType(MyProjectSettings(13), String), Char.Parse(vbCr))
        'ClearEmbeddedResourceFiles()
        'frmRes.lstReses.Items.Clear()
        'For Each r As String In Ress
        'AddEmbeddedResourceFile(r)
        'frmRes.lstReses.Items.Add(r)
        'Next
        'End If
        'cmbFrameworkVer.SelectedIndex = CType(MyProjectSettings(14), Integer)
        'CCAutoToolStripMenuItem.Checked = CType(MyProjectSettings(15), Boolean)
        'txtCode.Outlining.CollapseToDefinitions()
    End Sub
    Private Sub SaveAndSerialize(ByVal path As String)
        Dim HistoryList As String = ""
        Dim ix As Integer = 0
        For Each item As String In frmMain.cmbCmd.Items
            ix += 1
            If ix = 1 Then
                HistoryList = item
            Else
                HistoryList = HistoryList & vbCr & item
            End If
        Next
        'Dim ress As String = ""
        'Dim ix2 As Integer = 0
        'For Each item As String In frmRes.lstReses.Items
        'ix2 += 1
        'If ix2 = 1 Then
        'ress = item
        'Else
        'ress = ress & vbCr & item
        'End If
        'Next
        Dim MyProjectSettings As New ArrayList
        Dim MyString() As Object = {frmOptions.picForeColor.BackColor,
                                    frmOptions.picBackColor.BackColor,
                                    frmOptions.picShadowColor.BackColor,
                                    frmOptions.tbTransparency.Value,
                                    HistoryList} '= {txtCode.Text, txtIcon.Text, _
        'txtOutputName.Text, txtOutputPth.Text, _
        'txtStartupObject.Text, cmbDebugRelease.SelectedIndex, _
        'cmbExeOrDll.SelectedIndex, cmbMode.SelectedIndex, Width, _
        'Height, Top, Left, libs, ress, cmbFrameworkVer.SelectedIndex, _
        '                           CCAutoToolStripMenuItem.Checked}
        MyProjectSettings.AddRange(MyString)
        Dim BF As New BinaryFormatter
        Dim S As New FileStream(path, FileMode.Create)
        S.SetLength(0)
        Try
            BF.Serialize(S, MyProjectSettings)
        Catch ex As Exception
            S.Close()
            MessageBox.Show("Serialization Failed. Cannot Save File.", "Cannot Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        S.Close()
        'lblStatus.Text = "Saved " & path
    End Sub
End Module