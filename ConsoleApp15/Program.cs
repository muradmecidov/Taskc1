using ConsoleApp15.Models;
using System.Text.Json;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Task 1
            //string path = @"C:\Users\murad\Desktop\Models\Data";
            string path1 = @"C:\Users\murad\Desktop\Models\Data\jsonData.json";

            //Directory.CreateDirectory(path);



            //if (!File.Exists(path1)) 
            //{
            //    File.Create(path1);

            //}
            //else
            //{
            //    Console.WriteLine("Movcuddur");
            //}
            //string text = "";

            //using (StreamReader stream = new StreamReader(path1))
            //{
            //    text = stream.ReadToEnd();
            //}
            //using (StreamWriter stream = new StreamWriter(path1))
            //{
            //    stream.WriteLine(text);
            //    stream.WriteLine("salam dostlar");

            //} 
            #endregion













            //Task2 



            string jsonurl = "https://jsonplaceholder.typicode.com/posts";

            HttpClient url = new HttpClient();
            string json = url.GetStringAsync(jsonurl).Result;
            List<Post> posts = JsonSerializer.Deserialize<List<Post>>(json);

            Console.WriteLine(posts[0].Body);



        }
    }
}