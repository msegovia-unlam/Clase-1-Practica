
using PW3_2022_1C_Clase_1.Entidades;
using System;

namespace PW3_2022_1C_Clase_1.Bola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte su pregunta");
            Console.WriteLine("Pregunta: ");

            string pregunta = Console.ReadLine();

            Console.WriteLine($"{Bola8.PedirRespuestas(pregunta)}");
            

        }
    }
}
