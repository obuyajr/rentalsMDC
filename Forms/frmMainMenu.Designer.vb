<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        SplitContainer1 = New SplitContainer()
        Button3 = New Button()
        btnRooms = New Button()
        btnReports = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        lbl_uname = New Label()
        btnPayments = New Button()
        Button1 = New Button()
        btnAssignHouse = New Button()
        btnHouses = New Button()
        btn_Tenants = New Button()
        btn_Users = New Button()
        Button2 = New Button()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.Indigo
        SplitContainer1.Panel1.Controls.Add(Button3)
        SplitContainer1.Panel1.Controls.Add(btnRooms)
        SplitContainer1.Panel1.Controls.Add(btnReports)
        SplitContainer1.Panel1.Controls.Add(Panel1)
        SplitContainer1.Panel1.Controls.Add(btnPayments)
        SplitContainer1.Panel1.Controls.Add(Button1)
        SplitContainer1.Panel1.Controls.Add(btnAssignHouse)
        SplitContainer1.Panel1.Controls.Add(btnHouses)
        SplitContainer1.Panel1.Controls.Add(btn_Tenants)
        SplitContainer1.Panel1.Controls.Add(btn_Users)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.White
        SplitContainer1.Panel2.BackgroundImage = My.Resources.Resources.download__1_
        SplitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Center
        SplitContainer1.Panel2.Controls.Add(Button2)
        SplitContainer1.Panel2.ForeColor = Color.Black
        SplitContainer1.Size = New Size(1063, 566)
        SplitContainer1.SplitterDistance = 150
        SplitContainer1.TabIndex = 0
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.White
        Button3.Image = My.Resources.Resources.report_solid_24__1_
        Button3.ImageAlign = ContentAlignment.MiddleRight
        Button3.Location = New Point(3, 365)
        Button3.Margin = New Padding(1)
        Button3.Name = "Button3"
        Button3.Size = New Size(149, 34)
        Button3.TabIndex = 10
        Button3.Text = "Bill Batch"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = True
        ' 
        ' btnRooms
        ' 
        btnRooms.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnRooms.FlatAppearance.BorderSize = 0
        btnRooms.FlatStyle = FlatStyle.Flat
        btnRooms.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnRooms.ForeColor = Color.White
        btnRooms.Image = My.Resources.Resources.report_solid_24__1_
        btnRooms.ImageAlign = ContentAlignment.MiddleRight
        btnRooms.Location = New Point(1, 457)
        btnRooms.Margin = New Padding(1)
        btnRooms.Name = "btnRooms"
        btnRooms.Size = New Size(149, 34)
        btnRooms.TabIndex = 9
        btnRooms.Text = "Rooms"
        btnRooms.TextAlign = ContentAlignment.MiddleLeft
        btnRooms.UseVisualStyleBackColor = True
        ' 
        ' btnReports
        ' 
        btnReports.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnReports.FlatAppearance.BorderSize = 0
        btnReports.FlatStyle = FlatStyle.Flat
        btnReports.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnReports.ForeColor = Color.White
        btnReports.Image = My.Resources.Resources.report_solid_24__1_
        btnReports.ImageAlign = ContentAlignment.MiddleRight
        btnReports.Location = New Point(0, 320)
        btnReports.Margin = New Padding(1)
        btnReports.Name = "btnReports"
        btnReports.Size = New Size(149, 34)
        btnReports.TabIndex = 8
        btnReports.Text = "Reports"
        btnReports.TextAlign = ContentAlignment.MiddleLeft
        btnReports.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.Crimson
        Panel1.BackgroundImage = My.Resources.Resources.building_house_solid_36
        Panel1.BackgroundImageLayout = ImageLayout.Center
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lbl_uname)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(152, 90)
        Panel1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(10, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 17)
        Label1.TabIndex = 9
        Label1.Text = "USER :"
        ' 
        ' lbl_uname
        ' 
        lbl_uname.AutoSize = True
        lbl_uname.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_uname.ForeColor = Color.White
        lbl_uname.Location = New Point(92, 66)
        lbl_uname.Name = "lbl_uname"
        lbl_uname.Size = New Size(46, 21)
        lbl_uname.TabIndex = 8
        lbl_uname.Text = "User"
        ' 
        ' btnPayments
        ' 
        btnPayments.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnPayments.FlatAppearance.BorderSize = 0
        btnPayments.FlatStyle = FlatStyle.Flat
        btnPayments.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnPayments.ForeColor = Color.White
        btnPayments.Image = My.Resources.Resources.money_withdraw_regular_24
        btnPayments.ImageAlign = ContentAlignment.MiddleRight
        btnPayments.Location = New Point(1, 275)
        btnPayments.Margin = New Padding(1)
        btnPayments.Name = "btnPayments"
        btnPayments.Size = New Size(148, 34)
        btnPayments.TabIndex = 6
        btnPayments.Text = "Payment"
        btnPayments.TextAlign = ContentAlignment.MiddleLeft
        btnPayments.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.DialogResult = DialogResult.Cancel
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Image = My.Resources.Resources.close
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(1, 522)
        Button1.Margin = New Padding(1)
        Button1.Name = "Button1"
        Button1.Size = New Size(148, 34)
        Button1.TabIndex = 5
        Button1.Text = "Exit"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnAssignHouse
        ' 
        btnAssignHouse.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnAssignHouse.FlatAppearance.BorderSize = 0
        btnAssignHouse.FlatStyle = FlatStyle.Flat
        btnAssignHouse.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnAssignHouse.ForeColor = Color.White
        btnAssignHouse.Image = My.Resources.Resources.door_open_regular_24
        btnAssignHouse.ImageAlign = ContentAlignment.MiddleRight
        btnAssignHouse.Location = New Point(0, 230)
        btnAssignHouse.Margin = New Padding(1)
        btnAssignHouse.Name = "btnAssignHouse"
        btnAssignHouse.Size = New Size(149, 34)
        btnAssignHouse.TabIndex = 4
        btnAssignHouse.Text = "Assign House"
        btnAssignHouse.TextAlign = ContentAlignment.MiddleLeft
        btnAssignHouse.UseVisualStyleBackColor = True
        ' 
        ' btnHouses
        ' 
        btnHouses.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnHouses.FlatAppearance.BorderSize = 0
        btnHouses.FlatStyle = FlatStyle.Flat
        btnHouses.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnHouses.ForeColor = Color.White
        btnHouses.Image = My.Resources.Resources.building_house_solid_24
        btnHouses.ImageAlign = ContentAlignment.MiddleRight
        btnHouses.Location = New Point(0, 185)
        btnHouses.Margin = New Padding(1)
        btnHouses.Name = "btnHouses"
        btnHouses.Size = New Size(149, 34)
        btnHouses.TabIndex = 3
        btnHouses.Text = "Houses"
        btnHouses.TextAlign = ContentAlignment.MiddleLeft
        btnHouses.UseVisualStyleBackColor = True
        ' 
        ' btn_Tenants
        ' 
        btn_Tenants.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btn_Tenants.FlatAppearance.BorderSize = 0
        btn_Tenants.FlatStyle = FlatStyle.Flat
        btn_Tenants.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_Tenants.ForeColor = Color.White
        btn_Tenants.Image = My.Resources.Resources.book_open_regular_24___Copy
        btn_Tenants.ImageAlign = ContentAlignment.MiddleRight
        btn_Tenants.Location = New Point(2, 139)
        btn_Tenants.Margin = New Padding(1)
        btn_Tenants.Name = "btn_Tenants"
        btn_Tenants.Size = New Size(149, 34)
        btn_Tenants.TabIndex = 2
        btn_Tenants.Text = "Tenants"
        btn_Tenants.TextAlign = ContentAlignment.MiddleLeft
        btn_Tenants.UseVisualStyleBackColor = True
        ' 
        ' btn_Users
        ' 
        btn_Users.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btn_Users.FlatAppearance.BorderSize = 0
        btn_Users.FlatStyle = FlatStyle.Flat
        btn_Users.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btn_Users.ForeColor = Color.White
        btn_Users.Image = My.Resources.Resources.user_solid_24
        btn_Users.ImageAlign = ContentAlignment.MiddleRight
        btn_Users.Location = New Point(2, 94)
        btn_Users.Margin = New Padding(1)
        btn_Users.Name = "btn_Users"
        btn_Users.Size = New Size(148, 34)
        btn_Users.TabIndex = 0
        btn_Users.Text = "Users"
        btn_Users.TextAlign = ContentAlignment.MiddleLeft
        btn_Users.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(-168, 288)
        Button2.Margin = New Padding(1)
        Button2.Name = "Button2"
        Button2.Size = New Size(163, 25)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' frmMainMenu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1063, 566)
        Controls.Add(SplitContainer1)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmMainMenu"
        StartPosition = FormStartPosition.Manual
        Text = "frmMainMenu"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btn_Users As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAssignHouse As Button
    Friend WithEvents btnHouses As Button
    Friend WithEvents btn_Tenants As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnPayments As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_uname As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReports As Button
    Friend WithEvents btnRooms As Button
    Friend WithEvents Button3 As Button
End Class
