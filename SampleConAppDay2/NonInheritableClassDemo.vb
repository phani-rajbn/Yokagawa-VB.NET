'Final classes of Java are in VB.NET Called as NonInheritable classes
'They are also called as Sealed classes.
Module NonInheritableClassDemo
    Sub Main()
        Dim td As New TestDerived
        td.TestFunc()
    End Sub
End Module
NotInheritable Class TestClass
    Public Sub TestFunc()
        Console.WriteLine("Test Func example")
    End Sub
End Class
'Containment is the only way to reuse non inheritable classes.
Class TestDerived
    Private instance As New TestClass
    Public Sub TestFunc()
        instance.TestFunc()
        Console.WriteLine("Reusing the code")
    End Sub
End Class