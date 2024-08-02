using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Chose();
        }
        static public void Chose()
        {
            Console.WriteLine("Привет. Что бы ты хотел вычислить?");
            Console.WriteLine("1 - Известны два катета - найти гипотенузу");
            Console.WriteLine("2 - Известен один катет и гипотенуза - найти второй катет");
            string numberChose = Console.ReadLine();
            if (numberChose == "1") {
                Hypetenuse();
            }
            else if (numberChose == "2") {
                TheCatether();
            } else Console.WriteLine("Необходимо ввести 1 или 2");
        }
        static private void Hypetenuse()
        {
            int a = 15;
            int b = 12;
            double hypetenuseResult = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"Гепотенуза равна {hypetenuseResult}");
        }
        static private void TheCatether()
        {
            int a = 50;
            int b = 20;
            double theCatetherResult = Math.Sqrt(Math.Pow(a, 2) - Math.Pow(b, 2));
            Console.WriteLine($"Второй катет равен {theCatetherResult}");
        }
    }
}
