using System;

namespace Prueba1
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d, e, f;
            a = 10;
            b = 40;
            c = Suma(a, b);
            d = Resta(a, b);
            e = Multi(a, b);
            f = Divi(a, b);
            Console.WriteLine("La suma de {0} + {1} es: {2}", a, b, c);
            Console.WriteLine("La resta de {0} - {1} es: {2}", a, b, d);
            Console.WriteLine("La multiplicación de {0} * {1} es: {2}", a, b, e);
            Console.WriteLine("La división de {0} / {1} es: {2}", a, b, f);
        }
        static float Suma(float a1, float a2){ return a1 + a2; }
        static float Resta(float a1, float a2) { return a1 - a2; }
        static float Multi(float a1, float a2) { return a1 * a2; }
        static float Divi(float a1, float a2) { return a1 / a2; }
    }
}
