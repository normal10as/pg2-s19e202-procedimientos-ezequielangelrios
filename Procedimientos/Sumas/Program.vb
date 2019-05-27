Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("Sumar 5+5: " & Sumas(5, 5))
        Console.WriteLine("Sumar 10+10+10: " & Sumas(10, 10, 10))
        Console.WriteLine("Sumar 20+20+20+20: " & Sumas(20, 20, 20, 20))
    End Sub

    Private Function Sumas(Valor1 As UInt16, Valor2 As UInt16) As UInt16
        Return Valor1 + Valor2
    End Function
    Private Function Sumas(Valor1 As UInt16, Valor2 As UInt16, Valor3 As UInt16) As UInt16

        Return Valor1 + Valor2 + Valor3
    End Function
    Private Function Sumas(Valor1 As UInt16, Valor2 As Int16, Valor3 As UInt16, Valor4 As Int16) As UInt16

        Return Valor1 + Valor2 + Valor3 + Valor4
    End Function

End Module
