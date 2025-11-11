using System;

namespace Practica6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значения параметра x = ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);

            double F = 5 * Math.Sin(x) - 7 * Math.Cos(x);
        }
    }
}