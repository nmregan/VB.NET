' ********************************************************************************
' Name: Nick Regan
' Class: IT-102-001
' Abstract: Assignment #1 - Driver's Exam
' **********************************************************************************

Option Strict On

Public Class frmExam

    Private Sub btnSubmitExam_Click(sender As Object, e As EventArgs) Handles btnSubmitExam.Click

        Try

        If Validation() = True Then
            ' show the second form
            Dim frmNewAnswers As New frmAnswers
                frmNewAnswers.ShowDialog()

                txtInput1.Focus()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Function Validation() As Boolean

        For Each ctrl As Control In Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.BackColor = Color.White
                ctrl.Text = ctrl.Text.ToUpper
                If ctrl.Text = "A" Or ctrl.Text = "B" Or ctrl.Text = "C" Or ctrl.Text = "D" Then
                    If ctrl.Name.EndsWith("1") Then
                        astrGivenAnswers(0) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("2") Then
                        astrGivenAnswers(1) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("3") Then
                        astrGivenAnswers(2) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("4") Then
                        astrGivenAnswers(3) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("5") Then
                        astrGivenAnswers(4) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("6") Then
                        astrGivenAnswers(5) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("7") Then
                        astrGivenAnswers(6) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("8") Then
                        astrGivenAnswers(7) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("9") Then
                        astrGivenAnswers(8) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("0") Then
                        astrGivenAnswers(9) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("A") Then
                        astrGivenAnswers(10) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("B") Then
                        astrGivenAnswers(11) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("C") Then
                        astrGivenAnswers(12) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("D") Then
                        astrGivenAnswers(13) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("E") Then
                        astrGivenAnswers(14) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("F") Then
                        astrGivenAnswers(15) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("G") Then
                        astrGivenAnswers(16) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("H") Then
                        astrGivenAnswers(17) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("I") Then
                        astrGivenAnswers(18) = ctrl.Text
                    ElseIf ctrl.Name.EndsWith("J") Then
                        astrGivenAnswers(19) = ctrl.Text
                    End If
                Else
                    MessageBox.Show("Please enter A,B,C or D only.")
                    ctrl.BackColor = Color.Yellow
                    Return False
                End If
            End If
        Next

        Return True

    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Clearstuff()

    End Sub

    Sub Clearstuff()

        ' clear out the text boxes
        For Each ctrl As Control In Controls
            If TypeOf (ctrl) Is TextBox Then
                ctrl.Text = String.Empty
            End If
        Next

        txtInput1.Focus()

    End Sub


End Class
