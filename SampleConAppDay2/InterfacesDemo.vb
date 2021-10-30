' Interfaces are like Abstract classes but all the methods of the interface are must inherit. 
' They are always public. 
' A class can implement multiple interfaces at the same level. All interfaces are abstract classes but all abstract classes are not interfaces. Abstract classes can have normal methods.
' interfaces are the basis for many frameworks that are created in the Computing world.
Imports System.Data
Module InterfacesDemo
    Sub Main()
        Dim obj As IDataComponent
        obj = New EmpDataComponent
        Dim records = obj.GetAllEmployees
        For Each row In records.Rows
            Console.WriteLine($"{row(0)} - {row("EmpName")} - {row("EmpAddress")}")
        Next
    End Sub
End Module
Interface IDataComponent
    Sub AddEmployee(id As Integer, name As String, address As String)
    Sub UpdateEmployee(id As Integer, name As String, address As String)
    Sub DeleteEmployee(id As Integer)
    Function GetAllEmployees() As DataTable
End Interface
'Implements keyword in a method is useful when U want to have single implementation for multiple  methods of one or more interfaces. 
'If a class implements the interface, it must implement all the methods of the interface, else it should be marked as must inherit
Class EmpDataComponent
    Implements IDataComponent
    Dim table As New DataTable
    Public Sub New() 'Construtor in VB.NET
        Initialize()
    End Sub
    Sub Initialize()
        table.Columns.Add(New DataColumn("EmpID", GetType(Integer)))
        table.Columns.Add(New DataColumn("EmpName", GetType(String)))
        table.Columns.Add(New DataColumn("EmpAddress", GetType(String)))
        table.PrimaryKey = New DataColumn() {table.Columns(0)}
        AddEmployee(111, "Phaniraj", "Bangalore")
        AddEmployee(112, "Vivek", "Bangalore")
        AddEmployee(113, "Rachana", "Bangalore")
        AddEmployee(114, "Govind", "Bangalore")
        AddEmployee(115, "Gopal", "Bangalore")
    End Sub
    Public Sub AddEmployee(id As Integer, name As String, address As String) Implements IDataComponent.AddEmployee
        Dim row = table.NewRow 'Create new blank row with schema of the table
        row(0) = id 'set the values taken from the parameters
        row(1) = name
        row(2) = address
        table.Rows.Add(row) 'add the filled row into the table
        table.AcceptChanges() 'save them
    End Sub

    Public Sub UpdateEmployee(id As Integer, name As String, address As String) Implements IDataComponent.UpdateEmployee
        Dim row = table.Rows.Find(id)
        If IsNothing(row) Then
            MsgBox("The Employee to update does not exist")
            Return
        End If
        row(1) = name
        row(2) = address
        table.AcceptChanges()
    End Sub

    Public Sub DeleteEmployee(id As Integer) Implements IDataComponent.DeleteEmployee
        Dim row = table.Rows.Find(id) 'Find works only if U have set the primary key for UR table
        table.Rows.Remove(row)
        table.AcceptChanges()
    End Sub

    Public Function GetAllEmployees() As DataTable Implements IDataComponent.GetAllEmployees
        Return table
    End Function
End Class