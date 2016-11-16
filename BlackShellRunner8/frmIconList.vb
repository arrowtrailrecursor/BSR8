Imports System.ComponentModel
Imports System.IO
Imports BSR.TAFactory.IconPack

Partial Public Class frmIconList
    Inherits Form
#Region "Variables"
    Protected folderIcon As Icon = Nothing
#End Region

#Region "Constructor"
    Public Sub New()
        InitializeComponent()
    End Sub
#End Region

#Region "Events"

    Private Sub frmIconList_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        folderIcon = IconHelper.ExtractBestFitIcon("%SystemRoot%\system32\shell32.dll", 4, SystemInformation.SmallIconSize)
        AddMergeNode()
        IconList.TileSize = New Size(64, 64)
        AdjustView(64)
        UpdateTreeStatus()
    End Sub

    Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs)
        If diagSelectLibrary.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Refresh()
            Cursor = Cursors.WaitCursor
            Cursor = Cursors.Arrow

        End If
    End Sub

    Private Sub treeIcons_AfterSelect(ByVal sender As Object, ByVal e As TreeViewEventArgs) Handles treeIcons.AfterSelect
        Dim icon As Icon = CType(e.Node.Tag, Icon)
        FillBestFitIcons(icon)
        FillIconListView(icon)
        UpdateTreeStatus()
    End Sub

    Private Sub treeIcons_NodeMouseClick(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs) Handles treeIcons.NodeMouseClick
        If treeIcons.SelectedNode IsNot e.Node Then
            treeIcons.SelectedNode = e.Node
        End If
    End Sub

    Private Sub tlbarMainOpen_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tlbarMainOpen.Click
        If diagSelectLibrary.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            Refresh()
            Cursor = Cursors.WaitCursor
            LoadIconFromLibrary(diagSelectLibrary.FileName)
            Cursor = Cursors.Arrow
        End If
    End Sub
#End Region

