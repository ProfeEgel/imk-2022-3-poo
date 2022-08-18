using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace FirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loop = false;
            do
            {
                Clear();
                WriteLine("***************************************************");
                WriteLine("* Programa para resolver la ec. ax^2 + bx + c = 0 *");
                WriteLine("***************************************************");
                WriteLine("Introduce los valores");

                Write("a: ");
                int a = Convert.ToInt32(ReadLine());

                Write("b: ");
                int b = Convert.ToInt32(ReadLine());

                Write("c: ");
                int c = Convert.ToInt32(ReadLine());

                if (a == 0 && b == 0)
                {
                    WriteLine("\n¡NO ES UNA ECUACIÓN VÁLIDA!");
                }
                else if (a == 0 && b != 0)
                {
                    WriteLine("\nEs una ecuación de primer grado");

                    double x = -c / (double)b;
                    WriteLine($"x = {x}");
                }
                else
                {
                    int D = b * b - 4 * a * c;
                    if (D == 0)
                    {
                        WriteLine("\nRaíces reales e iguales");

                        double x = -b / (2.0 * a);
                        WriteLine($"x1 = x2 = {x}");
                    }
                    else if (D > 0)
                    {
                        WriteLine("\nRaíces reales y diferentes");

                        double x1 = (-b + Math.Sqrt(D)) / (2.0 * a);
                        double x2 = (-b - Math.Sqrt(D)) / (2.0 * a);
                        WriteLine($"x1 = {x1}");
                        WriteLine($"x2 = {x2}");
                    }
                    else
                    {
                        WriteLine("\nRaíces complejas conjugadas");

                        double real = -b / (2.0 * a);
                        double imag = Math.Sqrt(-D) / (2.0 * a);
                        WriteLine($"x1 = {real} + {imag} i");
                        WriteLine($"x2 = {real} - {imag} i");
                    }
                }

                Write("\n¿Deseas resolver otra ecuación? [S/N]: ");
                loop = ReadLine().ToUpper()[0] == 'S';
            }
            while (loop);

            WriteLine("\n¡Gracias por utilizar el programa!");
        }
    }
}
