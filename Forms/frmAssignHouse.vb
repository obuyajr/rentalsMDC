Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmAssignHouse

    Dim Dr As SqlDataReader
    Dim currentId As Integer = 0
    Dim currentState As Integer = 0


    Private Sub frmAssignHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Display_Data_on_Comboboxes_from_DatabaseTable()
        Define_listviewHouses_Columns()


        txt_id.ReadOnly = True
        txt_houseNo.ReadOnly = True
        txt_rent.ReadOnly = True
        txtDeposit.ReadOnly = True
        combo_tenantName.DropDownStyle = ComboBoxStyle.DropDownList
        combo_status.DropDownStyle = ComboBoxStyle.DropDownList
        combo_location.DropDownStyle = ComboBoxStyle.DropDownList
        combo_category.DropDownStyle = ComboBoxStyle.DropDownList




    End Sub







    Public Sub Display_Data_on_Comboboxes_from_DatabaseTable()


        Dim query As String = "SELECT DISTINCT location FROM houseRegistration"

        Using cmd As New SqlCommand(query, conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()

                combo_location.Items.Clear()

                While reader.Read()

                    combo_location.Items.Add(reader("location").ToString())

                End While

                reader.Close()

            End Using

        End Using



        Dim query1 As String = "SELECT DISTINCT category FROM houseRegistration"
        Using cmd As New SqlCommand(query1, conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()

                combo_category.Items.Clear()

                While reader.Read()


                    combo_category.Items.Add(reader("category").ToString())

                End While

                reader.Close()

            End Using

        End Using


        Dim query2 As String = "SELECT DISTINCT status FROM houseRegistration"

        Using cmd As New SqlCommand(query2, conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()

                combo_status.Items.Clear()

                While reader.Read()

                    combo_status.Items.Add(reader("status").ToString())

                End While

                reader.Close()

            End Using

        End Using




        Dim query3 As String = " SELECT  DISTINCT tenantName
                                        FROM tenantRegistration
                                        WHERE id NOT  IN (
                                                        SELECT tenantID
                                                        FROM assignHouse
                                                         )"


        Using cmd As New SqlCommand(query3, conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()

                combo_tenantName.Items.Clear()
                txt_id.Text = String.Empty


                While reader.Read()

                    combo_tenantName.Items.Add(reader("tenantName").ToString())


                End While

                reader.Close()

            End Using

        End Using


    End Sub

    Private Sub combo_tenantName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_tenantName.SelectedIndexChanged

        StrCmd = ""
        StrCmd = "SELECT id FROM tenantRegistration WHERE tenantName = '" & combo_tenantName.Text & "'"
        Cmd = New SqlCommand(StrCmd, conn)

        Dim reader As SqlDataReader = Cmd.ExecuteReader()

        If reader.Read() Then
            txt_id.Text = reader("id").ToString()
        End If

        reader.Close()


    End Sub



    Private Sub Define_listviewHouses_Columns()

        With lvwHouses

            .Columns.Add(" ID", 50, HorizontalAlignment.Left)
            .Columns.Add(" House No.", 100, HorizontalAlignment.Left)
            .Columns.Add("Location", 200, HorizontalAlignment.Left)
            .Columns.Add("Category", 300, HorizontalAlignment.Left)
            .Columns.Add("Rent", 100, HorizontalAlignment.Left)
            .Columns.Add("Deposit", 100, HorizontalAlignment.Left)
            '.Columns.Add("Status", 100, HorizontalAlignment.Left)

            .CheckBoxes = True

            .View = View.Details

        End With

    End Sub

    Private Sub LoadDataTo_lvwHouses()

        StrCmd = ""
        StrCmd = "SELECT * FROM houseRegistration WHERE category = '" & combo_category.Text & "' AND location = '" & combo_location.Text & "' AND status ='" & combo_status.Text & "'"
        Cmd = New SqlCommand(StrCmd, conn)
        Dr = Cmd.ExecuteReader
        lvwHouses.Items.Clear()

        While Dr.Read
            Dim li As New ListViewItem(Dr.Item("id").ToString)

            With li

                .SubItems.Add(Dr.Item("houseNo").ToString)
                .SubItems.Add(Dr.Item("location").ToString)
                .SubItems.Add(Dr.Item("category").ToString)
                .SubItems.Add(Dr.Item("rent").ToString)
                .SubItems.Add(Dr.Item("deposit").ToString)
                '.SubItems.Add(Dr.Item("status").ToString)

                lvwHouses.Items.Add(li)

            End With

        End While

        Dr.Close()
        Cmd.Dispose()


    End Sub

    Private Sub Display_data()

    End Sub

    Private Sub Assign_House_To_Tenants()
        '


        'validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------
        If combo_location.Text.Trim = "" Then

            ErrorProvider1.SetError(combo_location, "Invalid Input")

            Exit Sub

        Else

            ErrorProvider1.SetError(combo_location, "")

        End If


        If combo_category.Text.Trim = "" Then

            ErrorProvider1.SetError(combo_category, "Invalid Input")

            Exit Sub

        Else

            ErrorProvider1.SetError(combo_category, "")

        End If

        If combo_status.Text.Trim = "" Then

            ErrorProvider1.SetError(combo_status, "Invalid Input")

            Exit Sub

        Else

            ErrorProvider1.SetError(combo_status, "")

        End If


        If combo_tenantName.Text.Trim = "" Then

            ErrorProvider1.SetError(combo_tenantName, "Invalid Input")

            Exit Sub

        Else

            ErrorProvider1.SetError(combo_tenantName, "")

        End If

        If txt_houseNo.Text.Trim = "" Then

            ErrorProvider1.SetError(txt_houseNo, "Invalid Input")

            Exit Sub

        Else

            ErrorProvider1.SetError(txt_houseNo, "")

        End If


        If txt_id.Text.Trim = "" Then

            ErrorProvider1.SetError(txt_id, "Invalid Input")
            Exit Sub

        Else

            ErrorProvider1.SetError(txt_id, "")

        End If

        If txt_rent.Text.Trim = "" Then

            ErrorProvider1.SetError(txt_rent, "Invalid Input")
            Exit Sub

        Else

            ErrorProvider1.SetError(txt_rent, "")

        End If

        If txtDeposit.Text.Trim = "" Then

            ErrorProvider1.SetError(txtDeposit, "Invalid Input")
            Exit Sub

        Else

            ErrorProvider1.SetError(txtDeposit, "")

        End If

        If txt_total.Text.Trim = "" Then

            ErrorProvider1.SetError(txt_total, "Invalid Input")
            Exit Sub

        Else

            ErrorProvider1.SetError(txt_total, "")

        End If

        If Not chkbox_bill.Checked Then

            ErrorProvider1.SetError(chkbox_bill, "Field must be checked")

            Exit Sub
        Else

            ErrorProvider1.SetError(chkbox_bill, "")

        End If


        ' End validation ------------------------------------------------------------------------
        '-----------------------------------------------------------------------------------

        Dim checkOccupiedQuery As String = "SELECT COUNT(*) FROM assignHouse WHERE houseNo = '" & txt_houseNo.Text.ToUpper.Trim & "' "

        Cmd = New SqlCommand(checkOccupiedQuery, conn)

        Try

            Dim result As Integer = Convert.ToInt32(Cmd.ExecuteScalar())


            If result > 0 Then

                MessageBox.Show("The selected house is already occupied and cannot be assigned to another tenant.", "Occupied House", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            Else
                If MessageBox.Show("Save Record?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                    txt_total.Text = (Decimal.Parse(txt_rent.Text) + Decimal.Parse(txtDeposit.Text))
                    Dim totalAmount As New Decimal
                    totalAmount = -1 * CDec(txt_total.Text)


                    '*----------------------insert into assignHouse table--------------------------------------------------
                    '*-------------------------------------------------------------------------------------------------
                    StrCmd = ""
                    StrCmd = "INSERT INTO assignHouse" &
                            "           (houseNo" &
                            "           ,tenantID)" &
                            "     VALUES" &
                            "           ('" & txt_houseNo.Text.ToUpper.Trim & "'" &
                            "           ," & txt_id.Text.ToUpper & ")"



                End If

                Cmd = New SqlCommand(StrCmd, conn)

                Try

                    Cmd.ExecuteNonQuery()

                Catch ex As Exception

                    MessageBox.Show(ex.Message)
                    Exit Sub

                End Try

                Cmd.Dispose()

                '*-------------------------------------------------------------------------------------------------
                '*-------------------------------------------------------------------------------------------------






                '*-----------------------Insert into charge log table------------------------------------------------------
                '*-----------------------------------------------------------------------------------------------------------


                txt_total.Text = (Decimal.Parse(txt_rent.Text) + Decimal.Parse(txtDeposit.Text))
                Dim totalAmount1 As New Decimal
                totalAmount1 = CDec(txt_total.Text)


                Dim transactionDesc As String = "Bill House Number :" + txt_houseNo.Text
                Dim transactionType As String = "BILL"


                If chkbox_bill.Checked Then
                    StrCmd = ""
                    StrCmd = "INSERT INTO chargeLog" &
                                        "           (houseNo" &
                                        "           ,tenantID" &
                                        "           ,description" &
                                        "           ,transactionType" &
                                        "           ,drAmount" &
                                        "           ,crAmount)" &
                                        "     VALUES" &
                                        "           ('" & txt_houseNo.Text.ToUpper & "'" &
                                        "           ,'" & txt_id.Text.ToUpper & "'" &
                                        "           ,'" & transactionDesc & "'" &
                                        "           ,'BILL'" &
                                        "           ," & totalAmount1 & "" &
                                        "           ," & 0 & ")"

                End If





                Cmd = New SqlCommand(StrCmd, conn)

                Try

                    Cmd.ExecuteNonQuery()

                Catch ex As Exception

                    MessageBox.Show(ex.Message)
                    Exit Sub

                End Try

                Cmd.Dispose()



                ''*--------------------------End-------------------------------------------------------------------------------
                ''*------------------------------------------------------------------------------------------------------------
                ''*******************************'


                ''*-----------------------Insert into Rent Updates table------------------------------------------------------
                ''*-----------------------------------------------------------------------------------------------------------




                If chkbox_bill.Checked Then

                    StrCmd = ""
                    StrCmd = "DELETE FROM rentUpdates WHERE houseNo = '" & txt_houseNo.Text & "'"

                    Cmd = New SqlCommand(StrCmd, conn)

                    Try

                        Cmd.ExecuteNonQuery()

                    Catch ex As Exception

                        MessageBox.Show(ex.Message)
                        Exit Sub

                    End Try

                    Cmd.Dispose()

                End If





                If chkbox_bill.Checked Then



                    '*-----------------------------------------------------------------------------------------------------------
                    StrCmd = ""
                    StrCmd = "INSERT INTO rentUpdates" &
                                "           (houseNo" &
                                "           ,tenantID" &
                                "           ,runningBalance )" &
                                "     VALUES" &
                                "           ('" & txt_houseNo.Text.ToUpper & "'" &
                                "           ,'" & txt_id.Text.ToUpper & "'" &
                                "           ," & totalAmount1 & ")"

                End If





                Cmd = New SqlCommand(StrCmd, conn)

                Try

                    Cmd.ExecuteNonQuery()

                Catch ex As Exception

                    MessageBox.Show(ex.Message)
                    Exit Sub

                End Try

                Cmd.Dispose()



                ''*--------------------------End-------------------------------------------------------------------------------
                ''*------------------------------------------------------------------------------------------------------------
                ''*******************************'




                ''*------------------------------------------------------------------------------------------------------
                ''*-------------------------UPDATE THE HOUSE IN THE HOUSE TABLE TO OCCUPIED------------------------------

                If MessageBox.Show("Update Record?", "Update", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then



                    StrCmd = ""
                    StrCmd = "UPDATE houseRegistration SET status = 'OCCUPIED' WHERE houseNo = '" & txt_houseNo.Text & "'"
                    Cmd = New SqlCommand(StrCmd, conn)

                    Try

                        Cmd.ExecuteNonQuery()

                    Catch ex As Exception

                        MessageBox.Show(ex.Message)
                        Exit Sub

                    End Try

                    Cmd.Dispose()

                    LoadDataTo_lvwHouses()



                End If

                ''*------------------------------------------------------------------------------------------------------
                ''*-------------------------UPDATE THE HOUSE IN THE HOUSE TABLE TO OCCUPIED------------------------------



                combo_location.Text = Nothing
                combo_category.Text = Nothing
                combo_status.Text = Nothing
                combo_tenantName.Text = Nothing
                txt_id.Text = ""
                txt_houseNo.Text = ""
                txt_rent.Text = ""
                txt_total.Text = ""
                txtDeposit.Text = ""

                combo_location.Focus()

                currentId = 0
                currentState = 0

                Beep()

                MessageBox.Show("Record Successfully Saved!", "Save", MessageBoxButtons.OK)

            End If
        Catch
        End Try




    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        LoadDataTo_lvwHouses()

    End Sub

    Private Sub btn_assignHouse_Click(sender As Object, e As EventArgs) Handles btn_assignHouse.Click
        Assign_House_To_Tenants()
        Display_Data_on_Comboboxes_from_DatabaseTable()




    End Sub



    Private Sub lvwHouses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwHouses.SelectedIndexChanged
        loadHouseKeyInfo()
    End Sub

    Private Sub loadHouseKeyInfo()

        Dim I As Integer = 0
        Dim Count As Integer = 0
        Dim K As Integer = 0
        Dim tAmount As Decimal


        For I = 0 To lvwHouses.Items.Count - 1

            If lvwHouses.Items(I).Selected = True Then

                currentId = CInt(lvwHouses.Items(I).SubItems(0).Text)
                txt_houseNo.Text = lvwHouses.Items(I).SubItems(1).Text
                txt_rent.Text = FormatNumber(CDec(lvwHouses.Items(I).SubItems(4).Text)).ToString
                txtDeposit.Text = FormatNumber(CDec(lvwHouses.Items(I).SubItems(5).Text)).ToString

                txt_total.Text = FormatNumber(CDec(lvwHouses.Items(I).SubItems(4).Text) _
                                                      + CDec(lvwHouses.Items(I).SubItems(5).Text)).ToString

            End If

        Next

    End Sub

    Private Sub lvwHouses_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lvwHouses.ItemSelectionChanged
        loadHouseKeyInfo()
    End Sub
End Class