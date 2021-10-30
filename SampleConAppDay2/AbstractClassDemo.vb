'Abstract class in OOP is a class that has atleast one non implemented function. A function may not be implemented due to the reasons of not having clarity on the implementation. 
'These classes are provided with a modifier called MustInherit. 
'The methods that cannot be implemented are provided with a modifier called Mustoverride. 
'As one or more methods of abstract class is not implemented, the class is incomplete. So we cannot instantiate the abstract classes.
'The derived class who inherits this abstract class must implement all the mustoverride methods and can be instantiated, else even this class must be declared as Mustinherit.
'Read only Properties allow the property to be read by the user, but cannot be set anywhere else. However U can set a value for the property at the declaration time or at the constructor of the class. Once set, it is not modifiable.  
Module AbstractClassDemo
    Sub Main()
        Dim obj As AbstractClassExample.Account
        obj = New AbstractClassExample.SBAccount
        obj.AccName = "Phaniraj"
        obj.AccId = 123
        obj.Credit(65000)

        obj.Credit(5000)
        obj.CalculateInterest()
        Console.WriteLine("The Current Balance is " & obj.Balance)
    End Sub
End Module
Namespace AbstractClassExample 'Namespaces are created to avoid naming conflicts of the classes. Namespaces dont have any filename, they are simply conceptual grouping.  
    MustInherit Class Account

        Public Property AccName As String
        Public ReadOnly Property Balance As Double = 5000 'If a property is readonly, U cannot set the values to it. However U can use the private fields created by VB.NET to set the values and can be set only within the class.
        Public Property AccId As String
        ''' <summary>
        ''' Adds the Amount to the current balance of the Account
        ''' </summary>
        ''' <param name="amount">The Amount in double to add</param>
        Public Sub Credit(amount As Double)
            _Balance += amount 'Hidden field created by VB for UR public property Balance
        End Sub

        Public Sub Debit(amount As Double)
            If Balance > amount Then
                _Balance -= amount
            Else
                Throw New Exception("Insufficient Funds")
            End If
        End Sub
        Public MustOverride Sub CalculateInterest()
    End Class

    Class SBAccount
        Inherits Account
        Public Overrides Sub CalculateInterest()
            Dim principle = Me.Balance ' this equivalent in VB.NET
            Dim rate = 6.5 / 100
            Dim term = 1 / 4
            Dim interest = principle * rate * term
            Credit(interest)
        End Sub
    End Class
End Namespace
'Create 3 classes for FD, RD account. CalculateInterest should be implemented as per the norms. Use Factory pattern to see RTP in the abstract classes 

