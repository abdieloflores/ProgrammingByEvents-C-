using System;

namespace Actividad1
{
    class Program
    {
        const double Pi = 3.1415926535;
        const int semanas = 52, meses = 12;
        const string cumple = "01 Noviembre 1995";

        public static double Suma(double num1, double num2) {
            return num1 + num2;
        }
        public static double Restar(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Dividir(double num1, double num2)
        {
            return num1 / num2;
        }
        public static double Multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public static int SumaTxt(string num1, string num2) {
            return int.Parse(num1) + int.Parse(num2);
        }

        static void Main(string[] args)
        {
            double a = 1005, b = 20, c;
            string nn, num1, num2;
            Console.WriteLine("Mi fecha de cumpleaños es el {0}", cumple);
            c = Suma(a, b);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Este es un mensaje con una variable \nEl valor de a es: {0}",a);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Es es un mensaje con 2 variables \nEl valor de a es {0} y el valor de b es {1}",a,b);
            Console.WriteLine("{0} + {1} = {2}",a,b,c);
            Console.WriteLine("Concatenando las variables a, b y c, el resultado es: "+a.ToString()+b.ToString()+c.ToString());
            Console.WriteLine("Escrba un texto: ");
            nn = Console.ReadLine();
            Console.WriteLine("El texto capturado por consola es: {0}",nn);
            Console.WriteLine("\n\n AHORA VAMOS A SUMAR 2 CADENAS DE TEXTO");
            Console.WriteLine("Escrib el primer número: ");
            num1 = Console.ReadLine();
            Console.WriteLine("Escriba el segundo número: ");
            num2 = Console.ReadLine();
            Console.WriteLine("La suma de {0} y {1} es: {2}", num1, num2, SumaTxt(num1, num2));
            
        }
        
    }
}
