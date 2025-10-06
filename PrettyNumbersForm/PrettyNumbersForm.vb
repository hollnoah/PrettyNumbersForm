'Add engineering notation with metric prefixes
Public Class PrettyNumbersForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub



    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        If InputTextBox.Text <> "" And IsNumeric(InputTextBox.Text) Then
            'get text from textbox1 and format in scientific notation using tostring method
            InputTextBox.Text = CDec(InputTextBox.Text).ToString("E2")
        End If
    End Sub
End Class
