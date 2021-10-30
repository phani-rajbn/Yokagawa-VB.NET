Imports SampleConAppDay2.RepositoryExample

Module OveridingExample
    Sub Main()
        Dim accType = ConsoleHelper.GetString("Enter the TypeOf Of Account U want to create")
        Dim acc = CreateObject(accType)
        acc.MakePayment(50000, "Cheque")
        acc.MakePayment(50000, "Card")
    End Sub
    'Factory pattern applied. 
    Function CreateObject(type As String) As Account
        Select Case type
            Case "Old"
                Return New Account()
            Case "New"
                Return New NewAccount()
            Case Else
                Return Nothing
        End Select
    End Function
End Module
Class Account
    Public Overridable Sub MakePayment(amount As Double, mode As String) 'Base class is giving permission to change in the derived class. Similar to C++
        If mode = "Cash" Or mode = "Cheque" Then
            MsgBox($"Payment of {amount:C} recieved as {mode}")
        Else
            MsgBox("Invalid Mode of Payment")
        End If
    End Sub
    Public Sub RecievePayment(amount As Double) ' This function cannot be modified in the derived class.
        Console.WriteLine($"Payment of {amount:C} recieved as Cash")
    End Sub
End Class

Class NewAccount
    Inherits Account
    Public Overrides Sub MakePayment(amount As Double, mode As String)
        Console.WriteLine("Cards are accepted here")
        If mode = "Cash" Or mode = "Card" Then
            MsgBox($"Payment of {amount:C} recieved as {mode}")
        Else
            MsgBox("Invalid Mode of Payment")
        End If
    End Sub
    'Shadows tells the compiler that this function is redefined and shadows(hides) the base version
    Public Shadows Sub RecievePayment(amount As Double)
        Console.WriteLine($"Payment of {amount:C} recieved thru' PhonePay")
    End Sub
End Class
'A Class is immutable, so if any function needs to be modified after creating and distributing it, U should inherit it into another class and modify it in the other. 
'An existing method of a class needs to be modified. U extend the class and change the functionality of the method without altering the signature of the method including the return type, name and the parameters of the method.
'In VB.NET only methods that are marked as OVERRIDABLE can be overriden in the derived classes. 
'In the derived class the method is modified using a modifier called overrides. overrides modifier can be applied to a method only if the base class version of the method has a modifier called overridable, mustoverride or overrides  
'Method overriding leads to a concept of RUNTIME POLYMORPHISM. 
'If a method in the base class is not overridable, then U cannot override the method, however U can reimplement the method and the features of RTP will not be applied. UR modified method cannot have overrides keyword. It gives a warning that the method is already implemented in the base class and should be provided with modifier called shawdows(hides) 
'3 Key points:
' overridable: Used in the base class for making this function modifiable
' overrides: Used in the derivd class for making modifable functions to modify
' shadows: Used in the derived class if a non overridable function is modified. 