using System;

namespace ДомашкаМетоды
{
    class Program
    {
        static void PrintSymbols(int numberSymbols, char symbol)
        {
            for (int i = 0; i < numberSymbols; i++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine("\n==============");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Количесто символов");
            int numberSymbols = int.Parse(Console.ReadLine());

            PrintSymbols(numberSymbols, symbol);

            Console.ReadLine();
        }

        
    }
}
