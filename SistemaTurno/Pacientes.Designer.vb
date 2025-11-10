<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pacientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        InfoPaciente = New GroupBox()
        BtnAgregar = New Button()
        Label2 = New Label()
        TextEmail = New TextBox()
        Label1 = New Label()
        PaclblCredencial = New Label()
        PaclblTelefono = New Label()
        PacLblApellido = New Label()
        PacLblNombre = New Label()
        TextTelefono = New TextBox()
        TextFechaNac = New TextBox()
        TextDNI = New TextBox()
        TextNombre = New TextBox()
        TextApellido = New TextBox()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        Label7 = New Label()
        TextNCredencial = New TextBox()
        TextOSocial = New TextBox()
        DataGridPacientes = New DataGridView()
        DGBTurnosPaciente = New DataGridViewTextBoxColumn()
        asistencia = New DataGridViewTextBoxColumn()
        DGBEspecialidad = New DataGridViewTextBoxColumn()
        DGBDIA = New DataGridViewTextBoxColumn()
        TextBuscar = New TextBox()
        PacBuscador = New GroupBox()
        ErrorProvider1 = New ErrorProvider(components)
        ToolTip1 = New ToolTip(components)
        InfoPaciente.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridPacientes, ComponentModel.ISupportInitialize).BeginInit()
        PacBuscador.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' InfoPaciente
        ' 
        InfoPaciente.Controls.Add(BtnAgregar)
        InfoPaciente.Controls.Add(Label2)
        InfoPaciente.Controls.Add(TextEmail)
        InfoPaciente.Controls.Add(Label1)
        InfoPaciente.Controls.Add(PaclblCredencial)
        InfoPaciente.Controls.Add(PaclblTelefono)
        InfoPaciente.Controls.Add(PacLblApellido)
        InfoPaciente.Controls.Add(PacLblNombre)
        InfoPaciente.Controls.Add(TextTelefono)
        InfoPaciente.Controls.Add(TextFechaNac)
        InfoPaciente.Controls.Add(TextDNI)
        InfoPaciente.Controls.Add(TextNombre)
        InfoPaciente.Controls.Add(TextApellido)
        InfoPaciente.ForeColor = Color.Black
        InfoPaciente.Location = New Point(72, 102)
        InfoPaciente.Name = "InfoPaciente"
        InfoPaciente.Size = New Size(509, 574)
        InfoPaciente.TabIndex = 0
        InfoPaciente.TabStop = False
        InfoPaciente.Text = "Info del Paciente"
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.BackColor = Color.CadetBlue
        BtnAgregar.ForeColor = Color.White
        BtnAgregar.Location = New Point(347, 460)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(104, 51)
        BtnAgregar.TabIndex = 13
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(61, 208)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 20)
        Label2.TabIndex = 12
        Label2.Text = "DNI"
        ' 
        ' TextEmail
        ' 
        TextEmail.Location = New Point(202, 383)
        TextEmail.Name = "TextEmail"
        TextEmail.Size = New Size(249, 27)
        TextEmail.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(61, 263)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 20)
        Label1.TabIndex = 9
        Label1.Text = "FECHA NAC"
        ' 
        ' PaclblCredencial
        ' 
        PaclblCredencial.AutoSize = True
        PaclblCredencial.ForeColor = Color.Black
        PaclblCredencial.Location = New Point(61, 390)
        PaclblCredencial.Name = "PaclblCredencial"
        PaclblCredencial.Size = New Size(51, 20)
        PaclblCredencial.TabIndex = 8
        PaclblCredencial.Text = "EMAIL"
        ' 
        ' PaclblTelefono
        ' 
        PaclblTelefono.AutoSize = True
        PaclblTelefono.ForeColor = Color.Black
        PaclblTelefono.Location = New Point(61, 326)
        PaclblTelefono.Name = "PaclblTelefono"
        PaclblTelefono.Size = New Size(80, 20)
        PaclblTelefono.TabIndex = 7
        PaclblTelefono.Text = "TELEFONO"
        ' 
        ' PacLblApellido
        ' 
        PacLblApellido.AutoSize = True
        PacLblApellido.ForeColor = Color.Black
        PacLblApellido.Location = New Point(61, 78)
        PacLblApellido.Name = "PacLblApellido"
        PacLblApellido.Size = New Size(75, 20)
        PacLblApellido.TabIndex = 6
        PacLblApellido.Text = "APELLIDO"
        ' 
        ' PacLblNombre
        ' 
        PacLblNombre.AutoSize = True
        PacLblNombre.ForeColor = Color.Black
        PacLblNombre.Location = New Point(61, 150)
        PacLblNombre.Name = "PacLblNombre"
        PacLblNombre.Size = New Size(70, 20)
        PacLblNombre.TabIndex = 5
        PacLblNombre.Text = "NOMBRE"
        ' 
        ' TextTelefono
        ' 
        TextTelefono.Location = New Point(202, 326)
        TextTelefono.Name = "TextTelefono"
        TextTelefono.Size = New Size(249, 27)
        TextTelefono.TabIndex = 4
        ToolTip1.SetToolTip(TextTelefono, ChrW(8220) & "Ingresar solo números" & ChrW(8221))
        ' 
        ' TextFechaNac
        ' 
        TextFechaNac.Location = New Point(202, 260)
        TextFechaNac.Name = "TextFechaNac"
        TextFechaNac.Size = New Size(249, 27)
        TextFechaNac.TabIndex = 3
        ToolTip1.SetToolTip(TextFechaNac, ChrW(8220) & "Ingresar solo números" & ChrW(8221))
        ' 
        ' TextDNI
        ' 
        TextDNI.Location = New Point(202, 201)
        TextDNI.Name = "TextDNI"
        TextDNI.Size = New Size(249, 27)
        TextDNI.TabIndex = 2
        ToolTip1.SetToolTip(TextDNI, ChrW(8220) & "Ingresar solo números" & ChrW(8221))
        ' 
        ' TextNombre
        ' 
        TextNombre.Location = New Point(202, 143)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(249, 27)
        TextNombre.TabIndex = 1
        ToolTip1.SetToolTip(TextNombre, ChrW(8220) & "Ingresar solo letras" & ChrW(8221))
        ' 
        ' TextApellido
        ' 
        TextApellido.Location = New Point(202, 78)
        TextApellido.Name = "TextApellido"
        TextApellido.Size = New Size(249, 27)
        TextApellido.TabIndex = 0
        ToolTip1.SetToolTip(TextApellido, ChrW(8220) & "Ingresar solo letras" & ChrW(8221))
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TextNCredencial)
        GroupBox1.Controls.Add(TextOSocial)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(617, 102)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(509, 228)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Obra Social"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(61, 146)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 20)
        Label5.TabIndex = 8
        Label5.Text = "N° CREDENCIAL"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(61, 81)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 20)
        Label7.TabIndex = 6
        Label7.Text = "O. SOCIAL"
        ' 
        ' TextNCredencial
        ' 
        TextNCredencial.Location = New Point(202, 143)
        TextNCredencial.Name = "TextNCredencial"
        TextNCredencial.Size = New Size(249, 27)
        TextNCredencial.TabIndex = 1
        ' 
        ' TextOSocial
        ' 
        TextOSocial.Location = New Point(202, 78)
        TextOSocial.Name = "TextOSocial"
        TextOSocial.Size = New Size(249, 27)
        TextOSocial.TabIndex = 0
        ' 
        ' DataGridPacientes
        ' 
        DataGridPacientes.BackgroundColor = Color.DarkGray
        DataGridPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridPacientes.Columns.AddRange(New DataGridViewColumn() {DGBTurnosPaciente, asistencia, DGBEspecialidad, DGBDIA})
        DataGridPacientes.GridColor = Color.Black
        DataGridPacientes.Location = New Point(630, 365)
        DataGridPacientes.Name = "DataGridPacientes"
        DataGridPacientes.ReadOnly = True
        DataGridPacientes.RowHeadersWidth = 51
        DataGridPacientes.Size = New Size(615, 311)
        DataGridPacientes.TabIndex = 14
        ' 
        ' DGBTurnosPaciente
        ' 
        DataGridViewCellStyle9.ForeColor = Color.Black
        DGBTurnosPaciente.DefaultCellStyle = DataGridViewCellStyle9
        DGBTurnosPaciente.HeaderText = "Paciente"
        DGBTurnosPaciente.MinimumWidth = 6
        DGBTurnosPaciente.Name = "DGBTurnosPaciente"
        DGBTurnosPaciente.ReadOnly = True
        DGBTurnosPaciente.Width = 125
        ' 
        ' asistencia
        ' 
        DataGridViewCellStyle10.ForeColor = Color.Black
        asistencia.DefaultCellStyle = DataGridViewCellStyle10
        asistencia.HeaderText = "Asistencia"
        asistencia.MinimumWidth = 6
        asistencia.Name = "asistencia"
        asistencia.ReadOnly = True
        asistencia.Width = 125
        ' 
        ' DGBEspecialidad
        ' 
        DataGridViewCellStyle11.ForeColor = Color.Black
        DGBEspecialidad.DefaultCellStyle = DataGridViewCellStyle11
        DGBEspecialidad.HeaderText = "Especialidad"
        DGBEspecialidad.MinimumWidth = 6
        DGBEspecialidad.Name = "DGBEspecialidad"
        DGBEspecialidad.ReadOnly = True
        DGBEspecialidad.Width = 125
        ' 
        ' DGBDIA
        ' 
        DataGridViewCellStyle12.ForeColor = Color.Black
        DGBDIA.DefaultCellStyle = DataGridViewCellStyle12
        DGBDIA.HeaderText = "Día Turno"
        DGBDIA.MinimumWidth = 6
        DGBDIA.Name = "DGBDIA"
        DGBDIA.ReadOnly = True
        DGBDIA.Width = 150
        ' 
        ' TextBuscar
        ' 
        TextBuscar.Location = New Point(23, 31)
        TextBuscar.Name = "TextBuscar"
        TextBuscar.Size = New Size(408, 27)
        TextBuscar.TabIndex = 15
        ' 
        ' PacBuscador
        ' 
        PacBuscador.Controls.Add(TextBuscar)
        PacBuscador.Location = New Point(72, 13)
        PacBuscador.Name = "PacBuscador"
        PacBuscador.Size = New Size(753, 84)
        PacBuscador.TabIndex = 18
        PacBuscador.TabStop = False
        PacBuscador.Text = "Buscador de Pacientes"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Pacientes
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1364, 756)
        Controls.Add(PacBuscador)
        Controls.Add(DataGridPacientes)
        Controls.Add(GroupBox1)
        Controls.Add(InfoPaciente)
        FormBorderStyle = FormBorderStyle.None
        Name = "Pacientes"
        StartPosition = FormStartPosition.CenterParent
        Text = "Pacientes"
        InfoPaciente.ResumeLayout(False)
        InfoPaciente.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridPacientes, ComponentModel.ISupportInitialize).EndInit()
        PacBuscador.ResumeLayout(False)
        PacBuscador.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

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
    Friend WithEvents asistencia As DataGridViewTextBoxColumn
    Friend WithEvents DGBEspecialidad As DataGridViewTextBoxColumn
    Friend WithEvents DGBDIA As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip

End Class
