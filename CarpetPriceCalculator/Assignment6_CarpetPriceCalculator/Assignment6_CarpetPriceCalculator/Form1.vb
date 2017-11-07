' ********************************************************************************
' Name: Nick Regan
' Class: IT-102-001
' Abstract: Assignment #6 - Carpet Price Calculator
' **********************************************************************************

Option Strict On



Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare Variables
        Dim objRectangal As New Rectangal
        Dim objCarpet As New Carpet
        Dim dblTotalPrice As Double


        If Validation() = True Then

            objRectangal.Length = CInt(txtLength.Text)

            objRectangal.Width = CInt(txtWidth.Text)

            objCarpet.Price = CDbl(txtPrice.Text)

            objCarpet.Color = txtColor.Text

            objCarpet.Style = txtStyle.Text

            dblTotalPrice = CalcTotalPrice(objRectangal, objCarpet)

            DisplayArea(objRectangal)

            DisplayTotalPrice(dblTotalPrice)

            DisplayColorStyle(objCarpet)

        End If

    End Sub

    Private Sub DisplayArea(ByVal objRectangal As Rectangal)
        ' Display Area in the Area Label on form1
        lblArea.Text = CStr(objRectangal.GetArea)

    End Sub

    Function CalcTotalPrice(ByRef objRectangal As Rectangal, ByRef objCarpet As Carpet) As Double
        ' Calculates total price of carpet

        Return objCarpet.Price * CDbl(objRectangal.GetArea)

    End Function

    Private Sub DisplayTotalPrice(ByVal dblTotalPrice As Double)
        ' Display total price in the Area Label on form1
        lblPriceOfCarpet.Text = CStr(dblTotalPrice.ToString("c"))

    End Sub

    Sub DisplayColorStyle(ByVal objCarpet As Carpet)
        ' Show color and style in a message box
        MessageBox.Show("your color is " & objCarpet.Color & "your style is " & objCarpet.Style)

    End Sub

    Function Validation() As Boolean
        ' Sets all backcolors back to white once validated
        txtColor.BackColor = Color.White
        txtStyle.BackColor = Color.White
        txtPrice.BackColor = Color.White
        txtWidth.BackColor = Color.White
        txtLength.BackColor = Color.White

        ' Declare Variables for validation
        Dim dblPrice As Double
        Dim intWidth As Integer
        Dim intLength As Integer

        ' Checks to see that color textbox is empty, if so, 
        ' a message box pops up and the user is unable to proceed
        If txtColor.Text = String.Empty Then
            MessageBox.Show("Please enter a Color.")
            txtColor.BackColor = Color.Yellow
            txtColor.Focus()
            Return False
        End If
        ' Checks to see that style textbox is empty, if so, 
        ' a message box pops up and the user is unable to proceed
        If txtStyle.Text = String.Empty Then
            MessageBox.Show("Please enter a Style.")
            txtStyle.BackColor = Color.Yellow
            txtStyle.Focus()
            Return False
        End If
        ' Checks to see if text in price textbox is a number, if not, 
        ' a message box pops up and the user is unable to proceed
        If IsNumeric(txtPrice.Text) Then
            dblPrice = CDbl(txtPrice.Text)
        Else
            MessageBox.Show("Please enter a number for Price.")
            txtPrice.Focus()
            txtPrice.BackColor = Color.Yellow
            Return False
            Exit Function
        End If
        ' Checks to see if text in price textbox is greater than 0, if not, 
        ' a message box pops up and the user is unable to proceed
        If dblPrice < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for Price.")
            txtPrice.Focus()
            txtPrice.BackColor = Color.Yellow
            Return False
            Exit Function
        End If
        ' Checks to see if text in width textbox is a number, if not, 
        ' a message box pops up and the user is unable to proceed
        If IsNumeric(txtWidth.Text) Then
            intWidth = CInt(txtWidth.Text)
        Else
            MessageBox.Show("Please enter a number for Width.")
            txtWidth.Focus()
            txtWidth.BackColor = Color.Yellow
            Return False
            Exit Function
        End If
        ' Checks to see if text in width textbox is greater than 0, if not, 
        ' a message box pops up and the user is unable to proceed
        If intWidth < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for Width.")
            txtWidth.Focus()
            txtWidth.BackColor = Color.Yellow
            Return False
            Exit Function
        End If
        ' Checks to see if text in length textbox is a number, if not, 
        ' a message box pops up and the user is unable to proceed
        If IsNumeric(txtLength.Text) Then
            intLength = CInt(txtLength.Text)
        Else
            MessageBox.Show("Please enter a number for Length.")
            txtLength.Focus()
            txtLength.BackColor = Color.Yellow
            Return False
            Exit Function
        End If
        ' Checks to see if text in length textbox is greater than 0, if not, 
        ' a message box pops up and the user is unable to proceed
        If intLength < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for Length.")
            txtLength.Focus()
            txtLength.BackColor = Color.Yellow
            Return False
            Exit Function
        End If

        Return True

    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears all text boxes and labels
        txtColor.Clear()
        txtStyle.Clear()
        txtPrice.Clear()
        txtWidth.Clear()
        txtLength.Clear()
        lblArea.ResetText()
        lblPriceOfCarpet.ResetText()
        ' Refocuses cursor to color text box
        txtColor.Focus()
        ' Sets all backcolors back to white
        txtColor.BackColor = Color.White
        txtStyle.BackColor = Color.White
        txtPrice.BackColor = Color.White
        txtWidth.BackColor = Color.White
        txtLength.BackColor = Color.White

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes carpet price calculator form
        Close()

    End Sub

End Class
