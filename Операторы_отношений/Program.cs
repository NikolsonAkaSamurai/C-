using System;
// Операторы отношение и сравнения
//  == равно
//  != не равно
// > больше
// < меньше
// >= больше или равно
// <= меньше или равно 

namespace Операторы_отношений
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            bool EQ = a == b;
            bool NE = a != b;
            bool GT = a > b;
            bool LT = a < b;
            bool GE = a >= b;
            bool LE = a <= b;


            Console.WriteLine($"a == b {EQ}\na != b {NE}\na > b {GT}\na < b {LT}\na >= b {GE}\na <= b {LE}");
            Console.ReadLine();
        }
    }
}
