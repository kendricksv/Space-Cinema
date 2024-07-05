Public Class Form1

    Private Sub btnGenerarBoleto_Click(sender As Object, e As EventArgs) Handles btnGenerarBoleto.Click
        Dim nombres As String = txtNombres.Text
        Dim apellidos As String = txtApellidos.Text
        Dim cedula As String = txtCedula.Text
        Dim sala As String = txtSala.Text
        Dim puesto As String = txtPuesto.Text
        Dim horaFuncion As String = txtHoraFuncion.Text


        If String.IsNullOrWhiteSpace(nombres) OrElse
          String.IsNullOrWhiteSpace(apellidos) OrElse
          String.IsNullOrWhiteSpace(cedula) OrElse
          String.IsNullOrWhiteSpace(sala) OrElse
          String.IsNullOrWhiteSpace(puesto) OrElse
          String.IsNullOrWhiteSpace(horaFuncion) Then


            MessageBox.Show("Error al ingresar los datos requeridos. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else







            rtbBoleto.Text = "Boleto de Cine" & Environment.NewLine &
                          "----------------------------------" & Environment.NewLine &
                          "Nombres: " & nombres & Environment.NewLine &
                          "Apellidos: " & apellidos & Environment.NewLine &
                          "Número de Cédula: " & cedula & Environment.NewLine &
                          "Sala: " & sala & Environment.NewLine &
                          "Puesto: " & puesto & Environment.NewLine &
                          "Hora de la Función: " & horaFuncion & Environment.NewLine

        End If


    End Sub




End Class



