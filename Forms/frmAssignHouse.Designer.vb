<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssignHouse
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
        Panel1 = New Panel()
        combo_category = New ComboBox()
        combo_status = New ComboBox()
        Label4 = New Label()
        combo_location = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Panel2 = New Panel()
        lvwHouses = New ListView()
        Panel3 = New Panel()
        txtDeposit = New TextBox()
        txt_rent = New TextBox()
        txt_houseNo = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        txt_id = New TextBox()
        combo_tenantName = New ComboBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(combo_category)
        Panel1.Controls.Add(combo_status)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(combo_location)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1047, 65)
        Panel1.TabIndex = 0
        ' 
        ' combo_category
        ' 
        combo_category.BackColor = Color.Turquoise
        combo_category.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        combo_category.FormattingEnabled = True
        combo_category.Location = New Point(332, 16)
        combo_category.Name = "combo_category"
        combo_category.Size = New Size(320, 28)
        combo_category.TabIndex = 2
        ' 
        ' combo_status
        ' 
        combo_status.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        combo_status.FormattingEnabled = True
        combo_status.Location = New Point(731, 16)
        combo_status.Name = "combo_status"
        combo_status.Size = New Size(169, 28)
        combo_status.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(679, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 17)
        Label4.TabIndex = 5
        Label4.Text = "Status"
        ' 
        ' combo_location
        ' 
        combo_location.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        combo_location.FormattingEnabled = True
        combo_location.Location = New Point(71, 16)
        combo_location.Name = "combo_location"
        combo_location.Size = New Size(185, 28)
        combo_location.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(262, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 17)
        Label2.TabIndex = 2
        Label2.Text = "Category"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(4, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(61, 17)
        Label1.TabIndex = 1
        Label1.Text = "Location"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = My.Resources.Resources.cog_solid_24
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(929, 13)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 36)
        Button1.TabIndex = 0
        Button1.Text = "Generate"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = SystemColors.GradientInactiveCaption
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(lvwHouses)
        Panel2.Location = New Point(12, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1047, 155)
        Panel2.TabIndex = 1
        ' 
        ' lvwHouses
        ' 
        lvwHouses.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvwHouses.BorderStyle = BorderStyle.FixedSingle
        lvwHouses.Location = New Point(3, 12)
        lvwHouses.Name = "lvwHouses"
        lvwHouses.Size = New Size(1037, 136)
        lvwHouses.TabIndex = 0
        lvwHouses.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(txtDeposit)
        Panel3.Controls.Add(txt_rent)
        Panel3.Controls.Add(txt_houseNo)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(txt_id)
        Panel3.Controls.Add(combo_tenantName)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(12, 266)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1047, 200)
        Panel3.TabIndex = 2
        ' 
        ' txtDeposit
        ' 
        txtDeposit.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtDeposit.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txtDeposit.Location = New Point(115, 134)
        txtDeposit.Name = "txtDeposit"
        txtDeposit.Size = New Size(88, 33)
        txtDeposit.TabIndex = 14
        txtDeposit.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_rent
        ' 
        txt_rent.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_rent.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_rent.Location = New Point(115, 95)
        txt_rent.Name = "txt_rent"
        txt_rent.Size = New Size(88, 33)
        txt_rent.TabIndex = 13
        txt_rent.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_houseNo
        ' 
        txt_houseNo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_houseNo.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_houseNo.Location = New Point(115, 53)
        txt_houseNo.Name = "txt_houseNo"
        txt_houseNo.Size = New Size(88, 33)
        txt_houseNo.TabIndex = 12
        txt_houseNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(53, 143)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 17)
        Label9.TabIndex = 11
        Label9.Text = "Deposit"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(72, 104)
        Label8.Name = "Label8"
        Label8.Size = New Size(37, 17)
        Label8.TabIndex = 10
        Label8.Text = "Rent"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(50, 62)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 17)
        Label6.TabIndex = 8
        Label6.Text = "House #"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(471, 26)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 17)
        Label5.TabIndex = 7
        Label5.Text = "Tenant ID:"
        ' 
        ' txt_id
        ' 
        txt_id.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_id.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_id.Location = New Point(551, 19)
        txt_id.Name = "txt_id"
        txt_id.Size = New Size(66, 33)
        txt_id.TabIndex = 6
        txt_id.TextAlign = HorizontalAlignment.Center
        ' 
        ' combo_tenantName
        ' 
        combo_tenantName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        combo_tenantName.FormattingEnabled = True
        combo_tenantName.Location = New Point(115, 19)
        combo_tenantName.Name = "combo_tenantName"
        combo_tenantName.Size = New Size(336, 28)
        combo_tenantName.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(17, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 17)
        Label3.TabIndex = 4
        Label3.Text = "Tenant Name"
        ' 
        ' frmAssignHouse
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1071, 512)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmAssignHouse"
        Text = "Assign House"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lvwHouses As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents combo_location As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_tenantName As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents combo_status As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents combo_category As ComboBox
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txt_rent As TextBox
    Friend WithEvents txt_houseNo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
End Class
