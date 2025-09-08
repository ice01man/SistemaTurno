<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Turnos
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
        MonthCalendar1 = New MonthCalendar()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        TextBox1 = New TextBox()
        ListBox1 = New ListBox()
        GroupBox2 = New GroupBox()
        DGVTurnos = New DataGridView()
        Timer1 = New Timer(components)
        DGVPacientes = New DataGridViewTextBoxColumn()
        DGVConsultorio = New DataGridViewTextBoxColumn()
        DGVDoctor = New DataGridViewTextBoxColumn()
        DGVServicio = New DataGridViewTextBoxColumn()
        DGVDia = New DataGridViewTextBoxColumn()
        DGVHora = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(DGVTurnos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(955, 32)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 2
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(ListBox1)
        GroupBox1.Location = New Point(126, 51)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(585, 188)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 2
        Label1.Text = "Buscar"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(101, 45)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(262, 27)
        TextBox1.TabIndex = 1
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33"})
        ListBox1.Location = New Point(30, 78)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(333, 104)
        ListBox1.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(DGVTurnos)
        GroupBox2.Location = New Point(126, 251)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(1052, 418)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox2"
        ' 
        ' DGVTurnos
        ' 
        DGVTurnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGVTurnos.Columns.AddRange(New DataGridViewColumn() {DGVPacientes, DGVConsultorio, DGVDoctor, DGVServicio, DGVDia, DGVHora})
        DGVTurnos.Dock = DockStyle.Fill
        DGVTurnos.Location = New Point(3, 23)
        DGVTurnos.Name = "DGVTurnos"
        DGVTurnos.RowHeadersWidth = 51
        DGVTurnos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DGVTurnos.RowTemplate.Height = 30
        DGVTurnos.RowTemplate.Resizable = DataGridViewTriState.True
        DGVTurnos.Size = New Size(1046, 392)
        DGVTurnos.TabIndex = 2
        ' 
        ' DGVPacientes
        ' 
        DGVPacientes.HeaderText = "Pacientes"
        DGVPacientes.MinimumWidth = 6
        DGVPacientes.Name = "DGVPacientes"
        DGVPacientes.Width = 125
        ' 
        ' DGVConsultorio
        ' 
        DGVConsultorio.HeaderText = "Consultorio"
        DGVConsultorio.MinimumWidth = 6
        DGVConsultorio.Name = "DGVConsultorio"
        DGVConsultorio.Width = 125
        ' 
        ' DGVDoctor
        ' 
        DGVDoctor.HeaderText = "Doctor"
        DGVDoctor.MinimumWidth = 6
        DGVDoctor.Name = "DGVDoctor"
        DGVDoctor.Width = 125
        ' 
        ' DGVServicio
        ' 
        DGVServicio.HeaderText = "Servicio"
        DGVServicio.MinimumWidth = 6
        DGVServicio.Name = "DGVServicio"
        DGVServicio.Width = 125
        ' 
        ' DGVDia
        ' 
        DGVDia.HeaderText = "Turno Dia"
        DGVDia.MinimumWidth = 6
        DGVDia.Name = "DGVDia"
        DGVDia.Width = 125
        ' 
        ' DGVHora
        ' 
        DGVHora.HeaderText = "Turno Hora"
        DGVHora.MinimumWidth = 6
        DGVHora.Name = "DGVHora"
        DGVHora.Width = 125
        ' 
        ' Turnos
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1450, 850)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(MonthCalendar1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Turnos"
        Text = "Turnos"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        CType(DGVTurnos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGVTurnos As DataGridView
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DGVPacientes As DataGridViewTextBoxColumn
    Friend WithEvents DGVConsultorio As DataGridViewTextBoxColumn
    Friend WithEvents DGVDoctor As DataGridViewTextBoxColumn
    Friend WithEvents DGVServicio As DataGridViewTextBoxColumn
    Friend WithEvents DGVDia As DataGridViewTextBoxColumn
    Friend WithEvents DGVHora As DataGridViewTextBoxColumn
End Class
