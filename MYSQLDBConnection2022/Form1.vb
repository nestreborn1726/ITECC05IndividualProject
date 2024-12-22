Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=accountdatabase"
        Try
            conn.Open()

            MessageBox.Show("Connection to MySQL test database was successful!!!!", "TESTING      CONNECTION TO MySQL DATABASE")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password='';database=accountdatabase"
        Dim READER As MySqlDataReader

        Try
            conn.Open()
            Dim Query As String
            Query = "select * from accountdatabase.account where username = '" & usernameTextBox.Text & "' 
                                                             and password = '" & passwordTextBox.Text & "' "

            COMMAND = New MySqlCommand(Query, conn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer

            count = 0

            While READER.Read
                count = count + 1

            End While

            If count = 1 Then
                MessageBox.Show("Username and password are correct")
                Me.Hide()

                usernameTextBox.Text = ""
                passwordTextBox.Text = ""

                Form2.Show()


            ElseIf count > 1 Then
                MessageBox.Show("Username and password are duplicate")
            Else
                MessageBox.Show("Username and password are not correct")

            End If

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub


End Class
