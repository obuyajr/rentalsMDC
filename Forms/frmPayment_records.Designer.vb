﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment_records
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
        Label1 = New Label()
        combo_location = New ComboBox()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txt_id = New TextBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(combo_location)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(723, 81)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(20, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 17)
        Label1.TabIndex = 2
        Label1.Text = "Select House # :"
        ' 
        ' combo_location
        ' 
        combo_location.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        combo_location.FormattingEnabled = True
        combo_location.Location = New Point(133, 13)
        combo_location.Name = "combo_location"
        combo_location.Size = New Size(185, 45)
        combo_location.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(TextBox3)
        Panel2.Controls.Add(TextBox2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(txt_id)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(12, 99)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(723, 238)
        Panel2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(48, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 17)
        Label3.TabIndex = 3
        Label3.Text = "Category :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(20, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 17)
        Label2.TabIndex = 2
        Label2.Text = "Tenant Name :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(56, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 5
        Label4.Text = "Balance :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(51, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 17)
        Label5.TabIndex = 4
        Label5.Text = "Location :"
        ' 
        ' txt_id
        ' 
        txt_id.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_id.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_id.Location = New Point(133, 23)
        txt_id.Name = "txt_id"
        txt_id.Size = New Size(304, 33)
        txt_id.TabIndex = 7
        txt_id.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        TextBox1.Location = New Point(133, 76)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(304, 33)
        TextBox1.TabIndex = 8
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        TextBox2.Location = New Point(133, 130)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(304, 33)
        TextBox2.TabIndex = 9
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        TextBox3.Location = New Point(133, 180)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(115, 33)
        TextBox3.TabIndex = 10
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' frmPayment_records
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(747, 481)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmPayment_records"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rent Payment"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents combo_location As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txt_id As TextBox
End Class
