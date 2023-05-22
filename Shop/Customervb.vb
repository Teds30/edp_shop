Imports MySql.Data.MySqlClient

Public Class Customervb

    Public Sub Load_Data()
        dgv_Products.Rows.Clear()

        Dim query As String
        Dim mycommand As New MySqlCommand
        query = "SELECT c.id, c.name, totalord.orders FROM customer as c left JOIN customertotalorders as totalord ON c.id = totalord.id;"
        Connect_to_DB()

        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = query
        End With

        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            dgv_Products.Rows.Add(New Object() {myreader.Item("id"), myreader.Item("name"), myreader.Item("orders")})
        End While

        Disconnect_to_DB()




    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Load_Data()
    End Sub

    Private Sub btn_AddCustomer_Click(sender As Object, e As EventArgs) Handles btn_AddCustomer.Click

        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand


            strSQL = "INSERT INTO customer (name) VALUES ('" _
            & .txt_CustomerName.Text & "');"


            Try
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Customer Successfully Added")

            Catch ex As MySqlException

                MsgBox(ex.Number & " " & ex.Message)
            End Try

            Call Disconnect_to_DB()
        End With
    End Sub
End Class