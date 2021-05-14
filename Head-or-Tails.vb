Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'close current form
        Me.Close()
    End Sub

    Private Sub btnHead_Click(sender As Object, e As EventArgs) Handles btnHead.Click
        'Show picture of heads
        picHead.Visible = True
        picTail.Visible = False
        lblTitle.Visible = False
    End Sub

    Private Sub btnTail_Click(sender As Object, e As EventArgs) Handles btnTail.Click
        'show picture of Tails
        picTail.Visible = True
        picHead.Visible = False
        lblTitle.Visible = False
    End Sub
End Class
