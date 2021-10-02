using System;

namespace Дз_Количество_четных_чисел
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
                uint evenNumberCount = 0;
                uint oddNumberCount = 0;

                int evenNumberSum = 0;
                int oddNumberSum = 0;


            Console.WriteLine("Введите начало диапазона чисел");
                int currentNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Введите конечное диапазона чисел");
                int endNumber = int.Parse(Console.ReadLine());

                while (currentNumber <= endNumber)
                { 
                    if (currentNumber%2 == 0)
                    {
                        evenNumberCount++;
                        evenNumberSum += currentNumber;
                    }
                    else
                    {
                        oddNumberCount++;
                        oddNumberSum += currentNumber;
                    }

                    currentNumber++;
                }
                
                Console.WriteLine($"Четные числа: {evenNumberCount}\nНечетные: {oddNumberCount}");
                Console.WriteLine($"Сумма четных чисел: {evenNumberSum}\nСумма нечетных чисел: {oddNumberSum}");
                Console.ReadKey();
            

        }
        
    }
}
