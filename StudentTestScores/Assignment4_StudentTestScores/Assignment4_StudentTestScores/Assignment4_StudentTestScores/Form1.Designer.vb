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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTest7 = New System.Windows.Forms.TextBox()
        Me.txtTest9 = New System.Windows.Forms.TextBox()
        Me.txtTest8 = New System.Windows.Forms.TextBox()
        Me.txtTest4 = New System.Windows.Forms.TextBox()
        Me.txtTest6 = New System.Windows.Forms.TextBox()
        Me.txtTest5 = New System.Windows.Forms.TextBox()
        Me.txtTest1 = New System.Windows.Forms.TextBox()
        Me.txtTest3 = New System.Windows.Forms.TextBox()
        Me.txtTest2 = New System.Windows.Forms.TextBox()
        Me.txtName3 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.lblAverage3 = New System.Windows.Forms.Label()
        Me.lblAverage2 = New System.Windows.Forms.Label()
        Me.lblAverage1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculateAverages = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReportToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(375, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.LoadToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'LoadToolStripMenuItem
        '
        Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
        Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.LoadToolStripMenuItem.Text = "Load"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem})
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "&Report"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTest7)
        Me.GroupBox1.Controls.Add(Me.txtTest9)
        Me.GroupBox1.Controls.Add(Me.txtTest8)
        Me.GroupBox1.Controls.Add(Me.txtTest4)
        Me.GroupBox1.Controls.Add(Me.txtTest6)
        Me.GroupBox1.Controls.Add(Me.txtTest5)
        Me.GroupBox1.Controls.Add(Me.txtTest1)
        Me.GroupBox1.Controls.Add(Me.txtTest3)
        Me.GroupBox1.Controls.Add(Me.txtTest2)
        Me.GroupBox1.Controls.Add(Me.txtName3)
        Me.GroupBox1.Controls.Add(Me.txtName2)
        Me.GroupBox1.Controls.Add(Me.txtName1)
        Me.GroupBox1.Controls.Add(Me.lblAverage3)
        Me.GroupBox1.Controls.Add(Me.lblAverage2)
        Me.GroupBox1.Controls.Add(Me.lblAverage1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 168)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Data"
        '
        'txtTest7
        '
        Me.txtTest7.Location = New System.Drawing.Point(112, 116)
        Me.txtTest7.Name = "txtTest7"
        Me.txtTest7.Size = New System.Drawing.Size(47, 20)
        Me.txtTest7.TabIndex = 10
        '
        'txtTest9
        '
        Me.txtTest9.Location = New System.Drawing.Point(218, 117)
        Me.txtTest9.Name = "txtTest9"
        Me.txtTest9.Size = New System.Drawing.Size(47, 20)
        Me.txtTest9.TabIndex = 12
        '
        'txtTest8
        '
        Me.txtTest8.Location = New System.Drawing.Point(165, 117)
        Me.txtTest8.Name = "txtTest8"
        Me.txtTest8.Size = New System.Drawing.Size(47, 20)
        Me.txtTest8.TabIndex = 11
        '
        'txtTest4
        '
        Me.txtTest4.Location = New System.Drawing.Point(112, 82)
        Me.txtTest4.Name = "txtTest4"
        Me.txtTest4.Size = New System.Drawing.Size(47, 20)
        Me.txtTest4.TabIndex = 6
        '
        'txtTest6
        '
        Me.txtTest6.Location = New System.Drawing.Point(218, 82)
        Me.txtTest6.Name = "txtTest6"
        Me.txtTest6.Size = New System.Drawing.Size(47, 20)
        Me.txtTest6.TabIndex = 8
        '
        'txtTest5
        '
        Me.txtTest5.Location = New System.Drawing.Point(165, 82)
        Me.txtTest5.Name = "txtTest5"
        Me.txtTest5.Size = New System.Drawing.Size(47, 20)
        Me.txtTest5.TabIndex = 7
        '
        'txtTest1
        '
        Me.txtTest1.Location = New System.Drawing.Point(112, 48)
        Me.txtTest1.Name = "txtTest1"
        Me.txtTest1.Size = New System.Drawing.Size(47, 20)
        Me.txtTest1.TabIndex = 2
        '
        'txtTest3
        '
        Me.txtTest3.Location = New System.Drawing.Point(218, 48)
        Me.txtTest3.Name = "txtTest3"
        Me.txtTest3.Size = New System.Drawing.Size(47, 20)
        Me.txtTest3.TabIndex = 4
        '
        'txtTest2
        '
        Me.txtTest2.Location = New System.Drawing.Point(165, 48)
        Me.txtTest2.Name = "txtTest2"
        Me.txtTest2.Size = New System.Drawing.Size(47, 20)
        Me.txtTest2.TabIndex = 3
        '
        'txtName3
        '
        Me.txtName3.Location = New System.Drawing.Point(6, 116)
        Me.txtName3.Name = "txtName3"
        Me.txtName3.Size = New System.Drawing.Size(100, 20)
        Me.txtName3.TabIndex = 9
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(6, 82)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(100, 20)
        Me.txtName2.TabIndex = 5
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(6, 48)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(100, 20)
        Me.txtName1.TabIndex = 1
        '
        'lblAverage3
        '
        Me.lblAverage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage3.Location = New System.Drawing.Point(271, 119)
        Me.lblAverage3.Name = "lblAverage3"
        Me.lblAverage3.Size = New System.Drawing.Size(47, 20)
        Me.lblAverage3.TabIndex = 5
        '
        'lblAverage2
        '
        Me.lblAverage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage2.Location = New System.Drawing.Point(271, 84)
        Me.lblAverage2.Name = "lblAverage2"
        Me.lblAverage2.Size = New System.Drawing.Size(47, 20)
        Me.lblAverage2.TabIndex = 4
        '
        'lblAverage1
        '
        Me.lblAverage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverage1.Location = New System.Drawing.Point(271, 48)
        Me.lblAverage1.Name = "lblAverage1"
        Me.lblAverage1.Size = New System.Drawing.Size(47, 20)
        Me.lblAverage1.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(271, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Average"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Test Scores"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'btnCalculateAverages
        '
        Me.btnCalculateAverages.Location = New System.Drawing.Point(173, 243)
        Me.btnCalculateAverages.Name = "btnCalculateAverages"
        Me.btnCalculateAverages.Size = New System.Drawing.Size(92, 38)
        Me.btnCalculateAverages.TabIndex = 13
        Me.btnCalculateAverages.Text = "Calculate &Averages"
        Me.btnCalculateAverages.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(271, 243)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 38)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 293)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculateAverages)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Student Test Scores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTest7 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest9 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest8 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest4 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest6 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest5 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest3 As System.Windows.Forms.TextBox
    Friend WithEvents txtTest2 As System.Windows.Forms.TextBox
    Friend WithEvents txtName3 As System.Windows.Forms.TextBox
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents txtName1 As System.Windows.Forms.TextBox
    Friend WithEvents lblAverage3 As System.Windows.Forms.Label
    Friend WithEvents lblAverage2 As System.Windows.Forms.Label
    Friend WithEvents lblAverage1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculateAverages As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents LoadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
