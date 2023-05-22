Imports MySql.Data.MySqlClient

Public Class Categories
    Public Sub Load_Data()
        dgv_Products.Rows.Clear()

        Dim query As String
        Dim mycommand As New MySqlCommand
        query = "SELECT c.name, (SELECT COUNT(p.id) as products_count from products as p INNER JOIN categories as c2 ON p.category_id = c2.id WHERE c2.id = c.id) as products_count, (SELECT SUM(p3.price) as total_amount from products as p3 INNER JOIN categories as c3 ON p3.category_id = c.id where c3.id = 1) as total_amount from categories as c;"
        Connect_to_DB()

        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = query
        End With

        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            dgv_Products.Rows.Add(New Object() {myreader.Item("name"), myreader.Item("products_count"), myreader.Item("total_amount")})
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

    Private Sub btn_AddProduct_Click(sender As Object, e As EventArgs) Handles btn_AddProduct.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand


            strSQL = "INSERT INTO categories (name) VALUES ('" _
            & .txt_CatName.Text & "');"


            Try
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Categories Successfully Added")

            Catch ex As MySqlException

                MsgBox(ex.Number & " " & ex.Message)
            End Try

            Call Disconnect_to_DB()
        End With
    End Sub
End Class