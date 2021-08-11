<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Me.LenghtLabel = New System.Windows.Forms.Label()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.WidthLabel = New System.Windows.Forms.Label()
        Me.CoverageLabel = New System.Windows.Forms.Label()
        Me.SingleRollLabel = New System.Windows.Forms.Label()
        Me.LenghtCmb = New System.Windows.Forms.ComboBox()
        Me.WidthCmb = New System.Windows.Forms.ComboBox()
        Me.HeightCmb = New System.Windows.Forms.ComboBox()
        Me.RollCoverCmb = New System.Windows.Forms.ComboBox()
        Me.CalculateBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.SingleRollTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LenghtLabel
        '
        Me.LenghtLabel.AutoSize = True
        Me.LenghtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LenghtLabel.Location = New System.Drawing.Point(46, 66)
        Me.LenghtLabel.Name = "LenghtLabel"
        Me.LenghtLabel.Size = New System.Drawing.Size(108, 17)
        Me.LenghtLabel.TabIndex = 0
        Me.LenghtLabel.Text = "Length (feet):"
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeightLabel.Location = New System.Drawing.Point(46, 193)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(105, 17)
        Me.HeightLabel.TabIndex = 1
        Me.HeightLabel.Text = "Height (feet):"
        '
        'WidthLabel
        '
        Me.WidthLabel.AutoSize = True
        Me.WidthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WidthLabel.Location = New System.Drawing.Point(46, 128)
        Me.WidthLabel.Name = "WidthLabel"
        Me.WidthLabel.Size = New System.Drawing.Size(99, 17)
        Me.WidthLabel.TabIndex = 2
        Me.WidthLabel.Text = "Width (feet):"
        '
        'CoverageLabel
        '
        Me.CoverageLabel.AutoSize = True
        Me.CoverageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CoverageLabel.Location = New System.Drawing.Point(46, 256)
        Me.CoverageLabel.Name = "CoverageLabel"
        Me.CoverageLabel.Size = New System.Drawing.Size(169, 17)
        Me.CoverageLabel.TabIndex = 3
        Me.CoverageLabel.Text = "Roll Coverage (sqrFt):"
        '
        'SingleRollLabel
        '
        Me.SingleRollLabel.AutoSize = True
        Me.SingleRollLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SingleRollLabel.Location = New System.Drawing.Point(495, 128)
        Me.SingleRollLabel.Name = "SingleRollLabel"
        Me.SingleRollLabel.Size = New System.Drawing.Size(91, 17)
        Me.SingleRollLabel.TabIndex = 4
        Me.SingleRollLabel.Text = "Single Roll:"
        '
        'LenghtCmb
        '
        Me.LenghtCmb.FormattingEnabled = True
        Me.LenghtCmb.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.LenghtCmb.Location = New System.Drawing.Point(237, 63)
        Me.LenghtCmb.Name = "LenghtCmb"
        Me.LenghtCmb.Size = New System.Drawing.Size(192, 24)
        Me.LenghtCmb.TabIndex = 5
        '
        'WidthCmb
        '
        Me.WidthCmb.FormattingEnabled = True
        Me.WidthCmb.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.WidthCmb.Location = New System.Drawing.Point(237, 128)
        Me.WidthCmb.Name = "WidthCmb"
        Me.WidthCmb.Size = New System.Drawing.Size(192, 24)
        Me.WidthCmb.TabIndex = 6
        '
        'HeightCmb
        '
        Me.HeightCmb.FormattingEnabled = True
        Me.HeightCmb.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.HeightCmb.Location = New System.Drawing.Point(237, 193)
        Me.HeightCmb.Name = "HeightCmb"
        Me.HeightCmb.Size = New System.Drawing.Size(192, 24)
        Me.HeightCmb.TabIndex = 7
        '
        'RollCoverCmb
        '
        Me.RollCoverCmb.FormattingEnabled = True
        Me.RollCoverCmb.Items.AddRange(New Object() {"40", "40,5", "41", "41,5", "42", "42,5", "43", "43,5", "44", "44,5", "45", "45,5", "46", "46,5", "47", "47,5", "48", "48,5", "49", "49,5", "50"})
        Me.RollCoverCmb.Location = New System.Drawing.Point(237, 253)
        Me.RollCoverCmb.Name = "RollCoverCmb"
        Me.RollCoverCmb.Size = New System.Drawing.Size(192, 24)
        Me.RollCoverCmb.TabIndex = 8
        '
        'CalculateBtn
        '
        Me.CalculateBtn.Location = New System.Drawing.Point(498, 256)
        Me.CalculateBtn.Name = "CalculateBtn"
        Me.CalculateBtn.Size = New System.Drawing.Size(120, 29)
        Me.CalculateBtn.TabIndex = 10
        Me.CalculateBtn.Text = "Calculate"
        Me.CalculateBtn.UseVisualStyleBackColor = True
        '
        'ExitBtn
        '
        Me.ExitBtn.Location = New System.Drawing.Point(624, 256)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(118, 29)
        Me.ExitBtn.TabIndex = 11
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'SingleRollTxt
        '
        Me.SingleRollTxt.Location = New System.Drawing.Point(498, 161)
        Me.SingleRollTxt.Name = "SingleRollTxt"
        Me.SingleRollTxt.Size = New System.Drawing.Size(244, 22)
        Me.SingleRollTxt.TabIndex = 12
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 372)
        Me.Controls.Add(Me.SingleRollTxt)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.CalculateBtn)
        Me.Controls.Add(Me.RollCoverCmb)
        Me.Controls.Add(Me.HeightCmb)
        Me.Controls.Add(Me.WidthCmb)
        Me.Controls.Add(Me.LenghtCmb)
        Me.Controls.Add(Me.SingleRollLabel)
        Me.Controls.Add(Me.CoverageLabel)
        Me.Controls.Add(Me.WidthLabel)
        Me.Controls.Add(Me.HeightLabel)
        Me.Controls.Add(Me.LenghtLabel)
        Me.Name = "FormMain"
        Me.Text = "Wallpaper App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LenghtLabel As Label
    Friend WithEvents HeightLabel As Label
    Friend WithEvents WidthLabel As Label
    Friend WithEvents CoverageLabel As Label
    Friend WithEvents SingleRollLabel As Label
    Friend WithEvents LenghtCmb As ComboBox
    Friend WithEvents WidthCmb As ComboBox
    Friend WithEvents HeightCmb As ComboBox
    Friend WithEvents RollCoverCmb As ComboBox
    Friend WithEvents CalculateBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents SingleRollTxt As TextBox
End Class
