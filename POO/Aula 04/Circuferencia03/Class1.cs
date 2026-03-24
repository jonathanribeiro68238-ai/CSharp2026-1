using System;
using System.Collections.Generic;
using System.Text;

namespace Circuferencia03
{
    internal static class Calculadora
    {
        //Campos da classe estética
        public static double PI = 3.14;


        //Metodos
        public static double Circuferencia(double raio)
        {
            return 2 * PI * raio;
        }


        public static double Volume(double raio)
        {
            return (4/3) * PI * Math.Pow(raio, 3);
        }
    }
}
