Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Orders.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Products.Show()
    End Sub
    Private Sub Button1_Active(sender As Object, e As EventArgs) Handles Button1.MouseMove
        With Button1
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.White
        End With
    End Sub
    Private Sub Button1_Inactive(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        With Button1
            .BackColor = Color.Transparent
            .FlatAppearance.BorderSize = 1
            .ForeColor = Color.FromArgb(64, 64, 64)
        End With
    End Sub

    Private Sub Button2_Active(sender As Object, e As EventArgs) Handles Button2.MouseMove
        With Button2
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.White
        End With
    End Sub
    Private Sub Button2_Inactive(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        With Button2
            .BackColor = Color.Transparent
            .FlatAppearance.BorderSize = 1
            .ForeColor = Color.FromArgb(64, 64, 64)
        End With
    End Sub

    Private Sub Button3_Active(sender As Object, e As EventArgs) Handles Button3.MouseMove
        With Button3
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.White
        End With
    End Sub
    Private Sub Button3_Inactive(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        With Button3
            .BackColor = Color.Transparent
            .FlatAppearance.BorderSize = 1
            .ForeColor = Color.FromArgb(64, 64, 64)
        End With
    End Sub

    Private Sub Button4_Active(sender As Object, e As EventArgs) Handles Button4.MouseMove
        With Button4
            .FlatAppearance.BorderSize = 0
            .ForeColor = Color.White
        End With
    End Sub
    Private Sub Button4_Inactive(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        With Button4
            .BackColor = Color.Transparent
            .FlatAppearance.BorderSize = 1
            .ForeColor = Color.FromArgb(64, 64, 64)
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Categories.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Employee.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Customervb.Show()
    End Sub
End Class
