Imports System.IO
'Try catch finally and Throw are the keywords used for  exceptions handling in VB.NET
'Exception is an abnormal condition in the execution of the application when the App fails to understand how to proceed. In this case, the app will halt and the runtime will terminate the app abnormally.
'As a programmer U will handle such conditions and try to give an alternate path of execution. 
'Try block will contain the code that could raise an exception. The catch block will handle the raised exception. U can have multiple catch blocks within a single try. Every Try block is ended with an End Try. Optionally U can also have finally block which will execute on all conditions irrespective the Exception is raised or not.
'There are 100s of classes that define the different kinds of Exceptions raised by the .NET CLR. They are grouped into the namespaces. For all File IO related issues, U have IOException that will handle almost all the Exceptions raised during the file handling. If the file is not found, the CLR raises the FileNotFoundException
'If U try to access an object that has not been instantiated or created, then the CLR will raise the NullReferenceException
'Exceptions are of 2 types: System generated exceptions which are raised by the CLR and App Specific Exceptions that are raised by the programmer for his/her business logic requirements. 
'Custom Exceptions are App specific Exceptions that are created to raise the Exception with App perspective. EmployeeNotFoundException, RegistrationFailedException, LoginFailedException are some of the custom Exceptions that programmers create to raise the exception for their app logical requirements. 
'Logging of Exceptions will be covered later
Enum BookErrorCode
    ID = 1
    Title = 2
    Price = 3
End Enum
Module ExceptionHandling
    Sub Main()
        oldSyntaxOfErrorHandling()
        'simpleTryCatchExample()
        'nullReferenceExample()
        'fileNotFoundExample()s
        'Try 'Example to catch the thrown exception from the ThrowExample
        '    ThrowExample()
        'Catch ex As Exception
        '    Console.WriteLine(ex.Message)
        'End Try

        'Try
        '    Dim test As New BookStore
        '    test.UpdateBook(Nothing)
        'Catch ex As BookNotFoundException
        '    Console.WriteLine(ex.Message)
        'End Try

    End Sub

    Private Sub oldSyntaxOfErrorHandling()
        On Error GoTo Err
        Console.WriteLine("welcome to old syntax of Error Handling")
        Dim intVal = Integer.Parse(Console.ReadLine)
        Console.WriteLine(intVal)
Err:
        MsgBox(Err.Description)
    End Sub
    'All Exceptions are objects of a class derived from System.Exception. If U want Ur code to raise an Exception, U can do so by throwing an object of the Exception class or any one of its derivatives. U can create UR own custom Exception and throw it.  
    ''' <summary>
    ''' Example to raise an Exception thru code in VB.NET
    ''' </summary>
    ''' <exception cref="System.Exception">Throws when the user role is not appropriate</exception>
    Private Sub ThrowExample()
        Console.WriteLine("Enter the User role")
        Dim role = Console.ReadLine
        If role = "Trainer" Or role = "Trainee" Then
            Console.WriteLine("Welcome to the user")
        Else
            Throw New Exception("Invalid Role") 'Throw will raise an exception. 
        End If
    End Sub
    'Dont write a code that could raise an exception as much as possible, handle all the exception possibilities at compile time itself and unexpected exceptions to be handled thru' TCF segments. Exception handling will break the execution, handle the exception and return to the run mode. This will have an impact on the App execution.
    Private Sub fileNotFoundExample()
        Dim filename = "SampleContent.txt"
        If Not File.Exists(filename) Then
            Console.WriteLine("This file is not available to read")
            Return
        End If
        Try
            Dim content = File.ReadAllText(filename)
            Console.WriteLine(content)
        Catch ex As FileNotFoundException
            Console.WriteLine($"{filename} is not found to read")
        End Try
    End Sub
    'Factory method to create a book after following the business rule 
    Function createBook(id As Integer, title As String, price As Double, ByRef errCode As BookErrorCode) As Book
        'Business rules are applied and then the book is created and returned. 
        If id <= 0 Or String.IsNullOrEmpty(title) Or price < 100 Then
            If id <= 0 Then errCode = BookErrorCode.ID
            If title = "" Then errCode = BookErrorCode.Title
            If price < 100 Then errCode = BookErrorCode.Price
            Return Nothing
        End If
        Return New Book With {.BookId = id, .Title = title, .Price = price}
    End Function
    Private Sub nullReferenceExample()
        Dim errCode As BookErrorCode
        Try
            Dim myBook = createBook(-123, "SOmeTimte", 150, errCode)
            Console.WriteLine(myBook.Title & " is the title of the book I purchased")
        Catch fEx As NullReferenceException
            Select Case errCode
                Case BookErrorCode.ID
                    Console.WriteLine("ID of the Book should be a valid positive no")
                    Return
                Case BookErrorCode.Title
                    Console.WriteLine("Title of the Book is mandatory")
                    Return
                Case Else
                    Console.WriteLine($"Price of the Book must be atleast {100:C}")
                    Return
            End Select
        End Try
    End Sub

    Private Sub simpleTryCatchExample()
RETRY:
        Try
            Console.WriteLine("Enter a number to add")
            Dim intVal = Integer.Parse(Console.ReadLine())
        Catch fEx As FormatException
            Console.WriteLine("Input should be a valid whole number")
            GoTo RETRY
        Catch oEx As OverflowException
            Console.WriteLine($"Number entered should be within {Integer.MinValue} and {Integer.MaxValue}")
            GoTo RETRY
        End Try
    End Sub
End Module
'All Custom Exceptions are expected to be derived from ApplicationException.

Class BookNotFoundException
    Inherits ApplicationException
    Public Sub New()

    End Sub
    Public Sub New(message As String)
        MyBase.New(message) 'MyBase is similar to base keyword of C# and final keyword of Java.
    End Sub

    Public Sub New(message As String, innerException As Exception)
        MyBase.New(message, innerException)
    End Sub
End Class
'By default, when a class instance is created, internally its base class default constructor will be called. If U want to call the specific version of the overloaded constructors, U can use MyBase keyword is used to refer the immediate base class of the current class and call its constructor using New and pass the required args.  