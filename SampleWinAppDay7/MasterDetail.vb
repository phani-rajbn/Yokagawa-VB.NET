Imports SampleDataLib
Public Class MasterDetail
    Private Shared component As IDBComponent = DataFactory.GetComponent ' it becomes thread safe.
    Private Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        Dim table = component.GetAllEmployees
        lstNames.DataSource = table
        lstNames.DisplayMember = "EmpName" 'Tell which column of the table be displayed.
    End Sub
End Class