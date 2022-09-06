using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdasDemo
{
    internal class Program
    {
        delegate int Operation(int a, int b);
        static int DoOperation(int a, int b, Operation op)
        {
            return op(a, b);
        }

        static int Suma(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;

            Console.WriteLine($"Suma: {DoOperation(a, b, (x, y) => x + y)}");
            Console.WriteLine($"Mult: {DoOperation(a, b, (x, y) => x * y)}");
            Console.WriteLine($"Mult: {DoOperation(a, b, (x, y) => x * x + y + y)}");

            //Console.WriteLine($"Suma: {DoOperation(a, b, Suma)}");

        }
    }
}
