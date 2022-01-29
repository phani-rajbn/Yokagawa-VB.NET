Imports System.Configuration
Imports System.Data.SqlClient

Public Class DataComponent
    Implements IDataComponent
    Dim strCon = ConfigurationManager.ConnectionStrings("myConnection").ConnectionString
    Const sqlDeleteRecord = "DeleteEmployee"
    Const sqlAddRecord = "AddEmployee"
    Const sqlUpdateRecord = "UpdateEmployee"
    Public Sub AddEmployee(emp As Employee) Implements IDataComponent.AddEmployee
        Dim con As New SqlConnection(strCon)
        Dim cmd = con.CreateCommand() 'Creates a new SqlCommand associated with this Connection
        cmd.CommandText = sqlAddRecord
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id", emp.EmpId)
        cmd.Parameters.AddWithValue("@name", emp.EmpName)
        cmd.Parameters.AddWithValue("@address", emp.EmpAddress)
        cmd.Parameters.AddWithValue("@sal", emp.EmpSalary)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex 'Throw to the User interface and UI will handle it and display the info if required.
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub UpdateEmployee(emp As Employee) Implements IDataComponent.UpdateEmployee
        Dim con As New SqlConnection(strCon)
        Dim cmd = con.CreateCommand() 'Creates a new SqlCommand associated with this Connection
        cmd.CommandText = sqlUpdateRecord
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id", emp.EmpId)
        cmd.Parameters.AddWithValue("@name", emp.EmpName)
        cmd.Parameters.AddWithValue("@address", emp.EmpAddress)
        cmd.Parameters.AddWithValue("@sal", emp.EmpSalary)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex 'Throw to the User interface and UI will handle it and display the info if required.
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub DeleteEmployee(empId As Integer) Implements IDataComponent.DeleteEmployee
        Dim con As New SqlConnection(strCon)
        Dim cmd = con.CreateCommand() 'Creates a new SqlCommand associated with this Connection
        cmd.CommandText = sqlDeleteRecord
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id", empId)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex 'Throw to the User interface and UI will handle it and display the info if required.
        Finally
            con.Close()
        End Try

    End Sub
    ''' <summary>
    ''' Returns a valid Employee based on the ID
    ''' </summary>
    ''' <param name="empId">ID of the Employee to search</param>
    ''' <returns>A Data filled Employee </returns>
    ''' <exception cref="Exception"/>
    ''' <exception cref="SqlException"/>
    Public Function FindEmployee(empId As Integer) As Employee Implements IDataComponent.FindEmployee
        Dim sqlSelect = "SELECT * FROM EMPTABLE WHERE EMPID = @id"
        Dim con As New SqlConnection(strCon)
        Dim cmd = con.CreateCommand() 'Creates a new SqlCommand associated with this Connection
        cmd.CommandText = sqlSelect
        cmd.Parameters.AddWithValue("@id", empId)
        Try
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
                    Dim emp As New Employee
                    emp.EmpId = Convert.ToInt32(reader(0))
                    emp.EmpSalary = Convert.ToInt32(reader(3))
                    emp.EmpName = reader(1).ToString
                    emp.EmpAddress = reader(2).ToString
                    Return emp
                End While
            Else
                Throw New Exception($"Employee with Id {empId} not found")
            End If
        Catch ex As SqlException
            Throw ex 'Throw to the User interface and UI will handle it and display the info if required.
        Finally
            con.Close()
        End Try
    End Function

    Public Function FindEmployee(empName As String) As List(Of Employee) Implements IDataComponent.FindEmployee
        Dim list As New List(Of Employee)
        Dim sqlSelect = $"SELECT * FROM EMPTABLE WHERE EMPName Like '%{empName}%'"
        Dim con As New SqlConnection(strCon)
        Dim cmd = con.CreateCommand() 'Creates a new SqlCommand associated with this Connection
        cmd.CommandText = sqlSelect
        Try
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim emp As New Employee
                    emp.EmpId = Convert.ToInt32(reader(0))
                    emp.EmpSalary = Convert.ToInt32(reader(3))
                    emp.EmpName = reader(1).ToString
                emp.EmpAddress = reader(2).ToString
                list.Add(emp)
            End While
            Return list 'Return the final list of employees
        Catch ex As SqlException
            Throw ex 'Throw to the User interface and UI will handle it and display the info if required.
        Finally
            con.Close()
        End Try
    End Function
End Class
