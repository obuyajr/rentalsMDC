Imports System.Data.SqlClient

Public Class frmTenants

    Dim Dr As SqlDataReader
    Dim currentId As Integer = 0







    Private Sub Define_listviewUsers_Columns()

        With lvwTenants

            .Columns.Add("ID", 100, HorizontalAlignment.Left)
            .Columns.Add("Name", 100, HorizontalAlignment.Left)
            .Columns.Add("National ID", 100, HorizontalAlignment.Left)
            .Columns.Add("Contact", 100, HorizontalAlignment.Left)
            .Columns.Add("Email Address", 100, HorizontalAlignment.Left)
            .Columns.Add("NOK Name", 100, HorizontalAlignment.Left)
            .Columns.Add("NOK Phone", 100, HorizontalAlignment.Left)


            .View = View.Details

        End With

    End Sub

    Private Sub LoadDataTo_lvwTenants()

        StrCmd = ""
        StrCmd = "SELECT * FROM tenants ORDER BY id"
        Cmd = New SqlCommand(StrCmd, conn)
        Dr = Cmd.ExecuteReader
        lvwTenants.Items.Clear()

        While Dr.Read
            Dim li As New ListViewItem(Dr.Item("id").ToString)

            With li

                .SubItems.Add(Dr.Item("name").ToString)
                .SubItems.Add(Dr.Item("national_id").ToString)
                .SubItems.Add(Dr.Item("contact").ToString)
                .SubItems.Add(Dr.Item("email").ToString)
                .SubItems.Add(Dr.Item("nok_name").ToString)
                .SubItems.Add(Dr.Item("nok_phone").ToString)
                lvwTenants.Items.Add(li)

            End With

        End While

        Dr.Close()
        Cmd.Dispose()


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        'validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------
        If txtName.Text.Trim = "" Then
            ErrorProvider1.SetError(txtName, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtName, "")
        End If


        If txtNationalId.Text.Trim = "" Then
            ErrorProvider1.SetError(txtNationalId, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtNationalId, "")
        End If

        If txtContact.Text.Trim = "" Then
            ErrorProvider1.SetError(txtContact, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtContact, "")
        End If


        If txtEmail.Text.Trim = "" Then
            ErrorProvider1.SetError(txtEmail, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtEmail, "")
        End If

        If txt_NOK.Text.Trim = "" Then
            ErrorProvider1.SetError(txt_NOK, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txt_NOK, "")
        End If


        If txt_NOK_phone.Text.Trim = "" Then
            ErrorProvider1.SetError(txt_NOK_phone, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txt_NOK_phone, "")
        End If

        ' End validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------


        StrCmd = ""
        StrCmd = "INSERT INTO tenants" &
                    "           (name" &
                    "           ,national_id" &
                    "           ,contact" &
                    "           ,email" &
                    "           ,nok_name" &
                    "           ,nok_phone)" &
                    "     VALUES" &
                    "           ('" & txtName.Text.ToUpper.Trim & "'" &
                    "           ,'" & txtNationalId.Text.ToUpper & "'" &
                    "           ,'" & txtContact.Text.ToUpper & "'" &
                    "           ,'" & txtEmail.Text.ToUpper & "'" &
                    "           ,'" & txt_NOK.Text.ToUpper & "'" &
                    "           ,'" & txt_NOK_phone.Text.ToUpper & "')"

        Cmd = New SqlCommand(StrCmd, conn)

        Try

            Cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Exit Sub

        End Try

        Cmd.Dispose()

        LoadDataTo_lvwTenants()


        txtName.Text = ""
        txtNationalId.Text = ""
        txtContact.Text = ""
        txtEmail.Text = ""
        txt_NOK.Text = ""
        txt_NOK_phone.Text = ""

        txtName.Focus()

        Beep()

        MessageBox.Show("Record Successfully Saved!", "Save", MessageBoxButtons.OK)





    End Sub

    Private Sub frmTenants_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Define_listviewUsers_Columns()
        LoadDataTo_lvwTenants()


    End Sub
End Class