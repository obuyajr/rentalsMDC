Imports System.Data.SqlClient
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
        Dim Dr As SqlDataReader
        'work within working screen
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height

        lbl_uname.Text = frmLogin.txtUserName.Text


        '* check for rights


        StrCmd = ""
        StrCmd = "SELECT * FROM users WHERE id = " & loggedInActiveUserID & ""

        Cmd = New SqlCommand(StrCmd, conn)

        Dr = Cmd.ExecuteReader

        While Dr.Read

            If Dr.Item("super_admin").ToString.ToUpper = "Y" Then
                btn_Users.Enabled = True
                btnAssignHouse.Enabled = True

            Else

                btn_Users.Enabled = False
                btnAssignHouse.Enabled = False

            End If

            If Dr.Item("add_house").ToString.ToUpper = "Y" Then

                btnHouses.Enabled = True

            Else

                btnHouses.Enabled = False

            End If

            If Dr.Item("add_tenants").ToString.ToUpper = "Y" Then

                btn_Tenants.Enabled = True

            Else

                btn_Tenants.Enabled = False

            End If

            If Dr.Item("make_payments").ToString.ToUpper = "Y" Then

                btnPayments.Enabled = True

            Else

                btnPayments.Enabled = False

            End If



        End While
        Dr.Close()
        Cmd.Dispose()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Tenants.Click

        Dim tenantsPanel As New frmTenants
        switchPanel(tenantsPanel)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnHouses.Click

        Dim housesPanel As New frmHouses
        switchPanel(housesPanel)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAssignHouse.Click

        Dim assignHouse As New frmAssignHouse
        switchPanel(assignHouse)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()

        ' Me.Close()
        Dim frmLogin As New frmLogin
        frmLogin.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnPayments.Click

        Dim payRent As New frmPayment_records
        switchPanel(payRent)

    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click

        Dim reports As New reports
        switchPanel(reports)

    End Sub
End Class