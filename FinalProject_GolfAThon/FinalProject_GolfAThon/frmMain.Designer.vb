<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnManageGolfers = New System.Windows.Forms.Button()
        Me.btnManageSponsors = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEventYearTotal = New System.Windows.Forms.Label()
        Me.btnTotalEventYear = New System.Windows.Forms.Button()
        Me.cboEventYears = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnManageGolfers
        '
        Me.btnManageGolfers.Location = New System.Drawing.Point(78, 274)
        Me.btnManageGolfers.Name = "btnManageGolfers"
        Me.btnManageGolfers.Size = New System.Drawing.Size(110, 55)
        Me.btnManageGolfers.TabIndex = 0
        Me.btnManageGolfers.Text = "Manage Golfers"
        Me.btnManageGolfers.UseVisualStyleBackColor = True
        '
        'btnManageSponsors
        '
        Me.btnManageSponsors.Location = New System.Drawing.Point(213, 274)
        Me.btnManageSponsors.Name = "btnManageSponsors"
        Me.btnManageSponsors.Size = New System.Drawing.Size(110, 55)
        Me.btnManageSponsors.TabIndex = 1
        Me.btnManageSponsors.Text = "Manage Sponsors"
        Me.btnManageSponsors.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(348, 274)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(110, 55)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEventYearTotal)
        Me.GroupBox1.Controls.Add(Me.btnTotalEventYear)
        Me.GroupBox1.Controls.Add(Me.cboEventYears)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 219)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Total Amount Pledged for Each Year's Event"
        '
        'lblEventYearTotal
        '
        Me.lblEventYearTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEventYearTotal.Location = New System.Drawing.Point(259, 114)
        Me.lblEventYearTotal.Name = "lblEventYearTotal"
        Me.lblEventYearTotal.Size = New System.Drawing.Size(130, 37)
        Me.lblEventYearTotal.TabIndex = 7
        Me.lblEventYearTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnTotalEventYear
        '
        Me.btnTotalEventYear.Location = New System.Drawing.Point(123, 114)
        Me.btnTotalEventYear.Name = "btnTotalEventYear"
        Me.btnTotalEventYear.Size = New System.Drawing.Size(130, 37)
        Me.btnTotalEventYear.TabIndex = 6
        Me.btnTotalEventYear.Text = "Total Amount Pledged"
        Me.btnTotalEventYear.UseVisualStyleBackColor = True
        '
        'cboEventYears
        '
        Me.cboEventYears.FormattingEnabled = True
        Me.cboEventYears.Location = New System.Drawing.Point(259, 68)
        Me.cboEventYears.Margin = New System.Windows.Forms.Padding(2)
        Me.cboEventYears.Name = "cboEventYears"
        Me.cboEventYears.Size = New System.Drawing.Size(65, 21)
        Me.cboEventYears.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select Event Year:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(536, 376)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnManageSponsors)
        Me.Controls.Add(Me.btnManageGolfers)
        Me.Name = "frmMain"
        Me.Text = "Golf-A-Thon"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnManageGolfers As System.Windows.Forms.Button
    Friend WithEvents btnManageSponsors As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnTotalEventYear As System.Windows.Forms.Button
    Friend WithEvents cboEventYears As System.Windows.Forms.ComboBox
    Friend WithEvents lblEventYearTotal As System.Windows.Forms.Label

End Class
