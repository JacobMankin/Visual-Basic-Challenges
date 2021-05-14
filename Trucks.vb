Public Class Trucks
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim decSubTotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal

        decSubTotal = SubTotalCalculations()
        decTax = TaxCalculations()
        decTotal = TotalCalculations()

        MainForm.lblSubTotal.Text = decSubTotal.ToString("c")
        MainForm.lblTax.Text = decTax.ToString("c")
        MainForm.lblTotal.Text = decTotal.ToString("c")
    End Sub
End Class