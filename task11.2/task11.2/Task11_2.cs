using System.IO;

namespace Task11_2
{

    public class Task11_2

    {

        static void Main(string[] args)

        {

            string[] arr = { "red", "green", "black", "white", "blue" };

            FileStream colors = new FileStream("D:\\test.txt", FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(colors); //создаем «потоковый писатель» и связываем его с файловым потоком 


            foreach (string color in arr)
            {
                writer.WriteLine(color);
            }
            writer.Close();


            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 


        }
    }
}