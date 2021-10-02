using System;

namespace Логические_Операторы
{   
    /*
        Логические операторы
        && сокращенное И
        || сокращенное ИЛИ
        & И
        | ИЛИ
        ! НЕ (унарный)
    */
    class Program
    {
        static void Main(string[] args)
        {
            int fanSpeen = 3000;
            bool isHighTemperature = true;
            bool hasNoCooling = fanSpeen <= 0;

            if (hasNoCooling && isHighTemperature)
            {
                Console.WriteLine("Опасность перегрева копмьютера!");
            }
            
        }
    }
}
