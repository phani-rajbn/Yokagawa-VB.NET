'ADO.NET provides a different way of interacting with the database called disconnected model. It is widely used for web based applications where scalability is a major requirement. Usage of the Application from a small amount to a larger amount without hampering the application performance is called as Scalability. ADO.NET's disconnected model allows the data to be extracted from the database and store it into an in-memory tables collection called DataSet.
'DataSet is a repository object that contains a collection of tables that developer wants to work with. Based on the app requirement, dataset can store the data in the form of DataTables and the source of the data can come from any kind of data persistance layer. 
'Important Classes:
'DataSet is the central point of Disconnected architecture. It will store the data disconnected from its source in the form of tables.
'xxxDataAdapter is the link b/w the actual database and the DataSet. It has 2 methods: Fill fills the data from the source to a Table of the dataset. If U dont mention the table, it will create a table and fills the data in it and will be the first Table. The other method is Update is the reverse of Fill which updates the modified data of the datatable into the database. 
'DataTable represents the disconnected data in the form of a Table
'DataRow represents each row of the table. 
'Command builder is a smart class that auto generates the insert, delete and update SQL statements based on the action U have done on the dataset's Table
Imports System.Configuration
Imports System.IO
Imports System.Data.SqlClient
Module DisconnectedModel
    Public ds As New DataSet
    ReadOnly strCon As String = ConfigurationManager.ConnectionStrings("myCon").ConnectionString
    Dim adapter As New SqlDataAdapter("SELECT * FROM TBLEMPLOYEE", strCon)
    Dim cb As New SqlCommandBuilder(adapter)

    Friend Sub UpdateRecord()
        adapter.Update(ds, "Employees")
    End Sub

    ''' <summary>
    ''' This function uses disconnected model to insert the record into the database. 
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="name"></param>
    ''' <param name="address"></param>
    ''' <param name="salary"></param>
    Public Sub InsertRecord(id As Integer, name As String, address As String, salary As Integer)
        If ds.Tables("Employees") Is Nothing Then
            MsgBox("DataSet does not contain the Employee data")
            Return
        End If
        Dim row = ds.Tables("Employees").NewRow
        row(0) = id
        row(1) = name
        row(2) = address
        row(3) = salary
        ds.Tables("Employees").Rows.Add(row)
        'MsgBox(row.RowState.ToString)
        Try
            adapter.Update(ds, "Employees") 'Works with CommandBuilder to insert the record if its RowState is Added
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub DeleteRecord()
        adapter.Update(ds, "Employees") 'Delete the changed data and updates it to the database. 
    End Sub
    ''' <summary>
    ''' Helper function used to extract data from database using Disconnected model.
    ''' </summary>
    Public Sub CreateEmployees()
        'Dim conn As New SqlConnection(strCon)
        'Dim cmd As New SqlCommand("SELECT * FROM TBLEMPLOYEE", conn)
        'Dim adapter As New SqlDataAdapter(cmd)
        adapter.Fill(ds, "Employees") 'Fill is a smart method of the adapter which opens a closed connection, fills the data into the table of the dataset and immediately closes the connection.
        'MsgBox(adapter.SelectCommand.Connection.State.ToString)
    End Sub


    Sub CreateBranches()
        Dim table As New DataTable("Branches") 'Good practise to name the Datatable that stores the data in memory.
        table.Columns.Add("BranchID", GetType(Integer))
        table.Columns.Add("BranchName", GetType(String))
        table.Columns.Add("Contact", GetType(String))
        table.Columns.Add("PinCode", GetType(Long))
        readfiles(table)
        ds.Tables.Add(table)
    End Sub
    Sub readfiles(ByRef table As DataTable)
        Dim filename = ConfigurationManager.AppSettings("branchFile")
        Dim lines = File.ReadAllLines(filename)
        For Each line As String In lines
            Dim words = line.Split(",")
            Dim row = table.NewRow 'Initialize a blank row with the schema of the table.
            row(0) = words(0)
            row(1) = words(1)
            row(2) = words(2)
            row(3) = words(3)
            table.Rows.Add(row) 'Adds the filled row into the table's Rows Collection. 
        Next
    End Sub
End Module
