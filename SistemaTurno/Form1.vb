Public Class Form1

    Public Function ValidarCredenciales(ByVal usuario As String, ByVal password As String) As Boolean
        Try
            ' 1. Lee todas las líneas del archivo de usuarios
            Dim rutaArchivo As String = System.IO.Path.Combine(Application.StartupPath, "\usuarios.txt")

            Dim lineas As String() = System.IO.File.ReadAllLines(".\usuarios.txt")

            ' 2. Recorre cada línea del archivo
            For Each linea As String In lineas
                ' Divide la línea en un array usando la coma como separador
                Dim datos As String() = linea.Split(","c)

                ' Verifica que la línea tenga 2 partes (usuario y contraseña)
                If datos.Length = 2 Then

                    If datos(0).Trim() = usuario.Trim() AndAlso datos(1).Trim() = password.Trim() Then

                        Return True
                    End If
                End If
            Next

            ' Si el bucle termina y no se encontraron las credenciales, devuelve False
            Return False

        Catch ex As System.IO.FileNotFoundException
            ' Maneja el error si el archivo no se encuentra
            MsgBox("El archivo de usuarios no se encuentra. Verifique la ruta.", MsgBoxStyle.Critical)
            Return False
        Catch ex As Exception
            ' Maneja otros posibles errores
            MsgBox("Ocurrió un error al leer el archivo de usuarios: " & ex.Message, MsgBoxStyle.Critical)
            Return False
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
        If ValidarCredenciales(usuarioIngresado, passwordIngresada) Then
            ' Las credenciales son correctas
            Me.ToolStripContainer1.ContentPanel.Controls.Clear()
            Dim frmInicio As New Inicio
            frmInicio.MdiParent = Me
            Me.ToolStripContainer1.ContentPanel.Controls.Add(frmInicio)
            frmInicio.Show()

            ' Habilitar las opciones del menú
            HabilitarMenu()

        Else
            ' Las credenciales son incorrectas
            MsgBox("Usuario o contraseña incorrectos.", MsgBoxStyle.Exclamation)
            LogintxtPassword.Clear() ' Limpia el campo de contraseña
            LogintxtUsuario.Focus() ' Devuelve el foco al campo de usuario
        End If

    End Sub

    Private Sub HabilitarMenu()

        ' Aquí los haces visibles o activas su propiedad Enabled.
        MenuInicio.Visible = True
        MenuPacientes.Visible = True
        MenuTurnos.Visible = True


    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs) Handles ToolStripContainer1.ContentPanel.Load

    End Sub
End Class
