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


            int[] numbers = { 4, 7, 13, 20, 33, 23, 54 };



            foreach (int number in numbers)
            {
                if (number > 20 && number < 50)

                {
                    Console.WriteLine("Числа больше 20 и меньше 50: " + number);
                    Console.ReadKey();
                }
            }
        }
    }
}
