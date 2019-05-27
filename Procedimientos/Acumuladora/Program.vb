Imports System

Module Program
    Sub Main(args As String())
        Dim Valor1, Valor2, Valor3 As Single
        Valor1 = 1.5
        Valor2 = 2.5
        Valor3 = 3.5
        Console.WriteLine("Primer valor : {0}", Valor1)
        Acumular(Valor1)
        Console.WriteLine("Segundo valor: {0}", Valor2)
        Acumular(Valor2)
        Console.WriteLine("Tercer valor: {0}", Valor3)
        Acumular(Valor3)
    End Sub
    Private Sub Acumular(ByVal Valor As Single)
        Dim acumular As Single
        acumular = Valor + Valor
        Console.WriteLine("Valor acumulado: {0}", acumular)
    End Sub
End Module
