Imports System.Reflection
'Reflection is a namespace that contain classes that allow to read the metadata of the Assembly(DLL or EXE) at runtime and get its Runtime Type Information. U could make decisions based on the type selected at runtime and create/use the components based on ur logic. 
Public Class Form1
    Friend asmDetails As Assembly
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        openFileDlg.ShowDialog(Me)
        Dim dllName = openFileDlg.FileName
        If String.IsNullOrEmpty(dllName) Then
            MsgBox("File is not selected")
            Return
        Else
            asmDetails = Assembly.LoadFile(dllName)
            Dim alltypes As Type() = asmDetails.GetTypes 'Get alltypes.ToList(Of String)().Sort()
            lstClasses.DataSource = alltypes
            lstClasses.DisplayMember = "FullName"
        End If
    End Sub

    Private Sub lstClasses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstClasses.SelectedIndexChanged
        If asmDetails Is Nothing Then
            MsgBox("First select the dll and then find UR class")
            Return
        End If
        Dim clName As Type = lstClasses.SelectedItem 'U have selected a class from the List of Classes. 
        Dim functions As MethodInfo() = clName.GetMethods()
        lstFunctions.DataSource = functions
        lstFunctions.DisplayMember = "Name"
    End Sub

    Private Sub lstFunctions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFunctions.SelectedIndexChanged
        Dim clName As Type = lstClasses.SelectedItem 'Get the class info
        Dim selectedMethod As MethodInfo = lstFunctions.SelectedItem ' Get the method info
        Dim parameters As ParameterInfo() = selectedMethod.GetParameters()
        lstParameters.Items.Clear()
        For Each item In parameters
            Dim str = $"{item.Name}-{item.ParameterType().Name}"
            lstParameters.Items.Add(str)
        Next
    End Sub

    Private Sub btnInvoke_Click(sender As Object, e As EventArgs) Handles btnInvoke.Click
        Dim count = lstParameters.Items.Count
        Dim method = lstFunctions.SelectedItem.Name
        Dim frm As New MethodInvoke(count, method)
        frm.ShowDialog(Me)
    End Sub
End Class
