Public Class CardIdentifier
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pic9.Click
        'display card in label
        lblAnswer.Text = "Nine of Clubs"
    End Sub

    Private Sub lblAnswer_Click(sender As Object, e As EventArgs) Handles lblAnswer.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close current form
        Me.Close()
    End Sub

    Private Sub picA_Click(sender As Object, e As EventArgs) Handles picA.Click
        'display card in label
        lblAnswer.Text = "Ace of Spades"
    End Sub

    Private Sub pic3_Click(sender As Object, e As EventArgs) Handles pic3.Click
        'display card in label
        lblAnswer.Text = "Three of Hearts"
    End Sub

    Private Sub picK_Click(sender As Object, e As EventArgs) Handles picK.Click
        'display card in label
        lblAnswer.Text = "King of Hearts"
    End Sub

    Private Sub picJ_Click(sender As Object, e As EventArgs) Handles picJ.Click
        'display card in label
        lblAnswer.Text = "Jack of Diamonds"
    End Sub
End Class
