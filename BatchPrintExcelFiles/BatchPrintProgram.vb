Imports System.Windows.Forms
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports System.Diagnostics.Process
Imports System.Text

Namespace BatchPrintExcelFiles

	Public Module BatchPrintProgram
		Dim DebugMode As Boolean = False
		ReadOnly DebugText As New StringBuilder
		Dim Options As UserOptions

		Enum UserStatus
			Ready = 0
			Abort = 1
		End Enum

		Sub Main()
			' Get user input and prepare system
			Dim Status = Initialize()

			If Status = UserStatus.Ready Then
				' Begin the main work
				PrintFiles()
			End If

			' So that the console doesn't exit immediately
			' after we've aborted or completed the program
			Console.Write(vbCrLf & "Press any key to exit...")
			Console.ReadKey()
		End Sub

		'
		' Begins the program by asking the user for confirmation
		' and configuration, as well as attempting to end any existing
		' Excel processes. Returns UserStatus.Abort if the user cancels
		' at any point or if there are any fatal errors; otherwise
		' returns UserStatus.Ready.
		'
		Function Initialize() As UserStatus
			Dim process As Process()
			Dim ReadyDialog As New CustomMessageBox()

			' Display a pop-up that waits for user input before continuing
			Dim Result = ReadyDialog.ShowDialog()

			' Exit the program if the user cancels
			If Result = DialogResult.Cancel Then
				Console.WriteLine("Printing cancelled by user.")
				Return UserStatus.Abort
			ElseIf Result = DialogResult.OK Then
				' Otherwise check if they want to start in debug mode
				If ReadyDialog.DebugModeCheckBox.Checked Then
					DebugMode = True
					Console.WriteLine("Debug Mode activated.")
				End If
			End If

			' Get printing options from the user
			Options = GetUserOptions()
			If (Options Is Nothing) Then
				Console.WriteLine("Printing cancelled by user.")
				Return UserStatus.Abort
			End If

			' Attempt to end existing Excel processes
			process = GetProcessesByName("EXCEL")
			If process.Length > 0 Then
				PrintDebug(DebugMode, "Ending existing Excel processes...")
				Try
					For i As Integer = 0 To process.Length - 1
						process(i).Kill()
						process(i).WaitForExit()
					Next i
					PrintDebug(DebugMode, "All current processes ended.")
				Catch ex As Exception
					' Print the error and exit the program
					Console.WriteLine(ex.Message)
					Return UserStatus.Abort
				End Try
			End If

			Return UserStatus.Ready

		End Function

		'
		' Shows a dialog that asks the user for configuration options
		' for the print:
		' 1. The folder that contains the files to print
		' 2. Any edits to be made to particular cells in each file before print
		'
		Public Function GetUserOptions() As UserOptions
			Dim options As New UserOptions()

			' If this program is still being used in 2030, wow. Get a new system.
			' Also, send me an email at april.neufeld@gmail.com so I know my program
			' has lasted for 9 years!
			Dim Form1 As New UserOptionsForm()

			' Show the dialog
			Dim result As DialogResult = Form1.ShowDialog()

			' Get the information entered by the user
			If (result = DialogResult.OK) Then
				options.FilenameArray = Form1.FileNameArray

				For Each cellEditInfo As CellEditor In Form1.FlowLayoutPanel4.Controls
					Dim cell = cellEditInfo.CellToEdit.Text
					Dim text = cellEditInfo.TextToInsert.Text

					If Not String.IsNullOrWhiteSpace(cell) _
						And Not String.IsNullOrWhiteSpace(text) Then
						options.CellEditInfo.Add(cell, text)
					End If
				Next
			Else
				' If the user cancels
				Return Nothing
			End If

			Form1.Dispose()

			Return options

		End Function

		'
		' Does the work of looping through each eligible file in the
		' chosen directory. Opens, edits, and prints each one, showing
		' a progress bar in the bottom of the console throughout. 
		'
		Sub PrintFiles()
			Dim FileCount As Integer

			' Excel references
			Dim xlApp As Excel.Application = Nothing
			Dim xlBook As Excel._Workbook = Nothing
			Dim xlSheet As Excel._Worksheet = Nothing
			Dim xlCell As Excel.Range = Nothing

			FileCount = Options.FilenameArray.Length

			' This is checked in the selection dialog already, but
			' just in case it's also here.
			If (FileCount = 0) Then
				Console.WriteLine("No files to print. Exiting program.")
				Exit Sub
			End If

			Console.WriteLine("Printing your files, please wait...")

			Try
				Using ProgressBar = New ProgressBar(FileCount)
					Dim currentFile As Integer = 0
					Dim progress As Integer = 0
					Dim totalWork As Integer = FileCount * 2

					' Loop through the files
					For Each file As String In Options.FilenameArray

						' Get the Excel Application object
						PrintDebug(DebugMode, vbCrLf & "Opening " & file & "...")
						xlApp = New Excel.Application()

						' Attempt to open the Excel file
						xlBook = xlApp.Workbooks.Open(file)
						progress += 1
						ProgressBar.Report((progress / totalWork), currentFile)

						' Get the first sheet
						xlSheet = xlBook.Worksheets(1)

						' Get the cell editing options
						For Each item As KeyValuePair(Of String, String) In Options.CellEditInfo
							xlCell = xlSheet.Range(item.Key)

							' Replace the cell's text
							If (String.Compare(item.Value, xlCell.Text) <> 0) Then
								PrintDebug(DebugMode, "Replaced '" & xlCell.Text & "' with '" _
											  & item.Value & "'.")
								If (DebugMode = False) Then
									xlCell.Value = item.Value
								End If
							End If
						Next

						' Print
						PrintDebug(DebugMode, "Printing...")
						If (DebugMode = False) Then
							xlBook.PrintOutEx(Preview:=False)
						End If
						PrintDebug(DebugMode, "Printed.")

						' Close the file
						PrintDebug(DebugMode, "Closing Excel...")
						xlBook.Close(SaveChanges:=True)
						xlApp.Quit()

						' Update the progress bar
						currentFile += 1
						progress += 1
						ProgressBar.Report((progress / totalWork), currentFile)
					Next
				End Using

				' Success!
				Console.WriteLine(vbCrLf & "Congratulations! Your " & FileCount &
								  " files have been printed.")

				' Check if they want to read the debug text
				If DebugMode Then
					Console.Write("Do you want to read the debug log? Y/N: ")
					Dim key = Console.ReadKey()

					If key.Key = ConsoleKey.Y Then
						Console.WriteLine(DebugText.ToString)
					End If
				End If

			Catch ex As Exception
				Console.WriteLine(vbCrLf & "Error while accessing Excel. Details: " &
								  ex.Message & vbCrLf)

			Finally
				' Garbage collection
				GC.Collect()
				GC.WaitForPendingFinalizers()

				If xlSheet IsNot Nothing Then
					Marshal.ReleaseComObject(xlSheet)
				End If

				If xlBook IsNot Nothing Then
					Marshal.ReleaseComObject(xlBook)
				End If

				If xlApp IsNot Nothing Then
					Marshal.ReleaseComObject(xlApp)
				End If

				Options = Nothing

				GC.Collect()
				GC.WaitForPendingFinalizers()
			End Try
		End Sub

		Sub PrintDebug(DebugMode As Boolean, Message As String)
			If DebugMode = True Then
				DebugText.AppendLine(Message)
			End If
		End Sub

	End Module
End Namespace
