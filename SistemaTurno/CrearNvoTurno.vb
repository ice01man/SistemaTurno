<<<<<<< HEAD
﻿Imports System.IO


' Actualizado el 14/10/25
Public Class CrearNvoTurno
=======
﻿Public Class CrearNvoTurno
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'Validar campos
        If cmbPaciente.Text = "" Then
            MessageBox.Show("Ingrese el Apellido y Nombre del paciente.")
            cmbPaciente.Focus()
            Exit Sub
>>>>>>> 004e269285548fbece1a3300a33ce5d15a269055

    Private pacientes As New List(Of Persona)
    Private dtpFecha As Object

    Private Class Persona
        Public Property ApellidoNombre As String
        Public Property Telefono As String
        Public Property DNI As String
    End Class

<<<<<<< HEAD
    '-----
=======
        ' --- Lógica para guardar en el archivo ---
        Dim rutaArchivo = "turnos.csv"
        Dim datosTurno = String.Join(",", New String() {
        dtpFecha.Value.ToString("yyyy-MM-dd"), ' Formato de fecha para ordenar
        cmbPaciente.Text,
        txtTelefono.Text,
        cmbAsistencia.Text
    })
>>>>>>> 004e269285548fbece1a3300a33ce5d15a269055

    Public Sub New()
        InitializeComponent()
        CargarPacientes()
        CargarEspecialidades("doctores.csv")

        dtpHora.MinDate = DateTime.Today
    End Sub


    ' Cargar pacientes desde pacientes.csv y configurar autocompletado
    Private Sub CargarPacientes()
        Dim rutaArchivo As String = "pacientes.csv"

<<<<<<< HEAD
=======


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

