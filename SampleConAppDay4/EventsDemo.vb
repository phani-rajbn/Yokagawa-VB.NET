'Actions performed on the object is called event. This is used in UI related Apps. Click is an event(Action) done by the user on the button or a textbox or a checkbox or any other UI control of a Web/Win form. 
'All events in .NET are objects of a delagate. EventHandler is one common delegate for all UI related Controls. 
Module EventsDemo
    Dim WithEvents empDB As New EmpDatabase
    Sub Main()
        empDB.AddEmployee(123, "testName") 'U call a method of the object and object calls back UR method
    End Sub

    Private Sub empDB_Added() Handles empDB.Added
        MsgBox("Employee added successfully")
    End Sub
End Module
Class EmpDatabase
    Public Event Added As Action 'Action is the builtin delegate I am using to represent an event
    Public Sub AddEmployee(id As Integer, name As String)
        'Code to add the employee to the persistant layer 
        RaiseEvent Added() 'Will call the mapped method of the caller.
    End Sub
End Class
