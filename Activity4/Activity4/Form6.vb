Public Class Form6
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        tb1.Text = DateTimePicker1.Text

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tb1.TextChanged


    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.CustomFormat = "MMMM dd, yyyy hh:mm:ss:tt"
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        tb2.Text = DateTimePicker2.Text

    End Sub
End Class