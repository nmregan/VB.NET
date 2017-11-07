' ********************************************************************************
' Name: Nick Regan
' Class: IT-102-001
' Abstract: Assignment #1 - Driver's Exam
' **********************************************************************************

Option Strict On

Public Class frmAnswers

    Private Sub frmAnswers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim astrCorrectAnswers() As String = {"B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A"}
        Dim intCorrect As Integer = 0
        Dim strResult As String = "Correct"

        lblCorrect1.Text = astrCorrectAnswers(0)
        lblCorrect2.Text = astrCorrectAnswers(1)
        lblCorrect3.Text = astrCorrectAnswers(2)
        lblCorrect4.Text = astrCorrectAnswers(3)
        lblCorrect5.Text = astrCorrectAnswers(4)
        lblCorrect6.Text = astrCorrectAnswers(5)
        lblCorrect7.Text = astrCorrectAnswers(6)
        lblCorrect8.Text = astrCorrectAnswers(7)
        lblCorrect9.Text = astrCorrectAnswers(8)
        lblCorrect10.Text = astrCorrectAnswers(9)
        lblCorrect11.Text = astrCorrectAnswers(10)
        lblCorrect12.Text = astrCorrectAnswers(11)
        lblCorrect13.Text = astrCorrectAnswers(12)
        lblCorrect14.Text = astrCorrectAnswers(13)
        lblCorrect15.Text = astrCorrectAnswers(14)
        lblCorrect16.Text = astrCorrectAnswers(15)
        lblCorrect17.Text = astrCorrectAnswers(16)
        lblCorrect18.Text = astrCorrectAnswers(17)
        lblCorrect19.Text = astrCorrectAnswers(18)
        lblCorrect20.Text = astrCorrectAnswers(19)

        lblGiven1.Text = astrGivenAnswers(0)
        lblGiven2.Text = astrGivenAnswers(1)
        lblGiven3.Text = astrGivenAnswers(2)
        lblGiven4.Text = astrGivenAnswers(3)
        lblGiven5.Text = astrGivenAnswers(4)
        lblGiven6.Text = astrGivenAnswers(5)
        lblGiven7.Text = astrGivenAnswers(6)
        lblGiven8.Text = astrGivenAnswers(7)
        lblGiven9.Text = astrGivenAnswers(8)
        lblGiven10.Text = astrGivenAnswers(9)
        lblGiven11.Text = astrGivenAnswers(10)
        lblGiven12.Text = astrGivenAnswers(11)
        lblGiven13.Text = astrGivenAnswers(12)
        lblGiven14.Text = astrGivenAnswers(13)
        lblGiven15.Text = astrGivenAnswers(14)
        lblGiven16.Text = astrGivenAnswers(15)
        lblGiven17.Text = astrGivenAnswers(16)
        lblGiven18.Text = astrGivenAnswers(17)
        lblGiven19.Text = astrGivenAnswers(18)
        lblGiven20.Text = astrGivenAnswers(19)

        For i = 0 To astrGivenAnswers.Length - 1
            If astrGivenAnswers(i) = astrCorrectAnswers(i) Then
                intCorrect += 1
                Result(i, strResult)
            End If
        Next

        If intCorrect > 15 Then
            lblResult.Text = "PASS"
            lblResult.ForeColor = Color.Blue
        Else
            lblResult.Text = "FAIL"
            lblResult.ForeColor = Color.Red
            End If

        Display(intCorrect)


    End Sub

    Sub Result(ByVal Index As Integer, ByVal Result As String)

        ' show the result and if correct
        Select Case Index
            Case 0
                lblResult1.Text = Result
                lblResult1.ForeColor = Color.Black
            Case 1
                lblResult2.Text = Result
                lblResult2.ForeColor = Color.Black
            Case 2
                lblResult3.Text = Result
                lblResult3.ForeColor = Color.Black
            Case 3
                lblResult4.Text = Result
                lblResult4.ForeColor = Color.Black
            Case 4
                lblResult5.Text = Result
                lblResult5.ForeColor = Color.Black
            Case 5
                lblResult6.Text = Result
                lblResult6.ForeColor = Color.Black
            Case 6
                lblResult7.Text = Result
                lblResult7.ForeColor = Color.Black
            Case 7
                lblResult8.Text = Result
                lblResult8.ForeColor = Color.Black
            Case 8
                lblResult9.Text = Result
                lblResult9.ForeColor = Color.Black
            Case 9
                lblResult10.Text = Result
                lblResult10.ForeColor = Color.Black
            Case 10
                lblResult11.Text = Result
                lblResult11.ForeColor = Color.Black
            Case 11
                lblResult12.Text = Result
                lblResult12.ForeColor = Color.Black
            Case 12
                lblResult13.Text = Result
                lblResult13.ForeColor = Color.Black
            Case 13
                lblResult14.Text = Result
                lblResult14.ForeColor = Color.Black
            Case 14
                lblResult15.Text = Result
                lblResult15.ForeColor = Color.Black
            Case 15
                lblResult16.Text = Result
                lblResult16.ForeColor = Color.Black
            Case 16
                lblResult17.Text = Result
                lblResult17.ForeColor = Color.Black
            Case 17
                lblResult18.Text = Result
                lblResult18.ForeColor = Color.Black
            Case 18
                lblResult19.Text = Result
                lblResult19.ForeColor = Color.Black
            Case 19
                lblResult20.Text = Result
                lblResult20.ForeColor = Color.Black
        End Select

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

        frmExam.Clearstuff()

    End Sub

    Sub Display(ByVal Correct As Integer)

        ' Show number of correct answers

        lblCorrect.Text = Correct & " / " & astrGivenAnswers.Length

    End Sub

End Class