Imports System.Data.SqlClient

Public Class frmRooms
    Dim Dr As SqlDataReader
    Dim currentID As Integer = 0
    Dim currentState As Integer = 0

    Private Sub frmRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxes_To_Take_Uppercase_data()
        Define_listviewRooms_Columns()
        LoadDataTo_lvwRooms()

    End Sub

    Private Sub TextBoxes_To_Take_Uppercase_data()

        txtRoomNo.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub Define_listviewRooms_Columns()

        With lvwRooms

            .Columns.Add(" ID", 50, HorizontalAlignment.Left)
            .Columns.Add(" Room No.", 100, HorizontalAlignment.Left)
            .Columns.Add("Room Type", 200, HorizontalAlignment.Left)
            .Columns.Add("Rates", 100, HorizontalAlignment.Left)
            .Columns.Add("VAT", 100, HorizontalAlignment.Left)


            .CheckBoxes = True

            .View = View.Details

        End With

    End Sub

    Private Sub LoadDataTo_lvwRooms()

        StrCmd = ""
        StrCmd = "SELECT * FROM rooms ORDER BY id"
        Cmd = New SqlCommand(StrCmd, conn)
        Dr = Cmd.ExecuteReader
        lvwRooms.Items.Clear()

        While Dr.Read
            Dim li As New ListViewItem(Dr.Item("id").ToString)

            With li

                .SubItems.Add(Dr.Item("roomNo").ToString)
                .SubItems.Add(Dr.Item("roomType").ToString)
                .SubItems.Add(Dr.Item("rates").ToString)
                .SubItems.Add(Dr.Item("vat").ToString)

                lvwRooms.Items.Add(li)

            End With

        End While

        Dr.Close()
        Cmd.Dispose()


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        '
        'validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------
        If txtRoomNo.Text.Trim = "" Then
            ErrorProvider1.SetError(txtRoomNo, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtRoomNo, "")
        End If


        If txtRates.Text.Trim = "" Then
            ErrorProvider1.SetError(txtRates, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtRates, "")
        End If

        If combo_rtype.Text.Trim = "" Then
            ErrorProvider1.SetError(combo_rtype, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(combo_rtype, "")
        End If

        If combo_vat.Text.Trim = "" Then
            ErrorProvider1.SetError(combo_vat, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(combo_vat, "")
        End If



        ' End validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------


        If MessageBox.Show("Save Record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then




            StrCmd = ""

            If currentID <> 0 Then

                StrCmd = ""
                StrCmd = "UPDATE rooms set roomType = '" & combo_rtype.Text.ToUpper.Trim & "',rates = '" & txtRates.Text & "',vat = '" & combo_vat.Text & "' where id = " & currentID & ""

            Else
                StrCmd = ""
                StrCmd = "INSERT INTO rooms" &
                            "           (roomNo" &
                            "           ,roomType" &
                            "           ,rates" &
                            "           ,vat)" &
                            "     VALUES" &
                            "           ('" & txtRoomNo.Text.ToUpper.Trim & "'" &
                            "           ,'" & combo_rtype.Text.ToUpper & "'" &
                            "           ,'" & txtRates.Text.ToUpper & "'" &
                            "           ,'" & combo_vat.Text.ToLower & "')"
            End If

            Cmd = New SqlCommand(StrCmd, conn)

            Try

                Cmd.ExecuteNonQuery()

            Catch ex As Exception

                MessageBox.Show(ex.Message)
                Exit Sub

            End Try

            Cmd.Dispose()

            LoadDataTo_lvwRooms()

            combo_rtype.Text = Nothing
            txtRates.Text = ""
            txtRoomNo.Text = ""
            combo_vat.Text = Nothing

            txtRoomNo.Focus()

            currentID = 0
            currentState = 0
            Beep()

            MessageBox.Show("Record Successfully Saved!", "Save", MessageBoxButtons.OK)


        End If
        '
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        currentState = 1
        currentID = 0

        txtRoomNo.ReadOnly = False
        txtRates.ReadOnly = False



    End Sub


End Class