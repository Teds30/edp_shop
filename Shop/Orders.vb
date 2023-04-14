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
End Class