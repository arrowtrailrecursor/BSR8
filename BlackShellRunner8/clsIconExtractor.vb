Imports System.Runtime.InteropServices
Imports System.IO
Imports System.ComponentModel
Imports BSR.Microsoft.API
Imports BSR.TAFactory.Utilities

Namespace TAFactory.IconPack
    ''' <summary>
    ''' Get icon resources (RT_GROUP_ICON and RT_ICON) from an executable module (either a .dll or an .exe file).
    ''' </summary>
    Public Class IconExtractor
        Implements IDisposable
#Region "Public Propreties"
        Protected _fileName As String
        ''' <summary>
        ''' A fully quallified name of the executable module.
        ''' </summary>
        Public Property FileName() As String
            Get
                Return _fileName
            End Get
            Protected Set(ByVal value As String)
                _fileName = value
            End Set
        End Property

        Protected _moduleHandle As IntPtr
        ''' <summary>
        ''' Gets the module handle.
        ''' </summary>
        Public Property ModuleHandle() As IntPtr
            Get
                Return _moduleHandle
            End Get
            Protected Set(ByVal value As IntPtr)
                _moduleHandle = value
            End Set
        End Property

        Protected _iconNamesList As List(Of ResourceName)
        ''' <summary>
        ''' Gets a list of icons resource names RT_GROUP_ICON;
        ''' </summary>
        Public Property IconNamesList() As List(Of ResourceName)
            Get
                Return _iconNamesList
            End Get
            Protected Set(ByVal value As List(Of ResourceName))
                _iconNamesList = value
            End Set
        End Property

        ''' <summary>
        ''' Gets number of RT_GROUP_ICON found in the executable module.
        ''' </summary>
        Public ReadOnly Property IconCount() As Integer
            Get
                Return IconNamesList.Count
            End Get
        End Property
#End Region

#Region "Protected Properties"
        Protected _iconCache As Dictionary(Of Integer, Icon)
        ''' <summary>
        ''' Gets or sets the RT_GROUP_ICON cache.
        ''' </summary>
        Protected Property IconCache() As Dictionary(Of Integer, Icon)
            Get
                Return _iconCache
            End Get
            Set(ByVal value As Dictionary(Of Integer, Icon))
                _iconCache = value
            End Set
        End Property
#End Region

#Region "Constructor/Destructor"
        ''' <summary>
        ''' Initializes a new IconExtractor and loads the executable module into the address space of the calling process.
        ''' The executable module can be a .dll or an .exe file.
        ''' The specified module can cause other modules to be mapped into the address space.
        ''' </summary>
        ''' <param name="fileName">The name of the executable module (either a .dll or an .exe file). The file name can contain environment variables (like %SystemRoot%).</param>
        Public Sub New(ByVal fileName As String)
            LoadLibrary(fileName)
        End Sub
        ''' <summary>
        ''' Destructs the IconExtractor object.
        ''' </summary>
        Protected Overrides Sub Finalize()
            Dispose()
        End Sub
#End Region

#Region "Public Methods"
        ''' <summary>
        ''' Gets a System.Drawing.Icon that represents RT_GROUP_ICON at the givin index.
        ''' </summary>
        ''' <param name="index">The index of the RT_GROUP_ICON in the executable module.</param>
        ''' <returns>Returns System.Drawing.Icon.</returns>
        Public Function GetIconAt(ByVal index As Integer) As Icon
            If index < 0 OrElse index >= IconCount Then
                If IconCount > 0 Then
                    Throw New ArgumentOutOfRangeException("index", index, "Index should be in the range (0-" & IconCount.ToString() & ").")
                Else
                    Throw New ArgumentOutOfRangeException("index", index, "No icons in the list.")
                End If
            End If

            If (Not IconCache.ContainsKey(index)) Then
                IconCache(index) = GetIconFromLib(index)
            End If

            Return IconCache(index)
        End Function
#End Region

