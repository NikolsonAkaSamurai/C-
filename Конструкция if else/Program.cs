using System;
    // конструкция условного оператора if else
namespace Конструкция_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a == 5)
            {
                Console.WriteLine("a = 5");
            }
            else
            {
                Console.WriteLine("a != 5");
            }
            
        }
    }
}
