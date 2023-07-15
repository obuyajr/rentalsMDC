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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        Label1 = New Label()
        combo_houseNo = New ComboBox()
        txt_tenantName = New TextBox()
        Label2 = New Label()
        Panel2 = New Panel()
        chkbox_payment = New CheckBox()
        txt_mMoney = New TextBox()
        Label6 = New Label()
        txt_cash = New TextBox()
        Label5 = New Label()
        txt_id = New TextBox()
        Label3 = New Label()
        txt_balance = New TextBox()
        Label4 = New Label()
        Panel3 = New Panel()
        btnClear = New Button()
        btn_cancel = New Button()
        btn_pay = New Button()
        ListView1 = New ListView()
        ErrorProvider1 = New ErrorProvider(components)
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
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(combo_houseNo)
        Panel1.Controls.Add(txt_tenantName)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1045, 81)
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
        ' txt_tenantName
        ' 
        txt_tenantName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_tenantName.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_tenantName.Location = New Point(516, 19)
        txt_tenantName.Name = "txt_tenantName"
        txt_tenantName.Size = New Size(304, 33)
        txt_tenantName.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(405, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 17)
        Label2.TabIndex = 2
        Label2.Text = "Tenant Name :"
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.White
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(chkbox_payment)
        Panel2.Controls.Add(txt_mMoney)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(txt_cash)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txt_id)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txt_balance)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(12, 99)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1045, 172)
        Panel2.TabIndex = 1
        ' 
        ' chkbox_payment
        ' 
        chkbox_payment.AutoSize = True
        chkbox_payment.Checked = True
        chkbox_payment.CheckState = CheckState.Checked
        chkbox_payment.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        chkbox_payment.Location = New Point(617, 21)
        chkbox_payment.Name = "chkbox_payment"
        chkbox_payment.Size = New Size(82, 21)
        chkbox_payment.TabIndex = 17
        chkbox_payment.Text = "Payment"
        chkbox_payment.UseVisualStyleBackColor = True
        ' 
        ' txt_mMoney
        ' 
        txt_mMoney.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_mMoney.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_mMoney.Location = New Point(133, 53)
        txt_mMoney.Name = "txt_mMoney"
        txt_mMoney.Size = New Size(131, 43)
        txt_mMoney.TabIndex = 16
        txt_mMoney.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(8, 72)
        Label6.Name = "Label6"
        Label6.Size = New Size(111, 17)
        Label6.TabIndex = 15
        Label6.Text = "M/ Money [F9] :"
        ' 
        ' txt_cash
        ' 
        txt_cash.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        txt_cash.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        txt_cash.Location = New Point(133, 115)
        txt_cash.Name = "txt_cash"
        txt_cash.Size = New Size(131, 43)
        txt_cash.TabIndex = 14
        txt_cash.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(46, 134)
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
        txt_balance.Location = New Point(405, 14)
        txt_balance.Name = "txt_balance"
        txt_balance.Size = New Size(131, 33)
        txt_balance.TabIndex = 10
        txt_balance.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(328, 23)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 17)
        Label4.TabIndex = 5
        Label4.Text = "Balance :"
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.WhiteSmoke
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(btnClear)
        Panel3.Controls.Add(btn_cancel)
        Panel3.Controls.Add(btn_pay)
        Panel3.Location = New Point(12, 618)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1045, 80)
        Panel3.TabIndex = 2
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightCoral
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.Image = My.Resources.Resources.eraser_solid_24__1_
        btnClear.ImageAlign = ContentAlignment.MiddleRight
        btnClear.Location = New Point(267, 20)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(107, 32)
        btnClear.TabIndex = 3
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btn_cancel
        ' 
        btn_cancel.BackColor = Color.LightCoral
        btn_cancel.FlatStyle = FlatStyle.Flat
        btn_cancel.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_cancel.Image = My.Resources.Resources.x_regular_24
        btn_cancel.ImageAlign = ContentAlignment.MiddleRight
        btn_cancel.Location = New Point(916, 20)
        btn_cancel.Name = "btn_cancel"
        btn_cancel.Size = New Size(107, 32)
        btn_cancel.TabIndex = 2
        btn_cancel.Text = "Cancel"
        btn_cancel.UseVisualStyleBackColor = False
        ' 
        ' btn_pay
        ' 
        btn_pay.BackColor = Color.LightCoral
        btn_pay.FlatStyle = FlatStyle.Flat
        btn_pay.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        btn_pay.Image = My.Resources.Resources.wallet_regular_24
        btn_pay.ImageAlign = ContentAlignment.MiddleRight
        btn_pay.Location = New Point(93, 20)
        btn_pay.Name = "btn_pay"
        btn_pay.Size = New Size(107, 32)
        btn_pay.TabIndex = 0
        btn_pay.Text = "Pay "
        btn_pay.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ListView1.BorderStyle = BorderStyle.FixedSingle
        ListView1.Location = New Point(12, 290)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(1045, 322)
        ListView1.TabIndex = 3
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' frmPayment_records
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(1071, 700)
        Controls.Add(ListView1)
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
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btn_pay As Button
    Friend WithEvents txt_cash As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_mMoney As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents btnClear As Button
    Friend WithEvents chkbox_payment As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
