' ********************************************************************************
' Name: Nick Regan
' Date: 10/6/2016
' Class: IT-101-200
' Abstract: Assignment 6 - Theater Revenue
' **********************************************************************************

Option Strict On




Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtAdultTicketPrice.Clear()
        txtAdultTicketSold.Clear()
        txtChildTicketPrice.Clear()
        txtChildTicketSold.Clear()

        lblGrossAdultTicketSales.ResetText()
        lblGrossChildTicketSales.ResetText()
        lblNetAdultTicketSales.ResetText()
        lblNetChildTicketSales.ResetText()
        lblTotalGrossRevenue.ResetText()
        lblTotalNetRevenue.ResetText()

        txtAdultTicketPrice.Focus()

        txtAdultTicketPrice.BackColor = Color.White
        txtAdultTicketSold.BackColor = Color.White
        txtChildTicketPrice.BackColor = Color.White
        txtChildTicketSold.BackColor = Color.White

    End Sub

    Private Sub btnCalcTickRev_Click(sender As Object, e As EventArgs) Handles btnCalcTickRev.Click

        Const dblBoxOfficePercentage As Double = 0.2


        Dim dblAdultTicketPrice As Double
        Dim intAdultTicketSold As Integer
        Dim dblChildTicketPrice As Double
        Dim intChildTicketSold As Integer
        Dim dblGrossAdultTicketSales As Double
        Dim dblGrossChildTicketSales As Double
        Dim dblNetAdultTicketSales As Double
        Dim dblNetChildTicketSales As Double
        Dim dblTotalGrossRevenue As Double
        Dim dblTotalNetRevenue As Double

        Try

            txtAdultTicketPrice.BackColor = Color.White
            txtAdultTicketSold.BackColor = Color.White
            txtChildTicketPrice.BackColor = Color.White
            txtChildTicketSold.BackColor = Color.White

            'Adult Ticket Sales

            If IsNumeric(txtAdultTicketPrice.Text) Then
                dblAdultTicketPrice = CDbl(txtAdultTicketPrice.Text)
            Else
                MessageBox.Show("Please enter numeric value for adult ticket price.")
                txtAdultTicketPrice.BackColor = Color.Yellow
                txtAdultTicketPrice.Focus()
                Exit Sub
            End If

            If dblAdultTicketPrice < 0 Then
                MessageBox.Show("Please enter a value equal to or greater than 0 for adult ticket price.")
                txtAdultTicketPrice.BackColor = Color.Yellow
                txtAdultTicketPrice.Focus()
                Exit Sub
            End If

            If Not Integer.TryParse(txtAdultTicketSold.Text, intAdultTicketSold) Then
                MessageBox.Show("Please enter numeric value for adult ticket price (must be a whole number).")
                txtAdultTicketSold.BackColor = Color.Yellow
                txtAdultTicketSold.Focus()
                Exit Sub
            End If

            If intAdultTicketSold < 0 Then
                MessageBox.Show("Please enter a value greater than or equal to 0 for the number of adult tickets sold.")
                txtAdultTicketSold.BackColor = Color.Yellow
                txtAdultTicketSold.Focus()
                Exit Sub
            End If

            'Child Ticket Sales

            If IsNumeric(txtChildTicketPrice.Text) Then
                dblChildTicketPrice = CDbl(txtChildTicketPrice.Text)
            Else
                MessageBox.Show("Please enter numeric value for child ticket price.")
                txtChildTicketPrice.BackColor = Color.Yellow
                txtChildTicketPrice.Focus()
                Exit Sub
            End If

            If dblChildTicketPrice < 0 Then
                MessageBox.Show("Please enter a value equal to or greater than 0 for child ticket price.")
                txtChildTicketPrice.BackColor = Color.Yellow
                txtChildTicketPrice.Focus()
                Exit Sub
            End If

            If Not Integer.TryParse(txtChildTicketSold.Text, intChildTicketSold) Then
                MessageBox.Show("Please enter numeric value for child ticket price (must be a whole number).")
                txtChildTicketSold.BackColor = Color.Yellow
                txtChildTicketSold.Focus()
                Exit Sub
            End If

            If intChildTicketSold < 0 Then
                MessageBox.Show("Please enter a value greater than or equal to 0 for the number of child tickets sold.")
                txtChildTicketSold.BackColor = Color.Yellow
                txtChildTicketSold.Focus()
                Exit Sub
            End If

            ' do calculations

            dblGrossAdultTicketSales = dblAdultTicketPrice * intAdultTicketSold
            dblGrossChildTicketSales = dblChildTicketPrice * intChildTicketSold
            dblTotalGrossRevenue = dblGrossAdultTicketSales + dblGrossChildTicketSales


            lblGrossAdultTicketSales.Text = dblGrossAdultTicketSales.ToString("c")
            lblGrossChildTicketSales.Text = dblGrossChildTicketSales.ToString("c")
            lblTotalGrossRevenue.Text = dblTotalGrossRevenue.ToString("c")




            dblNetAdultTicketSales = dblGrossAdultTicketSales * dblBoxOfficePercentage
            dblNetChildTicketSales = dblGrossChildTicketSales * dblBoxOfficePercentage
            dblTotalNetRevenue = dblNetAdultTicketSales + dblNetChildTicketSales


            lblNetAdultTicketSales.Text = dblNetAdultTicketSales.ToString("c")
            lblNetChildTicketSales.Text = dblNetChildTicketSales.ToString("c")
            lblTotalNetRevenue.Text = dblTotalNetRevenue.ToString("c")


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
