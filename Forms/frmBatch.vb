Imports System.Data.SqlClient

Public Class frmBatch
    Dim Dr As SqlDataReader
    Dim counter As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        StrCmd = ""
        StrCmd = "SELECT * FROM rentHouse"
        Cmd = New SqlCommand(StrCmd, conn)
        Dr = Cmd.ExecuteReader

        counter = 0


        While Dr.Read


            StrCmd = ""
            StrCmd = "INSERT INTO rent_records" &
                                "           (house_no" &
                                "           ,tenant_id" &
                                "           ,tenant_name" &
                                "           ,transaction_description" &
                                "           ,transaction_type" &
                                "           ,debit" &
                                "           ,credit)" &
                                "     VALUES" &
                                "           ('" & Dr.Item("house_no") & "'" &
                                "           ,'" & Dr.Item("tenant_id") & "'" &
                                "           ,'" & Dr.Item("tenant_name") & "'" &
                                "           ,'Rent House Number:" & Dr.Item("house_no") & "'" &
                                "           ,'BILL'" &
                                "           ," & Dr.Item("rent") & "" &
                                "           ," & 0 & ")"

            Cmd = New SqlCommand(StrCmd, conn)


            Try
                Cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            Cmd.Dispose()


            StrCmd = ""
            StrCmd = "INSERT INTO rent_updates" &
                                "           (house_no" &
                                "           ,tenant_id" &
                                "           ,tenant_name" &
                                "           ,balance)" &
                                "     VALUES" &
                                "           ('" & Dr.Item("house_no") & "'" &
                                "           ,'" & Dr.Item("tenant_id") & "'" &
                                "           ,'" & Dr.Item("tenant_name") & "'" &
                                "           ," & Dr.Item("rent") & ")"

            Cmd = New SqlCommand(StrCmd, conn)


            Try
                Cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
            Cmd.Dispose()


            counter = +1


        End While
        Dr.Close()
        Cmd.Dispose()

        MessageBox.Show("records updated successfully")


    End Sub
End Class