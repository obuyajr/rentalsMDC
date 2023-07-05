Imports System.Data.SqlClient

Public Class frmLogin

    Dim Dr As SqlDataReader
    Dim UserExists As Boolean = False

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If txtUserName.Text.Trim = "" Then
            ErrorProvider1.SetError(txtUserName, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtUserName, "")
        End If


        If txtUserPassword.Text.Trim = "" Then
            ErrorProvider1.SetError(txtUserPassword, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtUserPassword, "")
        End If


        If EstablishedConnectionToDB() = True Then

            StrCmd = ""
            StrCmd = "SELECT TOP(1) * FROM users where upper(name) = '" & txtUserName.Text.Trim.ToUpper & "' and password = '" & txtUserPassword.Text.Trim.ToUpper & "'"
            Cmd = New SqlCommand(StrCmd, conn)

            Dr = Cmd.ExecuteReader
            If Dr.HasRows Then
                UserExists = True
            Else
                UserExists = False
            End If
            Dr.Close()
            Cmd.Dispose()

            If UserExists = True Then

                '*-----------------------------------------------------------------------------
                '* Load Main Menu
                '*-----------------------------------------------------------------------------
                Dim mmenu As New frmUsers
                Me.Hide()
                mmenu.ShowDialog()

            End If

        End If


    End Sub

End Class