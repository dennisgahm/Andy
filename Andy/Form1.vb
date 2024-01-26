Imports System.Net.Mail
Imports System.Security.Cryptography

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Access to CIA database granted."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label3.Visible = True
        DataGridView1.Rows.Insert(0, "Hello", "iloveyou", "5302")
        DataGridView1.Rows.Insert(0, "Agent 007", "double07", "239847")

        DataGridView2.Rows.Insert(0, "Y9a8F7s34s", "Bob Jones", "Thousand Oaks, CA, USA")
        DataGridView2.Rows.Insert(0, "0101110", "Debby Jim", "Barrigada, Guam")
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True

        TextBox4.Visible = True
        TextBox5.Visible = True

        Button4.Visible = True
        Button5.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView4.Rows.Insert(0, "Hello", "iloveyou", "5302")
        DataGridView4.Rows.Insert(0, "Agent 007", "double07", "239847")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        DataGridView3.Rows.Insert(0, "Y9a8F7s34s", "Bob Jones", "Thousand Oaks, CA, USA")
        DataGridView3.Rows.Insert(0, "0101110", "Debby Jim", "Barrigada, Guam")
    End Sub
End Class
