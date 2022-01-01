Imports SampleCOMLibLib
Public Class COMConsumer
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Dim com As IMathComponent
        'com = New MathComponentClass()
        'Dim com As New MathComponentClass 'For every COM Component, .NET will create wrapper class with a suffix class. 
        'Dim result As Integer
        'com.AddMethod(123, 23, result)
        Dim com As Object
        com = CreateObject("SampleCOMLib.MathComponent") 'invoking the COM componet using progid thru late binding. 
        Dim result As Integer
        com.AddMethod(123, 23, result)
        MsgBox(result)
    End Sub

    Private Sub subFunc_Click(sender As Object, e As EventArgs) Handles subFunc.Click
        'Dim com As New MathComponentClass
        'Dim result As Integer
        'com.SubtractMethod(123, 23, result)
        'MsgBox(result)
    End Sub
End Class