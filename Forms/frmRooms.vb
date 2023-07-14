Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmRooms
    Dim Dr As SqlDataReader
    Dim currentID As Integer = 0
    Dim currentState As Integer = 0

    Private Sub frmRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxes_To_Take_Uppercase_data()
        Define_listviewRooms_Columns()
        LoadDataTo_lvwRooms()

        combo_rtype.DropDownStyle = ComboBoxStyle.DropDownList
        combo_vat.DropDownStyle = ComboBoxStyle.DropDownList


    End Sub

    Private Sub TextBoxes_To_Take_Uppercase_data()

        txtRoomNo.CharacterCasing = CharacterCasing.Upper

    End Sub

    Private Sub Define_listviewRooms_Columns()

        With lvwRooms

            .Columns.Add(" ID", 50, HorizontalAlignment.Left)
            .Columns.Add(" Room No.", 100, HorizontalAlignment.Left)
            .Columns.Add("Room Type", 200, HorizontalAlignment.Left)
            .Columns.Add("Vat Type", 100, HorizontalAlignment.Left)
            .Columns.Add("Net Amount", 100, HorizontalAlignment.Left)
            .Columns.Add("Vat Amount", 100, HorizontalAlignment.Left)
            .Columns.Add("Post Vat (rates) ", 200, HorizontalAlignment.Left)
            .Columns.Add("Status", 100, HorizontalAlignment.Left)


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
                .SubItems.Add(Dr.Item("vatType").ToString)
                .SubItems.Add(Dr.Item("netAmount").ToString)
                .SubItems.Add(Dr.Item("vatAmount").ToString)
                .SubItems.Add(Dr.Item("rates_afterVAT").ToString)
                .SubItems.Add(Dr.Item("status").ToString)

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

        If chkboxStatus.CheckState = False Then
            ErrorProvider1.SetError(chkboxStatus, "Invalid Input")

            Exit Sub
        Else
            ErrorProvider1.SetError(chkboxStatus, "")
        End If


        ' End validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------


        If MessageBox.Show("Save Record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            calculateVATamount()



            StrCmd = ""

            If currentID <> 0 Then

                StrCmd = ""
                StrCmd = "UPDATE rooms set roomType = '" & combo_rtype.Text.ToUpper.Trim & "',vatType = '" & combo_vat.Text & "',netAmount = " & netAmount & " ,vatAmount = " & vatAmount & ",rates_afterVAT= " & amountAfterVat & " , status = 'AVAILABLE' where id = " & currentID & ""

            Else
                StrCmd = ""
                StrCmd = "INSERT INTO rooms" &
                            "           (roomNo" &
                            "           ,roomType" &
                            "           ,vatType" &
                            "           ,netAmount" &
                            "           ,vatAmount" &
                            "           ,rates_afterVAT" &
                            "           ,status)" &
                            "     VALUES" &
                            "           ('" & txtRoomNo.Text.ToUpper.Trim & "'" &
                            "           ,'" & combo_rtype.Text.ToUpper & "'" &
                            "           ,'" & combo_vat.Text.ToUpper & "'" &
                            "           ," & netAmount & "" &
                            "           ," & vatAmount & "" &
                            "           ," & amountAfterVat & "" &
                            "           , 'AVAILABLE')"
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        StrCmd = ""
        Dim I As Integer = 0
        Dim Count As Integer = 0


        For I = 0 To lvwRooms.Items.Count - 1

            If lvwRooms.Items(I).Checked = True Then

                Dim result As DialogResult = MessageBox.Show("Are you sure you want to Delete this Record ??", "Warning", MessageBoxButtons.YesNo)

                If result = DialogResult.Yes Then
                    currentID = CInt(lvwRooms.Items(I).SubItems(0).Text)


                    StrCmd = ""
                    StrCmd = "DELETE rooms where id = " & currentID & ""

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

        LoadDataTo_lvwRooms()


    End Sub

    Private Sub lvwRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwRooms.SelectedIndexChanged

        Dim I As Integer = 0

        If currentState = 1 Then

            For I = 0 To lvwRooms.Items.Count - 1

                If lvwRooms.Items(I).Selected = True Then


                    currentID = lvwRooms.Items(I).SubItems(0).Text
                    txtRoomNo.Text = lvwRooms.Items(I).SubItems(1).Text
                    combo_rtype.Text = lvwRooms.Items(I).SubItems(2).Text
                    txtRates.Text = lvwRooms.Items(I).SubItems(3).Text
                    combo_vat.Text = lvwRooms.Items(I).SubItems(4).Text


                End If

            Next

        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        currentState = 0
        currentID = 0

        txtRoomNo.ReadOnly = False
        txtRates.ReadOnly = False


        txtRates.Text = ""
        txtRoomNo.Text = ""
        combo_rtype.Text = Nothing
        combo_vat.Text = Nothing

    End Sub

    Public Sub calculateVATamount()

        amountAfterVat = CDec(txtRates.Text)

        If combo_vat.SelectedItem.ToString() = "V" Then
            netAmount = amountAfterVat / (vatV + 1)
            vatAmount = netAmount * vatV

        Else
            netAmount = amountAfterVat / (vatZ + 1)
            vatAmount = netAmount * vatZ

        End If


    End Sub
End Class