<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDealerAutos
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
        Me.btnUpdateDealer = New System.Windows.Forms.Button()
        Me.btnDeleteSP = New System.Windows.Forms.Button()
        Me.btnDeleteDealerSQL = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnNewDealer = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnLoadDealer = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.cboDealerNames = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnDeleteAutoSP = New System.Windows.Forms.Button()
        Me.btnDeleteAutoSQL = New System.Windows.Forms.Button()
        Me.btnNewAuto = New System.Windows.Forms.Button()
        Me.btnUpdateAuto = New System.Windows.Forms.Button()
        Me.btnLoadAuto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMileage = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.cboModels = New System.Windows.Forms.ComboBox()
        Me.btnAddAutoToDealer = New System.Windows.Forms.Button()
        Me.btnRemoveAutoFromDealer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLoadDealerAutos = New System.Windows.Forms.Button()
        Me.btnShowAvailableAutos = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnUpdateDealer)
        Me.GroupBox1.Controls.Add(Me.btnDeleteSP)
        Me.GroupBox1.Controls.Add(Me.btnDeleteDealerSQL)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnNewDealer)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnLoadDealer)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtZip)
        Me.GroupBox1.Controls.Add(Me.txtState)
        Me.GroupBox1.Controls.Add(Me.txtCity)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.cboDealerNames)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 391)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dealers"
        '
        'btnUpdateDealer
        '
        Me.btnUpdateDealer.Location = New System.Drawing.Point(148, 246)
        Me.btnUpdateDealer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateDealer.Name = "btnUpdateDealer"
        Me.btnUpdateDealer.Size = New System.Drawing.Size(75, 39)
        Me.btnUpdateDealer.TabIndex = 41
        Me.btnUpdateDealer.Text = "Update Dealer Info"
        Me.btnUpdateDealer.UseVisualStyleBackColor = True
        '
        'btnDeleteSP
        '
        Me.btnDeleteSP.Location = New System.Drawing.Point(147, 333)
        Me.btnDeleteSP.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteSP.Name = "btnDeleteSP"
        Me.btnDeleteSP.Size = New System.Drawing.Size(109, 39)
        Me.btnDeleteSP.TabIndex = 20
        Me.btnDeleteSP.Text = "Delete Dealer Stored Proc"
        Me.btnDeleteSP.UseVisualStyleBackColor = True
        '
        'btnDeleteDealerSQL
        '
        Me.btnDeleteDealerSQL.Location = New System.Drawing.Point(34, 333)
        Me.btnDeleteDealerSQL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteDealerSQL.Name = "btnDeleteDealerSQL"
        Me.btnDeleteDealerSQL.Size = New System.Drawing.Size(109, 39)
        Me.btnDeleteDealerSQL.TabIndex = 19
        Me.btnDeleteDealerSQL.Text = "Delete Dealer SQL"
        Me.btnDeleteDealerSQL.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 206)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Zip Code"
        '
        'btnNewDealer
        '
        Me.btnNewDealer.Location = New System.Drawing.Point(108, 290)
        Me.btnNewDealer.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewDealer.Name = "btnNewDealer"
        Me.btnNewDealer.Size = New System.Drawing.Size(75, 39)
        Me.btnNewDealer.TabIndex = 18
        Me.btnNewDealer.Text = "Add New Dealer"
        Me.btnNewDealer.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 174)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "State"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 141)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "City"
        '
        'btnLoadDealer
        '
        Me.btnLoadDealer.Location = New System.Drawing.Point(68, 246)
        Me.btnLoadDealer.Name = "btnLoadDealer"
        Me.btnLoadDealer.Size = New System.Drawing.Size(75, 39)
        Me.btnLoadDealer.TabIndex = 1
        Me.btnLoadDealer.Text = "Load Dealer Info"
        Me.btnLoadDealer.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 107)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Address"
        '
        'txtZip
        '
        Me.txtZip.Location = New System.Drawing.Point(115, 202)
        Me.txtZip.Margin = New System.Windows.Forms.Padding(2)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(76, 20)
        Me.txtZip.TabIndex = 5
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(115, 171)
        Me.txtState.Margin = New System.Windows.Forms.Padding(2)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(37, 20)
        Me.txtState.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(115, 138)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(76, 20)
        Me.txtCity.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(115, 105)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(135, 20)
        Me.txtAddress.TabIndex = 2
        '
        'cboDealerNames
        '
        Me.cboDealerNames.FormattingEnabled = True
        Me.cboDealerNames.Location = New System.Drawing.Point(40, 60)
        Me.cboDealerNames.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDealerNames.Name = "cboDealerNames"
        Me.cboDealerNames.Size = New System.Drawing.Size(210, 21)
        Me.cboDealerNames.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnDeleteAutoSP)
        Me.GroupBox2.Controls.Add(Me.btnDeleteAutoSQL)
        Me.GroupBox2.Controls.Add(Me.btnNewAuto)
        Me.GroupBox2.Controls.Add(Me.btnUpdateAuto)
        Me.GroupBox2.Controls.Add(Me.btnLoadAuto)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtMake)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtMileage)
        Me.GroupBox2.Controls.Add(Me.txtYear)
        Me.GroupBox2.Controls.Add(Me.txtModel)
        Me.GroupBox2.Controls.Add(Me.cboModels)
        Me.GroupBox2.Location = New System.Drawing.Point(457, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 391)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Autos"
        '
        'btnDeleteAutoSP
        '
        Me.btnDeleteAutoSP.Location = New System.Drawing.Point(147, 333)
        Me.btnDeleteAutoSP.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteAutoSP.Name = "btnDeleteAutoSP"
        Me.btnDeleteAutoSP.Size = New System.Drawing.Size(109, 39)
        Me.btnDeleteAutoSP.TabIndex = 45
        Me.btnDeleteAutoSP.Text = "Delete Auto Stored Proc"
        Me.btnDeleteAutoSP.UseVisualStyleBackColor = True
        '
        'btnDeleteAutoSQL
        '
        Me.btnDeleteAutoSQL.Location = New System.Drawing.Point(34, 333)
        Me.btnDeleteAutoSQL.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDeleteAutoSQL.Name = "btnDeleteAutoSQL"
        Me.btnDeleteAutoSQL.Size = New System.Drawing.Size(109, 39)
        Me.btnDeleteAutoSQL.TabIndex = 44
        Me.btnDeleteAutoSQL.Text = "Delete Auto SQL"
        Me.btnDeleteAutoSQL.UseVisualStyleBackColor = True
        '
        'btnNewAuto
        '
        Me.btnNewAuto.Location = New System.Drawing.Point(108, 290)
        Me.btnNewAuto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewAuto.Name = "btnNewAuto"
        Me.btnNewAuto.Size = New System.Drawing.Size(75, 39)
        Me.btnNewAuto.TabIndex = 43
        Me.btnNewAuto.Text = "Add New Auto"
        Me.btnNewAuto.UseVisualStyleBackColor = True
        '
        'btnUpdateAuto
        '
        Me.btnUpdateAuto.Location = New System.Drawing.Point(148, 246)
        Me.btnUpdateAuto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdateAuto.Name = "btnUpdateAuto"
        Me.btnUpdateAuto.Size = New System.Drawing.Size(75, 39)
        Me.btnUpdateAuto.TabIndex = 42
        Me.btnUpdateAuto.Text = "Update Auto Info"
        Me.btnUpdateAuto.UseVisualStyleBackColor = True
        '
        'btnLoadAuto
        '
        Me.btnLoadAuto.Location = New System.Drawing.Point(68, 246)
        Me.btnLoadAuto.Name = "btnLoadAuto"
        Me.btnLoadAuto.Size = New System.Drawing.Size(75, 39)
        Me.btnLoadAuto.TabIndex = 40
        Me.btnLoadAuto.Text = "Load Auto Info"
        Me.btnLoadAuto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Make"
        '
        'txtMake
        '
        Me.txtMake.Location = New System.Drawing.Point(114, 104)
        Me.txtMake.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(135, 20)
        Me.txtMake.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 203)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Mileage"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(43, 171)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 139)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Model"
        '
        'txtMileage
        '
        Me.txtMileage.Location = New System.Drawing.Point(115, 200)
        Me.txtMileage.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.Size = New System.Drawing.Size(76, 20)
        Me.txtMileage.TabIndex = 10
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(115, 168)
        Me.txtYear.Margin = New System.Windows.Forms.Padding(2)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(76, 20)
        Me.txtYear.TabIndex = 9
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(114, 136)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(2)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(135, 20)
        Me.txtModel.TabIndex = 8
        '
        'cboModels
        '
        Me.cboModels.FormattingEnabled = True
        Me.cboModels.Location = New System.Drawing.Point(40, 62)
        Me.cboModels.Margin = New System.Windows.Forms.Padding(2)
        Me.cboModels.Name = "cboModels"
        Me.cboModels.Size = New System.Drawing.Size(210, 21)
        Me.cboModels.TabIndex = 6
        '
        'btnAddAutoToDealer
        '
        Me.btnAddAutoToDealer.Location = New System.Drawing.Point(326, 313)
        Me.btnAddAutoToDealer.Name = "btnAddAutoToDealer"
        Me.btnAddAutoToDealer.Size = New System.Drawing.Size(109, 39)
        Me.btnAddAutoToDealer.TabIndex = 6
        Me.btnAddAutoToDealer.Text = "Add Auto to Selected Dealer"
        Me.btnAddAutoToDealer.UseVisualStyleBackColor = True
        '
        'btnRemoveAutoFromDealer
        '
        Me.btnRemoveAutoFromDealer.Location = New System.Drawing.Point(326, 148)
        Me.btnRemoveAutoFromDealer.Name = "btnRemoveAutoFromDealer"
        Me.btnRemoveAutoFromDealer.Size = New System.Drawing.Size(109, 39)
        Me.btnRemoveAutoFromDealer.TabIndex = 5
        Me.btnRemoveAutoFromDealer.Text = "Remove Auto From Selected Dealer"
        Me.btnRemoveAutoFromDealer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(632, 468)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLoadDealerAutos
        '
        Me.btnLoadDealerAutos.Location = New System.Drawing.Point(326, 93)
        Me.btnLoadDealerAutos.Name = "btnLoadDealerAutos"
        Me.btnLoadDealerAutos.Size = New System.Drawing.Size(109, 39)
        Me.btnLoadDealerAutos.TabIndex = 3
        Me.btnLoadDealerAutos.Text = "Load Selected Dealer Autos"
        Me.btnLoadDealerAutos.UseVisualStyleBackColor = True
        '
        'btnShowAvailableAutos
        '
        Me.btnShowAvailableAutos.Location = New System.Drawing.Point(326, 258)
        Me.btnShowAvailableAutos.Name = "btnShowAvailableAutos"
        Me.btnShowAvailableAutos.Size = New System.Drawing.Size(109, 39)
        Me.btnShowAvailableAutos.TabIndex = 4
        Me.btnShowAvailableAutos.Text = "Show Available Autos"
        Me.btnShowAvailableAutos.UseVisualStyleBackColor = True
        '
        'frmDealerAutos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 524)
        Me.Controls.Add(Me.btnAddAutoToDealer)
        Me.Controls.Add(Me.btnShowAvailableAutos)
        Me.Controls.Add(Me.btnLoadDealerAutos)
        Me.Controls.Add(Me.btnRemoveAutoFromDealer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmDealerAutos"
        Me.Text = "Dealer Autos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents cboDealerNames As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMake As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMileage As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents cboModels As System.Windows.Forms.ComboBox
    Friend WithEvents btnLoadDealer As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnNewDealer As System.Windows.Forms.Button
    Friend WithEvents btnDeleteSP As System.Windows.Forms.Button
    Friend WithEvents btnDeleteDealerSQL As System.Windows.Forms.Button
    Friend WithEvents btnUpdateDealer As System.Windows.Forms.Button
    Friend WithEvents btnLoadAuto As System.Windows.Forms.Button
    Friend WithEvents btnLoadDealerAutos As System.Windows.Forms.Button
    Friend WithEvents btnUpdateAuto As System.Windows.Forms.Button
    Friend WithEvents btnNewAuto As System.Windows.Forms.Button
    Friend WithEvents btnShowAvailableAutos As System.Windows.Forms.Button
    Friend WithEvents btnRemoveAutoFromDealer As System.Windows.Forms.Button
    Friend WithEvents btnAddAutoToDealer As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAutoSP As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAutoSQL As System.Windows.Forms.Button

End Class
