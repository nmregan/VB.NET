' ********************************************************************************
' Name: Nick Regan
' Class: IT-102-001
' Abstract: Assignment #2 - Cell Phone Package
' **********************************************************************************

Option Strict On

Public Class frmMain

    Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click

        ' show the Individual Plan form
        Dim frmIndividual As New frmIndividualPlan
        frmIndividual.ShowDialog()

    End Sub

    Private Sub btnFamily_Click(sender As Object, e As EventArgs) Handles btnFamily.Click

        ' show the Family Plan form
        Dim frmFamily As New frmFamilyPlan
        frmFamily.ShowDialog()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

End Class
