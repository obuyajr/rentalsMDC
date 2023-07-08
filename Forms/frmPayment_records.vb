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
        txt_category.CharacterCasing = CharacterCasing.Upper
        txt_category.ReadOnly = True
        txt_location.CharacterCasing = CharacterCasing.Upper
        txt_location.ReadOnly = True

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


    '*----------------------------- End Functions-----------------------------------------------------------------*

End Class