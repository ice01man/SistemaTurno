Imports System.IO
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
    Private Sub CargarTurnosEnDataGridView()
        Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "turnos.csv")

        DGVTurnos.Rows.Clear()
        DGVTurnos.Columns.Clear()

        ' Columnas visibles
        DGVTurnos.Columns.Add("Paciente", "Paciente")
        DGVTurnos.Columns.Add("Telefono", "Teléfono")
        DGVTurnos.Columns.Add("Profesional", "Profesional")
        DGVTurnos.Columns.Add("TurnoDia", "Día del Turno")
        DGVTurnos.Columns.Add("TurnoHora", "Hora")

        ' Botón "Ver"
        Dim colVer As New DataGridViewButtonColumn() With {
            .HeaderText = "Ver",
            .Text = "Ver",
            .UseColumnTextForButtonValue = True
        }
        DGVTurnos.Columns.Add(colVer)

        ' CheckBox "Asistió" y "Ausente"
        DGVTurnos.Columns.Add(New DataGridViewCheckBoxColumn() With {.HeaderText = "Asistió", .Name = "Asistio"})
        DGVTurnos.Columns.Add(New DataGridViewCheckBoxColumn() With {.HeaderText = "Ausente", .Name = "Ausente"})

        ' Columnas ocultas
        DGVTurnos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "DNI", .Visible = False})
        DGVTurnos.Columns.Add(New DataGridViewTextBoxColumn() With {.Name = "AsistenciaRaw", .Visible = False})

        If Not File.Exists(rutaArchivo) Then
            MessageBox.Show("No se encontró el archivo de turnos: " & vbCrLf & rutaArchivo, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Using parser As New TextFieldParser(rutaArchivo)
            parser.TextFieldType = FieldType.Delimited
            parser.SetDelimiters(",")

            Dim primeraLinea As Boolean = True
            While Not parser.EndOfData
                Dim datos() As String = parser.ReadFields()

                ' Saltar encabezado
                If primeraLinea Then
                    primeraLinea = False
                    Continue While
                End If

                If datos.Length < 9 Then Continue While

                Dim apellido = datos(0).Trim()
                Dim nombre = datos(1).Trim()
                Dim dni = datos(2).Trim()
                Dim telefono = datos(3).Trim()
                Dim asistencia = datos(4).Trim().ToLower()
                Dim profesional = datos(6).Trim()
                Dim fecha = datos(7).Trim()
                Dim hora = datos(8).Trim()

                Dim asistio = {"si", "presente", "asistio", "true", "1"}.Contains(asistencia)
                Dim ausente = {"no", "ausente", "false", "0"}.Contains(asistencia)

                DGVTurnos.Rows.Add($"{apellido} {nombre}", telefono, profesional, fecha, hora, "Ver", asistio, ausente, dni, asistencia)
            End While
        End Using

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
            Dim dni = DGVTurnos.Rows(e.RowIndex).Cells("DNI").Value?.ToString()
            MessageBox.Show($"Paciente: {apynom}{vbCrLf}DNI: {dni}", "Detalle del Turno", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

            Dim dni As String = row.Cells("DNI").Value.ToString()
            Dim fecha As String = row.Cells("TurnoDia").Value.ToString()
            Dim hora As String = row.Cells("TurnoHora").Value.ToString()
            Dim nuevoValor As String = ""

            If CBool(row.Cells("Asistio").Value) Then
                nuevoValor = "Presente"
            ElseIf CBool(row.Cells("Ausente").Value) Then
                nuevoValor = "Ausente"
            End If

            Dim lineas = File.ReadAllLines(rutaArchivo).ToList()
            For i = 0 To lineas.Count - 1
                Dim datos = lineas(i).Split(","c)
                If datos.Length < 9 Then Continue For
                If datos(0).Trim().ToLower().Contains("apellido") Then Continue For

                If datos(2).Trim() = dni AndAlso datos(7).Trim() = fecha AndAlso datos(8).Trim() = hora Then
                    datos(4) = nuevoValor
                    lineas(i) = String.Join(",", datos)
                    Exit For
                End If
            Next

            File.WriteAllLines(rutaArchivo, lineas)
            row.Cells("AsistenciaRaw").Value = nuevoValor
        Catch ex As Exception
            MessageBox.Show("Error al guardar asistencia: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ===========================================================
    ' BOTONES
    ' ===========================================================
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

        Desarrollado en Visual Basic .NET
        © 2025 - Todos los derechos reservados.
        Autores: Paulo Reta, Clara Carmagnac, M Victoria Marcos."

        MessageBox.Show(mensaje, "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
