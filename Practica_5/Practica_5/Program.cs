using System;

namespace Practica_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int intNum;
            string strNum;
            bool control = true;

            while (control)
            {
                Console.Clear();
                Console.WriteLine("Escribe un número: ");
                strNum = Console.ReadLine();

                //Convirtiendo string a entero
                try
                {
                    Console.WriteLine("\nIntentando convertir string a numero\n");
                    intNum = int.Parse(strNum);
                    Console.Write("Realizado con éxito");
                    Console.Write("\n\nClick para continuar...");
                    control = false;
                    Console.ReadLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El número ingresado es demasiado grande, vuelve a intentar");
                    Console.Write("\n\nClick para continuar...");
                    Console.ReadLine();

                }
                catch (FormatException)
                {
                    Console.Write("El tipo de dato ingresado no es el indicado, vuelve a intentar");
                    Console.Write("\n\nClick para continuar...");
                    Console.ReadLine();
                }
                finally{
                    Console.WriteLine("\nEsta excepción se va a correr pase lo que pase\n");
                }
            }

            Console.WriteLine("Programa Finalizado con Éxito");
        }
    }
}
