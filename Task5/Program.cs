using System;

namespace Task5
{
    class Program
    {
        static int radius = 45;
        static void Main(string[] args)
        {
            Console.WriteLine($"Площадь круга с радиусом {radius} равна {Math.PI * Math.Pow(radius, 2)}");
        }
    }
}
