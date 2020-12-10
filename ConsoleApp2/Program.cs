using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Введите число:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 7)
            {
                Console.WriteLine("Привет");
            }
            else
            {
                Console.WriteLine("Не правильно введено число");
            }
            Console.ReadKey();
        }
    }
}
