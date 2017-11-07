<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFamilyPlan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumberOfPhones = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radPackageC = New System.Windows.Forms.RadioButton()
        Me.radPackageB = New System.Windows.Forms.RadioButton()
        Me.radPackageA = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkTextMessaging = New System.Windows.Forms.CheckBox()
        Me.chkEmail = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblTotalMonthlyCharge = New System.Windows.Forms.Label()
        Me.lblPackageCharge = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblPhoneTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radModel200 = New System.Windows.Forms.RadioButton()
        Me.radModel110 = New System.Windows.Forms.RadioButton()
        Me.radModel100 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Phones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNumberOfPhones
        '
        Me.txtNumberOfPhones.Location = New System.Drawing.Point(121, 9)
        Me.txtNumberOfPhones.Name = "txtNumberOfPhones"
        Me.txtNumberOfPhones.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfPhones.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(44, 421)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(44, 373)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(44, 325)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radPackageC)
        Me.GroupBox2.Controls.Add(Me.radPackageB)
        Me.GroupBox2.Controls.Add(Me.radPackageA)
        Me.GroupBox2.Location = New System.Drawing.Point(162, 46)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 134)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select a Package"
        '
        'radPackageC
        '
        Me.radPackageC.AutoSize = True
        Me.radPackageC.Location = New System.Drawing.Point(6, 92)
        Me.radPackageC.Name = "radPackageC"
        Me.radPackageC.Size = New System.Drawing.Size(110, 17)
        Me.radPackageC.TabIndex = 2
        Me.radPackageC.Text = "Unilimited Minutes"
        Me.radPackageC.UseVisualStyleBackColor = True
        '
        'radPackageB
        '
        Me.radPackageB.AutoSize = True
        Me.radPackageB.Location = New System.Drawing.Point(6, 61)
        Me.radPackageB.Name = "radPackageB"
        Me.radPackageB.Size = New System.Drawing.Size(124, 17)
        Me.radPackageB.TabIndex = 1
        Me.radPackageB.Text = "1500 Minutes/Month"
        Me.radPackageB.UseVisualStyleBackColor = True
        '
        'radPackageA
        '
        Me.radPackageA.AutoSize = True
        Me.radPackageA.Checked = True
        Me.radPackageA.Location = New System.Drawing.Point(6, 30)
        Me.radPackageA.Name = "radPackageA"
        Me.radPackageA.Size = New System.Drawing.Size(118, 17)
        Me.radPackageA.TabIndex = 0
        Me.radPackageA.TabStop = True
        Me.radPackageA.Text = "800 Minutes/Month"
        Me.radPackageA.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkTextMessaging)
        Me.GroupBox3.Controls.Add(Me.chkEmail)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 186)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(131, 106)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Options"
        '
        'chkTextMessaging
        '
        Me.chkTextMessaging.AutoSize = True
        Me.chkTextMessaging.Location = New System.Drawing.Point(6, 66)
        Me.chkTextMessaging.Name = "chkTextMessaging"
        Me.chkTextMessaging.Size = New System.Drawing.Size(101, 17)
        Me.chkTextMessaging.TabIndex = 1
        Me.chkTextMessaging.Text = "Text Messaging"
        Me.chkTextMessaging.UseVisualStyleBackColor = True
        '
        'chkEmail
        '
        Me.chkEmail.AutoSize = True
        Me.chkEmail.Location = New System.Drawing.Point(6, 29)
        Me.chkEmail.Name = "chkEmail"
        Me.chkEmail.Size = New System.Drawing.Size(51, 17)
        Me.chkEmail.TabIndex = 0
        Me.chkEmail.Text = "Email"
        Me.chkEmail.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblTotalMonthlyCharge)
        Me.GroupBox4.Controls.Add(Me.lblPackageCharge)
        Me.GroupBox4.Controls.Add(Me.lblOptions)
        Me.GroupBox4.Controls.Add(Me.lblPhoneTotal)
        Me.GroupBox4.Controls.Add(Me.lblTax)
        Me.GroupBox4.Controls.Add(Me.lblSubtotal)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(162, 186)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(233, 274)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Totals"
        '
        'lblTotalMonthlyCharge
        '
        Me.lblTotalMonthlyCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalMonthlyCharge.Location = New System.Drawing.Point(120, 211)
        Me.lblTotalMonthlyCharge.Name = "lblTotalMonthlyCharge"
        Me.lblTotalMonthlyCharge.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalMonthlyCharge.TabIndex = 11
        '
        'lblPackageCharge
        '
        Me.lblPackageCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackageCharge.Location = New System.Drawing.Point(120, 177)
        Me.lblPackageCharge.Name = "lblPackageCharge"
        Me.lblPackageCharge.Size = New System.Drawing.Size(100, 23)
        Me.lblPackageCharge.TabIndex = 10
        '
        'lblOptions
        '
        Me.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptions.Location = New System.Drawing.Point(120, 143)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(100, 23)
        Me.lblOptions.TabIndex = 9
        '
        'lblPhoneTotal
        '
        Me.lblPhoneTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhoneTotal.Location = New System.Drawing.Point(120, 109)
        Me.lblPhoneTotal.Name = "lblPhoneTotal"
        Me.lblPhoneTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblPhoneTotal.TabIndex = 8
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(120, 75)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 7
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(120, 41)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubtotal.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(14, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 30)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Monthly Charge"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(14, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Package Charge"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(14, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Options"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(17, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone Total"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(56, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 27)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Phone Subtotal"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radModel200)
        Me.GroupBox1.Controls.Add(Me.radModel110)
        Me.GroupBox1.Controls.Add(Me.radModel100)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 134)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Phone"
        '
        'radModel200
        '
        Me.radModel200.AutoSize = True
        Me.radModel200.Location = New System.Drawing.Point(6, 92)
        Me.radModel200.Name = "radModel200"
        Me.radModel200.Size = New System.Drawing.Size(75, 17)
        Me.radModel200.TabIndex = 2
        Me.radModel200.Text = "Model 200"
        Me.radModel200.UseVisualStyleBackColor = True
        '
        'radModel110
        '
        Me.radModel110.AutoSize = True
        Me.radModel110.Location = New System.Drawing.Point(6, 61)
        Me.radModel110.Name = "radModel110"
        Me.radModel110.Size = New System.Drawing.Size(75, 17)
        Me.radModel110.TabIndex = 1
        Me.radModel110.Text = "Model 110"
        Me.radModel110.UseVisualStyleBackColor = True
        '
        'radModel100
        '
        Me.radModel100.AutoSize = True
        Me.radModel100.Checked = True
        Me.radModel100.Location = New System.Drawing.Point(6, 30)
        Me.radModel100.Name = "radModel100"
        Me.radModel100.Size = New System.Drawing.Size(75, 17)
        Me.radModel100.TabIndex = 0
        Me.radModel100.TabStop = True
        Me.radModel100.Text = "Model 100"
        Me.radModel100.UseVisualStyleBackColor = True
        '
        'frmFamilyPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 476)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNumberOfPhones)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFamilyPlan"
        Me.Text = "Family Plan"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNumberOfPhones As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radPackageC As System.Windows.Forms.RadioButton
    Friend WithEvents radPackageB As System.Windows.Forms.RadioButton
    Friend WithEvents radPackageA As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTextMessaging As System.Windows.Forms.CheckBox
    Friend WithEvents chkEmail As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalMonthlyCharge As System.Windows.Forms.Label
    Friend WithEvents lblPackageCharge As System.Windows.Forms.Label
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents lblPhoneTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radModel200 As System.Windows.Forms.RadioButton
    Friend WithEvents radModel110 As System.Windows.Forms.RadioButton
    Friend WithEvents radModel100 As System.Windows.Forms.RadioButton
End Class