#Region "Methods"
    Protected mergeNode As TreeNode = Nothing

    Private Sub AddMergeNode()
        ilTree.Images.Clear()
        ilTree.Images.Add(folderIcon)
        treeIcons.Nodes.Clear()
        mergeNode = treeIcons.Nodes.Add("MergedIcons", "Merged Icons", 0, 0)
        mergeNode.Tag = Nothing
    End Sub

    Protected Function AddFileNode(ByVal fileName As String, ByVal addNode As Boolean) As TreeNode
        Dim info As New FileInfo(fileName)
        If treeIcons.Nodes.ContainsKey(info.FullName.ToLower()) Then
            Return treeIcons.Nodes(info.FullName.ToLower())
        End If

        If addNode Then
            Dim node As TreeNode = treeIcons.Nodes.Add(info.FullName.ToLower(), info.Name, 0, 0)
            node.Tag = Nothing
            Return node
        End If
        Return Nothing
    End Function
    Protected Function LoadIconFromLibrary(ByVal fileName As String) As Boolean
        Dim fileNode As TreeNode = AddFileNode(fileName, False)
        If fileNode IsNot Nothing Then
            treeIcons.SelectedNode = fileNode
            fileNode.ExpandAll()
            treeIcons.Focus()
            Return True
        End If

        Dim extractedIcons As List(Of Icon)
        Try
            extractedIcons = IconHelper.ExtractAllIcons(fileName)
        Catch exp As Exception
            MessageBox.Show(exp.Message, "Icon Extractor", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End Try
        Refresh()
        fileNode = AddFileNode(fileName, True)
        For i As Integer = 0 To extractedIcons.Count - 1
            Dim iconIndex As Integer = ilTree.Images.Count
            ilTree.Images.Add(i.ToString(), IconHelper.GetBestFitIcon(extractedIcons(i), SystemInformation.SmallIconSize))
            Dim node As TreeNode = fileNode.Nodes.Add(i.ToString(), "Icon #" & i.ToString(), iconIndex, iconIndex)
            node.Tag = extractedIcons(i)
        Next i
        fileNode.ExpandAll()
        treeIcons.Focus()
        treeIcons.SelectedNode = fileNode
        Return True
    End Function
    Private Sub FillIconListView(ByVal icon As Icon)
        IconList.Items.Clear()
        If icon Is Nothing Then
            Return
        End If
        Dim l As List(Of Icon) = IconHelper.SplitGroupIcon(icon)
        For Each icn As Icon In l
            Dim item As New IconListViewItem()
            item.Name = IconList.Items.Count.ToString().PadLeft(5, "0"c)
            item.Icon = icn
            IconList.Items.Add(item)
        Next icn
    End Sub
    Private Sub FillBestFitIcons(ByVal icon As Icon)
        If icon Is Nothing Then
            pic16.Image = Nothing
            pic24.Image = Nothing
            pic32.Image = Nothing
            pic48.Image = Nothing
            pic64.Image = Nothing
        Else
            Dim sizeFormat As String = "{0} x {1}"
            Dim icn As Icon = IconHelper.GetBestFitIcon(icon, New Size(64, 64))
            pic64.Image = icn.ToBitmap()
            lbl64.Text = String.Format(sizeFormat, icn.Width, icn.Height)

            icn = IconHelper.GetBestFitIcon(icon, New Size(48, 48))
            pic48.Image = icn.ToBitmap()
            lbl48.Text = String.Format(sizeFormat, icn.Width, icn.Height)

            icn = IconHelper.GetBestFitIcon(icon, New Size(32, 32))
            pic32.Image = icn.ToBitmap()
            lbl32.Text = String.Format(sizeFormat, icn.Width, icn.Height)

            icn = IconHelper.GetBestFitIcon(icon, New Size(24, 24))
            pic24.Image = icn.ToBitmap()
            lbl24.Text = String.Format(sizeFormat, icn.Width, icn.Height)

            icn = IconHelper.GetBestFitIcon(icon, New Size(16, 16))
            pic16.Image = icn.ToBitmap()
            lbl16.Text = String.Format(sizeFormat, icn.Width, icn.Height)
        End If
    End Sub

    Protected Function AddMergedIcon(ByVal icon As Icon) As TreeNode
        Dim iconIndex As Integer = ilTree.Images.Count
        Dim key As String = Guid.NewGuid().ToString()
        ilTree.Images.Add(key, IconHelper.GetBestFitIcon(icon, SystemInformation.SmallIconSize))
        Dim node As TreeNode = mergeNode.Nodes.Add("Merged Icon #" & mergeNode.Nodes.Count.ToString())
        node.ImageKey = key
        node.SelectedImageKey = key
        node.Tag = icon
        Return node
    End Function

    Private Sub MergeIcons(ByVal ParamArray iconList() As Icon)
        If iconList.Length = 0 Then
            Return
        End If

        Dim icon As Icon = IconHelper.Merge(iconList)

        Dim node As TreeNode = AddMergedIcon(icon)
        treeIcons.SelectedNode = node
        treeIcons.Focus()
    End Sub

    Private Sub SaveIcon(ByVal icon As Icon)
        If Not PathExists(TheFlashOrRegularDirectoryPath & "\BSR_ICO", TypeOfPath.Directory) Then
            My.Computer.FileSystem.CreateDirectory(TheFlashOrRegularDirectoryPath & "\BSR_ICO")
        End If
        'Do Until Not PathExists(TheFlashOrRegularDirectoryPath & "\BSR_ICO\" & frmMain.CustomCommandIconNameStr & ".ICO", TypeOfPath.File)
        'Kill(TheFlashOrRegularDirectoryPath & "\BSR_ICO\" & frmMain.CustomCommandIconNameStr.UC & ".ICO")
        'Application.DoEvents()
        'Loop
        Dim PreviousIcon As String = TheFlashOrRegularDirectoryPath & "\BSR_ICO\" & frmMain.CustomCommandIconNameStr & ".ICO"
        If PathExists(PreviousIcon, TypeOfPath.File) Then
            Kill(PreviousIcon)
            Delay(1)
        End If
        Dim fs As FileStream = File.Create(TheFlashOrRegularDirectoryPath & "\BSR_ICO\" & frmMain.CustomCommandIconNameStr.UC & ".ICO")
        icon.Save(fs)
        fs.Close()
        With frmMain
            .picMain.Image = Drawing.Icon.ExtractAssociatedIcon(TheFlashOrRegularDirectoryPath & "\BSR_ICO\" & frmMain.CustomCommandIconNameStr.UC & ".ICO").ToBitmap
            .Refresh()
        End With
        With frmCustomCommads
            .picMain.BackgroundImage = Drawing.Icon.ExtractAssociatedIcon(TheFlashOrRegularDirectoryPath & "\BSR_ICO\" & frmMain.CustomCommandIconNameStr.UC & ".ICO").ToBitmap
            .Refresh()
        End With
        Close()
    End Sub

    Private Sub AdjustView(ByVal width As Integer)
        mnuIconListView16.Checked = (width = 16)
        mnuIconListView24.Checked = (width = 24)
        mnuIconListView32.Checked = (width = 32)
        mnuIconListView48.Checked = (width = 48)
        mnuIconListView64.Checked = (width = 64)
        mnuIconListView96.Checked = (width = 96)
        'tlbarMainView16.Checked = (width = 16)
        'tlbarMainView24.Checked = (width = 24)
        'tlbarMainView32.Checked = (width = 32)
        'tlbarMainView48.Checked = (width = 48)
        'tlbarMainView64.Checked = (width = 64)
        'tlbarMainView96.Checked = (width = 96)
    End Sub
    Private Sub ShowIconProperties(ByVal icon As Icon)
        Dim info As New IconInfo(icon)
        Dim format As String = "Width: {0}" & Constants.vbLf & "Height: {1}" & Constants.vbLf & "Bit Count: {2}" & Constants.vbLf & "Color Depth: {3}" & Constants.vbLf & "Color Count: {4}" & Constants.vbLf & "# Of Images: {5}" & Constants.vbLf
        Dim message As String = String.Format(format, info.Width, info.Height, info.BitCount, info.ColorDepth, info.ColorCount, info.Images.Count)
        MessageBox.Show(message, "Icon Properties", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub UpdateTreeStatus()
        Dim selected As TreeNode = treeIcons.SelectedNode
        If selected Is Nothing Then
            Return
        End If
    End Sub

#End Region

#Region "Tree Menu Events"
    Private Sub cntxtTree_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles cntxtTree.Opening
        Dim icon As Icon = CType(treeIcons.SelectedNode.Tag, Icon)
        e.Cancel = (icon Is Nothing)
    End Sub
    Private Sub mnuTreeSaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuTreeSaveAs.Click
        Dim icon As Icon = CType(treeIcons.SelectedNode.Tag, Icon)
        If icon IsNot Nothing Then
            SaveIcon(icon)
        End If
    End Sub
    Private Sub mnuTreeProperties_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuTreeProperties.Click
        Dim icon As Icon = CType(treeIcons.SelectedNode.Tag, Icon)
        If icon IsNot Nothing Then
            ShowIconProperties(icon)
        End If
    End Sub
#End Region

#Region "Icon List Menu Events"
    Private Sub cntxtIconList_Opening(ByVal sender As Object, ByVal e As CancelEventArgs) Handles cntxtIconList.Opening
        Dim item As IconListViewItem = Nothing
        '  If iconList.SelectedIndices.Count = 1 Then
        '     item = TryCast(iconList.SelectedItems(0), IconListViewItem)
        '    End If
        mnuIconListSaveAs.Enabled = (item IsNot Nothing)
        mnuIconListProperties.Enabled = (item IsNot Nothing)
        '   mnuIconListMerge.Enabled = (iconList.SelectedIndices.Count > 1)
    End Sub
    Private Sub mnuIconListSaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuIconListSaveAs.Click
        '  Dim item As IconListViewItem = TryCast(iconList.SelectedItems(0), IconListViewItem)

        'If item IsNot Nothing Then
        'SaveIcon(item.Icon)
        'End If
    End Sub
    Private Sub mnuIconListView16_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuIconListView16.Click
        'iconList.TileSize = New Size(16, 16)
        AdjustView(16)
    End Sub
    Private Sub mnuIconListView24_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuIconListView24.Click
        'iconList.TileSize = New Size(24, 24)
        AdjustView(24)
    End Sub
    Private Sub mnuIconListView32_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuIconListView32.Click
        'iconList.TileSize = New Size(32, 32)
        AdjustView(32)
    End Sub
    Private Sub mnuIconListView48_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuIconListView48.Click
        'iconList.TileSize = New Size(48, 48)
        AdjustView(48)
    End Sub
    Private Sub mnuIconListView64_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuIconListView64.Click
        'iconList.TileSize = New Size(64, 64)
        AdjustView(64)
    End Sub
    Private Sub mnuIconListView96_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuIconListView96.Click
        'iconList.TileSize = New Size(96, 96)
        AdjustView(96)
    End Sub
    Private Sub mnuIconListProperties_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuIconListProperties.Click
        'Dim item As IconListViewItem = TryCast(iconList.SelectedItems(0), IconListViewItem)
        ' If item IsNot Nothing Then
        'ShowIconProperties(item.Icon)
        'End If
    End Sub
    Private Sub mnuIconListMerge_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mnuIconListMerge.Click
        If IconList.SelectedIndices.Count < 2 Then

            Return
        End If
        Dim list As List(Of Icon) = New List(Of Icon)()
        For Each item As IconListViewItem In IconList.SelectedItems
            If item.Icon IsNot Nothing Then
                list.Add(item.Icon)
            End If
        Next item
        If list.Count < 2 Then
            Return
        End If
        MergeIcons(list.ToArray())
    End Sub
#End Region

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If Not LCase(treeIcons.SelectedNode.Text).Contains(".exe") _
            And Not LCase(treeIcons.SelectedNode.Text).Contains(".dll") _
            And Not LCase(treeIcons.SelectedNode.Text).Contains(".ico") _
            And Not LCase(treeIcons.SelectedNode.Text).Contains("merged icons") Then
            Dim icon As Icon = CType(treeIcons.SelectedNode.Tag, Icon) 'If item IsNot Nothing Then
            SaveIcon(icon)
        End If
    End Sub

    Private Sub iconList_VirtualItemsSelectionRangeChanged(sender As Object, e As System.Windows.Forms.ListViewVirtualItemsSelectionRangeChangedEventArgs)
        IconList.ForeColor = frmOptions.picForeColor.BackColor
    End Sub

End Class