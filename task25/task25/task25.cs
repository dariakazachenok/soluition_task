using System;

namespace task25
{
    class Money
    {

        public int Amount { get; set; }
        public string Unit { get; set; }

        public Money(int Amount, string Unit)
        {
            this.Amount = Amount;
            this.Unit = Unit;
        }

        public static Money operator +(Money a, Money b)
        {
            if (a.Unit != b.Unit)
            {
                Console.WriteLine("Разный тип валют.\nКовертацыя {0} {2} в {1}", b.Amount, a.Unit, b.Unit);
                b.Amount = Konvert(b.Amount, a.Unit, b.Unit);
                return new Money(a.Amount + b.Amount, a.Unit);

            }

            return new Money(a.Amount + b.Amount, a.Unit);

        }
        public static int Konvert(int amount, string aUnit, string bUnit)
        {
            Console.WriteLine("Введите курс {0} к {1}", bUnit, aUnit);
            Console.Write("1 {0} в {1} = ", bUnit, aUnit);
            int cuorse = Convert.ToInt32(Console.ReadLine());
            int Result = amount * cuorse;
            return Result;
        }

    }

    class task25
    {
        static void Main(string[] args)
        {
            Money myMoney = new Money(23, "BYN");
            Money youMoney = new Money(30, "USD");
            Money sum = myMoney + youMoney;
            Console.WriteLine("Result : " + sum.Amount + " " + sum.Unit);
            Console.ReadKey();
        }
    }
}
