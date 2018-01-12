using System;
using System.Collections.Generic;


namespace task23
{
    class Name
    {
        public void name(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (i < names.Length - 1)
                    Console.Write(names[i] + ", ");
                else
                    Console.Write(names[i] + "\n");

            }
        }
        public void name(string[] nam, string symbol)
        {
            for (int i = 0; i < nam.Length; i++)
            {
                if (i < nam.Length - 1)
                    Console.Write(nam[i] + symbol + " ");
                else
                    Console.Write(nam[i] + "\n");
            }
        }
    }


    class task23
    {
        public static void Main(string[] args)
        {
            string[] array = { "John", "Oleg", "Alex" };
            Name N = new Name();
            N.name(array);
            Console.WriteLine("Введдите символ, которым хотите заменить запятую");
            string a = Convert.ToString(Console.ReadLine());
            N.name(array, a);
            Console.ReadKey();
        }
    }
}
