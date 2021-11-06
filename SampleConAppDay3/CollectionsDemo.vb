Imports System.Collections.Generic
Imports System.Linq
Module CollectionsDemo
    Public collection As New Dictionary(Of String, Object) 'global object.
    Sub Main()
        'listExample()
        'listOfEmployeeDemo()
        'hashSetDemo()
        'hashSetOfEmployees()
        'DictionaryExample()
        'QueueExample()
        StackExample()
    End Sub
    'Stack is used to store elements on Last in First Out basis. First element in the collection would be the last element added and it would the first element to be removed.
    Private Sub StackExample()
        Dim pile As New Stack(Of String)
        pile.Push("Book of Ele") ' Adds to the top of the list
        pile.Push("Ramayana")
        pile.Push("The Mahabharatha")
        pile.Push("2 States")
        pile.Push("Romeo and Juliet") 'Last book to add. 
        'pile.Pop() 'Removes the last/top book that was added into the stack and returns it. 
        Console.WriteLine("The last book added to the pile is " & pile.Peek)
        For Each book In pile
            Console.WriteLine(book)
        Next
    End Sub
    'Queue store the collection data in the form of First In First out basis. Typically used when creating shopping cart apps where we have the recently viewed items
    Private Sub QueueExample()
        Dim recentList As New Queue(Of String)()
        Do
            Console.WriteLine("Enter the Item U want to see")
            If recentList.Count = 5 Then
                recentList.Dequeue() 'Removes the first item in the queue
            End If
            recentList.Enqueue(Console.ReadLine) 'Add the element to the bottom of the queue.
            'Display the recent list...
            Dim list = recentList.Reverse 'Use the LINQ method
            For Each item In list
                Console.WriteLine(item)
            Next
        Loop
    End Sub
    'Dictionary stores the data in the form of key-value pairs. It can have key as different data type and value as another type. 
    'Key part of the dictionary object should be unique. The uniqueness is determined in the same manner of HashSet. Value associted with the dictionary need not be unique. 
    'This is very powerfull and fast compared to any other data structure. U can get the value of the associated key without any interation. Key will behave like indexer for the dictionary
    Sub DictionaryExample()
        collection.Add("initCount", 200)
        collection.Add("maxCount", 100)
        collection.Add("message", "Sample message")
        collection.Add("title", "My Demo Example")
        collection.Add("error", "OOPs!, Something wrong happened!")
        collection.Add("currentUser", New Employee With {.EmpID = 123, .EmpName = "SampleName", .EmpAddress = "Bangalore", .EmpSalary = 34000})
        Console.WriteLine(collection("error"))
        For Each pair In collection
            Console.WriteLine("Key: {0}-Value: {1}", pair.Key, pair.Value)
        Next
    End Sub
    'Blazor app
    'Hashset works for custom datatypes(Custom Classes) only if UR type overrides the GetHashCode method and Equals method coming from the System.Object which is the base clsas for all types in .NET Framework. GetHashCode tells that the object is of the same type, and Equals method determines the logical equivalence of the object with the comparing object.
    Private Sub hashSetOfEmployees()
        Dim empList As New HashSet(Of Employee)()
        Dim emp1 As New Employee With {.EmpID = 111, .EmpName = "Phaniraj", .EmpAddress = "Mysore", .EmpSalary = 65000}
        Dim emp2 As New Employee With {
            .EmpID = emp1.EmpID, .EmpName = emp1.EmpName, .EmpAddress = emp1.EmpAddress, .EmpSalary = emp1.EmpSalary
        }
        'Console.WriteLine(emp1.GetHashCode)
        'Console.WriteLine(emp2.GetHashCode)
        empList.Add(New Employee With {.EmpID = 111, .EmpName = "Phaniraj", .EmpAddress = "Mysore", .EmpSalary = 65000})
        empList.Add(New Employee With {.EmpID = 111, .EmpName = "Phaniraj", .EmpAddress = "Mysore", .EmpSalary = 65000})
        empList.Add(New Employee With {.EmpID = 111, .EmpName = "Phaniraj", .EmpAddress = "Mysore", .EmpSalary = 65000})
        empList.Add(New Employee With {.EmpID = 111, .EmpName = "Phaniraj", .EmpAddress = "Mysore", .EmpSalary = 65000})
        empList.Add(New Employee With {.EmpID = 111, .EmpName = "Phaniraj", .EmpAddress = "Mysore", .EmpSalary = 65000})
        'empList.Add(New Employee With {.EmpID = 112, .EmpName = "Soundarya", .EmpAddress = "Bangalore", .EmpSalary = 65000})
        'empList.Add(New Employee With {.EmpID = 113, .EmpName = "Vivek", .EmpAddress = "Chennai", .EmpSalary = 65000})
        'empList.Add(New Employee With {.EmpID = 114, .EmpName = "Govind", .EmpAddress = "Mysore", .EmpSalary = 65000})
        'empList.Add(New Employee With {.EmpID = 111, .EmpName = "Ramesh", .EmpAddress = "Mysore", .EmpSalary = 65000})
        'Console.WriteLine("The Count:{0}", empList.Count)
        For Each emp In empList
            Console.WriteLine(emp.GetHashCode())
        Next

    End Sub
    'Very similar to List but will store only unique values. It uses a HashCode an unique no generated by the .NET CLR when an object is created, to check the uniqueness of the object before its added. The no is generated based on its type and the value. 
    Private Sub hashSetDemo()
        Dim fruits As New HashSet(Of String)()
        fruits.Add("Apple")
        If Not fruits.Add("Apple") Then
            MsgBox("Apple is already in the basket")
        End If
        fruits.Add("Apple")
        fruits.Add("Apple")
        Console.WriteLine($"The count {fruits.Count}")
    End Sub
    'list can store duplicates. 
    Private Sub listOfEmployeeDemo()
        Dim empList As New List(Of Employee)()
        Dim emp As New Employee With {
            .EmpID = 123, .EmpName = "Phaniraj", .EmpAddress = "Bangalore", .EmpSalary = 65000
        } 'Object initialization syntax of VB.NET from VB 9
        empList.Add(emp)
        For Each emp In empList
            Console.WriteLine(emp.EmpName)
        Next
    End Sub
    'It is used to store data of the same type like an array. New items are added to the bottom of the List. U have an object to access any element and remove it or insert in between. It uses indexers to access the individual elements. (index). 
    Private Sub listExample()
        Dim fruits As New List(Of String)() 'Creates a List of size 0
        fruits.Add("Mango")
        fruits.AddRange(New String() {"Orange", "PineApple", "Banana"}) 'Multiple values at a time.
        Console.WriteLine("The no of elements in this collection is " & fruits.Count)
        For Each item In fruits
            Console.WriteLine(item)
        Next
        If fruits.Remove("Kiwi") Then
            MsgBox("Fruit deleted successfully")
        Else
            MsgBox("Kiwi is not found in the list to remove")
        End If

    End Sub
