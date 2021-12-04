Public Class UIForm
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Create a blank book object
        Dim bk As New Book
        'Take the values from the controls and place it in the book object.
        bk.Author = txtAuthor.Text
        bk.BookTitle = txtTitle.Text
        bk.Price = Integer.Parse(txtPrice.Text) 'Good pratise to convert the data by urself
        'Call the Business Component's add New book function
        Dim component As New BookBusinessComponent
        Try
            component.AddNewBook(bk)
            MsgBox("Book is added successfully to the database")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        'Handle exceptions if any
    End Sub

    Private Sub btnUpdateFind_Click(sender As Object, e As EventArgs) Handles btnUpdateFind.Click
        Dim findId As Integer = InputBox("Enter the Id of the Book to update")
        Dim component As New BookBusinessComponent
        Dim foundBook = component.Find(findId)
        lblUpdateId.Text = foundBook.BookId
        txtUpdateAuthor.Text = foundBook.Author
        txtUpdatePrice.Text = foundBook.Price
        txtUpdateTitle.Text = foundBook.BookTitle
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim component As New BookBusinessComponent
        Dim bk As New Book With {.Author = txtUpdateAuthor.Text, .BookId = lblUpdateId.Text, .BookTitle = txtUpdateTitle.Text, .Price = txtUpdatePrice.Text}
        Try
            component.UpdateBook(bk)
            MsgBox("Book is updated properly")
            updateClear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub updateClear()
        lblUpdateId.Text = String.Empty
        txtUpdateAuthor.Text = String.Empty
        txtUpdatePrice.Text = String.Empty
        txtUpdateTitle.Text = String.Empty
    End Sub
End Class