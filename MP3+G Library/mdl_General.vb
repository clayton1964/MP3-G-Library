Imports System.IO

Module Module1

    ''' <summary>
    ''' Entry point that shows usage of recursive directory function.
    ''' </summary>
    Sub myfiles()
        ' Get recursive List of all files starting in this directory.
        Dim list As List(Of String) = FileHelper.GetFilesRecursive("C:\Data\IIS")

        ' Loop through and display each path.
        For Each path In list
            Console.WriteLine(path)
        Next

        ' Write total number of paths found.
        Console.WriteLine(list.Count)
    End Sub

End Module
