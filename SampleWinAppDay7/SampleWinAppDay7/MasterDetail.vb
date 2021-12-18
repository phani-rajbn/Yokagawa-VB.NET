Imports SampleDataLib
Public Class MasterDetail
    Private Shared component As IDBComponent = DataFactory.GetComponent ' it becomes thread safe.
    Private Sub btnFetch_Click(sender As Object, e As EventArgs) Handles btnFetch.Click
        Dim table = component.GetAllEmployees
        lstNames.DataSource = table
        lstNames.DisplayMember = "EmpName" 'Tell which column of the table be displayed.
    End Sub
    'This is triggered when the user changes the selected item in the listbox. 
    Private Sub lstNames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstNames.SelectedIndexChanged
        Dim name = lstNames.GetItemText(lstNames.SelectedItem)
        Dim table = component.GetAllEmployees
        For Each dr As DataRow In table.Rows
            If dr("EmpName") = name Then
                EmpDetails.txtID.Text = dr("EmpId")
                EmpDetails.txtName.Text = dr("EmpName")
                EmpDetails.txtAddress.Text = dr("EmpAddress")
                EmpDetails.txtSalary.Text = dr("EmpSalary")
                Return 'Exit if the first occurance of the matching record is found
            End If
        Next
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles EmpDetails.Submit
        'Take the inputs from the user
        Dim id = CInt(EmpDetails.txtID.Text)
        Dim name = EmpDetails.txtName.Text
        Dim address = EmpDetails.txtAddress.Text
        Dim salary = CDbl(EmpDetails.txtSalary.Text)
        'call the component's update method
        Try
            component.UpdateEmployee(id, name, address, salary)
            MsgBox("Employee Details updated successfully")
            'repopulate the listbox
        Catch ex As EmployeeException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close() 'WIll terminate the App only if the current form is the entry
        'Application.Exit() 'It terminates the Application
    End Sub

    Private Sub MasterDetail_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Dim msgRst = MsgBox("Do U Really want to Close the application?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical)
        If msgRst = MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub AddNewEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewEmployeeToolStripMenuItem.Click, ToolStripButton1.Click
        NewEmployee.ShowDialog(Me)
    End Sub

    Private Sub DeleteEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeToolStripMenuItem.Click
        DeleteForm.ShowDialog(Me)
    End Sub

    Private Sub TreeViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TreeViewToolStripMenuItem.Click
        TreeViewExample.ShowDialog(Me)
    End Sub
End Class