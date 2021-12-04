''' <summary>
''' Represents a Book of the Applicatoin
''' </summary>
Public Class Book
    Public Property BookId As Integer
    Public Property BookTitle As String
    Public Property Price As Integer
    Public Property Author As String 'There is only one author per book
    Public Property Stock As Integer = 10
End Class
