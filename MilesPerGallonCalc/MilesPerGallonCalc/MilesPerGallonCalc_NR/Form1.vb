' **************************************************
' Name: Nick Regan
' Date: 9/29/16
' Abstract: Assignment #5: Miles per Gallon Calculator
' **************************************************




Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallons.Clear()
        txtMiles.Clear()
        lblMPG.ResetText()

        txtGallons.Focus()

        txtGallons.BackColor = Color.White
        txtMiles.BackColor = Color.White

    End Sub

    Private Sub btnCalcMPG_Click(sender As Object, e As EventArgs) Handles btnCalcMPG.Click
        Dim dblGallons As Double
        Dim dblMiles As Double
        Dim dblMPG As Double

        Try

            txtGallons.BackColor = Color.White
            txtMiles.BackColor = Color.White

            If IsNumeric(txtGallons.Text) Then
                dblGallons = txtGallons.Text
            Else
                MessageBox.Show("Please enter the number of gallons of gas your car can hold")
                txtGallons.Focus()
                txtGallons.BackColor = Color.Yellow
                Exit Sub
            End If

            If dblGallons <= 0 Then
                MessageBox.Show("Please enter a number greater than 0")
                txtGallons.Focus()
                txtGallons.BackColor = Color.Yellow
                Exit Sub
            End If


            If IsNumeric(txtMiles.Text) Then
                dblMiles = txtMiles.Text
            Else
                MessageBox.Show("Please enter the number of mile your car can drive on a full tank")
                txtMiles.Focus()
                txtMiles.BackColor = Color.Yellow
                Exit Sub
            End If

            If dblMiles <= 0 Then
                MessageBox.Show("Please enter a number greater than 0")
                txtMiles.Focus()
                txtMiles.BackColor = Color.Yellow
                Exit Sub
            End If


            dblMPG = dblMiles / dblGallons

            lblMPG.Text = dblMPG

            lblMPG.Text = dblMPG.ToString("n2")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
