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
            string s = "Login1,LOgin2,login3,loGin4";
            string[] array = s.Split(',');
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i].ToLower());
                Console.ReadKey();
            }

        }

    }
}
