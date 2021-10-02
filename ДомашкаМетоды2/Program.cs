using System;

namespace ДомашкаМетоды2
{
    class Program
    {   

        static int SearchIndex(int[] myArray, int Number)
        {

            for (int i = 0; i < myArray.Length; i++)
            {

                if (myArray[i] == Number)
                {
                    return i;
                }

                
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 4, 6, 8, 9, 34, 77, 45 };


            Console.WriteLine("Какое число необходимо найти ?");
            int Number = int.Parse(Console.ReadLine());

            int result = SearchIndex(myArray, Number);

            if(result == -1)
            {
                Console.WriteLine($"Число не найдено");
            }
            else
            {
                Console.WriteLine($"Индекс искомого числа: {result}");
            }

            

            Console.ReadLine();

        }
    }
}
