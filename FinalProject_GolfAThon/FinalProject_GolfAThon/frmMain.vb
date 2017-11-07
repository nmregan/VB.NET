' ********************************************************************************
' Name: Nick Regan
' Class: IT-102-001
' Abstract: Final Project - Golf-A-Thon
' ********************************************************************************

Option Strict On

Public Class frmMain

    
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            cboEventYears.BeginUpdate()

            ' Clear out the list
            'cboNames.Items.Clear()

            ' Build the select statement
            strSelect = "SELECT intEventYearID, intEventYear FROM VYearTotals"

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

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try

    End Sub


    Private Sub btnManageGolfers_Click(sender As Object, e As EventArgs) Handles btnManageGolfers.Click

        frmGolfers.ShowDialog()

        frmMain_Load(sender, e)

    End Sub


    Private Sub btnManageSponsors_Click(sender As Object, e As EventArgs) Handles btnManageSponsors.Click

        frmSponsors.ShowDialog()

        frmMain_Load(sender, e)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    
    Private Sub btnTotalEventYear_Click(sender As Object, e As EventArgs) Handles btnTotalEventYear.Click

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
            strSelect = "SELECT YearTotals FROM VYearTotals Where intEventYearID = " & cboEventYears.SelectedValue.ToString

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load the data table from the reader
            dt.Load(drSourceTable)

            ' populate the text boxes with the data
            lblEventYearTotal.Text = dt.Rows(0).Item(0).ToString

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try


    End Sub
End Class
