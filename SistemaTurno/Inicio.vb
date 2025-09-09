Public Class Inicio

    'Ultima Actualizacion 08/09/2025 
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarTurnosEnDataGridView()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim frmNuevoTurno As New frmNuevoTurno()
        Dim frmNvoTurno As New CrearNvoTurno
        If frmNvoTurno.ShowDialog = DialogResult.OK Then
            ' Si el formulario se cerró con DialogResult.OK,
            ' significa que se guardó un nuevo turno, así que actualizamos el DataGridView.
            CargarTurnosEnDataGridView()
        End If
    End Sub

    Private Sub CargarTurnosEnDataGridView()
        Dim rutaArchivo As String = "turnos.csv"

        'Limpiar las filas actuales para evitar duplicados
        'Dim v = DGVTurnos.Rows.Count

        DGVTurnos.Rows.Clear()

        If My.Computer.FileSystem.FileExists(rutaArchivo) Then
            Try
                ' Leer todas las líneas del archivo
                Dim lineas As String() = My.Computer.FileSystem.ReadAllText(rutaArchivo).Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

                ' Recorrer cada línea del archivo
                For Each linea As String In lineas
                    ' Separar los datos por la coma
                    Dim datos() As String = linea.Split(","c)

                    If datos.Length >= 5 Then ' Asegurarse de que la línea tiene todos los campos necesarios
                        ' Agregar una nueva fila al DataGridView con los datos de la línea
                        DGVTurnos.Rows.Add(datos(2), datos(3), datos(4), datos(0), datos(1))
                        ' El orden de los datos debe coincidir con el orden de las columnas en tu DataGridView
                        ' Recuerda que en el código anterior guardamos en el orden: Fecha, Hora, Paciente, Teléfono, Asistencia
                        ' Así que el orden al agregar la fila es: Paciente, Teléfono, Asistencia, Fecha, Hora
                    End If
                Next
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al cargar los turnos en el DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTurnos.CellContentClick
        CargarTurnosEnDataGridView()
    End Sub


End Class