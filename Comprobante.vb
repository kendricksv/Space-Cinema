Public Class Comprobante
    Public Shared Function GenerarComprobante(boleto As Boleto) As String
        Dim comprobante As String = "===== BOLETO DE CINE =====" & Environment.NewLine
        comprobante &= "Nombre: " & boleto.GetNombre() & Environment.NewLine
        comprobante &= "Apellido: " & boleto.GetApellido() & Environment.NewLine
        comprobante &= "Cédula: " & boleto.GetCedula() & Environment.NewLine
        comprobante &= "Sala: " & boleto.GetSala() & Environment.NewLine
        comprobante &= "Puesto: " & boleto.GetPuesto() & Environment.NewLine
        comprobante &= "Hora de Función: " & boleto.GetHoraFuncion() & Environment.NewLine
        comprobante &= "Película: " & boleto.GetPelicula() & Environment.NewLine
        comprobante &= "==========================="

        Return comprobante
    End Function
End Class

