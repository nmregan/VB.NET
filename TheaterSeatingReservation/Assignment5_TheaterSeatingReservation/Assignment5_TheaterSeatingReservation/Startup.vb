' ********************************************************************************
' Name: Nick Regan
' Class: IT-102-001
' Abstract: Assignment #5 - Theater Seating Reservation
' ********************************************************************************

Option Strict On
Option Explicit On 

' This module is designated as the startup model. Thus, the statements
' in the Sub Main procedure will execute when the program starts. 
Module Startup

    Public Sub Main()
        Dim frmSplashNew As New frmSplash()

        Dim frmMainNew As New frmSeating
        frmSplashNew.ShowDialog()
        frmMainNew.ShowDialog()
    End Sub

End Module
