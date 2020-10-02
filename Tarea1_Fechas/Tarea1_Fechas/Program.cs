using System;
using System.Linq.Expressions;

namespace Tarea1_Fechas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            while (a)
            {
                int day = 0, month = 0, year = 0;
                string strDay, strMonth, strYear;
                bool control = true;
                while (control)
                {
                    try
                    {
                        bool control2 = true;

                        while (control2)
                        {
                            try
                            {
                                Console.Clear();
                                day = 0; month = 0; year = 0;
                                Console.Write("NOMBRE DEL DÍA DE LA FECHA INGRESADA\n\n");
                                Console.Write("Ingrese el día: ");
                                strDay = Console.ReadLine();
                                Console.Write("Ingrese el número de mes:");
                                strMonth = Console.ReadLine();
                                Console.Write("Ingrese el año a 4 digitos: ");
                                strYear = Console.ReadLine();
                                day = Convert.ToInt32(strDay);
                                month = Convert.ToInt32(strMonth);
                                year = Convert.ToInt32(strYear) < 1000 ? Convert.ToInt32("") : Convert.ToInt32(strYear);

                                control2 = false;
                            }

                            catch (FormatException)
                            {
                                Console.Clear();
                                Console.WriteLine("\n¡ERROR!\n");
                                Console.WriteLine("El formato de los datos ingresado es erroneo");
                                Console.WriteLine("\nPresiona cualquier tecla para continuar...\n");
                                Console.ReadLine();
                            }
                        }

                        DateTime dateValue = new DateTime(year, month, day);
                        Console.Clear();
                        Console.WriteLine("\n\nEl {0} de {1} fue \" {2} \"", dateValue.ToString("dd"), dateValue.ToString("Y"), dateValue.ToString("dddd"));
                        Console.WriteLine("\nPresiona cualquier tecla para continuar...\n");
                        Console.ReadLine();
                        control = false;
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.Clear();
                        Console.WriteLine("\n¡ERROR!\n");
                        Console.WriteLine("\nLos datos ingresados están fuera de rango, favor de introducir los datos correctos");
                        Console.WriteLine("\nPresiona cualquier tecla para continuar...\n");
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Console.WriteLine("\n\n¿Desea conocer otro día?\n");
                Console.WriteLine("\n\ns = si , n = no\n");

                a = (Console.ReadLine() == "s" || Console.ReadLine() == "S") ? true : false;
                if (a == false)
                {
                    Console.Clear();
                    Console.WriteLine("\nCERRANDO PROGRAMA\n");
                    Console.WriteLine("\nPresiona cualquier tecla para cerrar...\n");
                    Console.ReadLine();
                }

            }
        }
    }
}
