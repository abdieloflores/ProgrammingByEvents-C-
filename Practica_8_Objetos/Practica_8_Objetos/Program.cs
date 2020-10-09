using System;

namespace Practica_8_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando clase Gato

            Gato chimuelo = new Gato("Chimuelo","Amarillo","Normales","Miel");
            Gato tonchi = new Gato("Tonchi", "Negro", "Normales", "Miel");

            chimuelo.show();
            tonchi.show();

            Console.ReadLine();
        }
    }
}
