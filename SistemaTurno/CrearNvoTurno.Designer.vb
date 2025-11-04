<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearNvoTurno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnCancelar = New Button()
        btnGuardar = New Button()
        dtpHora = New DateTimePicker()
        cmbAsistencia = New ComboBox()
        lblHora = New Label()
        lblFecha = New Label()
        lblAsistencia = New Label()
        txtTelefono = New TextBox()
        lblTelefono = New Label()
        lblPaciente = New Label()
        Label1 = New Label()
        cmbEspecialidad = New ComboBox()
        btnAgregar = New Button()
        Txt_ApellidoNombre = New TextBox()
        cmbHora = New ComboBox()
        lblProfesional = New Label()
        cmbProfesional = New ComboBox()
        lblDNI = New Label()
        txtDNI = New TextBox()
        Label2 = New Label()
        lblDiasTrabajo1 = New Label()
        btnAyuda = New Button()
        SuspendLayout()
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(616, 588)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(94, 29)
        btnCancelar.TabIndex = 19
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(801, 588)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 29)
        btnGuardar.TabIndex = 20
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' dtpHora
        ' 
        dtpHora.Location = New Point(565, 473)
        dtpHora.Name = "dtpHora"
        dtpHora.Size = New Size(292, 27)
        dtpHora.TabIndex = 16
        ' 
        ' cmbAsistencia
        ' 
        cmbAsistencia.FormattingEnabled = True
        cmbAsistencia.Items.AddRange(New Object() {"Consulta", "Estudio"})
        cmbAsistencia.Location = New Point(565, 275)
        cmbAsistencia.Name = "cmbAsistencia"
        cmbAsistencia.Size = New Size(292, 28)
        cmbAsistencia.TabIndex = 8
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.ForeColor = Color.Black
        lblHora.Location = New Point(389, 521)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(42, 20)
        lblHora.TabIndex = 17
        lblHora.Text = "Hora"
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.ForeColor = Color.Black
        lblFecha.Location = New Point(389, 480)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(47, 20)
        lblFecha.TabIndex = 15
        lblFecha.Text = "Fecha"
        ' 
        ' lblAsistencia
        ' 
        lblAsistencia.AutoSize = True
        lblAsistencia.ForeColor = Color.Black
        lblAsistencia.Location = New Point(389, 275)
        lblAsistencia.Name = "lblAsistencia"
        lblAsistencia.Size = New Size(75, 20)
        lblAsistencia.TabIndex = 7
        lblAsistencia.Text = "Asistencia"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(565, 235)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(292, 27)
        txtTelefono.TabIndex = 6
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.ForeColor = Color.Black
        lblTelefono.Location = New Point(389, 235)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(67, 20)
        lblTelefono.TabIndex = 5
        lblTelefono.Text = "Teléfono"
        ' 
        ' lblPaciente
        ' 
        lblPaciente.AutoSize = True
        lblPaciente.ForeColor = Color.Black
        lblPaciente.Location = New Point(389, 155)
        lblPaciente.Name = "lblPaciente"
        lblPaciente.Size = New Size(136, 20)
        lblPaciente.TabIndex = 0
        lblPaciente.Text = "Apellido y Nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(389, 315)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 20)
        Label1.TabIndex = 9
        Label1.Text = "Especialidad"
        ' 
        ' cmbEspecialidad
        ' 
        cmbEspecialidad.FormattingEnabled = True
        cmbEspecialidad.Items.AddRange(New Object() {"Seleccionar ", "Estudio Medicina Familiar", "Pediatría", "Ginecología y Obstetricia", "Cardiología", "Dermatología", "Neumología", "Neurología", "Urología", "Oftalmología"})
        cmbEspecialidad.Location = New Point(565, 315)
        cmbEspecialidad.Name = "cmbEspecialidad"
        cmbEspecialidad.Size = New Size(292, 28)
        cmbEspecialidad.TabIndex = 10
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(887, 154)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(94, 29)
        btnAgregar.TabIndex = 2
        btnAgregar.Text = "+ Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' Txt_ApellidoNombre
        ' 
        Txt_ApellidoNombre.Location = New Point(565, 155)
        Txt_ApellidoNombre.Name = "Txt_ApellidoNombre"
        Txt_ApellidoNombre.Size = New Size(292, 27)
        Txt_ApellidoNombre.TabIndex = 1
        ' 
        ' cmbHora
        ' 
        cmbHora.FormattingEnabled = True
        cmbHora.Location = New Point(723, 518)
        cmbHora.Name = "cmbHora"
        cmbHora.Size = New Size(134, 28)
        cmbHora.TabIndex = 18
        ' 
        ' lblProfesional
        ' 
        lblProfesional.AutoSize = True
        lblProfesional.ForeColor = Color.Black
        lblProfesional.Location = New Point(389, 355)
        lblProfesional.Name = "lblProfesional"
        lblProfesional.Size = New Size(83, 20)
        lblProfesional.TabIndex = 11
        lblProfesional.Text = "Profesional"
        ' 
        ' cmbProfesional
        ' 
        cmbProfesional.FormattingEnabled = True
        cmbProfesional.Items.AddRange(New Object() {"Seleccionar ", "Estudio Medicina Familiar", "Pediatría", "Ginecología y Obstetricia", "Cardiología", "Dermatología", "Neumología", "Neurología", "Urología", "Oftalmología"})
        cmbProfesional.Location = New Point(565, 355)
        cmbProfesional.Name = "cmbProfesional"
        cmbProfesional.Size = New Size(292, 28)
        cmbProfesional.TabIndex = 12
        ' 
        ' lblDNI
        ' 
        lblDNI.AutoSize = True
        lblDNI.ForeColor = Color.Black
        lblDNI.Location = New Point(389, 195)
        lblDNI.Name = "lblDNI"
        lblDNI.Size = New Size(35, 20)
        lblDNI.TabIndex = 3
        lblDNI.Text = "DNI"
        ' 
        ' txtDNI
        ' 
        txtDNI.Location = New Point(565, 195)
        txtDNI.Name = "txtDNI"
        txtDNI.Size = New Size(292, 27)
        txtDNI.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(389, 395)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 20)
        Label2.TabIndex = 13
        Label2.Text = "Ver días laborales"
        ' 
        ' lblDiasTrabajo1
        ' 
        lblDiasTrabajo1.ForeColor = SystemColors.ButtonHighlight
        lblDiasTrabajo1.Location = New Point(565, 395)
        lblDiasTrabajo1.MaximumSize = New Size(250, 0)
        lblDiasTrabajo1.Name = "lblDiasTrabajo1"
        lblDiasTrabajo1.Size = New Size(250, 60)
        lblDiasTrabajo1.TabIndex = 14
        ' 
        ' btnAyuda
        ' 
        btnAyuda.Location = New Point(431, 588)
        btnAyuda.Name = "btnAyuda"
        btnAyuda.Size = New Size(94, 29)
        btnAyuda.TabIndex = 21
        btnAyuda.Text = "❓ Ayuda"
        btnAyuda.UseVisualStyleBackColor = True
        ' 
        ' CrearNvoTurno
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1364, 756)
        Controls.Add(btnAyuda)
        Controls.Add(lblDiasTrabajo1)
        Controls.Add(Label2)
        Controls.Add(txtDNI)
        Controls.Add(lblDNI)
        Controls.Add(cmbProfesional)
        Controls.Add(lblProfesional)
        Controls.Add(cmbHora)
        Controls.Add(Txt_ApellidoNombre)
        Controls.Add(btnAgregar)
        Controls.Add(cmbEspecialidad)
        Controls.Add(dtpHora)
        Controls.Add(Label1)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(cmbAsistencia)
        Controls.Add(lblHora)
        Controls.Add(lblFecha)
        Controls.Add(lblAsistencia)
        Controls.Add(txtTelefono)
        Controls.Add(lblTelefono)
        Controls.Add(lblPaciente)
        FormBorderStyle = FormBorderStyle.None
        Name = "CrearNvoTurno"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistema de Turnos - Crear Nuevo Turno"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dtpHora As DateTimePicker
    'Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cmbAsistencia As ComboBox
    Friend WithEvents lblHora As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblAsistencia As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblPaciente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbEspecialidad As ComboBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Txt_ApellidoNombre As TextBox
    Friend WithEvents cmbHora As ComboBox
    Friend WithEvents lblProfesional As Label
    Friend WithEvents cmbProfesional As ComboBox
    Friend WithEvents lblDNI As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents cmbPaciente As ComboBox
    Friend WithEvents ComboHorarios As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblDiasTrabajo1 As Label
    Friend WithEvents btnAyuda As Button
End Class
