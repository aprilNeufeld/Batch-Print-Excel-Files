<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserOptionsForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserOptionsForm))
		Me.Label3 = New System.Windows.Forms.Label()
		Me.BrowseFolderDialog = New System.Windows.Forms.FolderBrowserDialog()
		Me.OpenFolderBrowser = New System.Windows.Forms.Button()
		Me.FolderPathText = New System.Windows.Forms.TextBox()
		Me.PrintButton = New System.Windows.Forms.Button()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.CancelButton = New System.Windows.Forms.Button()
		Me.ReadyCheckBox = New System.Windows.Forms.CheckBox()
		Me.FoundFilesLabel = New System.Windows.Forms.Label()
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		Me.FilenameRegexText = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ExtensionComboBox = New System.Windows.Forms.ComboBox()
		Me.AddRowButton = New System.Windows.Forms.Button()
		Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
		Me.InsertTextLabel = New System.Windows.Forms.Label()
		Me.CellLabel = New System.Windows.Forms.Label()
		Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
		Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
		Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
		Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FlowLayoutPanel3.SuspendLayout()
		Me.FlowLayoutPanel2.SuspendLayout()
		Me.FlowLayoutPanel1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(11, 127)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(43, 15)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Folder:"
		'
		'OpenFolderBrowser
		'
		Me.OpenFolderBrowser.Location = New System.Drawing.Point(421, 123)
		Me.OpenFolderBrowser.Name = "OpenFolderBrowser"
		Me.OpenFolderBrowser.Size = New System.Drawing.Size(75, 23)
		Me.OpenFolderBrowser.TabIndex = 5
		Me.OpenFolderBrowser.Text = "Browse..."
		Me.OpenFolderBrowser.UseVisualStyleBackColor = True
		'
		'FolderPathText
		'
		Me.FolderPathText.Location = New System.Drawing.Point(60, 124)
		Me.FolderPathText.Name = "FolderPathText"
		Me.FolderPathText.ReadOnly = True
		Me.FolderPathText.Size = New System.Drawing.Size(355, 23)
		Me.FolderPathText.TabIndex = 6
		'
		'PrintButton
		'
		Me.PrintButton.Enabled = False
		Me.PrintButton.Location = New System.Drawing.Point(250, 3)
		Me.PrintButton.Name = "PrintButton"
		Me.PrintButton.Size = New System.Drawing.Size(241, 32)
		Me.PrintButton.TabIndex = 7
		Me.PrintButton.Text = "Print Files"
		Me.PrintButton.UseVisualStyleBackColor = True
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(10, 22)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(475, 75)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = resources.GetString("Label4.Text")
		'
		'CancelButton
		'
		Me.CancelButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.CancelButton.Location = New System.Drawing.Point(3, 3)
		Me.CancelButton.Name = "CancelButton"
		Me.CancelButton.Size = New System.Drawing.Size(241, 32)
		Me.CancelButton.TabIndex = 9
		Me.CancelButton.Text = "Cancel"
		Me.CancelButton.UseVisualStyleBackColor = True
		'
		'ReadyCheckBox
		'
		Me.ReadyCheckBox.AutoSize = True
		Me.ReadyCheckBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.ReadyCheckBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
		Me.ReadyCheckBox.Location = New System.Drawing.Point(10, 61)
		Me.ReadyCheckBox.Margin = New System.Windows.Forms.Padding(10, 20, 3, 3)
		Me.ReadyCheckBox.Name = "ReadyCheckBox"
		Me.ReadyCheckBox.Size = New System.Drawing.Size(287, 19)
		Me.ReadyCheckBox.TabIndex = 10
		Me.ReadyCheckBox.Text = "*I am ready to print all these files.* (REQUIRED)"
		Me.ReadyCheckBox.UseVisualStyleBackColor = True
		'
		'FoundFilesLabel
		'
		Me.FoundFilesLabel.AutoSize = True
		Me.FoundFilesLabel.Location = New System.Drawing.Point(115, 190)
		Me.FoundFilesLabel.Name = "FoundFilesLabel"
		Me.FoundFilesLabel.Size = New System.Drawing.Size(260, 15)
		Me.FoundFilesLabel.TabIndex = 11
		Me.FoundFilesLabel.Text = "Found 0 matching files in the selected directory."
		'
		'ErrorProvider1
		'
		Me.ErrorProvider1.ContainerControl = Me
		'
		'FilenameRegexText
		'
		Me.FilenameRegexText.Location = New System.Drawing.Point(115, 164)
		Me.FilenameRegexText.Name = "FilenameRegexText"
		Me.FilenameRegexText.Size = New System.Drawing.Size(172, 23)
		Me.FilenameRegexText.TabIndex = 12
		Me.FilenameRegexText.Text = "*"
		Me.FilenameRegexText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(10, 167)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(99, 15)
		Me.Label1.TabIndex = 13
		Me.Label1.Text = "Filename Pattern:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
		Me.Label2.Location = New System.Drawing.Point(289, 169)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(13, 19)
		Me.Label2.TabIndex = 15
		Me.Label2.Text = "."
		'
		'ExtensionComboBox
		'
		Me.ExtensionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.ExtensionComboBox.FormattingEnabled = True
		Me.ExtensionComboBox.Items.AddRange(New Object() {"xlsx", "xlsm", "xml", "xls"})
		Me.ExtensionComboBox.Location = New System.Drawing.Point(304, 163)
		Me.ExtensionComboBox.Name = "ExtensionComboBox"
		Me.ExtensionComboBox.Size = New System.Drawing.Size(72, 23)
		Me.ExtensionComboBox.TabIndex = 17
		'
		'AddRowButton
		'
		Me.AddRowButton.Location = New System.Drawing.Point(3, 9)
		Me.AddRowButton.Name = "AddRowButton"
		Me.AddRowButton.Size = New System.Drawing.Size(114, 23)
		Me.AddRowButton.TabIndex = 19
		Me.AddRowButton.Text = "+ Add an Edit"
		Me.AddRowButton.UseVisualStyleBackColor = True
		'
		'InsertTextLabel
		'
		Me.InsertTextLabel.AutoSize = True
		Me.InsertTextLabel.Location = New System.Drawing.Point(115, 224)
		Me.InsertTextLabel.Name = "InsertTextLabel"
		Me.InsertTextLabel.Size = New System.Drawing.Size(77, 15)
		Me.InsertTextLabel.TabIndex = 21
		Me.InsertTextLabel.Text = "Text to Insert:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'CellLabel
		'
		Me.CellLabel.AutoSize = True
		Me.CellLabel.Location = New System.Drawing.Point(16, 224)
		Me.CellLabel.Name = "CellLabel"
		Me.CellLabel.Size = New System.Drawing.Size(77, 15)
		Me.CellLabel.TabIndex = 20
		Me.CellLabel.Text = "Cell Number:"
		'
		'FlowLayoutPanel3
		'
		Me.FlowLayoutPanel3.AutoSize = True
		Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel3.Controls.Add(Me.FlowLayoutPanel4)
		Me.FlowLayoutPanel3.Controls.Add(Me.AddRowButton)
		Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel3.MinimumSize = New System.Drawing.Size(500, 2)
		Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
		Me.FlowLayoutPanel3.Size = New System.Drawing.Size(500, 35)
		Me.FlowLayoutPanel3.TabIndex = 22
		'
		'FlowLayoutPanel4
		'
		Me.FlowLayoutPanel4.AutoSize = True
		Me.FlowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 3)
		Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
		Me.FlowLayoutPanel4.Size = New System.Drawing.Size(0, 0)
		Me.FlowLayoutPanel4.TabIndex = 20
		'
		'FlowLayoutPanel2
		'
		Me.FlowLayoutPanel2.AutoSize = True
		Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel3)
		Me.FlowLayoutPanel2.Controls.Add(Me.ReadyCheckBox)
		Me.FlowLayoutPanel2.Controls.Add(Me.FlowLayoutPanel1)
		Me.FlowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
		Me.FlowLayoutPanel2.Location = New System.Drawing.Point(10, 242)
		Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
		Me.FlowLayoutPanel2.Size = New System.Drawing.Size(506, 127)
		Me.FlowLayoutPanel2.TabIndex = 24
		'
		'FlowLayoutPanel1
		'
		Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.FlowLayoutPanel1.Controls.Add(Me.CancelButton)
		Me.FlowLayoutPanel1.Controls.Add(Me.PrintButton)
		Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 86)
		Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
		Me.FlowLayoutPanel1.Size = New System.Drawing.Size(500, 38)
		Me.FlowLayoutPanel1.TabIndex = 11
		'
		'UserOptionsForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSize = True
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ClientSize = New System.Drawing.Size(519, 392)
		Me.Controls.Add(Me.FlowLayoutPanel2)
		Me.Controls.Add(Me.InsertTextLabel)
		Me.Controls.Add(Me.CellLabel)
		Me.Controls.Add(Me.ExtensionComboBox)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.FilenameRegexText)
		Me.Controls.Add(Me.FoundFilesLabel)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.FolderPathText)
		Me.Controls.Add(Me.OpenFolderBrowser)
		Me.Controls.Add(Me.Label3)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Name = "UserOptionsForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Configuration Options"
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FlowLayoutPanel3.ResumeLayout(False)
		Me.FlowLayoutPanel3.PerformLayout()
		Me.FlowLayoutPanel2.ResumeLayout(False)
		Me.FlowLayoutPanel2.PerformLayout()
		Me.FlowLayoutPanel1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents Label3 As Windows.Forms.Label
	Friend WithEvents BrowseFolderDialog As Windows.Forms.FolderBrowserDialog
	Friend WithEvents OpenFolderBrowser As Windows.Forms.Button
	Friend WithEvents FolderPathText As Windows.Forms.TextBox
	Friend WithEvents PrintButton As Windows.Forms.Button
	Friend WithEvents Label4 As Windows.Forms.Label
	Friend WithEvents CancelButton As Windows.Forms.Button
	Friend WithEvents ReadyCheckBox As Windows.Forms.CheckBox
	Friend WithEvents FoundFilesLabel As Windows.Forms.Label
	Friend WithEvents ErrorProvider1 As Windows.Forms.ErrorProvider
	Friend WithEvents Label1 As Windows.Forms.Label
	Friend WithEvents FilenameRegexText As Windows.Forms.TextBox
	Friend WithEvents Label2 As Windows.Forms.Label
	Friend WithEvents ExtensionComboBox As Windows.Forms.ComboBox
	Friend WithEvents AddRowButton As Windows.Forms.Button
	Friend WithEvents BindingSource1 As Windows.Forms.BindingSource
	Friend WithEvents InsertTextLabel As Windows.Forms.Label
	Friend WithEvents CellLabel As Windows.Forms.Label
	Friend WithEvents FlowLayoutPanel3 As Windows.Forms.FlowLayoutPanel
	Friend WithEvents FlowLayoutPanel4 As Windows.Forms.FlowLayoutPanel
	Friend WithEvents FlowLayoutPanel2 As Windows.Forms.FlowLayoutPanel
	Friend WithEvents FlowLayoutPanel1 As Windows.Forms.FlowLayoutPanel
End Class
