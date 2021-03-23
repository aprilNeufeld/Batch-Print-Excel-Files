
Public Class CustomMessageBox

	Private Sub ReadyCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ReadyCheckBox.CheckedChanged

		If (ReadyCheckBox.Checked) Then
			ContinueButton.Enabled = True
		Else
			ContinueButton.Enabled = False
		End If
	End Sub

End Class