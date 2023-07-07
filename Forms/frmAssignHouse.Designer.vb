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
        combo_status = New ComboBox()
        Label4 = New Label()
        combo_category = New ComboBox()
        combo_location = New ComboBox()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Panel2 = New Panel()
        ListView1 = New ListView()
        Panel3 = New Panel()
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
        Panel1.Controls.Add(combo_status)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(combo_category)
        Panel1.Controls.Add(combo_location)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1047, 65)
        Panel1.TabIndex = 0
        ' 
        ' combo_status
        ' 
        combo_status.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        combo_status.FormattingEnabled = True
        combo_status.Location = New Point(659, 16)
        combo_status.Name = "combo_status"
        combo_status.Size = New Size(156, 28)
        combo_status.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(580, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 17)
        Label4.TabIndex = 5
        Label4.Text = "Status"
        ' 
        ' combo_category
        ' 
        combo_category.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        combo_category.FormattingEnabled = True
        combo_category.Location = New Point(379, 18)
        combo_category.Name = "combo_category"
        combo_category.Size = New Size(156, 28)
        combo_category.TabIndex = 4
        ' 
        ' combo_location
        ' 
        combo_location.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        combo_location.FormattingEnabled = True
        combo_location.Location = New Point(85, 16)
        combo_location.Name = "combo_location"
        combo_location.Size = New Size(153, 28)
        combo_location.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(293, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 17)
        Label2.TabIndex = 2
        Label2.Text = "Category"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(18, 23)
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
        Button1.Location = New Point(866, 11)
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
        Panel2.Controls.Add(ListView1)
        Panel2.Location = New Point(12, 83)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1047, 155)
        Panel2.TabIndex = 1
        ' 
        ' ListView1
        ' 
        ListView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListView1.BorderStyle = BorderStyle.FixedSingle
        ListView1.Location = New Point(3, 12)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1037, 136)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(combo_tenantName)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(12, 266)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1047, 200)
        Panel3.TabIndex = 2
        ' 
        ' combo_tenantName
        ' 
        combo_tenantName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        combo_tenantName.FormattingEnabled = True
        combo_tenantName.Location = New Point(115, 19)
        combo_tenantName.Name = "combo_tenantName"
        combo_tenantName.Size = New Size(153, 28)
        combo_tenantName.TabIndex = 5
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
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents combo_category As ComboBox
    Friend WithEvents combo_location As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents combo_tenantName As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents combo_status As ComboBox
    Friend WithEvents Label4 As Label
End Class
