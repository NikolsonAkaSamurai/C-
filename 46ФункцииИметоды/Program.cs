using System;

namespace _46ФункцииИметоды
{
    class Program
    {   


        static int Sum(int a, int b)
        {
            int result = a + b;

            return result;
        }

        static void PrintResult(int result)
        {
            Console.WriteLine("Результат сложения: "+ result);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int a, b, c;

                Console.WriteLine("Введите первое число");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                b = int.Parse(Console.ReadLine());

                c = Sum(a, b);

                PrintResult(c);

                Console.WriteLine("==============");
                Console.WriteLine("Нажмите любую клавишу для завершения");

                Console.ReadKey();
            }

           

            
        }
    }
}
