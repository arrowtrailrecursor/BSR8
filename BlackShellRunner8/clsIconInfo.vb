Imports System.IO
Imports System.Runtime.InteropServices
Imports BSR.Microsoft.API
Imports BSR.TAFactory.Utilities

Namespace TAFactory.IconPack
    ''' <summary>
    ''' Provides information about a givin icon.
    ''' This class cannot be inherited.
    ''' </summary>
    <Serializable()> _
    Public Class IconInfo
#Region "ReadOnly"
        Public Shared SizeOfIconDir As Integer = Marshal.SizeOf(GetType(IconDir))
        Public Shared SizeOfIconDirEntry As Integer = Marshal.SizeOf(GetType(IconDirEntry))
        Public Shared SizeOfGroupIconDir As Integer = Marshal.SizeOf(GetType(GroupIconDir))
        Public Shared SizeOfGroupIconDirEntry As Integer = Marshal.SizeOf(GetType(GroupIconDirEntry))
#End Region

#Region "Properties"
        Protected _sourceIcon As Icon
        ''' <summary>
        ''' Gets the source System.Drawing.Icon.
        ''' </summary>
        Public Property SourceIcon() As Icon
            Get
                Return _sourceIcon
            End Get
            Protected Set(ByVal value As Icon)
                _sourceIcon = value
            End Set
        End Property

        Protected _fileName As String = Nothing
        ''' <summary>
        ''' Gets the icon's file name.
        ''' </summary>
        Public Property FileName() As String
            Get
                Return _fileName
            End Get
            Protected Set(ByVal value As String)
                _fileName = value
            End Set
        End Property

        Protected _images As List(Of Icon)
        ''' <summary>
        ''' Gets a list System.Drawing.Icon that presents the icon contained images.
        ''' </summary>
        Public Property Images() As List(Of Icon)
            Get
                Return _images
            End Get
            Protected Set(ByVal value As List(Of Icon))
                _images = value
            End Set
        End Property

        ''' <summary>
        ''' Get whether the icon contain more than one image or not.
        ''' </summary>
        Public ReadOnly Property IsMultiIcon() As Boolean
            Get
                Return (Images.Count > 1)
            End Get
        End Property

        Protected _bestFitIconIndex As Integer
        ''' <summary>
        ''' Gets icon index that best fits to screen resolution.
        ''' </summary>
        Public Property BestFitIconIndex() As Integer
            Get
                Return _bestFitIconIndex
            End Get
            Protected Set(ByVal value As Integer)
                _bestFitIconIndex = value
            End Set
        End Property

        Protected _width As Integer
        ''' <summary>
        ''' Gets icon width.
        ''' </summary>
        Public Property Width() As Integer
            Get
                Return _width
            End Get
            Protected Set(ByVal value As Integer)
                _width = value
            End Set
        End Property

        Protected _height As Integer
        ''' <summary>
        ''' Gets icon height.
        ''' </summary>
        Public Property Height() As Integer
            Get
                Return _height
            End Get
            Protected Set(ByVal value As Integer)
                _height = value
            End Set
        End Property

        Protected _colorCount As Integer
        ''' <summary>
        ''' Gets number of colors in icon (0 if >=8bpp).
        ''' </summary>
        Public Property ColorCount() As Integer
            Get
                Return _colorCount
            End Get
            Protected Set(ByVal value As Integer)
                _colorCount = value
            End Set
        End Property

        Protected _planes As Integer
        ''' <summary>
        ''' Gets icon color planes.
        ''' </summary>
        Public Property Planes() As Integer
            Get
                Return _planes
            End Get
            Protected Set(ByVal value As Integer)
                _planes = value
            End Set
        End Property

        Protected _bitCount As Integer

        Public Property BitCount() As Integer
            Get
                Return _bitCount
            End Get
            Protected Set(ByVal value As Integer)
                _bitCount = value
            End Set
        End Property

        ''' <summary>
        ''' Gets icon bits per pixel.
        ''' </summary>
        Public ReadOnly Property ColorDepth() As Integer
            Get
                If BitCount <> 0 Then
                    Return BitCount
                End If
                If ColorCount = 0 Then
                    Return 0
                End If
                Return CInt(Fix(Math.Log(ColorCount, 2)))
            End Get
        End Property
#End Region

