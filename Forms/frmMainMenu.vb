Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class frmMainMenu


    'switch between panels
    Public Sub switchPanel(panel As Form)


        SplitContainer1.Panel2.Controls.Clear()
        panel.TopLevel = False
        SplitContainer1.Panel2.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub btn_Users_Click(sender As Object, e As EventArgs) Handles btn_Users.Click

        Dim userPanel As New frmUsers

        switchPanel(userPanel)

    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'work within working screen
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Tenants.Click

        Dim tenantsPanel As New frmTenants
        switchPanel(tenantsPanel)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim housesPanel As New frmHouses
        switchPanel(housesPanel)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim assignHouse As New frmAssignHouse
        switchPanel(assignHouse)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()
        Dim frmLogin As New frmLogin
        frmLogin.Show()

    End Sub
End Class