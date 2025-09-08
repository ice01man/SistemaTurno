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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        InfoPaciente = New GroupBox()
        Label2 = New Label()
        TextBox6 = New TextBox()
        Label1 = New Label()
        PaclblCredencial = New Label()
        PaclblTelefono = New Label()
        PacLblApellido = New Label()
        PacLblNombre = New Label()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        GroupBox1 = New GroupBox()
        Label5 = New Label()
        Label7 = New Label()
        TextBox13 = New TextBox()
        TextBox14 = New TextBox()
        DataGridView1 = New DataGridView()
        DGBTurnosPaciente = New DataGridViewTextBoxColumn()
        DGBServicios = New DataGridViewTextBoxColumn()
        DGBDIA = New DataGridViewTextBoxColumn()
        TextBox7 = New TextBox()
        ComboBox1 = New ComboBox()
        BtnBuscar = New Button()
        PacBuscador = New GroupBox()
        InfoPaciente.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        PacBuscador.SuspendLayout()
        SuspendLayout()
        ' 
        ' InfoPaciente
        ' 
        InfoPaciente.Controls.Add(Label2)
        InfoPaciente.Controls.Add(TextBox6)
        InfoPaciente.Controls.Add(Label1)
        InfoPaciente.Controls.Add(PaclblCredencial)
        InfoPaciente.Controls.Add(PaclblTelefono)
        InfoPaciente.Controls.Add(PacLblApellido)
        InfoPaciente.Controls.Add(PacLblNombre)
        InfoPaciente.Controls.Add(TextBox5)
        InfoPaciente.Controls.Add(TextBox4)
        InfoPaciente.Controls.Add(TextBox3)
        InfoPaciente.Controls.Add(TextBox2)
        InfoPaciente.Controls.Add(TextBox1)
        InfoPaciente.ForeColor = Color.Black
        InfoPaciente.Location = New Point(72, 102)
        InfoPaciente.Name = "InfoPaciente"
        InfoPaciente.Size = New Size(509, 574)
        InfoPaciente.TabIndex = 0
        InfoPaciente.TabStop = False
        InfoPaciente.Text = "Info del Paciente"
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
        ' TextBox6
        ' 
        TextBox6.Location = New Point(202, 383)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(249, 27)
        TextBox6.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(61, 263)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 9
        Label1.Text = "EDAD"
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
        PacLblApellido.Location = New Point(61, 150)
        PacLblApellido.Name = "PacLblApellido"
        PacLblApellido.Size = New Size(75, 20)
        PacLblApellido.TabIndex = 6
        PacLblApellido.Text = "APELLIDO"
        ' 
        ' PacLblNombre
        ' 
        PacLblNombre.AutoSize = True
        PacLblNombre.ForeColor = Color.Black
        PacLblNombre.Location = New Point(61, 81)
        PacLblNombre.Name = "PacLblNombre"
        PacLblNombre.Size = New Size(70, 20)
        PacLblNombre.TabIndex = 5
        PacLblNombre.Text = "NOMBRE"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(202, 326)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(249, 27)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(202, 260)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(249, 27)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(202, 201)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(249, 27)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(202, 143)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(249, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(202, 78)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(249, 27)
        TextBox1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(TextBox13)
        GroupBox1.Controls.Add(TextBox14)
        GroupBox1.ForeColor = Color.Black
        GroupBox1.Location = New Point(617, 102)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(509, 228)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        GroupBox1.Text = "Info del Paciente"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(61, 146)
        Label5.Name = "Label5"
        Label5.Size = New Size(120, 20)
        Label5.TabIndex = 8
        Label5.Text = "N^ CEDRENCIAL"
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
        ' TextBox13
        ' 
        TextBox13.Location = New Point(202, 143)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(249, 27)
        TextBox13.TabIndex = 1
        ' 
        ' TextBox14
        ' 
        TextBox14.Location = New Point(202, 78)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(249, 27)
        TextBox14.TabIndex = 0
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {DGBTurnosPaciente, DGBServicios, DGBDIA})
        DataGridView1.Location = New Point(617, 365)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(509, 311)
        DataGridView1.TabIndex = 14
        ' 
        ' DGBTurnosPaciente
        ' 
        DGBTurnosPaciente.HeaderText = "Turnos"
        DGBTurnosPaciente.MinimumWidth = 6
        DGBTurnosPaciente.Name = "DGBTurnosPaciente"
        DGBTurnosPaciente.Width = 125
        ' 
        ' DGBServicios
        ' 
        DGBServicios.HeaderText = "Servicios"
        DGBServicios.MinimumWidth = 6
        DGBServicios.Name = "DGBServicios"
        DGBServicios.Width = 125
        ' 
        ' DGBDIA
        ' 
        DGBDIA.HeaderText = "DIA Atencion"
        DGBDIA.MinimumWidth = 6
        DGBDIA.Name = "DGBDIA"
        DGBDIA.Width = 125
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(23, 31)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(214, 27)
        TextBox7.TabIndex = 15
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(383, 31)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(343, 28)
        ComboBox1.TabIndex = 16
        ' 
        ' BtnBuscar
        ' 
        BtnBuscar.BackColor = Color.CadetBlue
        BtnBuscar.Location = New Point(258, 21)
        BtnBuscar.Name = "BtnBuscar"
        BtnBuscar.Size = New Size(94, 47)
        BtnBuscar.TabIndex = 17
        BtnBuscar.Text = "Buscar"
        BtnBuscar.UseVisualStyleBackColor = False
        ' 
        ' PacBuscador
        ' 
        PacBuscador.Controls.Add(TextBox7)
        PacBuscador.Controls.Add(ComboBox1)
        PacBuscador.Controls.Add(BtnBuscar)
        PacBuscador.Location = New Point(72, 12)
        PacBuscador.Name = "PacBuscador"
        PacBuscador.Size = New Size(753, 84)
        PacBuscador.TabIndex = 18
        PacBuscador.TabStop = False
        PacBuscador.Text = "Buscador de Pacientes"
        ' 
        ' Pacientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1269, 801)
        Controls.Add(PacBuscador)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        Controls.Add(InfoPaciente)
        ForeColor = Color.Transparent
        FormBorderStyle = FormBorderStyle.None
        Name = "Pacientes"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pacientes"
        InfoPaciente.ResumeLayout(False)
        InfoPaciente.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        PacBuscador.ResumeLayout(False)
        PacBuscador.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents InfoPaciente As GroupBox
    Friend WithEvents PacLblNombre As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PaclblCredencial As Label
    Friend WithEvents PaclblTelefono As Label
    Friend WithEvents PacLblApellido As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DGBTurnosPaciente As DataGridViewTextBoxColumn
    Friend WithEvents DGBServicios As DataGridViewTextBoxColumn
    Friend WithEvents DGBDIA As DataGridViewTextBoxColumn
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnBuscar As Button
    Friend WithEvents PacBuscador As GroupBox
End Class