#Region "Icon Headers Properties"
        Protected _iconDir As IconDir
        ''' <summary>
        ''' Gets the TAFactory.IconPack.IconDir of the icon.
        ''' </summary>
        Public Property IconDir() As IconDir
            Get
                Return _iconDir
            End Get
            Protected Set(ByVal value As IconDir)
                _iconDir = value
            End Set
        End Property

        Protected _groupIconDir As GroupIconDir
        ''' <summary>
        ''' Gets the TAFactory.IconPack.GroupIconDir of the icon.
        ''' </summary>
        Public Property GroupIconDir() As GroupIconDir
            Get
                Return _groupIconDir
            End Get
            Protected Set(ByVal value As GroupIconDir)
                _groupIconDir = value
            End Set
        End Property

        Protected _iconDirEntries As List(Of IconDirEntry)
        ''' <summary>
        ''' Gets a list of TAFactory.IconPack.IconDirEntry of the icon.
        ''' </summary>
        Public Property IconDirEntries() As List(Of IconDirEntry)
            Get
                Return _iconDirEntries
            End Get
            Protected Set(ByVal value As List(Of IconDirEntry))
                _iconDirEntries = value
            End Set
        End Property

        Protected _groupIconDirEntries As List(Of GroupIconDirEntry)
        ''' <summary>
        ''' Gets a list of TAFactory.IconPack.GroupIconDirEntry of the icon.
        ''' </summary>
        Public Property GroupIconDirEntries() As List(Of GroupIconDirEntry)
            Get
                Return _groupIconDirEntries
            End Get
            Protected Set(ByVal value As List(Of GroupIconDirEntry))
                _groupIconDirEntries = value
            End Set
        End Property

        Protected _rawData As List(Of Byte())
        ''' <summary>
        ''' Gets a list of raw data for each icon image.
        ''' </summary>
        Public Property RawData() As List(Of Byte())
            Get
                Return _rawData
            End Get
            Protected Set(ByVal value As List(Of Byte()))
                _rawData = value
            End Set
        End Property

        Protected _resourceRawData() As Byte
        ''' <summary>
        ''' Gets the icon raw data as a resource data.
        ''' </summary>
        Public Property ResourceRawData() As Byte()
            Get
                Return _resourceRawData
            End Get
            Set(ByVal value As Byte())
                _resourceRawData = value
            End Set
        End Property
#End Region

#Region "Constructors"
        ''' <summary>
        ''' Intializes a new instance of TAFactory.IconPack.IconInfo which contains the information about the givin icon.
        ''' </summary>
        ''' <param name="icon">A System.Drawing.Icon object to retrieve the information about.</param>
        Public Sub New(ByVal icon As Icon)
            FileName = Nothing
            LoadIconInfo(icon)
        End Sub

        ''' <summary>
        ''' Intializes a new instance of TAFactory.IconPack.IconInfo which contains the information about the icon in the givin file.
        ''' </summary>
        ''' <param name="fileName">A fully qualified name of the icon file, it can contain environment variables.</param>
        Public Sub New(ByVal fileName As String)
            fileName = fileName
            LoadIconInfo(New Icon(fileName))
        End Sub
#End Region

