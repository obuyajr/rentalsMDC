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
        Button4 = New Button()
        btn_Tenants = New Button()
        Button2 = New Button()
        btn_Users = New Button()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.SuspendLayout()
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
        SplitContainer1.Panel1.Controls.Add(Button4)
        SplitContainer1.Panel1.Controls.Add(btn_Tenants)
        SplitContainer1.Panel1.Controls.Add(Button2)
        SplitContainer1.Panel1.Controls.Add(btn_Users)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.BackColor = Color.White
        SplitContainer1.Panel2.BackgroundImage = My.Resources.Resources.download__1_
        SplitContainer1.Panel2.BackgroundImageLayout = ImageLayout.Center
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
        Button3.Image = My.Resources.Resources.user_solid_24
        Button3.ImageAlign = ContentAlignment.MiddleRight
        Button3.Location = New Point(10, 179)
        Button3.Margin = New Padding(1)
        Button3.Name = "Button3"
        Button3.Size = New Size(128, 34)
        Button3.TabIndex = 4
        Button3.Text = "Users"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.ForeColor = Color.White
        Button4.Image = My.Resources.Resources.building_house_solid_24
        Button4.ImageAlign = ContentAlignment.MiddleRight
        Button4.Location = New Point(10, 129)
        Button4.Margin = New Padding(1)
        Button4.Name = "Button4"
        Button4.Size = New Size(128, 34)
        Button4.TabIndex = 3
        Button4.Text = "Houses"
        Button4.UseVisualStyleBackColor = True
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
        btn_Tenants.Location = New Point(10, 83)
        btn_Tenants.Margin = New Padding(1)
        btn_Tenants.Name = "btn_Tenants"
        btn_Tenants.Size = New Size(128, 34)
        btn_Tenants.TabIndex = 2
        btn_Tenants.Text = "Tenants"
        btn_Tenants.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(26, 183)
        Button2.Margin = New Padding(1)
        Button2.Name = "Button2"
        Button2.Size = New Size(163, 25)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
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
        btn_Users.Location = New Point(10, 33)
        btn_Users.Margin = New Padding(1)
        btn_Users.Name = "btn_Users"
        btn_Users.Size = New Size(128, 34)
        btn_Users.TabIndex = 0
        btn_Users.Text = "Users"
        btn_Users.UseVisualStyleBackColor = True
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
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btn_Users As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btn_Tenants As Button
End Class
