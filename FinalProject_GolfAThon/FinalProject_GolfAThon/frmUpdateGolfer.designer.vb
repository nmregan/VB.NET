<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateGolfer
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
        Me.btnUpdateGolfer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.cboShirtSize = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.btnLoadGolfer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUpdateGolfer
        '
        Me.btnUpdateGolfer.Location = New System.Drawing.Point(41, 465)
        Me.btnUpdateGolfer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateGolfer.Name = "btnUpdateGolfer"
        Me.btnUpdateGolfer.Size = New System.Drawing.Size(87, 37)
        Me.btnUpdateGolfer.TabIndex = 12
        Me.btnUpdateGolfer.Text = "Update Golfer"
        Me.btnUpdateGolfer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(162, 465)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 37)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Location = New System.Drawing.Point(117, 364)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(121, 21)
        Me.cboGender.TabIndex = 11
        '
        'cboShirtSize
        '
        Me.cboShirtSize.FormattingEnabled = True
        Me.cboShirtSize.Location = New System.Drawing.Point(117, 331)
        Me.cboShirtSize.Name = "cboShirtSize"
        Me.cboShirtSize.Size = New System.Drawing.Size(121, 21)
        Me.cboShirtSize.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 334)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Shirt Size"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 367)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 301)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 268)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 89
        Me.Label8.Text = "Phone"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(117, 298)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(135, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(117, 265)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(135, 20)
        Me.txtPhone.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 235)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Zip Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 202)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 169)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 136)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 70)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "First Name"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(117, 232)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(76, 20)
        Me.txtZip.TabIndex = 7
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(117, 199)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(37, 20)
        Me.txtState.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(117, 166)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(76, 20)
        Me.txtCity.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(117, 133)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(135, 20)
        Me.txtAddress.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(117, 100)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(135, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(117, 67)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(135, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'cboGolfers
        '
        Me.cboGolfers.FormattingEnabled = True
        Me.cboGolfers.Location = New System.Drawing.Point(42, 30)
        Me.cboGolfers.Margin = New System.Windows.Forms.Padding(2)
        Me.cboGolfers.Name = "cboGolfers"
        Me.cboGolfers.Size = New System.Drawing.Size(210, 21)
        Me.cboGolfers.TabIndex = 1
        '
        'btnLoadGolfer
        '
        Me.btnLoadGolfer.Location = New System.Drawing.Point(80, 411)
        Me.btnLoadGolfer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoadGolfer.Name = "btnLoadGolfer"
        Me.btnLoadGolfer.Size = New System.Drawing.Size(130, 37)
        Me.btnLoadGolfer.TabIndex = 95
        Me.btnLoadGolfer.Text = "Load Golfer Info"
        Me.btnLoadGolfer.UseVisualStyleBackColor = True
        '
        'frmUpdateGolfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 513)
        Me.Controls.Add(Me.btnLoadGolfer)
        Me.Controls.Add(Me.cboGender)
        Me.Controls.Add(Me.cboShirtSize)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
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
        Me.Controls.Add(Me.btnUpdateGolfer)
        Me.Controls.Add(Me.btnExit)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmUpdateGolfer"
        Me.Text = "Update Golfer Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdateGolfer As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cboGender As System.Windows.Forms.ComboBox
    Friend WithEvents cboShirtSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
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
    Friend WithEvents btnLoadGolfer As System.Windows.Forms.Button
End Class
