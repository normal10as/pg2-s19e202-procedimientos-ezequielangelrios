Imports System

Module Program
    Sub Main(args As String())
        Dim Valor1, Valor2, Valor3 As Single
        Valor1 = 1.5
        Valor2 = 2.5
        Valor3 = 3.5
        Console.WriteLine("Primer valor :")
        Acumular(Valor1)
        Console.WriteLine("Segundo valor: ")
        Acumular(Valor2)
        Console.WriteLine("Tercer valor: ")
        Acumular(Valor3)
    End Sub
    Sub Acumular(ByVal Valor As Single)
        Dim acumular As Single
        acumular = Valor + Valor
        Console.WriteLine("valor= {0}", acumular)
    End Sub
End Module
