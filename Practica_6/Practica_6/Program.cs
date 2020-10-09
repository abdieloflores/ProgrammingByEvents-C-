using System;

namespace Practica_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int TemperaturaAgua = 150;
            string EstadoDelAgua, temp;
            bool bien = true;
            while (bien)
            {
                Console.Write("Cual es la temperatura del agua (-276 a 276): ");
                temp = Console.ReadLine();
                bien = false;
                try
                {
                    TemperaturaAgua = int.Parse(temp);

                }
                catch (FormatException)
                {
                    Console.WriteLine("Debes escribir un numero");
                    bien = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Debes escribir un numero");
                    bien = true;
                }
                if (!bien)
                {
                    if ((TemperaturaAgua > 276) || (TemperaturaAgua < -276))
                    {
                        Console.WriteLine("La cantidad esta fuera de rango");
                        bien = true;
                    }

                }

            }
            Console.WriteLine("La temperatura del agua es: " + TemperaturaAgua);

            EstadoDelAgua = ((TemperaturaAgua > 90) ? "Gaseosa" : ((TemperaturaAgua < 0) ? "Solida" : "Liquida"));
            Console.WriteLine("El estado del agua esta: " + EstadoDelAgua);
        }
    }
}
