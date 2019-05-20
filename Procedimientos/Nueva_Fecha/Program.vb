Imports System
Imports System.DateTime

Module Program
    Sub Main(args As String())
        Dim Dias As Date
        Dim SumarDias As UInt16
        Console.WriteLine("Ingrese una fecha y luego los dias a sumar: ")
        Dias = Console.ReadLine()
        SumarDias = Console.ReadLine()
        Console.WriteLine(Fecha(Dias, SumarDias))
    End Sub

    Function Fecha(Dias As Date, AddDias As UInt16) As Date

        Return Dias.AddDays(AddDias)
    End Function
End Module
