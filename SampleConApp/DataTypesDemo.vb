' Sub functions are also called as Sub Routines. They are void functions of VB(VB.NET). Sub routines dont return a value. If U want a function to return a value, we use function instead of sub routines
'Blocks in VB are provided as Sub/Function and ended with End Sub/Function. There is no {} concept in VB.NET.
'This demo shows on handling multiple Mains in ur project
'Project->Properties->Application->Startup Object. The Drop down list displays all the modules/Classes that have valid Entry point.
'Sub name should be Main. Main Function must be static, it can return void or int. No other data type is allowed. It can have String [] as arg and no other kind of args are allowed. 
'''''''''''''''''''''''''''''Data types in VB'''''''''''''''''''''''''''''
'All data types in VB are derived from the Common Type System of the .NET Framework. Common Type System(CTS) is the base type system for all .NET languages. These types are the basis for creating datatypes in any .NET language. It is the part of the Common language specification that says all .NET enabled languages should adhere to the Common Type system.
'It contains Value Types and Reference types: Value types are primitive types: 
' Integral values: Byte(System.Byte), Short(System.Int16), Integer(System.Int32), Long(System.Int64).
' Floating values: Single(System.Single), Double(System.Double), Decimal(System.Decimal)-128Bit value
' Other types: Char, Boolean, DateTime, Structure, Enums

'Reference types: Strings, Arrays, Classes, Object are examples of Reference types. The data of the reference type is created in the Managed Heap of the .NET Framework and its reference will be stored in the variable.  
Module DataTypesDemo
    Sub Main()
        'FuncVsSub()
        Console.WriteLine("The Range of integer is " & Integer.MinValue & " and " & Integer.MaxValue)
        Console.WriteLine("The Range of long is " & ULong.MinValue & " and " & ULong.MaxValue)
        Console.WriteLine("The Range of long is " & Decimal.MinValue & " and " & Decimal.MaxValue)
        Console.WriteLine("The current date is " & Date.Now)
    End Sub

    Sub FuncVsSub()
        Console.WriteLine("2nd Program")
        Dim res = AddFunc(123, 23)
        Console.WriteLine(res.ToString() + " is the result of the AddFunc")
    End Sub

    Function AddFunc(v1 As Integer, v2 As Integer) As Integer
        Return v1 + v2
    End Function
End Module
