using System;

namespace Practica_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double dA, dB, dC;
            string sA, sB, sC;
            Console.WriteLine("Escribe un número: ");
            sA = Console.ReadLine();
            Console.WriteLine("Usted escribio {}", sA);
            dA = double.Parse(sA);
            Console.WriteLine("Escribe otro número: ");
            sB = Console.ReadLine();
            Console.WriteLine("Usted escribio {}", sB);
            dB = double.Parse(sB);
            dC = dA + dB;
            sC = Convert.ToString(dC);
            Console.Write("El resultado de la suma de {} + {} = {}", sA, sB, sC);
            

            switch (Convert.ToInt32(dA)) {
                case 1:
                    Console.Write("Uno");
                    break;
                case 2:
                    Console.Write("Dos");
                    break;
                default:
                    Console.Write("Ninguno de los anteriores");
                    break;

            }


        }
    }
}
