using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15.Models
{
    public class Post
    {
        //string urls = "https://jsonplaceholder.typicode.com/posts";

        //public void GetHttpContent(string url)
        //{
        //    HttpClient httpClient = new HttpClient();
        //foreach (var itme in url)
        //    {
        //        var result = httpClient.GetStringAsync(itme);
        //         list.Add(result);
        //    }
        //}






        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

    }
}
