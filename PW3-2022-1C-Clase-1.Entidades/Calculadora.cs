using System;

namespace PW3_2022_1C_Clase_1.Entidades
{
    public static class Calculadora
    {
        public static int Sumar(string val1, string val2)
        {
            int int1 = Int32.Parse(val1);
            int int2 = Convert.ToInt32(val2);
            return int1 + int2;
        }
    }
}
