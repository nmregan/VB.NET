' ********************************************************************************
' Name: Nick Regan
' Class: IT-102-001
' Abstract: Assignment #5 - Theater Seating Reservation
' ********************************************************************************

Option Strict On
Option Explicit On

Public Class frmSplash
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents tmrClose As System.Windows.Forms.Timer
    Friend WithEvents lblName As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrClose = New System.Windows.Forms.Timer(Me.components)
        Me.lblName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrClose
        '
        Me.tmrClose.Enabled = True
        Me.tmrClose.Interval = 5000
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.Azure
        Me.lblName.Location = New System.Drawing.Point(64, 114)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(360, 120)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Theater Seating"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSplash
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(488, 349)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' Close the form when the Timer's Tick event fires.
    Private Sub tmrClose_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClose.Tick

        Me.Close()

    End Sub

   
End Class
