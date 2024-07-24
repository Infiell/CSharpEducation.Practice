using System;

namespace Task4
{
    class Program
    {
        static string firstString;
        static string secondString;
        static void Main(string[] args)
        {
            Console.Write("Введите первое слово: ");
            firstString = Console.ReadLine();
            Console.Write("Введите второе слово: ");
            secondString = Console.ReadLine();
            Console.WriteLine($"{firstString} {secondString}");
        }
    }
}
