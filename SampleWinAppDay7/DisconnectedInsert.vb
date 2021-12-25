Public Class DisconnectedInsert
    'Recommended to use connected model for insert, delete and update instead of disconnected model.
    Private Sub empDetails_Submit(sender As Object, e As EventArgs) Handles empDetails.Submit
        If ds.Tables("Employees") Is Nothing Then
            DisconnectedModel.CreateEmployees()
        End If
        Dim id = CInt(empDetails.txtID.Text)
        Dim name = empDetails.txtName.Text
        Dim address = empDetails.txtAddress.Text
        Dim salary = CDbl(empDetails.txtSalary.Text)
        DisconnectedModel.InsertRecord(id, name, address, salary)
        Me.Close()
    End Sub
End Class