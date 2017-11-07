' ********************************************************************************
' Name: Nick Regan
' Date: 11/19/2016
' Class: IT-101-200
' Abstract: Assignment 14 Falling Distance
' **********************************************************************************

Option Strict On


Public Class Form1

    Dim blnOK As Boolean = False

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTime.Clear()
        lblFallingDistance.ResetText()

        txtTime.BackColor = Color.White

    End Sub

    Private Sub btnCalculateDistance_Click(sender As Object, e As EventArgs) Handles btnCalculateDistance.Click

        Dim dblTime As Double
        Dim dblFallingDistance As Double

        Try

            Call Validation(dblTime)

            If blnOK = True Then
                ' Do calculation by adding numbers
                dblFallingDistance = FallingDistance(dblTime)

                Display(dblFallingDistance.ToString)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Validation(ByRef Time As Double)
        If IsNumeric(txtTime.Text) Then
            Time = CDbl(txtTime.Text)
        Else
            MessageBox.Show("Please enter the amount of time, in seconds, that your object has fallen.")
            txtTime.Focus()
            txtTime.BackColor = Color.Yellow
            blnOK = False
            Exit Sub
        End If

        If Time < 0 Then
            MessageBox.Show("Please enter a number greater than or equal to 0.")
            txtTime.Focus()
            txtTime.BackColor = Color.Yellow
            blnOK = False
            Exit Sub
        End If

        blnOK = True

    End Sub

    Private Function FallingDistance(ByVal Time As Double) As Double
        Const dblGravity As Double = 9.8
        Dim dblDistance As Double

        dblDistance = 0.5 * (dblGravity) * (Time * Time)

        Return dblDistance

    End Function

    Private Sub Display(ByVal DistanceOutput As String)

        lblFallingDistance.Text = DistanceOutput

    End Sub

End Class
