Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Console.WriteLine(vbCrLf + "Was ist Ihre Name?")
        Dim name = Console.ReadLine()
        Dim currentDate = DateTime.Now
        Console.WriteLine($"{vbCrLf}Hello, {name}, on {currentDate:d} at {currentDate:t}")
        Console.Write(vbCrLf + "Press any key to exit.......")
        Console.ReadKey(True)
    End Sub
End Module
