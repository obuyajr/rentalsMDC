Imports System.Data.SqlClient
Module sysPublics


    Public conn As SqlClient.SqlConnection = New SqlConnection
    Public StrCmd As String
    Public Cmd As New SqlCommand
    Public loggedInActiveUserID As Integer = 0

    Public Function generateYYYYdashMMdashDDDateformat(ByVal strDate As String)
        Dim dayPart, monthPart, yearPart As String
        dayPart = CDate(strDate).Day
        monthPart = CDate(strDate).Month
        yearPart = CDate(strDate).Year

        If Len(dayPart.Trim) = 1 Then
            dayPart = "0" & dayPart.Trim
        End If

        If Len(monthPart.Trim) = 1 Then
            monthPart = "0" & monthPart.Trim
        End If

        Return yearPart & "-" & monthPart & "-" & dayPart

    End Function

    Public Function EstablishedConnectionToDB() As Boolean


        StrCmd = "server=DESKTOP-KCVKSCU\DESKTOPKCVKSCU;database=housing;uid=sa;pwd=felix37brock;MultipleActiveResultSets=True;User Instance=False"

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


    'Public vatV As Decimal = 0.16
    'Public vatZ As Decimal = 0.14
    'Public amountAfterVat As Decimal
    'Public vatAmount As Decimal
    'Public netAmount As Decimal


End Module
