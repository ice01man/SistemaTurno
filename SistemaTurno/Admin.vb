Imports System.Net.Http
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class Admin
    Private dt As New DataTable()
    Private dv As New DataView()

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim seleccion = ComboBox1.SelectedItem.ToString


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

                DataGridViewAdmin.Columns.Clear()

                If My.Computer.FileSystem.FileExists(rutaArchivo) Then
                    Try
                        ' Leer todas las líneas del archivo
                        Dim lineas = My.Computer.FileSystem.ReadAllText(rutaArchivo).Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
                        Dim contador = 0

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
                            If datos.Length >= 3 Then                               ' Asegurarse de que la línea tiene todos los campos necesarios

                                DataGridViewAdmin.Rows.Add(datos(0), datos(1), datos(2), datos(3))

                            End If
                        Next
                    Catch ex As Exception
                        MessageBox.Show("Ocurrió un error al cargar los turnos en el DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

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
                        ' Leer todas las líneas del archivo
                        Dim lineas = My.Computer.FileSystem.ReadAllText(rutaArchivo).Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

                        Dim contador = 0
                        ' Recorrer cada línea del archivo
                        For Each linea In lineas

                            ' Separar los datos por la coma
                            Dim datos = linea.Split(","c)
                            If contador = 0 Then
                                datos = linea.Split(","c)
                                For Each dato In datos
                                    'id,Nombre,Apellido,Especialidad,Dia_Laboral,Horario, Vacaciones, Etc 
                                    Dim coldato As New DataGridViewTextBoxColumn
                                    coldato.HeaderText = dato                   ' El texto que se muestra en el encabezado
                                    coldato.Name = dato                         ' El nombre interno de la columna (útil para referenciarla)
                                    DataGridViewAdmin.Columns.Add(coldato)      ' Agregamos la columna al DataGridView
                                    If dato = "id" Then
                                        coldato.Visible = False
                                    End If
                                Next

                                contador += 1
                                Continue For ' Salta al inicio del siguiente bucle
                            End If

                            If datos.Length >= 2 Then ' Asegurarse de que la línea tiene todos los campos necesarios
                                ' Agregar una nueva fila al DataGridView con los datos de la línea
                                DataGridViewAdmin.Size = New Size(660, 414)
                                DataGridViewAdmin.Rows.Add(datos(0), datos(1), datos(2), datos(3), datos(4))

                            End If
                        Next
                    Catch ex As Exception
                        MessageBox.Show("Ocurrió un error al cargar los turnos en el DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            Case Else

                MsgBox("Selección no válida.", MsgBoxStyle.Exclamation, "Error")
                Exit Sub ' Salir de la subrutina para no continuar.
        End Select




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

            Dim idDeLaFila0 As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim idDeLaFila1 As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(2).Value.ToString()
            Dim idDeLaFila2 As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(3).Value.ToString()

            textBox_texto1.Text = idDeLaFila0
            textBox_texto2.Text = idDeLaFila1
            textBox_texto3.Text = idDeLaFila2

            If (numeroDeColumnas > 4) Then
                Dim idDeLaFila3 As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(4).Value.ToString()
                Dim datos = idDeLaFila3.Split("/"c)

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

            textBox_combo.Text = idDeLaFila2


        End If


    End Sub



    Private Sub txt_buscador_TextChanged(sender As Object, e As EventArgs) Handles txt_buscador.TextChanged
        ' Si el TextBox está vacío, muestra todas las filas
        If String.IsNullOrEmpty(txt_buscador.Text) Then
            For Each row As DataGridViewRow In DataGridViewAdmin.Rows
                row.Visible = True
            Next
        Else
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
                        row.Visible = True ' Muestra la fila si hay coincidencia
                    Else
                        row.Visible = False ' Oculta la fila si no hay coincidencia
                    End If

                End If

            Next
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_buscadorEspe.TextChanged

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
                        row.Visible = True ' Muestra la fila si hay coincidencia
                    Else
                        row.Visible = False ' Oculta la fila si no hay coincidencia
                    End If

                End If

            Next
        End If

    End Sub
End Class