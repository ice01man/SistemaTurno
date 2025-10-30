Public Class Form1

    Public Function ValidarCredenciales(ByVal usuario As String, ByVal password As String) As String
        Try
            ' 1. Lee todas las líneas del archivo de usuarios
            Dim rutaArchivo As String = System.IO.Path.Combine(Application.StartupPath, "\usuarios.txt")

            Dim lineas As String() = System.IO.File.ReadAllLines(".\usuarios.txt")

            ' 2. Recorre cada línea del archivo
            For Each linea As String In lineas
                ' Divide la línea en un array usando la coma como separador
                Dim datos As String() = linea.Split(","c)

                ' Verifica que la línea tenga 2 partes (usuario y contraseña)
                If datos.Length >= 4 Then

                    If datos(1).Trim().Equals(usuario.Trim(), StringComparison.OrdinalIgnoreCase) AndAlso
                        datos(2).Trim().Equals(password.Trim(), StringComparison.Ordinal) Then

                        ' Credenciales correctas, devolvemos el Rol
                        Dim rol As String = datos(3).Trim()
                        Return rol

                    End If
                End If
            Next

            ' Si el bucle termina y no se encontraron las credenciales, devuelve False
            Return String.Empty

        Catch ex As System.IO.FileNotFoundException
            ' Maneja el error si el archivo no se encuentra
            MsgBox("El archivo de usuarios no se encuentra. Verifique la ruta.", MsgBoxStyle.Critical)
            Return String.Empty
        Catch ex As Exception
            ' Maneja otros posibles errores
            MsgBox("Ocurrió un error al leer el archivo de usuarios: " & ex.Message, MsgBoxStyle.Critical)
            Return String.Empty
        End Try
    End Function

    Public Sub MostrarFormulario(ByVal nuevoForm As Form)
        Dim menuTemp As Control = Nothing
        For Each ctrl As Control In Me.ToolStripContainer1.ContentPanel.Controls
            If TypeOf ctrl Is MenuStrip Then
                Me.ToolStripContainer1.ContentPanel.Controls.Remove(ctrl)
                ctrl.Dispose() ' Importante para liberar recursos

                Exit For
            End If
        Next
        nuevoForm.TopLevel = False
        nuevoForm.FormBorderStyle = FormBorderStyle.None
        nuevoForm.Dock = DockStyle.Fill

        Me.ToolStripContainer1.ContentPanel.Controls.Add(nuevoForm)
        nuevoForm.Show()
        nuevoForm.BringToFront() ' Asegura que esté al frente

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim usuarioIngresado As String = LogintxtUsuario.Text
        Dim passwordIngresada As String = LogintxtPassword.Text

        Dim rolObtenido As String = ValidarCredenciales(usuarioIngresado, passwordIngresada)

        'If ValidarCredenciales(usuarioIngresado, passwordIngresada) Then
        If Not String.IsNullOrEmpty(rolObtenido) Then
            ' Las credenciales son correctas
            'MostrarFormulario(New Inicio())
            Dim frmInicio As New Inicio()
            frmInicio.FormPrincipal = Me   ' <<< Aquí se pasa la referencia al principal
            MostrarFormulario(frmInicio)

            ' Habilitar las opciones del menú
            Select Case rolObtenido
                Case "Administrador"
                    MenuInicio.Visible = True
                    MenuPacientes.Visible = True
                    ' MenuTurnos.Visible = True
                    MenuAdmin.Visible = True
                Case "Usuario"
                    MenuInicio.Visible = True
                    MenuPacientes.Visible = True
                    ' MenuTurnos.Visible = True
                    MenuAdmin.Visible = False
                Case Else
                    MenuInicio.Visible = True
                    MenuPacientes.Visible = False
                    ' MenuTurnos.Visible = False
                    MenuAdmin.Visible = False
            End Select



        Else
            ' Las credenciales son incorrectas
            MsgBox("Usuario o contraseña incorrectos.", MsgBoxStyle.Exclamation)
            LogintxtPassword.Clear() ' Limpia el campo de contraseña
            LogintxtUsuario.Focus() ' Devuelve el foco al campo de usuario
        End If

    End Sub

    Private Sub MenuInicio_Click(sender As Object, e As EventArgs) Handles MenuInicio.Click
        Dim frmInicio As New Inicio
        frmInicio.FormPrincipal = Me
        MostrarFormulario(frmInicio)

        'MostrarFormulario(New Inicio())
    End Sub

    Private Sub MenuPacientes_Click(sender As Object, e As EventArgs) Handles MenuPacientes.Click
        Dim frmPacientes As New Pacientes
        frmPacientes.FormPrincipal = Me
        MostrarFormulario(frmPacientes)
    End Sub

    'Private Sub MenuTurnos_Click(sender As Object, e As EventArgs) Handles MenuTurnos.Click
    '    MostrarFormulario(New Turnos())
    'End Sub

    Private Sub MenuAdmin_Click(sender As Object, e As EventArgs) Handles MenuAdmin.Click
        Dim frmAdmin As New Admin
        frmAdmin.FormPrincipal = Me
        MostrarFormulario(frmAdmin)

    End Sub


    Friend Sub AbrirFormularioInterno(frm As Form)
        MostrarFormulario(frm)
    End Sub
    Private Sub ToolStripContainer1_TopToolStripPanel_Click(sender As Object, e As EventArgs) Handles ToolStripContainer1.TopToolStripPanel.Click

    End Sub

End Class
