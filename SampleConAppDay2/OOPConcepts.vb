Imports SampleConAppDay2.RepositoryExample

Module OOPConcepts
    Sub Main()
        AddCustomer(Nothing)
    End Sub
    'Pass the raw meterials required for this function to work. UR function should do only one job. It should not ask questions, it should give U an answer for the questions that U pass to it.
    Sub AddCustomer(Cst As Customer)
        'Code rquired to add this Customer to the database
        If IsNothing(Cst) Then
            MsgBox("Guys! This guy has no info")
            Return 'Exiting the Subroutine
        End If

    End Sub
End Module
