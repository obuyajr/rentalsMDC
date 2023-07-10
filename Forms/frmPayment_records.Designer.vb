<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        combo_houseNo = New ComboBox()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Label5 = New Label()
        txt_id = New TextBox()
        Label3 = New Label()
        txt_balance = New TextBox()
        txt_tenantName = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        Button1 = New Button()
        txt_mMoney = New TextBox()
        Label6 = New Label()
        btn_cancel = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(combo_houseNo)
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
        ' combo_houseNo
        ' 
        combo_houseNo.Font = New Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        combo_houseNo.FormattingEnabled = True
        combo_houseNo.Location = New Point(133, 19)
        combo_houseNo.Name = "combo_houseNo"
        combo_houseNo.Size = New Size(185, 38)
        combo_houseNo.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(txt_mMoney)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(TextBox1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txt_id)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txt_balance)
        Panel2.Controls.Add(txt_tenantName)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(12, 99)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(723, 312)
        Panel2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        TextBox1.Location = New Point(133, 205)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(131, 43)
        TextBox1.TabIndex = 14
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(46, 224)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 17)
        Label5.TabIndex = 13
        Label5.Text = "CashPaid :"
        ' 
        ' txt_id
        ' 
        txt_id.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_id.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_id.Location = New Point(133, 14)
        txt_id.Name = "txt_id"
        txt_id.Size = New Size(131, 33)
        txt_id.TabIndex = 12
        txt_id.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(48, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 17)
        Label3.TabIndex = 11
        Label3.Text = "Tenant ID:"
        ' 
        ' txt_balance
        ' 
        txt_balance.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_balance.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_balance.Location = New Point(133, 115)
        txt_balance.Name = "txt_balance"
        txt_balance.Size = New Size(131, 33)
        txt_balance.TabIndex = 10
        txt_balance.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_tenantName
        ' 
        txt_tenantName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_tenantName.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_tenantName.Location = New Point(133, 63)
        txt_tenantName.Name = "txt_tenantName"
        txt_tenantName.Size = New Size(304, 33)
        txt_tenantName.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(56, 124)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 5
        Label4.Text = "Balance :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(22, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 17)
        Label2.TabIndex = 2
        Label2.Text = "Tenant Name :"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btn_cancel)
        Panel3.Controls.Add(Button1)
        Panel3.Location = New Point(12, 417)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(723, 80)
        Panel3.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Image = My.Resources.Resources.wallet_regular_24
        Button1.ImageAlign = ContentAlignment.MiddleRight
        Button1.Location = New Point(93, 20)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 32)
        Button1.TabIndex = 0
        Button1.Text = "Pay "
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txt_mMoney
        ' 
        txt_mMoney.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_mMoney.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_mMoney.Location = New Point(133, 156)
        txt_mMoney.Name = "txt_mMoney"
        txt_mMoney.Size = New Size(131, 43)
        txt_mMoney.TabIndex = 16
        txt_mMoney.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(8, 175)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 17)
        Label6.TabIndex = 15
        Label6.Text = "M/ Money [F9] :"
        ' 
        ' btn_cancel
        ' 
        btn_cancel.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_cancel.Image = My.Resources.Resources.x_regular_24
        btn_cancel.ImageAlign = ContentAlignment.MiddleRight
        btn_cancel.Location = New Point(595, 23)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(107, 32)
        btn_cancel.TabIndex = 2
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = True
        ' 
        ' frmPayment_records
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(747, 500)
        Controls.Add(Panel3)
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
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents combo_houseNo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_balance As TextBox
    Friend WithEvents txt_tenantName As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_mMoney As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_cancel As Button
End Class
