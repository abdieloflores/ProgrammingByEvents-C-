using System;

namespace Practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            bool x1 = true, xx, yy;
            string a1 ="", b1="";
            while (x1 == true)
            {
                Console.Clear();

                Console.Write("Escribe un número: ");
                a1 = Console.ReadLine();
                Console.Write("Escribe otro número: ");
                b1 = Console.ReadLine();
                xx = double.TryParse(a1, out a); //Valida si el valor es un numerico
                yy = double.TryParse(b1, out b);
                if ((xx == true) && (yy == true)) x1 = false;
                Console.WriteLine("El resultado de {0} + {1} = {2}", a, b, (a+b));
            }
            Console.Read();
        }
    }
}
