<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomMessageBox
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
		Me.components = New System.ComponentModel.Container()
		Me.LabelCaption = New System.Windows.Forms.Label()
		Me.CancelButton = New System.Windows.Forms.Button()
		Me.ContinueButton = New System.Windows.Forms.Button()
		Me.ReadyCheckBox = New System.Windows.Forms.CheckBox()
		Me.DebugModeCheckBox = New System.Windows.Forms.CheckBox()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'LabelCaption
		'
		Me.LabelCaption.AutoSize = True
		Me.LabelCaption.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.LabelCaption.Location = New System.Drawing.Point(22, 102)
		Me.LabelCaption.Name = "LabelCaption"
		Me.LabelCaption.Size = New System.Drawing.Size(373, 19)
		Me.LabelCaption.TabIndex = 0
		Me.LabelCaption.Text = "Please save your work and close ALL Excel documents." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'CancelButton
		'
		Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CancelButton.Location = New System.Drawing.Point(22, 221)
		Me.CancelButton.Name = "CancelButton"
		Me.CancelButton.Size = New System.Drawing.Size(124, 35)
		Me.CancelButton.TabIndex = 1
		Me.CancelButton.Text = "Cancel"
		Me.ToolTip1.SetToolTip(Me.CancelButton, "Exits the program without printing.")
		Me.CancelButton.UseVisualStyleBackColor = True
		'
		'ContinueButton
		'
		Me.ContinueButton.DialogResult = System.Windows.Forms.DialogResult.OK
		Me.ContinueButton.Enabled = False
		Me.ContinueButton.Location = New System.Drawing.Point(327, 221)
		Me.ContinueButton.Name = "ContinueButton"
		Me.ContinueButton.Size = New System.Drawing.Size(124, 35)
		Me.ContinueButton.TabIndex = 2
		Me.ContinueButton.Text = "Continue"
		Me.ToolTip1.SetToolTip(Me.ContinueButton, "Continue to the next step, where you can " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose the folder location and the dat" &
		"e before" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "printing.")
		Me.ContinueButton.UseVisualStyleBackColor = True
		'
		'ReadyCheckBox
		'
		Me.ReadyCheckBox.AutoSize = True
		Me.ReadyCheckBox.BackColor = System.Drawing.SystemColors.Control
		Me.ReadyCheckBox.Cursor = System.Windows.Forms.Cursors.Default
		Me.ReadyCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Red
		Me.ReadyCheckBox.FlatAppearance.BorderSize = 3
		Me.ReadyCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.ReadyCheckBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.ReadyCheckBox.Location = New System.Drawing.Point(22, 143)
		Me.ReadyCheckBox.Name = "ReadyCheckBox"
		Me.ReadyCheckBox.Size = New System.Drawing.Size(339, 19)
		Me.ReadyCheckBox.TabIndex = 3
		Me.ReadyCheckBox.Text = "*I have saved all my work and exited Excel.* (REQUIRED)"
		Me.ToolTip1.SetToolTip(Me.ReadyCheckBox, "The program will terminate all Excel processes before" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "starting. You must check t" &
		"his box before you may proceed.")
		Me.ReadyCheckBox.UseVisualStyleBackColor = False
		'
		'DebugModeCheckBox
		'
		Me.DebugModeCheckBox.AutoSize = True
		Me.DebugModeCheckBox.Location = New System.Drawing.Point(22, 168)
		Me.DebugModeCheckBox.Name = "DebugModeCheckBox"
		Me.DebugModeCheckBox.Size = New System.Drawing.Size(134, 19)
		Me.DebugModeCheckBox.TabIndex = 4
		Me.DebugModeCheckBox.Text = "Run in debug mode."
		Me.ToolTip1.SetToolTip(Me.DebugModeCheckBox, "Runs the program with all debug messages but " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "does not actually alter or print a" &
		"ny files. ")
		Me.DebugModeCheckBox.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
		Me.Label1.Location = New System.Drawing.Point(22, 42)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(352, 30)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "This program will batch print all Excel files whose names match a " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "user-specifie" &
	"d regular expression."
		'
		'CustomMessageBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(475, 268)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.DebugModeCheckBox)
		Me.Controls.Add(Me.ReadyCheckBox)
		Me.Controls.Add(Me.ContinueButton)
		Me.Controls.Add(Me.CancelButton)
		Me.Controls.Add(Me.LabelCaption)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "CustomMessageBox"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "It's time to batch print your files!"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents LabelCaption As Windows.Forms.Label
	Friend WithEvents CancelButton As Windows.Forms.Button
	Friend WithEvents ContinueButton As Windows.Forms.Button
	Friend WithEvents ReadyCheckBox As Windows.Forms.CheckBox
	Friend WithEvents DebugModeCheckBox As Windows.Forms.CheckBox
	Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
	Friend WithEvents Label1 As Windows.Forms.Label
End Class
