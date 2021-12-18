Imports SampleDataLib
Public Class DeleteForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer = CInt(TextBox1.Text)
        Dim component = DataFactory.GetComponent
        Try
            component.DeleteEmployee(id)
        Catch ex As EmployeeException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text = String.Empty Then
            MsgBox("ID must be entered")
        End If
    End Sub
End Class