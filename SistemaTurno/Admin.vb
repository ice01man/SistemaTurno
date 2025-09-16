Public Class Admin

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim seleccion As String = ComboBox1.SelectedItem.ToString()
        MsgBox("Seleccionaste: " & seleccion)

        Select Case seleccion
            Case "Usuarios"
                Dim rutaArchivo As String = "usuarios.txt"
                DataGridViewAdmin.Rows.Clear()

                If My.Computer.FileSystem.FileExists(rutaArchivo) Then
                    Try
                        ' Leer todas las líneas del archivo
                        Dim lineas As String() = My.Computer.FileSystem.ReadAllText(rutaArchivo).Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)

                        ' Recorrer cada línea del archivo
                        For Each linea As String In lineas
                            ' Separar los datos por la coma
                            Dim datos() As String = linea.Split(","c)

                            If datos.Length >= 3 Then ' Asegurarse de que la línea tiene todos los campos necesarios
                                ' Agregar una nueva fila al DataGridView con los datos de la línea
                                DataGridViewAdmin.Rows.Add(datos(0), datos(1), datos(2))

                            End If
                        Next
                    Catch ex As Exception
                        MessageBox.Show("Ocurrió un error al cargar los turnos en el DataGridView: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If

            Case "Pantalla"
                MsgBox("Seleccionaste: " & seleccion)
            Case "Colores"
                MsgBox("Seleccionaste: " & seleccion)
            Case Else
                ' Manejar un caso en el que la selección no coincide con lo esperado.
                ' Por ejemplo, puedes mostrar un mensaje de error o no hacer nada.
                MsgBox("Selección no válida.", MsgBoxStyle.Exclamation, "Error")
                Exit Sub ' Salir de la subrutina para no continuar.
        End Select




    End Sub

    Private Sub DataGridViewAdmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewAdmin.CellContentClick

    End Sub

    Private Sub DataGridViewAdmin_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewAdmin.CellMouseDoubleClick
        If e.RowIndex >= 0 Then

            ' 1. Obtener el valor de la celda clicada
            Dim valorDeLaCelda As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()
            Dim textBox_usuario = admin_usuario
            Dim textBox_contrasena = admin_contrasena
            Dim textBox_combo = admin_combo

            ' 2. Acceder a otros valores de la misma fila (útil para obtener IDs u otros datos)
            ' Si la primera columna contiene un ID, puedes leerlo así:
            Dim idDeLaFila0 As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(0).Value.ToString()
            Dim idDeLaFila1 As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(1).Value.ToString()
            Dim idDeLaFila2 As String = DataGridViewAdmin.Rows(e.RowIndex).Cells(2).Value.ToString()

            textBox_usuario.Text = idDeLaFila0
            textBox_contrasena.Text = idDeLaFila1
            textBox_combo.Text = idDeLaFila2

            'MsgBox("El ID de la fila es: " & idDeLaFila1, )

        End If


    End Sub
End Class