using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public static void ReplaceNumber(int[] numbers, int number, int newNumber)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                    numbers[i] = newNumber;
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 13, 16, 25, 30, 41 };
            ReplaceNumber(numbers, 6, -6);
            ReplaceNumber(numbers, 16, -16);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
                Console.ReadKey();
            }
        }

    }
}
