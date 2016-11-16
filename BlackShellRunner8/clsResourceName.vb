Imports System.Runtime.InteropServices

Namespace TAFactory.IconPack
    ''' <summary>
    ''' Represents a resource name (either integer resource or string resource).
    ''' </summary>
    Public Class ResourceName
        Implements IDisposable
#Region "Properties"
        Protected _id As Nullable(Of Integer)
        ''' <summary>
        ''' Gets the resource identifier, returns null if the resource is not an integer resource.
        ''' </summary>
        Public Property Id() As Nullable(Of Integer)
            Get
                Return _id
            End Get
            Protected Set(ByVal value As Nullable(Of Integer))
                _id = value
            End Set
        End Property

        Protected _name As String
        ''' <summary>
        ''' Gets the resource name, returns null if the resource is not a string resource.
        ''' </summary>
        Public Property Name() As String
            Get
                Return _name
            End Get
            Protected Set(ByVal value As String)
                _name = value
            End Set
        End Property

        Protected _value As IntPtr
        ''' <summary>
        ''' Gets a pointer to resource name that can be used in FindResource function.
        ''' </summary>
        Public Property Value() As IntPtr
            Get
                If IsIntResource Then
                    Return New IntPtr(Id.Value)
                End If

                If _value = IntPtr.Zero Then
                    _value = Marshal.StringToHGlobalAuto(Name)
                End If

                Return _value
            End Get
            Protected Set(ByVal value As IntPtr)
                _value = value
            End Set
        End Property

        ''' <summary>
        ''' Gets whether the resource is an integer resource.
        ''' </summary>
        Public ReadOnly Property IsIntResource() As Boolean
            Get
                Return (Id IsNot Nothing)
            End Get
        End Property
#End Region

#Region "Constructor/Destructor"

        Public Sub New(ByVal lpName As IntPtr)
            If (CUInt(lpName) >> 16) = 0 Then 'Integer resource
                Id = lpName.ToInt32()
                Name = Nothing
            Else
                Id = Nothing
                Name = Marshal.PtrToStringAuto(lpName)
            End If
        End Sub
        ''' <summary>
        ''' Destructs the ResourceName object.
        ''' </summary>
        Protected Overrides Sub Finalize()
            Dispose()
        End Sub
#End Region

#Region "Public Functions"
        ''' <summary>
        ''' Returns a System.String that represents the current TAFactory.IconPack.ResourceName.
        ''' </summary>
        ''' <returns>Returns a System.String that represents the current TAFactory.IconPack.ResourceName.</returns>
        Public Overrides Function ToString() As String
            If IsIntResource Then
                Return "#" & Id.ToString()
            End If

            Return Name
        End Function
        ''' <summary>
        ''' Releases the pointer to the resource name.
        ''' </summary>
        Public Sub Free()
            If _value <> IntPtr.Zero Then
                Try
                    Marshal.FreeHGlobal(_value)
                Catch
                End Try
                _value = IntPtr.Zero
            End If
        End Sub
#End Region

#Region "IDisposable Members"
        ''' <summary>
        ''' Release the pointer to the resource name.
        ''' </summary>
        Public Sub Dispose() Implements IDisposable.Dispose
            Free()
        End Sub
#End Region
    End Class
End Namespace