Public Class MainForm
    Const dec_BASE_CHARGE As Decimal = 2000D
    Const dec_EXPRESS_INSTALL As Decimal = 0.05D

    Dim strFirstName, strLastName, strPhone As String
    Dim intPanels, intAdditionalPanels As Integer
    Dim decDeposit, decBalanceDue, decTotal, decAdditionalCost As Decimal

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Solar Panel Installtion Charges created by Jacob Mankin version 1.0")
    End Sub

    Private Sub mnuFileClear_Click(sender As Object, e As EventArgs) Handles mnuFileClear.Click
        ClearAll()
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub btnErrors_Click(sender As Object, e As EventArgs) Handles btnErrors.Click


        If ValidateInputs(strFirstName, strLastName, strPhone, intPanels, decDeposit) Then
            lblErrors.ForeColor = Color.Green
            lblErrors.Text = "All values passed! Good to move on."
        Else
            lblErrors.ForeColor = Color.Red
            lblErrors.Text = "Something went wrong. Try again!"
        End If
    End Sub

    Private Sub mnuInstallationCharges_Click(sender As Object, e As EventArgs) Handles mnuInstallationCharges.Click
        intPanels = CInt(txtNumberPanels.Text)
        decDeposit = CDec(txtDepositAmount.Text)
        decTotal = 0
        decBalanceDue = 0
        decAdditionalCost = 0
        intAdditionalPanels = 0


        If ValidateInputs(strFirstName, strLastName, strPhone, intPanels, decDeposit) Then
            grpCharges.Visible = True
            CalculateValues(intPanels, decDeposit, decBalanceDue, decTotal, decAdditionalCost, intAdditionalPanels)
        End If
    End Sub

    Private Sub btnReCalc_Click(sender As Object, e As EventArgs) Handles btnReCalc.Click
        intPanels = CInt(txtNumberPanels.Text)
        decDeposit = CDec(txtDepositAmount.Text)
        decTotal = 0
        decBalanceDue = 0
        decAdditionalCost = 0
        intAdditionalPanels = 0

        If ValidateInputs(strFirstName, strLastName, strPhone, intPanels, decDeposit) Then
            CalculateValues(intPanels, decDeposit, decBalanceDue, decTotal, decAdditionalCost, intAdditionalPanels)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAll()
    End Sub

    Private Sub mnuInstallationOptions_Click(sender As Object, e As EventArgs) Handles mnuInstallationOptions.Click
        'Assign first, last name, and tele number
        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        strPhone = txtPhone.Text

        If ValidateCustInfo(strFirstName, strLastName, strPhone) Then
            grpOptions.Visible = True
            mnuInstallationCharges.Enabled = True
        End If
    End Sub

    Function ValidateInputs(ByRef strFirstName As String, ByRef strLastName As String, ByRef strPhone As String, ByRef intPanels As Integer, ByRef decDeposit As Decimal) As Boolean

        'Validate inputs accepts 5 arguments
        'Validates and assigns the values to variables
        'Returns false if any values fails, returns true if all values pass

        If ValidateCustInfo(strFirstName, strLastName, strPhone) Then
            'Validate the number of panels
            If Not Integer.TryParse(txtNumberPanels.Text, intPanels) Or intPanels < 2 Then
                lblControl.Text = "Please enter a valid number of panels, minimum 2."
                Return False
            End If
            'Validate value is greater than 0
            If Not Decimal.TryParse(txtDepositAmount.Text, decDeposit) Or decDeposit < 1 Then
                lblControl.Text = "Please enter a valid deposit amount."
                Return False
            End If

            lblControl.Text = String.Empty
            'All values pass
            Return True
        End If

    End Function

    Function ValidateCustInfo(strFirstName As String, strLastName As String, strPhone As String) As Boolean

        'Validate First Name
        If strFirstName.Length < 1 Then
            lblControl.Text = "Please enter a valid first name."
            txtFirstName.Focus()
            Return False
        End If

        'Validate Last Name
        If strLastName.Length < 1 Then
            lblControl.Text = "Please enter a valid last name."
            txtLastName.Focus()
            Return False
        End If

        'Validate Phone Number
        If strPhone.Length < 10 Or Not IsNumeric(strPhone) Then
            lblControl.Text = "Please enter a valid phone number."
            txtPhone.Focus()
            Return False
        End If


        'Clear past error messages
        lblControl.Text = String.Empty


        'all values pass
        lblControl.Text = String.Empty
        Return True

    End Function

    Sub CalculateValues(intPanels As Integer, decDeposit As Decimal, ByRef decBalanceDue As Decimal, ByRef decTotal As Decimal, ByRef decAdditionalCost As Decimal, ByRef intAdditionalPanels As Integer)
        'CalulateValues recieves 6 arguments
        'it calcs and outputs all values

        intAdditionalPanels = intPanels - 2
        decAdditionalCost = intAdditionalPanels * 300
        decTotal = decAdditionalCost + dec_BASE_CHARGE

        'Check for express install
        If chkExpress.Checked = True Then
            decTotal = decTotal + decTotal * dec_EXPRESS_INSTALL
        End If

        decBalanceDue = decTotal - decDeposit

        If decDeposit > decTotal Then
            lblBalanceDue.Text = "Refund:"
        End If

        If decDeposit < decTotal Then
            lblBalanceDue.Text = "Balance Due:"
        End If

        'Output all values and calculations
        lblBaseCharge.Text = dec_BASE_CHARGE.ToString("c")
        lblAdditionalPanels.Text = decAdditionalCost.ToString("c")
        lblTotal.Text = decTotal.ToString("c")
        lblDeposit.Text = decDeposit.ToString("c")
        lblDue.Text = decBalanceDue.ToString("c")

    End Sub

    Sub ClearAll()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhone.Clear()
        txtNumberPanels.Clear()
        txtDepositAmount.Clear()
        lblAdditionalPanels.Text = String.Empty
        lblBalanceDue.Text = String.Empty
        lblBaseCharge.Text = String.Empty
        lblControl.Text = String.Empty
        lblDeposit.Text = String.Empty
        lblDue.Text = String.Empty
        lblTotal.Text = String.Empty
        grpCharges.Visible = False
        grpOptions.Visible = False
        mnuInstallationCharges.Enabled = False
        txtFirstName.Focus()

    End Sub

End Class
