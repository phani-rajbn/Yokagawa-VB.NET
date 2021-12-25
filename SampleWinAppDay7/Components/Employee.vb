Public Class Employee
    Public Event Submit As EventHandler 'Create a Custom Event which is triggered when the button is clicked

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        RaiseEvent Submit(sender, e) 'Raising the event called Submit
    End Sub

    Private empID_Enabled As Boolean
    Public Property EmpIDEnabled() As Boolean
        Get
            Return txtID.Enabled
        End Get
        Set(ByVal value As Boolean)
            empID_Enabled = value
            txtID.Enabled = empID_Enabled
        End Set
    End Property


End Class
