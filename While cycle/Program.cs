using System;

namespace While_cycle
{
    class Program
    {   // цикл while - 16 урок
        static void Main(string[] args)
        {
            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            while (count <= 10) 
            {
                Console.WriteLine($"{count} Выполняем действие");
                count++;
            }
        }
    }
}   