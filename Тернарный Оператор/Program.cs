using System;

namespace Тернарный_Оператор
{
    class Program
    {
        static void Main(string[] args)
        {
            bool accessAllowed;

            string storedPassword = "qwerty";
            Console.WriteLine("Введите пароль");
            string enteredPassword = Console.ReadLine();
            //переменная1 =(правдивость условия) переменная2 ==(равна) переменная3 ?(если да) выполнить это :( если нет) выполнить это;
            accessAllowed = enteredPassword == storedPassword ? true : false;

            Console.WriteLine(accessAllowed);

            Console.ReadLine();

        }
    }
}
