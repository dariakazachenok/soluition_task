using System;
using System.Text.RegularExpressions;

namespace task27
{
    class task27
    {
        static void Main(string[] args)
        {
            Regex myReg = new Regex(@"[A-Za-z0-9]");
            Regex oneReg = new Regex(@"[^0-9]");

            string login;
            bool log = false;
            do
            {
                Console.WriteLine("Введите логин от 2 до 10 символов, начинающийся с буквы");
                login = Convert.ToString(Console.ReadLine());
                if (myReg.IsMatch(login) == false)
                {
                    Console.WriteLine("Логин должен содержать только буквы и цифры");
                }
                else if (login.Length < 2 || login.Length > 10)
                {
                    Console.WriteLine("Логин должен содержать от 2 до 10 символов");
                    Console.WriteLine("Ваш логин содержит " + login.Length + " символов");
                }
                else if (oneReg.IsMatch(login.Substring(0, 1)) == false)
                {
                    Console.WriteLine("Логин должен начинаться с буквы");
                }
                else
                {
                    Console.WriteLine("Логин введен верно");
                    log = true;
                }
            }
            while (log == false);
            Console.ReadKey();
        }
    }
}