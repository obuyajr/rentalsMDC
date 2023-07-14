Imports System.Data.SqlClient
Module sysPublics


    Public conn As SqlClient.SqlConnection = New SqlConnection
    Public StrCmd As String
    Public Cmd As New SqlCommand
    Public loggedInActiveUserID As Integer = 0



    Public Function EstablishedConnectionToDB() As Boolean


        StrCmd = "server=DESKTOP-KCVKSCU;database=MDCRent;uid=felix;pwd=felix;MultipleActiveResultSets=True;User Instance=False"

        conn = New SqlConnection(StrCmd)

        Try

            conn.Open()

        Catch ex As Exception

            MessageBox.Show("Establishing Connection To Database Server Failed", "Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If MessageBox.Show("Attempt Another Connection?", "Connection", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                conn.Open()

            End If

            End

        End Try


        If conn.State = ConnectionState.Open Then
            Return True
        Else
            Return False
        End If

    End Function


    Public vatV As Decimal = 0.16
    Public vatZ As Decimal = 0.14
    Public amountAfterVat As Decimal
    Public vatAmount As Decimal
    Public netAmount As Decimal


End Module
