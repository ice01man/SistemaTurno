<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        GroupBox1 = New GroupBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        PanelUsuarios = New Panel()
        Labelad4 = New Label()
        admin_texto3 = New TextBox()
        Chboxad = New CheckedListBox()
        Button2 = New Button()
        admin_combo = New ComboBox()
        Labelad3 = New Label()
        Labelad2 = New Label()
        Labelad1 = New Label()
        admin_texto2 = New TextBox()
        admin_texto1 = New TextBox()
        Panel2 = New Panel()
        lbl_buscarEspecialidad = New Label()
        txt_buscadorEspe = New TextBox()
        Buscador = New Label()
        txt_buscador = New TextBox()
        DataGridViewAdmin = New DataGridView()
        GroupBox1.SuspendLayout()
        PanelUsuarios.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridViewAdmin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Location = New Point(67, 35)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1186, 71)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Administracion"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Seleccione", "Usuarios", "Doctores", "Pantalla"})
        ComboBox1.Location = New Point(55, 27)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(421, 28)
        ComboBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(508, 27)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 2
        Button1.Text = "ir"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PanelUsuarios
        ' 
        PanelUsuarios.Controls.Add(Labelad4)
        PanelUsuarios.Controls.Add(admin_texto3)
        PanelUsuarios.Controls.Add(Chboxad)
        PanelUsuarios.Controls.Add(Button2)
        PanelUsuarios.Controls.Add(admin_combo)
        PanelUsuarios.Controls.Add(Labelad3)
        PanelUsuarios.Controls.Add(Labelad2)
        PanelUsuarios.Controls.Add(Labelad1)
        PanelUsuarios.Controls.Add(admin_texto2)
        PanelUsuarios.Controls.Add(admin_texto1)
        PanelUsuarios.Location = New Point(70, 140)
        PanelUsuarios.Name = "PanelUsuarios"
        PanelUsuarios.Size = New Size(510, 465)
        PanelUsuarios.TabIndex = 1
        PanelUsuarios.Visible = False
        ' 
        ' Labelad4
        ' 
        Labelad4.AutoSize = True
        Labelad4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Labelad4.ForeColor = Color.Black
        Labelad4.Location = New Point(52, 149)
        Labelad4.Name = "Labelad4"
        Labelad4.Size = New Size(74, 28)
        Labelad4.TabIndex = 7
        Labelad4.Text = "Texto 4"
        ' 
        ' admin_texto3
        ' 
        admin_texto3.Location = New Point(220, 116)
        admin_texto3.Name = "admin_texto3"
        admin_texto3.Size = New Size(232, 27)
        admin_texto3.TabIndex = 6
        ' 
        ' Chboxad
        ' 
        Chboxad.ForeColor = Color.Black
        Chboxad.FormattingEnabled = True
        Chboxad.Items.AddRange(New Object() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"})
        Chboxad.Location = New Point(220, 183)
        Chboxad.Name = "Chboxad"
        Chboxad.Size = New Size(232, 158)
        Chboxad.TabIndex = 4
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.GreenYellow
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(358, 421)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 3
        Button2.Text = "Guardar"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' admin_combo
        ' 
        admin_combo.FormattingEnabled = True
        admin_combo.Items.AddRange(New Object() {"Seleccione", "Usuario", "Administrador", "Consultor"})
        admin_combo.Location = New Point(220, 149)
        admin_combo.Name = "admin_combo"
        admin_combo.Size = New Size(232, 28)
        admin_combo.TabIndex = 3
        ' 
        ' Labelad3
        ' 
        Labelad3.AutoSize = True
        Labelad3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Labelad3.ForeColor = Color.Black
        Labelad3.Location = New Point(52, 116)
        Labelad3.Name = "Labelad3"
        Labelad3.Size = New Size(74, 28)
        Labelad3.TabIndex = 5
        Labelad3.Text = "Texto 3"
        ' 
        ' Labelad2
        ' 
        Labelad2.AutoSize = True
        Labelad2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Labelad2.ForeColor = Color.Black
        Labelad2.Location = New Point(52, 83)
        Labelad2.Name = "Labelad2"
        Labelad2.Size = New Size(74, 28)
        Labelad2.TabIndex = 4
        Labelad2.Text = "Texto 2"
        ' 
        ' Labelad1
        ' 
        Labelad1.AutoSize = True
        Labelad1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Labelad1.ForeColor = Color.Black
        Labelad1.Location = New Point(52, 50)
        Labelad1.Name = "Labelad1"
        Labelad1.Size = New Size(74, 28)
        Labelad1.TabIndex = 3
        Labelad1.Text = "Texto 1"
        ' 
        ' admin_texto2
        ' 
        admin_texto2.Location = New Point(220, 83)
        admin_texto2.Name = "admin_texto2"
        admin_texto2.Size = New Size(232, 27)
        admin_texto2.TabIndex = 1
        ' 
        ' admin_texto1
        ' 
        admin_texto1.Location = New Point(220, 50)
        admin_texto1.Name = "admin_texto1"
        admin_texto1.Size = New Size(232, 27)
        admin_texto1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lbl_buscarEspecialidad)
        Panel2.Controls.Add(txt_buscadorEspe)
        Panel2.Controls.Add(Buscador)
        Panel2.Controls.Add(txt_buscador)
        Panel2.Controls.Add(DataGridViewAdmin)
        Panel2.Location = New Point(603, 140)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(708, 565)
        Panel2.TabIndex = 2
        ' 
        ' lbl_buscarEspecialidad
        ' 
        lbl_buscarEspecialidad.AutoSize = True
        lbl_buscarEspecialidad.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_buscarEspecialidad.ForeColor = Color.Black
        lbl_buscarEspecialidad.Location = New Point(376, 24)
        lbl_buscarEspecialidad.Name = "lbl_buscarEspecialidad"
        lbl_buscarEspecialidad.Size = New Size(112, 23)
        lbl_buscarEspecialidad.TabIndex = 10
        lbl_buscarEspecialidad.Text = "Especialidad: "
        ' 
        ' txt_buscadorEspe
        ' 
        txt_buscadorEspe.Location = New Point(376, 50)
        txt_buscadorEspe.Name = "txt_buscadorEspe"
        txt_buscadorEspe.Size = New Size(260, 27)
        txt_buscadorEspe.TabIndex = 9
        ' 
        ' Buscador
        ' 
        Buscador.AutoSize = True
        Buscador.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Buscador.ForeColor = Color.Black
        Buscador.Location = New Point(19, 24)
        Buscador.Name = "Buscador"
        Buscador.Size = New Size(89, 23)
        Buscador.TabIndex = 8
        Buscador.Text = "Buscador: "
        ' 
        ' txt_buscador
        ' 
        txt_buscador.Location = New Point(19, 50)
        txt_buscador.Name = "txt_buscador"
        txt_buscador.Size = New Size(333, 27)
        txt_buscador.TabIndex = 8
        ' 
        ' DataGridViewAdmin
        ' 
        DataGridViewAdmin.AllowUserToAddRows = False
        DataGridViewAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewAdmin.Location = New Point(19, 94)
        DataGridViewAdmin.Name = "DataGridViewAdmin"
        DataGridViewAdmin.RowHeadersWidth = 51
        DataGridViewAdmin.Size = New Size(631, 414)
        DataGridViewAdmin.TabIndex = 0
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1382, 803)
        Controls.Add(Panel2)
        Controls.Add(PanelUsuarios)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Admin"
        ShowInTaskbar = False
        Text = "Admin"
        GroupBox1.ResumeLayout(False)
        PanelUsuarios.ResumeLayout(False)
        PanelUsuarios.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridViewAdmin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PanelUsuarios As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Labelad1 As Label
    Friend WithEvents admin_texto2 As TextBox
    Friend WithEvents admin_texto1 As TextBox
    Friend WithEvents Labelad2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents admin_combo As ComboBox
    Friend WithEvents Labelad3 As Label
    Friend WithEvents DataGridViewAdmin As DataGridView
    Friend WithEvents Chboxad As CheckedListBox
    Friend WithEvents admin_texto3 As TextBox
    Friend WithEvents Labelad4 As Label
    Friend WithEvents txt_buscador As TextBox
    Friend WithEvents Buscador As Label
    Friend WithEvents lbl_buscarEspecialidad As Label
    Friend WithEvents txt_buscadorEspe As TextBox
End Class
