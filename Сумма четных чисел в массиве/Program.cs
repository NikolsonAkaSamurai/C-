using System;

namespace Сумма_четных_чисел_в_массиве
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 2, 3, 99, 49, 64, 77, 4, 42, 5 };

            int result = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    result += myArray[i];
                }
            }

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
