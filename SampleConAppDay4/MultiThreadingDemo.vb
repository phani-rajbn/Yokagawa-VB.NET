Imports System.Threading
'Thread is a path of execution within a process, A Process is a running instance of an executable. 
'Every process will have atleast one path of execution running in it. If the Thread completes or closes, the process also closes.
'Most of the Apps are fine with single threaded apps. But for certain scenarios where U want to perform multiple operations at a time, we can go for async programming. Multi Threading is one of the ways of acheiving async programming in .NET.
'All Threads in ,NET are objects of a class called System.Threading.Thread. A thread object looks for a delegate instance called ThreadStart which maps to the function that defines the functionality odf the thread.  
Module MultiThreadingDemo
    'Thread functions that take parameters should have only one parameter of the type object. U may have to unbox them if U want to use the parameter in the function
    Sub ThreadFuncWithParameters(data As Object)
        'For index = 1 To data
        '    Console.WriteLine($"Complex Beep #{index}")
        '    Thread.Sleep(1000)
        'Next
        For Each fruit In data
            Console.WriteLine(fruit)
            Thread.Sleep(1000)
        Next
    End Sub
    'Monitor is a static class that is used to maintain Critical section within the Application. If U have a block of code that has to be accessed by only one thread at a time, U can use Monitor class and place the block of code within the Enter and Exit block. 
    Sub ComplexOperation()
        Monitor.Enter(GetType(MultiThreadingDemo))
        For index = 1 To 10
            Console.WriteLine($"Complex Beep of the Thread {Thread.CurrentThread.Name} #{index}")
            'If index = 5 Then
            '    Thread.CurrentThread.Suspend()
            'End If
            Thread.Sleep(1000)
        Next
        Monitor.Exit(GetType(MultiThreadingDemo))
    End Sub
    Sub Main()
        '  ComplexOperation()
        'Dim th As New Thread(New ThreadStart(AddressOf ComplexOperation))
        'th.Start()
        'SimpleOperation()
        'If th.ThreadState = ThreadState.Suspended Then
        '    th.Resume()
        'End If
        '''''''''''''''''''''''Example of Parameterized thread start``````````````````````````````````````
        'Dim th As New Thread(New ParameterizedThreadStart(AddressOf ThreadFuncWithParameters))
        'th.Start(New String() {"Apples", "Mangoes", "Oranges"})

        ''''''''''''''''''''''''''Example of Thread Synchronization''''''''''''''''''''''''''''''''''
        'Dim t1 As New Thread(New ThreadStart(AddressOf ComplexOperation))
        't1.Name = "Thread1"
        'Dim t2 As New Thread(New ThreadStart(AddressOf ComplexOperation))
        't2.Name = "Thread2"
        't1.Start()
        't2.Start()
        ''''''''''''''''''''''''''''''Thread Pools in .NET''''''''''''''''''''''''''''''''''''''''''''''
        'Thread pool is a bunch of ready to use threads that .NET CLR will use to execute and manage .NET Apps. One can use any thread within that pool to perform any async operation if required. 
        'ThreadPool.QueueUserWorkItem(New WaitCallback(AddressOf ComplexOperation))
        'Threads inside the threadpool are background threads(Deamon threads). In this case, if the Main thread has no further operations to do, the App will close and any pending work of the Background thread will be closed. U cannot control the execution of the thread in the thread pool.
        'SimpleOperation()
        ''''''''''''''''''''''''''background Threads''''''''''''''''''''''
        Dim t1 As New Thread(New ThreadStart(AddressOf ComplexOperation))
        t1.Name = "Thread1"
        t1.IsBackground = True 'Makes it the background thread which will die if the calling thread completes
        t1.Start()
        Console.ReadKey()
    End Sub

    Private Sub SimpleOperation()
        For index = 1 To 5 '10
            Console.WriteLine($"Simple Beep #{index}")
            Thread.Sleep(1000)
        Next
    End Sub
End Module
