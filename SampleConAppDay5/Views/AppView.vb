Module AppView
    Sub Main()
        Dim component = DataFactory.GetComponent
        Dim emp As New Employee With {.EmpID = 123, .EmpName = "Phaniraj B.N.", .EmpAddress = "Mysore", .EmpSalary = 45000}
        component.AddNewEmployee(emp)
        'component.UpdateEmployee(emp)
        'component.DeleteEmployee(123)
        'component.GetAllEmployees("")
    End Sub
End Module
