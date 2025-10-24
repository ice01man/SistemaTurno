Public Class Inicio

    ' Ultima actualizacion 21/10
    'Ultima Actualizacion 17/09/2025 
    'Actualizacion al 14/10/2025

    Public Property FormPrincipal As Form1
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarTurnosEnDataGridView()
    End Sub

    Private Sub btnPaciente_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        If FormPrincipal IsNot Nothing Then
            Dim pacientes As New Pacientes()
            pacientes.FormPrincipal = FormPrincipal
            FormPrincipal.MostrarFormulario(pacientes)
        Else
            MessageBox.Show("No se encontró el formulario principal.")
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim frmNuevoTurno As New frmNuevoTurno()

        'Dim frmNvoTurno As New CrearNvoTurno
        'If frmNvoTurno.ShowDialog = DialogResult.OK Then
        'Si el formulario se cerró con DialogResult.OK,
        'CargarTurnosEnDataGridView()
        'End If

        If Me.FormPrincipal IsNot Nothing Then
            Dim frmNuevoTurno As New CrearNvoTurno()

            ' Llama a la función del formulario principal (Form1) para cargarlo en el ContentPanel
            Me.FormPrincipal.MostrarFormulario(frmNuevoTurno)
        Else
            MsgBox("Error: Referencia al Formulario Principal no encontrada.")
        End If
    End Sub

    Private Sub CargarTurnosEnDataGridView()
        Dim rutaArchivo As String = "turnos.csv"

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

    Private Sub lblTurnosDiaActual_Click(sender As Object, e As EventArgs) Handles lblTurnosDiaActual.Click

    End Sub
End Class
