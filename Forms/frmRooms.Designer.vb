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
        ErrorProvider1 = New ErrorProvider(components)
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
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
        TabControl1.Size = New Size(1080, 573)
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
        ' combo_vat
        ' 
        combo_vat.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        combo_vat.FormattingEnabled = True
        combo_vat.Items.AddRange(New Object() {"V", "Z"})
        combo_vat.Location = New Point(884, 34)
        combo_vat.Name = "combo_vat"
        combo_vat.Size = New Size(140, 27)
        combo_vat.TabIndex = 6
        ' 
        ' combo_rtype
        ' 
        combo_rtype.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        combo_rtype.FormattingEnabled = True
        combo_rtype.Items.AddRange(New Object() {"ECONOMY(1 BED)", "ECONOMY(2 BEDS)", "LUXURIOUS"})
        combo_rtype.Location = New Point(347, 34)
        combo_rtype.Name = "combo_rtype"
        combo_rtype.Size = New Size(257, 27)
        combo_rtype.TabIndex = 3
        ' 
        ' txtRates
        ' 
        txtRates.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtRates.Location = New Point(676, 34)
        txtRates.Name = "txtRates"
        txtRates.Size = New Size(122, 27)
        txtRates.TabIndex = 5
        ' 
        ' txtRoomNo
        ' 
        txtRoomNo.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtRoomNo.Location = New Point(86, 36)
        txtRoomNo.Name = "txtRoomNo"
        txtRoomNo.Size = New Size(155, 27)
        txtRoomNo.TabIndex = 0
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(623, 42)
        Label6.Name = "Label6"
        Label6.Size = New Size(47, 15)
        Label6.TabIndex = 5
        Label6.Text = "Rates :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(259, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 15)
        Label4.TabIndex = 3
        Label4.Text = "Room Type :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(835, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 15)
        Label3.TabIndex = 2
        Label3.Text = "VAT :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(9, 39)
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
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1072, 545)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' frmRooms
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1080, 580)
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
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
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
End Class
