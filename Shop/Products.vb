Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports MySql.Data.MySqlClient

Public Class Products
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



End Class