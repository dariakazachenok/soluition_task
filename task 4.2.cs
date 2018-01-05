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
            int a;
            Console.WriteLine("Введите число:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 3 == 0 && a % 7 == 0)
            {
                Console.WriteLine("Число кратно 3 и 7:" + " " + a);
            }
            else
            {
                Console.WriteLine("Число некратно 3 и 7:" + " " + a);
            }
            Console.ReadKey();

        }
    }
}
