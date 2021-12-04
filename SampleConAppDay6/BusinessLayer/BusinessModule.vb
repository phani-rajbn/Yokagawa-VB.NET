Imports System.Collections.Generic
Public Interface IBookComponent
    Sub AddNewBook(bk As Book)
    Sub UpdateBook(bk As Book)
    Function Find(bkName As String) As List(Of Book)
    Function Find(id As Integer) As Book
    Function FindByAuthor(authorName As String) As List(Of Book)
End Interface

Public Class BookBusinessComponent
    Implements IBookComponent
    Private dalComponent As New BookDBComponent
    Public Sub AddNewBook(bk As Book) Implements IBookComponent.AddNewBook
        'Perform all the business rules.
        Try
            dalComponent.AddNewBook(bk.BookTitle, bk.Author, bk.Price, bk.Stock)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub UpdateBook(bk As Book) Implements IBookComponent.UpdateBook
        Try
            dalComponent.UpdateBook(bk.BookId, bk.BookTitle, bk.Author, bk.Price, bk.Stock)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function Find(bkName As String) As List(Of Book) Implements IBookComponent.Find
        Dim list As New List(Of Book)
        Try
            Dim table = dalComponent.Find(bkName)
            For Each row As DataRow In table.Rows
                list.Add(convert(row))
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return list
    End Function

    Public Function Find(id As Integer) As Book Implements IBookComponent.Find
        Return convert(dalComponent.Find(id))
    End Function

    Public Function FindByAuthor(authorName As String) As List(Of Book) Implements IBookComponent.FindByAuthor
        Dim list As New List(Of Book)
        Try
            Dim table = dalComponent.FindByAuthor(authorName)
            For Each row As DataRow In table.Rows
                list.Add(convert(row))
            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return list
    End Function
    ''' <summary>
    ''' Helper function used for converting a valid DataRow of the table to a Book object
    ''' </summary>
    ''' <param name="row"></param>
    ''' <returns></returns>
    Private Function convert(row As DataRow) As Book
        Dim bk As New Book
        bk.BookId = row(0)
        bk.BookTitle = row(1)
        bk.Author = row(2)
        bk.Price = row(3)
        bk.Stock = row(4)
        Return bk
    End Function
End Class