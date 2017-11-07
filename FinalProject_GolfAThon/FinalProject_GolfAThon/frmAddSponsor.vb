

Option Strict On


Public Class frmAddSponsor

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnAddNewSponsor.Click

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

                strSelect = "SELECT MAX(intSponsorID) + 1 AS intNextHighestRecordID " & _
                        " FROM TSponsors"

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

                strInsert = "Insert into TSponsors (intSponsorID, strFirstName, strLastName, strStreetAddress, strCity, strState, strZip, strPhoneNumber, strEmail)" & _
                " Values (" & intNextHighestRecordID & ",'" & strFirstName & "'," & "'" & strLastName & "'," & "'" & strStreetAddress & "'," & "'" & strCity & "'," & "'" & strState & "'," & "'" & strZip & "'," & "'" & strPhoneNumber & "'," & "'" & strEmail & "')"

                cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)


                intRowsAffected = cmdInsert.ExecuteNonQuery()

                If intRowsAffected > 0 Then
                    MessageBox.Show("Sponsor has been added")
                    Me.Close()
                End If


                CloseDatabaseConnection()


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