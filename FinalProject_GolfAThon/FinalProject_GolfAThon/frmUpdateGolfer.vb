

Option Strict On

Public Class frmUpdateGolfer


    Private Sub frmUpdateGolfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

            ' loop through the textboxes and clear them in case they have data in them after a delete
            For Each cntrl As Control In Controls
                If TypeOf cntrl Is TextBox Then
                    cntrl.Text = String.Empty
                End If
            Next

            ShirtSize()
            Gender()


            cboGender.ResetText()
            cboShirtSize.ResetText()


            ' open the DB
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine & _
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Show changes all at once at end (MUCH faster). 
            cboGolfers.BeginUpdate()

            ' Clear out the list
            'cboNames.Items.Clear()

            ' Build the select statement
            strSelect = "SELECT intGolferID, strLastName FROM TGolfers"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)


            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboGolfers.ValueMember = "intGolferID"
            cboGolfers.DisplayMember = "strLastName"
            cboGolfers.DataSource = dt



            ' Select the first item in the list by default
            If cboGolfers.Items.Count > 0 Then cboGolfers.SelectedIndex = 0

            ' Show any changes
            cboGolfers.EndUpdate()

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

    Sub Gender()

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

            ' loop through the textboxes and clear them in case they have data in them after a delete
            For Each cntrl As Control In Controls
                If TypeOf cntrl Is TextBox Then
                    cntrl.Text = String.Empty
                End If
            Next


            ' open the DB
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine & _
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Show changes all at once at end (MUCH faster). 
            cboGender.BeginUpdate()

            ' Clear out the list
            'cboNames.Items.Clear()

            ' Build the select statement
            strSelect = "SELECT intGenderID, strGenderDesc FROM TGenders"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)


            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboGender.ValueMember = "intGenderID"
            cboGender.DisplayMember = "strGenderDesc"
            cboGender.DataSource = dt



            ' Select the first item in the list by default
            If cboGender.Items.Count > 0 Then cboGender.SelectedIndex = 0

            ' Show any changes
            cboGender.EndUpdate()

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

    Sub ShirtSize()

        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

            ' loop through the textboxes and clear them in case they have data in them after a delete
            For Each cntrl As Control In Controls
                If TypeOf cntrl Is TextBox Then
                    cntrl.Text = String.Empty
                End If
            Next


            ' open the DB
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine & _
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Show changes all at once at end (MUCH faster). 
            cboShirtSize.BeginUpdate()

            ' Clear out the list
            'cboNames.Items.Clear()

            ' Build the select statement
            strSelect = "SELECT intShirtSizeID, strShirtSizeDesc FROM TShirtSizes"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)


            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboShirtSize.ValueMember = "intShirtSizeID"
            cboShirtSize.DisplayMember = "strShirtSizeDesc"
            cboShirtSize.DataSource = dt



            ' Select the first item in the list by default
            If cboShirtSize.Items.Count > 0 Then cboShirtSize.SelectedIndex = 0

            ' Show any changes
            cboShirtSize.EndUpdate()

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

    Private Sub btnLoadGolfer_Click(sender As Object, e As EventArgs) Handles btnLoadGolfer.Click

        Try

            Dim strSelect As String = ""
            Dim strName As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

            ' open the database
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine & _
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Build the select statement using PK from name selected
            strSelect = "SELECT strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEmail, strShirtSizeDesc, strGenderDesc FROM VGolferInfo Where intGolferID = " & cboGolfers.SelectedValue.ToString

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load the data table from the reader
            dt.Load(drSourceTable)

            ' populate the text boxes with the data
            txtFirstName.Text = dt.Rows(0).Item(0).ToString
            txtLastName.Text = dt.Rows(0).Item(1).ToString
            txtAddress.Text = dt.Rows(0).Item(2).ToString
            txtCity.Text = dt.Rows(0).Item(3).ToString
            txtState.Text = dt.Rows(0).Item(4).ToString
            txtZip.Text = dt.Rows(0).Item(5).ToString
            txtPhone.Text = dt.Rows(0).Item(6).ToString
            txtEmail.Text = dt.Rows(0).Item(7).ToString
            cboShirtSize.Text = dt.Rows(0).Item(8).ToString
            cboGender.Text = dt.Rows(0).Item(9).ToString

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

    Private Sub btnUpdateGolfer_Click(sender As Object, e As EventArgs) Handles btnUpdateGolfer.Click

        Try

            Dim strSelect As String = ""
            Dim strFirstName As String = ""
            Dim strLastName As String = ""
            Dim strStreetAddress As String = ""
            Dim strCity As String = ""
            Dim strState As String = ""
            Dim strZip As String = ""
            Dim strPhoneNumber As String = ""
            Dim strEmail As String = ""
            Dim intRowsAffected As Integer

            ' thie will hold our Update statement
            Dim cmdUpdate As OleDb.OleDbCommand

            ' check to make sure all text boxes have data. No data no update!
            If Validation() = True Then
                ' open database
                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine & _
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

                strFirstName = txtFirstName.Text
                strLastName = txtLastName.Text
                strStreetAddress = txtAddress.Text
                strCity = txtCity.Text
                strState = txtState.Text
                strZip = txtZip.Text
                strPhoneNumber = txtPhone.Text
                strEmail = txtEmail.Text


                ' Build the select statement using PK from name selected
                strSelect = "Update TGolfers Set strFirstName = '" & strFirstName & "', " & "strLastName = '" & strLastName & "', " & "strStreetAddress = '" & strStreetAddress & "', " & "strCity = '" & strCity & "', " & _
                  "strState = '" & strState & "', " & "strZip = '" & strZip & "', " & "strPhoneNumber = '" & strPhoneNumber & "', " & "strEmail = '" & strEmail & "', " & "intShirtSizeID = '" & cboShirtSize.SelectedValue.ToString & "', " & "intGenderID = '" & cboGender.SelectedValue.ToString & "' " & _
                  "Where intGolferID = " & cboGolfers.SelectedValue.ToString  'strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEmail FROM TDealers Where intDealerID = " & cboDealerNames.SelectedValue
                'MessageBox.Show(strSelect)

                ' execute the statement
                cmdUpdate = New OleDb.OleDbCommand(strSelect, m_conAdministrator)

                ' Insert the row
                intRowsAffected = cmdUpdate.ExecuteNonQuery()

                ' have to let the user know what happened 
                If intRowsAffected = 1 Then
                    MessageBox.Show("Update successful")
                Else
                    MessageBox.Show("Update failed")
                End If

                ' close the database connection
                CloseDatabaseConnection()

                ' call the Form Load sub to refresh the combo box data after a delete
                frmUpdateGolfer_Load(sender, e)

            End If

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

    Public Function Validation() As Boolean

        ' loop through the textboxes and clear them in case they have data in them after a delete
        For Each cntrl As Control In Controls
            If TypeOf cntrl Is TextBox Then
                cntrl.BackColor = Color.White
                If cntrl.Text = String.Empty Then
                    cntrl.BackColor = Color.Yellow
                    cntrl.Focus()
                    Return False
                End If
            End If
        Next

        'every this is good so return true
        Return True

    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

End Class