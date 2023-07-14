<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Panel2 = New Panel()
        ListView1 = New ListView()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Button1 = New Button()
        TabPage2 = New TabPage()
        Panel4 = New Panel()
        ListView2 = New ListView()
        Label4 = New Label()
        Label5 = New Label()
        DateTimePicker3 = New DateTimePicker()
        DateTimePicker4 = New DateTimePicker()
        ComboBox2 = New ComboBox()
        Label6 = New Label()
        Button2 = New Button()
        Panel3 = New Panel()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(2, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1122, 503)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.MistyRose
        TabPage1.Controls.Add(Panel2)
        TabPage1.Controls.Add(Panel1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1114, 475)
        TabPage1.TabIndex = 0
        TabPage1.Text = "User Reports"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.RosyBrown
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(ListView1)
        Panel2.Location = New Point(3, 131)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1102, 313)
        Panel2.TabIndex = 1
        ' 
        ' ListView1
        ' 
        ListView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListView1.Location = New Point(4, 13)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1093, 295)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(DateTimePicker2)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(3, 6)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1102, 100)
        Panel1.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(382, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 17)
        Label3.TabIndex = 6
        Label3.Text = "To :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(365, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 17)
        Label2.TabIndex = 5
        Label2.Text = "From :"
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.CalendarFont = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker2.Location = New Point(431, 55)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(200, 23)
        DateTimePicker2.TabIndex = 4
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarFont = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker1.Location = New Point(431, 12)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(94, 36)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(208, 26)
        ComboBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(3, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 17)
        Label1.TabIndex = 1
        Label1.Text = "Select User :"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(885, 31)
        Button1.Name = "Button1"
        Button1.Size = New Size(130, 35)
        Button1.TabIndex = 0
        Button1.Text = "Generate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.MistyRose
        TabPage2.Controls.Add(Panel4)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(DateTimePicker3)
        TabPage2.Controls.Add(DateTimePicker4)
        TabPage2.Controls.Add(ComboBox2)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(Button2)
        TabPage2.Controls.Add(Panel3)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1114, 475)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Rent Payment "
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel4.BackColor = Color.RosyBrown
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(ListView2)
        Panel4.Location = New Point(3, 131)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1101, 313)
        Panel4.TabIndex = 15
        ' 
        ' ListView2
        ' 
        ListView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ListView2.Location = New Point(4, 13)
        ListView2.Name = "ListView2"
        ListView2.Size = New Size(1091, 295)
        ListView2.TabIndex = 0
        ListView2.UseCompatibleStateImageBehavior = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(394, 62)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 17)
        Label4.TabIndex = 13
        Label4.Text = "To :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(377, 17)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 17)
        Label5.TabIndex = 12
        Label5.Text = "From :"
        ' 
        ' DateTimePicker3
        ' 
        DateTimePicker3.CalendarFont = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker3.Location = New Point(443, 56)
        DateTimePicker3.Name = "DateTimePicker3"
        DateTimePicker3.Size = New Size(200, 23)
        DateTimePicker3.TabIndex = 11
        ' 
        ' DateTimePicker4
        ' 
        DateTimePicker4.CalendarFont = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        DateTimePicker4.Location = New Point(443, 13)
        DateTimePicker4.Name = "DateTimePicker4"
        DateTimePicker4.Size = New Size(200, 23)
        DateTimePicker4.TabIndex = 10
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(106, 37)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(208, 26)
        ComboBox2.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(15, 40)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 17)
        Label6.TabIndex = 8
        Label6.Text = "Select User :"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(897, 32)
        Button2.Name = "Button2"
        Button2.Size = New Size(130, 35)
        Button2.TabIndex = 7
        Button2.Text = "Generate"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Location = New Point(3, 6)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1101, 100)
        Panel3.TabIndex = 14
        ' 
        ' frmReports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1125, 550)
        Controls.Add(TabControl1)
        Name = "frmReports"
        Text = "Reports"
        WindowState = FormWindowState.Maximized
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ListView2 As ListView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker4 As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
End Class
