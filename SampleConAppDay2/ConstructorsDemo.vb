'Why constructors: Constructors are one way of implementing DI in Ur class. Constructors are sp function that is automatically invoked when an object is instantiated. It is a place to set values to the fields so that UR object can be usable.  
'U can also create shared constructors in VB.NET. It is used to set values to the static variables of the class. A shared constructor is internally called once and only once during the execution of the program. Shared constructors are internally called by the Application, a programmer cannot call it explicitly. So UR shared constructors will not have paramters in them and no access specifier. 
Module ConstructorsDemo
    Sub Main()
        Dim emp As New Employee(123, "Phaniraj", "Bangalore", 45000)
        Console.WriteLine(emp.EmployeeID)
    End Sub
End Module

Class Employee
    Private empID As Integer
    Private empName As String
    Private empAddress As String
    Private empSalary As Integer
    'new is the reserved keyword that will be invoked when the object is being instantiated 
    Public Sub New(empID As Integer, empName As String, empAddress As String, empSalary As Integer)
        Console.WriteLine("Normal Constructor")
        Me.empID = empID
        Me.empName = empName
        Me.empAddress = empAddress
        Me.empSalary = empSalary
    End Sub

    Shared Sub New()
        Console.WriteLine("Shared constructor, called once and only once even before the normal constructor is called")
    End Sub

    Public EmployeeID As Integer = empID
    Public EmployeeName As Integer = empName
    Public EmployeeAddress As Integer = empAddress
    Public EmployeeSalary As Integer = empSalary
End Class
