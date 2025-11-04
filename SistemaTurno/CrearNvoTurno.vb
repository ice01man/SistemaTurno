Imports System.IO
Imports System.Reflection
Imports System.Diagnostics


'Actualizado el 25/10

Public Class CrearNvoTurno

    Private pacientes As New List(Of Persona)
    Private doctores As New List(Of Doctor)
    Public Property FormPrincipal As Form1
    Private turnosFile As String = "turnos.csv"
    Private doctoresFile As String = "doctores.csv"
    Private cronometro As Stopwatch = New Stopwatch()
    Private inicioCapturado As Boolean = False


    Private Class Persona
        Public Property ApellidoNombre As String
        Public Property Telefono As String
        Public Property DNI As String
    End Class

    Private Class Doctor
        Public Property Id As Integer
        Public Property Apellido As String
        Public Property Nombre As String
        Public Property Especialidad As String
        Public Property DiaLaboral As String
        Public Property HoraInicio As TimeSpan
        Public Property HoraFin As TimeSpan
    End Class

    Public Sub New()
        InitializeComponent()
        CargarPacientes()
        CargarDoctores("doctores.csv")
        CargarEspecialidades()
        dtpHora.MinDate = DateTime.Today
    End Sub

    'carga de pacientes
    Private Sub CargarPacientes()
        Dim rutaArchivo As String = "pacientes.csv"
        If Not File.Exists(rutaArchivo) Then Return

        Dim lineas = File.ReadAllLines(rutaArchivo)
        pacientes.Clear()

        For i As Integer = 1 To lineas.Length - 1
            Dim datos = lineas(i).Split(","c)
            If datos.Length >= 6 Then
                pacientes.Add(New Persona With {
                    .ApellidoNombre = $"{datos(1).Trim()} {datos(2).Trim()}",
                    .DNI = datos(3).Trim(),
                    .Telefono = datos(5).Trim()
                })
            End If
        Next

        Dim autoComplete As New AutoCompleteStringCollection()
        autoComplete.AddRange(pacientes.Select(Function(p) p.ApellidoNombre).ToArray())
        Txt_ApellidoNombre.AutoCompleteCustomSource = autoComplete
        Txt_ApellidoNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Txt_ApellidoNombre.AutoCompleteSource = AutoCompleteSource.CustomSource
    End Sub

    Private Sub Txt_ApellidoNombre_TextChanged(sender As Object, e As EventArgs) Handles Txt_ApellidoNombre.TextChanged

        ' iniciar cronómetro
        If Not inicioCapturado AndAlso Txt_ApellidoNombre.Text.Trim() <> "" Then
            cronometro.Restart()
            inicioCapturado = True
        End If

        Dim textoIngresado As String = Txt_ApellidoNombre.Text.Trim()
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


    'doctores

    Private allowedDayOfWeek As Nullable(Of DayOfWeek) = Nothing
    Private fechaAnterior As Date

    Private Sub CargarDoctores(rutaArchivo As String)
        doctores.Clear()
        If Not File.Exists(rutaArchivo) Then Return

        Dim lineas = File.ReadAllLines(rutaArchivo)
        For i As Integer = 1 To lineas.Length - 1
            Dim c = lineas(i).Split(","c)
            If c.Length >= 7 Then
                doctores.Add(New Doctor With {
                    .Id = Integer.Parse(c(0)),
                    .Apellido = c(1).Trim(),
                    .Nombre = c(2).Trim(),
                    .Especialidad = c(3).Trim(),
                    .DiaLaboral = c(4).Trim(),
                    .HoraInicio = TimeSpan.Parse(c(5)),
                    .HoraFin = TimeSpan.Parse(c(6))
                })
            End If
        Next
    End Sub
    Private Sub CargarEspecialidades()
        Dim especialidades = doctores.Select(Function(d) d.Especialidad).Distinct().OrderBy(Function(e) e).ToList()
        cmbEspecialidad.Items.Clear()
        For Each esp In especialidades
            cmbEspecialidad.Items.Add(esp)
        Next
    End Sub

    Private Sub cmbEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEspecialidad.SelectedIndexChanged
        cmbProfesional.Items.Clear()
        Dim seleccion = cmbEspecialidad.Text
        Dim listaProfes = doctores.Where(Function(d) d.Especialidad = seleccion).ToList()
        For Each doc In listaProfes
            cmbProfesional.Items.Add($"{doc.Apellido} {doc.Nombre}")
        Next
    End Sub



    'hora y dia

    Private Function ParseDayNameToDayOfWeek(dayName As String) As Nullable(Of DayOfWeek)
        If String.IsNullOrWhiteSpace(dayName) Then Return Nothing
        Dim s As String = dayName.Trim().ToLowerInvariant()

        ' normalizar acentos simples 

        s = s.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u").Replace("ñ", "n")
        Select Case s
            Case "lunes"
                Return DayOfWeek.Monday
            Case "martes"
                Return DayOfWeek.Tuesday
            Case "miercoles", "mierc"
                Return DayOfWeek.Wednesday
            Case "jueves"
                Return DayOfWeek.Thursday
            Case "viernes"
                Return DayOfWeek.Friday
            Case "sabado", "sab"
                Return DayOfWeek.Saturday
            Case "domingo", "dom"
                Return DayOfWeek.Sunday
            Case Else
                Return Nothing
        End Select
    End Function

    Private Sub cmbProfesional_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProfesional.SelectedIndexChanged
        Try

            ' validar selección

            If cmbProfesional.SelectedIndex = -1 Then
                allowedDayOfWeek = Nothing
                lblDiasTrabajo1.Text = "Seleccione un profesional para ver disponibilidad."
                lblDiasTrabajo1.BackColor = Color.FromArgb(224, 224, 224)
                lblDiasTrabajo1.ForeColor = Color.FromArgb(64, 64, 64)
                cmbHora.Items.Clear()
                Return
            End If

            Dim profesionalSel As String = cmbProfesional.SelectedItem.ToString()
            Dim doctorSel = doctores.FirstOrDefault(Function(d) $"{d.Apellido} {d.Nombre}" = profesionalSel)

            If doctorSel Is Nothing Then
                lblDiasTrabajo1.Text = "No se encontró el profesional seleccionado."
                lblDiasTrabajo1.BackColor = Color.FromArgb(255, 230, 230)
                lblDiasTrabajo1.ForeColor = Color.DarkRed
                allowedDayOfWeek = Nothing
                cmbHora.Items.Clear()
                Return
            End If


            ' mostrar días laborales

            Dim dias = doctores.
               Where(Function(d) d.Apellido = doctorSel.Apellido AndAlso d.Nombre = doctorSel.Nombre).
               Select(Function(d) $"{d.DiaLaboral} ({d.HoraInicio:hh\:mm} - {d.HoraFin:hh\:mm})").
               ToList()

            If dias.Count = 0 Then
                lblDiasTrabajo1.Text = "este profesional no tiene días laborales cargados."
                lblDiasTrabajo1.BackColor = Color.FromArgb(255, 250, 205)
                lblDiasTrabajo1.ForeColor = Color.FromArgb(102, 51, 0)
            Else
                lblDiasTrabajo1.Text = "🩺 días laborales de " & profesionalSel & ":" & vbCrLf & String.Join(vbCrLf, dias)
                lblDiasTrabajo1.BackColor = Color.FromArgb(210, 240, 255)
                lblDiasTrabajo1.ForeColor = Color.DarkBlue
                lblDiasTrabajo1.Visible = True
                lblDiasTrabajo1.Refresh()
            End If

            ' configurar día permitido (si solo hay un día en el registro principal se usa)
            allowedDayOfWeek = ParseDayNameToDayOfWeek(doctorSel.DiaLaboral)
            If allowedDayOfWeek Is Nothing Then
                ' si no se puede interpretar, permitimos elegir pero avisamos
                MessageBox.Show($"no se pudo interpretar el/los días laborales: '{doctorSel.DiaLaboral}'", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                ' fijar dtp al próximo dia valido
                Dim fecha As DateTime = DateTime.Today
                Dim attempts As Integer = 0
                While fecha.DayOfWeek <> allowedDayOfWeek.Value And attempts < 14
                    fecha = fecha.AddDays(1)
                    attempts += 1
                End While
                dtpHora.Value = fecha
                fechaAnterior = dtpHora.Value
            End If

            ' cargar horas disponibles para la fecha actual
            CargarHorasDisponibles()

        Catch ex As Exception
            lblDiasTrabajo1.Text = "⚠ error al consultar los días laborales."
            lblDiasTrabajo1.BackColor = Color.FromArgb(255, 230, 230)
            lblDiasTrabajo1.ForeColor = Color.DarkRed
            cmbHora.Items.Clear()
        End Try
    End Sub


    ' al cambiar la fecha

    Private ReadOnly DayOfWeekMap As New Dictionary(Of DayOfWeek, String) From {
    {DayOfWeek.Monday, "lunes"},
    {DayOfWeek.Tuesday, "martes"},
    {DayOfWeek.Wednesday, "miércoles"},
    {DayOfWeek.Thursday, "jueves"},
    {DayOfWeek.Friday, "viernes"},
    {DayOfWeek.Saturday, "sábado"},
    {DayOfWeek.Sunday, "domingo"}
}

    Private Sub dtpHora_ValueChanged(sender As Object, e As EventArgs) Handles dtpHora.ValueChanged

        ' si hay un día permitido, validamos

        If allowedDayOfWeek IsNot Nothing Then
            If dtpHora.Value.DayOfWeek <> allowedDayOfWeek.Value Then
                cmbHora.Items.Clear()
                MessageBox.Show($"el profesional seleccionado sólo atiende los {DayOfWeekMap(allowedDayOfWeek.Value)}. elegí una fecha en ese día.", "fecha no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' revertir a la fecha anterior valida
                dtpHora.Value = fechaAnterior
                Return
            End If
        End If

        ' si ok, actualizar horas disponibles y guardar fecha anterior
        CargarHorasDisponibles()
        fechaAnterior = dtpHora.Value
    End Sub


    ' cargar horas disponibles (dentro del rango del doctor y sin duplicados)

    Private Sub CargarHorasDisponibles()
        cmbHora.Items.Clear()
        cmbHora.Text = ""

        If cmbProfesional.SelectedIndex = -1 Then
            Return
        End If

        Dim profesional = cmbProfesional.SelectedItem.ToString()
        Dim doctorSel = doctores.FirstOrDefault(Function(d) $"{d.Apellido} {d.Nombre}" = profesional)
        If doctorSel Is Nothing Then Return

        ' rango laboral del doctor

        Dim horaInicio As TimeSpan = doctorSel.HoraInicio
        Dim horaFin As TimeSpan = doctorSel.HoraFin

        'generar slots de 30 minutos 

        Dim listaHoras As New List(Of String)
        Dim cur = horaInicio
        While cur < horaFin
            listaHoras.Add(cur.ToString("hh\:mm"))
            cur = cur.Add(TimeSpan.FromMinutes(30))
        End While

        ' obtener horarios ocupados desde turnos.csv
        Dim fechaSel As String = dtpHora.Value.ToString("dd/MM/yyyy")
        Dim ocupadas = cargarturnosocupados_por_especialidad(doctorSel.Especialidad, fechaSel) ' nota: comparacion por especialidad por formato actual del csv

        ' filtrar horarios disponibles
        Dim disponibles = listaHoras.Where(Function(h) Not ocupadas.Contains(h)).ToList()

        If disponibles.Count = 0 Then
            ' no hay horarios libres en ese rango
            MessageBox.Show("No hay horarios disponibles para este profesional en la fecha seleccionada.", "sin disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        cmbHora.Items.AddRange(disponibles.ToArray())
    End Sub

    Private Function cargarturnosocupados_por_especialidad(especialidad As String, fecha As String) As HashSet(Of String)
        Dim ocupadas As New HashSet(Of String)
        Dim ruta As String = "turnos.csv"
        If Not File.Exists(ruta) Then Return ocupadas

        Dim lineas = File.ReadAllLines(ruta)
        For i As Integer = 1 To lineas.Length - 1
            Dim c = lineas(i).Split(","c)
            ' proteger si la linea está mal formateada
            If c.Length >= 8 Then
                Dim especialidadTurno = c(4).Trim()     ' indice 4 -> especialidad
                Dim fechaTurno = c(6).Trim()           ' indice 6 -> fecha
                Dim hora = c(7).Trim()                 ' indice 7 -> hora
                If especialidadTurno = especialidad AndAlso fechaTurno = fecha Then
                    ocupadas.Add(hora)
                End If
            End If
        Next
        Return ocupadas
    End Function

    Private Sub CrearNvoTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' configuración visual del Label
        lblDiasTrabajo1.AutoSize = False
        lblDiasTrabajo1.MaximumSize = New Size(250, 0)
        lblDiasTrabajo1.ForeColor = Color.DarkBlue
        lblDiasTrabajo1.Font = New Font("Segoe UI", 9, FontStyle.Italic)
        lblDiasTrabajo1.Text = "Seleccione un profesional para ver disponibilidad."
        lblDiasTrabajo1.Visible = True

        ' boton guardar
        btnGuardar.BackColor = Color.FromArgb(30, 144, 255)
        btnGuardar.ForeColor = Color.White
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 204)
        btnGuardar.FlatAppearance.BorderSize = 1

        ' boton cancelar
        btnCancelar.BackColor = Color.FromArgb(220, 53, 69)
        btnCancelar.ForeColor = Color.White
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(200, 35, 51)
        btnCancelar.FlatAppearance.BorderSize = 1


    End Sub


    ' guardar turno: validación más específica y mensajes

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim archivoTurnos As String = "turnos.csv"
            Dim nombreCompleto = Txt_ApellidoNombre.Text.Trim()
            Dim telefono = txtTelefono.Text.Trim()
            Dim dni = txtDNI.Text.Trim()
            Dim especialidad = If(cmbEspecialidad.SelectedItem, String.Empty)?.ToString()
            Dim profesional = If(cmbProfesional.SelectedItem, String.Empty)?.ToString()
            Dim tipoConsulta = If(cmbAsistencia.SelectedItem, String.Empty)?.ToString()
            Dim fecha = dtpHora.Value.ToString("dd/MM/yyyy")
            Dim hora = If(cmbHora.SelectedItem, String.Empty)?.ToString()

            ' validaciones 

            Dim faltan As New List(Of String)
            If String.IsNullOrWhiteSpace(nombreCompleto) Then faltan.Add("Paciente")
            If String.IsNullOrWhiteSpace(dni) Then faltan.Add("DNI")
            If String.IsNullOrWhiteSpace(telefono) Then faltan.Add("Teléfono")
            If String.IsNullOrWhiteSpace(especialidad) Then faltan.Add("Especialidad")
            If String.IsNullOrWhiteSpace(profesional) Then faltan.Add("Profesional")
            If String.IsNullOrWhiteSpace(tipoConsulta) Then faltan.Add("Tipo de Consulta")
            If String.IsNullOrWhiteSpace(hora) Then faltan.Add("Hora")

            If faltan.Count > 0 Then
                MessageBox.Show("faltan campos: " & String.Join(", ", faltan), "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Return
            End If

            ' separar apellido y nombre 

            Dim partes() As String = nombreCompleto.Split(" "c, 2)
            Dim apellido As String = partes(0).Trim()
            Dim nombre As String = If(partes.Length > 1, partes(1).Trim(), "")

            ' validar turno duplicado 

            Dim ocupadas = cargarturnosocupados_por_especialidad(especialidad, fecha)
            If ocupadas.Contains(hora) Then
                MessageBox.Show("ese horario ya está ocupado para la especialidad seleccionada.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' crear línea en orden correcto 

            Dim linea As String = $"{apellido},{nombre},{dni},{telefono},{tipoConsulta},{especialidad},{fecha},{hora},{profesional}"

            Dim existeArchivo As Boolean = File.Exists(archivoTurnos)
            Using sw As New StreamWriter(archivoTurnos, True)
                If Not existeArchivo Then
                    sw.WriteLine("Apellido,Nombre,Dni,Telefono,Especialidad,TipoConsulta,Fecha,Hora")
                End If
                sw.WriteLine(linea)
            End Using

            cronometro.Stop()
            Dim tiempoTotal As TimeSpan = cronometro.Elapsed
            Dim mensajeTiempo As String = $"Tiempo para agendar el turno: {tiempoTotal.Minutes:D2}:{tiempoTotal.Seconds:D2} minutos."

            MessageBox.Show($"Turno guardado correctamente.{vbCrLf}{mensajeTiempo}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            CargarHorasDisponibles()
            cronometro.Reset()
            inicioCapturado = False

        Catch ex As Exception
            MessageBox.Show("Error al guardar el turno: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LimpiarCampos()
        End Try
    End Sub



    ' botones
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim formularioPacientes As New Pacientes()
        formularioPacientes.ShowDialog()
        CargarPacientes()
    End Sub



    Private Sub LimpiarCampos()
        RemoveHandler dtpHora.ValueChanged, AddressOf dtpHora_ValueChanged
        If cmbProfesional.SelectedIndex = -1 Then Exit Sub

        ' textBox

        Txt_ApellidoNombre.Clear()
        txtDNI.Clear()
        txtTelefono.Clear()

        ' comboBox

        cmbAsistencia.SelectedIndex = -1
        cmbAsistencia.Text = ""
        cmbEspecialidad.SelectedIndex = -1
        cmbEspecialidad.Text = ""
        cmbProfesional.SelectedIndex = -1
        cmbProfesional.Text = ""
        cmbHora.SelectedIndex = -1
        cmbHora.Text = ""

        dtpHora.Value = DateTime.Today

        ' label

        lblDiasTrabajo1.Text = "Seleccione un profesional para ver disponibilidad."
        lblDiasTrabajo1.BackColor = Color.FromArgb(224, 224, 224)
        lblDiasTrabajo1.ForeColor = Color.FromArgb(64, 64, 64)

        ' resetear variables de control
        allowedDayOfWeek = Nothing

        ' volver a activar el evento
        AddHandler dtpHora.ValueChanged, AddressOf dtpHora_ValueChanged

    End Sub

    Private Sub btnVer_MouseEnter(sender As Object, e As EventArgs)
        lblDiasTrabajo1.BackColor = Color.FromArgb(200, 200, 200)
    End Sub

    Private Sub btnVer_MouseLeave(sender As Object, e As EventArgs)
        lblDiasTrabajo1.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub





End Class

