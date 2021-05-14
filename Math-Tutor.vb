Public Class MathTutor
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close the current form
        Me.Close()
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        lblAnswer.Text = "51"
    End Sub
End Class
