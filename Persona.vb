Public Class Persona
    Private nombre As String
    Private apellido As String
    Private cedula As String


    Public Sub New(nombre As String, apellido As String, cedula As String)
        Me.nombre = nombre
        Me.apellido = apellido
        Me.cedula = cedula
    End Sub


    Public Function GetNombre() As String
        Return nombre
    End Function

    Public Function GetApellido() As String
        Return apellido
    End Function

    Public Function GetCedula() As String
        Return cedula
    End Function
End Class

