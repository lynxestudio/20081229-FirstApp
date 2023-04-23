using System;

namespace blog.listings{
    public class ProgramCS {
        static void Main(string[] args) {
            Console.WriteLine("Tabla de equivalencias de celsius a fahrenheit");
            Console.WriteLine("Celsius\tFahrenheit");
            for (int i = 50; i >= 0; i-=5){
                Console.WriteLine(" {0} \t {1} ",i,CelsiusToFahr(i));
            }
            Console.WriteLine("Presiona una tecla para continuar");
            Console.Read();
        }

        static double CelsiusToFahr(int cg){
            return 1.8 * cg + 32.0;
        }
    }
}
