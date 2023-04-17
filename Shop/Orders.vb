Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Orders

    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        With Me
            .Hide()
            Form1.Show()

        End With
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub


    Public Sub Load_Data()
        dgv_Orders.Rows.Clear()

        Dim query As String
        Dim mycommand As New MySqlCommand
        query = "SELECT p.name as prod_name,price, stock, c.name as cat_name FROM products as p INNER JOIN categories as c ON p.category_id = c.id"
        Connect_to_DB()

        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = query
        End With

        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            dgv_Orders.Rows.Add(New Object() {myreader.Item("prod_name"), myreader.Item("price"), myreader.Item("stock"), myreader.Item("cat_name")})
        End While

        Disconnect_to_DB()



    End Sub

End Class
