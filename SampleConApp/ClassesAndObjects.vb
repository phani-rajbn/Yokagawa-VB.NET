Module ClassesAndObjects
    Sub Main()
        'Classes are used in the form objects. Module does not work on objects, they are singleton. The methods of a Module are refered without an object, its refered by the name of the module. Classes are object oriented and follow the rules of OOP including Encapsulation. Module methods are all public unless U make them private
        Dim obj As New Employee 'Create an object in VB.NET => Employee obj = new Employee()
        obj.EmployeeID = 123
        obj.EmployeeName = "Phaniraj"
        obj.EmployeeAddress = "Bangalore"
        Console.WriteLine($"The name is {obj.EmployeeName } from {obj.EmployeeAddress } and has ID as {obj.EmployeeID }") 'New feature of VB.NET called Interpolation syntax. 
    End Sub
End Module
'A Class in VB.NET contains Properties, Methods and Events. Properties are getters and setters for the private fields that U create. Methods are functions that are used to manipulate the private data. Events are actions performed on the object.
'Properties are attributes or charecteristics of an object. Methods are actions performed by the object. Events are actions performed on the object. 
Class Employee
    'Fields or data of the Class. 
    Private empId As Integer
    Private empName As String
    Private empAddress As String
    'Accessors to the private fields.
    Public Property EmployeeID() As Integer
        Get
            Return empId
        End Get
        Set(value As Integer)
            empId = value
        End Set
    End Property

    Public Property EmployeeName() As String
        Get
            Return empName
        End Get
        Set(ByVal value As String)
            empName = value
        End Set
    End Property

    Public Property EmployeeAddress() As String
        Get
            Return empAddress
        End Get
        Set(ByVal value As String)
            empAddress = value
        End Set
    End Property
End Class
