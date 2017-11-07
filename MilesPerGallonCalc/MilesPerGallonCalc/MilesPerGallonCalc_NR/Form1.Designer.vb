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
        Me.btnCalcMPG = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.txtGallons = New System.Windows.Forms.TextBox()
        Me.txtMiles = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalcMPG
        '
        Me.btnCalcMPG.Location = New System.Drawing.Point(45, 250)
        Me.btnCalcMPG.Name = "btnCalcMPG"
        Me.btnCalcMPG.Size = New System.Drawing.Size(75, 50)
        Me.btnCalcMPG.TabIndex = 2
        Me.btnCalcMPG.Text = "&Calculate MPG"
        Me.btnCalcMPG.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(153, 250)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 50)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(261, 250)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 50)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gallons of gas the car can hold:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of miles it can be driven on a full tank:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 39)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Miles per gallon:"
        '
        'lblMPG
        '
        Me.lblMPG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMPG.Location = New System.Drawing.Point(220, 175)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(100, 20)
        Me.lblMPG.TabIndex = 6
        '
        'txtGallons
        '
        Me.txtGallons.Location = New System.Drawing.Point(220, 47)
        Me.txtGallons.Name = "txtGallons"
        Me.txtGallons.Size = New System.Drawing.Size(100, 20)
        Me.txtGallons.TabIndex = 0
        '
        'txtMiles
        '
        Me.txtMiles.Location = New System.Drawing.Point(220, 116)
        Me.txtMiles.Name = "txtMiles"
        Me.txtMiles.Size = New System.Drawing.Size(100, 20)
        Me.txtMiles.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 337)
        Me.Controls.Add(Me.txtMiles)
        Me.Controls.Add(Me.txtGallons)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcMPG)
        Me.Name = "Form1"
        Me.Text = "Miles per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalcMPG As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblMPG As System.Windows.Forms.Label
    Friend WithEvents txtGallons As System.Windows.Forms.TextBox
    Friend WithEvents txtMiles As System.Windows.Forms.TextBox

End Class
