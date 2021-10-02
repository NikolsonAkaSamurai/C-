using System;

namespace _44ЗубачатыеМассивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] myArray = new int[3][];
            myArray[0] = new int[5];
            myArray[1] = new int[2];
            myArray[2] = new int[10];

            Random random = new Random();

            for (int y = 0; y < myArray.Length; y++)
            {
                for (int x = 0; x < myArray[y].Length; x++)
                {
                    myArray[y][x] = random.Next(99);
                }
                Console.WriteLine("");
            }


            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write (myArray[i][j]+" ");
                }
                Console.WriteLine("");
            }

        }
    }
}
