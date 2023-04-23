Imports System
Namespace blog.listings
    Public Class ProgramVB
        Shared Sub Main()
            Console.WriteLine("Tabla de equivalencias de celsius a fahrenheit")
            Console.WriteLine("Celsius{0}Fahrenheit",ControlChars.Tab)
            For i As Integer = 100 To 0 Step -5
                Console.WriteLine(" {0} {1} {2} ", i, ControlChars.Tab, CelsiusToFahr(i))
            Next
            Console.WriteLine("Presiona una tecla para continuar")
            Console.Read()
        End Sub

        Shared Function CelsiusToFahr(ByVal cg As Integer) As Double
            Return 1.8 * cg + 32.0
        End Function
    End Class
End Namespace

