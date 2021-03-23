<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CellEditor
	Inherits System.Windows.Forms.UserControl

	'UserControl overrides dispose to clean up the component list.
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
		Me.CellToEdit = New System.Windows.Forms.TextBox()
		Me.TextToInsert = New System.Windows.Forms.TextBox()
		Me.DeleteButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'CellToEdit
		'
		Me.CellToEdit.Location = New System.Drawing.Point(5, 1)
		Me.CellToEdit.Name = "CellToEdit"
		Me.CellToEdit.Size = New System.Drawing.Size(77, 23)
		Me.CellToEdit.TabIndex = 0
		'
		'TextToInsert
		'
		Me.TextToInsert.Location = New System.Drawing.Point(97, 1)
		Me.TextToInsert.Name = "TextToInsert"
		Me.TextToInsert.Size = New System.Drawing.Size(268, 23)
		Me.TextToInsert.TabIndex = 2
		'
		'DeleteButton
		'
		Me.DeleteButton.Location = New System.Drawing.Point(372, 1)
		Me.DeleteButton.Name = "DeleteButton"
		Me.DeleteButton.Size = New System.Drawing.Size(24, 23)
		Me.DeleteButton.TabIndex = 3
		Me.DeleteButton.Text = "-"
		Me.DeleteButton.UseVisualStyleBackColor = True
		'
		'CellEditor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Controls.Add(Me.DeleteButton)
		Me.Controls.Add(Me.TextToInsert)
		Me.Controls.Add(Me.CellToEdit)
		Me.Name = "CellEditor"
		Me.Size = New System.Drawing.Size(396, 26)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents CellToEdit As Windows.Forms.TextBox
	Friend WithEvents TextToInsert As Windows.Forms.TextBox
	Friend WithEvents DeleteButton As Windows.Forms.Button
End Class
