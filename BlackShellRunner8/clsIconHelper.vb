Imports System.Runtime.InteropServices
Imports System.IO
Imports BSR.Microsoft.API
Imports BSR.TAFactory.Utilities

Namespace TAFactory.IconPack
#Region "Enumuration"
    '[Flags]
    Public Enum IconFlags As Integer
        Icon = &H100 ' get icon
        LinkOverlay = &H8000 ' put a link overlay on icon
        Selected = &H10000 ' show icon in selected state
        LargeIcon = &H0 ' get large icon
        SmallIcon = &H1 ' get small icon
        OpenIcon = &H2 ' get open icon
        ShellIconSize = &H4 ' get shell size icon
    End Enum
#End Region

    Public NotInheritable Class IconHelper
#Region "Public Methods"

        Private Sub New()
        End Sub
        Public Shared Function GetIconInfo(ByVal icon As Icon) As IconInfo
            Return New IconInfo(icon)
        End Function

        Public Shared Function GetIconInfo(ByVal fileName As String) As IconInfo
            Return New IconInfo(fileName)
        End Function

        Public Shared Function ExtractIcon(ByVal fileName As String, ByVal iconIndex As Integer) As Icon
            Dim icon As Icon = Nothing
            'Try to load the file as icon file.
            Try
                icon = New Icon(Environment.ExpandEnvironmentVariables(fileName))
            Catch
            End Try

            If icon IsNot Nothing Then 'The file was an icon file, return the icon.
                Return icon
            End If

            'Load the file as an executable module.
            Using extractor As New IconExtractor(fileName)
                Return extractor.GetIconAt(iconIndex)
            End Using
        End Function
        ''' <summary>
        ''' Extracts all the icons from a givin icon file or an executable module (.dll or an .exe file).
        ''' </summary>
        ''' <param name="fileName">The path of the icon file or the executable module.</param>
        ''' <returns>
        ''' A list of System.Drawing.Icon found in the file.
        ''' If the file was an icon file, it will return a list containing a single icon.
        ''' </returns>
        Public Shared Function ExtractAllIcons(ByVal fileName As String) As List(Of Icon)
            Dim icon As Icon = Nothing
            Dim list As List(Of Icon) = New List(Of Icon)()
            'Try to load the file as icon file.
            Try
                icon = New Icon(Environment.ExpandEnvironmentVariables(fileName))
            Catch
            End Try

            If icon IsNot Nothing Then 'The file was an icon file.
                list.Add(icon)
                Return list
            End If

            'Load the file as an executable module.
            Using extractor As New IconExtractor(fileName)
                For i As Integer = 0 To extractor.IconCount - 1
                    list.Add(extractor.GetIconAt(i))
                Next i
            End Using
            Return list
        End Function

        ''' <summary>
        ''' Splits the group icon into a list of icons (the single icon file can contain a set of icons).
        ''' </summary>
        ''' <param name="icon">The System.Drawing.Icon need to be splitted.</param>
        ''' <returns>List of System.Drawing.Icon.</returns>
        Public Shared Function SplitGroupIcon(ByVal icon As Icon) As List(Of Icon)
            Dim info As New IconInfo(icon)
            Return info.Images
        End Function

        ''' <summary>
        ''' Gets the System.Drawing.Icon that best fits the current display device.
        ''' </summary>
        ''' <param name="icon">System.Drawing.Icon to be searched.</param>
        ''' <returns>System.Drawing.Icon that best fit the current display device.</returns>
        Public Shared Function GetBestFitIcon(ByVal icon As Icon) As Icon
            Dim info As New IconInfo(icon)
            Dim index As Integer = info.GetBestFitIconIndex()
            Return info.Images(index)
        End Function
        ''' <summary>
        ''' Gets the System.Drawing.Icon that best fits the current display device.
        ''' </summary>
        ''' <param name="icon">System.Drawing.Icon to be searched.</param>
        ''' <param name="desiredSize">Specifies the desired size of the icon.</param>
        ''' <returns>System.Drawing.Icon that best fit the current display device.</returns>
        Public Shared Function GetBestFitIcon(ByVal icon As Icon, ByVal desiredSize As Size) As Icon
            Dim info As New IconInfo(icon)
            Dim index As Integer = info.GetBestFitIconIndex(desiredSize)
            Return info.Images(index)
        End Function
        ''' <summary>
        ''' Gets the System.Drawing.Icon that best fits the current display device.
        ''' </summary>
        ''' <param name="icon">System.Drawing.Icon to be searched.</param>
        ''' <param name="desiredSize">Specifies the desired size of the icon.</param>
        ''' <param name="isMonochrome">Specifies whether to get the monochrome icon or the colored one.</param>
        ''' <returns>System.Drawing.Icon that best fit the current display device.</returns>
        Public Shared Function GetBestFitIcon(ByVal icon As Icon, ByVal desiredSize As Size, ByVal isMonochrome As Boolean) As Icon
            Dim info As New IconInfo(icon)
            Dim index As Integer = info.GetBestFitIconIndex(desiredSize, isMonochrome)
            Return info.Images(index)
        End Function

        ''' <summary>
        ''' Extracts an icon (that best fits the current display device) from a givin icon file or an executable module (.dll or an .exe file).
        ''' </summary>
        ''' <param name="fileName">The path of the icon file or the executable module.</param>
        ''' <param name="iconIndex">The index of the icon in the executable module.</param>
        ''' <returns>A System.Drawing.Icon (that best fits the current display device) extracted from the file at the specified index in case of an executable module.</returns>
        Public Shared Function ExtractBestFitIcon(ByVal fileName As String, ByVal iconIndex As Integer) As Icon
            Dim icon As Icon = ExtractIcon(fileName, iconIndex)
            Return GetBestFitIcon(icon)
        End Function
        ''' <summary>
        ''' Extracts an icon (that best fits the current display device) from a givin icon file or an executable module (.dll or an .exe file).
        ''' </summary>
        ''' <param name="fileName">The path of the icon file or the executable module.</param>
        ''' <param name="iconIndex">The index of the icon in the executable module.</param>
        ''' <param name="desiredSize">Specifies the desired size of the icon.</param>
        ''' <returns>A System.Drawing.Icon (that best fits the current display device) extracted from the file at the specified index in case of an executable module.</returns>
        Public Shared Function ExtractBestFitIcon(ByVal fileName As String, ByVal iconIndex As Integer, ByVal desiredSize As Size) As Icon
            Dim icon As Icon = ExtractIcon(fileName, iconIndex)
            Return GetBestFitIcon(icon, desiredSize)
        End Function
        ''' <summary>
        ''' Extracts an icon (that best fits the current display device) from a givin icon file or an executable module (.dll or an .exe file).
        ''' </summary>
        ''' <param name="fileName">The path of the icon file or the executable module.</param>
        ''' <param name="iconIndex">The index of the icon in the executable module.</param>
        ''' <param name="desiredSize">Specifies the desired size of the icon.</param>
        ''' <param name="isMonochrome">Specifies whether to get the monochrome icon or the colored one.</param>
        ''' <returns>A System.Drawing.Icon (that best fits the current display device) extracted from the file at the specified index in case of an executable module.</returns>
        Public Shared Function ExtractBestFitIcon(ByVal fileName As String, ByVal iconIndex As Integer, ByVal desiredSize As Size, ByVal isMonochrome As Boolean) As Icon
            Dim icon As Icon = ExtractIcon(fileName, iconIndex)
            Return GetBestFitIcon(icon, desiredSize, isMonochrome)
        End Function

        ''' <summary>
        ''' Gets icon associated with the givin file.
        ''' </summary>
        ''' <param name="fileName">The file path (both absolute and relative paths are valid).</param>
        ''' <param name="flags">Specifies which icon to be retrieved (Larg, Small, Selected, Link Overlay and Shell Size).</param>
        ''' <returns>A System.Drawing.Icon associated with the givin file.</returns>
        Public Shared Function GetAssociatedIcon(ByVal fileName As String, ByVal flags As IconFlags) As Icon
            flags = flags Or IconFlags.Icon
            Dim fileInfo As New SHFILEINFO()
            Dim result As IntPtr = Win32.SHGetFileInfo(fileName, 0, fileInfo, CUInt(Marshal.SizeOf(fileInfo)), CType(flags, SHGetFileInfoFlags))

            If fileInfo.hIcon = IntPtr.Zero Then
                Return Nothing
            End If

            Return Icon.FromHandle(fileInfo.hIcon)
        End Function
        ''' <summary>
        ''' Gets large icon associated with the givin file.
        ''' </summary>
        ''' <param name="fileName">The file path (both absolute and relative paths are valid).</param>
        ''' <returns>A System.Drawing.Icon associated with the givin file.</returns>
        Public Shared Function GetAssociatedLargeIcon(ByVal fileName As String) As Icon
            Return GetAssociatedIcon(fileName, IconFlags.LargeIcon)
        End Function
        ''' <summary>
        ''' Gets small icon associated with the givin file.
        ''' </summary>
        ''' <param name="fileName">The file path (both absolute and relative paths are valid).</param>
        ''' <returns>A System.Drawing.Icon associated with the givin file.</returns>
        Public Shared Function GetAssociatedSmallIcon(ByVal fileName As String) As Icon
            Return GetAssociatedIcon(fileName, IconFlags.SmallIcon)
        End Function

        ''' <summary>
        ''' Merges a list of icons into one single icon.
        ''' </summary>
        ''' <param name="icons">The icons to be merged.</param>
        ''' <returns>System.Drawing.Icon that contains all the images of the givin icons.</returns>
        Public Shared Function Merge(ByVal ParamArray icons() As Icon) As Icon
            Dim list As List(Of IconInfo) = New List(Of IconInfo)(icons.Length)
            Dim numImages As Integer = 0
            For Each icon As Icon In icons
                If icon IsNot Nothing Then
                    Dim info As New IconInfo(icon)
                    list.Add(info)
                    numImages += info.Images.Count
                End If
            Next icon
            If list.Count = 0 Then
                Throw New ArgumentNullException("icons", "The icons list should contain at least one icon.")
            End If

            'Write the icon to a stream.
            Dim outputStream As New MemoryStream()
            Dim imageIndex As Integer = 0
            Dim imageOffset As Integer = IconInfo.SizeOfIconDir + numImages * IconInfo.SizeOfIconDirEntry
            For i As Integer = 0 To list.Count - 1
                Dim iconInfo As IconInfo = list(i)
                'The firs image, we should write the icon header.
                If i = 0 Then
                    'Get the IconDir and update image count with the new count.
                    Dim dir As IconDir = iconInfo.IconDir
                    dir.Count = CShort(Fix(numImages))

                    'Write the IconDir header.
                    outputStream.Seek(0, SeekOrigin.Begin)
                    Utility.WriteStructure(Of IconDir)(outputStream, dir)
                End If
                'For each image in the current icon, we should write the IconDirEntry and the image raw data.
                For j As Integer = 0 To iconInfo.Images.Count - 1
                    'Get the IconDirEntry and update the ImageOffset to the new offset.
                    Dim entry As IconDirEntry = iconInfo.IconDirEntries(j)
                    entry.ImageOffset = imageOffset

                    'Write the IconDirEntry to the stream.
                    outputStream.Seek(iconInfo.SizeOfIconDir + imageIndex * iconInfo.SizeOfIconDirEntry, SeekOrigin.Begin)
                    Utility.WriteStructure(Of IconDirEntry)(outputStream, entry)

                    'Write the image raw data.
                    outputStream.Seek(imageOffset, SeekOrigin.Begin)
                    outputStream.Write(iconInfo.RawData(j), 0, entry.BytesInRes)

                    'Update the imageIndex and the imageOffset
                    imageIndex += 1
                    imageOffset += entry.BytesInRes
                Next j
            Next i

            'Create the icon from the stream.
            outputStream.Seek(0, SeekOrigin.Begin)
            Dim resultIcon As New Icon(outputStream)
            outputStream.Close()

            Return resultIcon
        End Function
#End Region
    End Class
End Namespace