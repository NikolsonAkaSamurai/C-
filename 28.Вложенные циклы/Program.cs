using System;

namespace _28.Вложенные_циклы
{
    class Program
    {       //Вложенные циклы
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Введите высоту квадрата");
                int height = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите ширину квадрата");
                int width = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите  символ");
                string symbol = Console.ReadLine();

                for (int j = 0; j < height; j++)
                {
                    for (int i = 0; i < width; i++)
                    {
                        Console.Write(symbol);
                    }

                    Console.WriteLine();
                }

            }

            Console.ReadLine();
        }
    }
}
