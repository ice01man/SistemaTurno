Imports System.IO
Imports System.Text

Public Class CrearNvoTurno
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Validar campos
        If cmbPaciente.Text = "" Then
            MessageBox.Show("Ingrese el Apellido y Nombre del paciente.")
            cmbPaciente.Focus()
            Exit Sub

        End If

        If cmbAsistencia.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione la asistencia correspondiente")
            cmbAsistencia.Focus()
            Exit Sub
        End If

        ' --- Lógica para guardar en el archivo ---
        Dim rutaArchivo = "turnos.csv"
        Dim datosTurno = String.Join(",", New String() {
        dtpFecha.Value.ToString("yyyy-MM-dd"), ' Formato de fecha para ordenar
        dtpHora.Value.ToShortTimeString,
        cmbPaciente.Text,
        txtTelefono.Text,
        cmbAsistencia.Text
    })

        Try
            ' El segundo parámetro (True) hace que se agregue al final del archivo sin borrar lo anterior
            My.Computer.FileSystem.WriteAllText(rutaArchivo, datosTurno & Environment.NewLine, True)
            MessageBox.Show("Turno guardado con éxito.")
            ' --- Aquí está el cambio ---
            DialogResult = DialogResult.OK ' Indica que la operación fue exitosa
            Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar el turno: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DialogResult = DialogResult.Cancel ' Opcional: Indica que la operación falló
        End Try
        ' --- Fin de la lógica para guardar ---

    End Sub


    '------------------------------------------------------------------------------



    ' Clase interna para representar un paciente
    Private Class Persona
            Public Property ApellidoNombre As String
            Public Property Telefono As String
        End Class

        ' Lista de pacientes cargados desde el CSV
        Private pacientes As New List(Of Persona)

        ' Constructor del formulario
        Public Sub New()
            InitializeComponent()   ' <-- crea los controles del diseñador
            CargarPacientes()       ' <-- carga los datos desde el archivo
        End Sub

        ' Leer el archivo pacientes.csv y llenar el ComboBox
        Private Sub CargarPacientes()
            Dim rutaArchivo As String = "pacientes.csv"

            If IO.File.Exists(rutaArchivo) Then
            Dim lineas = IO.File.ReadAllLines(rutaArchivo)

            pacientes.Clear()

            For i As Integer = 1 To lineas.Length - 1
                Dim datos = lineas(i).Split(","c)

                If datos.Length >= 5 Then
                    Dim apellido As String = datos(0).Trim()
                    Dim nombre As String = datos(1).Trim()
                    Dim telefono As String = datos(4).Trim()

                    pacientes.Add(New Persona With {
                    .ApellidoNombre = apellido & " " & nombre,
                    .Telefono = telefono
                })
                End If
            Next

            ' Enlazar la lista al ComboBox
            cmbPaciente.DataSource = Nothing
            cmbPaciente.DataSource = pacientes
            cmbPaciente.DisplayMember = "ApellidoNombre"
            cmbPaciente.ValueMember = "Telefono"
        End If
    End Sub

    ' Cuando seleccionás un paciente, que aparezca el teléfono
    Private Sub cmbPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaciente.SelectedIndexChanged
            Dim seleccionado As Persona = TryCast(cmbPaciente.SelectedItem, Persona)
            If seleccionado IsNot Nothing Then
                txtTelefono.Text = seleccionado.Telefono
            End If
        End Sub




    '----------------------------------------------------------------------------------------------

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cmbAsistencia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAsistencia.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtPaciente_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub CrearNvoTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
