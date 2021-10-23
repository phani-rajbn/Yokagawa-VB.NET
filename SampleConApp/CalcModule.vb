'All the Conversion functions of Classic VB
Module CalcModule
    Sub Main()
        Do
            Console.WriteLine("Enter the First Value as double")
            Dim dVal1 = CDbl(Console.ReadLine()) 'Implict typed variable similar to var keyword of C#.

            Console.WriteLine("Enter the Second Value as double")
            Dim dVal2 = CDbl(Console.ReadLine())

            Console.WriteLine("Enter the choice as +, - * or /")
            Dim operand = Console.ReadLine

            Dim res = performOperation(dVal1, dVal2, operand)
            Console.WriteLine("The result of this operation is " & res)
        Loop
    End Sub
    Function performOperation(dVal1 As Double, dVal2 As Double, operand As String) As Double
        Select Case operand
            Case "+"
                Return AddFunc(dVal1, dVal2)
            Case "-"
                Return SubFunc(dVal1, dVal2)
            Case "*"
                Return MulFunc(dVal1, dVal2)
            Case "/"
                Return DivFunc(dVal1, dVal2)
            Case Else
                Return 0
        End Select
    End Function
    Private Sub simpleDataTypes()
        Dim iVal As Integer, iVal2 As Integer
        Console.WriteLine("Enter the value 1")
        iVal = Integer.Parse(Console.ReadLine()) 'ReadLine is a method of the Console class that takes the input from the User in Console and returns a string representation of it. 
        'All value types have a method called Parse that will convert a string to its own type. 
        iVal2 = Integer.Parse(Console.ReadLine())
        Dim iRes As Integer = iVal + iVal2
        'Console.WriteLine("The value is " & iRes)
        Console.WriteLine("Value 1:{0} and Value 2: {1} when added will result {2}", iVal, iVal2, iRes)
    End Sub
    'FunctionName: AddFunc, 2 args:dVal1 and dVal2, returns double
    Function AddFunc(dVal1 As Double, dVal2 As Double) As Double
        'AddFunc = dVal1 + dVal2 'Older syntax, not recommended.
        Return dVal1 + dVal2 'New syntax with return keyword.
    End Function
    Function SubFunc(dVal1 As Double, dVal2 As Double) As Double
        Return dVal1 - dVal2
    End Function
    Function MulFunc(dVal1 As Double, dVal2 As Double) As Double
        Return dVal1 * dVal2
    End Function
    Function DivFunc(dVal1 As Double, dVal2 As Double) As Double
        Return dVal1 / dVal2
    End Function
End Module
