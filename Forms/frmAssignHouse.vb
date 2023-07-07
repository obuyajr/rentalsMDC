Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmAssignHouse

    Dim Dr As SqlDataReader

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


        Dim query As String = "SELECT DISTINCT location FROM houses"

        Using cmd As New SqlCommand(query, conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()

                combo_location.Items.Clear()

                While reader.Read()

                    combo_location.Items.Add(reader("location").ToString())

                End While

                reader.Close()

            End Using

        End Using



        Dim query1 As String = "SELECT DISTINCT category FROM houses"
        Using cmd As New SqlCommand(query1, conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()

                combo_category.Items.Clear()

                While reader.Read()


                    combo_category.Items.Add(reader("category").ToString())

                End While

                reader.Close()

            End Using

        End Using


        Dim query2 As String = "SELECT DISTINCT status FROM houses"

        Using cmd As New SqlCommand(query2, conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()

                combo_status.Items.Clear()

                While reader.Read()

                    combo_status.Items.Add(reader("status").ToString())

                End While

                reader.Close()

            End Using

        End Using


        Dim query3 As String = "SELECT DISTINCT name FROM tenants"

        Using cmd As New SqlCommand(query3, conn)

            Using reader As SqlDataReader = cmd.ExecuteReader()

                combo_tenantName.Items.Clear()
                txt_id.Text = String.Empty


                While reader.Read()

                    combo_tenantName.Items.Add(reader("name").ToString())


                End While

                reader.Close()

            End Using

        End Using


    End Sub

    Private Sub combo_tenantName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_tenantName.SelectedIndexChanged


        Dim query As String = "SELECT id FROM tenants WHERE name = '" & combo_tenantName.Text & "'"
        Cmd = New SqlCommand(query, conn)
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
        StrCmd = "SELECT * FROM houses WHERE category = '" & combo_category.Text & "' AND location = '" & combo_location.Text & "' AND status ='" & combo_status.Text & "'"
        Cmd = New SqlCommand(StrCmd, conn)
        Dr = Cmd.ExecuteReader
        lvwHouses.Items.Clear()

        While Dr.Read
            Dim li As New ListViewItem(Dr.Item("id").ToString)

            With li

                .SubItems.Add(Dr.Item("house_no").ToString)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoadDataTo_lvwHouses()

    End Sub
End Class