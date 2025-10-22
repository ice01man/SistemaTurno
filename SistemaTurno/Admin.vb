'Actualizacion al 24 de septiembre 2025 
Imports System.IO
Imports System.Linq
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Admin

    Public Property FormPrincipal As Form1

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combobox_admin.SelectedIndexChanged
        Dim seleccion = Combobox_admin.SelectedItem.ToString
        btnGuardar.Visible = False
        txt_id.Visible = False


        Select Case seleccion
            Case "Usuarios"

                LimpiarAdmintrador(Me)

                PanelUsuarios.Visible = True
                PanelUsuarios.Location = New Point(70, 140)
                Chboxad.Visible = False
                admin_combo.Visible = True
                admin_texto3.Visible = False
                txt_buscadorEspe.Visible = False
                lbl_buscarEspecialidad.Visible = False
                admin_combo.Location = New Point(220, 116)


                Labelad1.Text = "Usuarios"
                Labelad2.Text = "Contraseña"
                Labelad3.Text = "Roles"
                Labelad4.Visible = False

                'DataGridViewAdmin.Rows.Clear()
                Dim rutaArchivo = "usuarios.txt"

                Try
                    CargarDatosDataGridview(rutaArchivo)
                Catch ex As Exception
                    MessageBox.Show("Ocurrió un error al cargar los turnos en el DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try


            Case "Pantalla"
                MsgBox("Seleccionaste: " & seleccion)

            Case "Doctores"

                LimpiarAdmintrador(Me)

                PanelUsuarios.Visible = True
                admin_combo.Visible = False
                Chboxad.Visible = True
                admin_texto3.Visible = True
                txt_buscadorEspe.Visible = True
                lbl_buscarEspecialidad.Visible = True
                Labelad4.Visible = True
                Chboxad.Location = New Point(220, 150)

                Labelad1.Text = "Dr/a:"
                Labelad2.Text = "Apellido"
                Labelad3.Text = "Especialidad"
                Labelad4.Text = "Dia Laboral"


                DataGridViewAdmin.Rows.Clear()
                DataGridViewAdmin.Columns.Clear()
                DataGridViewAdmin.AutoGenerateColumns = False

                Dim rutaArchivo = "doctores.csv"
                Dim primeraLinea = IO.File.ReadLines(rutaArchivo).FirstOrDefault


                If My.Computer.FileSystem.FileExists(rutaArchivo) Then
                    Try
                        CargarDatosDataGridview(rutaArchivo)
                    Catch ex As Exception
                        MessageBox.Show("Ocurrió un error al cargar los turnos en el DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            Case Else

                MsgBox("Selección no válida.", MsgBoxStyle.Exclamation, "Error")
                Exit Sub ' Salir de la subrutina para no continuar.
        End Select




    End Sub

    Private Sub CargarDatosDataGridview(ByVal rutaArchivo As String)
        'Dim rutaArchivo = "usuarios.txt"
        ' Leer todas las líneas del archivo
        Dim lineas = My.Computer.FileSystem.ReadAllText(rutaArchivo).Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
        Dim contador = 0

        DataGridViewAdmin.Columns.Clear()
        ' Recorrer cada línea del archivo
        For Each linea In lineas
            ' Separar los datos por la coma
            Dim datos = linea.Split(","c)

            If contador = 0 Then
                datos = linea.Split(","c)
                For Each dato In datos
                    'id,Nombre,Apellido,Especialidad,Dia_Laboral,Horario, Vacaciones, Etc 
                    Dim coldato As New DataGridViewTextBoxColumn
                    coldato.HeaderText = dato                       ' El texto que se muestra en el encabezado
                    coldato.Name = dato                             ' El nombre interno de la columna (útil para referenciarla)
                    DataGridViewAdmin.Columns.Add(coldato)          ' Agregamos la columna al DataGridView
                    If dato = "id" Then
                        coldato.Visible = False
                    End If
                Next
                contador += 1
                Continue For                                        ' Salta al inicio del siguiente bucle
            End If
            If datos.Length = 4 Then
                DataGridViewAdmin.Rows.Add(datos(0), datos(1), datos(2), datos(3))          ' Armo el Grid de Usuarios
            Else
                DataGridViewAdmin.Size = New Size(660, 414)
                DataGridViewAdmin.Rows.Add(datos(0), datos(1), datos(2), datos(3), datos(4)) ' Armo el Grid de Doctores
            End If
        Next

    End Sub

    Private Sub DataGridViewAdmin_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewAdmin.CellMouseDoubleClick
        If e.RowIndex >= 0 Then

            ' 1. Obtener el valor de la celda clicada
            Dim valorDeLaCelda As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

            Dim textBox_texto1 = admin_texto1
            Dim textBox_texto2 = admin_texto2
            Dim textBox_texto3 = admin_texto3
            Dim textBox_combo = admin_combo

            Dim numeroDeColumnas As Integer = DataGridViewAdmin.ColumnCount

            Dim idDeLaFila As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim txt1DeLaFila As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim txt2DeLaFila As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim txt3DeLaFila As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(3).Value.ToString()

            txt_id.Text = idDeLaFila
            textBox_texto1.Text = txt1DeLaFila
            textBox_texto2.Text = txt2DeLaFila
            textBox_texto3.Text = txt3DeLaFila

            If (numeroDeColumnas > 4) Then
                Dim txt4DeLaFila As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(4).Value.ToString()
                Dim datos = txt4DeLaFila.Split("/"c)

                For i As Integer = 0 To Chboxad.Items.Count - 1
                    Dim xx = Chboxad.GetItemText(Chboxad.Items(i))
                    Chboxad.SetItemChecked(i, False)
                    For Each dato In datos
                        If xx = dato Then
                            Chboxad.SetItemChecked(i, True)
                        End If

                    Next
                Next
            End If

            textBox_combo.Text = txt3DeLaFila

            btnGuardar.Visible = True


        End If


    End Sub

    Private Sub LimpiarAdmintrador(ByVal contenedor As Control)

        admin_texto1.Text = ""
        admin_texto2.Text = ""
        admin_texto3.Text = ""
        admin_combo.Text = ""
        txt_buscador.Text = ""
        For i As Integer = 0 To Chboxad.Items.Count - 1
            Chboxad.SetItemChecked(i, False)
        Next

    End Sub

    Private Sub txt_buscador_TextChanged(sender As Object, e As EventArgs) Handles txt_buscador.TextChanged
        ' Si el TextBox está vacío, muestra todas las filas
        If String.IsNullOrEmpty(txt_buscador.Text) Then
            For Each row As DataGridViewRow In DataGridViewAdmin.Rows
                row.Visible = True
            Next
        Else
            ' ToLower para hacer la búsqueda llevando todas las letas a minúsculas
            Dim searchText = txt_buscador.Text.ToLower
            Dim textoCompleto = ""
            Dim nombre = ""
            Dim apellido = ""
            Dim headers As New List(Of String)

            For Each columna As DataGridViewColumn In DataGridViewAdmin.Columns
                ' Agrega el HeaderText de cada columna a la lista
                headers.Add(columna.HeaderText)
            Next


            ' Recorre cada fila del DataGridView
            For Each row As DataGridViewRow In DataGridViewAdmin.Rows
                ' Por cada fila, busca en las celdas "Nombre" y "Apellido"
                Dim nombreCelda = row.Cells("Nombre")

                If headers.Contains("Apellido") Then
                    ' Si no existe la columna Apellido, solo busca en Nombre
                    Dim apellidoCelda = row.Cells("Apellido")
                    If Not String.IsNullOrWhiteSpace(apellidoCelda.Value) Then
                        apellido = apellidoCelda.Value.ToString
                    End If

                End If

                ' Obtiene el valor de la celda "Nombre" de forma segura
                If nombreCelda.Value IsNot Nothing Then
                    nombre = nombreCelda.Value.ToString
                End If

                ' Combina las cadenas y usa .Trim() para eliminar espacios extra si una de las celdas estaba vacía
                textoCompleto = (nombre & " " & apellido).Trim.ToLower

                If Not String.IsNullOrWhiteSpace(textoCompleto) Then
                    ' Verifica si el texto de búsqueda está contenido en alguna de las celdas
                    If textoCompleto.Contains(searchText) Then
                        row.Visible = True                  ' Muestra la fila si hay coincidencia
                    Else
                        row.Visible = False                 ' Oculta la fila si no hay coincidencia
                    End If

                End If

            Next
        End If

    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_buscadorEspe.TextChanged

        'Buscadores por Especialidad 

        If String.IsNullOrEmpty(txt_buscadorEspe.Text) Then
            For Each row As DataGridViewRow In DataGridViewAdmin.Rows
                row.Visible = True
            Next
        Else
            Dim searchText = txt_buscadorEspe.Text.ToLower
            Dim Especialidad = ""

            ' Recorre cada fila del DataGridView
            For Each row As DataGridViewRow In DataGridViewAdmin.Rows
                ' Por cada fila, busca en las celdas "Especialidad"
                Dim nombreCelda = row.Cells("Especialidad")

                ' Obtiene el valor de la celda "Especialidad" de forma segura
                If nombreCelda.Value IsNot Nothing Then
                    Especialidad = nombreCelda.Value.ToString.Trim.ToLower
                End If

                If Not String.IsNullOrWhiteSpace(Especialidad) Then
                    ' Verifica si el texto de búsqueda está contenido en alguna de las celdas
                    If Especialidad.Contains(searchText) Then
                        row.Visible = True              ' Muestra la fila si hay coincidencia
                    Else
                        row.Visible = False             ' Oculta la fila si no hay coincidencia
                    End If

                End If

            Next
        End If

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        ' Leo el elemento seleccionado y convertirlo a String.
        Dim valorSeleccionado = Combobox_admin.SelectedItem.ToString()

        Select Case valorSeleccionado
            Case "Usuarios"

                Dim id As String = txt_id.Text
                Dim nombre As String = admin_texto1.Text
                Dim contrasena As String = admin_texto2.Text
                Dim rol As String = admin_combo.Text


                If String.IsNullOrWhiteSpace(admin_texto1.Text) Then
                    ' El TextBox está vacío, o solo contiene espacios.
                    MessageBox.Show("El campo de texto está vacío o solo contiene espacios en blanco.")

                End If

                Dim rutaArchivo = "usuarios.txt"
                Try
                    Dim lineas As String() = File.ReadAllLines(rutaArchivo)
                    Dim cabecera As String = lineas(0)
                    Dim cuerpo As String() = lineas.Skip(1).ToArray()
                    Dim haycambios As Boolean = False


                    For i As Integer = 1 To lineas.Length - 1
                        Dim datos = lineas(i).Split(","c)
                        If id = datos(0) Then
                            lineas(i) = String.Join(",", id, nombre, contrasena, rol)
                            haycambios = True
                        End If

                    Next

                    If haycambios Then

                        File.WriteAllLines(rutaArchivo, lineas)
                        CargarDatosDataGridview(rutaArchivo)
                        LimpiarAdmintrador(Me)
                        btnGuardar.Visible = False
                    End If

                Catch ex As Exception

                End Try

                'ActualizarArchivo(rutaArchivo)
            Case "Doctores"

                Dim id As String = txt_id.Text
                Dim texto1 As String = admin_texto1.Text
                Dim texto2 As String = admin_texto2.Text
                Dim texto3 As String = admin_texto3.Text
                Dim texto4 As String = admin_combo.Text

                Dim rutaArchivo = "doctores.csv"

                Try
                    Dim lineas As String() = File.ReadAllLines(rutaArchivo)
                    Dim cabecera As String = lineas(0)
                    Dim cuerpo As String() = lineas.Skip(1).ToArray()
                    Dim haycambios As Boolean = False

                    For i As Integer = 1 To lineas.Length - 1
                        Dim datos = lineas(i).Split(","c)
                        If id = datos(0) Then
                            Dim itemsSeleccionados As String() = Chboxad.CheckedItems.Cast(Of String)().ToArray()
                            Dim resultado As String = String.Join("/", itemsSeleccionados)
                            lineas(i) = String.Join(",", id, texto1, texto2, texto3, resultado)
                            haycambios = True

                        End If

                    Next

                    If haycambios Then

                        File.WriteAllLines(rutaArchivo, lineas)

                        CargarDatosDataGridview(rutaArchivo)
                        LimpiarAdmintrador(Me)
                        btnGuardar.Visible = False
                    End If
                Catch ex As Exception

                End Try
        End Select



    End Sub


End Class