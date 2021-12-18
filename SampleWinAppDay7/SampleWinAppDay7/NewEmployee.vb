Imports SampleDataLib
Public Class NewEmployee
    Private Sub Employee1_Submit(sender As Object, e As EventArgs) Handles Employee1.Submit
        If TextValidate() Then
            Dim id = CInt(Employee1.txtID.Text)
            Dim name = Employee1.txtName.Text
            Dim address = Employee1.txtAddress.Text
            Dim salary = CDbl(Employee1.txtSalary.Text)
            Dim component = DataFactory.GetComponent
            Try
                component.AddEmployee(id, name, address, salary)
                MsgBox("Employee inserted successfully")
                Me.Close()
            Catch ex As EmployeeException
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Data is not valid")
            Return
        End If
    End Sub
    Private Function TextValidate() As Boolean
        Dim status As Boolean = True
        If String.IsNullOrEmpty(Employee1.txtID.Text) Then status = False
        If String.IsNullOrEmpty(Employee1.txtName.Text) Then status = False
        If String.IsNullOrEmpty(Employee1.txtAddress.Text) Then status = False
        If String.IsNullOrEmpty(Employee1.txtSalary.Text) Then status = False
        Return status
    End Function
End Class