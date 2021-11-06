'This is a demo to show the practical usage of Dictionary in Ur real time apps.
Module CustomCollectionDemo
    Sub Main()
        'usingDictionary()
        Dim obj As New EmpDataComponent
        obj.AddNewEmployee(127, "James", "Mumbai", 78000)
        obj.AddNewEmployee(124, "Gopal", "Chennai", 40000)
        obj.AddNewEmployee(126, "Ramanath", "Lucknow", 23000)
        obj.AddNewEmployee(125, "Krishna", "Hyderabad", 67000)
        obj.AddNewEmployee(123, "Phaniraj", "Bangalore", 70000)
        Console.WriteLine("Before sorting")
        For Each emp In obj 'obj is not a collection class
            Console.WriteLine(emp.EmpAddress)
        Next
        'Default sorting...
        'obj.Sort()

        obj.Sort("Address")

        'Using for each to iterate..
        Console.WriteLine("After sorting")
        For Each emp In obj 'obj is not a collection class
            Console.WriteLine(emp.EmpAddress)
        Next
        ''Using the IEnumerator object to iterate the collection..
        'Dim it = obj.GetEnumerator
        'While it.MoveNext
        '    Console.WriteLine(it.Current.EmpName)
        'End While
        'For i = 0 To obj.NoOfEmployees - 1
        '    Console.WriteLine(obj(i).EmpName)
        'Next
    End Sub

    Private Sub usingDictionary()
        DictionaryExample() 'Fill the items into the dictionary
        MsgBox(collection("currentUser").EmpName, MsgBoxStyle.Information, collection("title"))
        If collection.ContainsKey("initCount") Then
            collection("initCount") = 456
        End If
        collection("initCount") = 456 'This no would come from a service
    End Sub
End Module
Interface IDataComponent
    Inherits IEnumerable(Of Employee)
    Sub AddNewEmployee(id As Integer, name As String, address As String, salary As Integer)
    Sub UpdateEmployee(id As Integer, name As String, address As String, salary As Integer)
    Sub DeleteEmployee(id As Integer)
    Function GetEmployees() As List(Of Employee)
    Sub Sort()
    Sub Sort(comparingCriteria As String) 'Overloaded Function.
End Interface

Class EmpDataComponent
    Implements IDataComponent
    Private empList As New List(Of Employee)() 'create a blank list...
    Public Sub AddNewEmployee(id As Integer, name As String, address As String, salary As Integer) Implements IDataComponent.AddNewEmployee
        'Do business processing. 
        Dim emp As New Employee With {.EmpID = id, .EmpAddress = address, .EmpName = name, .EmpSalary = salary}
        empList.Add(emp)
    End Sub

    Public Sub UpdateEmployee(id As Integer, name As String, address As String, salary As Integer) Implements IDataComponent.UpdateEmployee
        For Each emp In empList 'Iterate thro the collection
            If emp.EmpID = id Then 'Find the matching Id
                emp.EmpName = name 'reset the name, address and salary
                emp.EmpAddress = address
                emp.EmpSalary = salary
                Return 'Exit the Subroutine
            End If
        Next
    End Sub

    Public Sub DeleteEmployee(id As Integer) Implements IDataComponent.DeleteEmployee
        'Iterate thru the collection
        For index = 0 To empList.Count - 1
            If empList(index).EmpID = id Then 'Find the matching emp object
                empList.RemoveAt(index) 'Remove the object from the source
                Return 'Exit the Function
            End If
        Next
    End Sub

    Public Function GetEmployees() As List(Of Employee) Implements IDataComponent.GetEmployees
        Return empList
    End Function

    Public Function GetEnumerator() As IEnumerator(Of Employee) Implements IEnumerable(Of Employee).GetEnumerator
        Return empList.GetEnumerator
    End Function

    Private Function IEnumerable_GetEnumerator() As IEnumerator Implements IEnumerable.GetEnumerator
        Throw New NotImplementedException()
    End Function

    Public Sub Sort() Implements IDataComponent.Sort
        empList.Sort()
    End Sub

    Public Sub Sort(comparingCriteria As String) Implements IDataComponent.Sort
        Dim comparer As New EmployeeComparer(comparingCriteria)
        empList.Sort(comparer)
    End Sub

    Public ReadOnly Property NoOfEmployees
        Get
            Return empList.Count
        End Get
    End Property

    'Indexer equivalent in VB.NET
    Default Public ReadOnly Property Employee(ByVal index As Integer) As Employee
        Get
            Return empList(index)
        End Get
        'Set(value As Employee)
        '    If index < NoOfEmployees Then
        '        empList(index) = value
        '    End If
        'End Set
    End Property
End Class