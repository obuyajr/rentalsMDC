<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBatch
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
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonShadow
        Button1.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(103, 54)
        Button1.Name = "Button1"
        Button1.Size = New Size(255, 71)
        Button1.TabIndex = 0
        Button1.Text = "BIll Rent ( EOM )"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ButtonShadow
        Button2.Font = New Font("Calibri", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(103, 175)
        Button2.Name = "Button2"
        Button2.Size = New Size(255, 71)
        Button2.TabIndex = 1
        Button2.Text = "Send Rent Due SMS"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' frmBatch
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(464, 375)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "frmBatch"
        Text = "Batch"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
