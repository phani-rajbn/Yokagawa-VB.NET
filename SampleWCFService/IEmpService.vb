'WCF service is an interface that contains the methods that U R exposing to the customers. 
'WCF interfaces will have attributes(Annotations) to expose them to the customers. 

<ServiceContract()>
Public Interface IEmpService
    <OperationContract()>' This makes the functions exposed to the Callers of UR service. 
    Function GetAllEmployees() As List(Of Employee)
    <OperationContract>
    Sub AddEmployee(emp As Employee)
End Interface
<DataContract()>
Public Class Employee
    <DataMember()>
    Public Property EmpID As Integer
    <DataMember()>
    Public Property EmpName As String
    <DataMember()>
    Public Property EmpAddress As String
    <DataMember()>
    Public Property EmpSalary As Integer
End Class