Imports System.IO
Imports System.Reflection

'Actualizado el 21/10

Public Class CrearNvoTurno

    Private pacientes As New List(Of Persona)
    Private doctores As New List(Of Doctor)
    Public Property FormPrincipal As Form1

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
        cmbEspecialidad.Items.AddRange(especialidades.ToArray())
    End Sub

    Private Sub cmbEspecialidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEspecialidad.SelectedIndexChanged
        cmbProfesional.Items.Clear()
        If cmbEspecialidad.SelectedIndex = -1 Then Exit Sub

        Dim esp = cmbEspecialidad.SelectedItem.ToString()
        Dim profesionales = doctores.Where(Function(d) d.Especialidad = esp).Select(Function(d) $"{d.Apellido} {d.Nombre}").Distinct().ToList()

        cmbProfesional.Items.AddRange(profesionales.ToArray())
    End Sub




    '==================== FILTROS POR DÍA Y HORA ====================

    Private Function ParseDayNameToDayOfWeek(dayName As String) As Nullable(Of DayOfWeek)
        If String.IsNullOrWhiteSpace(dayName) Then Return Nothing
        Dim s As String = dayName.Trim().ToLowerInvariant()
        ' normalizar acentos simples (very simple replacement)
        s = s.Replace("á", "a").Replace("é", "e").Replace("í", "i").Replace("ó", "o").Replace("ú", "u").Replace("ñ", "n")
        Select Case s
            Case "lunes"
                Return DayOfWeek.Monday
            Case "martes"
                Return DayOfWeek.Tuesday
            Case "miercoles", "mierc" ' fallback
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
        If cmbProfesional.SelectedIndex = -1 Then
            allowedDayOfWeek = Nothing
            Return
        End If

        Dim profesional = cmbProfesional.SelectedItem.ToString()
        Dim doctorSel = doctores.FirstOrDefault(Function(d) $"{d.Apellido} {d.Nombre}" = profesional)
        If doctorSel Is Nothing Then
            allowedDayOfWeek = Nothing
            Return
        End If

        ' obtener DayOfWeek correcto desde el string del CSV (maneja acentos)
        allowedDayOfWeek = ParseDayNameToDayOfWeek(doctorSel.DiaLaboral)
        If allowedDayOfWeek Is Nothing Then
            ' si no se reconoce el día, avisar y permitir selección normal
            MessageBox.Show($"No se pudo interpretar el día laboral del profesional: '{doctorSel.DiaLaboral}'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' fijar dtpHora al próximo día que coincida con el día laboral
        Dim fecha As DateTime = DateTime.Today
        Dim attempts As Integer = 0
        While fecha.DayOfWeek <> allowedDayOfWeek.Value And attempts < 14
            fecha = fecha.AddDays(1)
            attempts += 1
        End While
        dtpHora.Value = fecha

        ' actualizar horas disponibles inmediatamente
        CargarHorasDisponibles()
    End Sub

    ' ----------------------
    ' al cambiar la fecha
    ' ----------------------

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
                ' evitar bloquear UX—limpiar horas y avisar
                cmbHora.Items.Clear()
                MessageBox.Show($"El profesional seleccionado sólo atiende los {DayOfWeekMap(allowedDayOfWeek.Value)}. Elegí una fecha en ese día.", "Fecha no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        End If

        ' si todo OK, cargar horas
        CargarHorasDisponibles()
    End Sub

    ' ----------------------
    ' cargar horas disponibles (dentro del rango del doctor y sin duplicados)
    ' ----------------------
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

        ' generar slots de 30 minutos usando formato HH:mm (24h)
        Dim listaHoras As New List(Of String)
        Dim cur = horaInicio
        While cur < horaFin
            listaHoras.Add(cur.ToString("hh\:mm")) ' preserve leading zeros
            cur = cur.Add(TimeSpan.FromMinutes(30))
        End While

        ' cargar turnos ocupados para esa fecha y profesional
        Dim fechaSel As String = dtpHora.Value.ToString("dd/MM/yyyy") ' formato con el que se guardan
        Dim ocupadas = CargarTurnosOcupados(doctorSel, fechaSel)

        ' filtrar (aseguramos formatos iguales: hora ocupada también debe estar en HH:mm o hh:mm)
        Dim disponibles = listaHoras.Where(Function(h) Not ocupadas.Contains(h) AndAlso Not ocupadas.Contains(h.Replace("h", ":"))).ToList()

        If disponibles.Count = 0 Then
            ' no hay horarios libres
            MessageBox.Show("No hay horarios disponibles para este profesional en la fecha seleccionada.", "Sin disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        cmbHora.Items.AddRange(disponibles.ToArray())
    End Sub

    ' ----------------------
    ' cargar turnos ocupados (compara profesional y fecha)
    ' ----------------------
    Private Function CargarTurnosOcupados(doc As Doctor, fecha As String) As HashSet(Of String)
        Dim ocupadas As New HashSet(Of String)
        Dim ruta As String = "turnos.csv"
        If Not File.Exists(ruta) Then Return ocupadas

        Dim lineas = File.ReadAllLines(ruta)
        For i As Integer = 1 To lineas.Length - 1
            Dim c = lineas(i).Split(","c)
            If c.Length >= 7 Then
                Dim profesional = c(4).Trim()
                Dim fechaTurno = c(5).Trim()
                Dim hora = c(6).Trim()

                ' Normalizar horas a formato HH:mm (si vienen en otro)
                Dim horaNorm As String = hora
                ' Si tiene AM/PM u otro formato, sería necesario parsear; asumimos HH:mm
                If profesional = $"{doc.Apellido} {doc.Nombre}" AndAlso fechaTurno = fecha Then
                    ocupadas.Add(horaNorm)
                End If
            End If
        Next
        Return ocupadas
    End Function

    ' ----------------------
    ' guardar turno: validación más específica y mensajes
    ' ----------------------
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

            ' ===== Validaciones =====
            Dim faltan As New List(Of String)
            If String.IsNullOrWhiteSpace(nombreCompleto) Then faltan.Add("Paciente")
            If String.IsNullOrWhiteSpace(dni) Then faltan.Add("DNI")
            If String.IsNullOrWhiteSpace(telefono) Then faltan.Add("Teléfono")
            If String.IsNullOrWhiteSpace(especialidad) Then faltan.Add("Especialidad")
            If String.IsNullOrWhiteSpace(profesional) Then faltan.Add("Profesional")
            If String.IsNullOrWhiteSpace(tipoConsulta) Then faltan.Add("Tipo de Consulta")
            If String.IsNullOrWhiteSpace(hora) Then faltan.Add("Hora")

            If faltan.Count > 0 Then
                MessageBox.Show("Faltan campos: " & String.Join(", ", faltan),
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' ===== Separar Apellido y Nombre =====
            Dim partes() As String = nombreCompleto.Split(" "c, 2)
            Dim apellido As String = partes(0).Trim()
            Dim nombre As String = If(partes.Length > 1, partes(1).Trim(), "")

            ' ===== Validar turno duplicado =====
            Dim docSel = doctores.FirstOrDefault(Function(d) $"{d.Apellido} {d.Nombre}" = profesional)
            If docSel IsNot Nothing Then
                Dim ocupadas = CargarTurnosOcupados(docSel, fecha)
                If ocupadas.Contains(hora) Then
                    MessageBox.Show("Ese horario ya está ocupado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If

            ' ===== Crear línea en orden correcto =====
            Dim linea As String = $"{apellido},{nombre},{dni},{telefono},{especialidad},{tipoConsulta},{fecha},{hora}"

            Dim existeArchivo As Boolean = File.Exists(archivoTurnos)
            Using sw As New StreamWriter(archivoTurnos, True)
                If Not existeArchivo Then
                    sw.WriteLine("Apellido,Nombre,DNI,Telefono,Especialidad,TipoConsulta,Fecha,Hora")
                End If
                sw.WriteLine(linea)
            End Using

            MessageBox.Show("Turno guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()

        Catch ex As Exception
            MessageBox.Show("Error al guardar el turno: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            LimpiarCampos()
        End Try
    End Sub

    ' Dias laborales

    Private Sub btnDiasTrabajo_Click_Nuevo(sender As Object, e As EventArgs) Handles btnDiasTrabajo.Click
        Try
            Dim profesionalSel As String = If(cmbProfesional.SelectedItem, "").ToString().Trim()

            If String.IsNullOrWhiteSpace(profesionalSel) Then
                MessageBox.Show("Por favor, seleccione un profesional primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' Buscar al profesional en la lista de doctores
            Dim docSeleccionado = doctores.FirstOrDefault(Function(d) $"{d.Apellido} {d.Nombre}" = profesionalSel)

            If docSeleccionado Is Nothing Then
                MessageBox.Show("No se encontró el profesional seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Filtrar todos los registros de ese profesional (puede tener más de un día laboral)
            Dim dias = doctores.
            Where(Function(d) d.Apellido = docSeleccionado.Apellido AndAlso d.Nombre = docSeleccionado.Nombre).
            Select(Function(d) $"{d.DiaLaboral} ({d.HoraInicio} - {d.HoraFin})").
            ToList()

            If dias.Count = 0 Then
                MessageBox.Show("Este profesional no tiene días laborales cargados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim mensaje = "🩺 Días laborales de " & profesionalSel & ":" & vbCrLf & vbCrLf & String.Join(vbCrLf, dias)
                MessageBox.Show(mensaje, "Disponibilidad del Profesional", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al consultar los días laborales: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub








    '==================== BOTONES ====================
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim formularioPacientes As New Pacientes()
        formularioPacientes.ShowDialog()
        CargarPacientes()
    End Sub



    Private Sub LimpiarCampos()
        ' TextBox
        Txt_ApellidoNombre.Clear()
        txtDNI.Clear()
        txtTelefono.Clear()

        ' ComboBox
        cmbAsistencia.SelectedIndex = -1
        cmbAsistencia.Text = ""
        cmbEspecialidad.SelectedIndex = -1
        cmbEspecialidad.Text = ""
        cmbProfesional.SelectedIndex = -1
        cmbProfesional.Text = ""
        cmbHora.SelectedIndex = -1
        cmbHora.Text = ""

        dtpHora.Value = DateTime.Today

        ' Días laborales (botón o label asociado)
        btnDiasTrabajo.Enabled = True
        btnDiasTrabajo.BackColor = Color.FromArgb(224, 224, 224)

    End Sub
    Private Sub CrearNvoTurno_Load_(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- Botón GUARDAR ---
        btnGuardar.BackColor = Color.FromArgb(30, 144, 255)
        btnGuardar.ForeColor = Color.White
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(0, 102, 204)
        btnGuardar.FlatAppearance.BorderSize = 1

        ' --- Botón CANCELAR ---
        btnCancelar.BackColor = Color.FromArgb(220, 53, 69)
        btnCancelar.ForeColor = Color.White
        btnCancelar.FlatStyle = FlatStyle.Flat
        btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(200, 35, 51)
        btnCancelar.FlatAppearance.BorderSize = 1

        ' --- Botón VER (gris suave) ---
        btnDiasTrabajo.BackColor = Color.FromArgb(224, 224, 224)  ' gris claro
        btnDiasTrabajo.ForeColor = Color.FromArgb(64, 64, 64)     ' texto gris oscuro
        btnDiasTrabajo.FlatStyle = FlatStyle.Flat
        btnDiasTrabajo.FlatAppearance.BorderColor = Color.FromArgb(180, 180, 180)
        btnDiasTrabajo.FlatAppearance.BorderSize = 1
    End Sub
    Private Sub btnVer_MouseEnter(sender As Object, e As EventArgs) Handles btnDiasTrabajo.MouseEnter
        btnDiasTrabajo.BackColor = Color.FromArgb(200, 200, 200)
    End Sub

    Private Sub btnVer_MouseLeave(sender As Object, e As EventArgs) Handles btnDiasTrabajo.MouseLeave
        btnDiasTrabajo.BackColor = Color.FromArgb(224, 224, 224)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub CrearNvoTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnDiasTrabajo_Click(sender As Object, e As EventArgs) Handles btnDiasTrabajo.Click

    End Sub

    Private Sub cmbHora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbHora.SelectedIndexChanged

    End Sub
End Class
