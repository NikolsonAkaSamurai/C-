using System;

namespace Массивы
    //одномерные массивы
    // тип элементов_массива [] имя_массива;

{
    class Program
    {
        static void Main(string[] args)
        {

            /* int[] Array2 = { 4, 7, 8, 4, 6, 2, 9 };

            for (int i = 0; i < Array2.Length; i++)
            {
                Console.WriteLine(Array2[i]);
            }

            //Array2 = Enumerable.Range(4, 10).ToArray();
            //Console.WriteLine(myArray[1]);*/

            Console.Write("количество элементов в массиве?:\t");

            int elementsCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[elementsCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"введите элемент {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Вывод массива");

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }


            


            Console.ReadLine();
        }
    }
}
