Option Strict On

Public Class frmMain

  

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


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
            cboModels.BeginUpdate()

            ' Clear out the list
            'cboNames.Items.Clear()

            ' Build the select statement
            strSelect = "SELECT intAutoID, strModel FROM TAutos"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)


            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboModels.ValueMember = "intAutoID"
            cboModels.DisplayMember = "strModel"
            cboModels.DataSource = dt



            ' Select the first item in the list by default
            If cboModels.Items.Count > 0 Then cboModels.SelectedIndex = 0

            ' Show any changes
            cboModels.EndUpdate()

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try


    End Sub



    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

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
            strSelect = "SELECT strMake, strModel, strYear, strMileage FROM TAutos Where intAutoID = " & cboModels.SelectedValue.ToString

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load the data table from the reader
            dt.Load(drSourceTable)

            ' populate the text boxes with the data
            txtMake.Text = dt.Rows(0).Item(0).ToString
            txtModel.Text = dt.Rows(0).Item(1).ToString
            txtYear.Text = dt.Rows(0).Item(2).ToString
            txtMileage.Text = dt.Rows(0).Item(3).ToString

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' closes the program
        Close()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try


        Dim strSelect As String = ""
        Dim strMake As String = ""
        Dim strModel As String = ""
        Dim strYear As String = ""
        Dim strMileage As String = ""
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




            strMake = txtMake.Text
            strModel = txtModel.Text
            strYear = txtYear.Text
            strMileage = txtMileage.Text


            ' Build the select statement using PK from name selected
            strSelect = "Update TAutos Set strMake = '" & strMake & "', " & "strModel = '" & strModel & _
                "', " & "strYear = '" & strYear & "', " & "strMileage = '" & strMileage & "', " & _
                 "Where intAutoID = " & cboModels.SelectedValue.ToString  'strMake, strModel, strYear, strMileage FROM TAutos Where intAutoID = " & cboModels.SelectedValue

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
            Form1_Load(sender, e)

            End If

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        frmAddAuto.ShowDialog()

        Form1_Load(sender, e)

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

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
        result = MessageBox.Show("Are you sure you want to Delete Vehicle: Model-" & cboModels.Text & "?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        ' this will figure out which button was selected. Cancel and No does nothing, Yes will allow deletion
        Select Case result
            Case DialogResult.Cancel
                MessageBox.Show("Action Canceled")
            Case DialogResult.No
                MessageBox.Show("Action Canceled")
            Case DialogResult.Yes


                ' Build the delete statement using PK from name selected
                ' must delete any child revords first
                strDelete = "Delete FROM TAutos Where intAutoID = " & cboModels.SelectedValue.ToString

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
            Form1_Load(sender, e)

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

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

    Private Sub btnDeleteSP_Click(sender As Object, e As EventArgs) Handles btnDeleteSP.Click


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
            cmdDelete.CommandText = "EXECUTE uspDeleteAuto " & CInt(cboModels.SelectedValue)
            cmdDelete.CommandType = CommandType.StoredProcedure

            ' have user verify they want to delete
            Dim drAnswer = MessageBox.Show("Are you sure you want to delete " & cboModels.Text & "?", "Delete Model?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' If user says yes delete record
            If drAnswer = Windows.Forms.DialogResult.Yes Then
                ' Call stored proc which will delete record 
                cmdDelete = New OleDb.OleDbCommand(cmdDelete.CommandText, m_conAdministrator)

                ' this return is the # of rows affected
                intRowsAffected = cmdDelete.ExecuteNonQuery()
            End If

            ' have to let the user know what happened 
            If intRowsAffected > 0 Then
                MessageBox.Show("Delete successful Auto " & cboModels.Text & " has been deleted.")
            Else
                MessageBox.Show("Delete failed")
            End If


            ' close database connection
            CloseDatabaseConnection()

            ' reload form so the record deleted is gone
            Form1_Load(sender, e)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Close()
        End Try

    End Sub
End Class
