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
        Load_Data()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub


    Public Sub Load_Data()
        dgv_Orders.Rows.Clear()

        Dim query As String
        Dim mycommand As New MySqlCommand
        query = "SELECT o.id, c.name as customer_name, e.name as employee_name, p.name as product_name, ol.quantity FROM order_lines as ol INNER JOIN orders as o
 ON o.id = ol.order_id INNER JOIN customer as c
 ON c.id = o.customer_id INNER JOIN employee as e
 ON e.id = o.employee_id INNER JOIN products as p
 ON p.id = ol.product_id"
        Connect_to_DB()

        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = query
        End With

        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            dgv_Orders.Rows.Add(New Object() {myreader.Item("id"), myreader.Item("customer_name"), myreader.Item("employee_name"), myreader.Item("product_name"), myreader.Item("quantity")})
        End While

        Disconnect_to_DB()

        query = "SELECT * FROM categories"
        Connect_to_DB()

        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = query
        End With

        myreader = mycommand.ExecuteReader
        While myreader.Read()
            txt_ProdCat.Items.Add(myreader.Item("id"))
        End While


        Disconnect_to_DB()

        Disconnect_to_DB()

        query = "SELECT * FROM products"
        Connect_to_DB()

        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = query
        End With

        myreader = mycommand.ExecuteReader
        While myreader.Read()
            cb_Products.Items.Add(myreader.Item("id"))
        End While


        Disconnect_to_DB()



    End Sub

    Private Sub btn_AddProduct_Click(sender As Object, e As EventArgs) Handles btn_AddProduct.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand


            strSQL = "INSERT INTO order_lines (name, price, stock, category_id) VALUES ('" _
            & .txt_ProdCat.Text & "','" _
            & .cb_Products.Text & "','" _
            & .txt_OrdQuantity.Text & "','" _
            & ");"

            'MsgBox(strSQL)
            Try
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MsgBox("Product Successfully Added")

            Catch ex As MySqlException

                MsgBox(ex.Number & " " & ex.Message)
            End Try

            Call Disconnect_to_DB()
        End With
    End Sub
End Class
