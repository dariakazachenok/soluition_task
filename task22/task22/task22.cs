using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task22
{
    interface ISwitchable // объявление интерфейса
    {
        void Switchon();
        void Switchoff();
    }
    class TV : ISwitchable //реализация интерфейса
    {
        public void Switchon()
        {
            Console.WriteLine("TV on");
        }

        public void Switchoff()
        {
            Console.WriteLine("TV off");
        }
    }
    class Computer : ISwitchable //реализация интерфейса
    {
        public void Switchon()
        {
            Console.WriteLine("Computer on");
        }

        public void Switchoff()
        {
            Console.WriteLine("Computer off");
        }
    }
    class task22
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            Computer com = new Computer();

            Console.WriteLine("1- включить телевизор" + "\r\n" + "2- выключить телевизор" + "\r\n" + "3- включить компьютер" + "\r\n" + "4- выключить компьютер");
            while (true)
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                    {
                        tv.Switchon();
                        break;
                    }
                    case 2:
                    {
                        tv.Switchoff();
                        break;
                    }
                    case 3:
                    {
                        com.Switchon();
                        break;
                    }
                    case 4:
                    {
                        com.Switchoff();
                        break;
                    }
                }
            }
        }
    }
}
