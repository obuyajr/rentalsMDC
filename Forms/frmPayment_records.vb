Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class frmPayment_records

    Private Sub frmPayment_records_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxes_To_Take_Uppercase_data()
        Display_Data_on_Comboboxes_from_DatabaseTable()

    End Sub


    '*-----------------------Insert into Rent records table------------------------------------------------------
    '*-----------------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_pay.Click



        'validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------
        If combo_houseNo.Text.Trim = "" Then

            ErrorProvider1.SetError(combo_houseNo, "Invalid Input")

            Exit Sub

        Else

            ErrorProvider1.SetError(combo_houseNo, "")

        End If

        If txt_tenantName.Text.Trim = "" Then

            ErrorProvider1.SetError(txt_tenantName, "Invalid Input")

            Exit Sub

        Else

            ErrorProvider1.SetError(txt_tenantName, "")

        End If

        If txt_id.Text.Trim = "" Then

            ErrorProvider1.SetError(txt_id, "Invalid Input")

            Exit Sub

        Else

            ErrorProvider1.SetError(txt_id, "")

        End If

        If txt_id.Text.Trim = "" Then

            ErrorProvider1.SetError(txt_id, "Invalid Input")

            Exit Sub

        Else

            ErrorProvider1.SetError(txt_id, "")

        End If

        If chkbox_payment.Checked Then

            ErrorProvider1.SetError(chkbox_payment, String.Empty)
        Else

            ErrorProvider1.SetError(chkbox_payment, "This checkbox must be checked.")

            Exit Sub
        End If





        '-----------------------------End validation ---------------------------------------
        '-----------------------------------------------------------------------------------


        'txt_total.Text = (Decimal.Parse(txt_rent.Text) + Decimal.Parse(txtDeposit.Text))
        Dim cashPaid As New Decimal
        cashPaid = CDec(txt_cash.Text)

        Dim currentDate As DateTime = DateTime.Now
        Dim transactionDesc As String = "Pay Rent For :" + combo_houseNo.Text
        Dim transactionType As String = " PAYMENT "

        If MessageBox.Show("Save Record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            If chkbox_payment.Checked Then
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
                                        "           ,'" & transactionDesc & "'" &
                                        "           ,'PAYMENT'" &
                                        "           ," & 0 & "" &
                                        "           ," & cashPaid & ")"


            End If



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

        MessageBox.Show("Record Successfully Saved!", "Save", MessageBoxButtons.OK)




        ''*-------------------------------------------End----------------------------------------------------
        ''*-----------------------------''*******************************'-----------------------------------








        '*-------------------------------Insert into Rent Updates table---------------------------------------------
        '*-----------------------------------------------------------------------------------------------------------

        Dim balance As Decimal
        balance = CDec(txt_balance.Text) - CDec(txt_cash.Text)

        If chkbox_payment.Checked Then
            ' Construct the SQL UPDATE statement
            StrCmd = "UPDATE rentUpdates" &
             " SET tenantID = '" & txt_id.Text.ToUpper & "'" &
             " ,runningBalance = " & balance &
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

        txt_tenantName.Text = ""
        txt_balance.Text = ""
        txt_cash.Text = ""
        txt_id.Text = ""
        txt_mMoney.Text = ""
        combo_houseNo.Text = Nothing
        chkbox_payment.Checked = True

        Display_Data_on_Comboboxes_from_DatabaseTable()


        '*--------------------------End-------------------------------------------------------------------------------
        '*------------------------------------------------------------------------------------------------------------
        '*******************************'

    End Sub








    '*-----------------------------Functions----------------------------------------------------------------------*
    Private Sub TextBoxes_To_Take_Uppercase_data()

        txt_balance.CharacterCasing = CharacterCasing.Upper
        txt_balance.ReadOnly = True
        txt_id.CharacterCasing = CharacterCasing.Upper
        txt_id.ReadOnly = True
        txt_tenantName.ReadOnly = True


        'dropdown
        combo_houseNo.DropDownStyle = ComboBoxStyle.DropDownList



    End Sub



    Public Sub Display_Data_on_Comboboxes_from_DatabaseTable()


        Dim query As String = "SELECT DISTINCT houseNo FROM houseRegistration where status = 'OCCUPIED'"

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

        'display data to textbox if text changes
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
            txt_balance.Text = reader("runningBalance")


        End If

        reader.Close()


        '
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        If MessageBox.Show("Clear These Records?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            '* clear fields
            txt_balance.Text = ""
            txt_id.Text = ""
            txt_cash.Text = ""
            txt_mMoney.Text = ""
            txt_tenantName.Text = ""
            combo_houseNo.Text = Nothing

        End If



    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()

    End Sub





    '*----------------------------- End Functions-----------------------------------------------------------------*

End Class