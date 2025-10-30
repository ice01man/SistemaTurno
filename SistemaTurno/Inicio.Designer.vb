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
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MonthCalendar = New MonthCalendar()
        DGVTurnos = New DataGridView()
        F1DgbPacientes = New DataGridViewTextBoxColumn()
        F1DgbTelefono = New DataGridViewTextBoxColumn()
        F1DgbServicio = New DataGridViewTextBoxColumn()
        F1DgbTurnoDia = New DataGridViewTextBoxColumn()
        F1DgbTurnohora = New DataGridViewTextBoxColumn()
        F1DgbbtnVer = New DataGridViewButtonColumn()
        F1DgbBtnAsistio = New DataGridViewButtonColumn()
        F1DgbBtnAusente = New DataGridViewButtonColumn()
        GroupBox1 = New GroupBox()
        btnPaciente = New Button()
        btnTurnos = New Button()
        ToolTip1 = New ToolTip(components)
        lblTurnosDiaActual = New Label()
        CType(DGVTurnos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MonthCalendar
        ' 
        MonthCalendar.Location = New Point(868, 65)
        MonthCalendar.Name = "MonthCalendar"
        MonthCalendar.TabIndex = 5
        ' 
        ' DGVTurnos
        ' 
        DGVTurnos.BackgroundColor = SystemColors.InactiveCaption
        DGVTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVTurnos.Columns.AddRange(New DataGridViewColumn() {F1DgbPacientes, F1DgbTelefono, F1DgbServicio, F1DgbTurnoDia, F1DgbTurnohora, F1DgbbtnVer, F1DgbBtnAsistio, F1DgbBtnAusente})
        DGVTurnos.Location = New Point(83, 341)
        DGVTurnos.Name = "DGVTurnos"
        DGVTurnos.RowHeadersWidth = 51
        DGVTurnos.Size = New Size(1054, 317)
        DGVTurnos.TabIndex = 4
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
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = "Ver"
        F1DgbbtnVer.DefaultCellStyle = DataGridViewCellStyle4
        F1DgbbtnVer.HeaderText = "Ver"
        F1DgbbtnVer.MinimumWidth = 6
        F1DgbbtnVer.Name = "F1DgbbtnVer"
        F1DgbbtnVer.Text = "VER"
        F1DgbbtnVer.Width = 125
        ' 
        ' F1DgbBtnAsistio
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.NullValue = "Editar"
        F1DgbBtnAsistio.DefaultCellStyle = DataGridViewCellStyle5
        F1DgbBtnAsistio.HeaderText = "Asistio"
        F1DgbBtnAsistio.MinimumWidth = 6
        F1DgbBtnAsistio.Name = "F1DgbBtnAsistio"
        F1DgbBtnAsistio.Width = 125
        ' 
        ' F1DgbBtnAusente
        ' 
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = "Eliminar"
        F1DgbBtnAusente.DefaultCellStyle = DataGridViewCellStyle6
        F1DgbBtnAusente.HeaderText = "Ausente"
        F1DgbBtnAusente.MinimumWidth = 6
        F1DgbBtnAusente.Name = "F1DgbBtnAusente"
        F1DgbBtnAusente.Width = 125
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnPaciente)
        GroupBox1.Controls.Add(btnTurnos)
        GroupBox1.Location = New Point(83, 65)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(615, 207)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' btnPaciente
        ' 
        btnPaciente.BackColor = SystemColors.ActiveCaption
        btnPaciente.ForeColor = Color.Black
        btnPaciente.Location = New Point(342, 55)
        btnPaciente.Name = "btnPaciente"
        btnPaciente.Size = New Size(198, 107)
        btnPaciente.TabIndex = 2
        btnPaciente.Text = "👤 Pacientes"
        btnPaciente.UseVisualStyleBackColor = False
        ' 
        ' btnTurnos
        ' 
        btnTurnos.BackColor = SystemColors.ActiveCaption
        btnTurnos.ForeColor = Color.Black
        btnTurnos.Location = New Point(69, 55)
        btnTurnos.Name = "btnTurnos"
        btnTurnos.Size = New Size(198, 107)
        btnTurnos.TabIndex = 0
        btnTurnos.Text = "➕ Turnos"
        btnTurnos.UseVisualStyleBackColor = False
        ' 
        ' lblTurnosDiaActual
        ' 
        lblTurnosDiaActual.AutoSize = True
        lblTurnosDiaActual.BackColor = Color.CornflowerBlue
        lblTurnosDiaActual.Font = New Font("Segoe UI", 16F)
        lblTurnosDiaActual.ForeColor = Color.White
        lblTurnosDiaActual.Location = New Point(83, 301)
        lblTurnosDiaActual.Name = "lblTurnosDiaActual"
        lblTurnosDiaActual.Size = New Size(258, 37)
        lblTurnosDiaActual.TabIndex = 18
        lblTurnosDiaActual.Text = "PRÓXIMOS TURNOS"
        lblTurnosDiaActual.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1382, 803)
        Controls.Add(lblTurnosDiaActual)
        Controls.Add(MonthCalendar)
        Controls.Add(DGVTurnos)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Inicio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inicio"
        CType(DGVTurnos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MonthCalendar As MonthCalendar
    Friend WithEvents DGVTurnos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTurnos As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblTurnosDiaActual As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents F1DgbPacientes As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbTelefono As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbServicio As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbTurnoDia As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbTurnohora As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbbtnVer As DataGridViewButtonColumn
    Friend WithEvents F1DgbBtnAsistio As DataGridViewButtonColumn
    Friend WithEvents F1DgbBtnAusente As DataGridViewButtonColumn
    Friend WithEvents btnPaciente As Button
End Class
