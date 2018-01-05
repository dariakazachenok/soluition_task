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

            for (int i = 1; i <= 60; i += 3) //выполнится 20 раз
            {
                Console.WriteLine(i);
                Console.ReadKey();
            }

        }
    }
}

