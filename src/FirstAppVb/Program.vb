Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Tabla de equivalencias de Celsius a Fahrenheit")
	Console.WriteLine($"Celsius{ControlChars.Tab}Fahrenheit")
	For i As Integer = 100 to 0 Step -5
		Console.WriteLine($"{i} {ControlChars.Tab}{CelsiusToFahr(i)}")
	Next
	Console.WriteLine("Presiona una tecla para continuar")
	Console.Read()
    End Sub

	Function CelsiusToFahr(ByVal i as integer) as double
   		return 1.8 * i + 32.0
	End function
End Module

