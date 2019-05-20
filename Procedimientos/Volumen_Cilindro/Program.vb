Imports System
Imports System.Math
Module Program
    Sub Main(args As String())

        Dim Radio, Altura As UInt16
        Console.WriteLine("Ingrese el Radio Y luego la Altura en centímetros : ")
        Radio = Console.ReadLine()
        Altura = Console.ReadLine()
        Console.WriteLine("El volumen del cilindro es : " & CalcularVolumen(Radio, Altura) & "cm3")
    End Sub
    Function CalcularVolumen(r As UInt16, h As UInt16) As Single
        Return (PI * (r) ^ 2 * h)
    End Function
End Module
