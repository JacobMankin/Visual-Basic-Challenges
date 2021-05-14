Module Module1
    'Use module for calculations
    'Declare public variables and constants
    Public Const YOUR_WAY_PRINT_PRICE = 11.95
    Public Const HISTORY_SCOTLAND_PRICE = 14.5
    Public Const LEARN_CALC_PRICE = 29.95
    Public Const FEEL_STRESS_PRICE = 18.5
    Public Const SCIENCE_BODY_PRICE = 12.95
    Public Const RELAXATION_PRICE = 11.5

    'Function PrintIndex0() As Double
    'Dim dblTotal As Double
    'If PrintBooks.lstPrintBooks.SelectedIndex = 0 Then
    '  dblTotal += YOUR_WAY_PRINT_PRICE
    'End If

    'Return dblTotal
    ' End Function

    Function CalcSub() As Double
        Dim dblSub As Double
        Dim strYourWay As String = "I Did it Your Way (Print)"
        Dim strHistory As String = "The History of Scotland (Print)"
        Dim strCalc As String = "Learn Calculus in One Day (Print)"
        Dim strFeel As String = "Feel the Stress (Print)"
        Dim strCalcAudio As String = "Learn Calculus in One Day (Audio)"
        Dim strHistoryAudio As String = "The History of Scotland (Audio)"
        Dim strScience As String = "The Science of Body Language (Audio)"
        Dim strRelaxation As String = "Relaxation Techniques (Audio)"


        For i As Integer = 0 To (MainForm.lstShoppingCart.Items.Count - 1)
            If (MainForm.lstShoppingCart.Items(i).ToString.Contains(strYourWay)) Then
                dblSub += YOUR_WAY_PRINT_PRICE
                Exit For
            End If
        Next

        For i As Integer = 0 To (MainForm.lstShoppingCart.Items.Count - 1)
            If (MainForm.lstShoppingCart.Items(i).ToString.Contains(strHistory)) Then
                dblSub += HISTORY_SCOTLAND_PRICE
                Exit For
            End If

        Next

        For i As Integer = 0 To (MainForm.lstShoppingCart.Items.Count - 1)
            If (MainForm.lstShoppingCart.Items(i).ToString.Contains(strCalc)) Then
                dblSub += LEARN_CALC_PRICE
                Exit For
            End If

        Next

        For i As Integer = 0 To (MainForm.lstShoppingCart.Items.Count - 1)
            If (MainForm.lstShoppingCart.Items(i).ToString.Contains(strFeel)) Then
                dblSub += FEEL_STRESS_PRICE
                Exit For
            End If
        Next

        For i As Integer = 0 To (MainForm.lstShoppingCart.Items.Count - 1)
            If (MainForm.lstShoppingCart.Items(i).ToString.Contains(strCalcAudio)) Then
                dblSub += LEARN_CALC_PRICE
                Exit For
            End If
        Next

        For i As Integer = 0 To (MainForm.lstShoppingCart.Items.Count - 1)
            If (MainForm.lstShoppingCart.Items(i).ToString.Contains(strHistoryAudio)) Then
                dblSub += HISTORY_SCOTLAND_PRICE
                Exit For
            End If
        Next

        For i As Integer = 0 To (MainForm.lstShoppingCart.Items.Count - 1)
            If (MainForm.lstShoppingCart.Items(i).ToString.Contains(strScience)) Then
                dblSub += SCIENCE_BODY_PRICE
                Exit For
            End If
        Next

        For i As Integer = 0 To (MainForm.lstShoppingCart.Items.Count - 1)
            If (MainForm.lstShoppingCart.Items(i).ToString.Contains(strRelaxation)) Then
                dblSub += RELAXATION_PRICE
                Exit For
            End If
        Next

        Return dblSub
    End Function


    Function SubTotal() As Double
        Dim dblSubTotal As Double


        If PrintBooks.lstPrintBooks.SelectedIndex = 2 Then
            dblSubTotal += LEARN_CALC_PRICE
        End If
        If PrintBooks.lstPrintBooks.SelectedIndex = 3 Then
            dblSubTotal += FEEL_STRESS_PRICE
        End If
        If PrintBooks.lstPrintBooks.SelectedIndex = 1 Then
            dblSubTotal += HISTORY_SCOTLAND_PRICE
        End If
        If AudioBooks.lstAudioBooks.SelectedIndex = 0 Then
            dblSubTotal += LEARN_CALC_PRICE
        End If
        If AudioBooks.lstAudioBooks.SelectedIndex = 1 Then
            dblSubTotal += HISTORY_SCOTLAND_PRICE
        End If
        If AudioBooks.lstAudioBooks.SelectedIndex = 2 Then
            dblSubTotal += SCIENCE_BODY_PRICE
        End If
        If AudioBooks.lstAudioBooks.SelectedIndex = 3 Then
            dblSubTotal += RELAXATION_PRICE
        End If
        dblSubTotal = CalcSub()
        Return dblSubTotal
    End Function

    Function Tax() As Double
        Dim dblTax As Double
        dblTax = SubTotal() * 0.06

        Return dblTax
    End Function

    Function Shipping() As Double
        Dim dblShipping As Double
        dblShipping = MainForm.lstShoppingCart.Items.Count * 2

        Return dblShipping
    End Function

    Function GrandTotal() As Double
        Dim dblTotal As Double
        dblTotal = SubTotal() + Tax() + Shipping()

        Return dblTotal
    End Function

End Module
