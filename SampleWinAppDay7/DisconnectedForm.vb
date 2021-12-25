Public Class DisconnectedForm
    Private rowIndex As Integer = 0
    Private Sub btnBranches_Click(sender As Object, e As EventArgs) Handles btnBranches.Click
        DisconnectedModel.CreateBranches()
        grdBranches.DataSource = DisconnectedModel.ds.Tables("Branches") 'Accessing the table by index
    End Sub

    Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
        DisconnectedModel.CreateEmployees()
        grdEmployees.DataSource = ds.Tables("Employees") 'Accessing table by Name
    End Sub
    'For sorting purpose, U should use DataView class which has the sorting ability in it. 
    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        If ds.Tables("Employees") Is Nothing Then
            DisconnectedModel.CreateEmployees()
        End If
        Dim div As New DataView(ds.Tables("Employees")) ', "EmpAddress = 'Mangalore'", "EmpAddress", DataViewRowState.CurrentRows)//Use additional parameters for filtering purpose. 
        grdEmployees.DataSource = div
    End Sub

    Private Sub grdEmployees_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles grdEmployees.CellMouseUp
        If e.Button = MouseButtons.Right Then
            grdEmployees.Rows(e.RowIndex).Selected = True
            rowIndex = e.RowIndex
            ContextMenuStrip1.Show(grdEmployees, e.Location)
            ContextMenuStrip1.Show(Cursor.Position)
        End If
    End Sub

    Private Sub DeleteRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRowToolStripMenuItem.Click
        If Not grdEmployees.Rows(rowIndex).IsNewRow Then
            grdEmployees.Rows.RemoveAt(rowIndex)
            DisconnectedModel.DeleteRecord()
        End If
    End Sub

    Private Sub UpdateRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateRowToolStripMenuItem.Click
        DisconnectedModel.UpdateRecord()
    End Sub
End Class