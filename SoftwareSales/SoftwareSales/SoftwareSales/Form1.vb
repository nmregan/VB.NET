' ********************************************************************************
' Name: Nick Regan
' Date: 10/13/2016
' Class: IT-101-200
' Abstract: Assignment 7 - Software Sales
' **********************************************************************************


Option Strict On

Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPackageA.Clear()
        txtPackageB.Clear()
        txtPackageC.Clear()
        lblPackageASales.ResetText()
        lblPackageBSales.ResetText()
        lblPackageCSales.ResetText()
        lblGrandTotal.ResetText()

        txtPackageA.Focus()

        txtPackageA.BackColor = Color.White
        txtPackageB.BackColor = Color.White
        txtPackageC.BackColor = Color.White

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Const dblPackageAPrice As Double = 99
        Const dblPackageBPrice As Double = 199
        Const dblPackageCPrice As Double = 299

        Const dblDiscount0 As Double = 0.0
        Const dblDiscount1 As Double = 0.2
        Const dblDiscount2 As Double = 0.3
        Const dblDiscount3 As Double = 0.4
        Const dblDiscount4 As Double = 0.5
        
        Dim intPackageA As Integer
        Dim intPackageB As Integer
        Dim intPackageC As Integer
        Dim dblPackageASales As Double
        Dim dblPackageBSales As Double
        Dim dblPackageCSales As Double
        Dim dblGrandTotal As Double

        Try

            txtPackageA.BackColor = Color.White
            txtPackageB.BackColor = Color.White
            txtPackageC.BackColor = Color.White

            If Not Integer.TryParse(txtPackageA.Text, intPackageA) Then
                MessageBox.Show("Please enter numeric value for Package A (value must be a whole number).")
                txtPackageA.BackColor = Color.Yellow
                txtPackageA.Focus()
                Exit Sub
            End If

            If intPackageA < 0 Then
                MessageBox.Show("Please enter a value greater than or equal to 0 for Package A.")
                txtPackageA.BackColor = Color.Yellow
                txtPackageA.Focus()
                Exit Sub
            End If

            If Not Integer.TryParse(txtPackageB.Text, intPackageB) Then
                MessageBox.Show("Please enter numeric value for Package B (value must be a whole number).")
                txtPackageB.BackColor = Color.Yellow
                txtPackageB.Focus()
                Exit Sub
            End If

            If intPackageB < 0 Then
                MessageBox.Show("Please enter a value greater than or equal to 0 for Package B.")
                txtPackageB.BackColor = Color.Yellow
                txtPackageB.Focus()
                Exit Sub
            End If

            If Not Integer.TryParse(txtPackageC.Text, intPackageC) Then
                MessageBox.Show("Please enter numeric value for Package C (value must be a whole number).")
                txtPackageC.BackColor = Color.Yellow
                txtPackageC.Focus()
                Exit Sub
            End If

            If intPackageC < 0 Then
                MessageBox.Show("Please enter a value greater than or equal to 0 for Package C.")
                txtPackageC.BackColor = Color.Yellow
                txtPackageC.Focus()
                Exit Sub
            End If

            Select Case intPackageA
                Case Is >= 100
                    dblPackageASales = (intPackageA * dblPackageAPrice) - (dblDiscount4 * (intPackageA * dblPackageAPrice))
                Case 50 To 99
                    dblPackageASales = (intPackageA * dblPackageAPrice) - (dblDiscount3 * (intPackageA * dblPackageAPrice))
                Case 20 To 49
                    dblPackageASales = (intPackageA * dblPackageAPrice) - (dblDiscount2 * (intPackageA * dblPackageAPrice))
                Case 10 To 19
                    dblPackageASales = (intPackageA * dblPackageAPrice) - (dblDiscount1 * (intPackageA * dblPackageAPrice))
                Case Else
                    dblPackageASales = (intPackageA * dblPackageAPrice) - (dblDiscount0 * (intPackageA * dblPackageAPrice))
            End Select

            Select Case intPackageB
                Case Is >= 100
                    dblPackageBSales = (intPackageB * dblPackageBPrice) - (dblDiscount4 * (intPackageB * dblPackageBPrice))
                Case 50 To 99
                    dblPackageBSales = (intPackageB * dblPackageBPrice) - (dblDiscount3 * (intPackageB * dblPackageBPrice))
                Case 20 To 49
                    dblPackageBSales = (intPackageB * dblPackageBPrice) - (dblDiscount2 * (intPackageB * dblPackageBPrice))
                Case 10 To 19
                    dblPackageBSales = (intPackageB * dblPackageBPrice) - (dblDiscount1 * (intPackageB * dblPackageBPrice))
                Case Else
                    dblPackageBSales = (intPackageB * dblPackageBPrice) - (dblDiscount0 * (intPackageB * dblPackageBPrice))
            End Select

            Select Case intPackageC
                Case Is >= 100
                    dblPackageCSales = (intPackageC * dblPackageCPrice) - (dblDiscount4 * (intPackageC * dblPackageCPrice))
                Case 50 To 99
                    dblPackageCSales = (intPackageC * dblPackageCPrice) - (dblDiscount3 * (intPackageC * dblPackageCPrice))
                Case 20 To 49
                    dblPackageCSales = (intPackageC * dblPackageCPrice) - (dblDiscount2 * (intPackageC * dblPackageCPrice))
                Case 10 To 19
                    dblPackageCSales = (intPackageC * dblPackageCPrice) - (dblDiscount1 * (intPackageC * dblPackageCPrice))
                Case Else
                    dblPackageCSales = (intPackageC * dblPackageCPrice) - (dblDiscount0 * (intPackageC * dblPackageCPrice))
            End Select


            lblPackageASales.Text = dblPackageASales.ToString("c")
            lblPackageBSales.Text = dblPackageBSales.ToString("c")
            lblPackageCSales.Text = dblPackageCSales.ToString("c")

            dblGrandTotal = dblPackageASales + dblPackageBSales + dblPackageCSales
            lblGrandTotal.Text = dblGrandTotal.ToString("c")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class
