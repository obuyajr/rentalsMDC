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
        txtName = New TextBox()
        Label3 = New Label()
        txtUserPassword = New TextBox()
        txtUserName = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        chkBoxMakePayment = New CheckBox()
        chkBoxAddTenants = New CheckBox()
        chkboxAddHouse = New CheckBox()
        chkBoxSuperAdmin = New CheckBox()
        Panel3 = New Panel()
        lvwUsers = New ListView()
        btnSave = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        Button4 = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        btnadd = New Button()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.Snow
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtUserPassword)
        Panel1.Controls.Add(txtUserName)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1013, 63)
        Panel1.TabIndex = 0
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtName.Location = New Point(77, 18)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(321, 28)
        txtName.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(22, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 17)
        Label3.TabIndex = 8
        Label3.Text = "Name:"
        ' 
        ' txtUserPassword
        ' 
        txtUserPassword.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtUserPassword.Location = New Point(787, 19)
        txtUserPassword.Name = "txtUserPassword"
        txtUserPassword.PasswordChar = "*"c
        txtUserPassword.ReadOnly = True
        txtUserPassword.Size = New Size(209, 28)
        txtUserPassword.TabIndex = 3
        ' 
        ' txtUserName
        ' 
        txtUserName.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtUserName.Location = New Point(485, 19)
        txtUserName.Name = "txtUserName"
        txtUserName.ReadOnly = True
        txtUserName.Size = New Size(209, 28)
        txtUserName.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(712, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 17)
        Label2.TabIndex = 5
        Label2.Text = "Password"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(404, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 17)
        Label1.TabIndex = 4
        Label1.Text = "Username:"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.Snow
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(chkBoxMakePayment)
        Panel2.Controls.Add(chkBoxAddTenants)
        Panel2.Controls.Add(chkboxAddHouse)
        Panel2.Controls.Add(chkBoxSuperAdmin)
        Panel2.Location = New Point(12, 93)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1013, 148)
        Panel2.TabIndex = 1
        ' 
        ' chkBoxMakePayment
        ' 
        chkBoxMakePayment.AutoSize = True
        chkBoxMakePayment.Enabled = False
        chkBoxMakePayment.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        chkBoxMakePayment.Location = New Point(197, 14)
        chkBoxMakePayment.Name = "chkBoxMakePayment"
        chkBoxMakePayment.Size = New Size(121, 21)
        chkBoxMakePayment.TabIndex = 7
        chkBoxMakePayment.Text = "Make Payment"
        chkBoxMakePayment.UseVisualStyleBackColor = True
        ' 
        ' chkBoxAddTenants
        ' 
        chkBoxAddTenants.AutoSize = True
        chkBoxAddTenants.Enabled = False
        chkBoxAddTenants.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        chkBoxAddTenants.Location = New Point(22, 92)
        chkBoxAddTenants.Name = "chkBoxAddTenants"
        chkBoxAddTenants.Size = New Size(106, 21)
        chkBoxAddTenants.TabIndex = 6
        chkBoxAddTenants.Text = "Add Tenants"
        chkBoxAddTenants.UseVisualStyleBackColor = True
        ' 
        ' chkboxAddHouse
        ' 
        chkboxAddHouse.AutoSize = True
        chkboxAddHouse.Enabled = False
        chkboxAddHouse.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        chkboxAddHouse.Location = New Point(22, 54)
        chkboxAddHouse.Name = "chkboxAddHouse"
        chkboxAddHouse.Size = New Size(102, 21)
        chkboxAddHouse.TabIndex = 5
        chkboxAddHouse.Text = "Add Houses"
        chkboxAddHouse.UseVisualStyleBackColor = True
        ' 
        ' chkBoxSuperAdmin
        ' 
        chkBoxSuperAdmin.AutoSize = True
        chkBoxSuperAdmin.Enabled = False
        chkBoxSuperAdmin.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        chkBoxSuperAdmin.Location = New Point(22, 14)
        chkBoxSuperAdmin.Name = "chkBoxSuperAdmin"
        chkBoxSuperAdmin.Size = New Size(109, 21)
        chkBoxSuperAdmin.TabIndex = 4
        chkBoxSuperAdmin.Text = "Super Admin"
        chkBoxSuperAdmin.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.Controls.Add(lvwUsers)
        Panel3.Location = New Point(12, 260)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1013, 204)
        Panel3.TabIndex = 2
        ' 
        ' lvwUsers
        ' 
        lvwUsers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvwUsers.BackColor = Color.Snow
        lvwUsers.BorderStyle = BorderStyle.FixedSingle
        lvwUsers.FullRowSelect = True
        lvwUsers.Location = New Point(0, 13)
        lvwUsers.MultiSelect = False
        lvwUsers.Name = "lvwUsers"
        lvwUsers.Size = New Size(1013, 175)
        lvwUsers.TabIndex = 8
        lvwUsers.UseCompatibleStateImageBehavior = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.LightCoral
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.Location = New Point(23, 23)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 26)
        btnSave.TabIndex = 9
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.LightCoral
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnEdit.Location = New Point(154, 23)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 26)
        btnEdit.TabIndex = 10
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.LightCoral
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.Location = New Point(310, 23)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 26)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.LightCoral
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(749, 23)
        Button4.Name = "Button4"
        Button4.Size = New Size(140, 26)
        Button4.TabIndex = 13
        Button4.Text = "User Listing Report"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.LightCoral
        btnadd.FlatStyle = FlatStyle.Flat
        btnadd.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnadd.Location = New Point(467, 23)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(84, 26)
        btnadd.TabIndex = 12
        btnadd.Text = "Add New"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel4.BackColor = Color.WhiteSmoke
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(Button4)
        Panel4.Controls.Add(btnadd)
        Panel4.Controls.Add(btnSave)
        Panel4.Controls.Add(btnEdit)
        Panel4.Controls.Add(btnDelete)
        Panel4.Location = New Point(12, 470)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1013, 70)
        Panel4.TabIndex = 8
        ' 
        ' frmUsers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1037, 547)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "frmUsers"
        StartPosition = FormStartPosition.Manual
        Text = "Users"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
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
    Friend WithEvents Panel4 As Panel
    Friend WithEvents chkBoxMakePayment As CheckBox
    Friend WithEvents chkBoxAddTenants As CheckBox
    Friend WithEvents chkboxAddHouse As CheckBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
End Class
