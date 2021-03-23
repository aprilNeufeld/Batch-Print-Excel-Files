Public Class CellEditor
	Public Event DeleteButtonClicked As EventHandler

	Protected Overridable Sub OnDeleteButtonClicked(sender As Object, e As EventArgs) Handles DeleteButton.Click
		RaiseEvent DeleteButtonClicked(Me, e)
	End Sub

End Class
