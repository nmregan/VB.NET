' ********************************************************************************
' Name: Nick Regan
' Class: IT-102-001
' Abstract: Assignment #4 - Student Test Scores
' **********************************************************************************

Option Strict On

Structure Tests
    Dim strName As String           ' To hold a name
    Dim dblTestScores() As Double   ' To hold 3 test scores
    Dim dblAverages As Double       ' To hold test averages
End Structure

Public Class Form1
    Dim blnValidation As Boolean = False

    Dim Students() As Tests

    Private Sub btnCalculateAverages_Click(sender As Object, e As EventArgs) Handles btnCalculateAverages.Click

        Dim dblStudent1Average As Double
        Dim dblStudent2Average As Double
        Dim dblStudent3Average As Double
        Dim dblTest1Score As Double
        Dim dblTest2Score As Double
        Dim dblTest3Score As Double
        Dim dblTest4Score As Double
        Dim dblTest5Score As Double
        Dim dblTest6Score As Double
        Dim dblTest7Score As Double
        Dim dblTest8Score As Double
        Dim dblTest9Score As Double

        Dim intCounter As Integer

        txtTest1.BackColor = Color.White
        txtTest2.BackColor = Color.White
        txtTest3.BackColor = Color.White
        txtTest4.BackColor = Color.White
        txtTest5.BackColor = Color.White
        txtTest6.BackColor = Color.White
        txtTest7.BackColor = Color.White
        txtTest8.BackColor = Color.White
        txtTest9.BackColor = Color.White
        txtName1.BackColor = Color.White
        txtName2.BackColor = Color.White
        txtName3.BackColor = Color.White


        Try

            NameValidation()

            TestValidation(dblTest1Score, dblTest2Score, dblTest3Score, dblTest4Score, dblTest5Score, dblTest6Score, dblTest7Score, dblTest8Score, dblTest9Score)

            If blnValidation = True Then

                Do Until intCounter = 3

                    ReDim Preserve Students(intCounter)

                    For i = 0 To 2
                        ReDim Preserve Students(intCounter).dblTestScores(i)
                    Next

                    LoadData(intCounter)

                    intCounter += 1

                Loop

                dblStudent1Average = CalculateStudent1Average(dblStudent1Average)
                dblStudent2Average = CalculateStudent2Average(dblStudent2Average)
                dblStudent3Average = CalculateStudent3Average(dblStudent3Average)

                DisplayAverages(dblStudent1Average, dblStudent2Average, dblStudent3Average)



                SaveData()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub LoadData(ByVal Index As Integer)

        ' Load data from file

        Select Case Index
            Case 0
                Students(Index).strName = txtName1.Text
                Students(Index).dblTestScores(Index) = CDbl(txtTest1.Text)
                Students(Index).dblTestScores(Index + 1) = CDbl(txtTest2.Text)
                Students(Index).dblTestScores(Index + 2) = CDbl(txtTest3.Text)

            Case 1
                Students(Index).strName = txtName2.Text
                Students(Index).dblTestScores(Index - 1) = CDbl(txtTest4.Text)
                Students(Index).dblTestScores(Index) = CDbl(txtTest5.Text)
                Students(Index).dblTestScores(Index + 1) = CDbl(txtTest6.Text)

            Case 2
                Students(Index).strName = txtName2.Text
                Students(Index).dblTestScores(Index - 2) = CDbl(txtTest7.Text)
                Students(Index).dblTestScores(Index - 1) = CDbl(txtTest8.Text)
                Students(Index).dblTestScores(Index) = CDbl(txtTest9.Text)

        End Select

    End Sub

    Private Sub TestValidation(ByRef Test1Score As Double, ByRef Test2Score As Double, ByRef Test3Score As Double, ByRef Test4Score As Double, ByRef Test5Score As Double, ByRef Test6Score As Double, ByRef Test7Score As Double, ByRef Test8Score As Double, ByRef Test9Score As Double)
        If IsNumeric(txtTest1.Text) Then
            Test1Score = CDbl(txtTest1.Text)
        Else
            MessageBox.Show("Please enter a number for test score.")
            txtTest1.Focus()
            txtTest1.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If Test1Score < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for test score.")
            txtTest1.Focus()
            txtTest1.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If IsNumeric(txtTest2.Text) Then
            Test2Score = CDbl(txtTest2.Text)
        Else
            MessageBox.Show("Please enter a number for test score.")
            txtTest2.Focus()
            txtTest2.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If Test2Score < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for test score.")
            txtTest2.Focus()
            txtTest2.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If IsNumeric(txtTest3.Text) Then
            Test3Score = CDbl(txtTest3.Text)
        Else
            MessageBox.Show("Please enter a number for test score.")
            txtTest3.Focus()
            txtTest3.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If Test3Score < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for test score.")
            txtTest3.Focus()
            txtTest3.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If IsNumeric(txtTest4.Text) Then
            Test4Score = CDbl(txtTest4.Text)
        Else
            MessageBox.Show("Please enter a number for test score.")
            txtTest4.Focus()
            txtTest4.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If Test4Score < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for test score.")
            txtTest4.Focus()
            txtTest4.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If IsNumeric(txtTest5.Text) Then
            Test5Score = CDbl(txtTest5.Text)
        Else
            MessageBox.Show("Please enter a number for test score.")
            txtTest5.Focus()
            txtTest5.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If Test5Score < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for test score.")
            txtTest5.Focus()
            txtTest5.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If IsNumeric(txtTest6.Text) Then
            Test6Score = CDbl(txtTest6.Text)
        Else
            MessageBox.Show("Please enter a number for test score.")
            txtTest6.Focus()
            txtTest6.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If Test6Score < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for test score.")
            txtTest6.Focus()
            txtTest6.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If IsNumeric(txtTest7.Text) Then
            Test7Score = CDbl(txtTest7.Text)
        Else
            MessageBox.Show("Please enter a number for test score.")
            txtTest7.Focus()
            txtTest7.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If Test7Score < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for test score.")
            txtTest7.Focus()
            txtTest7.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If Test6Score < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for test score.")
            txtTest6.Focus()
            txtTest6.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If IsNumeric(txtTest8.Text) Then
            Test8Score = CDbl(txtTest8.Text)
        Else
            MessageBox.Show("Please enter a number for test score.")
            txtTest8.Focus()
            txtTest8.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If Test8Score < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for test score.")
            txtTest8.Focus()
            txtTest8.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If IsNumeric(txtTest9.Text) Then
            Test9Score = CDbl(txtTest9.Text)
        Else
            MessageBox.Show("Please enter a number for test score.")
            txtTest9.Focus()
            txtTest9.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If Test9Score < 0 Then
            MessageBox.Show("Please enter a number greater than 0 for test score.")
            txtTest9.Focus()
            txtTest9.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If


        blnValidation = True


    End Sub

    Private Sub NameValidation()
        If txtName1.Text = "" Then
            MessageBox.Show("Please enter student's name.")
            txtName1.Focus()
            txtName1.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If txtName2.Text = "" Then
            MessageBox.Show("Please enter student's name.")
            txtName2.Focus()
            txtName2.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        If txtName3.Text = "" Then
            MessageBox.Show("Please enter student's name.")
            txtName3.Focus()
            txtName3.BackColor = Color.Yellow
            blnValidation = False
            Exit Sub
        End If

        blnValidation = True

    End Sub

    Function CalculateStudent1Average(ByRef dblStudent1Average As Double) As Double

        dblStudent1Average = ((CDbl(Students(0).dblTestScores(0) + Students(0).dblTestScores(1) + Students(0).dblTestScores(2))) / 3) / 100


        Return dblStudent1Average

    End Function

    Function CalculateStudent2Average(ByRef dblStudent2Average As Double) As Double

        dblStudent2Average = ((CDbl(Students(1).dblTestScores(0) + Students(1).dblTestScores(1) + Students(1).dblTestScores(2))) / 3) / 100


        Return dblStudent2Average

    End Function

    Function CalculateStudent3Average(ByRef dblStudent3Average As Double) As Double

        dblStudent3Average = ((CDbl(Students(2).dblTestScores(0) + Students(2).dblTestScores(1) + Students(2).dblTestScores(2))) / 3) / 100


        Return dblStudent3Average

    End Function

    Sub DisplayAverages(ByVal dblStudent1Average As Double, ByVal dblStudent2Average As Double, ByVal dblStudent3Average As Double)

        lblAverage1.Text = FormatPercent(CStr(dblStudent1Average))
        lblAverage2.Text = FormatPercent(CStr(dblStudent2Average))
        lblAverage3.Text = FormatPercent(CStr(dblStudent3Average))

    End Sub

    Private Sub SaveData()
        ' Declare the object StudentScores as an output file
        Dim StudentScores As System.IO.StreamWriter
        Dim strFileName As String = "testscores.txt"
        Dim intCounter As Integer

        Do Until intCounter = 3

            ReDim Preserve Students(intCounter)

            For i = 0 To 2
                ReDim Preserve Students(intCounter).dblTestScores(i)
            Next

            LoadData(intCounter)

            intCounter += 1

        Loop

        ' Check to see if the file exists. if the file <> exist then create a file
        StudentScores = System.IO.File.CreateText(strFileName)

        With StudentScores
            .WriteLine(Students(0).strName + "," & Students(0).dblTestScores(0).ToString & "," + Students(0).dblTestScores(1).ToString & "," + Students(0).dblTestScores(2).ToString)
            .WriteLine(Students(1).strName + "," & Students(1).dblTestScores(0).ToString & "," + Students(1).dblTestScores(1).ToString & "," + Students(0).dblTestScores(2).ToString)
            .WriteLine(Students(2).strName + "," & Students(2).dblTestScores(0).ToString & "," + Students(2).dblTestScores(1).ToString & "," + Students(0).dblTestScores(2).ToString)
            .Close()

        End With

        ' See if file exists, if it does show message data was saved.
        If System.IO.File.Exists(strFileName) Then
            MessageBox.Show("Data saved to file.")
        End If

    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        ' Save data to the file
        SaveData()

    End Sub

    Private Sub OpenJobData()
        Dim StudentData As System.IO.StreamReader
        Dim strFilename As String = "testscores.txt"
        Dim strStudentTestData As String
        Dim intIndex As Integer ' Will be used to manipulate the index of strStudentTestData
        Dim intCounter As Integer

        Try

            ' Check if files exists. if it does exist, it will open, otherwise pop a msg box
            If System.IO.File.Exists(strFilename) Then
                StudentData = System.IO.File.OpenText(strFilename)
                ' Loop through the file until no more records exist and read data from file
                ' Do Until CBool(testScores.Peek = -2)
                Do Until StudentData.Peek = -2

                    strStudentTestData = StudentData.ReadLine

                    ReDim Preserve Students(intCounter)

                    For i = 0 To 2
                        ReDim Preserve Students(intCounter).dblTestScores(i)
                    Next

                    intIndex = strStudentTestData.IndexOf(",")
                    Students(intCounter).strName = strStudentTestData.Substring(0, intIndex)
                    strStudentTestData = strStudentTestData.Remove(0, intIndex + 1)
                    intIndex = strStudentTestData.IndexOf(",")

                    Students(intCounter).dblTestScores(0) = CDbl(strStudentTestData.Substring(0, intIndex))
                    Students(intCounter).dblTestScores(1) = CDbl(strStudentTestData.Remove(0, intIndex + 1))
                    Students(intCounter).dblTestScores(2) = CDbl(strStudentTestData.Remove(0, intIndex + 2))

                    intCounter += 1

                Loop

                ' Close the file
                StudentData.Close()


            End If

            ' Load the data into the correct controls on form for viewing
            txtName1.Text = Students(0).strName
            txtTest1.Text = CStr(Students(0).dblTestScores(0))
            txtTest2.Text = CStr(Students(0).dblTestScores(1))
            txtTest3.Text = CStr(Students(0).dblTestScores(2))

            txtName2.Text = Students(1).strName
            txtTest4.Text = CStr(Students(1).dblTestScores(0))
            txtTest5.Text = CStr(Students(1).dblTestScores(1))
            txtTest6.Text = CStr(Students(1).dblTestScores(2))

            txtName2.Text = Students(2).strName
            txtTest7.Text = CStr(Students(2).dblTestScores(0))
            txtTest8.Text = CStr(Students(2).dblTestScores(1))
            txtTest9.Text = CStr(Students(2).dblTestScores(2))


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' Close the form
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear all controls
        txtName1.Clear()
        txtName2.Clear()
        txtName3.Clear()
        txtTest1.Clear()
        txtTest2.Clear()
        txtTest3.Clear()
        txtTest4.Clear()
        txtTest5.Clear()
        txtTest6.Clear()
        txtTest7.Clear()
        txtTest8.Clear()
        txtTest9.Clear()
        lblAverage1.ResetText()
        lblAverage2.ResetText()
        lblAverage3.ResetText()

        txtTest1.BackColor = Color.White
        txtTest2.BackColor = Color.White
        txtTest3.BackColor = Color.White
        txtTest4.BackColor = Color.White
        txtTest5.BackColor = Color.White
        txtTest6.BackColor = Color.White
        txtTest7.BackColor = Color.White
        txtTest8.BackColor = Color.White
        txtTest9.BackColor = Color.White
        txtName1.BackColor = Color.White
        txtName2.BackColor = Color.White
        txtName3.BackColor = Color.White

        txtName1.Focus()

    End Sub



End Class
