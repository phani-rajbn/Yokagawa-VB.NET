'Delegates are reference types that hold references of functions/methods. They are used for creating functions that take a function as an arguement, very similar to callback functions that U see in JS and Java. 
'For any kind of functions U have ready to use delegates called Func(Functions) and Action(Subroutines). 
Delegate Function MathOperator(v1 As Double, v2 As Double) As Double
Module DelegatesExample
    Dim nameToFind As String
    'Using custom Delegate
    Sub InvokeMathOperation(v1 As Double, v2 As Double, op As MathOperator)
        Dim res = op(v1, v2)
        MsgBox(res)
    End Sub
    'Using Func delegate which is the generic delegate defined in .NET
    Sub InvokeMathOperation(v1 As Double, v2 As Double, op As Func(Of Double, Double, Double))
        Dim res = op(v1, v2)
        MsgBox(res)
    End Sub
    Function addFunc(first As Double, second As Double) As Double
        Return first + second
    End Function
    Sub Main()
        'Dim method As New MathOperator(AddressOf addFunc) 'Create the instance of the delegate object and associate a method with matching signature.
        Dim method As New Func(Of Double, Double, Double)(AddressOf addFunc)
        InvokeMathOperation(123, 234, method)
        'usingPredicateDelegate()

    End Sub
    'Delegate handler
    Function findingLogic(name As String) As Boolean
        Return name.Contains(nameToFind) 'return true if the word or the sequence of the charecters is found in string
    End Function
    Private Sub usingPredicateDelegate()
        Dim list As New List(Of String)(New String() {"Ramesh", "Gopal", "Swamy", "Krishna", "Ramnath", "Shiva", "Robert", "James"})
        Console.WriteLine("Enter the name of the Employee to find in the list")
        nameToFind = Console.ReadLine
        Dim func As New Predicate(Of String)(AddressOf findingLogic) 'associate the delegate instance to the method
        Dim foundRec = list.Find(func)
        Console.WriteLine("The found emp is " + foundRec)
    End Sub
End Module
