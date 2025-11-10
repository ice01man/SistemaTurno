Imports System.IO
Imports System.Linq.Expressions
Imports Microsoft.VisualBasic.FileIO

Public Class Inicio
    Public Property FormPrincipal As Form1

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVTurnos.DefaultCellStyle.ForeColor = Color.Black
        DGVTurnos.DefaultCellStyle.BackColor = Color.White
        DGVTurnos.DefaultCellStyle.SelectionForeColor = Color.Black
        DGVTurnos.DefaultCellStyle.SelectionBackColor = Color.LightGray
        Try
            CargarTurnosEnDataGridView()
        Catch ex As Exception
            MessageBox.Show("Error al cargar los turnos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        Dim btnAcercaDe As New Button()
        btnAcercaDe.Text = "ℹ Acerca de"
        btnAcercaDe.Font = New Font("Segoe UI", 9, FontStyle.Regular)
        btnAcercaDe.BackColor = Color.FromArgb(173, 216, 230)
        btnAcercaDe.FlatStyle = FlatStyle.Flat
        btnAcercaDe.FlatAppearance.BorderColor = Color.SteelBlue
        btnAcercaDe.FlatAppearance.BorderSize = 1
        btnAcercaDe.ForeColor = Color.Navy



    End Sub

    ' ===========================================================
    ' CARGA DE TURNOS DESDE CSV
    ' ===========================================================
    Private Sub CargarTurnosEnDataGridView(Optional fechaFiltro As Date? = Nothing)
        Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "turnos.csv")

        ' 1. Configuración de Columnas
        DGVTurnos.Rows.Clear()
        DGVTurnos.Columns.Clear()
        Dim diaAFiltrar As Date = If(fechaFiltro.HasValue, fechaFiltro.Value.Date, Date.Today.Date)

        ' Columnas de Datos (Basadas en el orden de carga)
        DGVTurnos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Paciente", .HeaderText = "Paciente", .ReadOnly = True})
        DGVTurnos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Telefono", .HeaderText = "Teléfono", .ReadOnly = True})
        DGVTurnos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "TipoConsulta", .HeaderText = "Tipo de Consulta", .ReadOnly = True})
        DGVTurnos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Especialidad", .HeaderText = "Especialidad", .ReadOnly = True})
        DGVTurnos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "Profesional", .HeaderText = "Profesional", .ReadOnly = True})
        DGVTurnos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "TurnoDiaHora", .HeaderText = "Día y Hora", .ReadOnly = True})

        ' Columna de Botón "Ver"
        Dim colVer As New DataGridViewButtonColumn() With {
        .HeaderText = "Detalle",
        .Text = "Ver",
        .UseColumnTextForButtonValue = True
    }
        DGVTurnos.Columns.Add(colVer)

        ' CheckBox "Asistió" y "Ausente"
        DGVTurnos.Columns.Add(New DataGridViewCheckBoxColumn() With {.HeaderText = "Asistió", .Name = "Asistio"})
        DGVTurnos.Columns.Add(New DataGridViewCheckBoxColumn() With {.HeaderText = "Ausente", .Name = "Ausente"})

        ' 2. Validación de Archivo
        If Not File.Exists(rutaArchivo) Then
            MessageBox.Show("No se encontró el archivo de turnos: " & vbCrLf & rutaArchivo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        ' 3. Lectura del CSV y Carga de Datos
        Using parser As New TextFieldParser(rutaArchivo)
            parser.TextFieldType = FieldType.Delimited
            parser.SetDelimiters(",")

            ' Saltar Encabezado (primera línea)
            If Not parser.EndOfData Then
                parser.ReadFields()
            End If

            While Not parser.EndOfData
                Dim datos() As String = parser.ReadFields()

                If datos Is Nothing OrElse datos.Length < 10 Then

                    Continue While
                End If

                ' Desempaquetar datos del CSV (índice 0 a 9)
                Dim apellido = datos(0).Trim()
                Dim nombre = datos(1).Trim()
                Dim dni = datos(2).Trim()
                Dim telefono = datos(3).Trim()
                Dim tipoconsulta = datos(4).Trim()
                Dim especialidad = datos(5).Trim()
                Dim profesional = datos(6).Trim()
                Dim fecha = datos(7).Trim()
                Dim hora = datos(8).Trim()
                Dim estadoAsistencia = datos(9).Trim().ToLower()

                ' Filtro el DataGridView por fecha
                Try
                    ' Convertir la fecha del CSV a objeto Date
                    Dim fechaTurno As Date = Date.Parse(fecha)

                    ' Comprobar si la fecha del turno coincide con el día a filtrar
                    If fechaTurno.Date <> diaAFiltrar Then
                        Continue While ' Si no coincide, salta esta línea y sigue con la siguiente
                    End If
                Catch ex As Exception
                    ' Si la fecha no es válida, podemos registrar un error o simplemente saltar la línea
                    Continue While
                End Try


                Dim asistio As Boolean = {"si", "presente", "asistio", "true", "1"}.Contains(estadoAsistencia)
                Dim ausente As Boolean = {"no", "ausente", "false", "0"}.Contains(estadoAsistencia)

                ' Agregar fila al DataGridView
                DGVTurnos.Rows.Add(
                $"{apellido} {nombre} ({dni})", ' Col 0: Paciente (Combinación de campos)
                telefono,                       ' Col 1: Teléfono
                tipoconsulta,                   ' Col 2: TipoConsulta
                especialidad,                   ' Col 3: Especialidad
                profesional,                    ' Col 4: Profesional
                $"{fecha} {hora}",              ' Col 5: Día y Hora (Combinación de campos)
                "Ver",                          ' Col 6: Botón
                asistio,                        ' Col 7: Checkbox Asistió
                ausente                         ' Col 8: Checkbox Ausente
            )
            End While
        End Using

        ' 4. Configuración Visual Final
        DGVTurnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DGVTurnos.RowHeadersVisible = False
        DGVTurnos.AllowUserToAddRows = False
        DGVTurnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    ' ===========================================================
    ' EVENTOS DE CELDAS
    ' ===========================================================
    Private Sub DGVTurnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTurnos.CellContentClick
        If e.RowIndex < 0 Then Return

        If TypeOf DGVTurnos.Columns(e.ColumnIndex) Is DataGridViewButtonColumn Then
            Dim apynom = DGVTurnos.Rows(e.RowIndex).Cells("Paciente").Value?.ToString()
            Dim DiaHora = DGVTurnos.Rows(e.RowIndex).Cells("TurnoDiaHora").Value.ToString()
            Dim espec = DGVTurnos.Rows(e.RowIndex).Cells("Especialidad").Value.ToString()
            Dim profes = DGVTurnos.Rows(e.RowIndex).Cells("Profesional").Value.ToString()

            Dim Mensajeturno As String = $"Paciente: {apynom}{vbCrLf}" &
                                         $"Detalle del Turno: {DiaHora}{vbCrLf}" &
                                         $"Dr/Dra: {profes}{vbCrLf}" &
                                         $"Especialidad: {espec}{vbCrLf}"

            MessageBox.Show(Mensajeturno, "Detalle del Turno", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If DGVTurnos.Columns(e.ColumnIndex).Name = "Asistio" OrElse DGVTurnos.Columns(e.ColumnIndex).Name = "Ausente" Then
            DGVTurnos.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub DGVTurnos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVTurnos.CellValueChanged
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Return

        Dim col = DGVTurnos.Columns(e.ColumnIndex).Name
        If col = "Asistio" OrElse col = "Ausente" Then
            Dim row = DGVTurnos.Rows(e.RowIndex)
            Dim asistio As Boolean = CBool(row.Cells("Asistio").Value)
            Dim ausente As Boolean = CBool(row.Cells("Ausente").Value)

            If col = "Asistio" AndAlso asistio Then row.Cells("Ausente").Value = False
            If col = "Ausente" AndAlso ausente Then row.Cells("Asistio").Value = False

            GuardarAsistenciaEnCSV(row)
        End If
    End Sub

    ' ===========================================================
    ' GUARDAR ASISTENCIA
    ' ===========================================================
    Private Sub GuardarAsistenciaEnCSV(row As DataGridViewRow)
        Try
            Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "turnos.csv")


            If Not File.Exists(rutaArchivo) Then Return
            Dim TempPaciente = row.Cells("Paciente").Value.ToString()
            Dim dniConParentesis As String = TempPaciente.Substring(TempPaciente.IndexOf("(") + 1).Trim().Replace(")", "")
            Dim dni As String = dniConParentesis.Replace("(", "").Replace(")", "")
            Dim ApellidoNombreCompleto As String = TempPaciente.Substring(0, TempPaciente.IndexOf("(")).Trim()
            Dim ApellidonombreArray() As String = ApellidoNombreCompleto.Split(" "c)
            Dim apellido As String = ApellidonombreArray(0).Trim()
            Dim nombre As String = String.Join(" ", ApellidonombreArray.Skip(1)).Trim()

            Dim TempFechaHora As String = row.Cells("TurnoDiaHora").Value.ToString()

            Dim fechaHoraArray() As String = TempFechaHora.Split(" "c)
            Dim fecha As String = fechaHoraArray(0).Trim()
            Dim hora As String = fechaHoraArray(1).Trim()


            Dim nuevoValor As String = ""
            If CBool(row.Cells("Asistio").Value) Then
                nuevoValor = "Presente"
            ElseIf CBool(row.Cells("Ausente").Value) Then
                nuevoValor = "Ausente"
            End If

            Dim lineas = File.ReadAllLines(rutaArchivo).ToList()
            Dim turnoEncontrado As Boolean = False

            For i As Integer = 1 To lineas.Count - 1
                Dim lineaOriginal = lineas(i).Trim()
                If String.IsNullOrWhiteSpace(lineaOriginal) Then Continue For
                Dim datos() As String = lineaOriginal.Split(","c)
                If datos.Length < 10 Then Continue For
                If datos(2).Trim() = dni AndAlso datos(7).Trim() = fecha AndAlso datos(8).Trim() = hora Then

                    datos(9) = nuevoValor

                    lineas(i) = String.Join(",", datos)
                    turnoEncontrado = True

                    Exit For
                End If
            Next


            If turnoEncontrado Then
                File.WriteAllLines(rutaArchivo, lineas)
            Else
                MessageBox.Show("Advertencia: No se encontró el turno con DNI y Hora coincidentes en el archivo CSV.", "Turno No Encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al guardar asistencia: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub


    Private Sub BtnTurnos_Click(sender As Object, e As EventArgs) Handles btnTurnos.Click
        If FormPrincipal IsNot Nothing Then
            Dim frm As New CrearNvoTurno()
            FormPrincipal.AbrirFormularioInterno(frm)
        End If
    End Sub

    Private Sub BtnPacientes_Click(sender As Object, e As EventArgs) Handles btnPaciente.Click
        If FormPrincipal IsNot Nothing Then
            Dim frm As New Pacientes()
            FormPrincipal.AbrirFormularioInterno(frm)
        End If
    End Sub

    Private Sub MonthCalendar_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar.DateChanged
        ' 1. Obtener la fecha seleccionada por el usuario
        ' MonthCalendar usa SelectionStart para el inicio del rango seleccionado (si es un solo día, es esa fecha).
        Dim fechaSeleccionada As Date = MonthCalendar.SelectionStart.Date

        ' 2. Recargar el DataGridView con el filtro
        Try
            ' Llama a la función principal, pasando la fecha seleccionada.
            CargarTurnosEnDataGridView(fechaSeleccionada)
        Catch
            MessageBox.Show("Error al guardar asistencia: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub
    Private Sub btn_AcercaDe_Click(sender As Object, e As EventArgs) Handles btn_AcercaDe.Click
        Dim mensaje As String =
        "📅 SISTEMA DE GESTIÓN DE TURNOS MÉDICOS
        Versión 1.0
        Este sistema permite administrar turnos de pacientes y profesionales de manera rápida y sencilla.

        Funciones principales: 
        • Registro y autocompletado de pacientes.
        • Filtrado por especialidad y profesional.
        • Control de disponibilidad horaria.
        • Almacenamiento de turnos en archivos CSV.
        "
    End Sub
End Class
