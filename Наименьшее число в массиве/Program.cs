using System;

namespace Наименьшее_число_в_массиве
{
    class Program
    {+
        static void Main(string[] args)
        {
            int[] myArray = { 2, 3, 99, 49, 64, 77, 1, 42, 5 };

            int minValue = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                   minValue = myArray[i];
                }
            }

            Console.WriteLine(minValue);

            Console.ReadLine();
        }
    }
}
