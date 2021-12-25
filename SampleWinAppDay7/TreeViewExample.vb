Imports SampleDataLib
Imports System.Collections.Generic
Public Class TreeViewExample
    'Load Event of the Form is handled to perform data population to the controls of the Form when its loaded into the memory.
    Private Sub TreeViewExample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim com = DataFactory.GetComponent
        Dim table = com.GetAllEmployees
        For Each row In table.Rows
            Dim node As New TreeNode(row("EmpId"))
            Dim children As New List(Of TreeNode)
            children.Add(New TreeNode(row("EmpName")))
            children.Add(New TreeNode(row("EmpAddress")))
            children.Add(New TreeNode(row("EmpSalary")))
            node.Nodes.AddRange(children.ToArray())
            TreeView1.Nodes.Add(node)
        Next
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If Not e.Node.Parent Is Nothing Then
            StatusStrip1.Items(0).Text = e.Node.Parent.Text
        End If
    End Sub
End Class
'TreeView that displays all the directories of a Drive and its files. ON selecting file, it should display the details of the file. 
'Explore the File, Directory static methods 
'DataGridView Control and Disconnected Architecture. 
'TabControl.