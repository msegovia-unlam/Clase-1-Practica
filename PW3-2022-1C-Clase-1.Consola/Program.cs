using System;

namespace PW3_2022_1C_Clase_1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a la calculaddora!");
            Console.WriteLine("Ingrese los numeros a sumar");
            
            Console.WriteLine("Num 1: ");
            string num1 = Console.ReadLine();
            //if (!Int32.TryParse(num1, out int int3))
            //    Console.WriteLine("El numero ingresado es inválido");

            Console.WriteLine("Num 2: ");
            string num2 = Console.ReadLine();

            int int1 = Int32.Parse(num1);
            int int2 = Convert.ToInt32(num2);

            Console.WriteLine($"{int1} + {int2} = {int1 + int2}");
            Console.ReadKey();
        }
    }
}
