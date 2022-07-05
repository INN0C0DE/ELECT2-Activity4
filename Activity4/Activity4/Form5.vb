Public Class Form5
    Dim n1, n2, quo As Double

    Private Sub tb1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged
        n1 = tb1.Text

    End Sub

    Private Sub tb2_TextChanged(sender As Object, e As EventArgs) Handles tb2.TextChanged
        n2 = tb2.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        quo = n1 / n2
        tb3.Text = quo

    End Sub
End Class