#Region "Public Methods"
        ''' <summary>
        ''' Gets the index of the icon that best fits the current display device.
        ''' </summary>
        ''' <returns>The icon index.</returns>
        Public Function GetBestFitIconIndex() As Integer
            Dim iconIndex As Integer = 0
            Dim resBits As IntPtr = Marshal.AllocHGlobal(ResourceRawData.Length)
            Marshal.Copy(ResourceRawData, 0, resBits, ResourceRawData.Length)
            Try
                iconIndex = Win32.LookupIconIdFromDirectory(resBits, True)
            Finally
                Marshal.FreeHGlobal(resBits)
            End Try

            Return iconIndex
        End Function
        ''' <summary>
        ''' Gets the index of the icon that best fits the current display device.
        ''' </summary>
        ''' <param name="desiredSize">Specifies the desired size of the icon.</param>
        ''' <returns>The icon index.</returns>
        Public Function GetBestFitIconIndex(ByVal desiredSize As Size) As Integer
            Return GetBestFitIconIndex(desiredSize, False)
        End Function
        ''' <summary>
        ''' Gets the index of the icon that best fits the current display device.
        ''' </summary>
        ''' <param name="desiredSize">Specifies the desired size of the icon.</param>
        ''' <param name="isMonochrome">Specifies whether to get the monochrome icon or the colored one.</param>
        ''' <returns>The icon index.</returns>
        Public Function GetBestFitIconIndex(ByVal desiredSize As Size, ByVal isMonochrome As Boolean) As Integer
            Dim iconIndex As Integer = 0
            Dim flags As LookupIconIdFromDirectoryExFlags = LookupIconIdFromDirectoryExFlags.LR_DEFAULTCOLOR
            If isMonochrome Then
                flags = LookupIconIdFromDirectoryExFlags.LR_MONOCHROME
            End If
            Dim resBits As IntPtr = Marshal.AllocHGlobal(ResourceRawData.Length)
            Marshal.Copy(ResourceRawData, 0, resBits, ResourceRawData.Length)
            Try
                iconIndex = Win32.LookupIconIdFromDirectoryEx(resBits, True, desiredSize.Width, desiredSize.Height, flags)
            Finally
                Marshal.FreeHGlobal(resBits)
            End Try

            Return iconIndex
        End Function
#End Region

#Region "Protected Methods"
        ''' <summary>
        ''' Loads the icon information from the givin icon into class members.
        ''' </summary>
        ''' <param name="icon">A System.Drawing.Icon object to retrieve the information about.</param>
        Private Sub LoadIconInfo(ByVal icon As Icon)
            If icon Is Nothing Then
                Throw New ArgumentNullException("icon")
            End If

            SourceIcon = icon
            Dim inputStream As New MemoryStream()
            SourceIcon.Save(inputStream)

            inputStream.Seek(0, SeekOrigin.Begin)
            Dim dir As IconDir = Utility.ReadStructure(Of IconDir)(inputStream)

            IconDir = dir
            GroupIconDir = dir.ToGroupIconDir()

            Images = New List(Of Icon)(dir.Count)
            IconDirEntries = New List(Of IconDirEntry)(dir.Count)
            GroupIconDirEntries = New List(Of GroupIconDirEntry)(dir.Count)
            RawData = New List(Of Byte())(dir.Count)

            Dim newDir As IconDir = dir
            newDir.Count = 1
            For i As Integer = 0 To dir.Count - 1
                inputStream.Seek(SizeOfIconDir + i * SizeOfIconDirEntry, SeekOrigin.Begin)

                Dim entry As IconDirEntry = Utility.ReadStructure(Of IconDirEntry)(inputStream)

                IconDirEntries.Add(entry)
                GroupIconDirEntries.Add(entry.ToGroupIconDirEntry(i))

                Dim content(entry.BytesInRes - 1) As Byte
                inputStream.Seek(entry.ImageOffset, SeekOrigin.Begin)
                inputStream.Read(content, 0, content.Length)
                RawData.Add(content)

                Dim newEntry As IconDirEntry = entry
                newEntry.ImageOffset = SizeOfIconDir + SizeOfIconDirEntry

                Dim outputStream As New MemoryStream()
                Utility.WriteStructure(Of IconDir)(outputStream, newDir)
                Utility.WriteStructure(Of IconDirEntry)(outputStream, newEntry)
                outputStream.Write(content, 0, content.Length)

                outputStream.Seek(0, SeekOrigin.Begin)
                Dim newIcon As New Icon(outputStream)
                outputStream.Close()

                Images.Add(newIcon)
                If dir.Count = 1 Then
                    BestFitIconIndex = 0

                    Width = entry.Width
                    Height = entry.Height
                    ColorCount = entry.ColorCount
                    Planes = entry.Planes
                    BitCount = entry.BitCount
                End If
            Next i
            inputStream.Close()
            ResourceRawData = GetIconResourceData()

            If dir.Count > 1 Then
                BestFitIconIndex = GetBestFitIconIndex()

                Width = IconDirEntries(BestFitIconIndex).Width
                Height = IconDirEntries(BestFitIconIndex).Height
                ColorCount = IconDirEntries(BestFitIconIndex).ColorCount
                Planes = IconDirEntries(BestFitIconIndex).Planes
                BitCount = IconDirEntries(BestFitIconIndex).BitCount
            End If

        End Sub
        ''' <summary>
        ''' Returns the icon's raw data as a resource data.
        ''' </summary>
        ''' <returns>The icon's raw as a resource data.</returns>
        Protected Function GetIconResourceData() As Byte()
            Dim outputStream As New MemoryStream()
            Utility.WriteStructure(Of GroupIconDir)(outputStream, GroupIconDir)
            For Each entry As GroupIconDirEntry In GroupIconDirEntries
                Utility.WriteStructure(Of GroupIconDirEntry)(outputStream, entry)
            Next entry

            Return outputStream.ToArray()
        End Function
#End Region
    End Class
End Namespace