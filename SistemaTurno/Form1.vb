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
                If datos.Length = 3 Then

                    If datos(0).Trim() = usuario.Trim() AndAlso datos(1).Trim() = password.Trim() Then
                        Dim rol As String = datos(2).Trim()

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

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuInicio.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmInicio As New Inicio
        frmInicio.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmInicio)
        frmInicio.Show()

    End Sub

    Private Sub PacientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuPacientes.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmPacientes As New Pacientes
        frmPacientes.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmPacientes)
        frmPacientes.Show()
    End Sub

    Private Sub TurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuTurnos.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmTurnos As New Turnos
        frmTurnos.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmTurnos)
        frmTurnos.Show()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim usuarioIngresado As String = LogintxtUsuario.Text
        Dim passwordIngresada As String = LogintxtPassword.Text

        Dim rolObtenido As String = ValidarCredenciales(usuarioIngresado, passwordIngresada)

        'If ValidarCredenciales(usuarioIngresado, passwordIngresada) Then
        If Not String.IsNullOrEmpty(rolObtenido) Then
            ' Las credenciales son correctas
            Me.ToolStripContainer1.ContentPanel.Controls.Clear()
            Dim frmInicio As New Inicio
            frmInicio.MdiParent = Me
            Me.ToolStripContainer1.ContentPanel.Controls.Add(frmInicio)
            frmInicio.Show()

            ' Habilitar las opciones del menú
            Select Case rolObtenido
                Case "Administrador"
                    MenuInicio.Visible = True
                    MenuPacientes.Visible = True
                    MenuTurnos.Visible = True
                    MenuAdmin.Visible = True
                Case "Usuario"
                    MenuInicio.Visible = True
                    MenuPacientes.Visible = True
                    MenuTurnos.Visible = True
                    MenuAdmin.Visible = False
                Case Else
                    MenuInicio.Visible = True
                    MenuPacientes.Visible = False
                    MenuTurnos.Visible = False
                    MenuAdmin.Visible = False
            End Select



        Else
            ' Las credenciales son incorrectas
            MsgBox("Usuario o contraseña incorrectos.", MsgBoxStyle.Exclamation)
            LogintxtPassword.Clear() ' Limpia el campo de contraseña
            LogintxtUsuario.Focus() ' Devuelve el foco al campo de usuario
        End If

    End Sub


    Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuAdmin.Click
        Me.ToolStripContainer1.ContentPanel.Controls.Clear()
        Dim frmAdmin As New Admin
        frmAdmin.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmAdmin)
        frmAdmin.Show()
    End Sub

    Private Sub LogintxtUsuario_TextChanged(sender As Object, e As EventArgs) Handles LogintxtUsuario.TextChanged

    End Sub
End Class
