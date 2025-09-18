<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        MenuStrip1 = New MenuStrip()
        MenuInicio = New ToolStripMenuItem()
        MenuPacientes = New ToolStripMenuItem()
        MenuTurnos = New ToolStripMenuItem()
        MenuAdmin = New ToolStripMenuItem()
        ToolStripContainer1 = New ToolStripContainer()
        GroupBox1 = New GroupBox()
        BtnLogin = New Button()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        LogintxtPassword = New TextBox()
        LogintxtUsuario = New TextBox()
        MenuStrip1.SuspendLayout()
        ToolStripContainer1.ContentPanel.SuspendLayout()
        ToolStripContainer1.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(323, 234)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {MenuInicio, MenuPacientes, MenuTurnos, MenuAdmin})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1382, 24)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' MenuInicio
        ' 
        MenuInicio.Name = "MenuInicio"
        MenuInicio.Size = New Size(59, 24)
        MenuInicio.Text = "Inicio"
        MenuInicio.Visible = False
        ' 
        ' MenuPacientes
        ' 
        MenuPacientes.Name = "MenuPacientes"
        MenuPacientes.Size = New Size(84, 24)
        MenuPacientes.Text = "Pacientes"
        MenuPacientes.Visible = False
        ' 
        ' MenuTurnos
        ' 
        MenuTurnos.Name = "MenuTurnos"
        MenuTurnos.Size = New Size(67, 24)
        MenuTurnos.Text = "Turnos"
        MenuTurnos.Visible = False
        ' 
        ' MenuAdmin
        ' 
        MenuAdmin.Name = "MenuAdmin"
        MenuAdmin.Size = New Size(67, 24)
        MenuAdmin.Text = "Admin"
        MenuAdmin.Visible = False
        ' 
        ' ToolStripContainer1
        ' 
        ToolStripContainer1.BottomToolStripPanelVisible = False
        ' 
        ' ToolStripContainer1.ContentPanel
        ' 
        ToolStripContainer1.ContentPanel.BackColor = SystemColors.ControlText
        ToolStripContainer1.ContentPanel.BackgroundImage = CType(resources.GetObject("ToolStripContainer1.ContentPanel.BackgroundImage"), Image)
        ToolStripContainer1.ContentPanel.Controls.Add(GroupBox1)
        ToolStripContainer1.ContentPanel.ForeColor = SystemColors.ActiveBorder
        ToolStripContainer1.ContentPanel.Size = New Size(1382, 754)
        ToolStripContainer1.Dock = DockStyle.Fill
        ToolStripContainer1.LeftToolStripPanelVisible = False
        ToolStripContainer1.Location = New Point(0, 24)
        ToolStripContainer1.Name = "ToolStripContainer1"
        ToolStripContainer1.RightToolStripPanelVisible = False
        ToolStripContainer1.Size = New Size(1382, 779)
        ToolStripContainer1.TabIndex = 3
        ToolStripContainer1.Text = "ToolStripContainer1"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Transparent
        GroupBox1.Controls.Add(BtnLogin)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(LogintxtPassword)
        GroupBox1.Controls.Add(LogintxtUsuario)
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(440, 143)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(314, 386)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Login"
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.Lime
        BtnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        BtnLogin.ForeColor = SystemColors.Desktop
        BtnLogin.Location = New Point(108, 323)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(104, 45)
        BtnLogin.TabIndex = 5
        BtnLogin.Text = "INGRESAR"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(108, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(104, 102)
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.HighlightText
        Label2.Location = New Point(88, 246)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 28)
        Label2.TabIndex = 3
        Label2.Text = "CONTRASEÑA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.HighlightText
        Label1.Location = New Point(108, 177)
        Label1.Name = "Label1"
        Label1.Size = New Size(99, 28)
        Label1.TabIndex = 2
        Label1.Text = "USUARIO"
        ' 
        ' LogintxtPassword
        ' 
        LogintxtPassword.Location = New Point(45, 281)
        LogintxtPassword.Name = "LogintxtPassword"
        LogintxtPassword.PasswordChar = "*"c
        LogintxtPassword.Size = New Size(222, 27)
        LogintxtPassword.TabIndex = 1
        ' 
        ' LogintxtUsuario
        ' 
        LogintxtUsuario.BorderStyle = BorderStyle.FixedSingle
        LogintxtUsuario.Location = New Point(45, 210)
        LogintxtUsuario.Name = "LogintxtUsuario"
        LogintxtUsuario.Size = New Size(222, 27)
        LogintxtUsuario.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1382, 803)
        Controls.Add(ToolStripContainer1)
        Controls.Add(Button1)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Sistema de Turnos"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ToolStripContainer1.ContentPanel.ResumeLayout(False)
        ToolStripContainer1.ResumeLayout(False)
        ToolStripContainer1.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuInicio As ToolStripMenuItem
    Friend WithEvents MenuPacientes As ToolStripMenuItem
    Friend WithEvents MenuTurnos As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LogintxtPassword As TextBox
    Friend WithEvents LogintxtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnLogin As Button
    Friend WithEvents MenuAdmin As ToolStripMenuItem

End Class
