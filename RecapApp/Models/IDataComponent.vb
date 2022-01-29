'Even though it is not mandatory, U should name the component's name and the Filename to be same. 
Public Interface IDataComponent
    Sub AddEmployee(emp As Employee)
    Sub UpdateEmployee(emp As Employee)
    Sub DeleteEmployee(empId As Integer)
    Function FindEmployee(empId As Integer) As Employee 'Method overloading..
    Function FindEmployee(empName As String) As List(Of Employee)
End Interface
