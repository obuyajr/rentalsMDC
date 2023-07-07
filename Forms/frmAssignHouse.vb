Imports System.Data.SqlClient

Public Class frmAssignHouse

    Private Sub frmAssignHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Display_Data_on_Comboboxes_from_DatabaseTable()

    End Sub







    Public Sub Display_Data_on_Comboboxes_from_DatabaseTable()

        Dim query As String = "SELECT DISTINCT location, category, status FROM houses"



        Using cmd As New SqlCommand(query, conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()

                combo_category.Items.Clear()

                While reader.Read()

                    combo_location.Items.Add(reader("location").ToString())
                    combo_category.Items.Add(reader("category").ToString())
                    combo_status.Items.Add(reader("status").ToString())

                End While

                reader.Close()

            End Using

        End Using

    End Sub


End Class