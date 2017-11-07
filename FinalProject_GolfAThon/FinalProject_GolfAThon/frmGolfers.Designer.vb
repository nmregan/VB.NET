<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGolfers
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
        Me.btnDeleteGolferSP = New System.Windows.Forms.Button()
        Me.btnDeleteGolferSQL = New System.Windows.Forms.Button()
        Me.btnAddGolfer = New System.Windows.Forms.Button()
        Me.btnUpdateGolfer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLoadGolfer = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.cboGolfers = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblGolferTotals = New System.Windows.Forms.Label()
        Me.btnGolferTotals = New System.Windows.Forms.Button()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtShirtSize = New System.Windows.Forms.TextBox()
        Me.cboEventYears = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDeleteGolferSP
        '
        Me.btnDeleteGolferSP.Location = New System.Drawing.Point(312, 317)
        Me.btnDeleteGolferSP.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteGolferSP.Name = "btnDeleteGolferSP"
        Me.btnDeleteGolferSP.Size = New System.Drawing.Size(130, 37)
        Me.btnDeleteGolferSP.TabIndex = 13
        Me.btnDeleteGolferSP.Text = "Delete Golfer Stored Proc"
        Me.btnDeleteGolferSP.UseVisualStyleBackColor = True
        '
        'btnDeleteGolferSQL
        '
        Me.btnDeleteGolferSQL.Location = New System.Drawing.Point(312, 259)
        Me.btnDeleteGolferSQL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteGolferSQL.Name = "btnDeleteGolferSQL"
        Me.btnDeleteGolferSQL.Size = New System.Drawing.Size(130, 37)
        Me.btnDeleteGolferSQL.TabIndex = 12
        Me.btnDeleteGolferSQL.Text = "Delete Golfer SQL"
        Me.btnDeleteGolferSQL.UseVisualStyleBackColor = True
        '
        'btnAddGolfer
        '
        Me.btnAddGolfer.Location = New System.Drawing.Point(312, 201)
        Me.btnAddGolfer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddGolfer.Name = "btnAddGolfer"
        Me.btnAddGolfer.Size = New System.Drawing.Size(130, 37)
        Me.btnAddGolfer.TabIndex = 16
        Me.btnAddGolfer.Text = "Add New Golfer"
        Me.btnAddGolfer.UseVisualStyleBackColor = True
        '
        'btnUpdateGolfer
        '
        Me.btnUpdateGolfer.Location = New System.Drawing.Point(312, 143)
        Me.btnUpdateGolfer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateGolfer.Name = "btnUpdateGolfer"
        Me.btnUpdateGolfer.Size = New System.Drawing.Size(130, 37)
        Me.btnUpdateGolfer.TabIndex = 15
        Me.btnUpdateGolfer.Text = "Update Golfer Info"
        Me.btnUpdateGolfer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(312, 375)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 37)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLoadGolfer
        '
        Me.btnLoadGolfer.Location = New System.Drawing.Point(312, 85)
        Me.btnLoadGolfer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoadGolfer.Name = "btnLoadGolfer"
        Me.btnLoadGolfer.Size = New System.Drawing.Size(130, 37)
        Me.btnLoadGolfer.TabIndex = 14
        Me.btnLoadGolfer.Text = "Load Golfer Info"
        Me.btnLoadGolfer.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(51, 295)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(51, 262)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Phone"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(129, 292)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(135, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(129, 259)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(135, 20)
        Me.txtPhone.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(51, 229)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Zip Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 196)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 163)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 130)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "First Name"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(129, 226)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(76, 20)
        Me.txtZip.TabIndex = 7
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(129, 193)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(37, 20)
        Me.txtState.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(129, 160)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(76, 20)
        Me.txtCity.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(129, 127)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(135, 20)
        Me.txtAddress.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(129, 94)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(135, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(129, 61)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(135, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'cboGolfers
        '
        Me.cboGolfers.FormattingEnabled = True
        Me.cboGolfers.Location = New System.Drawing.Point(54, 24)
        Me.cboGolfers.Margin = New System.Windows.Forms.Padding(2)
        Me.cboGolfers.Name = "cboGolfers"
        Me.cboGolfers.Size = New System.Drawing.Size(210, 21)
        Me.cboGolfers.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(51, 361)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(51, 328)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Shirt Size"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboEventYears)
        Me.GroupBox1.Controls.Add(Me.lblGolferTotals)
        Me.GroupBox1.Controls.Add(Me.btnGolferTotals)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 393)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 91)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Statistics"
        '
        'lblGolferTotals
        '
        Me.lblGolferTotals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGolferTotals.Location = New System.Drawing.Point(121, 49)
        Me.lblGolferTotals.Name = "lblGolferTotals"
        Me.lblGolferTotals.Size = New System.Drawing.Size(76, 20)
        Me.lblGolferTotals.TabIndex = 16
        '
        'btnGolferTotals
        '
        Me.btnGolferTotals.Location = New System.Drawing.Point(24, 38)
        Me.btnGolferTotals.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGolferTotals.Name = "btnGolferTotals"
        Me.btnGolferTotals.Size = New System.Drawing.Size(92, 37)
        Me.btnGolferTotals.TabIndex = 15
        Me.btnGolferTotals.Text = "Total Amount Pledged"
        Me.btnGolferTotals.UseVisualStyleBackColor = True
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(129, 358)
        Me.txtGender.Margin = New System.Windows.Forms.Padding(2)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(76, 20)
        Me.txtGender.TabIndex = 72
        '
        'txtShirtSize
        '
        Me.txtShirtSize.Location = New System.Drawing.Point(129, 325)
        Me.txtShirtSize.Margin = New System.Windows.Forms.Padding(2)
        Me.txtShirtSize.Name = "txtShirtSize"
        Me.txtShirtSize.Size = New System.Drawing.Size(135, 20)
        Me.txtShirtSize.TabIndex = 73
        '
        'cboEventYears
        '
        Me.cboEventYears.FormattingEnabled = True
        Me.cboEventYears.Location = New System.Drawing.Point(121, 16)
        Me.cboEventYears.Margin = New System.Windows.Forms.Padding(2)
        Me.cboEventYears.Name = "cboEventYears"
        Me.cboEventYears.Size = New System.Drawing.Size(65, 21)
        Me.cboEventYears.TabIndex = 74
        '
        'frmGolfers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 496)
        Me.Controls.Add(Me.txtShirtSize)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnDeleteGolferSP)
        Me.Controls.Add(Me.btnDeleteGolferSQL)
        Me.Controls.Add(Me.btnAddGolfer)
        Me.Controls.Add(Me.btnUpdateGolfer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoadGolfer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtZip)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.cboGolfers)
        Me.Name = "frmGolfers"
        Me.Text = "Manage Golfers"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeleteGolferSP As System.Windows.Forms.Button
    Friend WithEvents btnDeleteGolferSQL As System.Windows.Forms.Button
    Friend WithEvents btnAddGolfer As System.Windows.Forms.Button
    Friend WithEvents btnUpdateGolfer As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnLoadGolfer As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents cboGolfers As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblGolferTotals As System.Windows.Forms.Label
    Friend WithEvents btnGolferTotals As System.Windows.Forms.Button
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtShirtSize As System.Windows.Forms.TextBox
    Friend WithEvents cboEventYears As System.Windows.Forms.ComboBox
End Class
