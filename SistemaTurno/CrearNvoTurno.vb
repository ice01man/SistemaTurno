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
        ' Validar campos
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
            dtpFecha.Value.ToString("yyyy-MM-dd"),
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

    ' Cancelar


    ' Al escribir en Apellido y Nombre, verificar si existe y completar teléfono
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

    ' Acción del botón Agregar


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim formularioPacientes As New Pacientes()
        formularioPacientes.ShowDialog() ' Usá Show() si querés que no bloquee el formulario actual

        ' Opcional: recargar pacientes después de cerrar el formulario
        CargarPacientes()
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

    'Private Sub Txt_ApellidoNombre_TextChanged(sender As Object, e As EventArgs) Handles Txt_ApellidoNombre.TextChanged

    'End Sub

End Class
