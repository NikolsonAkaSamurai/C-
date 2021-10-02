using System;

namespace Дз_Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double value1, value2, result;


                //for words
                try
                {
                    Console.WriteLine("Введите первое число");
                    value1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    value2 = double.Parse(Console.ReadLine());
                }

                catch(Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число");
                    Console.ReadLine();
                    continue;
                }

                //Read task
                Console.WriteLine("Выберите математическую операцию:\n(+) (-) (*) (/)");
                string operation = Console.ReadLine();
                 
                //Operations
                switch (operation)
                {
                    case "+":
                        result = Math.Round(value1 + value2, 3);
                        Console.WriteLine($"Ваш результат: {result}");
                        break;
                    case "-":
                        result = Math.Round(value1 - value2, 3);
                        Console.WriteLine($"Ваш результат: {result}");
                        break;
                    case "*":
                        result = Math.Round(value1 * value2, 3);
                        Console.WriteLine($"Ваш результат: {result}");
                        break;
                    case "/":
                        result = Math.Round(value1 / value2, 3);
                        Console.WriteLine($"Ваш результат: {result}");
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция");
                        break;
                }

                Console.ReadKey();
            }
            
        }
    }
}
