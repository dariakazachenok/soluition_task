using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace task34
{
    class Task34
    {
        private static void Main()
        {

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://mycsharp.ru");
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string html = reader.ReadToEnd();
            MatchCollection matches = Regex.Matches(html, "<h2>.*?</h2>", RegexOptions.Singleline);
            foreach (Match element in matches)
            {
                var header = Regex.Replace(element.Value, "<.*?>", "");
                Console.WriteLine(header);
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
