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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnFamily = New System.Windows.Forms.Button()
        Me.btnIndividual = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFamily)
        Me.GroupBox1.Controls.Add(Me.btnIndividual)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 193)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Plan"
        '
        'btnFamily
        '
        Me.btnFamily.Location = New System.Drawing.Point(260, 138)
        Me.btnFamily.Name = "btnFamily"
        Me.btnFamily.Size = New System.Drawing.Size(75, 23)
        Me.btnFamily.TabIndex = 3
        Me.btnFamily.Text = "Family"
        Me.btnFamily.UseVisualStyleBackColor = True
        '
        'btnIndividual
        '
        Me.btnIndividual.Location = New System.Drawing.Point(260, 54)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.Size = New System.Drawing.Size(75, 23)
        Me.btnIndividual.TabIndex = 2
        Me.btnIndividual.Text = "Individual"
        Me.btnIndividual.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(48, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 59)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "The Family plan allows you to purchase multiple cell phones of the same model, wi" & _
    "th each phone sharing one monthly package."
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "The Individual plan provides one cell phone and a variety of monthly packages."
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(272, 230)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 273)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.Text = "Cell Phone Packages"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnFamily As System.Windows.Forms.Button
    Friend WithEvents btnIndividual As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
