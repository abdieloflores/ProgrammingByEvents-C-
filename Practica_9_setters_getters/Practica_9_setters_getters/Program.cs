using System;

namespace Practica_9_setters_getters
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro nano = new Perro();
            nano.Name = "Nano";
            nano.ColorEyes = "Miel";
            nano.Race = "Chihuahueño";
            nano.Size = "Pequeño";
            nano.Color = "Café";

            nano.show();

            Console.Write("\n\nHERENCIA DE CLASE PERRO A FINO\n\n");
            Fino firulais = new Fino();
            firulais.Name = "Firulais";
            firulais.ColorEyes = "Café";
            firulais.Race = "Dalmata";
            firulais.Size = "Grande";
            firulais.Color = "Manchado";
            firulais.Pedigree = true;
            firulais.Spots = 52;

            firulais.show();

            Console.ReadLine();
        }
    }
}
