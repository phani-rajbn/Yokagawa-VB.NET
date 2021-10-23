''' <summary>
''' This is a demo on using Statements of VB.NET. Use this file to understand the syntax of statements in VB 
''' </summary>
Module Statements
    Sub Main()
        forLoopDemo()
        'Develop the code for display the multiplication table of any number.
        displayTable(5)
    End Sub
    Sub displayTable(ival As Integer)
        Console.WriteLine("Table of {0}", ival)
        For index = 1 To 10
            Console.WriteLine("{0} X {1} = {2}", ival, index, ival * index)
        Next
    End Sub
    ''' <summary>
    ''' Example on for loop in VB.NET. 
    ''' Used to interate a statement or block for a specific no of times. 
    ''' </summary>
    Private Sub forLoopDemo()
        For index = 1 To 10 Step 2 '1 is default
            Console.WriteLine(index)
        Next
    End Sub
End Module
