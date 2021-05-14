Public Class AudioBooks
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        MainForm.lstShoppingCart.Items.Add(lstAudioBooks.SelectedItem)

        MainForm.lblSub.Text = SubTotal().ToString("c")
        MainForm.lblTax.Text = Tax().ToString("c")
        MainForm.lblShipping.Text = Shipping().ToString("c")
        MainForm.lblTotal.Text = GrandTotal().ToString("c")

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class