using System;
// инкременты и дикременты
// постфиксные и префиксные
namespace уроки4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 1;

            Console.WriteLine($"Постфиксный инкремент {a++}");//постфикстный инкремент
            Console.WriteLine($"Префиксный инкремент {++b}");//префиксный дикремент
            Console.ReadLine();

        }
    }
}
