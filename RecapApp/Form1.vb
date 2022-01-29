Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtFind_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim component As IDataComponent = New DataComponent
            Dim data = component.FindEmployee(txtFind.Text)
            ListBox1.DataSource = data
            ListBox1.DisplayMember = "EmpName"
        End If
    End Sub
End Class
