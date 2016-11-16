Imports System.IO
Imports System.Runtime.InteropServices

Namespace TAFactory.Utilities
    ''' <summary>
    ''' Holds a set of utilities.
    ''' </summary>
    Public NotInheritable Class Utility
#Region "Stream Utilities"

        Private Sub New()
        End Sub
        Public Shared Function ReadStructure(Of T As Structure)(ByVal inputStream As Stream) As T
            Dim size As Integer = Marshal.SizeOf(GetType(T))
            Dim buffer(size - 1) As Byte
            inputStream.Read(buffer, 0, size)
            Dim ptr As IntPtr = Marshal.AllocHGlobal(size)
            Marshal.Copy(buffer, 0, ptr, size)
            Dim ret As Object = Marshal.PtrToStructure(ptr, GetType(T))
            Marshal.FreeHGlobal(ptr)

            Return CType(ret, T)
        End Function
        ''' <summary>
        ''' Writes as structure of type T to the output stream.
        ''' </summary>
        ''' <typeparam name="T">The structure type to be written.</typeparam>
        ''' <param name="outputStream">The output stream to write to.</param>
        ''' <param name="structure">The structure to be written.</param>
        Public Shared Sub WriteStructure(Of T As Structure)(ByVal outputStream As Stream, ByVal [structure] As T)
            Dim size As Integer = Marshal.SizeOf(GetType(T))
            Dim buffer(size - 1) As Byte
            Dim ptr As IntPtr = Marshal.AllocHGlobal(size)
            Marshal.StructureToPtr([structure], ptr, True)
            Marshal.Copy(ptr, buffer, 0, size)
            Marshal.FreeHGlobal(ptr)
            outputStream.Write(buffer, 0, size)
        End Sub
#End Region
    End Class
End Namespace