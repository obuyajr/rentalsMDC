<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTenants
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
        txt_NOK_phone = New TextBox()
        txt_NOK = New TextBox()
        txtEmail = New TextBox()
        txtContact = New TextBox()
        txtNationalId = New TextBox()
        txtName = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        lvwTenants = New ListView()
        Panel3 = New Panel()
        Button4 = New Button()
        btnadd = New Button()
        btnSave = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        Label8 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(txt_NOK_phone)
        Panel1.Controls.Add(txt_NOK)
        Panel1.Controls.Add(txtEmail)
        Panel1.Controls.Add(txtContact)
        Panel1.Controls.Add(txtNationalId)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1047, 156)
        Panel1.TabIndex = 0
        ' 
        ' txt_NOK_phone
        ' 
        txt_NOK_phone.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_NOK_phone.Location = New Point(777, 86)
        txt_NOK_phone.Name = "txt_NOK_phone"
        txt_NOK_phone.Size = New Size(261, 25)
        txt_NOK_phone.TabIndex = 12
        ' 
        ' txt_NOK
        ' 
        txt_NOK.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txt_NOK.Location = New Point(777, 34)
        txt_NOK.Name = "txt_NOK"
        txt_NOK.Size = New Size(261, 25)
        txt_NOK.TabIndex = 11
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtEmail.Location = New Point(424, 86)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(261, 25)
        txtEmail.TabIndex = 10
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtContact.Location = New Point(424, 34)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(261, 25)
        txtContact.TabIndex = 9
        ' 
        ' txtNationalId
        ' 
        txtNationalId.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtNationalId.Location = New Point(86, 88)
        txtNationalId.Name = "txtNationalId"
        txtNationalId.Size = New Size(261, 25)
        txtNationalId.TabIndex = 8
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtName.Location = New Point(86, 36)
        txtName.Name = "txtName"
        txtName.Size = New Size(261, 25)
        txtName.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(702, 91)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 15)
        Label7.TabIndex = 6
        Label7.Text = "NOK Phone:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(702, 39)
        Label6.Name = "Label6"
        Label6.Size = New Size(69, 15)
        Label6.TabIndex = 5
        Label6.Text = "Next of Kin:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(379, 91)
        Label5.Name = "Label5"
        Label5.Size = New Size(39, 15)
        Label5.TabIndex = 4
        Label5.Text = "Email:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(366, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 15)
        Label4.TabIndex = 3
        Label4.Text = "Contact:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 15)
        Label3.TabIndex = 2
        Label3.Text = "National ID:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(38, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 15)
        Label2.TabIndex = 1
        Label2.Text = "Name:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(113, 20)
        Label1.TabIndex = 0
        Label1.Text = "Tenant Details"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(lvwTenants)
        Panel2.Location = New Point(12, 192)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1047, 225)
        Panel2.TabIndex = 1
        ' 
        ' lvwTenants
        ' 
        lvwTenants.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvwTenants.BackColor = Color.White
        lvwTenants.Location = New Point(11, 15)
        lvwTenants.Name = "lvwTenants"
        lvwTenants.Size = New Size(1027, 203)
        lvwTenants.TabIndex = 0
        lvwTenants.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(btnadd)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnEdit)
        Panel3.Controls.Add(btnDelete)
        Panel3.Location = New Point(0, 437)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1059, 63)
        Panel3.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(911, 20)
        Button4.Name = "Button4"
        Button4.Size = New Size(140, 26)
        Button4.TabIndex = 11
        Button4.Text = "User Listing Report"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' btnadd
        ' 
        btnadd.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnadd.Location = New Point(424, 20)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(84, 26)
        btnadd.TabIndex = 12
        btnadd.Text = "Add New"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.Location = New Point(28, 20)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 26)
        btnSave.TabIndex = 8
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnEdit.Location = New Point(162, 20)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 26)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.Location = New Point(293, 20)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 26)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(11, 126)
        Label8.Name = "Label8"
        Label8.Size = New Size(27, 15)
        Label8.TabIndex = 13
        Label8.Text = "Pin:"
        ' 
        ' frmTenants
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1071, 512)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmTenants"
        Text = "Tenants"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_NOK_phone As TextBox
    Friend WithEvents txt_NOK As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtNationalId As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lvwTenants As ListView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label8 As Label
End Class
