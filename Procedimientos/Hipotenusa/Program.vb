Imports System
Imports System.Math
Module Program
    Sub Main(args As String())
        Dim LadoA, LadoB As UInt16

        Console.WriteLine("Ingrese los valores de los lados A; B: ")
        LadoA = Console.ReadLine()
        LadoB = Console.ReadLine()
        Console.WriteLine("Valor del lado C: " & CalculoC(LadoA, LadoB))

    End Sub
    Function CalculoC(a As UInt16, b As UInt16) As UInt16
        Return Sqrt((a ^ 2) + (b ^ 2))
    End Function
End Module