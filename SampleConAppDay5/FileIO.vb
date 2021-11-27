Imports System.IO
Imports System.Configuration
'Text based and Binary data.
'Text based will be based on strings
'Binary data could be anything including images, audio-video files and other kinds. 
'System.IO is the namespace required for accessing APIs for File IO operations.
Module FileIO
    Dim csvFile As String = ConfigurationManager.AppSettings.Get("csvFile")
    'Dim fileName As String = ConfigurationManager.AppSettings.Get("fileToRead")
    Dim filename = "D:\Trainings\Yokogawa\VBTraining\SampleConAppDay5\FileIO.vb"
    Sub Main()
        'simpleFileReading()
        readingCSVFile()
        Console.ReadKey()
    End Sub

    Private Sub readingCSVFile()
        Dim allLines = File.ReadAllLines(csvFile) 'Gets all the lines of the CSV file.
        For Each line In allLines
            'Split each line based on , 
            Dim words = line.Split(",")
            Console.WriteLine($"Name:{words(1)} from {words(2)}") 'Name of the employee to read...
        Next
    End Sub

    ''' <summary>
    ''' Function Example to read the contents of the Text file as it is.
    ''' </summary>
    Private Sub simpleFileReading()
        If File.Exists(filename) Then
            Dim contents = File.ReadAllText(filename)
            Console.WriteLine(contents)
        Else
            MsgBox("This file does not exist")
        End If
    End Sub
End Module
