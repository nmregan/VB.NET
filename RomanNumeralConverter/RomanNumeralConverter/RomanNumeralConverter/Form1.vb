' *****************************************************************************************
' Nicholas Regan
' 10/20/2016
' Assignment 9: Roman Numeral Converter
' *****************************************************************************************

Option Strict On


Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber.Clear()
        lblRomanNumeral.ResetText()

        txtNumber.Focus()
        txtNumber.BackColor = Color.White

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intNumber As Integer


        Try

            txtNumber.BackColor = Color.White

            If Not Integer.TryParse(txtNumber.Text, intNumber) Then
                MessageBox.Show("Please enter numbers only.")
                txtNumber.Focus()
                txtNumber.BackColor = Color.Yellow
                Exit Sub
            End If

            If intNumber <= 0 Then
                MessageBox.Show("Please enter a number greater than 0")
                txtNumber.Focus()
                txtNumber.BackColor = Color.Yellow
                Exit Sub
            End If


            Select Case intNumber
                Case 1
                    lblRomanNumeral.Text = "I"
                Case 2
                    lblRomanNumeral.Text = "II"
                Case 3
                    lblRomanNumeral.Text = "III"
                Case 4
                    lblRomanNumeral.Text = "IV"
                Case 5
                    lblRomanNumeral.Text = "V"
                Case 6
                    lblRomanNumeral.Text = "VI"
                Case 7
                    lblRomanNumeral.Text = "VII"
                Case 8
                    lblRomanNumeral.Text = "VIII"
                Case 9
                    lblRomanNumeral.Text = "IX"
                Case 10
                    lblRomanNumeral.Text = "X"
                Case Else
                    MessageBox.Show("Please enter a number between 1 and 10.")
            End Select


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
