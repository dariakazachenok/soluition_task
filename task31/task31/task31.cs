using System;

namespace task31
{

    public class People
    {
        string Name { get; set; }
        int? Amount { get; set; }

        public People(string name, int? amount)
        {
            Name = name;
            Amount = amount;
        }

          public void Kids()
    
          {
            string kids;
            if (Amount == null)
            {
                kids = "unknown";
            }
            else if (Amount == 0)
            {
                kids = "no children";
            }
            else
            {
                kids = Amount.ToString();
            }
            Console.WriteLine(Name + "\n Amount of children -" + kids + "\n");
            Console.ReadLine();
          }
    }

    class task31
    {
        static void Main(string[] args)
        {
            People people1 = new People("Alex", 4);
            People people2 = new People("Kate", null);
            People people3 = new People("Stella", 0);
            people1.Kids();
            people2.Kids();
            people3.Kids();
        }   
    }
}