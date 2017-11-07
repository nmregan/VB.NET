' ********************************************************************************
' Name: Nick Regan
' Class: IT-102-001
' Abstract: Assignment #5 - Theater Seating Reservation
' ********************************************************************************

Option Explicit On 
Option Strict On

Public Class frmSeating
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

       
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
    Friend WithEvents lblFull As System.Windows.Forms.Label
    Friend WithEvents lblEmpty As System.Windows.Forms.Label
    Friend WithEvents pnlSeats As System.Windows.Forms.Panel
    Friend WithEvents lblPromptFull As System.Windows.Forms.Label
    Friend WithEvents lblPromptEmpty As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeatsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblFull = New System.Windows.Forms.Label()
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.pnlSeats = New System.Windows.Forms.Panel()
        Me.lblPromptFull = New System.Windows.Forms.Label()
        Me.lblPromptEmpty = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFull
        '
        Me.lblFull.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFull.Location = New System.Drawing.Point(249, 24)
        Me.lblFull.Name = "lblFull"
        Me.lblFull.Size = New System.Drawing.Size(56, 16)
        Me.lblFull.TabIndex = 1
        '
        'lblEmpty
        '
        Me.lblEmpty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmpty.Location = New System.Drawing.Point(249, 48)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(56, 16)
        Me.lblEmpty.TabIndex = 2
        '
        'pnlSeats
        '
        Me.pnlSeats.AutoScroll = True
        Me.pnlSeats.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlSeats.Location = New System.Drawing.Point(0, 137)
        Me.pnlSeats.Name = "pnlSeats"
        Me.pnlSeats.Size = New System.Drawing.Size(317, 376)
        Me.pnlSeats.TabIndex = 3
        '
        'lblPromptFull
        '
        Me.lblPromptFull.Location = New System.Drawing.Point(189, 24)
        Me.lblPromptFull.Name = "lblPromptFull"
        Me.lblPromptFull.Size = New System.Drawing.Size(56, 16)
        Me.lblPromptFull.TabIndex = 4
        Me.lblPromptFull.Text = "Full"
        Me.lblPromptFull.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPromptEmpty
        '
        Me.lblPromptEmpty.Location = New System.Drawing.Point(193, 48)
        Me.lblPromptEmpty.Name = "lblPromptEmpty"
        Me.lblPromptEmpty.Size = New System.Drawing.Size(56, 16)
        Me.lblPromptEmpty.TabIndex = 5
        Me.lblPromptEmpty.Text = "Empty"
        Me.lblPromptEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SeatsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(317, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SeatsToolStripMenuItem
        '
        Me.SeatsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem})
        Me.SeatsToolStripMenuItem.Name = "SeatsToolStripMenuItem"
        Me.SeatsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.SeatsToolStripMenuItem.Text = "Seats"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(297, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "     1        2        3        4       5       6        7       8        9      " & _
    " 10"
        '
        'frmSeating
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(334, 509)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPromptEmpty)
        Me.Controls.Add(Me.lblPromptFull)
        Me.Controls.Add(Me.pnlSeats)
        Me.Controls.Add(Me.lblEmpty)
        Me.Controls.Add(Me.lblFull)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSeating"
        Me.Text = "Seating Chart"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    ' Declare two dynamic arrays to store the created CheckBox and Label
    ' control instances. The array named chkSeats is a 2-dimensional array
    ' and the array lblRow is a one dimensional array.
    Private chkSeats(,) As System.Windows.Forms.CheckBox
    Private lblRow() As System.Windows.Forms.Label

    ' The following constants improve readibility by defining the
    ' standard size of each check box, and the number of seats and rows
    ' for each airplane type.
    Private Const cintCheckBoxHeight As Integer = 28
    Private Const cintCheckBoxWidth As Integer = 28

    Private Const cintTheaterSeats As Integer = 10
    Private Const cintTheaterRows As Integer = 25


    ' The variables mintFull and mintEmpty store the number of
    ' occupied and empty seats on the airplane.
    Private mintFull As Integer
    Private mintEmpty As Integer

    ' pntCurrent is used to create a Point structure.
    Private pntCurrent As System.Drawing.Point

    ' All of the work takes place in the ConfigureSeating procedure. This
    ' procedure is called by the constructor. See the New procedure in the
    ' Windows Form Designer generated code.
    Private Sub ConfigureSeating()

        ' Variables to store the current seat and the current row.
        Dim pintSeatCurrent, pintRowCurrent As Integer

        ' The Select Case statement configures the airplane based on the
        ' type of airplane. This value is passed to the procedure, and is
        ' obtained from the argument passed through the constructor.

        ' Redimension the arrays containing the check boxes and 
        ' labels based on the current airplane configuration.
        ReDim chkSeats(cintTheaterSeats, cintTheaterRows)
        ReDim lblRow(cintTheaterRows)

        ' Define the number of empty seats.
        mintEmpty = cintTheaterSeats * cintTheaterRows

        ' Create each check box representing a seat.
        For pintSeatCurrent = 0 To cintTheaterSeats - 1
            For pintRowCurrent = 0 To cintTheaterRows - 1
                pntCurrent = New Point((pintSeatCurrent + 1) * cintCheckBoxWidth, _
                    (pintRowCurrent + 1) * cintCheckBoxHeight)
                Call CreateCheckBox(pintSeatCurrent, pintRowCurrent, pntCurrent)
            Next
        Next

        ' Create the labels to identify the rows.
        For pintRowCurrent = 0 To cintTheaterRows - 1
            Call CreateLabel(pintRowCurrent)
            lblRow(pintRowCurrent).Left = 120
            lblRow(pintRowCurrent).Top = (pintRowCurrent + 1) * cintCheckBoxHeight
            lblRow(pintRowCurrent).Height = 15
            lblRow(pintRowCurrent).Width = 25
        Next



    End Sub

    ' The CreateCheckBox procedure is responsible for actually creating
    ' each CheckBox control instance and adding a reference to the array.
    ' The current seat and row are passed as arguments, along with the 
    ' position of the check box.
    Private Sub CreateCheckBox(ByVal pintSeatCurrent As Integer, ByVal pintRowcurrent As Integer, ByVal pnt As Point)

        ' Create an instance of the CheckBox control and make it visible.
        chkSeats(pintSeatCurrent, pintRowcurrent) = New CheckBox()
        chkSeats(pintSeatCurrent, pintRowcurrent).Visible = True

        ' Define the size of the CheckBox control instance by creating an 
        ' instance of the Size structure and assigning a value to the Size
        ' property.
        chkSeats(pintSeatCurrent, pintRowcurrent).Size = _
            New System.Drawing.Size(cintCheckBoxWidth, cintCheckBoxHeight)

        ' Define the position of the CheckBox control instance.
        chkSeats(pintSeatCurrent, pintRowcurrent).Location = pnt

        ' Add the event handler for the newly created CheckBox control instance. 
        ' The procedure named chkSeats_CheckChanged will handle the CheckedChanged event for
        ' all of the created check boxes.
        AddHandler chkSeats(pintSeatCurrent, pintRowcurrent).CheckedChanged, _
            AddressOf chkseats_CheckedChanged

        ' Finally, add the newly creted CheckBox control instance to the Controls 
        ' collection for the Panel. Note that by adding the control instance to the
        ' Controls collection of the Panel rather than the form, the control instances
        ' will be contained by the Panel. The reason is simple. The CheckBox control
        ' instances will scroll with the Panel instead of the form.
        Me.pnlSeats.Controls.Add(chkSeats(pintSeatCurrent, pintRowcurrent))
    End Sub

    ' The CreateLabel procedure is responsible for actually creating each
    ' Label control instance and adding a reference to the array.
    Private Sub CreateLabel(ByVal pintRowCurrent As Integer)
        lblRow(pintRowCurrent) = New Label()
        lblRow(pintRowCurrent).Visible = True
        lblRow(pintRowCurrent).Text = (pintRowCurrent + 1).ToString()
        Me.pnlSeats.Controls.Add(lblRow(pintRowCurrent))
    End Sub

    ' The CheckedChanged event handler is a multicast event handler and
    ' handles the CheckedChanged event for all of the CheckBox control instances.
    ' The statements in the event handler update the number of full or empty
    ' seats on the airplane.
    Private Sub chkseats_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ' Declare a varible to store the CheckBox.
        Dim chkCurrent As System.Windows.Forms.CheckBox

        ' Again, because sender is of type System.Object, explicitly convert
        ' the argument to a check box using the CType function
        chkCurrent = CType(sender, System.Windows.Forms.CheckBox)

        ' If the check box is checked, increment the number of occupied seats
        ' and decrement the number of empty seats. If the check box is not checked,
        ' then do the reverse.
        Select Case chkCurrent.Checked
            Case True
                mintFull += 1
                mintEmpty -= 1
            Case False
                mintFull -= 1
                mintEmpty += 1
        End Select

        ' Display the results in the labels.
        lblFull.Text = mintFull.ToString()
        lblEmpty.Text = mintEmpty.ToString()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub

    ' Uncheck all of the check boxes by enumerating the Controls collection
    ' of the Panel.

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Dim ctlCurrent As Control
        Dim chkCurrent As CheckBox

        ' The For Each loop enumerates the Controls collection for the 
        ' Panel rather than the form.
        For Each ctlCurrent In pnlSeats.Controls
            ' Check that the type of the control instance is a CheckBox. 
            ' Labels are also contained by the Panel. If the control instance
            ' is a CheckBox, then remove the check mark by setting the Checked property
            ' to False.
            If TypeOf (ctlCurrent) Is System.Windows.Forms.CheckBox Then
                chkCurrent = CType(ctlCurrent, System.Windows.Forms.CheckBox)
                chkCurrent.Checked = False
            End If
        Next
        lblFull.Text = ""
        lblEmpty.Text = ""
    End Sub

    Private Sub frmSeating_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConfigureSeating()

    End Sub
End Class
