

Option Strict On

Public Class frmGolfers

    

    Private Sub frmGolfers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

            EventYear()

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

    Sub EventYear()

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


            ' Show changes all at once at end (MUCH faster). 
            cboEventYears.BeginUpdate()

            ' Clear out the list
            'cboNames.Items.Clear()

            ' Build the select statement
            strSelect = "SELECT intEventYearID, intEventYear FROM TEventYears"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)


            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboEventYears.ValueMember = "intEventYearID"
            cboEventYears.DisplayMember = "intEventYear"
            cboEventYears.DataSource = dt



            ' Select the first item in the list by default
            If cboEventYears.Items.Count > 0 Then cboEventYears.SelectedIndex = 0

            ' Show any changes
            cboEventYears.EndUpdate()

            ' Clean up
            drSourceTable.Close()

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
            txtShirtSize.Text = dt.Rows(0).Item(8).ToString
            txtGender.Text = dt.Rows(0).Item(9).ToString

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

    Private Sub btnUpdateGolfer_Click(sender As Object, e As EventArgs) Handles btnUpdateGolfer.Click

        frmUpdateGolfer.ShowDialog()

        frmGolfers_Load(sender, e)

    End Sub

    Public Function Validation() As Boolean

        ' loop through the textboxes and check to make sure there is data in them
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


    Private Sub btnDeleteGolferSQL_Click(sender As Object, e As EventArgs) Handles btnDeleteGolferSQL.Click

        Try

            Dim strDelete As String = ""
            Dim strSelect As String = String.Empty
            Dim strName As String = ""
            Dim intRowsAffected As Integer
            Dim cmdDelete As OleDb.OleDbCommand ' this will be used for our Delete statement
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader
            Dim result As DialogResult

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

            ' always ask before deleting!!!!
            result = MessageBox.Show("Are you sure you want to Delete Golfer: Name-" & cboGolfers.Text & "?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            ' this will figure out which button was selected. Cancel and No does nothing, Yes will allow deletion
            Select Case result
                Case DialogResult.Cancel
                    MessageBox.Show("Action Canceled")
                Case DialogResult.No
                    MessageBox.Show("Action Canceled")
                Case DialogResult.Yes


                    ' Build the delete statement using PK from name selected
                    ' must delete any child revords first
                    strDelete = "Delete FROM TGolferEventYearSponsors Where intGolferID = " & cboGolfers.SelectedValue.ToString

                    ' Delete the record(s) 
                    cmdDelete = New OleDb.OleDbCommand(strDelete, m_conAdministrator)
                    intRowsAffected = cmdDelete.ExecuteNonQuery()

                    strDelete = "Delete FROM TGolferEventYears Where intGolferID = " & cboGolfers.SelectedValue.ToString

                    ' Delete the record(s) 
                    cmdDelete = New OleDb.OleDbCommand(strDelete, m_conAdministrator)
                    intRowsAffected = cmdDelete.ExecuteNonQuery()

                    ' now we can delete the parent record
                    strDelete = "Delete FROM TGolfers Where intGolferID = " & cboGolfers.SelectedValue.ToString

                    ' Delete the record(s) 
                    cmdDelete = New OleDb.OleDbCommand(strDelete, m_conAdministrator)
                    intRowsAffected = cmdDelete.ExecuteNonQuery()

                    ' Did it work?
                    If intRowsAffected > 0 Then

                        ' Yes, success
                        MessageBox.Show("Delete successful")

                    End If

            End Select

            ' close the database connection
            CloseDatabaseConnection()

            ' call the Form Load sub to refresh the combo box data after a delete
            frmGolfers_Load(sender, e)

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

    Private Sub btnDeleteGolferSP_Click(sender As Object, e As EventArgs) Handles btnDeleteGolferSP.Click

        Dim strDelete As String = ""
        Dim intRowsAffected As Integer
        Dim cmdDelete As New OleDb.OleDbCommand()

        Try

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

            ' text to call stored proc
            cmdDelete.CommandText = "EXECUTE uspDeleteGolfer " & CInt(cboGolfers.SelectedValue)
            cmdDelete.CommandType = CommandType.StoredProcedure

            ' have user verify they want to delete
            Dim drAnswer = MessageBox.Show("Are you sure you want to delete " & cboGolfers.Text & "?", "Delete Golfer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' If user says yes delete record
            If drAnswer = Windows.Forms.DialogResult.Yes Then
                ' Call stored proc which will delete record 
                cmdDelete = New OleDb.OleDbCommand(cmdDelete.CommandText, m_conAdministrator)

                ' this return is the # of rows affected
                intRowsAffected = cmdDelete.ExecuteNonQuery()
            End If

            ' have to let the user know what happened 
            If intRowsAffected > 0 Then
                MessageBox.Show("Delete successful Golfer " & cboGolfers.Text & " has been deleted.")
            Else
                MessageBox.Show("Delete failed")
            End If


            ' close database connection
            CloseDatabaseConnection()

            ' reload form so the record deleted is gone
            frmGolfers_Load(sender, e)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try

    End Sub

    
    Private Sub btnGolferTotals_Click(sender As Object, e As EventArgs) Handles btnGolferTotals.Click

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
            strSelect = "SELECT GolferTotals FROM VGolferTotals Where intGolferID = " & cboGolfers.SelectedValue.ToString & "and intEventYearID = " & cboEventYears.SelectedValue.ToString

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load the data table from the reader
            dt.Load(drSourceTable)

            ' populate the text boxes with the data
            lblGolferTotals.Text = dt.Rows(0).Item(0).ToString

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

    Private Sub btnAddGolfer_Click(sender As Object, e As EventArgs) Handles btnAddGolfer.Click

        frmAddGolfer.ShowDialog()

        frmGolfers_Load(sender, e)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub


End Class