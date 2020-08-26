Option Strict On
Option Explicit On
Option Compare Binary

Module IfStatements

    Sub Main()
        Dim userInput As String
        Dim userNumber As Integer
        Const COMPAREWITH As Integer = 5
        'If 3 > 5 Then
        '    Console.WriteLine("Yep")
        'Else
        '    Console.WriteLine("Nope")
        'End If

        userInput = Console.ReadLine()
        userNumber = CInt(userInput)

        If userNumber > 5 Then
            Console.WriteLine("Biggger than 5")
        ElseIf userNumber < 5 Then
            Console.WriteLine("Smaller than 5")
        ElseIf userNumber = 5 Then
            Console.WriteLine("Equals 5")
        Else
            Console.WriteLine("Invalid Input")
        End If

        Console.ReadLine()


    End Sub

End Module
