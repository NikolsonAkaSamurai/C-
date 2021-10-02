using System;

namespace ДвумерныйМассив
{

    // Двумерные массивы
    class Program
    {
        static void Main(string[] args)
        {
            // тип_данных [,] имя_массива;

            int[,] myArray = new int[,]
            {
                {2,45,12,51,51 },
                {6,7,8,3,1 },
                {1,5,65,78,13 },
                {6,3,151,5,65 }
            };

            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write($"{myArray[y,x]} ");
                }
                Console.WriteLine(" ");
            }

            

        }
    }
}
