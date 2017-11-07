' *****************************
' Ray Harmon
' Addition program using functions
' <date>
'******************************
Option Strict On

Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' closes the program
        Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        ' create my local variables
        Dim dblNumber1 As Double
        Dim dblNumber2 As Double
        Dim dblSum As Double

        txtNumber1.BackColor = Color.White
        txtNumber2.BackColor = Color.White

        Try


            ' validate our input-numbers
            If Not Double.TryParse(txtNumber1.Text, dblNumber1) Then
                MessageBox.Show("Please enter numbers only for Number 1.")
                txtNumber1.Focus()
                txtNumber1.BackColor = Color.Yellow
                Exit Sub
            End If

            If dblNumber1 < 1 Or dblNumber1 > 9 Then
                MessageBox.Show("Please enter 1 thourgh 9 only for Number 1.")
                txtNumber1.Focus()
                txtNumber1.BackColor = Color.Yellow
                Exit Sub
            End If

            If IsNumeric(txtNumber2.Text) Then
                dblNumber2 = CDbl(txtNumber2.Text)
            Else
                MessageBox.Show("Please enter numbers only for Number 2.")
                txtNumber2.Focus()
                txtNumber2.BackColor = Color.Yellow
                Exit Sub
            End If

            If dblNumber2 < 10 Then
                MessageBox.Show("Please enter 10 or greater only for Number 2.")
                txtNumber2.Focus()
                txtNumber2.BackColor = Color.Yellow
                Exit Sub
            End If


            ' Do calculation by adding numbers
            dblSum = dblNumber1 + dblNumber2



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' clear out the controls
        txtNumber1.Clear()
        txtNumber2.Clear()
        lblSum.ResetText()

        txtNumber1.Focus()

    End Sub
End Class
