using System;
namespace ConsoleApp1
    {
        class Program
        {
            static void Main(string[] args)
            {
            // Способы создания экземпляра типа string
            string i;
            Console.WriteLine("Введите имя:");
            i = Convert.ToString(Console.ReadLine());
            if (i=="Вячеслав") 
                {
                Console.WriteLine("Привет, Вячеслав");
            }
            else
                Console.WriteLine("Нет такого имени");

                
                Console.ReadKey();
            }
        }
    }

    

