using System;
using System.Collections.Generic;


namespace task21
{
    abstract class Man
    {
        public string Name { get; set; }
        public string Say { get; protected set; }

        public abstract void SayHello(); // объявление абстрактного метода
    }


    class Russian : Man
    {

        public Russian(string name)
        {
            Name = name;
            Say = "Привет";
            }

        public override void SayHello() // реализация абстрактного метода

            {
            Console.WriteLine(Name + "\n" + "Russian say: " + Say + "\n");
            }
    }

    class Ukrainian : Man
    {
        public Ukrainian(string name)
        {
            Name = name;
            Say = "Привіт";
        }

        public override void SayHello() // реализация абстрактного метода

        {
            Console.WriteLine(Name + "\n" + "Ukrainian say:" + Say + "\n");
        }
    }

    class American : Man
    {
        public American(string name)
        {
            Name = name;
            Say = "Hi";
        }

        public override void SayHello() // реализация абстрактного метода

        {
            Console.WriteLine(Name + "\n" + "American say: " + Say);
        }
    }
    class task21
    {
        static void Main(string[] args)
        {
            List<Man> mans = new List<Man>();
            mans.Add(new Russian("Петр"));
            mans.Add(new Ukrainian("Ванька"));
            mans.Add(new American("Alex"));

            foreach (Man man in mans)
                man.SayHello();
            Console.ReadKey();
        }
        }
}
