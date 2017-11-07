' ********************************************************************************
' Name: Nick Regan
' Date: 10/13/2016
' Class: IT-101-200
' Abstract: Assignment 8 - Larger and Smaller
' **********************************************************************************


Option Strict On


Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumberA.Clear()
        txtNumberB.Clear()
        lblOutput.ResetText()

        txtNumberA.Focus()

        txtNumberA.BackColor = Color.White
        txtNumberB.BackColor = Color.White

    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim intNumberA As Integer
        Dim intNumberB As Integer

        Try

            txtNumberA.BackColor = Color.White
            txtNumberB.BackColor = Color.White

            If Not Integer.TryParse(txtNumberA.Text, intNumberA) Then
                MessageBox.Show("Please enter numeric value for A (value must be a whole number).")
                txtNumberA.BackColor = Color.Yellow
                txtNumberA.Focus()
                Exit Sub
            End If

            If Not Integer.TryParse(txtNumberB.Text, intNumberB) Then
                MessageBox.Show("Please enter numeric value for B (value must be a whole number).")
                txtNumberB.BackColor = Color.Yellow
                txtNumberB.Focus()
                Exit Sub
            End If

            Select Case intNumberA
                Case Is > intNumberB
                    lblOutput.Text = "Value A is greatest"
            End Select

            Select Case intNumberB
                Case Is > intNumberA
                    lblOutput.Text = "Value B is greatest"
            End Select

            Select Case intNumberA
                Case Is = intNumberB
                    lblOutput.Text = "Values are equal"
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
