Imports System.IO
Imports System.Diagnostics.Process
Imports Excel = Microsoft.Office.Interop.Excel

Public Class AddTestQuote

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim unit As Control
        Dim price As Control
        Dim con_total As Control
        Dim dub_total As Double = 0
        Dim unit_price As Double
        Dim unit_total As Double
        Dim final_total As Double
        Dim row As Integer
        Dim column As Integer = 1

        'will loop through the table to unit total for each row. if not valid
        'number not entered they will be 0'd out
        For row = 0 To 19 Step 1
            unit = Me.tblPrices.GetControlFromPosition(column, row)
            price = Me.tblPrices.GetControlFromPosition(column + 1, row)
            If (Len(unit.Text) > 0 And Len(price.Text)) Then
                If (IsNumeric(remove_sign(unit.Text)) And IsNumeric(remove_sign(price.Text))) Then
                    unit_total = Convert.ToDouble(remove_sign(unit.Text)) * Convert.ToDouble(remove_sign(price.Text))
                    Me.tblPrices.GetControlFromPosition(column + 2, row).Text = unit_total
                Else
                    unit.Text = "0"
                    price.Text = "0.00"
                    unit_total = 0
                    Me.tblPrices.GetControlFromPosition(column + 2, row).Text = unit_total
                End If
            End If
        Next row

        'total for single unit
        For row = 0 To 19 Step 1
            con_total = Me.tblPrices.GetControlFromPosition(3, row)
            If (IsNumeric(con_total.Text)) Then
                dub_total = dub_total + Convert.ToDouble(remove_sign(con_total.Text))
            End If
        Next
        txtFinal.Text = dub_total.ToString("C")

        'format all number inputs to that of currency $
        For row = 0 To 19 Step 1
            unit = Me.tblPrices.GetControlFromPosition(2, row)
            con_total = Me.tblPrices.GetControlFromPosition(3, row)
            unit.Text = remove_sign(unit.Text)
            con_total.Text = remove_sign(con_total.Text)
            If (IsNumeric(unit.Text) And IsNumeric(con_total.Text)) Then
                unit_price = Convert.ToDouble(unit.Text)
                unit.Text = unit_price.ToString("C")
                final_total = Convert.ToDouble(con_total.Text)
                con_total.Text = final_total.ToString("C")
            End If
        Next
    End Sub

    'go back to the previous form and hide this form
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        CustomerContact.quoteGenInst.Show()
        QuoteGenerator.addTestQuoteInst.Hide()
    End Sub

    'used to remove dollar sign from values in table
    Public Function remove_sign(old As String)
        Return old.TrimStart("$")
    End Function

    Private Sub AddTestQuote_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class