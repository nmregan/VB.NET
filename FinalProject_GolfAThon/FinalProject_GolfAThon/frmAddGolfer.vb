


Option Strict On


Public Class frmAddGolfer

    Private Sub frmAddGolfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Gender()
            ShirtSize()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

    Private Sub btnAddNewGolfer_Click(sender As Object, e As EventArgs) Handles btnAddNewGolfer.Click

        Try

            Dim strSelect As String
            Dim strInsert As String
            Dim strFirstName As String = ""
            Dim strLastName As String = ""
            Dim strStreetAddress As String = ""
            Dim strCity As String = ""
            Dim strState As String = ""
            Dim strZip As String = ""
            Dim strPhoneNumber As String = ""
            Dim strEmail As String = ""
            Dim cmdSelect As OleDb.OleDbCommand
            Dim cmdInsert As OleDb.OleDbCommand
            Dim drSourceTable As OleDb.OleDbDataReader
            Dim intNextHighestRecordID As Integer
            Dim intRowsAffected As Integer


            strFirstName = txtFirstName.Text
            strLastName = txtLastName.Text
            strStreetAddress = txtAddress.Text
            strCity = txtCity.Text
            strState = txtState.Text
            strZip = txtZip.Text
            strPhoneNumber = txtPhone.Text
            strEmail = txtEmail.Text


            If Validation() = True Then



                If OpenDatabaseConnectionSQLServer() = False Then

                    ' No, warn the user ...
                    MessageBox.Show(Me, "Database connection error." & vbNewLine & _
                                        "The application will now close.",
                                        Me.Text + " Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' and close the form/application
                    Me.Close()

                End If

                strSelect = "SELECT MAX(intGolferID) + 1 AS intNextHighestRecordID " & _
                        " FROM TGolfers"

                ' Execute command
                cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                drSourceTable = cmdSelect.ExecuteReader

                ' Read result( highest ID )
                drSourceTable.Read()

                ' Null? (empty table)
                If drSourceTable.IsDBNull(0) = True Then

                    ' Yes, start numbering at 1
                    intNextHighestRecordID = 1

                Else

                    ' No, get the next highest ID
                    intNextHighestRecordID = CInt(drSourceTable.Item(0))

                End If

                strInsert = "Insert into TGolfers (intGolferID, strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEmail, intShirtSizeID, intGenderID)" & _
                " Values (" & intNextHighestRecordID & ",'" & strFirstName & "'," & "'" & strLastName & "'," & "'" & strStreetAddress & "'," & "'" & strCity & "'," & "'" & strState & "'," & "'" & strZip & "'," & "'" & strPhoneNumber & "'," & "'" & strEmail & "'," & "'" & cboShirtSize.SelectedValue.ToString & "'," & "'" & cboGender.SelectedValue.ToString & "')"

                cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)


                intRowsAffected = cmdInsert.ExecuteNonQuery()

                If intRowsAffected > 0 Then
                    MessageBox.Show("Golfer has been added")
                    Me.Close()
                End If


                CloseDatabaseConnection()


            End If

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