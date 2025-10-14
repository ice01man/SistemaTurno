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
        SuspendLayout()
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Location = New Point(155, 391)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(94, 29)
        btnCancelar.TabIndex = 28
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(586, 391)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(94, 29)
        btnGuardar.TabIndex = 27
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' dtpHora
        ' 
        dtpHora.Location = New Point(331, 293)
        dtpHora.Name = "dtpHora"
        dtpHora.Size = New Size(292, 27)
        dtpHora.TabIndex = 25
        ' 
        ' cmbAsistencia
        ' 
        cmbAsistencia.FormattingEnabled = True
        cmbAsistencia.Items.AddRange(New Object() {"Consulta", "Estudio"})
        cmbAsistencia.Location = New Point(331, 150)
        cmbAsistencia.Name = "cmbAsistencia"
        cmbAsistencia.Size = New Size(292, 28)
        cmbAsistencia.TabIndex = 24
        ' 
        ' lblHora
        ' 
        lblHora.AutoSize = True
        lblHora.Location = New Point(155, 344)
        lblHora.Name = "lblHora"
        lblHora.Size = New Size(42, 20)
        lblHora.TabIndex = 23
        lblHora.Text = "Hora"
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Location = New Point(155, 293)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(47, 20)
        lblFecha.TabIndex = 22
        lblFecha.Text = "Fecha"
        ' 
        ' lblAsistencia
        ' 
        lblAsistencia.AutoSize = True
        lblAsistencia.Location = New Point(155, 153)
        lblAsistencia.Name = "lblAsistencia"
        lblAsistencia.Size = New Size(75, 20)
        lblAsistencia.TabIndex = 21
        lblAsistencia.Text = "Asistencia"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(331, 117)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(292, 27)
        txtTelefono.TabIndex = 20
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(155, 120)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(67, 20)
        lblTelefono.TabIndex = 19
        lblTelefono.Text = "Teléfono"
        ' 
        ' lblPaciente
        ' 
        lblPaciente.AutoSize = True
        lblPaciente.Location = New Point(155, 47)
        lblPaciente.Name = "lblPaciente"
        lblPaciente.Size = New Size(136, 20)
        lblPaciente.TabIndex = 17
        lblPaciente.Text = "Apellido y Nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(155, 207)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 20)
        Label1.TabIndex = 29
        Label1.Text = "Especialidad"
        ' 
        ' cmbEspecialidad
        ' 
        cmbEspecialidad.FormattingEnabled = True
        cmbEspecialidad.Items.AddRange(New Object() {"Seleccionar ", "Estudio Medicina Familiar", "Pediatría", "Ginecología y Obstetricia", "Cardiología", "Dermatología", "Neumología", "Neurología", "Urología", "Oftalmología"})
        cmbEspecialidad.Location = New Point(331, 201)
        cmbEspecialidad.Name = "cmbEspecialidad"
        cmbEspecialidad.Size = New Size(292, 28)
        cmbEspecialidad.TabIndex = 30
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New Point(651, 44)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(94, 29)
        btnAgregar.TabIndex = 31
        btnAgregar.Text = "+ Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' Txt_ApellidoNombre
        ' 
        Txt_ApellidoNombre.Location = New Point(331, 44)
        Txt_ApellidoNombre.Name = "Txt_ApellidoNombre"
        Txt_ApellidoNombre.Size = New Size(292, 27)
        Txt_ApellidoNombre.TabIndex = 32
        ' 
        ' cmbHora
        ' 
        cmbHora.FormattingEnabled = True
        cmbHora.Location = New Point(331, 344)
        cmbHora.Name = "cmbHora"
        cmbHora.Size = New Size(151, 28)
        cmbHora.TabIndex = 33
        ' 
        ' lblProfesional
        ' 
        lblProfesional.AutoSize = True
        lblProfesional.Location = New Point(155, 248)
        lblProfesional.Name = "lblProfesional"
        lblProfesional.Size = New Size(83, 20)
        lblProfesional.TabIndex = 34
        lblProfesional.Text = "Profesional"
        ' 
        ' cmbProfesional
        ' 
        cmbProfesional.FormattingEnabled = True
        cmbProfesional.Items.AddRange(New Object() {"Seleccionar ", "Estudio Medicina Familiar", "Pediatría", "Ginecología y Obstetricia", "Cardiología", "Dermatología", "Neumología", "Neurología", "Urología", "Oftalmología"})
        cmbProfesional.Location = New Point(331, 245)
        cmbProfesional.Name = "cmbProfesional"
        cmbProfesional.Size = New Size(292, 28)
        cmbProfesional.TabIndex = 35
        ' 
        ' lblDNI
        ' 
        lblDNI.AutoSize = True
        lblDNI.Location = New Point(155, 85)
        lblDNI.Name = "lblDNI"
        lblDNI.Size = New Size(35, 20)
        lblDNI.TabIndex = 36
        lblDNI.Text = "DNI"
        ' 
        ' txtDNI
        ' 
        txtDNI.Location = New Point(331, 85)
        txtDNI.Name = "txtDNI"
        txtDNI.Size = New Size(194, 27)
        txtDNI.TabIndex = 37
        ' 
        ' CrearNvoTurno
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 453)
        Controls.Add(txtDNI)
        Controls.Add(lblDNI)
        Controls.Add(cmbProfesional)
        Controls.Add(lblProfesional)
        Controls.Add(cmbHora)
        Controls.Add(Txt_ApellidoNombre)
        Controls.Add(btnAgregar)
        Controls.Add(cmbEspecialidad)
        Controls.Add(Label1)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(dtpHora)
        Controls.Add(cmbAsistencia)
        Controls.Add(lblHora)
        Controls.Add(lblFecha)
        Controls.Add(lblAsistencia)
        Controls.Add(txtTelefono)
        Controls.Add(lblTelefono)
        Controls.Add(lblPaciente)
        Name = "CrearNvoTurno"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistema de Turnos - Crear Nuevo Turno"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dtpHora As DateTimePicker
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
End Class
