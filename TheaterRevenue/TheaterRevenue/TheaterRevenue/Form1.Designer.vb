<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAdultTicketSold = New System.Windows.Forms.TextBox()
        Me.txtAdultTicketPrice = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtChildTicketSold = New System.Windows.Forms.TextBox()
        Me.txtChildTicketPrice = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotalGrossRevenue = New System.Windows.Forms.Label()
        Me.lblGrossChildTicketSales = New System.Windows.Forms.Label()
        Me.lblGrossAdultTicketSales = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotalNetRevenue = New System.Windows.Forms.Label()
        Me.lblNetChildTicketSales = New System.Windows.Forms.Label()
        Me.lblNetAdultTicketSales = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnCalcTickRev = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtAdultTicketSold)
        Me.GroupBox1.Controls.Add(Me.txtAdultTicketPrice)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adult Ticket Sales"
        '
        'txtAdultTicketSold
        '
        Me.txtAdultTicketSold.Location = New System.Drawing.Point(128, 53)
        Me.txtAdultTicketSold.Name = "txtAdultTicketSold"
        Me.txtAdultTicketSold.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultTicketSold.TabIndex = 3
        '
        'txtAdultTicketPrice
        '
        Me.txtAdultTicketPrice.Location = New System.Drawing.Point(128, 27)
        Me.txtAdultTicketPrice.Name = "txtAdultTicketPrice"
        Me.txtAdultTicketPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtAdultTicketPrice.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tickets Sold:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Price per Ticket:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtChildTicketSold)
        Me.GroupBox2.Controls.Add(Me.txtChildTicketPrice)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(330, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(264, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Child Ticket Sales"
        '
        'txtChildTicketSold
        '
        Me.txtChildTicketSold.Location = New System.Drawing.Point(128, 53)
        Me.txtChildTicketSold.Name = "txtChildTicketSold"
        Me.txtChildTicketSold.Size = New System.Drawing.Size(100, 20)
        Me.txtChildTicketSold.TabIndex = 7
        '
        'txtChildTicketPrice
        '
        Me.txtChildTicketPrice.Location = New System.Drawing.Point(128, 27)
        Me.txtChildTicketPrice.Name = "txtChildTicketPrice"
        Me.txtChildTicketPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtChildTicketPrice.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tickets Sold:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Price per Ticket:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblTotalGrossRevenue)
        Me.GroupBox3.Controls.Add(Me.lblGrossChildTicketSales)
        Me.GroupBox3.Controls.Add(Me.lblGrossAdultTicketSales)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 142)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Gross Ticket Revenue"
        '
        'lblTotalGrossRevenue
        '
        Me.lblTotalGrossRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalGrossRevenue.Location = New System.Drawing.Point(144, 99)
        Me.lblTotalGrossRevenue.Name = "lblTotalGrossRevenue"
        Me.lblTotalGrossRevenue.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalGrossRevenue.TabIndex = 5
        '
        'lblGrossChildTicketSales
        '
        Me.lblGrossChildTicketSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossChildTicketSales.Location = New System.Drawing.Point(144, 59)
        Me.lblGrossChildTicketSales.Name = "lblGrossChildTicketSales"
        Me.lblGrossChildTicketSales.Size = New System.Drawing.Size(100, 23)
        Me.lblGrossChildTicketSales.TabIndex = 4
        '
        'lblGrossAdultTicketSales
        '
        Me.lblGrossAdultTicketSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrossAdultTicketSales.Location = New System.Drawing.Point(144, 21)
        Me.lblGrossAdultTicketSales.Name = "lblGrossAdultTicketSales"
        Me.lblGrossAdultTicketSales.Size = New System.Drawing.Size(100, 23)
        Me.lblGrossAdultTicketSales.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(20, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 30)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Gross Revenue for Ticket Sales:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Child Ticket Sales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Adult Ticket Sales:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotalNetRevenue)
        Me.GroupBox4.Controls.Add(Me.lblNetChildTicketSales)
        Me.GroupBox4.Controls.Add(Me.lblNetAdultTicketSales)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Location = New System.Drawing.Point(330, 127)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(264, 142)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Net Ticket Revenue"
        '
        'lblTotalNetRevenue
        '
        Me.lblTotalNetRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalNetRevenue.Location = New System.Drawing.Point(140, 99)
        Me.lblTotalNetRevenue.Name = "lblTotalNetRevenue"
        Me.lblTotalNetRevenue.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalNetRevenue.TabIndex = 11
        '
        'lblNetChildTicketSales
        '
        Me.lblNetChildTicketSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetChildTicketSales.Location = New System.Drawing.Point(140, 59)
        Me.lblNetChildTicketSales.Name = "lblNetChildTicketSales"
        Me.lblNetChildTicketSales.Size = New System.Drawing.Size(100, 23)
        Me.lblNetChildTicketSales.TabIndex = 10
        '
        'lblNetAdultTicketSales
        '
        Me.lblNetAdultTicketSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetAdultTicketSales.Location = New System.Drawing.Point(140, 21)
        Me.lblNetAdultTicketSales.Name = "lblNetAdultTicketSales"
        Me.lblNetAdultTicketSales.Size = New System.Drawing.Size(100, 23)
        Me.lblNetAdultTicketSales.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(25, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 30)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Total Net Revenue for Ticket Sales:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(38, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 13)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "Child Ticket Sales:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(38, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Adult Ticket Sales:"
        '
        'btnCalcTickRev
        '
        Me.btnCalcTickRev.Location = New System.Drawing.Point(64, 309)
        Me.btnCalcTickRev.Name = "btnCalcTickRev"
        Me.btnCalcTickRev.Size = New System.Drawing.Size(155, 23)
        Me.btnCalcTickRev.TabIndex = 4
        Me.btnCalcTickRev.Text = "&Calculate Ticket Revenue"
        Me.btnCalcTickRev.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(289, 309)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(467, 309)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalcTickRev
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(606, 370)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcTickRev)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Theater Revenue"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCalcTickRev As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtAdultTicketSold As System.Windows.Forms.TextBox
    Friend WithEvents txtAdultTicketPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChildTicketSold As System.Windows.Forms.TextBox
    Friend WithEvents txtChildTicketPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTotalGrossRevenue As System.Windows.Forms.Label
    Friend WithEvents lblGrossChildTicketSales As System.Windows.Forms.Label
    Friend WithEvents lblGrossAdultTicketSales As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalNetRevenue As System.Windows.Forms.Label
    Friend WithEvents lblNetChildTicketSales As System.Windows.Forms.Label
    Friend WithEvents lblNetAdultTicketSales As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
