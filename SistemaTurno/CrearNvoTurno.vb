Public Class CrearNvoTurno
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Validar campos
        If txtPaciente.Text = "" Then
            MessageBox.Show("Ingrese el Apellido y Nombre del paciente.")
            txtPaciente.Focus()
            Exit Sub

        End If

        If cmbAsistencia.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione la asistencia correspondiente")
            cmbAsistencia.Focus()
            Exit Sub
        End If

        ' --- Lógica para guardar en el archivo ---
        Dim rutaArchivo As String = "turnos.csv"
        Dim datosTurno As String = String.Join(",", New String() {
        dtpFecha.Value.ToString("yyyy-MM-dd"), ' Formato de fecha para ordenar
        dtpHora.Value.ToShortTimeString(),
        txtPaciente.Text,
        txtTelefono.Text,
        cmbAsistencia.Text
    })

        Try
            ' El segundo parámetro (True) hace que se agregue al final del archivo sin borrar lo anterior
            My.Computer.FileSystem.WriteAllText(rutaArchivo, datosTurno & Environment.NewLine, True)
            MessageBox.Show("Turno guardado con éxito.")
            ' --- Aquí está el cambio ---
            Me.DialogResult = DialogResult.OK ' Indica que la operación fue exitosa
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar el turno: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.DialogResult = DialogResult.Cancel ' Opcional: Indica que la operación falló
        End Try
        ' --- Fin de la lógica para guardar ---





    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbAsistencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAsistencia.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class