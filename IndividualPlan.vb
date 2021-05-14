Public Class IndividualPlan
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim intPhones As Integer
        Dim decPhoneSub As Decimal
        Dim decTax As Decimal
        Dim decPhoneTotal As Decimal
        Dim decOptions As Decimal
        Dim decPackage As Decimal
        Dim decMonthlty As Decimal

        decPhoneSub = PhoneSubSolo()
        decTax = CalcSoloTax()
        decPhoneTotal = CalcPhoneTotalSolo()
        decOptions = CalcSoloOptions()
        decPackage = CalcSoloPackage()
        decMonthlty = CalcSoloMonthly()

        lblPhoneSub.Text = decPhoneSub.ToString("c")
        lblTax.Text = decTax.ToString("c")
        lblPhoneTotal.Text = decPhoneTotal.ToString("c")
        lblOptions.Text = decOptions.ToString("c")
        lblPackageCharge.Text = decPackage.ToString("c")
        lblMonthlyCharge.Text = decMonthlty.ToString("c")

    End Sub
End Class