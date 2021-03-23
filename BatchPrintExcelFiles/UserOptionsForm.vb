Imports System.Windows.Forms

Public Class UserOptionsForm

	Dim FileCount As Integer = 0
	Public FileNameArray As String() = {}

	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		ExtensionComboBox.SelectedIndex = 0
		AddRow()
	End Sub

	Private Sub OpenFolderBrowser_Click(sender As Object, e As EventArgs) Handles OpenFolderBrowser.Click
		Dim result As DialogResult = BrowseFolderDialog.ShowDialog()
		If (result = DialogResult.OK) Then
			FolderPathText.Text = BrowseFolderDialog.SelectedPath
			GetFileNames()
		End If
	End Sub

	Private Sub ReadyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ReadyCheckBox.CheckedChanged
		If (ReadyCheckBox.Checked) Then
			PrintButton.Enabled = True
		Else
			PrintButton.Enabled = False
		End If
	End Sub

	Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
		If FileCount = 0 Then
			ErrorProvider1.SetError(
				FoundFilesLabel,
				"Please specify a folder and filename pattern that matches at least one file.")
		Else
			DialogResult = DialogResult.OK
		End If
	End Sub

	Private Sub AddRowButton_Click(sender As Object, e As EventArgs) Handles AddRowButton.Click
		AddRow()
	End Sub

	Private Sub FilenameRegexText_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles FilenameRegexText.Validating
		If String.IsNullOrWhiteSpace(FilenameRegexText.Text) Then
			FilenameRegexText.Text = "*"
		End If
	End Sub

	Private Sub FilenameRegexText_TextChanged(sender As Object, e As EventArgs) Handles FilenameRegexText.TextChanged
		GetFileNames()
	End Sub

	Private Sub ExtensionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExtensionComboBox.SelectedIndexChanged
		GetFileNames()
	End Sub

	Private Sub GetFileNames()
		' Put all the relevant filenames into a String array
		If Not String.IsNullOrWhiteSpace(BrowseFolderDialog.SelectedPath) Then
			FileNameArray =
				Directory.GetFiles(
					BrowseFolderDialog.SelectedPath,
					FilenameRegexText.Text & "." & ExtensionComboBox.SelectedItem.ToString()
				)
		End If

		FileCount = FileNameArray.Length

		FoundFilesLabel.Text = "Found " & FileCount & " eligible files in the selected directory."

		If Not FileCount = 0 Then
			ErrorProvider1.SetError(FoundFilesLabel, "")
		End If
	End Sub

	Private Sub AddRow()
		Dim editor = New CellEditor()
		AddHandler editor.DeleteButtonClicked, AddressOf DeleteRow
		FlowLayoutPanel4.Controls.Add(editor)
	End Sub

	Private Sub DeleteRow(sender As Object, e As EventArgs)
		If FlowLayoutPanel4.Controls.Contains(sender) Then
			Dim item = DirectCast(sender, CellEditor)
			RemoveHandler item.DeleteButtonClicked, AddressOf DeleteRow
			FlowLayoutPanel4.Controls.Remove(item)
			item.Dispose()
		End If
	End Sub

End Class