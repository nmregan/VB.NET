' **********************************************************
' Nick Regan
' 11/3/16
' Assignment 12: Retail Price Calculator
'***********************************************************

Option Strict On


Public Class Form1
    Dim blnOK As Boolean = False

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCost.Clear()
        txtMarkup.Clear()
        lblRetailPrice.ResetText()

        txtCost.Focus()

        txtCost.BackColor = Color.White
        txtMarkup.BackColor = Color.White

    End Sub

    Private Sub btnCalculations_Click(sender As Object, e As EventArgs) Handles btnCalculations.Click
        Dim dblCost As Double
        Dim dblMarkup As Double
        Dim dblRetailPrice As Double

        txtCost.BackColor = Color.White
        txtMarkup.BackColor = Color.White

        Try

            'Call Validation(dblCost, dblMarkup)

            'If blnOK = True Then
            dblRetailPrice = CalculateRetail(dblCost, dblMarkup)

            Display(CStr(dblRetailPrice.ToString("c")))
            'End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Private Sub Validation(ByRef Cost As Double, ByRef Markup As Double)
    '    If IsNumeric(txtCost.Text) Then
    '        Cost = CDbl(txtCost.Text)
    '    Else
    '        MessageBox.Show("Please enter a number for wholesale cost of item.")
    '        txtCost.Focus()
    '        txtCost.BackColor = Color.Yellow
    '        blnOK = False
    '        Exit Sub
    '    End If

    '    If Cost < 0 Then
    '        MessageBox.Show("Please enter a number greater than 0 for the wholesale cost.")
    '        txtCost.Focus()
    '        txtCost.BackColor = Color.Yellow
    '        blnOK = False
    '        Exit Sub
    '    End If

    '    If IsNumeric(txtMarkup.Text) Then
    '        Markup = CDbl(txtMarkup.Text)

    '    Else
    '        Markup = CDbl(txtMarkup.Text)
    '        MessageBox.Show("Please enter a number for markup %.")
    '        txtMarkup.Focus()
    '        txtMarkup.BackColor = Color.Yellow
    '        blnOK = False
    '        Exit Sub
    '    End If

    '    If Markup < 0 Then
    '        MessageBox.Show("Please enter a number greater than 0 for markup %.")
    '        txtMarkup.Focus()
    '        txtMarkup.BackColor = Color.Yellow
    '        blnOK = False
    '        Exit Sub
    '    End If

    '    blnOK = True

    'End Sub

    Private Function CalculateRetail(ByVal Cost As Double, ByVal Markup As Double) As Double
        Dim dblRetailPrice As Double

        dblRetailPrice = Cost * (1 + Markup / 100)

        Return dblRetailPrice

    End Function

    Private Sub Display(ByVal RetailOutput As String)
        lblRetailPrice.Text = RetailOutput

    End Sub
End Class
