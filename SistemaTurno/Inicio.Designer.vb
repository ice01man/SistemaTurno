<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MonthCalendar = New MonthCalendar()
        DGVTurnos = New DataGridView()
        Dim Paciente = New DataGridViewTextBoxColumn()
        Dim Telefono = New DataGridViewTextBoxColumn()
        Dim TipoConsulta = New DataGridViewTextBoxColumn()
        Dim Especialidad = New DataGridViewTextBoxColumn()
        Dim Profesional = New DataGridViewTextBoxColumn()
        Dim TurnoDiaHora = New DataGridViewTextBoxColumn()
        Dim Ver = New DataGridViewButtonColumn()
        Dim Asistio = New DataGridViewCheckBoxColumn()
        Dim Ausente = New DataGridViewCheckBoxColumn()
        GroupBox1 = New GroupBox()
        btnPaciente = New Button()
        btnTurnos = New Button()
        ToolTip1 = New ToolTip(components)
        lblTurnosDiaActual = New Label()
        btn_AcercaDe = New Button()
        CType(DGVTurnos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MonthCalendar
        ' 
        MonthCalendar.Location = New Point(868, 120)
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
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = "Ver"
        'F1DgbbtnVer.DefaultCellStyle = DataGridViewCellStyle1
        'F1DgbbtnVer.HeaderText = "Ver"
        'F1DgbbtnVer.MinimumWidth = 6
        'F1DgbbtnVer.Name = "F1DgbbtnVer"
        'F1DgbbtnVer.Text = "VER"
        'F1DgbbtnVer.Width = 125
        ' 
        ' Asistio
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "Editar"
        'F1DgbBtnAsistio.DefaultCellStyle = DataGridViewCellStyle2
        'F1DgbBtnAsistio.HeaderText = "Asistio"
        'F1DgbBtnAsistio.MinimumWidth = 6
        'F1DgbBtnAsistio.Name = "F1DgbBtnAsistio"
        'F1DgbBtnAsistio.Width = 125
        ' 
        ' Ausente
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "Eliminar"
        'F1DgbBtnAusente.DefaultCellStyle = DataGridViewCellStyle3
        'F1DgbBtnAusente.HeaderText = "Ausente"
        'F1DgbBtnAusente.MinimumWidth = 6
        'F1DgbBtnAusente.Name = "F1DgbBtnAusente"
        'F1DgbBtnAusente.Width = 125
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
        lblTurnosDiaActual.Font = New Font("Segoe UI", 16.0F)
        lblTurnosDiaActual.ForeColor = Color.White
        lblTurnosDiaActual.Location = New Point(83, 301)
        lblTurnosDiaActual.Name = "lblTurnosDiaActual"
        lblTurnosDiaActual.Size = New Size(258, 37)
        lblTurnosDiaActual.TabIndex = 18
        lblTurnosDiaActual.Text = "PRÓXIMOS TURNOS"
        lblTurnosDiaActual.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' btn_AcercaDe
        ' 
        btn_AcercaDe.Font = New Font("Segoe UI Emoji", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_AcercaDe.ForeColor = SystemColors.ActiveCaptionText
        btn_AcercaDe.Location = New Point(871, 75)
        btn_AcercaDe.Name = "btn_AcercaDe"
        btn_AcercaDe.Size = New Size(94, 29)
        btn_AcercaDe.TabIndex = 19
        btn_AcercaDe.Text = "ℹ Acerca de"
        btn_AcercaDe.UseVisualStyleBackColor = True
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1382, 803)
        Controls.Add(btn_AcercaDe)
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
    Friend WithEvents btn_AcercaDe As Button
End Class
