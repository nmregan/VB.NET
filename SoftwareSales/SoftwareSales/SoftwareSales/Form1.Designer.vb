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
        Me.txtPackageC = New System.Windows.Forms.TextBox()
        Me.txtPackageB = New System.Windows.Forms.TextBox()
        Me.txtPackageA = New System.Windows.Forms.TextBox()
        Me.lblPackageASales = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPackageBSales = New System.Windows.Forms.Label()
        Me.lblPackageCSales = New System.Windows.Forms.Label()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPackageC)
        Me.GroupBox1.Controls.Add(Me.txtPackageB)
        Me.GroupBox1.Controls.Add(Me.txtPackageA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(323, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Quantity Sold"
        '
        'txtPackageC
        '
        Me.txtPackageC.Location = New System.Drawing.Point(151, 98)
        Me.txtPackageC.Name = "txtPackageC"
        Me.txtPackageC.Size = New System.Drawing.Size(100, 20)
        Me.txtPackageC.TabIndex = 5
        '
        'txtPackageB
        '
        Me.txtPackageB.Location = New System.Drawing.Point(151, 62)
        Me.txtPackageB.Name = "txtPackageB"
        Me.txtPackageB.Size = New System.Drawing.Size(100, 20)
        Me.txtPackageB.TabIndex = 4
        '
        'txtPackageA
        '
        Me.txtPackageA.Location = New System.Drawing.Point(151, 26)
        Me.txtPackageA.Name = "txtPackageA"
        Me.txtPackageA.Size = New System.Drawing.Size(100, 20)
        Me.txtPackageA.TabIndex = 3
        '
        'lblPackageASales
        '
        Me.lblPackageASales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackageASales.Location = New System.Drawing.Point(174, 186)
        Me.lblPackageASales.Name = "lblPackageASales"
        Me.lblPackageASales.Size = New System.Drawing.Size(100, 19)
        Me.lblPackageASales.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Package C:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Package B:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Package A:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(38, 357)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(147, 357)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(256, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Package A Sales:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Package B Sales:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(65, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Package C Sales:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 286)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Grand Total:"
        '
        'lblPackageBSales
        '
        Me.lblPackageBSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackageBSales.Location = New System.Drawing.Point(174, 219)
        Me.lblPackageBSales.Name = "lblPackageBSales"
        Me.lblPackageBSales.Size = New System.Drawing.Size(100, 19)
        Me.lblPackageBSales.TabIndex = 9
        '
        'lblPackageCSales
        '
        Me.lblPackageCSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackageCSales.Location = New System.Drawing.Point(174, 252)
        Me.lblPackageCSales.Name = "lblPackageCSales"
        Me.lblPackageCSales.Size = New System.Drawing.Size(100, 19)
        Me.lblPackageCSales.TabIndex = 10
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrandTotal.Location = New System.Drawing.Point(174, 285)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(100, 19)
        Me.lblGrandTotal.TabIndex = 11
        '
        'Form1
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(368, 403)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.lblPackageCSales)
        Me.Controls.Add(Me.lblPackageBSales)
        Me.Controls.Add(Me.lblPackageASales)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Software Sales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPackageC As System.Windows.Forms.TextBox
    Friend WithEvents txtPackageB As System.Windows.Forms.TextBox
    Friend WithEvents txtPackageA As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblPackageASales As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblPackageBSales As System.Windows.Forms.Label
    Friend WithEvents lblPackageCSales As System.Windows.Forms.Label
    Friend WithEvents lblGrandTotal As System.Windows.Forms.Label

End Class
