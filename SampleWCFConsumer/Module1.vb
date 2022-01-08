Imports SampleWCFConsumer.myServices
Module Module1
    Sub Main()
        Dim obj As New EmpServiceClient 'A Proxy class with a suffix Client will be auto generated when U add the service reference
        Dim data = obj.GetAllEmployees
        For Each emp In data
            Console.WriteLine("The EmpName: " & emp.EmpName)
        Next
        addRecord() 'Call the addRecord
        Console.WriteLine("Press any key to continue")
        Console.ReadLine()
    End Sub

    Sub addRecord()
        Dim emp As New Employee With {.EmpID = 333, .EmpAddress = "Dharwad", .EmpName = "Shyam", .EmpSalary = 60000}
        Dim obj As New EmpServiceClient
        obj.AddEmployee(emp)
    End Sub
End Module
