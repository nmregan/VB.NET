Option Strict On

Public Class frmMain

    Private Sub MercuryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MercuryToolStripMenuItem.Click

        Dim frmNewMercury As New frmMercury
        frmNewMercury.ShowDialog()

    End Sub

    Private Sub VenusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VenusToolStripMenuItem.Click

        Dim frmNewVenus As New frmVenus
        frmNewVenus.ShowDialog()

    End Sub

    Private Sub EarthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EarthToolStripMenuItem.Click

        Dim frmNewEarth As New frmEarth
        frmNewEarth.ShowDialog()

    End Sub

    Private Sub MarsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarsToolStripMenuItem.Click

        Dim frmNewMars As New frmMars
        frmNewMars.ShowDialog()

    End Sub

    Private Sub JupiterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JupiterToolStripMenuItem.Click

        Dim frmNewJupiter As New frmJupiter
        frmNewJupiter.ShowDialog()

    End Sub

    Private Sub SaturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaturnToolStripMenuItem.Click

        Dim frmNewSaturn As New frmSaturn
        frmNewSaturn.ShowDialog()

    End Sub

    Private Sub UranusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UranusToolStripMenuItem.Click

        Dim frmNewUranus As New frmUranus
        frmNewUranus.ShowDialog()

    End Sub

    Private Sub NeptuneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeptuneToolStripMenuItem.Click

        Dim frmNewNeptune As New frmNeptune
        frmNewNeptune.ShowDialog()

    End Sub

    Private Sub PlutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlutoToolStripMenuItem.Click

        Dim frmNewPluto As New frmPluto
        frmNewPluto.ShowDialog()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

End Class
