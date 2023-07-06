<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHouses
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
        txtStatus = New TextBox()
        txtDeposit = New TextBox()
        txtRent = New TextBox()
        txtCategory = New TextBox()
        txtLocation = New TextBox()
        txtHouseNo = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        lvwHouses = New ListView()
        Panel3 = New Panel()
        Button4 = New Button()
        btnadd = New Button()
        btnSave = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        ErrorProvider1 = New ErrorProvider(components)
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
        Panel1.Controls.Add(txtStatus)
        Panel1.Controls.Add(txtDeposit)
        Panel1.Controls.Add(txtRent)
        Panel1.Controls.Add(txtCategory)
        Panel1.Controls.Add(txtLocation)
        Panel1.Controls.Add(txtHouseNo)
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
        Panel1.TabIndex = 1
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtStatus.Location = New Point(758, 86)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(261, 25)
        txtStatus.TabIndex = 12
        ' 
        ' txtDeposit
        ' 
        txtDeposit.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtDeposit.Location = New Point(758, 34)
        txtDeposit.Name = "txtDeposit"
        txtDeposit.Size = New Size(261, 25)
        txtDeposit.TabIndex = 11
        ' 
        ' txtRent
        ' 
        txtRent.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtRent.Location = New Point(424, 86)
        txtRent.Name = "txtRent"
        txtRent.Size = New Size(261, 25)
        txtRent.TabIndex = 10
        ' 
        ' txtCategory
        ' 
        txtCategory.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtCategory.Location = New Point(424, 34)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(261, 25)
        txtCategory.TabIndex = 9
        ' 
        ' txtLocation
        ' 
        txtLocation.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtLocation.Location = New Point(86, 88)
        txtLocation.Name = "txtLocation"
        txtLocation.Size = New Size(261, 25)
        txtLocation.TabIndex = 8
        ' 
        ' txtHouseNo
        ' 
        txtHouseNo.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        txtHouseNo.Location = New Point(86, 36)
        txtHouseNo.Name = "txtHouseNo"
        txtHouseNo.Size = New Size(261, 25)
        txtHouseNo.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(702, 91)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 6
        Label7.Text = "Status:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(702, 39)
        Label6.Name = "Label6"
        Label6.Size = New Size(50, 15)
        Label6.TabIndex = 5
        Label6.Text = "Deposit:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(384, 91)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 15)
        Label5.TabIndex = 4
        Label5.Text = "Rent:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(366, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 15)
        Label4.TabIndex = 3
        Label4.Text = "Category:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(17, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 2
        Label3.Text = "Location:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 1
        Label2.Text = "House No:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 20)
        Label1.TabIndex = 0
        Label1.Text = "House Details"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(lvwHouses)
        Panel2.Location = New Point(12, 192)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1047, 225)
        Panel2.TabIndex = 2
        ' 
        ' lvwHouses
        ' 
        lvwHouses.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        lvwHouses.BackColor = Color.White
        lvwHouses.Location = New Point(11, 15)
        lvwHouses.Name = "lvwHouses"
        lvwHouses.Size = New Size(1027, 203)
        lvwHouses.TabIndex = 0
        lvwHouses.UseCompatibleStateImageBehavior = False
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
        Panel3.Location = New Point(12, 437)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1047, 63)
        Panel3.TabIndex = 3
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(880, 20)
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
        ' frmHouses
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1071, 512)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmHouses"
        Text = "frmHouses"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txtRent As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents txtHouseNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lvwHouses As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
