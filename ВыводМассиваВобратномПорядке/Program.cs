using System;

namespace ВыводМассиваВобратномПорядке
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Количество элементов?");

            int elementCount = int.Parse(Console.ReadLine());

            int[] myArray = new int [elementCount];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент массива {i}\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }




            // непосредстенно вывод массива
            Console.WriteLine("\nВывод массива:");

            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.ReadLine();
        }
    }
}
