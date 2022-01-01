Imports System.Reflection
Public Class MethodInvoke
    Dim cLeft As Integer = 1
    Dim clName As Type
    Dim method As MethodInfo
    Dim parameters As ParameterInfo()
    Public Sub New(count As Integer, name As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        method = Form1.lstFunctions.SelectedItem
        lblTitle.Text = $"Method Name: {name}"
        For index = 1 To count
            Dim txt As New TextBox
            Controls.Add(txt)
            txt.Top = cLeft * 100
            txt.Left = 500
            txt.Name = "txt" + index.ToString()
            cLeft = cLeft + 1
        Next
        getClassDetails()
    End Sub
    Private Sub getClassDetails()
        Dim cLeft As Integer = 1
        clName = Form1.lstClasses.SelectedItem
        Dim selectedMethod As MethodInfo = Form1.lstFunctions.SelectedItem
        parameters = selectedMethod.GetParameters()
        For Each pm As ParameterInfo In parameters
            Dim lbl As New Label
            lbl.Text = $"Parameter: {pm.Name}DataType: {pm.ParameterType}"
            lbl.AutoSize = True
            Controls.Add(lbl)
            lbl.Top = cLeft * 100
            lbl.Left = 700
            cLeft = cLeft + 1
        Next
    End Sub

    Private Sub btnInvoke_Click(sender As Object, e As EventArgs) Handles btnInvoke.Click
        Dim clsName As Type = Form1.lstClasses.SelectedItem 'Get the selected class
        Dim obj As Object = Activator.CreateInstance(clsName) 'Create the instance of the class
        Dim values(parameters.Length - 1) As Object 'Create the paramter values with all set to nothing. 
        For index = 0 To parameters.Length - 1
            Dim value = TryCast(Controls.Find("txt" + (index + 1).ToString(), False)(0), TextBox).Text
            values(index) = Convert.ChangeType(value, parameters(index).ParameterType)
        Next
        Dim result = method.Invoke(obj, values)
        MsgBox(result)
    End Sub
End Class