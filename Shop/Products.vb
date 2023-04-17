Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports MySql.Data.MySqlClient


Public Class Products
    Dim file_name
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Active(sender As Object, e As EventArgs) Handles Button2.MouseMove
        With Button2
            .FlatAppearance.BorderSize = 1
            .ForeColor = Color.RoyalBlue
        End With
    End Sub
    Private Sub Button2_Inactive(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        With Button2
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.FromArgb(64, 64, 64)
        End With
    End Sub

    Private Sub btn_AddProduct_Click(sender As Object, e As EventArgs) Handles btn_AddProduct.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand


            strSQL = "INSERT INTO products (name, price, stock, category_id) VALUES ('" _
            & .txt_ProdName.Text & "','" _
            & .txt_ProdPrice.Text & "','" _
            & .txt_ProdStocks.Text & "','" _
            & .txt_ProdCat.Text & "'" _
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV Files|*.csv"
        openFileDialog1.Title = "Select a CSV File"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim file As String = openFileDialog1.FileName
            tbFileDir.Text = openFileDialog1.FileName.ToString
            file_name = openFileDialog1.FileName.ToString
            file_name = file_name.Replace("\", "/")



        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (file_name.Length()) Then
            With Me
                Call Connect_to_DB()
                Dim mycmd As New MySqlCommand
                Dim myreader As MySqlDataReader


                strSQL = "DELETE FROM products; LOAD DATA INFILE '" & file_name & "' INTO TABLE products
	FIELDS TERMINATED BY ',' lines terminated by '\r\n'
    ignore 1 lines;"

                'MsgBox(strSQL)
                mycmd.CommandText = strSQL
                mycmd.Connection = myconn

                mycmd.ExecuteNonQuery()
                MsgBox("Successfully imported!")
                Call Disconnect_to_DB()
            End With
        End If
    End Sub
    Public Sub Load_Data()
        dgv_Products.Rows.Clear()

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
            dgv_Products.Rows.Add(New Object() {myreader.Item("prod_name"), myreader.Item("price"), myreader.Item("stock"), myreader.Item("cat_name")})
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

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Load_Data()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "SELECT 'id', 'name', 'price', 'stock', 'category_id'
UNION ALL
SELECT id, `name`, price, stock, category_id
INTO OUTFILE 'C:/ProgramData/MySQL/MySQL Server 8.0/Uploads/products_export.csv'
	fields terminated by ',' lines terminated by '\r\n' from products;"

            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            mycmd.ExecuteNonQuery()
            MsgBox("Successfully exported!")
            Call Disconnect_to_DB()
        End With
    End Sub
End Class