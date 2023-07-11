Imports System.Data.SqlClient

Public Class frmPayment_records

    Private Sub frmPayment_records_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxes_To_Take_Uppercase_data()
        Display_Data_on_Comboboxes_from_DatabaseTable()

    End Sub


    '*-----------------------Insert into Rent records table------------------------------------------------------
    '*-----------------------------------------------------------------------------------------------------------
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_pay.Click




        ' txt_total.Text = (Decimal.Parse(txt_rent.Text) + Decimal.Parse(txtDeposit.Text))
        Dim cashPaid As New Decimal
        cashPaid = CDec(txt_cash.Text)

        Dim currentDate As DateTime = DateTime.Now
        Dim transactionDesc As String = "Pay Rent For :" + combo_houseNo.Text
        Dim transactionType As String = " Payment "

        If MessageBox.Show("Save Record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            If chkbox_payment.Checked Then
                StrCmd = ""
                StrCmd = "INSERT INTO rent_records" &
                                "           (date" &
                                "           ,house_no" &
                                "           ,tenant_id" &
                                "           ,tenant_name" &
                                "           ,transaction_description" &
                                "           ,transaction_type" &
                                "           ,debit" &
                                "           ,credit)" &
                                "     VALUES" &
                                "           ('" & currentDate.ToString("dd-MM-yyyy  HH:mm:ss") & "'" &
                                "           ,'" & combo_houseNo.Text.ToUpper & "'" &
                                "           ,'" & txt_id.Text.ToUpper & "'" &
                                "           ,'" & txt_tenantName.Text.ToUpper & "'" &
                                "           ,'" & transactionDesc & "'" &
                                "           ,'Payment'" &
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

        'combo_houseNo.Text = Nothing
        'txt_cash.Text = ""
        'txt_id.Text = ""
        'txt_mMoney.Text = ""
        'txt_tenantName.Text = ""



        ''*--------------------------End-------------------------------------------------------------------------------
        ''*------------------------------------------------------------------------------------------------------------
        ''*******************************'







        '*-----------------------Insert into Rent Updates table------------------------------------------------------
        '*-----------------------------------------------------------------------------------------------------------

        Dim balance As Decimal
        balance = CDec(txt_balance.Text) - CDec(txt_cash.Text)

        If chkbox_payment.Checked Then
            ' Construct the SQL UPDATE statement
            StrCmd = "UPDATE rent_updates" &
             " SET date = '" & currentDate.ToString("dd-MM-yyyy HH:mm:ss") & "'" &
             " ,tenant_id = '" & txt_id.Text.ToUpper & "'" &
             " ,tenant_name = '" & txt_tenantName.Text.ToUpper & "'" &
             " ,balance = " & balance &
             " WHERE house_no = '" & combo_houseNo.Text.ToUpper & "'"

        End If





        Cmd = New SqlCommand(StrCmd, conn)

        Try

            Cmd.ExecuteNonQuery()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            Exit Sub

        End Try

        Cmd.Dispose()



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


        'dropdown
        combo_houseNo.DropDownStyle = ComboBoxStyle.DropDownList



    End Sub



    Public Sub Display_Data_on_Comboboxes_from_DatabaseTable()


        Dim query As String = "SELECT DISTINCT house_no FROM houses"

        Using cmd As New SqlCommand(query, conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()

                combo_houseNo.Items.Clear()

                While reader.Read()

                    combo_houseNo.Items.Add(reader("house_no").ToString())

                End While

                reader.Close()

            End Using

        End Using
    End Sub

    Private Sub combo_houseNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_houseNo.SelectedIndexChanged

        'display data to textbox if text changes
        StrCmd = ""
        StrCmd = "SELECT tenant_id, tenant_name, balance FROM rent_updates WHERE house_no = '" & combo_houseNo.Text & "'"

        Cmd = New SqlCommand(StrCmd, conn)

        Dim reader As SqlDataReader = Cmd.ExecuteReader()

        If reader.Read() Then

            txt_id.Text = reader("tenant_id").ToString()
            txt_tenantName.Text = reader("tenant_name").ToString()
            txt_balance.Text = reader("balance")


        End If

        reader.Close()




        '
    End Sub





    '*----------------------------- End Functions-----------------------------------------------------------------*

End Class