End Module
Class Employee
    Implements IComparable(Of Employee)
    Public Property EmpID As Integer
    Public Property EmpName As String
    Public Property EmpAddress As String
    Public Property EmpSalary As Integer

    Public Overrides Function GetHashCode() As Integer
        Return EmpID.GetHashCode
    End Function
    Public Overrides Function Equals(obj As Object) As Boolean
        Dim temp As Employee = obj 'UNBOXING in VB.NET
        If Me.EmpID = temp.EmpID And Me.EmpName = temp.EmpName And Me.EmpAddress = temp.EmpAddress Then
            Return True
        End If
        Return False
    End Function
    Public Overrides Function ToString() As String
        Return $"{EmpName} from {EmpAddress} earns a salary of {EmpSalary:C}"
    End Function
    'If the current object value is greater than the other, it will return 1, else -1 and if they are equal it will return 0
    Public Function CompareTo(other As Employee) As Integer Implements IComparable(Of Employee).CompareTo
        'If EmpID < other.EmpID Then
        '    Return -1 'Other object's id is greater
        'ElseIf EmpID > other.EmpID Then
        '    Return 1 'When the current object's id is greater
        'Else
        '    Return 0 'when the ids are same
        'End If
        Return EmpName.CompareTo(other.EmpName) 'Every data type in .NET implements IComparable
    End Function
End Class

Class EmployeeComparer
    Implements IComparer(Of Employee)
    Private criteria As String
    Public Sub New(criteria As String)
        Me.criteria = criteria
    End Sub
    Public Function Compare(first As Employee, second As Employee) As Integer Implements IComparer(Of Employee).Compare
        Select Case criteria
            Case "Name"
                Return first.EmpName.CompareTo(second.EmpName)
            Case "Address"
                Return first.EmpAddress.CompareTo(second.EmpAddress)
            Case "Salary"
                Return first.EmpSalary.CompareTo(second.EmpSalary)
            Case Else
                Return first.CompareTo(second) 'Default comparison based on EmpID
        End Select
    End Function
End Class