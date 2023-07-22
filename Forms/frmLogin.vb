Imports System.Data.SqlClient

Public Class frmLogin

    Dim Dr As SqlDataReader
    Dim UserExists As Boolean = False


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxes_To_Take_Uppercase_data()

    End Sub

    Private Sub TextBoxes_To_Take_Uppercase_data()

        txtUserName.CharacterCasing = CharacterCasing.Upper
        txtUserPassword.CharacterCasing = CharacterCasing.Upper



    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmMainMenu.lbl_uname.Text = ""

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
            StrCmd = "SELECT TOP(1) * FROM users where upper(username) = '" & txtUserName.Text.Trim.ToUpper & "' and password = '" & txtUserPassword.Text.Trim.ToUpper & "'"
            Cmd = New SqlCommand(StrCmd, conn)

            Dr = Cmd.ExecuteReader
            If Dr.HasRows Then

                While Dr.Read

                    loggedInActiveUserID = Dr.Item("id")

                End While

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
                Dim mmenu As New frmMainMenu
                Me.Hide()
                mmenu.ShowDialog()

            Else
                MessageBox.Show("Wrong Credentials !!!")
                txtUserPassword.Text = ""
            End If

        End If


    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class