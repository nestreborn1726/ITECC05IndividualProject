Imports MySql.Data.MySqlClient

Public Class Form2
    Dim gender As String
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dr As MySqlDataReader
    Dim EmployeeID As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DBV_load()
        DataGridView1.ClearSelection()
    End Sub

    'Logout Button'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=accountdatabase"
        Dim READER As MySqlDataReader

        Try
            conn.Open()
            Dim Query As String
            Query = "INSERT INTO accountdatabase.employee (employeeID,name,surname,age,sex,birthdate,address,phone,email) 
                    Values ('" & TextBox_eid.Text & "' ,
                            '" & TextBox_name.Text & "' ,
                            '" & TextBox_surname.Text & "' ,
                            '" & TextBox_age.Text & "' ,
                            '" & gender & "',
                            '" & dtp_dob.Text & "',
                            '" & TextBox_address.Text & "',
                            '" & TextBox_phone.Text & "',
                            '" & TextBox_email.Text & "' )"

            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Saved")
            conn.Close()

            DBV_load()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub radbtn_male_CheckedChanged(sender As Object, e As EventArgs) Handles radbtn_male.CheckedChanged
        gender = "male"
    End Sub

    Private Sub radbtn_female_CheckedChanged(sender As Object, e As EventArgs) Handles radbtn_female.CheckedChanged
        gender = "female"
    End Sub

    Public Sub DBV_load()
        DataGridView1.Rows.Clear()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=accountdatabase"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM accountdatabase.employee", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("employeeID"),
                                       dr.Item("name"),
                                       dr.Item("surname"),
                                       dr.Item("age"),
                                       dr.Item("sex"),
                                       dr.Item("hireDate"),
                                       dr.Item("birthDate"),
                                       dr.Item("address"),
                                       dr.Item("phone"),
                                       dr.Item("email"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        TextBox_eid.Text = DataGridView1.CurrentRow.Cells(0).Value
        TextBox_name.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox_surname.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox_age.Text = DataGridView1.CurrentRow.Cells(3).Value
        gender = DataGridView1.CurrentRow.Cells(4).Value
        If gender = "male" Then
            radbtn_male.Checked = True
        ElseIf gender = "female" Then
            radbtn_female.Checked = True
        End If

        dtp_dob.Text = DataGridView1.CurrentRow.Cells(6).Value
        TextBox_address.Text = DataGridView1.CurrentRow.Cells(7).Value
        TextBox_phone.Text = DataGridView1.CurrentRow.Cells(8).Value
        TextBox_email.Text = DataGridView1.CurrentRow.Cells(9).Value

        TextBox_eid.ReadOnly = True
        btnSave.Enabled = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
        btnSave.Enabled = True
        TextBox_eid.ReadOnly = False
        DataGridView1.ClearSelection()
    End Sub

    Public Sub clear()
        TextBox_eid.Clear()
        TextBox_name.Clear()
        TextBox_surname.Clear()
        TextBox_age.Clear()
        radbtn_male.Checked = False
        radbtn_female.Checked = False
        dtp_dob.Value = Now
        TextBox_address.Clear()
        TextBox_phone.Clear()
        TextBox_email.Clear()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=accountdatabase"
        Dim READER As MySqlDataReader

        Try
            conn.Open()
            ' Update Query based on employeeID (which is assumed to be the primary key)'
            Dim Query As String
            Query = "UPDATE accountdatabase.employee SET 
                 name = @name, 
                 surname = @surname, 
                 age = @age, 
                 sex = @sex, 
                 birthdate = @birthdate, 
                 address = @address, 
                 phone = @phone, 
                 email = @email
                 WHERE employeeID = @employeeID"

            COMMAND = New MySqlCommand(Query, conn)
            COMMAND.Parameters.AddWithValue("@employeeID", TextBox_eid.Text)
            COMMAND.Parameters.AddWithValue("@name", TextBox_name.Text)
            COMMAND.Parameters.AddWithValue("@surname", TextBox_surname.Text)
            COMMAND.Parameters.AddWithValue("@age", TextBox_age.Text)
            COMMAND.Parameters.AddWithValue("@sex", gender)
            COMMAND.Parameters.AddWithValue("@birthdate", dtp_dob.Value.ToString("yyyy-MM-dd"))
            COMMAND.Parameters.AddWithValue("@address", TextBox_address.Text)
            COMMAND.Parameters.AddWithValue("@phone", TextBox_phone.Text)
            COMMAND.Parameters.AddWithValue("@email", TextBox_email.Text)


            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Updated Successfully")
            conn.Close()
            DBV_load()
            TextBox_eid.ReadOnly = False
            btnSave.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try

        clear()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        DBV_load()
        DataGridView1.ClearSelection()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MsgBox("Are you sure?", MsgBoxStyle.Question + vbYesNo) = vbYes Then
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost;userid=root;password='';database=accountdatabase"
            Dim READER As MySqlDataReader

            Try
                conn.Open()

                Dim Query As String
                Query = "DELETE FROM accountdatabase.employee WHERE employeeID = @employeeID"


                COMMAND = New MySqlCommand(Query, conn)
                COMMAND.Parameters.AddWithValue("@employeeID", TextBox_eid.Text)


                READER = COMMAND.ExecuteReader
                MessageBox.Show("Data Deleted Successfully")
                conn.Close()


                DBV_load()
                btnSave.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message)
                conn.Close()
            End Try

            clear()
        Else
            Return
        End If
    End Sub

    Private Sub TextBox_search_TextChanged(sender As Object, e As EventArgs) Handles TextBox_search.TextChanged
        DataGridView1.Rows.Clear()
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=accountdatabase"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT * FROM accountdatabase.employee 
                                        WHERE employeeID like '%" & TextBox_search.Text & "%' OR
                                              name like '%" & TextBox_search.Text & "%' OR
                                              surname like '%" & TextBox_search.Text & "%' OR
                                              name like '%" & TextBox_search.Text & "%'
                                              ", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("employeeID"),
                                       dr.Item("name"),
                                       dr.Item("surname"),
                                       dr.Item("age"),
                                       dr.Item("sex"),
                                       dr.Item("hireDate"),
                                       dr.Item("birthDate"),
                                       dr.Item("address"),
                                       dr.Item("phone"),
                                       dr.Item("email"))
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnChart_Click(sender As Object, e As EventArgs) Handles btnChart.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=accountdatabase"

        Dim READER As MySqlDataReader
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM accountdatabase.employee"
            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Chart1.Series("NAME_VS_AGE").Points.AddXY(READER.GetString("name"), READER.GetInt32("age"))
            End While
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub
End Class