<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.savevoteButton = New System.Windows.Forms.Button()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.budwesierLabel = New System.Windows.Forms.Label()
        Me.pepsiLabel = New System.Windows.Forms.Label()
        Me.fedexLabel = New System.Windows.Forms.Label()
        Me.etradeLabel = New System.Windows.Forms.Label()
        Me.budwesierdisplayLabel = New System.Windows.Forms.Label()
        Me.pepsidisplayLabel = New System.Windows.Forms.Label()
        Me.fedexdisplayLabel = New System.Windows.Forms.Label()
        Me.etradedisplayLabel = New System.Windows.Forms.Label()
        Me.commercialListBox = New System.Windows.Forms.ListBox()
        Me.CommercialLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'savevoteButton
        '
        Me.savevoteButton.Location = New System.Drawing.Point(371, 112)
        Me.savevoteButton.Name = "savevoteButton"
        Me.savevoteButton.Size = New System.Drawing.Size(89, 23)
        Me.savevoteButton.TabIndex = 0
        Me.savevoteButton.Text = "&Save  vote"
        Me.savevoteButton.UseVisualStyleBackColor = True
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(371, 159)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(89, 23)
        Me.displayButton.TabIndex = 1
        Me.displayButton.Text = "&Display votes"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(371, 208)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(89, 23)
        Me.exitButton.TabIndex = 2
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'budwesierLabel
        '
        Me.budwesierLabel.AutoSize = True
        Me.budwesierLabel.Location = New System.Drawing.Point(58, 270)
        Me.budwesierLabel.Name = "budwesierLabel"
        Me.budwesierLabel.Size = New System.Drawing.Size(61, 13)
        Me.budwesierLabel.TabIndex = 3
        Me.budwesierLabel.Text = "Budwesier"
        '
        'pepsiLabel
        '
        Me.pepsiLabel.AutoSize = True
        Me.pepsiLabel.Location = New System.Drawing.Point(167, 270)
        Me.pepsiLabel.Name = "pepsiLabel"
        Me.pepsiLabel.Size = New System.Drawing.Size(34, 13)
        Me.pepsiLabel.TabIndex = 4
        Me.pepsiLabel.Text = "Pepsi"
        '
        'fedexLabel
        '
        Me.fedexLabel.AutoSize = True
        Me.fedexLabel.Location = New System.Drawing.Point(265, 270)
        Me.fedexLabel.Name = "fedexLabel"
        Me.fedexLabel.Size = New System.Drawing.Size(40, 13)
        Me.fedexLabel.TabIndex = 5
        Me.fedexLabel.Text = "FedEx:"
        '
        'etradeLabel
        '
        Me.etradeLabel.AutoSize = True
        Me.etradeLabel.Location = New System.Drawing.Point(380, 270)
        Me.etradeLabel.Name = "etradeLabel"
        Me.etradeLabel.Size = New System.Drawing.Size(46, 13)
        Me.etradeLabel.TabIndex = 6
        Me.etradeLabel.Text = "ETRADE"
        '
        'budwesierdisplayLabel
        '
        Me.budwesierdisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.budwesierdisplayLabel.Location = New System.Drawing.Point(61, 298)
        Me.budwesierdisplayLabel.Name = "budwesierdisplayLabel"
        Me.budwesierdisplayLabel.Size = New System.Drawing.Size(58, 24)
        Me.budwesierdisplayLabel.TabIndex = 7
        '
        'pepsidisplayLabel
        '
        Me.pepsidisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pepsidisplayLabel.Location = New System.Drawing.Point(170, 298)
        Me.pepsidisplayLabel.Name = "pepsidisplayLabel"
        Me.pepsidisplayLabel.Size = New System.Drawing.Size(58, 24)
        Me.pepsidisplayLabel.TabIndex = 8
        '
        'fedexdisplayLabel
        '
        Me.fedexdisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fedexdisplayLabel.Location = New System.Drawing.Point(268, 298)
        Me.fedexdisplayLabel.Name = "fedexdisplayLabel"
        Me.fedexdisplayLabel.Size = New System.Drawing.Size(58, 24)
        Me.fedexdisplayLabel.TabIndex = 9
        '
        'etradedisplayLabel
        '
        Me.etradedisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.etradedisplayLabel.Location = New System.Drawing.Point(383, 298)
        Me.etradedisplayLabel.Name = "etradedisplayLabel"
        Me.etradedisplayLabel.Size = New System.Drawing.Size(58, 24)
        Me.etradedisplayLabel.TabIndex = 10
        '
        'commercialListBox
        '
        Me.commercialListBox.FormattingEnabled = True
        Me.commercialListBox.Location = New System.Drawing.Point(52, 112)
        Me.commercialListBox.Name = "commercialListBox"
        Me.commercialListBox.Size = New System.Drawing.Size(244, 147)
        Me.commercialListBox.TabIndex = 11
        '
        'CommercialLabel
        '
        Me.CommercialLabel.AutoSize = True
        Me.CommercialLabel.Location = New System.Drawing.Point(52, 67)
        Me.CommercialLabel.Name = "CommercialLabel"
        Me.CommercialLabel.Size = New System.Drawing.Size(74, 13)
        Me.CommercialLabel.TabIndex = 12
        Me.CommercialLabel.Text = "Commercials:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 358)
        Me.Controls.Add(Me.CommercialLabel)
        Me.Controls.Add(Me.commercialListBox)
        Me.Controls.Add(Me.etradedisplayLabel)
        Me.Controls.Add(Me.fedexdisplayLabel)
        Me.Controls.Add(Me.pepsidisplayLabel)
        Me.Controls.Add(Me.budwesierdisplayLabel)
        Me.Controls.Add(Me.etradeLabel)
        Me.Controls.Add(Me.fedexLabel)
        Me.Controls.Add(Me.pepsiLabel)
        Me.Controls.Add(Me.budwesierLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.savevoteButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.Text = "WKRK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents savevoteButton As System.Windows.Forms.Button
    Friend WithEvents displayButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button
    Friend WithEvents budwesierLabel As System.Windows.Forms.Label
    Friend WithEvents pepsiLabel As System.Windows.Forms.Label
    Friend WithEvents fedexLabel As System.Windows.Forms.Label
    Friend WithEvents etradeLabel As System.Windows.Forms.Label
    Friend WithEvents budwesierdisplayLabel As System.Windows.Forms.Label
    Friend WithEvents pepsidisplayLabel As System.Windows.Forms.Label
    Friend WithEvents fedexdisplayLabel As System.Windows.Forms.Label
    Friend WithEvents etradedisplayLabel As System.Windows.Forms.Label
    Friend WithEvents commercialListBox As System.Windows.Forms.ListBox
    Friend WithEvents CommercialLabel As System.Windows.Forms.Label

End Class
