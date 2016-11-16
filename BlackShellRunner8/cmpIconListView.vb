Namespace TAFactory.IconPack
    Partial Public Class IconListView
        Inherits ListView
        Protected Const minWidth As Integer = 64
        Protected Const textHeight As Integer = 18
        Protected Const verticalSpacing As Integer = 5
        Public Shared ReadOnly TilePadding As New Padding(5, 1, 5, 1)

        Public Sub New()
            InitializeComponent()
            MyBase.View = View.Tile
            TileSize = MyBase.TileSize
            MyBase.OwnerDraw = True
            AddHandler DrawItem, AddressOf IconListView_DrawItem
        End Sub

        Protected _tileSize As Size
        Public Shadows Property TileSize() As Size
            Get
                Return _tileSize
            End Get
            Set(ByVal value As Size)
                _tileSize = value
                MyBase.BeginUpdate()
                MyBase.TileSize = New Size(Math.Max(minWidth, value.Width) + TilePadding.Horizontal, value.Height + verticalSpacing + textHeight + TilePadding.Vertical)
                If MyBase.Items.Count <> 0 Then
                    Dim list As List(Of IconListViewItem) = New List(Of IconListViewItem)(MyBase.Items.Count)
                    For Each item As IconListViewItem In MyBase.Items
                        list.Add(item)
                    Next item
                    MyBase.Items.Clear()
                    For Each item As IconListViewItem In list
                        MyBase.Items.Add(item)
                    Next item
                    'base.RedrawItems(0, base.Items.Count - 1, false);
                End If

                MyBase.EndUpdate()
            End Set
        End Property

        Private Sub IconListView_DrawItem(ByVal sender As Object, ByVal e As DrawListViewItemEventArgs)
            Dim item As IconListViewItem = TryCast(e.Item, IconListViewItem)
            If item Is Nothing Then
                e.DrawDefault = True
                Return
            End If

            ' Draw item
            e.DrawBackground()
            Dim border As Pen = SystemPens.ControlLight
            If e.Item.Selected Then
                If Focused Then
                    border = SystemPens.Highlight
                Else
                    border = SystemPens.ButtonFace
                End If
            End If
            Dim centerSpacing As Integer = Convert.ToInt16((e.Bounds.Width - TileSize.Width - TilePadding.Horizontal) / 2 + TilePadding.Left)
            Dim newBounds As New Rectangle(e.Bounds.X + centerSpacing, e.Bounds.Y + TilePadding.Top, TileSize.Width, TileSize.Height)
            e.Graphics.DrawRectangle(border, newBounds)

            'e.Graphics.DrawString("Whatever", this.Font, e., 0, 0);
            Dim x As Integer = Convert.ToInt16(e.Bounds.X + (newBounds.Width - item.Icon.Width) / 2 + centerSpacing + 1)
            Dim y As Integer = Convert.ToInt16(e.Bounds.Y + (newBounds.Height - item.Icon.Height) / 2 + TilePadding.Top + 1)
            Dim rect As New Rectangle(x, y, item.Icon.Width, item.Icon.Height)
            Dim clipReg As New Region(newBounds)
            e.Graphics.Clip = clipReg
            e.Graphics.DrawIcon(item.Icon, rect)

            Dim text As String = String.Format("{0} x {1}", item.Icon.Width, item.Icon.Height)
            Dim stringSize As SizeF = e.Graphics.MeasureString(text, Font)
            Dim stringWidth As Integer = CInt(Fix(Math.Round(stringSize.Width)))
            Dim stringHeight As Integer = CInt(Fix(Math.Round(stringSize.Height)))
            x = Convert.ToInt16(e.Bounds.X + (e.Bounds.Width - stringWidth - TilePadding.Horizontal) / 2 + TilePadding.Left)
            y = Convert.ToInt16(e.Bounds.Y + TileSize.Height + verticalSpacing + TilePadding.Top)
            clipReg = New Region(e.Bounds)
            e.Graphics.Clip = clipReg
            If e.Item.Selected Then
                If Focused Then
                    e.Graphics.FillRectangle(New SolidBrush(frmOptions.picShadowColor.BackColor), x - 1, y - 1, stringWidth + 2, stringSize.Height + 2)
                    e.Graphics.DrawString(text, Font, New SolidBrush(frmOptions.picForeColor.BackColor), x, y)
                Else
                    e.Graphics.FillRectangle(New SolidBrush(frmOptions.picShadowColor.BackColor), x - 1, y - 1, stringWidth + 2, stringSize.Height + 2)
                    e.Graphics.DrawString(text, Font, New SolidBrush(frmOptions.picForeColor.BackColor), x, y)
                End If
            Else
                e.Graphics.DrawString(text, Font, New SolidBrush(frmOptions.picForeColor.BackColor), x, y)
            End If
        End Sub
    End Class
    Public Class IconListViewItem
        Inherits ListViewItem
        Protected _icon As Icon
        Public Property Icon() As Icon
            Get
                Return _icon
            End Get
            Set(ByVal value As Icon)
                _icon = value
            End Set
        End Property
    End Class
End Namespace