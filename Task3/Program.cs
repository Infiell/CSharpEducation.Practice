using System;

namespace Task3
{
    class Program
    {
        static string name;
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine($"Добро пожаловать домой, {name}.");
        }
    }
}
