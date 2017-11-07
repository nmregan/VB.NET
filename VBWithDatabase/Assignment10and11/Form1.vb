' ********************************************************************************
' Name: Nick Regan
' Class: IT-102-001
' Abstract: Assignment #10 & 11
' **********************************************************************************

Option Strict On

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

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
            ' copy and paste this everytime


            ' begin combo box update
            cboModels.BeginUpdate()

            'code goes here.............................

            ' Build the select statement
            strSelect = "SELECT intAutoID, strModel FROM TAutos"


            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator) 'New command heres the SQL statement and heres the conection to the DB
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

        ' code goes here..........................

        ' Build the select statement using PK from name selected
        strSelect = "SELECT strMake, strModel, strYear, strMileage FROM TAutos WHERE intAutoID = " & cboModels.SelectedValue.ToString


        ' Retrieve all the records
        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
        drSourceTable = cmdSelect.ExecuteReader


        ' load the data table from the reader
        dt.Load(drSourceTable)


        ' populate the text boxes with the data
        txtModel.Text = dt.Rows(0).Item(0).ToString
        txtMake.Text = dt.Rows(0).Item(1).ToString
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


        Dim strUpdate As String = ""
        Dim strMake As String = ""
        Dim strModel As String = ""
        Dim strYear As String = ""
        Dim strMileage As String = ""
        Dim intRowsAffected As Integer

        ' thie will hold our Update statement
        Dim cmdUpdate As OleDb.OleDbCommand

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



        ' code goes here.................................

        ' Build the select statement using PK from name selected
        strUpdate = "UPDATE TAutos SET strMake = '" & strMake & "', strModel = '" & strModel & "', strYear = '" & strYear & "', strMileage = '" & strMileage & "'" & _
            " WHERE intAutoID = " & cboModels.SelectedValue.ToString

        MessageBox.Show(strUpdate)

        ' execute the statement
        cmdUpdate = New OleDb.OleDbCommand(strUpdate, m_conAdministrator)


        ' have to let the user know what happened 
        intRowsAffected = cmdUpdate.ExecuteNonQuery

        If intRowsAffected > 0 Then
            MessageBox.Show("Update successful!")
        Else
            MessageBox.Show("Update failed :(")
        End If


        ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub



End Class
