Imports System.IO
'Actualización al 24 de septiembre



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
                        Dim apellido As String = campos(1).Trim()
                        If Not pacientesData.ContainsKey(apellido) Then
                            pacientesData.Add(apellido, campos)
                        Else

                            pacientesData(apellido) = campos
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
                        If datos(2).Trim() = apellido Then
                            DataGridPacientes.Rows.Add(datos(7), datos(6), datos(0), datos(1))
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

    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        GuardarPacientesEnCSV()
    End Sub
End Class
