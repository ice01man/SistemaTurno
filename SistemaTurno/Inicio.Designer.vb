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
        DGVTurnos = New DataGridView()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        ToolTip1 = New ToolTip(components)
        lblTurnosDiaActual = New Label()
        F1DgbPacientes = New DataGridViewTextBoxColumn()
        F1DgbTelefono = New DataGridViewTextBoxColumn()
        F1DgbServicio = New DataGridViewTextBoxColumn()
        F1DgbTurnoDia = New DataGridViewTextBoxColumn()
        F1DgbTurnohora = New DataGridViewTextBoxColumn()
        F1DgbbtnVer = New DataGridViewButtonColumn()
        F1DgbBtnAsistio = New DataGridViewButtonColumn()
        F1DgbBtnAusente = New DataGridViewButtonColumn()
        CType(DGVTurnos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(930, 65)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 5
        ' 
        ' DGVTurnos
        ' 
        DGVTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVTurnos.Columns.AddRange(New DataGridViewColumn() {F1DgbPacientes, F1DgbTelefono, F1DgbServicio, F1DgbTurnoDia, F1DgbTurnohora, F1DgbbtnVer, F1DgbBtnAsistio, F1DgbBtnAusente})
        DGVTurnos.Location = New Point(83, 341)
        DGVTurnos.Name = "DGVTurnos"
        DGVTurnos.RowHeadersWidth = 51
        DGVTurnos.Size = New Size(1067, 317)
        DGVTurnos.TabIndex = 4
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Location = New Point(83, 65)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(615, 207)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(224, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 20)
        Label2.TabIndex = 3
        Label2.Text = "Nuevo Paciente"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(224, 74)
        Button1.Name = "Button1"
        Button1.Size = New Size(135, 61)
        Button1.TabIndex = 2
        Button1.Text = "👤 Paciente"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(72, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(94, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nuevo Turno"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(72, 74)
        Button2.Name = "Button2"
        Button2.Size = New Size(135, 61)
        Button2.TabIndex = 0
        Button2.Text = "➕ Turnos"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' lblTurnosDiaActual
        ' 
        lblTurnosDiaActual.AutoSize = True
        lblTurnosDiaActual.Font = New Font("Segoe UI", 16F)
        lblTurnosDiaActual.ForeColor = Color.Black
        lblTurnosDiaActual.Location = New Point(83, 301)
        lblTurnosDiaActual.Name = "lblTurnosDiaActual"
        lblTurnosDiaActual.Size = New Size(174, 37)
        lblTurnosDiaActual.TabIndex = 18
        lblTurnosDiaActual.Text = "Turno de hoy"
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
        ' F1DgbBtnAsistio
        ' 
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = "Editar"
        F1DgbBtnAsistio.DefaultCellStyle = DataGridViewCellStyle2
        F1DgbBtnAsistio.HeaderText = "Asistio"
        F1DgbBtnAsistio.MinimumWidth = 6
        F1DgbBtnAsistio.Name = "F1DgbBtnAsistio"
        F1DgbBtnAsistio.Width = 125
        ' 
        ' F1DgbBtnAusente
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = "Eliminar"
        F1DgbBtnAusente.DefaultCellStyle = DataGridViewCellStyle3
        F1DgbBtnAusente.HeaderText = "Ausente"
        F1DgbBtnAusente.MinimumWidth = 6
        F1DgbBtnAusente.Name = "F1DgbBtnAusente"
        F1DgbBtnAusente.Width = 125
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1269, 801)
        Controls.Add(lblTurnosDiaActual)
        Controls.Add(MonthCalendar1)
        Controls.Add(DGVTurnos)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Inicio"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inicio"
        CType(DGVTurnos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents DGVTurnos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblTurnosDiaActual As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents F1DgbPacientes As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbTelefono As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbServicio As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbTurnoDia As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbTurnohora As DataGridViewTextBoxColumn
    Friend WithEvents F1DgbbtnVer As DataGridViewButtonColumn
    Friend WithEvents F1DgbBtnAsistio As DataGridViewButtonColumn
    Friend WithEvents F1DgbBtnAusente As DataGridViewButtonColumn
End Class
