Imports MySql.Data.MySqlClient

Public Class Employee

    Public Sub Load_Data()
        dgv_Products.Rows.Clear()

        Dim query As String
        Dim mycommand As New MySqlCommand
        query = "SELECT * FROM employee"
        Connect_to_DB()

        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = query
        End With

        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            dgv_Products.Rows.Add(New Object() {myreader.Item("id"), myreader.Item("name")})
        End While

        Disconnect_to_DB()




    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Load_Data()
    End Sub

    Private Sub btn_AddEmployee_Click(sender As Object, e As EventArgs) Handles btn_AddEmployee.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand


            strSQL = "INSERT INTO employee (name) VALUES ('" _
            & .txt_EmployeeName.Text & "');"


            Try
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Employee Successfully Added")

            Catch ex As MySqlException

                MsgBox(ex.Number & " " & ex.Message)
            End Try

            Call Disconnect_to_DB()
        End With
    End Sub
End Class