Imports System.IO
''Arrays are most common data structure for storing data of the same type as a contiguous memory. Each value in the array is called as Element and it is accessed thru an index.  
'Arrays are fixed in size. Once U declare the array, it cannot be modified. For dynamic arrays, U can use Collection classes of the .NET Framework.
'Find out how Jagged arrays work in VB.NET: Array of arrays is called Jagged Arrays. 
Module ArraysDemo
    Sub Main(args As String()) 'args is the command line args for this Application. 
        'createAndReadArray()
        'Read the file whose fullpath is passed as command line arg
        'CommandLineExample(args)
        'RedimExample()
        multiDimensionalArrayExample()
    End Sub
    'Using 2D array and display it in matrix format.
    Private Sub multiDimensionalArrayExample()
        Dim TwoD As Integer(,) = {{4, 5, 7}, {6, 7, 2}, {7, 8, 5}} '3x3
        For x = 0 To TwoD.GetLength(0) - 1 'Length of 1st dimension
            For y = 0 To TwoD.GetLength(1) - 1 'Length of the 2nd dimension
                Console.Write("{0} ", TwoD(x, y))
            Next
            Console.WriteLine()
        Next
    End Sub
    'In VB6 we had an option of redefining the array once it is created. ReDim is like redefining the size after the array is created. Redim recreates the array(new array). However, U can retain the old values using Preserve keyword... 
    Private Sub RedimExample()
        Dim array As String()
        ReDim array(2) 'Set the size for the array in the ReDim statement
        array(0) = "Test 123"
        array(1) = "Test 234"
        array(2) = "Test 345"
        For Each item In array
            Console.WriteLine(item)
        Next
        ReDim Preserve array(10) 'Retain the old values and increase the array size
        Console.WriteLine("The size is " & array.Length)
        For Each item In array
            Console.WriteLine(item)
        Next
    End Sub

    Private Sub CommandLineExample(args() As String)
        If File.Exists(args(0)) Then
            Dim contents = File.ReadAllText(args(0))
            Console.WriteLine(contents)
        End If
    End Sub

    Private Sub createAndReadArray()
        'Dim fruits As String() 'Declares the array
        'fruits = New String(5) {} 'Instantiating the array with values...
        Dim fruits(5) As String 'Array of size 6
        Console.WriteLine("The no of elements in the array is {0}", fruits.Length)
        For index = 0 To fruits.Length - 1
            Console.WriteLine("Enter the fruit name at the index " & index)
            fruits(index) = Console.ReadLine
        Next

        'iterating thru the foreach statement, works only on collections. 
        For Each fruit As String In fruits
            Console.WriteLine(fruit)
        Next
    End Sub
End Module
