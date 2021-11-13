Public Class Book
    Public Property BookId As Integer
    Public Property Title As String
    Public Property Price As Double
    Public Property StockCount As Short = 100 'Default values to UR property
End Class

Public Class BookStore
    ''' <summary>
    ''' Updates the passed Book into the store
    ''' </summary>
    ''' <param name="bk">Book details to update</param>
    ''' <exception cref="BookNotFoundException"/>
    Public Sub UpdateBook(bk As Book)
        Throw New BookNotFoundException("Book with specific Id not found in our repository")
    End Sub
End Class
