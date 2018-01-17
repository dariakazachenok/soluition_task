using System;
using System.Collections.Generic;

namespace task28
{
    class task28
    {
        static void Main()
        {
           List<DateTime> dates = new List<DateTime>();
            dates.Add(new DateTime(2014, 6, 30, 9, 31, 0));
            dates.Add(new DateTime(2014, 6, 30, 10, 31, 0));
            dates.Add(new DateTime(2014, 6, 30, 11, 31, 0));
            dates.Add(new DateTime(2014, 6, 30, 12, 31, 0));
            dates.Add(new DateTime(2014, 6, 30, 13, 31, 0));
            
            double[] temps = { 26.3, 27.1, 30, 24.7, 25 };

            Console.WriteLine("{0:MMM dd(ddd) h:mm > }" + temps[0] + "°C", dates[0]);
            Console.WriteLine("{0:MMM dd(ddd) h:mm > }" + temps[1] + "°C", dates[1]);
            Console.WriteLine("{0:MMM dd(ddd) h:mm > }" + "{1:f1}" + "°C", dates[2], temps[2]);
            Console.WriteLine("{0:MMM dd(ddd) h:mm > }" + temps[3] + "°C", dates[3] );
            Console.WriteLine("{0:MMM dd(ddd) h:mm > }" + "{1:f1}" + "°C", dates[4], temps[4]);
            Console.ReadLine();
        }
    }
}
