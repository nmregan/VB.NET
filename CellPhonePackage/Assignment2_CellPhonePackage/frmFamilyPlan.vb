' ********************************************************************************
' Name: Nick Regan
' Class: IT-102-001
' Abstract: Assignment #2 - Cell Phone Package
' **********************************************************************************

Option Strict On

Public Class frmFamilyPlan

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Constants for cell phone options
        Const dblPackageA As Double = 45.0
        Const dblPackageB As Double = 65.0
        Const dblPackageC As Double = 99.0
        Const dblEmailOption As Double = 25.0
        Const dblTextOption As Double = 10.0
        Const dblModel100 As Double = 29.95
        Const dblModel110 As Double = 49.95
        Const dblModel200 As Double = 99.95
        Const dblTax As Double = 0.06

        Dim intNumberOfPhones As Integer
        Dim dblSubtotal As Double
        Dim dblPhoneTax As Double
        Dim dblPhoneTotal As Double
        Dim dblOptions As Double
        Dim dblPackageCharge As Double
        Dim dblTotalMonthlyCharge As Double

        Try
            ' Validate Number of Phones
            If IsNumeric(txtNumberOfPhones.Text) Then
                intNumberOfPhones = CInt(txtNumberOfPhones.Text)

            Else
                MessageBox.Show("Please enter a number for Number of Phones.")
                txtNumberOfPhones.BackColor = Color.Yellow
                txtNumberOfPhones.Focus()
                Exit Sub
            End If

            If intNumberOfPhones <= 0 Then
                MessageBox.Show("Please enter a number greater than zero for Number of Phones.")
                txtNumberOfPhones.BackColor = Color.Yellow
                txtNumberOfPhones.Focus()
                Exit Sub
            End If

            ' Calculate Subtotal
            If radModel100.Checked = True Then
                dblSubtotal = dblModel100 * intNumberOfPhones
            ElseIf radModel110.Checked = True Then
                dblSubtotal = dblModel110 * intNumberOfPhones
            ElseIf radModel200.Checked = True Then
                dblSubtotal = dblModel200 * intNumberOfPhones
            End If

            ' Calculate Tax
            dblPhoneTax = dblSubtotal * dblTax

            ' Calculate Phone Total
            dblPhoneTotal = dblSubtotal + dblPhoneTax

            ' Calculate Options

            If chkEmail.Checked = True Then
                dblOptions = dblEmailOption * intNumberOfPhones
            End If

            If chkTextMessaging.Checked = True Then
                dblOptions = dblTextOption * intNumberOfPhones
            End If

            If chkEmail.Checked = True And chkTextMessaging.Checked = True Then
                dblOptions = (dblEmailOption + dblTextOption) * intNumberOfPhones
            End If

            ' Calculate Package Charge
            If radPackageA.Checked = True Then
                dblPackageCharge = dblPackageA
            ElseIf radPackageB.Checked = True Then
                dblPackageCharge = dblPackageB
            ElseIf radPackageC.Checked = True Then
                dblPackageCharge = dblPackageC
            End If

            ' Calculate Total Monthly Charge
            dblTotalMonthlyCharge = dblPhoneTotal + dblOptions + dblPackageCharge

            ' Display Subtotal
            lblSubtotal.Text = dblSubtotal.ToString("c")

            ' Display Phone Tax
            lblTax.Text = dblPhoneTax.ToString("c")

            ' Display Phone Total
            lblPhoneTotal.Text = dblPhoneTotal.ToString("c")

            ' Display Options
            lblOptions.Text = dblOptions.ToString("c")

            ' Display Package Charge
            lblPackageCharge.Text = dblPackageCharge.ToString("c")

            ' Display Total Monthly Charge
            lblTotalMonthlyCharge.Text = dblTotalMonthlyCharge.ToString("c")

            txtNumberOfPhones.BackColor = Color.White

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' clear all labels and reset check boxes and radio buttons
        radPackageA.Checked = False
        radPackageB.Checked = False
        radPackageC.Checked = False

        chkEmail.Checked = False
        chkTextMessaging.Checked = False

        lblSubtotal.ResetText()
        lblTax.ResetText()
        lblPhoneTotal.ResetText()
        lblOptions.ResetText()
        lblPackageCharge.ResetText()
        lblTotalMonthlyCharge.ResetText()

        txtNumberOfPhones.Clear()

        radModel100.Checked = True

        txtNumberOfPhones.BackColor = Color.White

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ' close the program
        Close()

    End Sub

End Class