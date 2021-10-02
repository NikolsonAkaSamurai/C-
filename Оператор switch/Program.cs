using System;

// Условный оператор Switch

namespace Оператор_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Вы ввели число 1");
                    break;
                case 2:
                    Console.WriteLine("Вы ввели чило 2");
                    break;
                default:
                    Console.WriteLine("Я не знаю что делать с этим числом");
                    break;
            }
        }
    }
}
