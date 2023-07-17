<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        txtUserName = New TextBox()
        txtUserPassword = New TextBox()
        btnLogin = New Button()
        btnCancel = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label3 = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(20, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 17)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(22, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 17)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' txtUserName
        ' 
        txtUserName.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtUserName.Location = New Point(110, 24)
        txtUserName.Name = "txtUserName"
        txtUserName.Size = New Size(289, 29)
        txtUserName.TabIndex = 2
        ' 
        ' txtUserPassword
        ' 
        txtUserPassword.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtUserPassword.Location = New Point(110, 79)
        txtUserPassword.Name = "txtUserPassword"
        txtUserPassword.PasswordChar = "*"c
        txtUserPassword.Size = New Size(289, 29)
        txtUserPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.LavenderBlush
        btnLogin.FlatStyle = FlatStyle.Popup
        btnLogin.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnLogin.ForeColor = Color.Black
        btnLogin.Image = My.Resources.Resources.fast_forward_circle_solid_36
        btnLogin.ImageAlign = ContentAlignment.MiddleRight
        btnLogin.Location = New Point(110, 140)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(88, 39)
        btnLogin.TabIndex = 4
        btnLogin.Text = "Login"
        btnLogin.TextAlign = ContentAlignment.MiddleLeft
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.LavenderBlush
        btnCancel.DialogResult = DialogResult.Cancel
        btnCancel.FlatStyle = FlatStyle.Popup
        btnCancel.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnCancel.ForeColor = Color.Black
        btnCancel.Image = My.Resources.Resources.x_regular_36
        btnCancel.ImageAlign = ContentAlignment.MiddleRight
        btnCancel.Location = New Point(311, 140)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(88, 39)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.TextAlign = ContentAlignment.MiddleLeft
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Indigo
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(428, 103)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(btnCancel)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(txtUserPassword)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(txtUserName)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 103)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(428, 267)
        Panel2.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Indigo
        Panel3.Controls.Add(Label3)
        Panel3.Dock = DockStyle.Bottom
        Panel3.Location = New Point(0, 296)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(428, 74)
        Panel3.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.ForeColor = Color.White
        Label3.Location = New Point(159, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 15)
        Label3.TabIndex = 0
        Label3.Text = "copyrights reserved"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(428, 370)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmLogin"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtUserPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
End Class
