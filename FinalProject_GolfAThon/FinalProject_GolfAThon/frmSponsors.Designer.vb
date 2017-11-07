<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSponsors
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
        Me.cboSponsors = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.btnDeleteSponsorSP = New System.Windows.Forms.Button()
        Me.btnDeleteSponsorSQL = New System.Windows.Forms.Button()
        Me.btnAddSponsor = New System.Windows.Forms.Button()
        Me.btnUpdateSponsor = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLoadSponsor = New System.Windows.Forms.Button()
        Me.btnSponsorTotals = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblSponsorTotals = New System.Windows.Forms.Label()
        Me.cboEventYears = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(53, 261)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Zip Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 228)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "State"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 129)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 96)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "First Name"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(131, 260)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(76, 20)
        Me.txtZip.TabIndex = 7
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(131, 227)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(37, 20)
        Me.txtState.TabIndex = 6
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(131, 194)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(76, 20)
        Me.txtCity.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(131, 161)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(135, 20)
        Me.txtAddress.TabIndex = 4
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(131, 128)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(135, 20)
        Me.txtLastName.TabIndex = 3
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(131, 95)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(135, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'cboSponsors
        '
        Me.cboSponsors.FormattingEnabled = True
        Me.cboSponsors.Location = New System.Drawing.Point(56, 58)
        Me.cboSponsors.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSponsors.Name = "cboSponsors"
        Me.cboSponsors.Size = New System.Drawing.Size(210, 21)
        Me.cboSponsors.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(53, 327)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 294)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Phone"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(131, 326)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(135, 20)
        Me.txtEmail.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(131, 293)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(135, 20)
        Me.txtPhone.TabIndex = 8
        '
        'btnDeleteSponsorSP
        '
        Me.btnDeleteSponsorSP.Location = New System.Drawing.Point(310, 323)
        Me.btnDeleteSponsorSP.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteSponsorSP.Name = "btnDeleteSponsorSP"
        Me.btnDeleteSponsorSP.Size = New System.Drawing.Size(130, 37)
        Me.btnDeleteSponsorSP.TabIndex = 11
        Me.btnDeleteSponsorSP.Text = "Delete Sponsor Stored Proc"
        Me.btnDeleteSponsorSP.UseVisualStyleBackColor = True
        '
        'btnDeleteSponsorSQL
        '
        Me.btnDeleteSponsorSQL.Location = New System.Drawing.Point(310, 266)
        Me.btnDeleteSponsorSQL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteSponsorSQL.Name = "btnDeleteSponsorSQL"
        Me.btnDeleteSponsorSQL.Size = New System.Drawing.Size(130, 37)
        Me.btnDeleteSponsorSQL.TabIndex = 10
        Me.btnDeleteSponsorSQL.Text = "Delete Sponsor SQL"
        Me.btnDeleteSponsorSQL.UseVisualStyleBackColor = True
        '
        'btnAddSponsor
        '
        Me.btnAddSponsor.Location = New System.Drawing.Point(310, 209)
        Me.btnAddSponsor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddSponsor.Name = "btnAddSponsor"
        Me.btnAddSponsor.Size = New System.Drawing.Size(130, 37)
        Me.btnAddSponsor.TabIndex = 14
        Me.btnAddSponsor.Text = "Add New Sponsor"
        Me.btnAddSponsor.UseVisualStyleBackColor = True
        '
        'btnUpdateSponsor
        '
        Me.btnUpdateSponsor.Location = New System.Drawing.Point(310, 152)
        Me.btnUpdateSponsor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateSponsor.Name = "btnUpdateSponsor"
        Me.btnUpdateSponsor.Size = New System.Drawing.Size(130, 37)
        Me.btnUpdateSponsor.TabIndex = 13
        Me.btnUpdateSponsor.Text = "Update Sponsor Info"
        Me.btnUpdateSponsor.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(310, 380)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 37)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLoadSponsor
        '
        Me.btnLoadSponsor.Location = New System.Drawing.Point(310, 95)
        Me.btnLoadSponsor.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoadSponsor.Name = "btnLoadSponsor"
        Me.btnLoadSponsor.Size = New System.Drawing.Size(130, 37)
        Me.btnLoadSponsor.TabIndex = 12
        Me.btnLoadSponsor.Text = "Load Sponsor Info"
        Me.btnLoadSponsor.UseVisualStyleBackColor = True
        '
        'btnSponsorTotals
        '
        Me.btnSponsorTotals.Location = New System.Drawing.Point(24, 47)
        Me.btnSponsorTotals.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSponsorTotals.Name = "btnSponsorTotals"
        Me.btnSponsorTotals.Size = New System.Drawing.Size(92, 37)
        Me.btnSponsorTotals.TabIndex = 15
        Me.btnSponsorTotals.Text = "Total Amount Pledged"
        Me.btnSponsorTotals.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboEventYears)
        Me.GroupBox1.Controls.Add(Me.lblSponsorTotals)
        Me.GroupBox1.Controls.Add(Me.btnSponsorTotals)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 360)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 106)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Statistics"
        '
        'lblSponsorTotals
        '
        Me.lblSponsorTotals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSponsorTotals.Location = New System.Drawing.Point(121, 58)
        Me.lblSponsorTotals.Name = "lblSponsorTotals"
        Me.lblSponsorTotals.Size = New System.Drawing.Size(76, 20)
        Me.lblSponsorTotals.TabIndex = 16
        '
        'cboEventYears
        '
        Me.cboEventYears.FormattingEnabled = True
        Me.cboEventYears.Location = New System.Drawing.Point(121, 23)
        Me.cboEventYears.Margin = New System.Windows.Forms.Padding(2)
        Me.cboEventYears.Name = "cboEventYears"
        Me.cboEventYears.Size = New System.Drawing.Size(65, 21)
        Me.cboEventYears.TabIndex = 75
        '
        'frmSponsors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 496)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnDeleteSponsorSP)
        Me.Controls.Add(Me.btnDeleteSponsorSQL)
        Me.Controls.Add(Me.btnAddSponsor)
        Me.Controls.Add(Me.btnUpdateSponsor)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoadSponsor)
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
        Me.Controls.Add(Me.cboSponsors)
        Me.Name = "frmSponsors"
        Me.Text = "Manage Sponsors"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents cboSponsors As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteSponsorSP As System.Windows.Forms.Button
    Friend WithEvents btnDeleteSponsorSQL As System.Windows.Forms.Button
    Friend WithEvents btnAddSponsor As System.Windows.Forms.Button
    Friend WithEvents btnUpdateSponsor As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnLoadSponsor As System.Windows.Forms.Button
    Friend WithEvents btnSponsorTotals As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSponsorTotals As System.Windows.Forms.Label
    Friend WithEvents cboEventYears As System.Windows.Forms.ComboBox
End Class
