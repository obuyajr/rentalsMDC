Imports System.Data.SqlClient

Public Class frmTenants

    Dim Dr As SqlDataReader
    Dim currentId As Integer = 0
    Dim currentState As Integer = 0


    Private Sub frmTenants_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Define_listviewTenants_Columns()
        LoadDataTo_lvwTenants()
        TextBoxes_To_Take_Uppercase_data()

        txtName.ReadOnly = True
        txtNationalId.ReadOnly = True
        txtContact.ReadOnly = True
        txtPin.ReadOnly = True
        txt_NOK.ReadOnly = True
        txtEmployer.ReadOnly = True






    End Sub

    Private Sub TextBoxes_To_Take_Uppercase_data()

        txtName.CharacterCasing = CharacterCasing.Upper
        txtNationalId.CharacterCasing = CharacterCasing.Upper
        txtContact.CharacterCasing = CharacterCasing.Upper
        txt_NOK.CharacterCasing = CharacterCasing.Upper
        txtPin.CharacterCasing = CharacterCasing.Upper
        txtEmployer.CharacterCasing = CharacterCasing.Upper


    End Sub



    Private Sub Define_listviewTenants_Columns()

        With lvwTenants

            .Columns.Add("ID", 100, HorizontalAlignment.Left)
            .Columns.Add("National ID", 100, HorizontalAlignment.Left)
            .Columns.Add("Name", 150, HorizontalAlignment.Left)
            .Columns.Add("Contact", 100, HorizontalAlignment.Left)
            .Columns.Add(" Pin ", 200, HorizontalAlignment.Left)
            .Columns.Add("NOK Name", 150, HorizontalAlignment.Left)
            .Columns.Add("Employer", 150, HorizontalAlignment.Left)
            .CheckBoxes = True
            .View = View.Details

        End With

    End Sub

    Private Sub LoadDataTo_lvwTenants()

        StrCmd = ""
        StrCmd = "SELECT * FROM tenantRegistration ORDER BY id"
        Cmd = New SqlCommand(StrCmd, conn)
        Dr = Cmd.ExecuteReader
        lvwTenants.Items.Clear()

        While Dr.Read
            Dim li As New ListViewItem(Dr.Item("id").ToString)

            With li

                .SubItems.Add(Dr.Item("idNo").ToString)
                .SubItems.Add(Dr.Item("tenantName").ToString)
                .SubItems.Add(Dr.Item("phoneNo").ToString)
                .SubItems.Add(Dr.Item("tenantPin").ToString)
                .SubItems.Add(Dr.Item("nextOfKin").ToString)
                .SubItems.Add(Dr.Item("employer").ToString)
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


        If txtPin.Text.Trim = "" Then
            ErrorProvider1.SetError(txtPin, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtPin, "")
        End If

        If txt_NOK.Text.Trim = "" Then
            ErrorProvider1.SetError(txt_NOK, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txt_NOK, "")
        End If


        If txtEmployer.Text.Trim = "" Then
            ErrorProvider1.SetError(txtEmployer, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtEmployer, "")
        End If

        ' End validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------


        If MessageBox.Show("Save Record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then




            StrCmd = ""

            If currentId <> 0 Then

                StrCmd = ""
                StrCmd = "UPDATE tenantRegistration set tenantName = '" & txtName.Text.ToUpper.Trim & "',idNo = '" & txtNationalId.Text & "',phoneNo = '" & txtContact.Text & "',tenantPin = '" & txtPin.Text & "',nextOfKin = '" & txt_NOK.Text & "',employer = '" & txtEmployer.Text & "',updatedDate = '" & generateYYYYdashMMdashDDDateformat(Now()) & "' where id = " & currentId & ""

            Else
                StrCmd = ""
                StrCmd = "INSERT INTO tenantRegistration" &
                            "           (tenantName" &
                            "           ,idNo" &
                            "           ,phoneNo" &
                            "           ,tenantPin" &
                            "           ,nextOfKin" &
                            "           ,employer)" &
                            "     VALUES" &
                            "           ('" & txtName.Text.ToUpper.Trim & "'" &
                            "           ,'" & txtNationalId.Text.ToUpper & "'" &
                            "           ,'" & txtContact.Text.ToUpper & "'" &
                            "           ,'" & txtPin.Text.ToLower & "'" &
                            "           ,'" & txt_NOK.Text.ToUpper & "'" &
                            "           ,'" & txtEmployer.Text.ToUpper & "')"
            End If

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
            txtPin.Text = ""
            txt_NOK.Text = ""
            txtEmployer.Text = ""

            txtName.Focus()

            currentId = 0
            currentState = 0
            Beep()

            MessageBox.Show("Record Successfully Saved!", "Save", MessageBoxButtons.OK)


        End If







    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        currentState = 1
        currentId = 0

        txtName.ReadOnly = False
        txtNationalId.ReadOnly = False
        txtContact.ReadOnly = False
        txtPin.ReadOnly = False
        txt_NOK.ReadOnly = False
        txtEmployer.ReadOnly = False


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        StrCmd = ""
        Dim I As Integer = 0
        Dim Count As Integer = 0


        For I = 0 To lvwTenants.Items.Count - 1

            If lvwTenants.Items(I).Checked = True Then

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete this Record ??", "Warning", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    currentId = CInt(lvwTenants.Items(I).SubItems(0).Text)


                    StrCmd = ""
                    StrCmd = "DELETE tenantRegistration where id = " & currentId & ""

                    Cmd = New SqlCommand(StrCmd, conn)

                    Try

                        Cmd.ExecuteNonQuery()

                    Catch ex As Exception

                        MessageBox.Show(ex.Message)

                    End Try

                    Cmd.Dispose()

                    Count = +1

                End If

            End If


        Next

        LoadDataTo_lvwTenants()


    End Sub

    Private Sub lvwTenants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwTenants.SelectedIndexChanged

        Dim I As Integer = 0

        If currentState = 1 Then

            For I = 0 To lvwTenants.Items.Count - 1

                If lvwTenants.Items(I).Selected = True Then

                    currentId = CInt(lvwTenants.Items(I).SubItems(0).Text)
                    txtName.Text = lvwTenants.Items(I).SubItems(1).Text
                    txtNationalId.Text = lvwTenants.Items(I).SubItems(2).Text
                    txtContact.Text = lvwTenants.Items(I).SubItems(3).Text
                    txtPin.Text = lvwTenants.Items(I).SubItems(4).Text
                    txt_NOK.Text = lvwTenants.Items(I).SubItems(5).Text
                    txtEmployer.Text = lvwTenants.Items(I).SubItems(6).Text

                End If

            Next

        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        currentState = 0
        currentId = 0

        txtName.ReadOnly = False
        txtNationalId.ReadOnly = False
        txtContact.ReadOnly = False
        txtPin.ReadOnly = False
        txt_NOK.ReadOnly = False
        txtEmployer.ReadOnly = False

        txtName.Text = ""
        txtNationalId.Text = ""
        txtContact.Text = ""
        txtPin.Text = ""
        txt_NOK.Text = ""
        txt_NOK.Text = ""
        txtName.Focus()



    End Sub
End Class