>>>>>>> 004e269285548fbece1a3300a33ce5d15a269055
        If IO.File.Exists(rutaArchivo) Then
            Dim lineas = IO.File.ReadAllLines(rutaArchivo)
            Pacientes.Clear()

            For i As Integer = 1 To lineas.Length - 1
                Dim datos = lineas(i).Split(","c)
                If datos.Length >= 8 Then
                    Dim apellido As String = datos(1).Trim()
                    Dim nombre As String = datos(2).Trim()
                    Dim dni As String = datos(3).Trim()
                    Dim telefono As String = datos(5).Trim()

                    pacientes.Add(New Persona With {
                        .ApellidoNombre = $"{apellido} {nombre}",
                        .Telefono = telefono,
                        .DNI = dni
                    })
                End If
            Next

            ' Autocompletado

            Dim autoComplete As New AutoCompleteStringCollection()
            autoComplete.AddRange(pacientes.Select(Function(p) p.ApellidoNombre).ToArray())

            Txt_ApellidoNombre.AutoCompleteCustomSource = autoComplete
            Txt_ApellidoNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Txt_ApellidoNombre.AutoCompleteSource = AutoCompleteSource.CustomSource
        Else
            MessageBox.Show("No se encontró el archivo pacientes.csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

<<<<<<< HEAD

    Private Sub Txt_ApellidoNombre_TextChanged(sender As Object, e As EventArgs) Handles Txt_ApellidoNombre.TextChanged
        Dim textoIngresado As String = Txt_ApellidoNombre.Text.Trim()

        If String.IsNullOrWhiteSpace(textoIngresado) Then
            txtTelefono.Clear()
            txtDNI.Clear()
            btnAgregar.Enabled = False
            Return
        End If

        Dim pacienteExistente = pacientes.FirstOrDefault(Function(p) String.Equals(p.ApellidoNombre, textoIngresado, StringComparison.OrdinalIgnoreCase))

        If pacienteExistente IsNot Nothing Then
            txtTelefono.Text = pacienteExistente.Telefono
            txtDNI.Text = pacienteExistente.DNI
            btnAgregar.Enabled = False
        Else
            txtTelefono.Clear()
            txtDNI.Clear()
            btnAgregar.Enabled = True
        End If
    End Sub

    Private Sub CargarEspecialidades(rutaArchivo As String)
        Try
            If File.Exists(rutaArchivo) Then
                Dim especialidades As New HashSet(Of String)()
                Dim lineas() As String = File.ReadAllLines(rutaArchivo)

                For i As Integer = 1 To lineas.Length - 1
                    Dim columnas() As String = lineas(i).Split(","c)
                    If columnas.Length >= 4 Then
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
            Else
                MessageBox.Show("No se encontró el archivo doctores.csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cargar especialidades: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
=======
    ' Cuando seleccionás un paciente, que aparezca el teléfono
    Private Sub cmbPaciente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPaciente.SelectedIndexChanged
        Dim seleccionado As Persona = TryCast(cmbPaciente.SelectedItem, Persona)
        If seleccionado IsNot Nothing Then
            txtTelefono.Text = seleccionado.Telefono
        End If
    End Sub

    Private Sub dtpHora_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboHorarios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboHorarios.SelectedIndexChanged
        Dim rutaArchivo = "horarios.csv"

        ComboHorarios.Items.Clear()

        If IO.File.Exists(rutaArchivo) Then
            Dim lineas = IO.File.ReadAllLines(rutaArchivo)
            For i = 1 To lineas.Length - 1
                Dim datos = lineas(i).Split(","c)
                If datos.Length >= 2 Then
                    Dim hora = datos(0).Trim
                    ComboHorarios.Items.Add(hora)
                End If
            Next
        End If
    End Sub

>>>>>>> 004e269285548fbece1a3300a33ce5d15a269055


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


                cmbHora.Items.Clear()

                For Each hora As String In lineas
                    If Not String.IsNullOrWhiteSpace(hora) Then
                        cmbHora.Items.Add(hora.Trim())
                    End If
                Next
            Else
                MessageBox.Show("No se encontró el archivo de horarios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al leer horarios: " & ex.Message)
        End Try
    End Sub

    Private Sub cmbEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEspecialidad.SelectedIndexChanged
        Dim especialidadSeleccionada As String = cmbEspecialidad.SelectedItem?.ToString()
        If Not String.IsNullOrEmpty(especialidadSeleccionada) Then
            CargarProfXEspecialidad(especialidadSeleccionada)
        Else
            cmbProfesional.Items.Clear()
        End If
    End Sub



    Private Sub CargarProfXEspecialidad(especialidad As String)
        Dim rutaArchivo As String = "doctores.csv"
        cmbProfesional.Items.Clear()

        If IO.File.Exists(rutaArchivo) Then
            Dim lineas = IO.File.ReadAllLines(rutaArchivo)

            For i As Integer = 1 To lineas.Length - 1
                Dim columnas = lineas(i).Split(","c)
                If columnas.Length >= 4 Then
                    Dim esp = columnas(3).Trim()
                    If esp.Equals(especialidad, StringComparison.OrdinalIgnoreCase) Then
                        Dim apellido = columnas(1).Trim()
                        Dim nombre = columnas(2).Trim()
                        cmbProfesional.Items.Add($"{apellido} {nombre}")
                    End If
                End If
            Next
        Else
            MessageBox.Show("No se encontró el archivo doctores.csv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim archivoTurnos As String = "turnos.csv"

            Dim paciente = Txt_ApellidoNombre.Text.Trim()
            Dim telefono = txtTelefono.Text.Trim()
            Dim dni = txtDNI.Text.Trim()
            Dim especialidad = cmbEspecialidad.SelectedItem?.ToString()
            Dim profesional = cmbProfesional.SelectedItem?.ToString()
            Dim fecha = dtpHora.Value.ToString("dd/MM/yyyy")
            Dim hora = cmbHora.SelectedItem?.ToString()

            If String.IsNullOrWhiteSpace(paciente) OrElse String.IsNullOrWhiteSpace(especialidad) OrElse
               String.IsNullOrWhiteSpace(profesional) OrElse String.IsNullOrWhiteSpace(hora) Then
                MessageBox.Show("Complete todos los campos antes de guardar el turno.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim linea As String = $"{paciente},{dni},{telefono},{especialidad},{profesional},{fecha},{hora}"
            Dim existeArchivo As Boolean = File.Exists(archivoTurnos)

            Using sw As New StreamWriter(archivoTurnos, True)
                If Not existeArchivo Then
                    sw.WriteLine("Paciente,DNI,Telefono,Especialidad,Profesional,Fecha,Hora")
                End If
                sw.WriteLine(linea)
            End Using

            MessageBox.Show("Turno guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al guardar el turno: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LimpiarCampos()
        Txt_ApellidoNombre.Clear()
        txtTelefono.Clear()
        txtDNI.Clear()
        cmbEspecialidad.SelectedIndex = -1
        cmbProfesional.Items.Clear()
        cmbHora.SelectedIndex = -1
    End Sub


    '----------------------------------------------------------------------------------------------

<<<<<<< HEAD
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

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbHora.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblProfesional.Click

    End Sub

    Private Sub cmbProfesional_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProfesional.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDNI.TextChanged

    End Sub
=======
>>>>>>> 004e269285548fbece1a3300a33ce5d15a269055
End Class
