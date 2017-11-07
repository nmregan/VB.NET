' ********************************************************************************
' Name: Nick Regan
' Date: 11/23/2016
' Class: IT-101-200
' Abstract: Assignment 15 Sum of Numbers
' **********************************************************************************

Option Strict On


Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnterNumbers.Click

        Try

            Dim intSum As Integer = 0
            Dim strResult As String
            Dim intNumber As Integer
            Dim intCounter As Integer


            strResult = InputBox("Enter a positive integer value ", "Enter Numbers", "10")

            'validate strResult
            'if strResult validates assign it to intNumber

            If Validation(strResult, intNumber) = True Then
                Do While intCounter <= intNumber
                    intSum += intCounter
                    intCounter += 1
                Loop
                MessageBox.Show("The Sum of Numbers 1 through " & intNumber.ToString & " is " & intSum.ToString)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Function Validation(ByVal Number As String, ByRef Answer As Integer) As Boolean
        If IsNumeric(Number) Then
            Answer = CInt(Number)
        Else
            MessageBox.Show("Please enter a positive integer value.")
            Return False
        End If

        Return True

        If CInt(Number) < 0 Then
            MessageBox.Show("Please enter an integer greater than 0.")
            Return False
        End If

        Return True

    End Function

End Class
