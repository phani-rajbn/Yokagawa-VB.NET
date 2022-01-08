' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in both code and config file together.
Imports System.Configuration
Imports System.Data.SqlClient
Public Class EmpService
    Implements IEmpService

    Public Sub AddEmployee(emp As Employee) Implements IEmpService.AddEmployee
        Dim strConn = ConfigurationManager.ConnectionStrings("myCon").ConnectionString
        Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlCommand($"Insert into Employee values({emp.EmpID},{emp.EmpName},{emp.EmpAddress},{emp.EmpSalary})", con)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New CommunicationException(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Function GetAllEmployees() As List(Of Employee) Implements IEmpService.GetAllEmployees
        'To get the data as List of Employee from ADO.NET Connected Model 
        Dim lst As New List(Of Employee)()
        'lst.Add(New Employee With {.EmpID = 123, .EmpAddress = "Bangalore", .EmpName = "Phaniraj", .EmpSalary = 45000})
        'lst.Add(New Employee With {.EmpID = 124, .EmpAddress = "Mysore", .EmpName = "Ramesh", .EmpSalary = 45000})
        'lst.Add(New Employee With {.EmpID = 125, .EmpAddress = "Chennai", .EmpName = "Swamy", .EmpSalary = 35000})
        'lst.Add(New Employee With {.EmpID = 126, .EmpAddress = "Pune", .EmpName = "Manjrekar", .EmpSalary = 40000})
        'lst.Add(New Employee With {.EmpID = 127, .EmpAddress = "Lucknow", .EmpName = "Ramnath Nishad", .EmpSalary = 25000})
        'lst.Add(New Employee With {.EmpID = 128, .EmpAddress = "Chandigarh", .EmpName = "Sanjeev", .EmpSalary = 42000})
        'Return lst
        Dim strConn = ConfigurationManager.ConnectionStrings("myCon").ConnectionString
        Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlCommand("SELECT * FROM EMPLOYEE", con)
        Try
            con.Open()
            Dim reader = cmd.ExecuteReader()
            While reader.Read
                Dim emp As New Employee
                emp.EmpID = reader(0) '1st Coll
                emp.EmpName = reader(1) '2nd Coll
                emp.EmpAddress = reader(2) '3rd Coll
                emp.EmpSalary = reader(3) '4th Coll
                lst.Add(emp)
            End While
            Return lst
        Catch ex As Exception
            Throw New CommunicationException(ex.Message)
        Finally
            con.Close()
        End Try
    End Function
    'Add Function to insert a record to the database. 
End Class