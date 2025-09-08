<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MonthCalendar1 = New MonthCalendar()
        DataGridView1 = New DataGridView()
        F1DgbPacientes = New DataGridViewTextBoxColumn()
        F1DgbTelefono = New DataGridViewTextBoxColumn()
        F1DgbServicio = New DataGridViewTextBoxColumn()
        F1DgbTurnoDia = New DataGridViewTextBoxColumn()
        F1DgbTurnohora = New DataGridViewTextBoxColumn()
        F1DgbbtnVer = New DataGridViewButtonColumn()
        F1DgbBtnEditar = New DataGridViewButtonColumn()
        F1DgbBtnEliminar = New DataGridViewButtonColumn()
        GroupBox1 = New GroupBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        ToolTip1 = New ToolTip(components)
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(930, 65)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 5
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {F1DgbPacientes, F1DgbTelefono, F1DgbServicio, F1DgbTurnoDia, F1DgbTurnohora, F1DgbbtnVer, F1DgbBtnEditar, F1DgbBtnEliminar})
        DataGridView1.Location = New Point(83, 341)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1067, 317)
        DataGridView1.TabIndex = 4
        ' 
        ' F1DgbPacientes
        ' 
        F1DgbPacientes.HeaderText = "Pacientes"
        F1DgbPacientes.MinimumWidth = 6
        F1DgbPacientes.Name = "F1DgbPacientes"
        F1DgbPacientes.Width = 125
        ' 
        ' F1DgbTelefono
        ' 
        F1DgbTelefono.HeaderText = "Telefono"
        F1DgbTelefono.MinimumWidth = 6
        F1DgbTelefono.Name = "F1DgbTelefono"
        F1DgbTelefono.Width = 125
        ' 
        ' F1DgbServicio
        ' 
        F1DgbServicio.HeaderText = "Servicio"
        F1DgbServicio.MinimumWidth = 6
        F1DgbServicio.Name = "F1DgbServicio"
        F1DgbServicio.Width = 125
        ' 
        ' F1DgbTurnoDia
        ' 
        F1DgbTurnoDia.HeaderText = "Turno Dia"
        F1DgbTurnoDia.MinimumWidth = 6
        F1DgbTurnoDia.Name = "F1DgbTurnoDia"
        F1DgbTurnoDia.Width = 125
        ' 
        ' F1DgbTurnohora
        ' 
        F1DgbTurnohora.HeaderText = "Turno Hora"
        F1DgbTurnohora.MinimumWidth = 6
        F1DgbTurnohora.Name = "F1DgbTurnohora"
        F1DgbTurnohora.Width = 125
        ' 
        ' F1DgbbtnVer
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Ver"
        F1DgbbtnVer.DefaultCellStyle = DataGridViewCellStyle1
        F1DgbbtnVer.HeaderText = "Ver"
        F1DgbbtnVer.MinimumWidth = 6
        F1DgbbtnVer.Name = "F1DgbbtnVer"
        F1DgbbtnVer.Text = "VER"
        F1DgbbtnVer.Width = 125
        ' 
        ' F1DgbBtnEditar
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "Editar"
        F1DgbBtnEditar.DefaultCellStyle = DataGridViewCellStyle2
        F1DgbBtnEditar.HeaderText = "Editar"
        F1DgbBtnEditar.MinimumWidth = 6
        F1DgbBtnEditar.Name = "F1DgbBtnEditar"
        F1DgbBtnEditar.Width = 125
        ' 
        ' F1DgbBtnEliminar
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "Eliminar"
        F1DgbBtnEliminar.DefaultCellStyle = DataGridViewCellStyle3
        F1DgbBtnEliminar.HeaderText = "Eliminar"
        F1DgbBtnEliminar.MinimumWidth = 6
        F1DgbBtnEliminar.Name = "F1DgbBtnEliminar"
        F1DgbBtnEliminar.Width = 125
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button4)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Location = New Point(83, 65)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(615, 258)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveCaption
        Button4.ForeColor = Color.Black
        Button4.Location = New Point(390, 83)
        Button4.Name = "Button4"
        Button4.Size = New Size(150, 61)
        Button4.TabIndex = 2
        Button4.Text = "👤 Pacientes"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaption
        Button3.ForeColor = Color.Black
        Button3.Location = New Point(223, 83)
        Button3.Name = "Button3"
        Button3.Size = New Size(148, 61)
        Button3.TabIndex = 1
        Button3.Text = "😊 Ver Turnos"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(67, 83)
        Button2.Name = "Button2"
        Button2.Size = New Size(135, 61)
        Button2.TabIndex = 0
        Button2.Text = "➕ Turnos"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ToolTip1
        ' 
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1450, 850)
        Controls.Add(MonthCalendar1)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Inicio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inicio"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents F1DgbPacientes As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbTelefono As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbServicio As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbTurnoDia As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbTurnohora As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbbtnVer As DataGridViewButtonColumn
    Friend WithEvents F1DgbBtnEditar As DataGridViewButtonColumn
    Friend WithEvents F1DgbBtnEliminar As DataGridViewButtonColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
