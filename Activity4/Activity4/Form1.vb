Public Class Form1

    Private Sub CheckToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ButtonToolStripMenuItem.Click
        Dialog1.Show()

    End Sub

    Private Sub CheckBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckBoxToolStripMenuItem.Click
        Dialog2.Show()

    End Sub

    Private Sub RadioButtonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RadioButtonToolStripMenuItem.Click
        Dialog3.Show()

    End Sub

    Private Sub AdditionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdditionToolStripMenuItem.Click
        Form2.Show()

    End Sub

    Private Sub SubtractionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubtractionToolStripMenuItem.Click
        Form3.Show()

    End Sub

    Private Sub MultiplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplicationToolStripMenuItem.Click
        Form4.Show()


    End Sub

    Private Sub DivisionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivisionToolStripMenuItem.Click
        Form5.Show()

    End Sub

    Private Sub MeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeToolStripMenuItem.Click
        AboutBox1.Show()

    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()


    End Sub

    Private Sub DateTimePickerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateTimePickerToolStripMenuItem.Click
        Form6.Show()

    End Sub
End Class
