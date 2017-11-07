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
        Me.btnVirginia = New System.Windows.Forms.Button()
        Me.btnNorthCarolina = New System.Windows.Forms.Button()
        Me.btnSouthCarolina = New System.Windows.Forms.Button()
        Me.btnFlorida = New System.Windows.Forms.Button()
        Me.btnAlabama = New System.Windows.Forms.Button()
        Me.btnGeorgia = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVirginia
        '
        Me.btnVirginia.Location = New System.Drawing.Point(33, 105)
        Me.btnVirginia.Name = "btnVirginia"
        Me.btnVirginia.Size = New System.Drawing.Size(75, 41)
        Me.btnVirginia.TabIndex = 0
        Me.btnVirginia.Text = "Virginia"
        Me.btnVirginia.UseVisualStyleBackColor = True
        '
        'btnNorthCarolina
        '
        Me.btnNorthCarolina.Location = New System.Drawing.Point(140, 105)
        Me.btnNorthCarolina.Name = "btnNorthCarolina"
        Me.btnNorthCarolina.Size = New System.Drawing.Size(75, 41)
        Me.btnNorthCarolina.TabIndex = 1
        Me.btnNorthCarolina.Text = "North Carolina"
        Me.btnNorthCarolina.UseVisualStyleBackColor = True
        '
        'btnSouthCarolina
        '
        Me.btnSouthCarolina.Location = New System.Drawing.Point(247, 105)
        Me.btnSouthCarolina.Name = "btnSouthCarolina"
        Me.btnSouthCarolina.Size = New System.Drawing.Size(75, 41)
        Me.btnSouthCarolina.TabIndex = 2
        Me.btnSouthCarolina.Text = "South Carolina"
        Me.btnSouthCarolina.UseVisualStyleBackColor = True
        '
        'btnFlorida
        '
        Me.btnFlorida.Location = New System.Drawing.Point(247, 161)
        Me.btnFlorida.Name = "btnFlorida"
        Me.btnFlorida.Size = New System.Drawing.Size(75, 41)
        Me.btnFlorida.TabIndex = 3
        Me.btnFlorida.Text = "Florida"
        Me.btnFlorida.UseVisualStyleBackColor = True
        '
        'btnAlabama
        '
        Me.btnAlabama.Location = New System.Drawing.Point(140, 161)
        Me.btnAlabama.Name = "btnAlabama"
        Me.btnAlabama.Size = New System.Drawing.Size(75, 41)
        Me.btnAlabama.TabIndex = 4
        Me.btnAlabama.Text = "Alabama"
        Me.btnAlabama.UseVisualStyleBackColor = True
        '
        'btnGeorgia
        '
        Me.btnGeorgia.Location = New System.Drawing.Point(33, 161)
        Me.btnGeorgia.Name = "btnGeorgia"
        Me.btnGeorgia.Size = New System.Drawing.Size(75, 41)
        Me.btnGeorgia.TabIndex = 5
        Me.btnGeorgia.Text = "Georgia"
        Me.btnGeorgia.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(216, 270)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(64, 270)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(127, 40)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(100, 23)
        Me.lblOutput.TabIndex = 8
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 311)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGeorgia)
        Me.Controls.Add(Me.btnAlabama)
        Me.Controls.Add(Me.btnFlorida)
        Me.Controls.Add(Me.btnSouthCarolina)
        Me.Controls.Add(Me.btnNorthCarolina)
        Me.Controls.Add(Me.btnVirginia)
        Me.Name = "Form1"
        Me.Text = "State Abbreviations"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnVirginia As System.Windows.Forms.Button
    Friend WithEvents btnNorthCarolina As System.Windows.Forms.Button
    Friend WithEvents btnSouthCarolina As System.Windows.Forms.Button
    Friend WithEvents btnFlorida As System.Windows.Forms.Button
    Friend WithEvents btnAlabama As System.Windows.Forms.Button
    Friend WithEvents btnGeorgia As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label

End Class
