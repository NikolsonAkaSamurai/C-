using System;

namespace _27._break_и_continue
{
    class Program
    {   
        // break завершает любой цикл и выходит из него
        //continue лишь перепрыгивает вверх в начало цикла, упуская текущую итерацию

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

        }   
    }
}
