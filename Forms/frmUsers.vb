Imports System.Data.SqlClient

Public Class frmUsers

    Dim Dr As SqlDataReader
    Dim currentId As Integer = 0
    Dim currentState As Integer = 0


    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        chkBoxSuperAdmin.Checked = False
        Define_lvwUsers_Columns()
        LoadDataTo_lvwUsers()

    End Sub


    Private Sub Define_lvwUsers_Columns()

        With lvwUsers

            .Columns.Add("ID", 100, HorizontalAlignment.Left)
            .Columns.Add("Name", 100, HorizontalAlignment.Left)
            .Columns.Add("Super Admin", 100, HorizontalAlignment.Left)
            .CheckBoxes = True
            .View = View.Details

        End With

    End Sub

    Private Sub LoadDataTo_lvwUsers()

        StrCmd = ""
        StrCmd = "SELECT * FROM users ORDER BY id"
        Cmd = New SqlCommand(StrCmd, conn)
        Dr = Cmd.ExecuteReader
        lvwUsers.Items.Clear()

        While Dr.Read
            Dim li As New ListViewItem(Dr.Item("id").ToString)

            With li

                .SubItems.Add(Dr.Item("name").ToString)
                .SubItems.Add(Dr.Item("super_admin").ToString)
                lvwUsers.Items.Add(li)

            End With

        End While

        Dr.Close()
        Cmd.Dispose()


    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim isSuperAdmin As String = ""


        If txtUserName.Text.Trim = "" Then
            ErrorProvider1.SetError(txtUserName, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtUserName, "")
        End If


        If txtUserPassword.Text.Trim = "" Then
            ErrorProvider1.SetError(txtUserPassword, "Invalid Input")
            Exit Sub
        Else
            ErrorProvider1.SetError(txtUserPassword, "")
        End If


        If chkBoxSuperAdmin.Checked = True Then
            isSuperAdmin = "Y"
        Else
            isSuperAdmin = "N"
        End If


        If MessageBox.Show("Save Record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then




            StrCmd = ""

            If currentId <> 0 Then

                StrCmd = ""
                StrCmd = "UPDATE users set name = '" & txtUserName.Text.ToUpper.Trim & "',password = '" & txtUserPassword.Text.ToUpper & "',super_admin = '" & isSuperAdmin & "' where id = " & currentId & ""


            Else

                StrCmd = "INSERT INTO users" &
                    "           (name" &
                    "           ,password" &
                    "           ,super_admin)" &
                    "     VALUES" &
                    "           ('" & txtUserName.Text.ToUpper.Trim & "'" &
                    "           ,'" & txtUserPassword.Text.ToUpper & "'" &
                    "           ,'" & isSuperAdmin & "')"

            End If


            Cmd = New SqlCommand(StrCmd, conn)

            Try

                Cmd.ExecuteNonQuery()

            Catch ex As Exception

                MessageBox.Show(ex.Message)
                Exit Sub

            End Try

            Cmd.Dispose()

            LoadDataTo_lvwUsers()


            txtUserName.Text = ""
            txtUserPassword.Text = ""
            txtUserName.Focus()

            txtUserName.ReadOnly = True
            txtUserPassword.ReadOnly = True
            chkBoxSuperAdmin.Enabled = False
            chkBoxSuperAdmin.Checked = False


            currentId = 0
            currentState = 0

            btnadd.Focus()
            Beep()

            MessageBox.Show("Record Successfully Saved!", "Save", MessageBoxButtons.OK)


        End If


    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        currentState = 0
        currentId = 0

        txtUserName.ReadOnly = False
        txtUserPassword.ReadOnly = False
        chkBoxSuperAdmin.Enabled = True
        txtUserPassword.Text = ""
        txtUserName.Text = ""

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        currentState = 1
        currentId = 0

        txtUserName.ReadOnly = False
        txtUserPassword.ReadOnly = False
        chkBoxSuperAdmin.Enabled = True


    End Sub

    Private Sub lvwUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwUsers.SelectedIndexChanged


    End Sub

    Private Sub lvwUsers_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lvwUsers.ItemSelectionChanged

        Dim I As Integer = 0

        If currentState = 1 Then

            For I = 0 To lvwUsers.Items.Count - 1

                If lvwUsers.Items(I).Selected = True Then

                    currentId = CInt(lvwUsers.Items(I).SubItems(0).Text)
                    txtUserName.Text = lvwUsers.Items(I).SubItems(1).Text
                    txtUserPassword.Text = ""

                    If lvwUsers.Items(I).SubItems(2).Text.Trim = "Y" Then
                        chkBoxSuperAdmin.Checked = True
                    Else
                        chkBoxSuperAdmin.Checked = False
                    End If

                End If

            Next

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        StrCmd = ""
        Dim I As Integer = 0
        Dim Count As Integer = 0


        For I = 0 To lvwUsers.Items.Count - 1

            If lvwUsers.Items(I).Checked = True Then

                currentId = CInt(lvwUsers.Items(I).SubItems(0).Text)

                StrCmd = ""
                StrCmd = "DELETE users where id = " & currentId & ""

                Cmd = New SqlCommand(StrCmd, conn)

                Try

                    Cmd.ExecuteNonQuery()

                Catch ex As Exception

                    MessageBox.Show(ex.Message)

                End Try

                Cmd.Dispose()

                Count = +1

            End If

        Next

        LoadDataTo_lvwUsers()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        '    Dim StrCmd As String = ""
        '    Dim RCount As Integer = 0
        '    Dim I As Integer = 0

        '    Dim Dr As SqlDataReader
        '    Dim Cmd As SqlCommand
        '    Dim MaxRecords As Integer = 0





        '    Dim found As Boolean = My.Computer.FileSystem.DirectoryExists(Application.StartupPath & "\users")
        '    If found = False Then
        '        My.Computer.FileSystem.CreateDirectory(Application.StartupPath & "\users\")
        '    End If


        '    '* Fetch Record Number To Pass To Dynamic Array
        '    '* ---------------------------------------------

        '    StrCmd = ""
        '    StrCmd = "Select Count(*) As MaxRecords From users"
        '    Cmd = New SqlCommand(StrCmd, conn)
        '    Dr = Cmd.ExecuteReader

        '    While Dr.Read
        '        MaxRecords = CInt(Dr.Item("MaxRecords"))
        '    End While

        '    Dr.Close()
        '    Cmd.Dispose()


        '    '* Since Excel Takes Only 64000 Records Maximum so if maxrecords > 60000
        '    '* Back Out
        '    '* Advice The User To Reduce His/Her Date Range
        '    '* ----------------------------------------------------------------------

        '    If MaxRecords > 60000 Then

        '        MessageBox.Show("Records Number More Than An Excel Sheet Limit" & vbCrLf &
        '                        "Sorry For That Small Inconvenience", "Excel Sheet Limit", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '        Exit Sub

        '    End If


        '    StrCmd = ""




        '    Cmd = New SqlCommand(StrCmd, conn)
        '    Dr = Cmd.ExecuteReader


        '    Dim ColsCount As Integer = Dr.FieldCount - 1
        '    Dim FieldsArr(0, ColsCount) As String
        '    Dim RowCounter As Integer = 0
        '    Dim DataArr(MaxRecords, ColsCount) As Object



        '    '* Populate the array of field names by using the DataReader's method 'GetName'.
        '    '* -----------------------------------------------------------------------------

        '    For NameCounter As Integer = 0 To ColsCount
        '        FieldsArr(0, NameCounter) = Dr.GetName(NameCounter)
        '    Next


        '    While Dr.Read

        '        For RecordCounter As Integer = 0 To ColsCount
        '            DataArr(RowCounter, RecordCounter) = "'" & Dr.Item(RecordCounter)
        '        Next
        '        RowCounter = RowCounter + 1

        '        ''* delay Counter
        '        ''* -------------

        '        'For I = 1 To 100
        '        '    PleaseWait.ProgressBar1.PerformStep()
        '        'Next


        '    End While

        '    Dr.Close()

        '    '* Close Patience request Form
        '    '* ---------------------------
        '    'PleaseWait.Close()



        '    '* Variables for Excel.
        '    '* --------------------

        '    Dim xlApp As New Microsoft.Office.Interop.Excel.Application
        '    Dim xlWBook As Microsoft.Office.Interop.Excel.Workbook = xlApp.Workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet)
        '    Dim xlWSheet As Microsoft.Office.Interop.Excel.Worksheet = CType(xlWBook.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet)
        '    Dim xlCalc As Microsoft.Office.Interop.Excel.XlCalculation

        '    '* Save the present setting for Excel's calculation mode and turn it off.
        '    '* ----------------------------------------------------------------------

        '    With xlApp
        '        .StandardFont = "Courier New"
        '        .StandardFontSize = 12
        '        xlCalc = .Calculation
        '        .Calculation = Microsoft.Office.Interop.Excel.XlCalculation.xlCalculationManual
        '    End With


        '    '* Write the field names and the data to the targeting worksheet.
        '    '* --------------------------------------------------------------


        '    With xlWSheet
        '        .Range(.Cells(1, 1), .Cells(1, ColsCount + 1)).Value = FieldsArr
        '        .Range(.Cells(2, 1), .Cells(RowCounter + 2, ColsCount + 1)).Value = DataArr
        '        .UsedRange.Columns.AutoFit()
        '    End With



        '    MessageBox.Show("Your File Is Ready." & vbCrLf _
        '                  & "Save It In The Folder :" & Application.StartupPath & "\AllStocks\" & vbCrLf _
        '                  & "With Name As AllStocks", "Stock Master Items", MessageBoxButtons.OK, MessageBoxIcon.Information)



        '    '* Make Excel available to the user.
        '    '* ---------------------------------

        '    With xlApp

        '        .Visible = True
        '        .UserControl = True

        '        '* Restore the calculation mode.
        '        '* -----------------------------

        '        .Calculation = xlCalc

        '    End With

        '    '* Relase objects from memory.
        '    '* ---------------------------

        '    Cmd.Dispose()


        '    Dr = Nothing

        '    Cmd = Nothing

        '    xlWSheet = Nothing

        '    xlWBook = Nothing

        '    xlApp = Nothing

    End Sub
End Class