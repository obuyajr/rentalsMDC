﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reports
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
        TabPage2 = New TabPage()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(2, 2)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1046, 503)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1038, 475)
        TabPage1.TabIndex = 0
        TabPage1.Text = "User Reports"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1038, 475)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Rent Payment "
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' reports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1048, 517)
        Controls.Add(TabControl1)
        Name = "reports"
        Text = "Reports"
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
