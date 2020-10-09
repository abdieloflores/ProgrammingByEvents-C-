using System;

namespace Practica_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador;
            string amigo, amigos = "", amigoss = "";
            for (contador=1;contador<20;contador++) {
                Console.WriteLine(contador);
            }
            while (contador>1) {
                contador--;
                Console.WriteLine(contador);
            }
            do {
                contador++;
                Console.WriteLine(contador);
            } while (contador<20);

            //-----------------
            do {
                Console.WriteLine("Escribe el nombre de un amigo: ");
                amigo = Console.ReadLine();
                contador += amigo.Length;
                amigoss = amigos + " " + amigo;
                amigos = amigoss;

            } while (contador<20);
            Console.WriteLine(amigos+" Con "+contador+" caracteres ");
            Console.ReadLine();
        }
    }
}
