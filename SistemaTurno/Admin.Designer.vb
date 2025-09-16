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
        Panel1 = New Panel()
        Button2 = New Button()
        admin_combo = New ComboBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        admin_contrasena = New TextBox()
        admin_usuario = New TextBox()
        Panel2 = New Panel()
        DataGridViewAdmin = New DataGridView()
        DGV_Usuario = New DataGridViewTextBoxColumn()
        DGV_Contrasena = New DataGridViewTextBoxColumn()
        DGV_Rol = New DataGridViewTextBoxColumn()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
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
        ComboBox1.Items.AddRange(New Object() {"Seleccione", "Pantalla", "Usuarios", "Colores"})
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
        ' Panel1
        ' 
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(admin_combo)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(admin_contrasena)
        Panel1.Controls.Add(admin_usuario)
        Panel1.Location = New Point(67, 142)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(554, 326)
        Panel1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.GreenYellow
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(358, 249)
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
        admin_combo.Location = New Point(220, 170)
        admin_combo.Name = "admin_combo"
        admin_combo.Size = New Size(232, 28)
        admin_combo.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(90, 166)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 28)
        Label3.TabIndex = 5
        Label3.Text = "Rol"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(90, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 28)
        Label2.TabIndex = 4
        Label2.Text = "Contraseña"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(90, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 28)
        Label1.TabIndex = 3
        Label1.Text = "Usuario"
        ' 
        ' admin_contrasena
        ' 
        admin_contrasena.Location = New Point(220, 110)
        admin_contrasena.Name = "admin_contrasena"
        admin_contrasena.Size = New Size(232, 27)
        admin_contrasena.TabIndex = 1
        ' 
        ' admin_usuario
        ' 
        admin_usuario.Location = New Point(220, 49)
        admin_usuario.Name = "admin_usuario"
        admin_usuario.Size = New Size(232, 27)
        admin_usuario.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(DataGridViewAdmin)
        Panel2.Location = New Point(678, 142)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(575, 565)
        Panel2.TabIndex = 2
        ' 
        ' DataGridViewAdmin
        ' 
        DataGridViewAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewAdmin.Columns.AddRange(New DataGridViewColumn() {DGV_Usuario, DGV_Contrasena, DGV_Rol})
        DataGridViewAdmin.Location = New Point(57, 39)
        DataGridViewAdmin.Name = "DataGridViewAdmin"
        DataGridViewAdmin.RowHeadersWidth = 51
        DataGridViewAdmin.Size = New Size(429, 414)
        DataGridViewAdmin.TabIndex = 0
        ' 
        ' DGV_Usuario
        ' 
        DGV_Usuario.HeaderText = "Usuarios"
        DGV_Usuario.MinimumWidth = 6
        DGV_Usuario.Name = "DGV_Usuario"
        DGV_Usuario.ReadOnly = True
        DGV_Usuario.Width = 125
        ' 
        ' DGV_Contrasena
        ' 
        DGV_Contrasena.HeaderText = "Contraseña"
        DGV_Contrasena.MinimumWidth = 6
        DGV_Contrasena.Name = "DGV_Contrasena"
        DGV_Contrasena.ReadOnly = True
        DGV_Contrasena.Width = 125
        ' 
        ' DGV_Rol
        ' 
        DGV_Rol.HeaderText = "Roles"
        DGV_Rol.MinimumWidth = 6
        DGV_Rol.Name = "DGV_Rol"
        DGV_Rol.ReadOnly = True
        DGV_Rol.Width = 125
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(1382, 803)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Admin"
        ShowInTaskbar = False
        Text = "Admin"
        GroupBox1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(DataGridViewAdmin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents admin_contrasena As TextBox
    Friend WithEvents admin_usuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents admin_combo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewAdmin As DataGridView
    Friend WithEvents DGV_Usuario As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Contrasena As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Rol As DataGridViewTextBoxColumn
End Class
