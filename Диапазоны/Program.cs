using System;

namespace Диапазоны
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 4, 5, 6, 7, 8 };

            //int[] myArray2 = myArray[1..4];

            /*Index myIndex = 2;

            Console.WriteLine(myArray[myIndex]);
            Console.WriteLine();
            Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");*/

            Range myRange = 1..4;

            int[] myArray2 = myArray[myRange];

            Console.WriteLine(myArray[myIndex]);
            Console.WriteLine();
            Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");
        }
    }
}
