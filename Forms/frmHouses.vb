﻿Imports System.Data.SqlClient

Public Class frmHouses

    Dim Dr As SqlDataReader
    Dim currentID As Integer = 0
    Dim currentState As Integer = 0


    Private Sub frmTenants_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Define_listviewHouses_Columns()
        LoadDataTo_lvwHouses()
        TextBoxes_To_Take_Uppercase_data()



    End Sub

    Private Sub TextBoxes_To_Take_Uppercase_data()

        txtHouseNo.CharacterCasing = CharacterCasing.Upper
        txtLocation.CharacterCasing = CharacterCasing.Upper
        txtRent.CharacterCasing = CharacterCasing.Upper
        txtDeposit.CharacterCasing = CharacterCasing.Upper



    End Sub



    Private Sub Define_listviewHouses_Columns()

        With lvwHouses

            .Columns.Add(" ID", 50, HorizontalAlignment.Left)
            .Columns.Add(" House No.", 100, HorizontalAlignment.Left)
            .Columns.Add("Location", 200, HorizontalAlignment.Left)
            .Columns.Add("Category", 300, HorizontalAlignment.Left)
            .Columns.Add("Rent", 100, HorizontalAlignment.Left)
            .Columns.Add("Deposit", 100, HorizontalAlignment.Left)
            .Columns.Add("Status", 100, HorizontalAlignment.Left)

            .CheckBoxes = True

            .View = View.Details

        End With

    End Sub

    Private Sub LoadDataTo_lvwHouses()

        StrCmd = ""
        StrCmd = "SELECT * FROM houses ORDER BY id"
        Cmd = New SqlCommand(StrCmd, conn)
        Dr = Cmd.ExecuteReader
        lvwHouses.Items.Clear()

        While Dr.Read
            Dim li As New ListViewItem(Dr.Item("id").ToString)

            With li

                .SubItems.Add(Dr.Item("house_no").ToString)
                .SubItems.Add(Dr.Item("location").ToString)
                .SubItems.Add(Dr.Item("category").ToString)
                .SubItems.Add(Dr.Item("rent").ToString)
                .SubItems.Add(Dr.Item("deposit").ToString)
                .SubItems.Add(Dr.Item("status").ToString)

                lvwHouses.Items.Add(li)

            End With

        End While

        Dr.Close()
        Cmd.Dispose()


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        'validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------
        If txtHouseNo.Text.Trim = "" Then
            ErrorProvider1.SetError(txtHouseNo, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtHouseNo, "")
        End If


        If txtLocation.Text.Trim = "" Then
            ErrorProvider1.SetError(txtLocation, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtLocation, "")
        End If

        If combo_category.Text.Trim = "" Then
            ErrorProvider1.SetError(combo_category, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(combo_category, "")
        End If


        If txtRent.Text.Trim = "" Then
            ErrorProvider1.SetError(txtRent, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtRent, "")
        End If

        If txtDeposit.Text.Trim = "" Then
            ErrorProvider1.SetError(txtDeposit, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtDeposit, "")
        End If


        If combo_status.Text.Trim = "" Then
            ErrorProvider1.SetError(combo_status, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(combo_status, "")
        End If

        ' End validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------


        If MessageBox.Show("Save Record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then




            StrCmd = ""

            If currentID <> 0 Then

                StrCmd = ""
                StrCmd = "UPDATE houses set location = '" & txtLocation.Text.ToUpper.Trim & "',category = '" & combo_category.Text & "',rent = '" & txtRent.Text & "',deposit = '" & txtDeposit.Text & "',status = '" & combo_status.Text & "' where id = " & currentID & ""

            Else
                StrCmd = ""
                StrCmd = "INSERT INTO houses" &
                            "           (house_no" &
                            "           ,location" &
                            "           ,category" &
                            "           ,rent" &
                            "           ,deposit" &
                            "           ,status)" &
                            "     VALUES" &
                            "           ('" & txtHouseNo.Text.ToUpper.Trim & "'" &
                            "           ,'" & txtLocation.Text.ToUpper & "'" &
                            "           ,'" & combo_category.Text.ToUpper & "'" &
                            "           ,'" & txtRent.Text.ToLower & "'" &
                            "           ,'" & txtDeposit.Text.ToUpper & "'" &
                            "           ,'" & combo_status.Text.ToUpper & "')"
            End If

            Cmd = New SqlCommand(StrCmd, conn)

            Try

                Cmd.ExecuteNonQuery()

            Catch ex As Exception

                MessageBox.Show(ex.Message)
                Exit Sub

            End Try

            Cmd.Dispose()

            LoadDataTo_lvwHouses()

            combo_category.Text = Nothing
            txtDeposit.Text = ""
            txtHouseNo.Text = ""
            txtLocation.Text = ""
            txtRent.Text = ""
            combo_status.Text = Nothing

            txtHouseNo.Focus()

            currentID = 0
            currentState = 0
            Beep()

            MessageBox.Show("Record Successfully Saved!", "Save", MessageBoxButtons.OK)


        End If







    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        currentState = 1
        currentID = 0

        txtHouseNo.ReadOnly = False
        txtLocation.ReadOnly = False
        'txtCategory.ReadOnly = False
        txtRent.ReadOnly = False
        txtDeposit.ReadOnly = False
        ' txtStatus.ReadOnly = False


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        StrCmd = ""
        Dim I As Integer = 0
        Dim Count As Integer = 0


        For I = 0 To lvwHouses.Items.Count - 1

            If lvwHouses.Items(I).Checked = True Then

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete this Record ??", "Warning", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    currentID = CInt(lvwHouses.Items(I).SubItems(0).Text)


                    StrCmd = ""
                    StrCmd = "DELETE houses where id = " & currentID & ""

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

        LoadDataTo_lvwHouses()


    End Sub

    Private Sub lvwTenants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwHouses.SelectedIndexChanged

        Dim I As Integer = 0

        If currentState = 1 Then

            For I = 0 To lvwHouses.Items.Count - 1

                If lvwHouses.Items(I).Selected = True Then


                    currentID = lvwHouses.Items(I).SubItems(0).Text
                    txtHouseNo.Text = lvwHouses.Items(I).SubItems(1).Text
                    txtLocation.Text = lvwHouses.Items(I).SubItems(2).Text
                    combo_category.Text = lvwHouses.Items(I).SubItems(3).Text
                    txtRent.Text = lvwHouses.Items(I).SubItems(4).Text
                    txtDeposit.Text = lvwHouses.Items(I).SubItems(5).Text
                    combo_status.Text = lvwHouses.Items(I).SubItems(6).Text

                End If

            Next

        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        currentState = 0
        currentID = 0

        txtHouseNo.ReadOnly = False
        txtLocation.ReadOnly = False
        txtDeposit.ReadOnly = False
        txtRent.ReadOnly = False
        txtRent.ReadOnly = False
        'txtCategory.ReadOnly = False

        txtHouseNo.Text = ""
        txtLocation.Text = ""
        txtDeposit.Text = ""
        txtRent.Text = ""
        combo_status.Text = ""
        combo_category.Text = ""


    End Sub
End Class