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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlanetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MercuryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VenusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EarthToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JupiterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UranusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeptuneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlutoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(105, 214)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlanetsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlanetsToolStripMenuItem
        '
        Me.PlanetsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MercuryToolStripMenuItem, Me.VenusToolStripMenuItem, Me.EarthToolStripMenuItem, Me.MarsToolStripMenuItem, Me.JupiterToolStripMenuItem, Me.SaturnToolStripMenuItem, Me.UranusToolStripMenuItem, Me.NeptuneToolStripMenuItem, Me.PlutoToolStripMenuItem})
        Me.PlanetsToolStripMenuItem.Name = "PlanetsToolStripMenuItem"
        Me.PlanetsToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.PlanetsToolStripMenuItem.Text = "Planets"
        '
        'MercuryToolStripMenuItem
        '
        Me.MercuryToolStripMenuItem.Name = "MercuryToolStripMenuItem"
        Me.MercuryToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MercuryToolStripMenuItem.Text = "Mercury"
        '
        'VenusToolStripMenuItem
        '
        Me.VenusToolStripMenuItem.Name = "VenusToolStripMenuItem"
        Me.VenusToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VenusToolStripMenuItem.Text = "Venus"
        '
        'EarthToolStripMenuItem
        '
        Me.EarthToolStripMenuItem.Name = "EarthToolStripMenuItem"
        Me.EarthToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EarthToolStripMenuItem.Text = "Earth"
        '
        'MarsToolStripMenuItem
        '
        Me.MarsToolStripMenuItem.Name = "MarsToolStripMenuItem"
        Me.MarsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MarsToolStripMenuItem.Text = "Mars"
        '
        'JupiterToolStripMenuItem
        '
        Me.JupiterToolStripMenuItem.Name = "JupiterToolStripMenuItem"
        Me.JupiterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.JupiterToolStripMenuItem.Text = "Jupiter"
        '
        'SaturnToolStripMenuItem
        '
        Me.SaturnToolStripMenuItem.Name = "SaturnToolStripMenuItem"
        Me.SaturnToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaturnToolStripMenuItem.Text = "Saturn"
        '
        'UranusToolStripMenuItem
        '
        Me.UranusToolStripMenuItem.Name = "UranusToolStripMenuItem"
        Me.UranusToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.UranusToolStripMenuItem.Text = "Uranus"
        '
        'NeptuneToolStripMenuItem
        '
        Me.NeptuneToolStripMenuItem.Name = "NeptuneToolStripMenuItem"
        Me.NeptuneToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NeptuneToolStripMenuItem.Text = "Neptune"
        '
        'PlutoToolStripMenuItem
        '
        Me.PlutoToolStripMenuItem.Name = "PlutoToolStripMenuItem"
        Me.PlutoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PlutoToolStripMenuItem.Text = "Pluto"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 66)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "WELCOME TO THE SOLAR SYSTEM!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(71, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 51)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Start Exploring By Clicking The ""Planets"" Menu In The Top Left Hand Corner"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 257)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "frmMain"
        Me.Text = "Astronomy Helper"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents PlanetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MercuryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VenusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EarthToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JupiterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaturnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UranusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeptuneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PlutoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
