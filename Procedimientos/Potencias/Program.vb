Imports System

Module Program
    Sub Main(args As String())
        Dim Numero As UInt16
        Console.WriteLine("Ingrese un numero: ")
        Numero = Console.ReadLine()
        Console.WriteLine("Numero elevado 2°; 3°, 5° :" & Potencia(Numero))
    End Sub
    Function Potencia(num As UInt16) As String
        Dim calculo2, calculo3, calculo5 As Int32
        calculo2 = num ^ 2
        calculo3 = num ^ 3
        calculo5 = num ^ 5

        Return (calculo2 & " " & calculo3 & " " & calculo5)
    End Function
End Module
