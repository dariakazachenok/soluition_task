using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите количество забитых голов хозяевами:");
            a = Convert.ToInt32(Console.ReadLine()); // вводим данные с клавиатуры*
            Console.WriteLine("Введите количество забитых голов гостями:");
            b = Convert.ToInt32(Console.ReadLine()); // вводим данные с клавиатуры*
            if (a > b) //проверяем число на чётность путем нахождения остатка от деления числа на 2
            {
                Console.WriteLine("Хозяева победили ");
            }
            else if (a < b)
            {
                Console.WriteLine("Гости победили");
            }
            else
            {
                Console.WriteLine("Ничья ");
            }

            Console.ReadKey();

        }
    }
}