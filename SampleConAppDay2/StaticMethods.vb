'Why static members in a class. If a method of a class is used very frequently in UR program, it is good to create the method as static. With this, the method could be called by the name of the class instead of the instance. There will be no need for an instance. For frequently used methods, it is hard time to create objects, call them and then get garbage collected. So U can make the method as static and call it by the classname.
'Modules do the same thing in VB.NET but are not object oriented. They are the part of the classic VB6 which has been retained for backward compatibility.
'If U intend to create a class with only static methods in them, U can create them within the module. 
'Console is a very popular static class that has only static methods in them. 
Module StaticMethods
    Sub Main()
        StaticClass.StaticFunc() 'static method calling thru' classname
        Dim obj As New StaticClass
        obj.InstanceFunc() 'instances cannot call static methods even if they belong to the same class
    End Sub
End Module

Class StaticClass
    'Methods will be marked as shared. 
    Public Shared Sub StaticFunc()
        Console.WriteLine("Static function called without an object")
    End Sub

    Public Sub InstanceFunc()
        Console.WriteLine("Can be called only thru' an object instance")
    End Sub
End Class
