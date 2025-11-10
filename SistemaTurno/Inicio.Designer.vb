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
        MonthCalendar = New MonthCalendar()
        DGVTurnos = New DataGridView()
        Paciente = New DataGridViewTextBoxColumn()
        Telefono = New DataGridViewTextBoxColumn()
        TipoConsulta = New DataGridViewTextBoxColumn()
        Especialidad = New DataGridViewTextBoxColumn()
        Profesional = New DataGridViewTextBoxColumn()
        TurnoDiaHora = New DataGridViewTextBoxColumn()
        Ver = New DataGridViewButtonColumn()
        Asistio = New DataGridViewCheckBoxColumn()
        Ausente = New DataGridViewCheckBoxColumn()
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
        DGVTurnos.Columns.AddRange(New DataGridViewColumn() {Paciente, Telefono, TipoConsulta, Especialidad, Profesional, TurnoDiaHora, Ver, Asistio, Ausente})
        DGVTurnos.Location = New Point(83, 341)
        DGVTurnos.Name = "DGVTurnos"
        DGVTurnos.RowHeadersWidth = 51
        DGVTurnos.Size = New Size(1207, 317)
        DGVTurnos.TabIndex = 4
        ' 
        ' Paciente
        ' 
        Paciente.HeaderText = "Paciente"
        Paciente.MinimumWidth = 6
        Paciente.Name = "Paciente"
        Paciente.Width = 125
        ' 
        ' Telefono
        ' 
        Telefono.HeaderText = "Telefono"
        Telefono.MinimumWidth = 6
        Telefono.Name = "Telefono"
        Telefono.Width = 125
        ' 
        ' TipoConsulta
        ' 
        TipoConsulta.HeaderText = "TipoConsulta"
        TipoConsulta.MinimumWidth = 6
        TipoConsulta.Name = "TipoConsulta"
        TipoConsulta.Width = 125
        ' 
        ' Especialidad
        ' 
        Especialidad.HeaderText = "Especialidad"
        Especialidad.MinimumWidth = 6
        Especialidad.Name = "Especialidad"
        Especialidad.Width = 125
        ' 
        ' Profesional
        ' 
        Profesional.HeaderText = "Profesional"
        Profesional.MinimumWidth = 6
        Profesional.Name = "Profesional"
        Profesional.Width = 125
        ' 
        ' TurnoDiaHora
        ' 
        TurnoDiaHora.HeaderText = "TurnoDiaHora"
        TurnoDiaHora.MinimumWidth = 6
        TurnoDiaHora.Name = "TurnoDiaHora"
        TurnoDiaHora.Width = 125
        ' 
        ' Ver
        ' 
        Ver.HeaderText = "Ver"
        Ver.MinimumWidth = 6
        Ver.Name = "Ver"
        Ver.Text = "Ver"
        Ver.Width = 125
        ' 
        ' Asistio
        ' 
        Asistio.HeaderText = "Asistio"
        Asistio.MinimumWidth = 6
        Asistio.Name = "Asistio"
        Asistio.Resizable = DataGridViewTriState.True
        Asistio.Width = 125
        ' 
        ' Ausente
        ' 
        Ausente.HeaderText = "Ausente"
        Ausente.MinimumWidth = 6
        Ausente.Name = "Ausente"
        Ausente.Resizable = DataGridViewTriState.True
        Ausente.Width = 125
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
    Friend WithEvents btnPaciente As Button
    Friend WithEvents Paciente As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents TipoConsulta As DataGridViewTextBoxColumn
    Friend WithEvents Especialidad As DataGridViewTextBoxColumn
    Friend WithEvents Profesional As DataGridViewTextBoxColumn
    Friend WithEvents TurnoDiaHora As DataGridViewTextBoxColumn
    Friend WithEvents Ver As DataGridViewButtonColumn
    Friend WithEvents Asistio As DataGridViewCheckBoxColumn
    Friend WithEvents Ausente As DataGridViewCheckBoxColumn
End Class
