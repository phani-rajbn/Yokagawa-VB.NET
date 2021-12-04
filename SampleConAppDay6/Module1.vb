Imports System.Data.SqlClient
Imports System.Configuration 'For the ConfigurationManager Class. Add the reference of the Sys.Config before U write this code. 
Module ConnectedDBAccess
    Const strSELECT As String = "SELECT * FROM TBLEMPLOYEE"
    Dim strConn As String = ConfigurationManager.ConnectionStrings("myConn").ConnectionString 'Read the ConnectionString set in the App.Config file. 
    Sub Main()
        'readRecords()
        'Console.WriteLine("Enter the name or part of the name to search")
        'Dim strName = Console.ReadLine
        'displayEmployeesByName(strName)
        'displayEmployeesByNameWithParameters(strName)
        'Take inputs from the user and pass it to the function..
        'insertRecord(9, "Swetha", "Mysore", 65000)
        'deleteRecord(9)
        UpdateExampleUsingStoredProc(8, "Ramesh Kumar", "Sira", 70000)
    End Sub

    Private Sub UpdateExampleUsingStoredProc(id As Integer, name As String, address As String, salary As Integer)
        Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlCommand("UpdateStatement", con) 'Name of the stored proc to be passed as 1st arg.
        cmd.CommandType = CommandType.StoredProcedure 'It is a stored Proc. 
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@salary", salary)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Updation is successfull")
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub deleteRecord(id As Integer)
        Dim strQuery = $"DELETE FROM TBLEMPLOYEE WHERE EMPID ={id}"
        Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlCommand(strQuery, con)
        Try
            con.Open()
            Dim rowsAffected = cmd.ExecuteNonQuery() 'Statement does not return any data from SQL server.INSERT, DELETE and UPDATE
            If rowsAffected = 1 Then
                MsgBox("Employee deleted successfully")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub insertRecord(id As Integer, name As String, address As String, salary As Integer)
        Const strQuery = "INSERT INTO TBLEMPLOYEE VALUES(@id, @name, @address, @salary)"
        Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlCommand(strQuery, con)
        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@address", address)
        cmd.Parameters.AddWithValue("@salary", salary)
        Try
            con.Open()
            Dim rowsAffected = cmd.ExecuteNonQuery() 'Statement does not return any data from SQL server.INSERT, DELETE and UPDATE
            If rowsAffected = 1 Then
                MsgBox("Employee inserted successfully")
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

    Private Sub displayEmployeesByNameWithParameters(strName As String)
        Dim strQuery = "SELECT * FROM TBLEMPLOYEE WHERE EMPNAME LIKE '%' + @name + '%'" '@name is a variable syntax of SQL....
        Dim con As New SqlConnection(strConn)
        Dim cmd As New SqlCommand(strQuery, con)
        cmd.Parameters.AddWithValue("@name", strName)
        Try
            con.Open()
            Dim reader = cmd.ExecuteReader()
            While reader.Read
                Console.WriteLine($"Name:{reader(1)}  Address: {reader(2)}  Salary: {reader(3):C}")
            End While
        Catch ex As SqlException
            Console.WriteLine(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub displayEmployeesByName(strName As String)
        'Write down the query to search by Name
        Dim strQuery = $"SELECT * FROM TBLEMPLOYEE WHERE EMPNAME LIKE '%{strName}%'"
        'Create the connection
        Dim con = New SqlConnection(strConn)
        'Create the Command
        Dim cmd = New SqlCommand(strQuery, con)
        'Execute the query
        Try
            con.Open()
            Dim reader = cmd.ExecuteReader()
            While reader.Read
                Console.WriteLine($"Name:{reader(1)}  Address: {reader(2)}  Salary: {reader(3):C}")
            End While
        Catch ex As SqlException
            Console.WriteLine(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        'Read the data or display the data on Console
        'Close the Connection
    End Sub

    Private Sub readRecords()
        'ToDo: Extract the records from the tblEmployee and display on Console.
        Dim con As New SqlConnection
        con.ConnectionString = strConn 'Contains the details for connecting to the specific database.

        Dim cmd As New SqlCommand
        cmd.Connection = con ''Associating the Connection to the Command.
        cmd.CommandText = strSELECT 'Contains the SQL statement to execute

        Try
            con.Open() 'open the connection
            Dim reader = cmd.ExecuteReader() 'execute the Command
            While reader.Read 'Start reading till the end of the records
                'Console.WriteLine("The Name of the Employee " & reader("EmpName"))
                Console.WriteLine($"Name:{reader(1)}  Address: {reader(2)}  Salary: {reader(3):C}") 'Read the values using Column based indexing. 
            End While
        Catch ex As SqlException 'Handle exceptions raised by SQL server if any
            Console.WriteLine(ex.Message)
        Finally
            con.Close() 'Close the connection after all the operations are done. 
        End Try
    End Sub
End Module
