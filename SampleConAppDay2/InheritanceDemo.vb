Module InheritanceDemo
    Sub Main()
        Dim obj As New ChildClass
        obj.ParentFunc()
        obj.ChildFunc()
    End Sub
End Module

Class ParentClss
    Public Sub ParentFunc()
        Console.WriteLine("Parent Func")
    End Sub
End Class

Class ChildClass
    Inherits ParentClss
    Public Sub ChildFunc()
        Console.WriteLine("Child Func")
    End Sub
End Class
''NOTES:
' Inherits keyword is used to inherit a class into the current class
' U can inherit only one class at any level, however U can have multi level inheritance. Each hierarchy will have only one class but can have multi level Hierarchy. 
'Inheritance leads to the concept of 'IS A' relation. Old VB was having containement as reusability option(HAS-A relation) 


