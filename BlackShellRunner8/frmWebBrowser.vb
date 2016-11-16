Imports System.Collections.Specialized
Public Class frmWebBrowse

    Protected URLs As New StringCollection
    Protected HostURLs As New StringCollection
    Public Shared Property SpawnNewWindowOnHostSwitch As Boolean = True
    Public SurppressList As Boolean = False
    Public Shared Property HomePage As String = ""
    Public NewHost As String = ""

    Sub New(Optional ByVal vURLs As StringCollection = Nothing, Optional ByVal vHostURLs As StringCollection = Nothing)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        If Not vURLs Is Nothing Then URLs = vURLs
        If Not vHostURLs Is Nothing Then HostURLs = vHostURLs
    End Sub

    Private Sub wbMain_DocumentTitleChanged(sender As Object, e As System.EventArgs) Handles wbMain.DocumentTitleChanged
        Text = wbMain.Document.Title
    End Sub

    Private Sub wbMain_StatusTextChanged(sender As Object, e As System.EventArgs) Handles wbMain.StatusTextChanged
        tsslStatus.Text = wbMain.StatusText
        tsslStatus.Invalidate()
    End Sub

    Private Sub wbMain_Navigated(sender As Object, e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles wbMain.Navigated
        Dim HostTo As String = wbMain.Url.Host
        If Not (HostTo = NewHost) Then
            NewHost = HostTo
            If Not HostExists(HostTo) Then HostURLs.Add(HostTo)
        End If
        Dim NavTo As String = wbMain.Url.ToString
        Static X As String = ""
        If Not NavTo = X And Not SurppressList Then
            X = NavTo
            If Exists(NavTo) Then
                RemoveItemByName(NavTo)
            End If
            cmbAddressBar.Items.Add(NavTo)
            URLs.Add(NavTo)
        End If
        cmbAddressBar.Text = NavTo
        SurppressList = False
    End Sub

    Protected Function HostExists(ByVal Host As String) As Boolean
        For Each hst As String In HostURLs
            If hst = Host Then Return True
        Next
        Return False
    End Function

    Private Sub RemoveItemByName(Item As String)
        Dim inx As Integer = 0
        Dim err As Boolean = True
        Do Until err = False
            Try
                For Each I As String In cmbAddressBar.Items
                    If I = Item Then
                        cmbAddressBar.Items.RemoveAt(inx)
                    End If
                    inx += 1
                Next
                err = False
            Catch ex As Exception
                err = True
            End Try
        Loop
    End Sub

    Private Sub RemoveHostItemByName(Item As String)
        Dim inx As Integer = 0
        Dim err As Boolean = True
        Do Until err = False
            Try
                For Each I As String In HostURLs
                    If I = Item Then
                        HostURLs.RemoveAt(inx)
                    End If
                    inx += 1
                Next
                err = False
            Catch ex As Exception
                err = True
            End Try
        Loop
    End Sub

    Private Sub abGoToHost_Click(sender As System.Object, e As System.EventArgs) Handles abGoToHost.Click
        Try
            wbMain.Navigate(wbMain.Url.Host)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub abBackward_Click(sender As System.Object, e As System.EventArgs) Handles abBackward.Click
        Try
            wbMain.Navigate(URLs.Item(GetBackwardURLIndex))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub abForward_Click(sender As System.Object, e As System.EventArgs) Handles abForward.Click
        Try
            wbMain.Navigate(URLs.Item(GetForwardURLIndex))
        Catch ex As Exception
        End Try
    End Sub

    Protected Function GetBackwardURLIndex() As Integer
        wbMain.Stop()
        Dim CurrentURL As String = wbMain.Url.ToString
        Dim URLi As Integer = 0
        For Each URL As String In URLs
            If URL = CurrentURL Then
                Return URLi - 1
            End If
            URLi += 1
        Next
        Return URLi
    End Function

    Protected Function GetForwardURLIndex() As Integer
        Dim CurrentURL As String = wbMain.Url.ToString
        Dim URLi As Integer = 0
        For Each URL As String In URLs
            If URL = CurrentURL Then
                Return URLi + 1
            End If
            URLi += 1
        Next
        Return URLi
    End Function

    Protected Function GetBackwardSite(Optional ByVal Surppress As Boolean = True) As String
        Dim TopInx As Integer = (HostURLs.Count - 1)
        Dim BotInx As Integer = 0
        Dim CurrentInx = GetCurrentHostInx() - 1
        If CurrentInx < BotInx Then CurrentInx = TopInx
        Dim RetVal As String = HostURLs.Item(CurrentInx)
        SurppressList = Surppress
        Return RetVal
    End Function

    Protected Function GetForwardSite(Optional ByVal Surppress As Boolean = True) As String
        Dim TopInx As Integer = (HostURLs.Count - 1)
        Dim BotInx As Integer = 0
        Dim CurrentInx = GetCurrentHostInx() + 1
        If CurrentInx > TopInx Then CurrentInx = BotInx
        Dim RetVal As String = HostURLs.Item(CurrentInx)
        SurppressList = Surppress
        Return RetVal
    End Function

    Protected Function GetCurrentHostInx() As Integer
        Dim Host = wbMain.Url.Host
        Dim TopInx As Integer = (HostURLs.Count - 1)
        Dim BotInx As Integer = 0
        Dim CurrentHost As String = ""
        For inx As Integer = TopInx To BotInx Step -1
            CurrentHost = HostURLs.Item(inx)
            If CurrentHost.CNT(Host) Then Return inx
        Next
    End Function

    Protected Function ConvertToHost(ByVal Host As String) As String
        Try
            Dim ReturnHost As String = Host.SPT("/").ToArray(0) & "//" & Host.SPT("/").ToArray(2)
            Dim FinalRetValue As String = ""
            If ReturnHost.RT(1) = "/" Then
                FinalRetValue = LT(ReturnHost, (ReturnHost.LN - 1))
            Else
                FinalRetValue = ReturnHost
            End If
            Return ReturnHost
        Catch ex As IndexOutOfRangeException
        End Try
    End Function

    Protected Function Exists(ByVal TxtToAdd As String) As Boolean
        Dim AlreadyExists As Boolean = False
        For Each Item As String In cmbAddressBar.Items
            If TxtToAdd = Item Then AlreadyExists = True
        Next
        Return AlreadyExists
    End Function

    Private Sub frmWebBrowse_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        Hide()
        If e.CloseReason = CloseReason.FormOwnerClosing Then
            wbMain.Stop()
            If clsExecuteCommand.isNewerOS Then
                If INIReadBoolean(INISettingsPath, "Internet", "PromptForCleanUp") Then
                    Dim YNClearMyTracks As DialogResult = MessageBox.Show("Do You Wish To Delete All Windows Internet Data?", "Clear My Tracks", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If YNClearMyTracks = Windows.Forms.DialogResult.Yes Then _
                        System.Diagnostics.Process.Start("RunDll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 4351")
                Else
                    System.Diagnostics.Process.Start("RunDll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 4351")
                End If
            End If
        End If
    End Sub

    Private Sub frmWebBrowse_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ColorFormsAndControls(frmOptions.picForeColor.BackColor, frmOptions.picBackColor.BackColor, frmOptions.picShadowColor.BackColor)
        SetSounds(frmOptions.chkSound.Checked)
        SetOpacity()
    End Sub

    Private Sub cmbAddressBar_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cmbAddressBar.KeyUp
        If e.KeyData = Keys.Return Or e.KeyData = Keys.Enter Then
            Try
                wbMain.Navigate(cmbAddressBar.Text)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub abUpDir_Click(sender As System.Object, e As System.EventArgs) Handles abUpDir.Click
        With cmbAddressBar
            Dim Url As String = .Text
            Static sUrl As String = ""
            Try
                sUrl = Url.LT(Url.LN - (Url.SPT("/").Last.LN))
                If sUrl.RT(1) = "/" Then
                    sUrl = sUrl.LT(sUrl.LN - 1)
                End If
                If sUrl Like "*://*" Then
                    wbMain.Navigate(sUrl)
                    .Text = sUrl
                End If
            Catch ex As Exception
            End Try
        End With
    End Sub

    Private Sub abRefresh_Click(sender As System.Object, e As System.EventArgs) Handles abRefresh.Click
        wbMain.Refresh()
    End Sub

    Private Sub abHome_Click(sender As System.Object, e As System.EventArgs) Handles abHome.Click
        wbMain.Navigate(HomePage)
    End Sub

    Private Sub abPanic_Click(sender As System.Object, e As System.EventArgs) Handles abPanic.Click
        Hide()
        wbMain.Stop()
        If clsExecuteCommand.isNewerOS Then
            If INIReadBoolean(INISettingsPath, "Internet", "PromptForCleanUp") Then
                Dim YNClearMyTracks As DialogResult = MessageBox.Show("Do You Wish To Delete All Windows Internet Data?", "Clear My Tracks", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If YNClearMyTracks = Windows.Forms.DialogResult.Yes Then _
                    System.Diagnostics.Process.Start("RunDll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 4351")
            Else
                System.Diagnostics.Process.Start("RunDll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 4351")
            End If
        End If
        Dispose()
    End Sub

    Sub abBackwardSite_Click(sender As System.Object, e As System.EventArgs) Handles abBackwardSite.Click
        Try
            If Not SpawnNewWindowOnHostSwitch Then
                wbMain.Navigate(GetBackwardSite(True))
            Else
                clsExecuteCommand.SpawnNewBrowserWindow(GetBackwardSite(True), Nothing, False, Me, URLs, HostURLs)
                Dispose()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub abForwardSite_Click(sender As System.Object, e As System.EventArgs) Handles abForwardSite.Click
        Try
            If Not SpawnNewWindowOnHostSwitch Then
                wbMain.Navigate(GetForwardSite(True))
            Else
                clsExecuteCommand.SpawnNewBrowserWindow(GetForwardSite(True), Nothing, False, Me, URLs, HostURLs)
                Dispose()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub StatusStrip1_Invalidated(sender As Object, e As System.Windows.Forms.InvalidateEventArgs) Handles ssMain.Invalidated
        tsslStatus.ForeColor = ssMain.ForeColor
    End Sub

    Private Sub abGoURL_Click(sender As System.Object, e As System.EventArgs) Handles abGoURL.Click
        Try
            wbMain.Navigate(cmbAddressBar.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class