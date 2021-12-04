Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Interface IBookDataComponent
    Sub AddNewBook(title As String, author As String, price As Integer, stock As Integer)
    Sub UpdateBook(id As Integer, title As String, author As String, price As Integer, stock As Integer)
    Function Find(bkName As String) As DataTable
    Function Find(id As Integer) As DataRow 'Represents a Row of a Table
    Function FindByAuthor(authorName As String) As DataTable
End Interface

Public Class BookDBComponent
    Implements IBookDataComponent
    Private strCon As String = ConfigurationManager.ConnectionStrings("myConn").ConnectionString
    Const strFind As String = "SELECT * FROM TBLBOOK WHERE BOOKTITLE = @title"
    Const strFindById As String = "SELECT * FROM TBLBOOK WHERE BOOKID = @id"
    Const strAdd As String = "Insert into tblBook values(@title, @author, @price, @stock)"
    Const strUpdate As String = "Update tblBook set BookTitle = @title, Author = @author, Price = @price, Stock = @stock Where BookId = @id"
    Const strFindByAuthor As String = "SELECT * FROM TBLBOOK WHERE Author = @author"

    Public Sub AddNewBook(title As String, author As String, price As Integer, stock As Integer) Implements IBookDataComponent.AddNewBook
        Dim con As New SqlConnection(strCon)
        Dim cmd As New SqlCommand(strAdd, con)
        cmd.Parameters.AddWithValue("@title", title)
        cmd.Parameters.AddWithValue("@author", author)
        cmd.Parameters.AddWithValue("@price", price)
        cmd.Parameters.AddWithValue("@stock", stock)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex 'Let the caller of this function handle it. 
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub UpdateBook(id As Integer, title As String, author As String, price As Integer, stock As Integer) Implements IBookDataComponent.UpdateBook
        Dim con As New SqlConnection(strCon)
        Dim cmd As New SqlCommand(strUpdate, con)
        cmd.Parameters.AddWithValue("@title", title)
        cmd.Parameters.AddWithValue("@author", author)
        cmd.Parameters.AddWithValue("@price", price)
        cmd.Parameters.AddWithValue("@stock", stock)
        cmd.Parameters.AddWithValue("@id", id)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex 'Let the caller of this function handle it. 
        Finally
            con.Close()
        End Try
    End Sub

    Public Function Find(bkName As String) As DataTable Implements IBookDataComponent.Find
        Dim con As New SqlConnection(strCon)
        Dim cmd As New SqlCommand(strFind, con)
        cmd.Parameters.AddWithValue("@title", bkName)
        Try
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim table As New DataTable("someName") 'nameing a table is not requried always
            table.Load(reader)
            Return table
        Catch ex As Exception
            Throw ex 'Let the caller of this function handle it. 
        Finally
            con.Close()
        End Try
    End Function

    Public Function Find(id As Integer) As DataRow Implements IBookDataComponent.Find
        Dim con As New SqlConnection(strCon)
        Dim cmd As New SqlCommand(strFindById, con)
        cmd.Parameters.AddWithValue("@id", id)
        Try
            con.Open()
            Dim reader = cmd.ExecuteReader
            Dim table As New DataTable
            table.Load(reader)
            Return table.Rows(0)
        Catch ex As Exception
            Throw ex 'Let the caller of this function handle it. 
        Finally
            con.Close()
        End Try
    End Function

    Public Function FindByAuthor(authorName As String) As DataTable Implements IBookDataComponent.FindByAuthor
        Dim con As New SqlConnection(strCon)
        Dim cmd As New SqlCommand(strFindByAuthor, con)
        cmd.Parameters.AddWithValue("@author", authorName)
        Try
            con.Open()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            Dim table As New DataTable("someName") 'nameing a table is not requried always
            table.Load(reader)
            Return table
        Catch ex As Exception
            Throw ex 'Let the caller of this function handle it. 
        Finally
            con.Close()
        End Try
    End Function
End Class