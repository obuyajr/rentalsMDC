Imports System.Data.SqlClient

Public Class frmCreditDebitNote

    Private Sub frmCreditDebitNote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Display_Data_on_Comboboxes_from_DatabaseTable()
        combo_houseNo.DropDownStyle = ComboBoxStyle.DropDownList
        txt_balance.ReadOnly = True
        txt_id.ReadOnly = True
        txt_tenantName.ReadOnly = True
        txtReason.CharacterCasing = CharacterCasing.Upper



    End Sub

    Public Sub Display_Data_on_Comboboxes_from_DatabaseTable()


        Dim query As String = "SELECT houseNo FROM houseRegistration WHERE status = 'OCCUPIED' "


        Using cmd As New SqlCommand(query, conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()

                combo_houseNo.Items.Clear()

                While reader.Read()

                    combo_houseNo.Items.Add(reader("houseNo").ToString())

                End While

                reader.Close()

            End Using

        End Using
    End Sub


    Private Sub combo_houseNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_houseNo.SelectedIndexChanged

        StrCmd = ""
        StrCmd = "SELECT rentUpdates.tenantID,
                         rentUpdates.runningBalance,
                         tenantRegistration.tenantName
                  FROM 
                         rentUpdates
                  JOIN   
                         tenantRegistration ON rentUpdates.tenantID = tenantRegistration.id
                  WHERE 
                         rentUpdates.houseNo = '" & combo_houseNo.Text & "'"

        Cmd = New SqlCommand(StrCmd, conn)

        Dim reader As SqlDataReader = Cmd.ExecuteReader()

        If reader.Read() Then

            txt_id.Text = reader("tenantID").ToString()
            txt_tenantName.Text = reader("tenantName").ToString()
            txt_balance.Text = FormatNumber(CDec(reader("runningBalance"))).ToString()





        End If

        reader.Close()
        Cmd.Dispose()

    End Sub

    Private Sub chboxDebit_CheckedChanged(sender As Object, e As EventArgs) Handles chboxDebit.CheckedChanged

        If chboxDebit.Checked = True Then
            chboxCredit.Checked = False

        End If
    End Sub

    Private Sub chboxCredit_CheckedChanged(sender As Object, e As EventArgs) Handles chboxCredit.CheckedChanged

        If chboxCredit.Checked = True Then
            chboxDebit.Checked = False

        End If
    End Sub

    '*---------------------------------------------------------------------------------------
    Public Sub insertDataToDb()





        'validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------
        If validateStringData(txt_cash, ErrorProvider1) = True Then
            Exit Sub
        End If


        If validateStringData(txt_balance, ErrorProvider1) = True Then
            Exit Sub
        End If

        If validateStringData(txtReason, ErrorProvider1) = True Then
            Exit Sub
        End If


        If validateStringData(combo_houseNo, ErrorProvider1) = True Then
            Exit Sub
        End If

        If validateStringData(txt_tenantName, ErrorProvider1) = True Then
            Exit Sub
        End If

        If validateStringData(txt_id, ErrorProvider1) = True Then
            Exit Sub
        End If





        ' End validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------



        If MessageBox.Show("Save These Records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            If chboxDebit.Checked = True Then

                StrCmd = ""
                StrCmd = "INSERT INTO chargeLog" &
                                        "           (houseNo" &
                                        "           ,tenantID" &
                                        "           ,description" &
                                        "           ,transactionType" &
                                        "           ,drAmount" &
                                        "           ,crAmount)" &
                                        "     VALUES" &
                                        "           ('" & combo_houseNo.Text.ToUpper & "'" &
                                        "           ,'" & txt_id.Text.ToUpper & "'" &
                                        "           ,'" & txtReason.Text & "'" &
                                        "           ,'BILL'" &
                                        "           ," & txt_cash.Text & "" &
                                        "           ," & 0 & ")"


            ElseIf chboxCredit.Checked = True Then
                StrCmd = ""
                StrCmd = "INSERT INTO chargeLog" &
                                        "           (houseNo" &
                                        "           ,tenantID" &
                                        "           ,description" &
                                        "           ,transactionType" &
                                        "           ,drAmount" &
                                        "           ,crAmount)" &
                                        "     VALUES" &
                                        "           ('" & combo_houseNo.Text.ToUpper & "'" &
                                        "           ,'" & txt_id.Text.ToUpper & "'" &
                                        "           ,'" & txtReason.Text & "'" &
                                        "           ,'PAYMENT'" &
                                        "           ," & 0 & "" &
                                        "           ," & txt_cash.Text & ")"
            End If
            Cmd = New SqlCommand(StrCmd, conn)

            Try

                Cmd.ExecuteNonQuery()


            Catch ex As Exception

                MessageBox.Show(ex.Message)
                Exit Sub

            End Try

            Cmd.Dispose()

            '*--------------------------------------------------------------------------------
            '*--------------------------------------------------------------------------------

            If chboxDebit.Checked = True Then

                StrCmd = ""
                StrCmd = "UPDATE rentUpdates" &
                 " SET tenantID = '" & txt_id.Text.ToUpper & "'" &
                 " ,runningBalance = runningBalance + " & CDec(txt_cash.Text) &
                 " WHERE houseNo = '" & combo_houseNo.Text.ToUpper & "'"

            ElseIf chboxCredit.Checked = True Then
                StrCmd = ""

                StrCmd = "UPDATE rentUpdates" &
                 " SET tenantID = '" & txt_id.Text.ToUpper & "'" &
                 " ,runningBalance =runningBalance - " & CDec(txt_cash.Text) &
                 " WHERE houseNo = '" & combo_houseNo.Text.ToUpper & "'"
            End If
            Cmd = New SqlCommand(StrCmd, conn)

            Try

                Cmd.ExecuteNonQuery()


            Catch ex As Exception

                MessageBox.Show(ex.Message)
                Exit Sub

            End Try

            Cmd.Dispose()





            Beep()

        End If


        MessageBox.Show("Record Successfully Saved!", "Save", MessageBoxButtons.OK)


        combo_houseNo.Text = Nothing
        txt_tenantName.Text = ""
        txt_id.Text = ""
        txt_balance.Text = ""
        txt_cash.Text = ""
        chboxCredit.Checked = False
        chboxDebit.Checked = False
        txtReason.Text = ""


    End Sub

    Private Sub btn_pay_Click(sender As Object, e As EventArgs) Handles btn_issue.Click

        insertDataToDb()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If MessageBox.Show("Clear These Records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            combo_houseNo.Text = Nothing
            txt_tenantName.Text = ""
            txt_id.Text = ""
            txt_balance.Text = ""
            txt_cash.Text = ""
            chboxCredit.Checked = False
            chboxDebit.Checked = False
            txtReason.Text = ""

        End If


    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()

    End Sub










    '*-----------------------------------------------------------------------------------------*
    '*------------------------------------------------------------------------------------------
End Class