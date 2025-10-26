<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pacientes
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.InfoPaciente = New System.Windows.Forms.GroupBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PaclblCredencial = New System.Windows.Forms.Label()
        Me.PaclblTelefono = New System.Windows.Forms.Label()
        Me.PacLblApellido = New System.Windows.Forms.Label()
        Me.PacLblNombre = New System.Windows.Forms.Label()
        Me.TextTelefono = New System.Windows.Forms.TextBox()
        Me.TextFechaNac = New System.Windows.Forms.TextBox()
        Me.TextDNI = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.TextApellido = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextNCredencial = New System.Windows.Forms.TextBox()
        Me.TextOSocial = New System.Windows.Forms.TextBox()
        Me.DataGridPacientes = New System.Windows.Forms.DataGridView()
        Me.DGBTurnosPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGBServicios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGBDIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBuscar = New System.Windows.Forms.TextBox()
        Me.PacBuscador = New System.Windows.Forms.GroupBox()
        Me.brnVolver = New System.Windows.Forms.Button()
        Me.InfoPaciente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PacBuscador.SuspendLayout()
        Me.SuspendLayout()
        '
        'InfoPaciente
        '
        Me.InfoPaciente.Controls.Add(Me.BtnAgregar)
        Me.InfoPaciente.Controls.Add(Me.Label2)
        Me.InfoPaciente.Controls.Add(Me.TextEmail)
        Me.InfoPaciente.Controls.Add(Me.Label1)
        Me.InfoPaciente.Controls.Add(Me.PaclblCredencial)
        Me.InfoPaciente.Controls.Add(Me.PaclblTelefono)
        Me.InfoPaciente.Controls.Add(Me.PacLblApellido)
        Me.InfoPaciente.Controls.Add(Me.PacLblNombre)
        Me.InfoPaciente.Controls.Add(Me.TextTelefono)
        Me.InfoPaciente.Controls.Add(Me.TextFechaNac)
        Me.InfoPaciente.Controls.Add(Me.TextDNI)
        Me.InfoPaciente.Controls.Add(Me.TextNombre)
        Me.InfoPaciente.Controls.Add(Me.TextApellido)
        Me.InfoPaciente.ForeColor = System.Drawing.Color.Black
        Me.InfoPaciente.Location = New System.Drawing.Point(72, 102)
        Me.InfoPaciente.Name = "InfoPaciente"
        Me.InfoPaciente.Size = New System.Drawing.Size(509, 574)
        Me.InfoPaciente.TabIndex = 0
        Me.InfoPaciente.TabStop = False
        Me.InfoPaciente.Text = "Info del Paciente"
        '
        'BtnAgregar
        '
        Me.BtnAgregar.BackColor = System.Drawing.Color.CadetBlue
        Me.BtnAgregar.ForeColor = System.Drawing.Color.White
        Me.BtnAgregar.Location = New System.Drawing.Point(347, 460)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(104, 51)
        Me.BtnAgregar.TabIndex = 13
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(61, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "DNI"
        '
        'TextEmail
        '
        Me.TextEmail.Location = New System.Drawing.Point(202, 383)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(249, 27)
        Me.TextEmail.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(61, 263)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "FECHA NAC"
        '
        'PaclblCredencial
        '
        Me.PaclblCredencial.AutoSize = True
        Me.PaclblCredencial.ForeColor = System.Drawing.Color.Black
        Me.PaclblCredencial.Location = New System.Drawing.Point(61, 390)
        Me.PaclblCredencial.Name = "PaclblCredencial"
        Me.PaclblCredencial.Size = New System.Drawing.Size(51, 20)
        Me.PaclblCredencial.TabIndex = 8
        Me.PaclblCredencial.Text = "EMAIL"
        '
        'PaclblTelefono
        '
        Me.PaclblTelefono.AutoSize = True
        Me.PaclblTelefono.ForeColor = System.Drawing.Color.Black
        Me.PaclblTelefono.Location = New System.Drawing.Point(61, 326)
        Me.PaclblTelefono.Name = "PaclblTelefono"
        Me.PaclblTelefono.Size = New System.Drawing.Size(80, 20)
        Me.PaclblTelefono.TabIndex = 7
        Me.PaclblTelefono.Text = "TELEFONO"
        '
        'PacLblApellido
        '
        Me.PacLblApellido.AutoSize = True
        Me.PacLblApellido.ForeColor = System.Drawing.Color.Black
        Me.PacLblApellido.Location = New System.Drawing.Point(61, 78)
        Me.PacLblApellido.Name = "PacLblApellido"
        Me.PacLblApellido.Size = New System.Drawing.Size(75, 20)
        Me.PacLblApellido.TabIndex = 6
        Me.PacLblApellido.Text = "APELLIDO"
        '
        'PacLblNombre
        '
        Me.PacLblNombre.AutoSize = True
        Me.PacLblNombre.ForeColor = System.Drawing.Color.Black
        Me.PacLblNombre.Location = New System.Drawing.Point(61, 150)
        Me.PacLblNombre.Name = "PacLblNombre"
        Me.PacLblNombre.Size = New System.Drawing.Size(70, 20)
        Me.PacLblNombre.TabIndex = 5
        Me.PacLblNombre.Text = "NOMBRE"
        '
        'TextTelefono
        '
        Me.TextTelefono.Location = New System.Drawing.Point(202, 326)
        Me.TextTelefono.Name = "TextTelefono"
        Me.TextTelefono.Size = New System.Drawing.Size(249, 27)
        Me.TextTelefono.TabIndex = 4
        '
        'TextFechaNac
        '
        Me.TextFechaNac.Location = New System.Drawing.Point(202, 260)
        Me.TextFechaNac.Name = "TextFechaNac"
        Me.TextFechaNac.Size = New System.Drawing.Size(249, 27)
        Me.TextFechaNac.TabIndex = 3
        '
        'TextDNI
        '
        Me.TextDNI.Location = New System.Drawing.Point(202, 201)
        Me.TextDNI.Name = "TextDNI"
        Me.TextDNI.Size = New System.Drawing.Size(249, 27)
        Me.TextDNI.TabIndex = 2
        '
        'TextNombre
        '
        Me.TextNombre.Location = New System.Drawing.Point(202, 143)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(249, 27)
        Me.TextNombre.TabIndex = 1
        '
        'TextApellido
        '
        Me.TextApellido.Location = New System.Drawing.Point(202, 78)
        Me.TextApellido.Name = "TextApellido"
        Me.TextApellido.Size = New System.Drawing.Size(249, 27)
        Me.TextApellido.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextNCredencial)
        Me.GroupBox1.Controls.Add(Me.TextOSocial)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(617, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 228)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Obra Social"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(61, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "N° CREDENCIAL"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(61, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "O. SOCIAL"
        '
        'TextNCredencial
        '
        Me.TextNCredencial.Location = New System.Drawing.Point(202, 143)
        Me.TextNCredencial.Name = "TextNCredencial"
        Me.TextNCredencial.Size = New System.Drawing.Size(249, 27)
        Me.TextNCredencial.TabIndex = 1
        '
        'TextOSocial
        '
        Me.TextOSocial.Location = New System.Drawing.Point(202, 78)
        Me.TextOSocial.Name = "TextOSocial"
        Me.TextOSocial.Size = New System.Drawing.Size(249, 27)
        Me.TextOSocial.TabIndex = 0
        '
        'DataGridPacientes
        '
        Me.DataGridPacientes.BackgroundColor = System.Drawing.Color.DarkGray
        Me.DataGridPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPacientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGBTurnosPaciente, Me.DGBServicios, Me.DGBDIA})
        Me.DataGridPacientes.GridColor = System.Drawing.Color.Black
        Me.DataGridPacientes.Location = New System.Drawing.Point(617, 365)
        Me.DataGridPacientes.Name = "DataGridPacientes"
        Me.DataGridPacientes.ReadOnly = True
        Me.DataGridPacientes.RowHeadersWidth = 51
        Me.DataGridPacientes.Size = New System.Drawing.Size(509, 311)
        Me.DataGridPacientes.TabIndex = 14
        '
        'DGBTurnosPaciente
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGBTurnosPaciente.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGBTurnosPaciente.HeaderText = "Turnos"
        Me.DGBTurnosPaciente.MinimumWidth = 6
        Me.DGBTurnosPaciente.Name = "DGBTurnosPaciente"
        Me.DGBTurnosPaciente.ReadOnly = True
        Me.DGBTurnosPaciente.Width = 125
        '
        'DGBServicios
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DGBServicios.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGBServicios.HeaderText = "Servicios"
        Me.DGBServicios.MinimumWidth = 6
        Me.DGBServicios.Name = "DGBServicios"
        Me.DGBServicios.ReadOnly = True
        Me.DGBServicios.Width = 125
        '
        'DGBDIA
        '
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DGBDIA.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGBDIA.HeaderText = "Día Turno"
        Me.DGBDIA.MinimumWidth = 6
        Me.DGBDIA.Name = "DGBDIA"
        Me.DGBDIA.ReadOnly = True
        Me.DGBDIA.Width = 125
        '
        'TextBuscar
        '
        Me.TextBuscar.Location = New System.Drawing.Point(23, 31)
        Me.TextBuscar.Name = "TextBuscar"
        Me.TextBuscar.Size = New System.Drawing.Size(408, 27)
        Me.TextBuscar.TabIndex = 15
        '
        'PacBuscador
        '
        Me.PacBuscador.Controls.Add(Me.TextBuscar)
        Me.PacBuscador.Location = New System.Drawing.Point(72, 13)
        Me.PacBuscador.Name = "PacBuscador"
        Me.PacBuscador.Size = New System.Drawing.Size(753, 84)
        Me.PacBuscador.TabIndex = 18
        Me.PacBuscador.TabStop = False
        Me.PacBuscador.Text = "Buscador de Pacientes"
        '
        'brnVolver
        '
        Me.brnVolver.BackColor = System.Drawing.Color.CadetBlue
        Me.brnVolver.ForeColor = System.Drawing.Color.White
        Me.brnVolver.Location = New System.Drawing.Point(861, 32)
        Me.brnVolver.Name = "brnVolver"
        Me.brnVolver.Size = New System.Drawing.Size(265, 51)
        Me.brnVolver.TabIndex = 19
        Me.brnVolver.Text = "VOLVER AL MENÚ PRINCIPAL"
        Me.brnVolver.UseVisualStyleBackColor = False
        '
        'Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1364, 756)
        Me.Controls.Add(Me.brnVolver)
        Me.Controls.Add(Me.PacBuscador)
        Me.Controls.Add(Me.DataGridPacientes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.InfoPaciente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pacientes"
        Me.InfoPaciente.ResumeLayout(False)
        Me.InfoPaciente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PacBuscador.ResumeLayout(False)
        Me.PacBuscador.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InfoPaciente As GroupBox
    Friend WithEvents PacLblNombre As Label
    Friend WithEvents TextTelefono As TextBox
    Friend WithEvents TextFechaNac As TextBox
    Friend WithEvents TextDNI As TextBox
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents TextApellido As TextBox
    Friend WithEvents PaclblCredencial As Label
    Friend WithEvents PaclblTelefono As Label
    Friend WithEvents PacLblApellido As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextNCredencial As TextBox
    Friend WithEvents TextOSocial As TextBox
    Friend WithEvents DataGridPacientes As DataGridView
    Friend WithEvents TextBuscar As TextBox
    Friend WithEvents PacBuscador As GroupBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents DGBTurnosPaciente As DataGridViewTextBoxColumn
    Friend WithEvents DGBServicios As DataGridViewTextBoxColumn
    Friend WithEvents DGBDIA As DataGridViewTextBoxColumn
    Friend WithEvents brnVolver As Button

End Class
