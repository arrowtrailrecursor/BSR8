Imports System.Runtime.InteropServices
Imports WORD = System.Int16
Imports DWORD = System.Int32

Namespace TAFactory.IconPack
    ''' <summary>
    ''' Presents an Icon Directory.
    ''' </summary>
    <StructLayout(LayoutKind.Sequential, Size:=6)> _
    Public Structure IconDir
        Public Reserved As WORD ' Reserved (must be 0)
        Public Type As WORD ' Resource Type (1 for icons)
        Public Count As WORD ' How many images?

        ''' <summary>
        ''' Converts the current TAFactory.IconPack.IconDir into TAFactory.IconPack.GroupIconDir.
        ''' </summary>
        ''' <returns>TAFactory.IconPack.GroupIconDir</returns>
        Public Function ToGroupIconDir() As GroupIconDir
            Dim grpDir As New GroupIconDir()
            grpDir.Reserved = Reserved
            grpDir.Type = Type
            grpDir.Count = Count
            Return grpDir
        End Function
    End Structure

    ''' <summary>
    ''' Presents an Icon Directory Entry.
    ''' </summary>
    <StructLayout(LayoutKind.Sequential, Size:=16)>
    Public Structure IconDirEntry
        Public Width As Byte ' Width, in pixels, of the image
        Public Height As Byte ' Height, in pixels, of the image
        Public ColorCount As Byte ' Number of colors in image (0 if >=8bpp)
        Public Reserved As Byte ' Reserved ( must be 0)
        Public Planes As WORD ' Color Planes
        Public BitCount As WORD ' Bits per pixel
        Public BytesInRes As DWORD ' How many bytes in this resource?
        Public ImageOffset As DWORD ' Where in the file is this image?

        ''' <summary>
        ''' Converts the current TAFactory.IconPack.IconDirEntry into TAFactory.IconPack.GroupIconDirEntry.
        ''' </summary>
        ''' <param name="id">The resource identifier.</param>
        ''' <returns>TAFactory.IconPack.GroupIconDirEntry</returns>
        Public Function ToGroupIconDirEntry(ByVal id As Integer) As GroupIconDirEntry
            Dim grpEntry As New GroupIconDirEntry()
            grpEntry.Width = Width
            grpEntry.Height = Height
            grpEntry.ColorCount = ColorCount
            grpEntry.Reserved = Reserved
            grpEntry.Planes = Planes
            grpEntry.BitCount = BitCount
            grpEntry.BytesInRes = BytesInRes
            grpEntry.ID = CShort(Fix(id))
            Return grpEntry
        End Function
    End Structure

    ''' <summary>
    ''' Presents a Group Icon Directory.
    ''' </summary>
    <StructLayout(LayoutKind.Sequential, Size:=6)>
    Public Structure GroupIconDir
        Public Reserved As WORD ' Reserved (must be 0)
        Public Type As WORD ' Resource Type (1 for icons)
        Public Count As WORD ' How many images?

        ''' <summary>
        ''' Converts the current TAFactory.IconPack.GroupIconDir into TAFactory.IconPack.IconDir.
        ''' </summary>
        ''' <returns>TAFactory.IconPack.IconDir</returns>
        Public Function ToIconDir() As IconDir
            Dim dir As New IconDir()
            dir.Reserved = Reserved
            dir.Type = Type
            dir.Count = Count
            Return dir
        End Function
    End Structure

    ''' <summary>
    ''' Presents a Group Icon Directory Entry.
    ''' </summary>
    <StructLayout(LayoutKind.Sequential, Size:=14)>
    Public Structure GroupIconDirEntry
        Public Width As Byte ' Width, in pixels, of the image
        Public Height As Byte ' Height, in pixels, of the image
        Public ColorCount As Byte ' Number of colors in image (0 if >=8bpp)
        Public Reserved As Byte ' Reserved ( must be 0)
        Public Planes As WORD ' Color Planes
        Public BitCount As WORD ' Bits per pixel
        Public BytesInRes As DWORD ' How many bytes in this resource?
        Public ID As WORD ' the ID

        Public Function ToIconDirEntry(ByVal imageOffiset As Integer) As IconDirEntry
            Dim entry As New IconDirEntry()
            entry.Width = Width
            entry.Height = Height
            entry.ColorCount = ColorCount
            entry.Reserved = Reserved
            entry.Planes = Planes
            entry.BitCount = BitCount
            entry.BytesInRes = BytesInRes
            entry.ImageOffset = imageOffiset
            Return entry
        End Function
    End Structure
End Namespace