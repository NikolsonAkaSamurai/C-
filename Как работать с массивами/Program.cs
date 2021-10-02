using System;
using System.Linq;

namespace Как_работать_с_массивами
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 56, 45, 17, 34, 66 };

            int[] result = Array.FindAll(myArray, i => i < 50);

            //Console.WriteLine(myArray.Sum());
            //Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());
            //Array.Find(myArray, i => i < 50);
            //Array.Sort(myArray);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadLine();
        }
    }
}
