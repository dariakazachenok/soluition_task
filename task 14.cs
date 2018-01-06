using System;

namespace task14
{
    class Test1
    {
        public class TV
        {
            int CurrentCh = 0;

            public void NextCh()
            {
                CurrentCh++;
                Console.WriteLine($"Current Channel: {CurrentCh}");
            }

            public void PrevCh()

            {
                CurrentCh--;
                if (CurrentCh < 0)
                    Console.ReadKey();
                Console.WriteLine($"Currect Channel: {CurrentCh}");
            }

            public void NumbCh(int n)
            {

                if (n <= 0)
                {
                    Console.WriteLine("Write Channel>0");
                    Console.ReadKey();
                }
                
                Console.WriteLine($"Current Channel: {CurrentCh = n}");
            }

        }
        private static void Main(string[] args)
        {
            TV myTV = new TV();
            Console.WriteLine("Write Channel");
            while (true)
            {
                
                int func = int.Parse(Console.ReadLine());
                if (func == -0)
                    break;
                if (func == 1)
                    myTV.NextCh();
                else if (func == -1)
                    myTV.PrevCh();
                else
                    myTV.NumbCh(func); 
            }
            Console.ReadKey();
        }
    }
}