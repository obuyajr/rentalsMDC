Imports System.Data.SqlClient

Public Class frmPayment_records

    Private Sub frmPayment_records_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBoxes_To_Take_Uppercase_data()
        Display_Data_on_Comboboxes_from_DatabaseTable()

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
        StrCmd = "SELECT tenant_id, tenant_name, total FROM rentHouse WHERE house_no = '" & combo_houseNo.Text & "'"

        Cmd = New SqlCommand(StrCmd, conn)

        Dim reader As SqlDataReader = Cmd.ExecuteReader()

        If reader.Read() Then

            txt_id.Text = reader("tenant_id").ToString()
            txt_tenantName.Text = reader("tenant_name").ToString()
            txt_balance.Text = reader("total")

        End If

        reader.Close()




        '
    End Sub




    '*----------------------------- End Functions-----------------------------------------------------------------*

End Class