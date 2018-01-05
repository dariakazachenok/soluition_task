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
            int a = 5;
            int b = 7;
            double c, c1, s;

            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            c1 = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(90 * Math.PI / 180));
            s = 0.5 * a * b;
            Console.WriteLine("площадь треугольника: " + s);
            Console.WriteLine("гипотенуза по теореме пифагора: " + c);

            Console.WriteLine("гипотенуза по теореме синусов: " + c1);
            Console.ReadKey();

        }
    }
}

