<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsers
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
        Panel1 = New Panel()
        txtUserPassword = New TextBox()
        txtUserName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        chkBoxSuperAdmin = New CheckBox()
        Panel3 = New Panel()
        lvwUsers = New ListView()
        btnSave = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        Button4 = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        btnadd = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtUserPassword)
        Panel1.Controls.Add(txtUserName)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(25, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(647, 103)
        Panel1.TabIndex = 0
        ' 
        ' txtUserPassword
        ' 
        txtUserPassword.Location = New Point(426, 6)
        txtUserPassword.Name = "txtUserPassword"
        txtUserPassword.PasswordChar = "*"c
        txtUserPassword.ReadOnly = True
        txtUserPassword.Size = New Size(209, 23)
        txtUserPassword.TabIndex = 7
        ' 
        ' txtUserName
        ' 
        txtUserName.Location = New Point(83, 6)
        txtUserName.Name = "txtUserName"
        txtUserName.ReadOnly = True
        txtUserName.Size = New Size(209, 23)
        txtUserName.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(341, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 4
        Label1.Text = "Username:"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(chkBoxSuperAdmin)
        Panel2.Location = New Point(25, 134)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(647, 50)
        Panel2.TabIndex = 1
        ' 
        ' chkBoxSuperAdmin
        ' 
        chkBoxSuperAdmin.AutoSize = True
        chkBoxSuperAdmin.Enabled = False
        chkBoxSuperAdmin.Location = New Point(27, 25)
        chkBoxSuperAdmin.Name = "chkBoxSuperAdmin"
        chkBoxSuperAdmin.Size = New Size(95, 19)
        chkBoxSuperAdmin.TabIndex = 0
        chkBoxSuperAdmin.Text = "Super Admin"
        chkBoxSuperAdmin.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lvwUsers)
        Panel3.Location = New Point(25, 190)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(647, 187)
        Panel3.TabIndex = 2
        ' 
        ' lvwUsers
        ' 
        lvwUsers.Dock = DockStyle.Fill
        lvwUsers.FullRowSelect = True
        lvwUsers.Location = New Point(0, 0)
        lvwUsers.MultiSelect = False
        lvwUsers.Name = "lvwUsers"
        lvwUsers.Size = New Size(647, 187)
        lvwUsers.TabIndex = 0
        lvwUsers.UseCompatibleStateImageBehavior = False
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(29, 400)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 26)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(108, 400)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 26)
        btnEdit.TabIndex = 4
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(186, 400)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 26)
        btnDelete.TabIndex = 5
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(532, 400)
        Button4.Name = "Button4"
        Button4.Size = New Size(140, 26)
        Button4.TabIndex = 6
        Button4.Text = "User Listing Report"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnadd
        ' 
        btnadd.Location = New Point(267, 400)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(75, 26)
        btnadd.TabIndex = 7
        btnadd.Text = "Add New"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' frmUsers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(691, 450)
        Controls.Add(btnadd)
        Controls.Add(Button4)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnSave)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmUsers"
        Text = "frmUsers"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chkBoxSuperAdmin As CheckBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lvwUsers As ListView
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txtUserPassword As TextBox
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnadd As Button
End Class
