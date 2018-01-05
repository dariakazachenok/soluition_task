using System;


namespace Rextester
{
    class Auto
    {
        private string skorost;
        public string color;
        public int year;

    }
    public class Program
    {
        public void Main(string[] args)
        {
            Auto bmw = new Auto(); //создание объекта bmw класса Auto
            Auto infiniti = new Auto();

            bmw.year = 2011;
            infiniti.year = 2012;

            Console.WriteLine(bmw.year); // выводит на экран 
            Console.WriteLine(infiniti.year);


            bmw.color = "RED";
            infiniti.color = "Black";


            Console.WriteLine(bmw.color); // выводит на экран 
            Console.Write(infiniti.color);

        }
    }
}
