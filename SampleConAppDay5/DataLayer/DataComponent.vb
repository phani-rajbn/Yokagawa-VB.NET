Imports System.Collections.Generic
Imports System.Configuration
Imports System.IO
Public Interface IDataComponent
    Sub AddNewEmployee(emp As Employee)
    Sub UpdateEmployee(emp As Employee)
    Sub DeleteEmployee(id As Integer)
    Function GetAllEmployees(name As String) As List(Of Employee)
    Function GetEmployee(id As Integer) As Employee
End Interface

Public Class DataFactory
    Public Shared Function GetComponent() As IDataComponent
        Dim className As String = ConfigurationManager.AppSettings.Get("DataComponent")
        Select Case className
            Case "FileData"
                Return New DataComponent
            Case Else
                Throw New Exception("Not a valid type of Data Component")
        End Select
    End Function
End Class
''' <summary>
''' Implements the IDataComponent to store the data into FileSystem as CSV file
''' </summary>
Public Class DataComponent
    Implements IDataComponent
    Private filename As String = "MyData.csv"
    Private empList As New List(Of Employee) 'blank list...
    Private Sub fillRecords()
        empList.Clear()
        Dim lines = File.ReadAllLines(filename)
        For Each line In lines
            If String.IsNullOrEmpty(line) Then Exit Sub
            Dim words = line.Split(",")
            Dim emp As New Employee With {.EmpID = Integer.Parse(words(0)), .EmpName = words(1), .EmpAddress = words(2), .EmpSalary = Integer.Parse(words(3))}
            empList.Add(emp)
        Next
    End Sub
    Private Sub saveRecords()
        Dim lines = New List(Of String)
        For Each emp In empList
            lines.Add($"{emp.EmpID}, {emp.EmpName}, {emp.EmpAddress}, {emp.EmpSalary}{vbCrLf}")
        Next
        File.WriteAllLines(filename, lines)
    End Sub
    Public Sub AddNewEmployee(emp As Employee) Implements IDataComponent.AddNewEmployee
        'Convert the emp object into a CSV data.
        'vbCrlf is like /n of C/C++
        Dim strContent = $"{emp.EmpID}, {emp.EmpName}, {emp.EmpAddress}, {emp.EmpSalary}{vbCrLf}"
        File.AppendAllText(filename, strContent)
    End Sub

    Public Sub UpdateEmployee(emp As Employee) Implements IDataComponent.UpdateEmployee
        fillRecords() 'Get all data from the file and put into a collection
        For Each temp In empList 'Change the data in the collection
            If emp.EmpID = temp.EmpID Then
                temp.EmpName = emp.EmpName
                temp.EmpAddress = emp.EmpAddress
                temp.EmpSalary = emp.EmpSalary
                saveRecords() 'Update the collection data back to the file
                Exit Sub 'Exits from the function itself
            End If
        Next
        Throw New Exception($"No Employee by ID {emp.EmpID} found to update")
    End Sub

    Public Sub DeleteEmployee(id As Integer) Implements IDataComponent.DeleteEmployee
        fillRecords()
        For Each emp In empList
            If emp.EmpID = id Then
                empList.Remove(emp)
                saveRecords()
                Return 'Exit the Sub...
            End If
        Next
        Throw New Exception($"Employee by ID {id} not found to delete")
    End Sub

    Public Function GetAllEmployees(name As String) As List(Of Employee) Implements IDataComponent.GetAllEmployees
        Throw New NotImplementedException("Do It URSelf")
    End Function

    Public Function GetEmployee(id As Integer) As Employee Implements IDataComponent.GetEmployee
        Throw New NotImplementedException("Do It URSelf")
    End Function
End Class
