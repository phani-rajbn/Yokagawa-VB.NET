'Namespace is conceptual grouping of classes and modules to avoid naming conflicts. 
'Each class is designed to create only one kind of operation
Imports System.IO
'use a module if U have a set of functions that U R repeatedly using in the application. 
Namespace RepositoryExample
    Module ConsoleHelper
        Function GetString(question As String) As String
            Console.WriteLine(question)
            Return Console.ReadLine
        End Function

        Function GetNumber(question As String) As Integer
            Console.WriteLine(question)
            Return CInt(Console.ReadLine)
        End Function
        Function GetDouble(question As String) As Double
            Console.WriteLine(question)
            Return CDbl(Console.ReadLine)
        End Function
        Function GetDate(question As String) As Date
            Console.WriteLine(question)
            Console.WriteLine("Enter the date in the format of dd/MM/yyyy")
            Return CDate(Console.ReadLine)
        End Function
    End Module
    ''' <summary>
    ''' Represents a customer of the Application
    ''' </summary>
    Class Customer
        Public Property CustomerID As Integer  'Automatic properties available from VS 2010 where
        Public Property CustomerName As String
        Public Property CustomerAddress As String
        Public Property BillDate As DateTime
        Public Property BillAmount As Double
    End Class
    Class CustomerDatabase
        Private customers(99) As Customer 'Customer Array in VB.NET
        'post the data to the database
        Public Sub AddCustomer(cst As Customer)
            For i = 0 To customers.Length 'iterate thro the array
                If IsNothing(customers(i)) Then 'find the first occurence of nothing
                    customers(i) = New Customer() 'create the customer in that location
                    customers(i).CustomerID = cst.CustomerID 'fill all the values
                    customers(i).CustomerName = cst.CustomerName
                    customers(i).CustomerAddress = cst.CustomerAddress
                    customers(i).BillAmount = cst.BillAmount
                    customers(i).BillDate = cst.BillDate
                    Exit Sub 'break statement of Java, exit the function
                End If
            Next
        End Sub
        'Delete the data to the database
        Public Sub DeleteCustomer(cstId As Integer)
            For index = 0 To customers.Length
                If Not IsNothing(customers(index)) And customers(index).CustomerID = cstId Then
                    customers(index) = Nothing 'removing the data and setting it to null
                    Exit Sub
                End If
            Next
        End Sub
        ''put the data into the database as modified content
        Public Sub UpdateCustomer(cst As Customer)
            For i = 0 To customers.Length 'iterate thro the array
                If Not IsNothing(customers(i)) And customers(i).CustomerID = cst.CustomerID Then 'find the first occurence of nothing
                    customers(i).CustomerName = cst.CustomerName
                    customers(i).CustomerAddress = cst.CustomerAddress
                    customers(i).BillAmount = cst.BillAmount
                    customers(i).BillDate = cst.BillDate
                    Exit Sub 'break statement of Java, exit the function
                End If
            Next
        End Sub
        'Get the data based on the Id
        Public Function FindCustomer(cstId As Integer) As Customer
            For index = 0 To customers.Length
                If Not IsNothing(customers(index)) And customers(index).CustomerID = cstId Then
                    Return customers(index)
                End If
            Next
            Return Nothing 'if there is no matching customer
        End Function
    End Class

    'User interface of UR App
    Module CustomerApp
        Private db As New CustomerDatabase
        Private processing As Boolean
        Private Function readMenu(fileName As String) As String
            Dim menu = File.ReadAllText(fileName)
            Return menu
        End Function
        Sub Main(args As String())
            Dim menu As String = readMenu(args(0))
            Do
                Dim choice = ConsoleHelper.GetString(menu)
                processing = processMenu(choice)
            Loop While (processing)
            Console.WriteLine("Thanks for Using our Application. Signing OFF!!!!")
        End Sub

        Private Function processMenu(choice As String) As Boolean
            Select Case UCase(choice)
                Case "N"
                    addingRecord()
                Case "U"
                    updateRecord()
                Case "D"
                    deleteRecord()
                Case "F"
                    findRecord()
                Case Else
                    Return False
            End Select
            Return True
        End Function

        Private Sub findRecord()
            Dim recID = ConsoleHelper.GetNumber("Enter the Id of the Customer to find")
            Dim cst = db.FindCustomer(recID)
            If IsNothing(cst) Then
                Console.WriteLine("Customer not found to show")
            Else
                Console.WriteLine($"{cst.CustomerName } from {cst.CustomerAddress }")
            End If
        End Sub

        Private Sub deleteRecord()
            Dim recID = ConsoleHelper.GetNumber("Enter the Id of the Customer to delete")
            db.DeleteCustomer(recID)
            Console.WriteLine($"Customer with ID {recID} deleted from the database")
        End Sub

        Private Sub updateRecord()
            Dim obj As New Customer
            obj.CustomerID = ConsoleHelper.GetNumber("Enter the Id of the Customer to Update")
            obj.CustomerName = ConsoleHelper.GetString("Enter the Modified Name of the Customer")
            obj.CustomerAddress = ConsoleHelper.GetString("Enter the Modified Address of the Customer")
            obj.BillDate = ConsoleHelper.GetDate("Enter the Modified Billing date of the Customer")
            obj.BillAmount = ConsoleHelper.GetDouble("Enter the BillAmount to modify")
            db.UpdateCustomer(obj)
            Console.WriteLine("Customer updated Successfully")
        End Sub

        Private Sub addingRecord()
            Dim obj As New Customer
            obj.CustomerID = ConsoleHelper.GetNumber("Enter the Id of the Customer")
            obj.CustomerName = ConsoleHelper.GetString("Enter the Name of the Customer")
            obj.CustomerAddress = ConsoleHelper.GetString("Enter the Address of the Customer")
            obj.BillDate = ConsoleHelper.GetDate("Enter the Billing date of the Customer")
            obj.BillAmount = ConsoleHelper.GetDouble("Enter the BillAmount")
            db.AddCustomer(obj)
            Console.WriteLine("Customer added Successfully")
        End Sub
    End Module
End Namespace