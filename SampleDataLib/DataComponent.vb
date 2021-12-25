Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Diagnostics
'Code Complete
Public Interface IDBComponent
    Sub AddEmployee(id As Integer, name As String, address As String, salary As Double)
    Sub UpdateEmployee(id As Integer, name As String, address As String, salary As Double)
    Function GetAllEmployees() As DataTable
    Sub DeleteEmployee(id As Integer)
End Interface
'This class is not public and will be scoped only to this Library
Class DataComponent
    Implements IDBComponent
    ReadOnly strCon As String = ConfigurationManager.ConnectionStrings("myCon").ConnectionString
    Const strInsert As String = "Insert into tblEmployee values(@id, @name, @address, @salary)"
    Const strUpdate As String = "Update tblEmployee Set EmpName = @name, EmpAddress = @address, EmpSalary = @salary where EmpID = @id"
    Const strSelect As String = "SELECT * from tblEmployee"
    Public Sub AddEmployee(id As Integer, name As String, address As String, salary As Double) Implements IDBComponent.AddEmployee
        Dim conn As New SqlConnection(strCon)
        Dim cmd As New SqlCommand(strInsert, conn)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@salary", salary)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New EmployeeException("Insertion of the Employee as Failed", ex)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Public Sub UpdateEmployee(id As Integer, name As String, address As String, salary As Double) Implements IDBComponent.UpdateEmployee
        Dim conn As New SqlConnection(strCon)
        Dim cmd As New SqlCommand(strUpdate, conn)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@salary", salary)
        Try
            conn.Open()
            cmd.ExecuteNonQuery()
        Catch ex As SqlException
            Throw New EmployeeException($"Updation of the Employee with Id {id} as Failed", ex)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Public Sub DeleteEmployee(id As Integer) Implements IDBComponent.DeleteEmployee
        Throw New NotImplementedException()
    End Sub

    Public Function GetAllEmployees() As DataTable Implements IDBComponent.GetAllEmployees
        Dim conn As New SqlConnection(strCon)
        Dim cmd As New SqlCommand(strSelect, conn)
        Try
            conn.Open()
            Dim reader = cmd.ExecuteReader() 'SELECT Statement
            Dim table As New DataTable("EmpTable")
            table.Load(reader)
            Return table
        Catch ex As SqlException
            Throw New EmployeeException("Employee Reading has failed", ex)
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Function
End Class

Public Class DataFactory
    Public Shared Function GetComponent() As IDBComponent
        Dim asm = Assembly.Load("SampleDataLib") 'Load the dll into the process
        Dim strClassName = ConfigurationManager.AppSettings("DataComponent") 'Get the class name to instantiate
        Dim component = asm.GetType(strClassName) 'Get the type info of the class
        If component Is Nothing Then
            Debug.WriteLine("Component is not available")
            Throw New Exception("Componet loading failed")
        End If
        Dim instance As IDBComponent 'Create an object of the interface
        instance = Activator.CreateInstance(component) 'Instantiate the object thru Reflection
        Return instance
    End Function
End Class
Public Class EmployeeException
    Inherits ApplicationException
    Public Sub New()
        MyBase.New
    End Sub

    Public Sub New(strMessage As String)
        MyBase.New(strMessage)
    End Sub
    Public Sub New(strMessage As String, innerException As Exception)
        MyBase.New(strMessage, innerException)
    End Sub

End Class

