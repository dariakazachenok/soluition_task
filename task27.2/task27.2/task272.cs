using System;
using System.Text.RegularExpressions;


namespace task27._2
{
    class task272
    {
        static void Main(string[] args)
        {

            // Создаём фильтр мата 
            // Метод работает со строкой и заменяет мат на цензура
            // Данные для проверки берутся из массива.  

            string Text = "всё ЛиСтики. ЦвеТочки всё!"; // Текст для теста
            string replaceWord = "Цензура"; // слово для замены
            Regex regBadWord; // регулярное выражение
            string[] badWords = { "листики", "цветочки" }; // массив плохих слов, корни

            foreach (string element in badWords) // Перебираем массив плохих слов
            {
                // создаём объект регулярного выражения, который игнорирует регистр
               
                regBadWord = new Regex("[а-я]*" + element + "[а-я]*", RegexOptions.IgnoreCase);
                // заменяем данные и записываем в переменную
                Text = regBadWord.Replace(Text, replaceWord);

            }
            Console.WriteLine(Text);
            Console.ReadKey();

        }
    }
}
