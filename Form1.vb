Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Declare Variables
        Dim dblAdultGross As Double
        Dim dblChildGross As Double
        Dim dblGross As Double
        Dim dblAdultNet As Double
        Dim dblChildNet As Double
        Dim dblNet As Double

        Try
            'Calculate Sales
            dblAdultGross = CDbl(txtAdultPrice.Text) * CDbl(txtAdultSold.Text)
            dblChildGross = CDec(txtChildPrice.Text) * CDec(txtChildSold.Text)
            dblGross = dblAdultGross + dblChildGross
            dblAdultNet = dblAdultGross * 0.2
            dblChildNet = dblChildGross * 0.2
            dblNet = dblAdultNet + dblChildNet

            'Display Sales Totals
            lblAdultGross.Text = dblAdultGross.ToString("c")
            lblAdultNet.Text = dblAdultNet.ToString("c")
            lblChildGross.Text = dblChildGross.ToString("c")
            lblChildNet.Text = dblChildNet.ToString("c")
            lblGross.Text = dblGross.ToString("c")
            lblNet.Text = dblNet.ToString("c")
        Catch
            'Display an error message.
            MessageBox.Show("Error: Please enter numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all textboxes and labels.
        txtAdultPrice.Clear()
        txtAdultSold.Clear()
        txtChildPrice.Clear()
        txtChildSold.Clear()
        lblAdultGross.Text = String.Empty
        lblAdultNet.Text = String.Empty
        lblChildGross.Text = String.Empty
        lblChildNet.Text = String.Empty
        lblGross.Text = String.Empty
        lblNet.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close the current form.
        Me.Close()
    End Sub
End Class
