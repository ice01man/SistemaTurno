Imports System.IO


' Actualizado el 30/09/25
Public Class CrearNvoTurno

    Private Class Persona
        Public Property ApellidoNombre As String
        Public Property Telefono As String
    End Class

    Private pacientes As New List(Of Persona)


    Public Sub New()
        InitializeComponent()
        CargarPacientes()
    End Sub

    ' Cargar pacientes desde pacientes.csv y configurar autocompletado
    Private Sub CargarPacientes()
        Dim rutaArchivo As String = "pacientes.csv"

        If IO.File.Exists(rutaArchivo) Then
            Dim lineas = IO.File.ReadAllLines(rutaArchivo)
            pacientes.Clear()

            For i As Integer = 1 To lineas.Length - 1
                Dim datos = lineas(i).Split(","c)

                If datos.Length >= 8 Then
                    Dim apellido As String = datos(1).Trim()
                    Dim nombre As String = datos(2).Trim()
                    Dim telefono As String = datos(5).Trim()

                    pacientes.Add(New Persona With {
                        .ApellidoNombre = $"{apellido} {nombre}",
                        .Telefono = telefono
                    })
                End If
            Next

            ' Config autocompletado
            Dim autoComplete As New AutoCompleteStringCollection()
            autoComplete.AddRange(pacientes.Select(Function(p) p.ApellidoNombre).ToArray())

            Txt_ApellidoNombre.AutoCompleteCustomSource = autoComplete
            Txt_ApellidoNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Txt_ApellidoNombre.AutoCompleteSource = AutoCompleteSource.CustomSource
        End If
    End Sub

    ' Guardar turno
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Txt_ApellidoNombre.Text = "" Then
            MessageBox.Show("Ingrese el Apellido y Nombre del paciente.")
            Txt_ApellidoNombre.Focus()
            Exit Sub
        End If

        If cmbAsistencia.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione la asistencia correspondiente")
            cmbAsistencia.Focus()
            Exit Sub
        End If

        ' Guardar datos
        Dim rutaArchivo As String = "turnos.csv"
        Dim datosTurno As String = String.Join(",", New String() {
            dtpHora.Value.ToString("yyyy-MM-dd"),
            dtpHora.Value.ToShortTimeString,
            Txt_ApellidoNombre.Text,
            txtTelefono.Text,
            cmbAsistencia.Text
        })

        Try
            My.Computer.FileSystem.WriteAllText(rutaArchivo, datosTurno & Environment.NewLine, True)
            MessageBox.Show("Turno guardado con éxito.")
            DialogResult = DialogResult.OK
            Close()
        Catch ex As Exception
            MessageBox.Show("Ocurrió un error al guardar el turno: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DialogResult = DialogResult.Cancel
        End Try
    End Sub


    Private Sub Txt_ApellidoNombre_TextChanged(sender As Object, e As EventArgs) Handles Txt_ApellidoNombre.TextChanged
        Dim textoIngresado As String = Txt_ApellidoNombre.Text.Trim()

        If String.IsNullOrWhiteSpace(textoIngresado) Then
            txtTelefono.Clear()
            btnAgregar.Enabled = False
            Return
        End If

        Dim pacienteExistente = pacientes.FirstOrDefault(Function(p) String.Equals(p.ApellidoNombre, textoIngresado, StringComparison.OrdinalIgnoreCase))

        If pacienteExistente IsNot Nothing Then
            txtTelefono.Text = pacienteExistente.Telefono
            btnAgregar.Enabled = False
        Else
            txtTelefono.Clear()
            btnAgregar.Enabled = True
        End If
    End Sub

    ' Botón Agregar

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim formularioPacientes As New Pacientes()
        formularioPacientes.ShowDialog()


        CargarPacientes()
    End Sub

    Private Sub FormTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarHorasDesdeCSV("horarios.csv")
        CargarEspecialidades("doctores.csv")
    End Sub

    Private Sub CargarHorasDesdeCSV(rutaArchivo As String)
        Try

            If File.Exists(rutaArchivo) Then

                Dim lineas() As String = File.ReadAllLines(rutaArchivo)


                CmbTurnos.Items.Clear()

                For Each hora As String In lineas
                    If Not String.IsNullOrWhiteSpace(hora) Then
                        CmbTurnos.Items.Add(hora.Trim())
                    End If
                Next
            Else
                MessageBox.Show("No se encontró el archivo de horarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al leer horarios: " & ex.Message)
        End Try
    End Sub


    Private Sub CargarEspecialidades(rutaArchivo As String)
        Try
            If File.Exists(rutaArchivo) Then
                Dim especialidades As New HashSet(Of String)()


                Dim lineas() As String = File.ReadAllLines(rutaArchivo)

                For i As Integer = 1 To lineas.Length - 1
                    Dim columnas() As String = lineas(i).Split(","c)

                    If columnas.Length >= 3 Then
                        Dim especialidad As String = columnas(3).Trim()

                        If Not String.IsNullOrWhiteSpace(especialidad) Then
                            especialidades.Add(especialidad)
                        End If
                    End If
                Next


                Dim listaOrdenada = especialidades.ToList()
                listaOrdenada.Sort()

                cmbEspecialidad.Items.Clear()
                For Each esp In listaOrdenada
                    cmbEspecialidad.Items.Add(esp)
                Next

                cmbEspecialidad.Items.Clear()
                For Each esp In especialidades
                    cmbEspecialidad.Items.Add(esp)

                Next

            Else
                MessageBox.Show("No se encontró el archivo doctores.csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar especialidades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEspecialidad.SelectedIndexChanged

    End Sub

    Private Sub CrearNvoTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dtpHora_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles CmbTurnos.SelectedIndexChanged

    End Sub



End Class
