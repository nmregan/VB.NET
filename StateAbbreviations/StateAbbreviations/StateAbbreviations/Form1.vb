' ***************************************************
' Name: Nick Regan
' Date: 9/15/2016
' Abstract: Assignment 4
' ***************************************************




Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblOutput.ResetText()

    End Sub

    Private Sub btnVirginia_Click(sender As Object, e As EventArgs) Handles btnVirginia.Click
        lblOutput.Text = "VA"

    End Sub

    Private Sub btnNorthCarolina_Click(sender As Object, e As EventArgs) Handles btnNorthCarolina.Click
        lblOutput.Text = "NC"
    End Sub

    Private Sub btnSouthCarolina_Click(sender As Object, e As EventArgs) Handles btnSouthCarolina.Click
        lblOutput.Text = "SC"
    End Sub

    Private Sub btnGeorgia_Click(sender As Object, e As EventArgs) Handles btnGeorgia.Click
        lblOutput.Text = "GA"
    End Sub

    Private Sub btnAlabama_Click(sender As Object, e As EventArgs) Handles btnAlabama.Click
        lblOutput.Text = "AL"
    End Sub

    Private Sub btnFlorida_Click(sender As Object, e As EventArgs) Handles btnFlorida.Click
        lblOutput.Text = "FL"
    End Sub
End Class
