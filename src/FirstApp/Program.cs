using System;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Tabla de equivalencias de celsius a fahrenheit");
Console.WriteLine("Celsius\tFahrenheit");
for(int i = 100;i >= 0;i-=5)
{
	Console.WriteLine($"{i}\t{CelsiusToFahr(i)}");
}
Console.WriteLine("Presione una tecla para continuar");
Console.Read();

static double CelsiusToFahr(int i)
{
	return 1.8 * i + 32.0;
}
