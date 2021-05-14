Module Calculations
    Public Const MODEL_101 As Decimal = 29.95D
    Public Const MODEL_600 As Decimal = 49.95D
    Public Const MODEL_T_1000 As Decimal = 99.95D
    Public Const TAX_PERCENTAGE As Decimal = 0.06D
    Public Const dec_800_MINUTES As Decimal = 45D
    Public Const dec_1500_MINUTES As Decimal = 65D
    Public Const UNLIMITED_MINUTES As Decimal = 99D
    Public Const EMAIL_OPTION As Decimal = 25D
    Public Const TEXT_OPTION As Decimal = 10D

    Function PhoneSub(ByVal intPhones As Integer) As Decimal
        Dim decTotal As Decimal

        If FamilyPlan.radModel101.Checked = True Then
            decTotal = MODEL_101
        ElseIf FamilyPlan.radModel600.Checked = True Then
            decTotal = MODEL_600
        ElseIf FamilyPlan.radModelT1000.Checked = True Then
            decTotal = MODEL_T_1000
        End If

        decTotal = decTotal * intPhones

        Return decTotal
    End Function

    Function PhoneSubSolo() As Decimal
        Dim decTotal As Decimal

        If IndividualPlan.radModel101.Checked = True Then
            decTotal = MODEL_101
        ElseIf IndividualPlan.radModel600.Checked = True Then
            decTotal = MODEL_600
        ElseIf IndividualPlan.radModelT1000.Checked = True Then
            decTotal = MODEL_T_1000
        End If

        Return decTotal
    End Function

    Function CalcFamilyTax() As Decimal
        Dim decTotal As Decimal
        Dim decPhoneSub As Decimal

        Dim intPhones As Integer

        intPhones = CInt(FamilyPlan.txtPhones.Text)

        decPhoneSub = PhoneSub(intPhones)

        decTotal = decPhoneSub * TAX_PERCENTAGE

        Return decTotal
    End Function

    Function CalcSoloTax() As Decimal
        Dim decTotal As Decimal
        Dim decPhoneSub As Decimal

        decPhoneSub = PhoneSubSolo()

        decTotal = decPhoneSub * TAX_PERCENTAGE

        Return decTotal
    End Function

    Function CalcPhoneTotalFamily() As Decimal
        Dim decTotal As Decimal
        Dim decTax As Decimal
        Dim decSub As Decimal

        Dim intPhones As Integer

        intPhones = CInt(FamilyPlan.txtPhones.Text)

        decSub = PhoneSub(intPhones)
        decTax = CalcFamilyTax()
        decTotal = decSub + decTax

        Return decTotal

    End Function

    Function CalcPhoneTotalSolo() As Decimal
        Dim decTotal As Decimal
        Dim decTax As Decimal
        Dim decSub As Decimal

        decSub = PhoneSubSolo()
        decTax = CalcSoloTax()
        decTotal = decSub + decTax

        Return decTotal
    End Function

    Function CalcFamilyOptions() As Decimal
        Dim decTotal As Decimal

        If FamilyPlan.chkEmail.Checked = True Then
            decTotal += EMAIL_OPTION
        End If

        If FamilyPlan.chkText.Checked = True Then
            decTotal += TEXT_OPTION
        End If

        Return decTotal
    End Function

    Function CalcSoloOptions() As Decimal
        Dim decTotal As Decimal

        If IndividualPlan.chkEmail.Checked = True Then
            decTotal += EMAIL_OPTION
        End If

        If IndividualPlan.chkText.Checked = True Then
            decTotal += TEXT_OPTION
        End If

        Return decTotal
    End Function

    Function CalcFamilyPackage() As Decimal
        Dim decTotal As Decimal

        If FamilyPlan.rad800min.Checked = True Then
            decTotal = dec_800_MINUTES
        ElseIf FamilyPlan.rad1500min.Checked = True Then
            decTotal = dec_1500_MINUTES
        ElseIf FamilyPlan.radUnlimited.Checked = True Then
            decTotal = UNLIMITED_MINUTES
        End If

        Return decTotal
    End Function

    Function CalcSoloPackage() As Decimal
        Dim decTotal As Decimal

        If IndividualPlan.rad800min.Checked = True Then
            decTotal = dec_800_MINUTES
        ElseIf IndividualPlan.rad1500min.Checked = True Then
            decTotal = dec_1500_MINUTES
        ElseIf IndividualPlan.radUnlimited.Checked = True Then
            decTotal = UNLIMITED_MINUTES
        End If

        Return decTotal
    End Function

    Function CalcFamilyMonthly() As Decimal
        Dim decTotal As Decimal
        Dim decOptions As Decimal
        Dim decPackage As Decimal

        decOptions = CalcFamilyOptions()
        decPackage = CalcFamilyPackage()

        decTotal = decOptions + decPackage

        Return decTotal
    End Function

    Function CalcSoloMonthly() As Decimal
        Dim decTotal As Decimal
        Dim decOptions As Decimal
        Dim decPackage As Decimal

        decOptions = CalcSoloOptions()
        decPackage = CalcSoloPackage()

        decTotal = decOptions + decPackage

        Return decTotal
    End Function

    'add pr in front of the number in webex

    'On family plan be sure to multiply intPhones by the PhoneSub()

End Module