#Region "Protected Methods"
        ''' <summary>
        ''' This function maps a specified executable module into the address space of the calling process.
        ''' The executable module can be a .dll or an .exe file.
        ''' The specified module can cause other modules to be mapped into the address space.
        ''' </summary>
        ''' <param name="fileName">The name of the executable module (either a .dll or an .exe file). The file name can contain environment variables (like %SystemRoot%).</param>
        Protected Sub LoadLibrary(ByVal fileName As String)
            If String.IsNullOrEmpty(fileName) Then
                Throw New ArgumentNullException("fileName")
            End If

            fileName = Environment.ExpandEnvironmentVariables(fileName)
            'Load the executable module into memory using LoadLibraryEx API.
            ModuleHandle = Win32.LoadLibraryEx(Environment.ExpandEnvironmentVariables(fileName), IntPtr.Zero, LoadLibraryExFlags.LOAD_LIBRARY_AS_DATAFILE)
            If ModuleHandle = IntPtr.Zero Then
                Dim errorNum As Integer = Marshal.GetLastWin32Error()
                Select Case CType(errorNum, GetLastErrorResult)
                    Case GetLastErrorResult.ERROR_FILE_NOT_FOUND
                        Throw New FileNotFoundException("File not found.", fileName)
                    Case GetLastErrorResult.ERROR_BAD_EXE_FORMAT
                        Throw New ArgumentException("The file '" & fileName & "' is not a valid win32 executable or dll.")
                    Case Else
                        Throw New Win32Exception(errorNum)
                End Select
            End If

            IconNamesList = New List(Of ResourceName)()
            IconCache = New Dictionary(Of Integer, Icon)()

            'Enumurate the resource names of RT_GROUP_ICON by calling EnumResourcesCallBack function for each resource of that type.
            Win32.EnumResourceNames(ModuleHandle, ResourceTypes.RT_GROUP_ICON, AddressOf EnumResourcesCallBack, IntPtr.Zero)
        End Sub
        ''' <summary>
        ''' The callback function that is being called for each resource (RT_GROUP_ICON, RT_ICON) in the executable module.
        ''' The function stores the resource name of type RT_GROUP_ICON into the GroupIconsList and
        ''' stores the resource name of type RT_ICON into the IconsList.
        ''' </summary>
        ''' <param name="hModule">The module handle.</param>
        ''' <param name="lpszType">Specifies the type of the resource being enumurated (RT_GROUP_ICON, RT_ICON).</param>
        ''' <param name="lpszName">Specifies the name of the resource being enumurated. For more ifnormation, see the Remarks section.</param>
        ''' <param name="lParam">Specifies the application defined parameter passed to the EnumResourceNames function.</param>
        ''' <returns>This callback function return true to continue enumuration.</returns>
        ''' <remarks>
        ''' If the high bit of lpszName is not set (=0), lpszName specifies the integer identifier of the givin resource.
        ''' Otherwise, it is a pointer to a null terminated string.
        ''' If the first character of the string is a pound sign (#), the remaining characters represent a decimal number that specifies the integer identifier of the resource. For example, the string "#258" represents the identifier 258.
        ''' #define IS_INTRESOURCE(_r) ((((ULONG_PTR)(_r)) >> 16) == 0)
        ''' </remarks>
        Protected Function EnumResourcesCallBack(ByVal hModule As IntPtr, ByVal lpszType As ResourceTypes, ByVal lpszName As IntPtr, ByVal lParam As IntPtr) As Boolean
            Select Case lpszType
                Case ResourceTypes.RT_GROUP_ICON
                    IconNamesList.Add(New ResourceName(lpszName))
                Case Else
            End Select

            Return True
        End Function
        ''' <summary>
        ''' Gets a System.Drawing.Icon that represents RT_GROUP_ICON at the givin index from the executable module.
        ''' </summary>
        ''' <param name="index">The index of the RT_GROUP_ICON in the executable module.</param>
        ''' <returns>Returns System.Drawing.Icon.</returns>
        Protected Function GetIconFromLib(ByVal index As Integer) As Icon
            Dim resourceData() As Byte = GetResourceData(ModuleHandle, IconNamesList(index), ResourceTypes.RT_GROUP_ICON)
            'Convert the resouce into an .ICO file image.
            Using inputStream As New MemoryStream(resourceData)
                Using destStream As New MemoryStream()
                    'Read the GroupIconDir header.
                    Dim grpDir As GroupIconDir = Utility.ReadStructure(Of GroupIconDir)(inputStream)

                    Dim numEntries As Integer = grpDir.Count
                    Dim iconImageOffset As Integer = IconInfo.SizeOfIconDir + numEntries * IconInfo.SizeOfIconDirEntry

                    'Write the IconDir header.
                    Utility.WriteStructure(Of IconDir)(destStream, grpDir.ToIconDir())
                    For i As Integer = 0 To numEntries - 1
                        'Read the GroupIconDirEntry.
                        Dim grpEntry As GroupIconDirEntry = Utility.ReadStructure(Of GroupIconDirEntry)(inputStream)

                        'Write the IconDirEntry.
                        destStream.Seek(IconInfo.SizeOfIconDir + i * IconInfo.SizeOfIconDirEntry, SeekOrigin.Begin)
                        Utility.WriteStructure(Of IconDirEntry)(destStream, grpEntry.ToIconDirEntry(iconImageOffset))

                        'Get the icon image raw data and write it to the stream.
                        Dim imgBuf() As Byte = GetResourceData(ModuleHandle, grpEntry.ID, ResourceTypes.RT_ICON)
                        destStream.Seek(iconImageOffset, SeekOrigin.Begin)
                        destStream.Write(imgBuf, 0, imgBuf.Length)

                        'Append the iconImageOffset.
                        iconImageOffset += imgBuf.Length
                    Next i
                    destStream.Seek(0, SeekOrigin.Begin)
                    Return New Icon(destStream)
                End Using
            End Using
        End Function

        Public Shared Function GetResourceData(ByVal hModule As IntPtr, ByVal resourceName As ResourceName, ByVal resourceType As ResourceTypes) As Byte()
            'Find the resource in the module.
            Dim hResInfo As IntPtr = IntPtr.Zero
            Try
                hResInfo = Win32.FindResource(hModule, resourceName.Value, resourceType)
            Finally
                resourceName.Free()
            End Try
            If hResInfo = IntPtr.Zero Then
                Throw New Win32Exception()
            End If
            'Load the resource.
            Dim hResData As IntPtr = Win32.LoadResource(hModule, hResInfo)
            If hResData = IntPtr.Zero Then
                Throw New Win32Exception()
            End If
            'Lock the resource to read data.
            Dim hGlobal As IntPtr = Win32.LockResource(hResData)
            If hGlobal = IntPtr.Zero Then
                Throw New Win32Exception()
            End If
            'Get the resource size.
            Dim resSize As Integer = Win32.SizeofResource(hModule, hResInfo)
            If resSize = 0 Then
                Throw New Win32Exception()
            End If
            'Allocate the requested size.
            Dim buf(resSize - 1) As Byte
            'Copy the resource data into our buffer.
            Marshal.Copy(hGlobal, buf, 0, buf.Length)

            Return buf
        End Function

        Public Shared Function GetResourceData(ByVal hModule As IntPtr, ByVal resourceId As Integer, ByVal resourceType As ResourceTypes) As Byte()
            'Find the resource in the module.
            Dim hResInfo As IntPtr = Win32.FindResource(hModule, New IntPtr(resourceId), resourceType)
            If hResInfo = IntPtr.Zero Then
                Throw New Win32Exception()
            End If
            'Load the resource.
            Dim hResData As IntPtr = Win32.LoadResource(hModule, hResInfo)
            If hResData = IntPtr.Zero Then
                Throw New Win32Exception()
            End If
            'Lock the resource to read data.
            Dim hGlobal As IntPtr = Win32.LockResource(hResData)
            If hGlobal = IntPtr.Zero Then
                Throw New Win32Exception()
            End If
            'Get the resource size.
            Dim resSize As Integer = Win32.SizeofResource(hModule, hResInfo)
            If resSize = 0 Then
                Throw New Win32Exception()
            End If
            'Allocate the requested size.
            Dim buf(resSize - 1) As Byte
            'Copy the resource data into our buffer.
            Marshal.Copy(hGlobal, buf, 0, buf.Length)

            Return buf
        End Function
#End Region

#Region "IDisposable Members"
        ''' <summary>
        ''' Releases the resources of that object.
        ''' </summary>
        Public Sub Dispose() Implements IDisposable.Dispose
            If ModuleHandle <> IntPtr.Zero Then
                Try
                    Win32.FreeLibrary(ModuleHandle)
                Catch
                End Try
                ModuleHandle = IntPtr.Zero
            End If
            If IconNamesList IsNot Nothing Then
                IconNamesList.Clear()
            End If
        End Sub
#End Region
    End Class
End Namespace