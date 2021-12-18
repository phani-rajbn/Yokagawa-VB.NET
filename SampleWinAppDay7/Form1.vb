Public Class frmUserInfo
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close() 'The Form should close
    End Sub
    'Every control will ahve a default event. Click is the default event of Button
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strContent As String
        Dim dob As DateTime = DateTime.Parse(txtBirthDate.Text)
        Dim age As Integer = DateTime.Now.Year - dob.Year
        strContent = $"The Name:{txtName.Text}{vbCrLf}The Address:{txtAddress.Text}{vbCrLf}The Qualification: {cmbQualification.Text}{vbCrLf}The Age: {age}"
        MsgBox(strContent, MsgBoxStyle.Information, "User Details")
        'Save the data to the database. 
    End Sub
    'Forms are classes derived from System.Windows.Forms.Form
End Class
