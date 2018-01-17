using System;


namespace task29
{
    enum Food { fish = 25, milk = 15, meat = 20, bread = 10 }; // объявление перечисления 

    public class Cat
    {
        int LevelHungry { get; set; }

        public Cat(int levelHungry)
        {
            LevelHungry = levelHungry;
        }

        public Cat()
        {
        }

        public void Eat()
        {
            Console.WriteLine("Enter the number than feed cat:" + "\r\n" + "1 - fish" + "\r\n" + "2 - milk" + "\r\n" + "3 - meat" + "\r\n" + "4 - bread");
            do
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {

                    case 1:
                        LevelHungry += (int)Food.fish;
                        Console.WriteLine("Satiety : " + LevelHungry + " of 100");
                        break;
                    case 2:
                        LevelHungry += (int)Food.meat;
                        Console.WriteLine("Satiety : " + LevelHungry + " of 100");
                        break;
                    case 3:
                        LevelHungry += (int)Food.milk;
                        Console.WriteLine("Satiety : " + LevelHungry + " of 100");
                        break;
                    case 4:
                        LevelHungry += (int)Food.bread;
                        Console.WriteLine("Satiety : " + LevelHungry + " of 100");
                        break;
                }

            }
            while (LevelHungry < 100);
            Console.WriteLine("Level satiety cаt 100. Cat don't hungry");
        }
    }

    class task29
    {
        static void Main()
        {
            Cat myCat = new Cat();
            myCat.Eat();
            Console.ReadKey();
        }
    }
}