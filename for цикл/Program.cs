using System;

namespace for_цикл
{
    class Program
    {
        static void Main(string[] args)
        {
            /*отличие for от while:
            переменная видна только внутри цикла*/
            // int i инициализируется 1 раз

            /*
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }*/

            /*int i = 0;// переменную можно объявить вне цикла
            for (; i < 3; i++)//отрабатывает до трех и сохраняет
            {
                Console.WriteLine("for1 " + 1);
                System.Threading.Thread.Sleep(300);
                
            }
            for(; i < 5; i++)// запускает с трех и добивает до 5
            {
                Console.WriteLine("for2 " + 1);
                System.Threading.Thread.Sleep(300);
            }*/

            for (int i = 0, j =5; i < 10 && j > 0; i++, j--)
            {
                Console.WriteLine($"i {i} j {j}");
            }

            Console.ReadLine();

        }
    }
}
