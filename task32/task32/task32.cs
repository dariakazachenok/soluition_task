using System;


namespace task32
{
    //Создаём структуру
    public struct RadiusFinder
    {
        // Метод внутри структуры и принадлежит структуре(static)
        public static void toFindRadius(int[] arrayRadius)
        {
            // Перебираем массив длинн радиусов и вычисляем среднюю длинну радиуса
            int average = 0;
            foreach (int element in arrayRadius)
            {
                average += element;
            }
            average = average / arrayRadius.Length; // Получаем среднюю длинну радиуса

            // Создаём переменную - индекс близости к среднему радиусу. 
            int closeToAverage = (Math.Abs(arrayRadius[0] - average)); // Записываем в переменную индекс близости первого элемента массива 

            // Перебираем массив радиусов. Радиус более близкий к середине(наименьший индекс близости) заносится в переменну position
            int position = 0;// 
            int count = 0; // 
            for (int i = 0; i < arrayRadius.Length; i++)
            {
                if (closeToAverage > Math.Abs(arrayRadius[i] - average))
                {
                    closeToAverage = Math.Abs(arrayRadius[i] - average);
                    position = count;
                }
                count++;
            }
            // выводим сообщение о среднем радиусе и наиболее близком радиусе к среднему
            Console.WriteLine("Наиболее близкий радиус {0} к среднему радиусу {1}", arrayRadius[position], average);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {

            int[] radius = { 100, 20, 13, 80, 30, 40, 300, 2 };

            toFindRadius(radius);
        }
    }
}
