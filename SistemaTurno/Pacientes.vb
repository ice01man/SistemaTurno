Imports System.IO
'Actualización al 24 de septiembre
'Actualización al 29/10



Public Class Pacientes

    ' Diccionario para guardar pacientes cargados desde el CSV
    Private pacientesData As New Dictionary(Of String, String())

    'Public Property FormReferencia As Form
    Public Property FormPrincipal As Form1


    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPacientesDesdeCSV()
        ConfigurarAutoComplete()

        If Not TextBuscar Is Nothing Then AddHandler TextBuscar.KeyDown, AddressOf TextBuscar_KeyDown
    End Sub


    Private Sub CargarPacientesDesdeCSV()
        pacientesData.Clear()
        Dim rutaCSV As String = "pacientes.csv"

        If File.Exists(rutaCSV) Then
            Using sr As New StreamReader(rutaCSV)
                While Not sr.EndOfStream
                    Dim linea As String = sr.ReadLine()
                    If String.IsNullOrWhiteSpace(linea) Then Continue While

                    Dim campos() As String = linea.Split(","c)

                    If campos.Length >= 8 Then
                        Dim dni As String = campos(3).Trim()
                        If Not pacientesData.ContainsKey(dni) Then
                            pacientesData.Add(dni, campos)
                        Else

                            pacientesData(dni) = campos
                        End If
                    End If
                End While
            End Using
        End If
    End Sub


    Private Sub ConfigurarAutoComplete()
        Try
            If TextBuscar Is Nothing Then Return

            Dim auto As New AutoCompleteStringCollection()
            auto.AddRange(pacientesData.Keys.ToArray())

            TextBuscar.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            TextBuscar.AutoCompleteSource = AutoCompleteSource.CustomSource
            TextBuscar.AutoCompleteCustomSource = auto
        Catch ex As Exception

        End Try
    End Sub

    Private Sub buscardatagrid()
        MsgBox("Ingreso BuscarGrid")
        Dim apellido = TextApellido.Text

        Dim rutaArchivo As String = "turnos.csv"

        DataGridPacientes.Rows.Clear()

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
                        If datos(0).Trim() = apellido Then
                            Dim vpaciente = datos(0) & ", " & datos(1)
                            Dim vhorario = datos(6) & "- " & datos(7)
                            DataGridPacientes.Rows.Add(vpaciente, datos(5), datos(4), vhorario)
                            ' DataGridPacientes.ForeColor = BLACK
                        End If

                    End If

                Next
            Catch ex As Exception
                MessageBox.Show("Ocurrió un error al cargar los turnos en el DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub


    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs)
        Dim apellido As String = If(TextBuscar?.Text, String.Empty).Trim()

        If String.IsNullOrEmpty(apellido) Then
            MessageBox.Show("Escribí un apellido en la caja de búsqueda.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        If pacientesData.ContainsKey(apellido) Then
            Dim datos = pacientesData(apellido)
            TextApellido.Text = datos(1)
            TextNombre.Text = datos(2)
            TextDNI.Text = datos(3)
            TextFechaNac.Text = datos(4)
            TextTelefono.Text = datos(5)
            TextEmail.Text = datos(6)
            TextOSocial.Text = datos(7)
            TextNCredencial.Text = datos(8)
        Else
            MessageBox.Show("Paciente no encontrado. Puede cargarlo como nuevo.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarFormulario()
            TextApellido.Text = apellido
        End If

        buscardatagrid()


    End Sub



    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs)
        Dim apellido As String = If(TextApellido?.Text, String.Empty).Trim()
        If apellido = "" Then
            MessageBox.Show("Debe ingresar un apellido para guardar el paciente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        LimpiarFormulario()

        Dim datos() As String = {
            TextApellido.Text,
            TextNombre.Text,
            TextDNI.Text,
            TextFechaNac.Text,
            TextTelefono.Text,
            TextEmail.Text,
            TextOSocial.Text,
            TextNCredencial.Text
        }


        If pacientesData.ContainsKey(apellido) Then
            pacientesData(apellido) = datos
        Else
            pacientesData.Add(apellido, datos)
        End If

        GuardarPacientesEnCSV()
        ConfigurarAutoComplete()

        MessageBox.Show("Paciente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    Private Sub GuardarPacientesEnCSV()
        Dim rutaCSV As String = "pacientes.csv"

        Using sw As New StreamWriter(rutaCSV, False, System.Text.Encoding.UTF8)
            For Each kvp In pacientesData

                sw.WriteLine(String.Join(",", kvp.Value))
            Next
        End Using

        LimpiarFormulario()
    End Sub

    ' Genera un ID simple y consecutivo si no hay uno cargado
    Private Function SiguienteId() As String
        ' Si tenés otra lógica de IDs, reemplazala acá.
        Return (pacientesData.Count + 1).ToString()
    End Function

    ' Construye la fila con el MISMO orden que usa tu código:
    ' [0]=ID, [1]=Apellido, [2]=Nombre, [3]=DNI, [4]=FechaNac, [5]=Tel, [6]=Email, [7]=OSocial, [8]=NCredencial
    Private Function CrearFilaPacienteDesdeFormulario() As String()
        Dim fila(8) As String
        fila(0) = SiguienteId()              ' ID (puede ser vacío si preferís)
        fila(1) = If(TextApellido?.Text, "").Trim()
        fila(2) = If(TextNombre?.Text, "").Trim()
        fila(3) = If(TextDNI?.Text, "").Trim()
        fila(4) = If(TextFechaNac?.Text, "").Trim()
        fila(5) = If(TextTelefono?.Text, "").Trim()
        fila(6) = If(TextEmail?.Text, "").Trim()
        fila(7) = If(TextOSocial?.Text, "").Trim()
        fila(8) = If(TextNCredencial?.Text, "").Trim()
        Return fila
    End Function

    Private Sub LimpiarFormulario()
        TextApellido.Clear()
        TextNombre.Clear()
        TextDNI.Clear()
        TextFechaNac.Clear()
        TextTelefono.Clear()
        TextEmail.Clear()
        TextOSocial.Clear()
        TextNCredencial.Clear()

        DataGridPacientes.Rows.Clear()
    End Sub


    Private Sub TextBuscar_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            BtnBuscar_Click(Nothing, EventArgs.Empty)
            e.SuppressKeyPress = True
        End If

        BtnAgregar.Text = "Guardar"
    End Sub

    '  Private Sub brnVolver_Click(sender As Object, e As EventArgs)
    '  If FormPrincipal IsNot Nothing Then
    '  Dim frmInicio As New Inicio
    '       frmInicio.FormPrincipal = FormPrincipal
    '       FormPrincipal.MostrarFormulario(frmInicio)
    ' End If
    ' End Sub

    Private Sub TextBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBuscar.TextChanged
        'BtnBuscar_Click()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Dim apellido As String = If(TextApellido?.Text, String.Empty).Trim()

        If apellido = "" Then
            MessageBox.Show("Debe ingresar al menos el Apellido para guardar el paciente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' 1) Tomo los datos del formulario en el orden correcto (ID, APE, NOM, DNI, FNA, TEL, EMA, OSO, NCRED)
        Dim fila As String() = CrearFilaPacienteDesdeFormulario()

        ' 2) Actualizo el diccionario en memoria usando el APELLIDO como clave, como ya hace tu código
        If pacientesData.ContainsKey(apellido) Then
            pacientesData(apellido) = fila
        Else
            pacientesData.Add(apellido, fila)
        End If

        ' 3) Guardo todo el diccionario al CSV y refresco el autocompletado
        GuardarPacientesEnCSV()
        ConfigurarAutoComplete()

        MessageBox.Show("Paciente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
