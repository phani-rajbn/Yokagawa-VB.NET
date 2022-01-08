Imports System.Timers ' FOr the timer clock
Imports System.IO
Public Class MySampleService
    Private folderName As String = "D:\Data"
    Protected Shared WithEvents timer As Timer
    Protected WithEvents watcher As New FileSystemWatcher(folderName)
    Protected Overrides Sub OnStart(ByVal args() As String)
        'Or is equivalent to | in Java/C#
        watcher.NotifyFilter = NotifyFilters.CreationTime Or NotifyFilters.FileName Or NotifyFilters.DirectoryName Or NotifyFilters.LastAccess
        watcher.Filter = "*.*" 'Handle any changes for any file or folder within the parent directory. 
        watcher.IncludeSubdirectories = True
        watcher.EnableRaisingEvents = True
        timer = New Timer(10000) 'Set the interval to 10 Seconds..
        timer.Enabled = True ' Make the Timer work when the service begins. 
    End Sub
    Protected Overrides Sub OnStop()
        timer.Enabled = False ' Make the Timer stop if the service stops. 
    End Sub
    'Elapsed is the event that triggers when the interval is completed. 
    Private Shared Sub timer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles timer.Elapsed
        LogMessage("User defined message")
    End Sub
    Private Shared Sub LogMessage(msg As String)
        Dim macName = System.Diagnostics.Process.GetCurrentProcess().MachineName
        Dim myLog As New EventLog("SampleService", macName, "YokagawaApps") 'Create a new Event Log.
        Try
            myLog.WriteEntry($"{msg} message was logged at {CStr(TimeOfDay)}", EventLogEntryType.Information)
        Catch myEx As Exception
            myLog.WriteEntry($"{myEx.Message} logged at {CStr(TimeOfDay)}", EventLogEntryType.Error)
        End Try
    End Sub
    Private Sub watcher_Created(sender As Object, e As FileSystemEventArgs) Handles watcher.Created
        If e.ChangeType = WatcherChangeTypes.Created Then
            LogMessage($"{e.Name} was created at {CStr(TimeOfDay)}")
        End If
    End Sub

    Private Sub watcher_Changed(sender As Object, e As FileSystemEventArgs) Handles watcher.Changed
        LogMessage($"{e.Name} was changed at {CStr(TimeOfDay)}")
    End Sub
End Class
'After building the project and the installer support U should open the VS Command Prompt. 
'InstallUtil followed by the FullPath of the Service EXE to install the Service
'InstallUtil followed by the -u FullPath of the Service EXE to uninstall the Service
'Any changes made and to build the App, U should stop the service and build it. 
'U can reinstall the service after successfull build.

'Service which reads a file when it is created or modified from a certain directory. The file will be a CSV file which contains the data to insert to the database. 
' After reading the file, the data should be inserted to the DB(SQL Server)
'An Event log entry should be made saying the total no of records inserted to the database after the complete operation is done. 