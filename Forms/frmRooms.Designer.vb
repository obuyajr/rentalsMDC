<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRooms
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Panel3 = New Panel()
        btn_reset = New Button()
        Button4 = New Button()
        btnadd = New Button()
        btnSave = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        Panel2 = New Panel()
        lvwRooms = New ListView()
        Panel1 = New Panel()
        chkboxStatus = New CheckBox()
        combo_vat = New ComboBox()
        combo_rtype = New ComboBox()
        txtRates = New TextBox()
        txtRoomNo = New TextBox()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        Label5 = New Label()
        Panel4 = New Panel()
        ErrorProvider1 = New ErrorProvider(components)
        combo_category = New ComboBox()
        Label9 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        Label10 = New Label()
        Label11 = New Label()
        Button1 = New Button()
        ListView1 = New ListView()
        Panel5 = New Panel()
        txtDeposit = New TextBox()
        txt_rent = New TextBox()
        txt_houseNo = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        txt_id = New TextBox()
        Label14 = New Label()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(0, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1080, 644)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.MistyRose
        TabPage1.Controls.Add(Panel3)
        TabPage1.Controls.Add(Panel2)
        TabPage1.Controls.Add(Panel1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1072, 545)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Room Operations"
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btn_reset)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(btnadd)
        Panel3.Controls.Add(btnSave)
        Panel3.Controls.Add(btnEdit)
        Panel3.Controls.Add(btnDelete)
        Panel3.Location = New Point(8, 476)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1047, 63)
        Panel3.TabIndex = 4
        ' 
        ' btn_reset
        ' 
        btn_reset.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_reset.Location = New Point(565, 20)
        btn_reset.Name = "btn_reset"
        btn_reset.Size = New Size(84, 26)
        btn_reset.TabIndex = 13
        btn_reset.Text = "Reset house"
        btn_reset.UseVisualStyleBackColor = True
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
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(lvwRooms)
        Panel2.Location = New Point(3, 129)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1063, 330)
        Panel2.TabIndex = 3
        ' 
        ' lvwRooms
        ' 
        lvwRooms.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lvwRooms.BackColor = Color.White
        lvwRooms.Location = New Point(3, 15)
        lvwRooms.Name = "lvwRooms"
        lvwRooms.Size = New Size(1053, 308)
        lvwRooms.TabIndex = 0
        lvwRooms.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(chkboxStatus)
        Panel1.Controls.Add(combo_vat)
        Panel1.Controls.Add(combo_rtype)
        Panel1.Controls.Add(txtRates)
        Panel1.Controls.Add(txtRoomNo)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(3, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1063, 97)
        Panel1.TabIndex = 2
        ' 
        ' chkboxStatus
        ' 
        chkboxStatus.AutoSize = True
        chkboxStatus.Checked = True
        chkboxStatus.CheckState = CheckState.Checked
        chkboxStatus.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        chkboxStatus.Location = New Point(86, 61)
        chkboxStatus.Name = "chkboxStatus"
        chkboxStatus.Size = New Size(86, 21)
        chkboxStatus.TabIndex = 7
        chkboxStatus.Text = "Available"
        chkboxStatus.UseVisualStyleBackColor = True
        ' 
        ' combo_vat
        ' 
        combo_vat.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        combo_vat.FormattingEnabled = True
        combo_vat.Items.AddRange(New Object() {"V", "Z"})
        combo_vat.Location = New Point(884, 26)
        combo_vat.Name = "combo_vat"
        combo_vat.Size = New Size(140, 27)
        combo_vat.TabIndex = 6
        ' 
        ' combo_rtype
        ' 
        combo_rtype.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        combo_rtype.FormattingEnabled = True
        combo_rtype.Items.AddRange(New Object() {"ECONOMY(1 BED)", "ECONOMY(2 BEDS)", "LUXURIOUS"})
        combo_rtype.Location = New Point(347, 26)
        combo_rtype.Name = "combo_rtype"
        combo_rtype.Size = New Size(257, 27)
        combo_rtype.TabIndex = 3
        ' 
        ' txtRates
        ' 
        txtRates.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtRates.Location = New Point(676, 26)
        txtRates.Name = "txtRates"
        txtRates.Size = New Size(122, 27)
        txtRates.TabIndex = 5
        ' 
        ' txtRoomNo
        ' 
        txtRoomNo.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtRoomNo.Location = New Point(86, 28)
        txtRoomNo.Name = "txtRoomNo"
        txtRoomNo.Size = New Size(155, 27)
        txtRoomNo.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(623, 34)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 15)
        Label6.TabIndex = 5
        Label6.Text = "Rates :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(259, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 15)
        Label4.TabIndex = 3
        Label4.Text = "Room Type :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(835, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 2
        Label3.Text = "VAT :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(9, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 1
        Label2.Text = "Room No:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 20)
        Label1.TabIndex = 0
        Label1.Text = "Room Details"
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.MistyRose
        TabPage2.Controls.Add(Panel5)
        TabPage2.Controls.Add(ListView1)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Panel4)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1072, 616)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Book Rooms"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(6, 3)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 21)
        Label5.TabIndex = 0
        Label5.Text = "Selection Criteria :"
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel4.BackColor = Color.White
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(Button1)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(DateTimePicker2)
        Panel4.Controls.Add(DateTimePicker1)
        Panel4.Controls.Add(combo_category)
        Panel4.Controls.Add(Label9)
        Panel4.Location = New Point(6, 19)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1063, 103)
        Panel4.TabIndex = 0
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' combo_category
        ' 
        combo_category.BackColor = Color.Turquoise
        combo_category.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        combo_category.FormattingEnabled = True
        combo_category.Location = New Point(90, 11)
        combo_category.Name = "combo_category"
        combo_category.Size = New Size(213, 28)
        combo_category.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(5, 11)
        Label9.Name = "Label9"
        Label9.Size = New Size(79, 17)
        Label9.TabIndex = 7
        Label9.Text = "Room Type"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(419, 14)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(185, 25)
        DateTimePicker1.TabIndex = 12
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Font = New Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker2.Location = New Point(695, 14)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(185, 25)
        DateTimePicker2.TabIndex = 13
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(642, 20)
        Label10.Name = "Label10"
        Label10.Size = New Size(32, 17)
        Label10.TabIndex = 14
        Label10.Text = "To :"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(349, 18)
        Label11.Name = "Label11"
        Label11.Size = New Size(49, 17)
        Label11.TabIndex = 15
        Label11.Text = "From :"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = My.Resources.Resources.search_alt_2_regular_24
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(916, 7)
        Button1.Name = "Button1"
        Button1.Size = New Size(129, 37)
        Button1.TabIndex = 16
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.BorderStyle = BorderStyle.FixedSingle
        ListView1.Location = New Point(6, 162)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1060, 214)
        ListView1.TabIndex = 1
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(txtDeposit)
        Panel5.Controls.Add(txt_rent)
        Panel5.Controls.Add(txt_houseNo)
        Panel5.Controls.Add(Label7)
        Panel5.Controls.Add(Label8)
        Panel5.Controls.Add(Label12)
        Panel5.Controls.Add(Label13)
        Panel5.Controls.Add(txt_id)
        Panel5.Controls.Add(Label14)
        Panel5.Location = New Point(6, 382)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1060, 228)
        Panel5.TabIndex = 2
        ' 
        ' txtDeposit
        ' 
        txtDeposit.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtDeposit.ForeColor = Color.Red
        txtDeposit.Location = New Point(112, 149)
        txtDeposit.Name = "txtDeposit"
        txtDeposit.Size = New Size(140, 33)
        txtDeposit.TabIndex = 24
        txtDeposit.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_rent
        ' 
        txt_rent.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_rent.ForeColor = Color.Red
        txt_rent.Location = New Point(112, 93)
        txt_rent.Name = "txt_rent"
        txt_rent.Size = New Size(140, 33)
        txt_rent.TabIndex = 23
        txt_rent.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_houseNo
        ' 
        txt_houseNo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_houseNo.ForeColor = Color.Red
        txt_houseNo.Location = New Point(112, 49)
        txt_houseNo.Name = "txt_houseNo"
        txt_houseNo.Size = New Size(295, 33)
        txt_houseNo.TabIndex = 22
        txt_houseNo.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(347, 174)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 17)
        Label7.TabIndex = 21
        Label7.Text = "Deposit"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(62, 102)
        Label8.Name = "Label8"
        Label8.Size = New Size(35, 17)
        Label8.TabIndex = 20
        Label8.Text = "ID #"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(344, 93)
        Label12.Name = "Label12"
        Label12.Size = New Size(59, 17)
        Label12.TabIndex = 19
        Label12.Text = "House #"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(5, 58)
        Label13.Name = "Label13"
        Label13.Size = New Size(101, 17)
        Label13.TabIndex = 18
        Label13.Text = "Phonenumber "
        ' 
        ' txt_id
        ' 
        txt_id.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_id.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_id.Location = New Point(112, 3)
        txt_id.Name = "txt_id"
        txt_id.Size = New Size(295, 33)
        txt_id.TabIndex = 17
        txt_id.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(5, 10)
        Label14.Name = "Label14"
        Label14.Size = New Size(92, 17)
        Label14.TabIndex = 16
        Label14.Text = "Tenant Name"
        ' 
        ' frmRooms
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1080, 651)
        Controls.Add(TabControl1)
        Name = "frmRooms"
        StartPosition = FormStartPosition.Manual
        Text = "Rooms"
        WindowState = FormWindowState.Maximized
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents combo_vat As ComboBox
    Friend WithEvents combo_rtype As ComboBox
    Friend WithEvents txtRates As TextBox
    Friend WithEvents txtRoomNo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lvwRooms As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_reset As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents chkboxStatus As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents combo_category As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtDeposit As TextBox
    Friend WithEvents txt_rent As TextBox
    Friend WithEvents txt_houseNo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label14 As Label
End Class
