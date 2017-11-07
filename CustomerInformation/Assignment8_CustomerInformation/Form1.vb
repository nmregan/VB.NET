' ********************************************************************************
' Name: Nick Regan
' Class: IT-102-001
' Abstract: Assignment #8 - Customer Information
' **********************************************************************************

Option Strict On


Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim objPerson As New Person

        If Validation() = True Then

            objPerson.LastName = txtLastName.Text
            objPerson.FirstName = txtFirstName.Text
            objPerson.Address = txtAddress.Text
            objPerson.City = txtCity.Text
            objPerson.State = txtState.Text
            objPerson.Zip = txtZip.Text
            objPerson.Phone = txtPhone.Text

            Display(objPerson)

        End If

    End Sub

    Function Validation() As Boolean

        txtLastName.BackColor = Color.White
        txtFirstName.BackColor = Color.White
        txtAddress.BackColor = Color.White
        txtCity.BackColor = Color.White
        txtState.BackColor = Color.White
        txtZip.BackColor = Color.White
        txtPhone.BackColor = Color.White

        If txtLastName.Text = String.Empty Then
            MessageBox.Show("Please enter a last name.")
            txtLastName.BackColor = Color.Yellow
            txtLastName.Focus()
            Return False
        End If

        If txtFirstName.Text = String.Empty Then
            MessageBox.Show("Please enter a first name.")
            txtFirstName.BackColor = Color.Yellow
            txtFirstName.Focus()
            Return False
        End If

        If txtAddress.Text = String.Empty Then
            MessageBox.Show("Please enter an address.")
            txtAddress.BackColor = Color.Yellow
            txtAddress.Focus()
            Return False
        End If

        If txtCity.Text = String.Empty Then
            MessageBox.Show("Please enter a city.")
            txtCity.BackColor = Color.Yellow
            txtCity.Focus()
            Return False
        End If

        If txtState.Text = String.Empty Then
            MessageBox.Show("Please enter a state.")
            txtState.BackColor = Color.Yellow
            txtState.Focus()
            Return False
        End If

        If txtZip.Text = String.Empty Then
            MessageBox.Show("Please enter a zip code.")
            txtZip.BackColor = Color.Yellow
            txtZip.Focus()
            Return False
        End If

        If txtPhone.Text = String.Empty Then
            MessageBox.Show("Please enter a phone number.")
            txtPhone.BackColor = Color.Yellow
            txtPhone.Focus()
            Return False
        End If

        Return True

    End Function

    Sub Display(ByVal objPerson As Person)

        lblLastName.Text = objPerson.LastName
        lblFirstName.Text = objPerson.FirstName
        lblAddress.Text = objPerson.Address
        lblCity.Text = objPerson.City
        lblState.Text = objPerson.State
        lblZip.Text = objPerson.Zip
        lblPhone.Text = objPerson.Phone

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        ' clear out the text boxes
        For Each ctrl As Control In Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = String.Empty
            End If
        Next

        lblLastName.ResetText()
        lblFirstName.ResetText()
        lblAddress.ResetText()
        lblCity.ResetText()
        lblState.ResetText()
        lblZip.ResetText()
        lblPhone.ResetText()

        txtLastName.BackColor = Color.White
        txtFirstName.BackColor = Color.White
        txtAddress.BackColor = Color.White
        txtCity.BackColor = Color.White
        txtState.BackColor = Color.White
        txtZip.BackColor = Color.White
        txtPhone.BackColor = Color.White

        txtLastName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub


End Class
