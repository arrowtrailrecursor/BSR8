Imports Microsoft.VisualBasic
Imports System

Partial Public Class frmIconList

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIconList))
        label2 = New System.Windows.Forms.Label()
        treeIcons = New System.Windows.Forms.TreeView()
        cntxtTree = New System.Windows.Forms.ContextMenuStrip(components)
        mnuTreeSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        toolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        mnuTreeProperties = New System.Windows.Forms.ToolStripMenuItem()
        ilTree = New System.Windows.Forms.ImageList(components)
        diagSelectLibrary = New System.Windows.Forms.OpenFileDialog()
        panel1 = New System.Windows.Forms.Panel()
        lbl16 = New System.Windows.Forms.Label()
        lbl24 = New System.Windows.Forms.Label()
        lbl32 = New System.Windows.Forms.Label()
        lbl48 = New System.Windows.Forms.Label()
        lbl64 = New System.Windows.Forms.Label()
        label12 = New System.Windows.Forms.Label()
        label10 = New System.Windows.Forms.Label()
        label8 = New System.Windows.Forms.Label()
        label6 = New System.Windows.Forms.Label()
        label4 = New System.Windows.Forms.Label()
        pic16 = New System.Windows.Forms.PictureBox()
        pic24 = New System.Windows.Forms.PictureBox()
        pic32 = New System.Windows.Forms.PictureBox()
        pic48 = New System.Windows.Forms.PictureBox()
        pic64 = New System.Windows.Forms.PictureBox()
        label3 = New System.Windows.Forms.Label()
        cntxtIconList = New System.Windows.Forms.ContextMenuStrip(components)
        mnuIconListSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        mnuIconListMerge = New System.Windows.Forms.ToolStripMenuItem()
        toolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        mmnuIconListView = New System.Windows.Forms.ToolStripMenuItem()
        mnuIconListView16 = New System.Windows.Forms.ToolStripMenuItem()
        mnuIconListView24 = New System.Windows.Forms.ToolStripMenuItem()
        mnuIconListView32 = New System.Windows.Forms.ToolStripMenuItem()
        mnuIconListView48 = New System.Windows.Forms.ToolStripMenuItem()
        mnuIconListView64 = New System.Windows.Forms.ToolStripMenuItem()
        mnuIconListView96 = New System.Windows.Forms.ToolStripMenuItem()
        toolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        mnuIconListProperties = New System.Windows.Forms.ToolStripMenuItem()
        tlbarMain = New System.Windows.Forms.ToolStrip()
        tlbarMainOpen = New System.Windows.Forms.ToolStripButton()
        ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        mcttMain = New AcidControls.AcidToolTip(components)
        IconList = New BSR.TAFactory.IconPack.IconListView()
        cntxtTree.SuspendLayout()
        panel1.SuspendLayout()
        CType(pic16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(pic24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(pic32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(pic48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(pic64, System.ComponentModel.ISupportInitialize).BeginInit()
        cntxtIconList.SuspendLayout()
        tlbarMain.SuspendLayout()
        SuspendLayout()
        '
        'label2
        '
        label2.AutoSize = True
        label2.BackColor = System.Drawing.Color.Black
        label2.ForeColor = System.Drawing.Color.Lime
        label2.Location = New System.Drawing.Point(9, 25)
        label2.Name = "label2"
        label2.Size = New System.Drawing.Size(55, 13)
        label2.TabIndex = 0
        label2.Text = "Icons List:"
        '
        'treeIcons
        '
        treeIcons.AllowDrop = True
        treeIcons.Anchor = System.Windows.Forms.AnchorStyles.Top
        treeIcons.BackColor = System.Drawing.Color.Black
        treeIcons.ContextMenuStrip = cntxtTree
        treeIcons.Cursor = System.Windows.Forms.Cursors.Hand
        treeIcons.ForeColor = System.Drawing.Color.Lime
        treeIcons.HideSelection = False
        treeIcons.HotTracking = True
        treeIcons.ImageIndex = 0
        treeIcons.ImageList = ilTree
        treeIcons.LineColor = System.Drawing.Color.Lime
        treeIcons.Location = New System.Drawing.Point(9, 41)
        treeIcons.Name = "treeIcons"
        treeIcons.SelectedImageIndex = 0
        treeIcons.Size = New System.Drawing.Size(204, 106)
        treeIcons.TabIndex = 3
        mcttMain.SetToolTip(treeIcons, "Select Opened Icon And Click The Save Button Above To Set As BlackShellRunner Cus" &
        "tom Command Icon")
        '
        'cntxtTree
        '
        cntxtTree.Items.AddRange(New System.Windows.Forms.ToolStripItem() {mnuTreeSaveAs, toolStripMenuItem2, mnuTreeProperties})
        cntxtTree.Name = "cntxtTree"
        cntxtTree.Size = New System.Drawing.Size(128, 54)
        '
        'mnuTreeSaveAs
        '
        mnuTreeSaveAs.Name = "mnuTreeSaveAs"
        mnuTreeSaveAs.Size = New System.Drawing.Size(127, 22)
        mnuTreeSaveAs.Text = "&Save As..."
        '
        'toolStripMenuItem2
        '
        toolStripMenuItem2.Name = "toolStripMenuItem2"
        toolStripMenuItem2.Size = New System.Drawing.Size(124, 6)
        '
        'mnuTreeProperties
        '
        mnuTreeProperties.Name = "mnuTreeProperties"
        mnuTreeProperties.Size = New System.Drawing.Size(127, 22)
        mnuTreeProperties.Text = "P&roperties"
        '
        'ilTree
        '
        ilTree.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        ilTree.ImageSize = New System.Drawing.Size(16, 16)
        ilTree.TransparentColor = System.Drawing.Color.Transparent
        '
        'diagSelectLibrary
        '
        diagSelectLibrary.FileName = "c:\windows\system32\shell32.dll"
        diagSelectLibrary.Filter = "All Supported Files (*.exe, *.dll, *.ico)|*.exe;*.dll;*.ico|Executable Modules (*" &
    ".exe, *.dll)|*.exe;*.dll|Icon Files (*.ico)|*.ico|All Files (*.*)|*.*"
        diagSelectLibrary.InitialDirectory = "%SystemRoot%\system32\"
        diagSelectLibrary.Title = "Select File"
        '
        'panel1
        '
        panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        panel1.BackColor = System.Drawing.Color.Black
        panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        panel1.Controls.Add(lbl16)
        panel1.Controls.Add(lbl24)
        panel1.Controls.Add(lbl32)
        panel1.Controls.Add(lbl48)
        panel1.Controls.Add(lbl64)
        panel1.Controls.Add(label12)
        panel1.Controls.Add(label10)
        panel1.Controls.Add(label8)
        panel1.Controls.Add(label6)
        panel1.Controls.Add(label4)
        panel1.Controls.Add(pic16)
        panel1.Controls.Add(pic24)
        panel1.Controls.Add(pic32)
        panel1.Controls.Add(pic48)
        panel1.Controls.Add(pic64)
        panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        panel1.Location = New System.Drawing.Point(218, 41)
        panel1.Name = "panel1"
        panel1.Size = New System.Drawing.Size(354, 106)
        panel1.TabIndex = 4
        '
        'lbl16
        '
        lbl16.ForeColor = System.Drawing.Color.Lime
        lbl16.Location = New System.Drawing.Point(283, 84)
        lbl16.Name = "lbl16"
        lbl16.Size = New System.Drawing.Size(64, 13)
        lbl16.TabIndex = 1
        lbl16.Text = "New Size"
        lbl16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl24
        '
        lbl24.ForeColor = System.Drawing.Color.Lime
        lbl24.Location = New System.Drawing.Point(213, 84)
        lbl24.Name = "lbl24"
        lbl24.Size = New System.Drawing.Size(64, 13)
        lbl24.TabIndex = 1
        lbl24.Text = "New Size"
        lbl24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl32
        '
        lbl32.ForeColor = System.Drawing.Color.Lime
        lbl32.Location = New System.Drawing.Point(143, 84)
        lbl32.Name = "lbl32"
        lbl32.Size = New System.Drawing.Size(64, 13)
        lbl32.TabIndex = 1
        lbl32.Text = "New Size"
        lbl32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl48
        '
        lbl48.ForeColor = System.Drawing.Color.Lime
        lbl48.Location = New System.Drawing.Point(73, 84)
        lbl48.Name = "lbl48"
        lbl48.Size = New System.Drawing.Size(64, 13)
        lbl48.TabIndex = 1
        lbl48.Text = "New Size"
        lbl48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl64
        '
        lbl64.ForeColor = System.Drawing.Color.Lime
        lbl64.Location = New System.Drawing.Point(3, 84)
        lbl64.Name = "lbl64"
        lbl64.Size = New System.Drawing.Size(64, 13)
        lbl64.TabIndex = 1
        lbl64.Text = "New Size"
        lbl64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label12
        '
        label12.AutoSize = True
        label12.ForeColor = System.Drawing.Color.Lime
        label12.Location = New System.Drawing.Point(283, 0)
        label12.Name = "label12"
        label12.Size = New System.Drawing.Size(45, 13)
        label12.TabIndex = 1
        label12.Text = "16 x 16:"
        '
        'label10
        '
        label10.AutoSize = True
        label10.ForeColor = System.Drawing.Color.Lime
        label10.Location = New System.Drawing.Point(213, 0)
        label10.Name = "label10"
        label10.Size = New System.Drawing.Size(45, 13)
        label10.TabIndex = 1
        label10.Text = "24 x 24:"
        '
        'label8
        '
        label8.AutoSize = True
        label8.ForeColor = System.Drawing.Color.Lime
        label8.Location = New System.Drawing.Point(143, 0)
        label8.Name = "label8"
        label8.Size = New System.Drawing.Size(45, 13)
        label8.TabIndex = 1
        label8.Text = "32 x 32:"
        '
        'label6
        '
        label6.AutoSize = True
        label6.ForeColor = System.Drawing.Color.Lime
        label6.Location = New System.Drawing.Point(73, 0)
        label6.Name = "label6"
        label6.Size = New System.Drawing.Size(45, 13)
        label6.TabIndex = 1
        label6.Text = "48 x 48:"
        '
        'label4
        '
        label4.AutoSize = True
        label4.ForeColor = System.Drawing.Color.Lime
        label4.Location = New System.Drawing.Point(3, 0)
        label4.Name = "label4"
        label4.Size = New System.Drawing.Size(45, 13)
        label4.TabIndex = 1
        label4.Text = "64 x 64:"
        '
        'pic16
        '
        pic16.BackColor = System.Drawing.Color.Black
        pic16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pic16.Location = New System.Drawing.Point(283, 17)
        pic16.Name = "pic16"
        pic16.Size = New System.Drawing.Size(64, 64)
        pic16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        pic16.TabIndex = 0
        pic16.TabStop = False
        '
        'pic24
        '
        pic24.BackColor = System.Drawing.Color.Black
        pic24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pic24.Location = New System.Drawing.Point(213, 17)
        pic24.Name = "pic24"
        pic24.Size = New System.Drawing.Size(64, 64)
        pic24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        pic24.TabIndex = 0
        pic24.TabStop = False
        '
        'pic32
        '
        pic32.BackColor = System.Drawing.Color.Black
        pic32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pic32.Location = New System.Drawing.Point(143, 17)
        pic32.Name = "pic32"
        pic32.Size = New System.Drawing.Size(64, 64)
        pic32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        pic32.TabIndex = 0
        pic32.TabStop = False
        '
        'pic48
        '
        pic48.BackColor = System.Drawing.Color.Black
        pic48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pic48.Location = New System.Drawing.Point(73, 17)
        pic48.Name = "pic48"
        pic48.Size = New System.Drawing.Size(64, 64)
        pic48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        pic48.TabIndex = 0
        pic48.TabStop = False
        '
        'pic64
        '
        pic64.BackColor = System.Drawing.Color.Black
        pic64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        pic64.Location = New System.Drawing.Point(3, 17)
        pic64.Name = "pic64"
        pic64.Size = New System.Drawing.Size(64, 64)
        pic64.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        pic64.TabIndex = 0
        pic64.TabStop = False
        '
        'label3
        '
        label3.AutoSize = True
        label3.BackColor = System.Drawing.Color.Black
        label3.ForeColor = System.Drawing.Color.Lime
        label3.Location = New System.Drawing.Point(218, 25)
        label3.Name = "label3"
        label3.Size = New System.Drawing.Size(74, 13)
        label3.TabIndex = 0
        label3.Text = "Best Fit Icons:"
        '
        'cntxtIconList
        '
        cntxtIconList.Items.AddRange(New System.Windows.Forms.ToolStripItem() {mnuIconListSaveAs, mnuIconListMerge, toolStripMenuItem3, mmnuIconListView, toolStripMenuItem1, mnuIconListProperties})
        cntxtIconList.Name = "cntxtIconList"
        cntxtIconList.Size = New System.Drawing.Size(220, 104)
        '
        'mnuIconListSaveAs
        '
        mnuIconListSaveAs.Name = "mnuIconListSaveAs"
        mnuIconListSaveAs.Size = New System.Drawing.Size(219, 22)
        mnuIconListSaveAs.Text = "&Save To Custom Command"
        '
        'mnuIconListMerge
        '
        mnuIconListMerge.Name = "mnuIconListMerge"
        mnuIconListMerge.Size = New System.Drawing.Size(219, 22)
        mnuIconListMerge.Text = "Merge"
        '
        'toolStripMenuItem3
        '
        toolStripMenuItem3.Name = "toolStripMenuItem3"
        toolStripMenuItem3.Size = New System.Drawing.Size(216, 6)
        '
        'mmnuIconListView
        '
        mmnuIconListView.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {mnuIconListView16, mnuIconListView24, mnuIconListView32, mnuIconListView48, mnuIconListView64, mnuIconListView96})
        mmnuIconListView.Name = "mmnuIconListView"
        mmnuIconListView.Size = New System.Drawing.Size(219, 22)
        mmnuIconListView.Text = "&View"
        '
        'mnuIconListView16
        '
        mnuIconListView16.Name = "mnuIconListView16"
        mnuIconListView16.Size = New System.Drawing.Size(109, 22)
        mnuIconListView16.Text = "16 x 16"
        '
        'mnuIconListView24
        '
        mnuIconListView24.Name = "mnuIconListView24"
        mnuIconListView24.Size = New System.Drawing.Size(109, 22)
        mnuIconListView24.Text = "24 x 24"
        '
        'mnuIconListView32
        '
        mnuIconListView32.Name = "mnuIconListView32"
        mnuIconListView32.Size = New System.Drawing.Size(109, 22)
        mnuIconListView32.Text = "32 x 32"
        '
        'mnuIconListView48
        '
        mnuIconListView48.Name = "mnuIconListView48"
        mnuIconListView48.Size = New System.Drawing.Size(109, 22)
        mnuIconListView48.Text = "48 x 48"
        '
        'mnuIconListView64
        '
        mnuIconListView64.Name = "mnuIconListView64"
        mnuIconListView64.Size = New System.Drawing.Size(109, 22)
        mnuIconListView64.Text = "64 x 64"
        '
        'mnuIconListView96
        '
        mnuIconListView96.Name = "mnuIconListView96"
        mnuIconListView96.Size = New System.Drawing.Size(109, 22)
        mnuIconListView96.Text = "96 x 96"
        '
        'toolStripMenuItem1
        '
        toolStripMenuItem1.Name = "toolStripMenuItem1"
        toolStripMenuItem1.Size = New System.Drawing.Size(216, 6)
        '
        'mnuIconListProperties
        '
        mnuIconListProperties.Name = "mnuIconListProperties"
        mnuIconListProperties.Size = New System.Drawing.Size(219, 22)
        mnuIconListProperties.Text = "P&roperties"
        '
        'tlbarMain
        '
        tlbarMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {tlbarMainOpen, ToolStripButton1, toolStripSeparator1})
        tlbarMain.Location = New System.Drawing.Point(0, 0)
        tlbarMain.Name = "tlbarMain"
        tlbarMain.ShowItemToolTips = False
        tlbarMain.Size = New System.Drawing.Size(581, 25)
        tlbarMain.TabIndex = 8
        tlbarMain.Text = "toolStrip1"
        mcttMain.SetToolTip(tlbarMain, "Click Save Button To Set Selected Icon In Tree View For BlackShellRunner Custom C" &
        "ommand")
        '
        'tlbarMainOpen
        '
        tlbarMainOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        tlbarMainOpen.Image = CType(resources.GetObject("tlbarMainOpen.Image"), System.Drawing.Image)
        tlbarMainOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        tlbarMainOpen.Name = "tlbarMainOpen"
        tlbarMainOpen.Size = New System.Drawing.Size(23, 22)
        tlbarMainOpen.Text = "&Open"
        '
        'ToolStripButton1
        '
        ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        '
        'toolStripSeparator1
        '
        toolStripSeparator1.Name = "toolStripSeparator1"
        toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'mcttMain
        '
        mcttMain.BackColor = System.Drawing.Color.Black
        mcttMain.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold)
        mcttMain.ForeColor = System.Drawing.Color.Lime
        mcttMain.OwnerDraw = True
        mcttMain.UseAnimation = False
        mcttMain.UseTransparentFading = True
        '
        'IconList
        '
        IconList.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        IconList.BackColor = System.Drawing.Color.Black
        IconList.Location = New System.Drawing.Point(115, 48)
        IconList.Name = "IconList"
        IconList.OwnerDraw = True
        IconList.Size = New System.Drawing.Size(67, 62)
        IconList.TabIndex = 9
        IconList.TileSize = New System.Drawing.Size(0, 0)
        IconList.UseCompatibleStateImageBehavior = False
        IconList.View = System.Windows.Forms.View.Tile
        '
        'frmIconList
        '
        AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        BackColor = System.Drawing.Color.Black
        ClientSize = New System.Drawing.Size(581, 156)
        Controls.Add(panel1)
        Controls.Add(tlbarMain)
        Controls.Add(label3)
        Controls.Add(label2)
        Controls.Add(treeIcons)
        Controls.Add(IconList)
        ForeColor = System.Drawing.Color.Lime
        Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Name = "frmIconList"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Jack The Icon Ripper"
        cntxtTree.ResumeLayout(False)
        panel1.ResumeLayout(False)
        panel1.PerformLayout()
        CType(pic16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(pic24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(pic32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(pic48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(pic64, System.ComponentModel.ISupportInitialize).EndInit()
        cntxtIconList.ResumeLayout(False)
        tlbarMain.ResumeLayout(False)
        tlbarMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

#End Region

    Protected ilTree As System.Windows.Forms.ImageList
    Protected diagSelectLibrary As System.Windows.Forms.OpenFileDialog
    Protected WithEvents cntxtIconList As System.Windows.Forms.ContextMenuStrip
    Protected WithEvents mnuIconListSaveAs As System.Windows.Forms.ToolStripMenuItem
    Protected mmnuIconListView As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents mnuIconListView16 As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents mnuIconListView24 As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents mnuIconListView32 As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents mnuIconListView48 As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents mnuIconListView64 As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents mnuIconListView96 As System.Windows.Forms.ToolStripMenuItem
    Protected toolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Protected WithEvents mnuIconListProperties As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents cntxtTree As System.Windows.Forms.ContextMenuStrip
    Protected WithEvents mnuTreeSaveAs As System.Windows.Forms.ToolStripMenuItem
    Protected toolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Protected WithEvents mnuTreeProperties As System.Windows.Forms.ToolStripMenuItem
    Protected WithEvents mnuIconListMerge As System.Windows.Forms.ToolStripMenuItem
    Protected toolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Protected toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Public WithEvents treeIcons As System.Windows.Forms.TreeView
    Public WithEvents label2 As System.Windows.Forms.Label
    Public WithEvents panel1 As System.Windows.Forms.Panel
    Public WithEvents label3 As System.Windows.Forms.Label
    Public WithEvents lbl64 As System.Windows.Forms.Label
    Public WithEvents label4 As System.Windows.Forms.Label
    Public WithEvents lbl16 As System.Windows.Forms.Label
    Public WithEvents lbl24 As System.Windows.Forms.Label
    Public WithEvents lbl32 As System.Windows.Forms.Label
    Public WithEvents lbl48 As System.Windows.Forms.Label
    Public WithEvents label12 As System.Windows.Forms.Label
    Public WithEvents label10 As System.Windows.Forms.Label
    Public WithEvents label8 As System.Windows.Forms.Label
    Public WithEvents label6 As System.Windows.Forms.Label
    Public WithEvents tlbarMain As System.Windows.Forms.ToolStrip
    Public WithEvents pic64 As System.Windows.Forms.PictureBox
    Public WithEvents pic16 As System.Windows.Forms.PictureBox
    Public WithEvents pic24 As System.Windows.Forms.PictureBox
    Public WithEvents pic32 As System.Windows.Forms.PictureBox
    Public WithEvents pic48 As System.Windows.Forms.PictureBox
    Protected Friend WithEvents mcttMain As AcidControls.AcidToolTip
    Public WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Public WithEvents tlbarMainOpen As System.Windows.Forms.ToolStripButton
    Private components As ComponentModel.IContainer
    Friend WithEvents IconList As TAFactory.IconPack.IconListView
End Class