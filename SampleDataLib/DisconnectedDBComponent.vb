Imports System.Data.SqlClient
Imports System.Configuration
'it is not public
Class DisconnectedDBComponent
    Implements IDBComponent
    'Set thru a variable and should not be modified
    Shared ReadOnly strCon As String = ConfigurationManager.ConnectionStrings("myCon").ConnectionString
    Const strCmd As String = "SELECT * FROM TBLEMPLOYEE" 'Not to be modifieds
    Shared ds As New DataSet 'singleton and thread safe
    Shared adapter As New SqlDataAdapter(strCmd, strCon)
    Shared cmdBuilder As New SqlCommandBuilder(adapter) 'Auto generating SQL statements. 
    'Data is filled when the object is created. 
    Public Sub New()
        If ds.Tables("Employees") Is Nothing Then
            adapter.Fill(ds, "Employees")
        End If
    End Sub
    Public Sub AddEmployee(id As Integer, name As String, address As String, salary As Double) Implements IDBComponent.AddEmployee
        Dim row = ds.Tables("Employees").NewRow
        row(0) = id
        row(1) = name
        row(2) = address
        row(3) = salary
        ds.Tables("Employees").Rows.Add(row)
        adapter.Update(ds, "Employees")
    End Sub

    Public Sub UpdateEmployee(id As Integer, name As String, address As String, salary As Double) Implements IDBComponent.UpdateEmployee
        For Each row As DataRow In ds.Tables("Employees").Rows
            If row(0) = id Then
                row(1) = name
                row(2) = address
                row(3) = salary
                adapter.Update(ds, "Employees")
                Return
            End If
        Next
        Throw New Exception($"No employee by ID {id} found to update")
    End Sub

    Public Sub DeleteEmployee(id As Integer) Implements IDBComponent.DeleteEmployee
        For Each row As DataRow In ds.Tables("Employees").Rows
            If row(0) = id Then
                row.Delete() 'deletes the row from the datatable
                adapter.Update(ds, "Employees")
                Return
            End If
        Next
        Throw New Exception($"No employee by ID {id} found to Delete")
    End Sub

    Public Function GetAllEmployees() As DataTable Implements IDBComponent.GetAllEmployees
        Return ds.Tables("Employees")
    End Function
End Class
