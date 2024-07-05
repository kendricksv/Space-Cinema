Public Class Boleto
    Inherits Persona
    Private sala As String
    Private puesto As String
    Private horaFuncion As String
    Private pelicula As String


    Public Sub New(nombre As String, apellido As String, cedula As String, sala As String, puesto As String, horaFuncion As String, pelicula As String)
        MyBase.New(nombre, apellido, cedula)
        Me.sala = sala
        Me.puesto = puesto
        Me.horaFuncion = horaFuncion
        Me.pelicula = pelicula
    End Sub


    Public Function GetSala() As String
        Return sala
    End Function

    Public Function GetPuesto() As String
        Return puesto
    End Function

    Public Function GetHoraFuncion() As String
        Return horaFuncion
    End Function

    Public Function GetPelicula() As String
        Return pelicula
    End Function
End Class

