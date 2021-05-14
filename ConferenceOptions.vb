Public Class ConferenceOptions

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        chkDinner.Checked = False
        chkRegistration.Checked = False
        lstWorkshops.SelectedIndex = -1
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click

        Dim decTotal As Decimal
        Dim decWorkshop As Decimal
        Dim decDinner As Decimal
        Dim decBase As Decimal

        If lstWorkshops.SelectedIndex = 0 Then
            decWorkshop = 295
        End If
        If lstWorkshops.SelectedIndex = 1 Then
            decWorkshop = 295
        End If
        If lstWorkshops.SelectedIndex = 2 Then
            decWorkshop = 395
        End If
        If lstWorkshops.SelectedIndex = 3 Then
            decWorkshop = 395
        End If

        If chkDinner.Checked = True Then
            decDinner = 30
        End If

        decBase = 895D

        decTotal = decDinner + decWorkshop + decBase


        If chkRegistration.Checked = True Then
            MainForm.lblTotal.Text = decTotal.ToString("c")
        Else MessageBox.Show("Must select conference registration for additional options.")
        End If

        Me.Close()
    End Sub
End Class