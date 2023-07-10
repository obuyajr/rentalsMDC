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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        combo_category = New ComboBox()
        combo_status = New ComboBox()
        Label4 = New Label()
        combo_location = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        btnGenerate = New Button()
        Panel2 = New Panel()
        btn_display = New Button()
        lvwHouses = New ListView()
        Panel3 = New Panel()
        Label7 = New Label()
        txt_total = New TextBox()
        btn_assignHouse = New Button()
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
        ErrorProvider1 = New ErrorProvider(components)
        chkbox_bill = New CheckBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.Controls.Add(btnGenerate)
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
        ' btnGenerate
        ' 
        btnGenerate.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnGenerate.Image = My.Resources.Resources.cog_solid_24
        btnGenerate.ImageAlign = ContentAlignment.MiddleRight
        btnGenerate.Location = New Point(929, 13)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(112, 36)
        btnGenerate.TabIndex = 0
        btnGenerate.Text = "Generate"
        btnGenerate.TextAlign = ContentAlignment.MiddleLeft
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = SystemColors.GradientInactiveCaption
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(btn_display)
        Panel2.Controls.Add(lvwHouses)
        Panel2.Location = New Point(12, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1047, 245)
        Panel2.TabIndex = 1
        ' 
        ' btn_display
        ' 
        btn_display.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btn_display.BackColor = SystemColors.HighlightText
        btn_display.FlatStyle = FlatStyle.Popup
        btn_display.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_display.ForeColor = Color.Green
        btn_display.Image = My.Resources.Resources.desktop_regular_24
        btn_display.ImageAlign = ContentAlignment.MiddleRight
        btn_display.Location = New Point(17, 202)
        btn_display.Name = "btn_display"
        btn_display.Size = New Size(129, 36)
        btn_display.TabIndex = 1
        btn_display.Text = "Display"
        btn_display.TextAlign = ContentAlignment.MiddleLeft
        btn_display.UseVisualStyleBackColor = False
        ' 
        ' lvwHouses
        ' 
        lvwHouses.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvwHouses.BorderStyle = BorderStyle.FixedSingle
        lvwHouses.Location = New Point(3, 12)
        lvwHouses.Name = "lvwHouses"
        lvwHouses.Size = New Size(1037, 175)
        lvwHouses.TabIndex = 0
        lvwHouses.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(chkbox_bill)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(txt_total)
        Panel3.Controls.Add(btn_assignHouse)
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
        Panel3.Location = New Point(12, 334)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1047, 241)
        Panel3.TabIndex = 2
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(914, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 25)
        Label7.TabIndex = 17
        Label7.Text = "TOTAL"
        ' 
        ' txt_total
        ' 
        txt_total.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point)
        txt_total.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_total.Location = New Point(878, 46)
        txt_total.Name = "txt_total"
        txt_total.Size = New Size(150, 51)
        txt_total.TabIndex = 16
        txt_total.TextAlign = HorizontalAlignment.Center
        ' 
        ' btn_assignHouse
        ' 
        btn_assignHouse.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btn_assignHouse.ForeColor = Color.Green
        btn_assignHouse.Image = My.Resources.Resources.right_arrow_solid_24
        btn_assignHouse.ImageAlign = ContentAlignment.MiddleRight
        btn_assignHouse.Location = New Point(878, 171)
        btn_assignHouse.Name = "btn_assignHouse"
        btn_assignHouse.Size = New Size(150, 49)
        btn_assignHouse.TabIndex = 15
        btn_assignHouse.Text = "Assign House"
        btn_assignHouse.TextAlign = ContentAlignment.MiddleLeft
        btn_assignHouse.UseVisualStyleBackColor = True
        ' 
        ' txtDeposit
        ' 
        txtDeposit.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtDeposit.ForeColor = Color.Red
        txtDeposit.Location = New Point(115, 194)
        txtDeposit.Name = "txtDeposit"
        txtDeposit.Size = New Size(140, 33)
        txtDeposit.TabIndex = 14
        txtDeposit.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_rent
        ' 
        txt_rent.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_rent.ForeColor = Color.Red
        txt_rent.Location = New Point(115, 155)
        txt_rent.Name = "txt_rent"
        txt_rent.Size = New Size(140, 33)
        txt_rent.TabIndex = 13
        txt_rent.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_houseNo
        ' 
        txt_houseNo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_houseNo.ForeColor = Color.Red
        txt_houseNo.Location = New Point(115, 113)
        txt_houseNo.Name = "txt_houseNo"
        txt_houseNo.Size = New Size(140, 33)
        txt_houseNo.TabIndex = 12
        txt_houseNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(53, 203)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 17)
        Label9.TabIndex = 11
        Label9.Text = "Deposit"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(72, 164)
        Label8.Name = "Label8"
        Label8.Size = New Size(37, 17)
        Label8.TabIndex = 10
        Label8.Text = "Rent"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(50, 122)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 17)
        Label6.TabIndex = 8
        Label6.Text = "House #"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(35, 71)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 17)
        Label5.TabIndex = 7
        Label5.Text = "Tenant ID:"
        ' 
        ' txt_id
        ' 
        txt_id.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_id.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_id.Location = New Point(115, 64)
        txt_id.Name = "txt_id"
        txt_id.Size = New Size(140, 33)
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
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' chkbox_bill
        ' 
        chkbox_bill.AutoSize = True
        chkbox_bill.Checked = True
        chkbox_bill.CheckState = CheckState.Checked
        chkbox_bill.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        chkbox_bill.Location = New Point(292, 203)
        chkbox_bill.Name = "chkbox_bill"
        chkbox_bill.Size = New Size(48, 21)
        chkbox_bill.TabIndex = 18
        chkbox_bill.Text = "Bill"
        chkbox_bill.UseVisualStyleBackColor = True
        ' 
        ' frmAssignHouse
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1071, 580)
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
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGenerate As Button
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
    Friend WithEvents btn_assignHouse As Button
    Friend WithEvents btn_display As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_total As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents chkbox_bill As CheckBox
End Class
