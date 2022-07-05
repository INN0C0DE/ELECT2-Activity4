Public Class Form3
    Dim n1, n2, diff As Double

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        n1 = tb1.Text

    End Sub

    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged
        n2 = tb2.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        diff = n1 - n2
        tb3.Text = diff

    End Sub

    Private Sub tb3_TextChanged(sender As Object, e As EventArgs) Handles tb3.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class