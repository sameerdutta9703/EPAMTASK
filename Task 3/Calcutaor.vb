Imports System

Class Calculator
    Public Shared Sub Main(ByVal args As String())
        Dim firstNum, secondNum As Integer
        Dim operation As String
        Console.WriteLine("Enter the first number")
        firstNum = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the second number")
        secondNum = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Enter the operator to perform the specified operation")
        Console.WriteLine("The operators should be among +, -, *, /")
        operation = Console.ReadLine()

        If opetation = "+" Then
            Console.WriteLine(firstNum & " + " & secondNum & "  = " & (firstNum + secondNum))
            Console.ReadLine()
        ElseIf opetation = "-" Then
            Console.WriteLine(firstNum & " - " & secondNum & "  = " & (firstNum - secondNum))
            Console.ReadLine()
        ElseIf opetation = "*" Then
            Console.WriteLine(firstNum & " * " & secondNum & "  = " & (firstNum * secondNum))
            Console.ReadLine()
        ElseIf opetation = "/" Then
            Console.WriteLine(firstNum & " / " & secondNum & "  = " & (firstNum / secondNum))
            Console.ReadLine()
        End If
    End Sub
End Class
