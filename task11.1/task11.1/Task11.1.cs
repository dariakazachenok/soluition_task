
using System.IO;

namespace Task11_1
{

    public class Task11_1

        {

        static void Main(string[] args)

        {


            FileStream file1 = new FileStream("D:\\numbers.txt", FileMode.Create); //создаем файловый поток
            StreamWriter writer = new StreamWriter(file1); //создаем «потоковый писатель» и связываем его с файловым потоком 


            for (int i = 0; i < 501; i++)
            {
                writer.Write(i + ","); //записываем в файл
            }

            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
        }
    }
}