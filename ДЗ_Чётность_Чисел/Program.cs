using System;

namespace ДЗ_Чётность_Чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int remainder = number % 2;
            if(remainder == 0)
            {
                Console.WriteLine($"Number {number} is even");
            }
            else
            {
                Console.WriteLine($"Number {number} is not even;");
            }

            Console.ReadLine();
        }   
    }
}
