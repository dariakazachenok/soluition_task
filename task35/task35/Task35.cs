using System;
using System.IO;
using System.Net;
using System.Text;


namespace task35
{
    class Task35
    {
        static void Main(string[] args)
        {

            string uri = "http://mycsharp.ru/post/51/2016_07_28_protokol_http_metod_post_i_kuki_v_si-sharp.html";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);

            // данные для отправки, здесь я изменил значение тектового поля на "http_post"
            string postData = "__EVENTTARGET=&__EVENTARGUMENT=&__VIEWSTATE=%2FwEPDwUJNzg3OTE4NTEzZBgBBR5fX0NvbnRyb2xzUmVxdWlyZVBvc3RCYWNrS2V5X18WBQUjY3RsMDAkTG9naW5WaWV3MSRMb2dpblN0YXR1czEkY3RsMDEFI2N0bDAwJExvZ2luVmlldzEkTG9naW5TdGF0dXMxJGN0bDAzBStjdGwwMCRDb250ZW50UGxhY2VIb2xkZXIxJEJ1dHRvbkFkZE1lc3NhZ2UyBSljdGwwMCRDb250ZW50UGxhY2VIb2xkZXIxJEltYWdlQnV0dG9uQ29kZQUWY3RsMDAkQnV0dG9uQWRkTWVzc2FnZcX2JaIf8IS3DzNtiBAh%2FEs2hodi&__VIEWSTATEGENERATOR=AD7AD114&__EVENTVALIDATION=%2FwEdAAs5NA1pL1gCOBx0k2bA%2BOJPBWceBit8e6%2FTdPqOU5fZbeF5u10kY4z8bQzmOH3HYPfY9Wbgx5wbmQnu0TIq2KVEMBPtPHD3IbRvk%2ByxeYb24wz%2F%2FswWW9Bijj8L66VLU8XZ%2BZJwSnD0h6b%2FvE2D3PPKxiJES0DEX6bfdLMW9tej7mlHPn5cMzWaJidgY%2FaB5w8fNNzJQwXQE28z1YB3DF6sToTWYbm21jBEozz8d3mJig%2FMxqmfvCWVCjjwPKwBSnAj7RZ8&ctl00%24ContentPlaceHolder1%24email2=%D1%82%D0%B2%D0%BE%D0%B9+e-mail&ctl00%24ContentPlaceHolder1%24TextBoxName=aqualady&ctl00%24ContentPlaceHolder1%24TextBoxEmail=kazachenokd%40mail.ru&ctl00%24ContentPlaceHolder1%24TextBoxMessage=I+did+it.&ctl00%24ContentPlaceHolder1%24ButtonAddMessage=%D0%94%D0%BE%D0%B1%D0%B0%D0%B2%D0%B8%D1%82%D1%8C&ctl00%24email=%D1%82%D0%B2%D0%BE%D0%B9+e-mail";

            // конвертируем строку в массив байтов
            byte[] data = Encoding.UTF8.GetBytes(postData);
            // указываем метод запроса POST
            request.Method = "POST";
            // для POST запроса необходимо указать тип передаваемых данных и размер
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;
            // записываем в поток запроса данные
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);

            Console.WriteLine(reader.ReadToEnd()); // получаем ответ от сервера - страничка с текстом "HTTP_POST"
            reader.Close();
            Console.ReadLine();

        }
    }
}
