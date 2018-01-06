using System;


namespace task16

{
    public class TV
    {
        public int volumesound; //объявление поля

        public int Volumesound //объявление свойства
        {
            get // аксессор чтения поля
            {
                return volumesound;
            }
            set // аксессор записи в поле
            {
                if (value < 0)
                    volumesound = 0;
                else if (value > 100)
                    volumesound = 100;
                else volumesound = value;
            }
        }
    }
    class task16
    {
        static void Main(string[] args)
        {
            TV tv1 = new TV();
            Console.Write("Введите значение громкости - ");
            tv1.Volumesound = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Значение громкости - " + tv1.Volumesound);

            Console.ReadKey();
        }
    }
}