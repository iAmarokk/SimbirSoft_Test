using HtmlAgilityPack;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace SimbirSoft_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Program program = new Program();
            program.Start();
            Console.WriteLine("Press any key to Escape");
            Console.ReadKey();
        }

        public void Start()
        {
            FileWorker fileWorker = new FileWorker();
            HTMLWorker htmlWorker;
            var urldata = fileWorker.ReadFile();
            Console.WriteLine(urldata);
            //htmlWorker = new HTMLWorker(urldata);
            //using (WebClient client = new WebClient())
            //{
            //    string html = client.DownloadString("http://stackoverflow.com");
            //    //Do something with html then
            //    Console.WriteLine(html);
            //}

            //htmlWorker.SaveHTMLPages();

            //HttpClient httpclient = new HttpClient();
            //var result = httpclient.GetStringAsync(new Uri("https://www.microsoft.com/en-sg/"));
            //File.WriteAllText("test.html", result);

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml("https://www.microsoft.com");

            FileStream sw = new FileStream("FileStream.html", FileMode.Create);

            htmlDoc.Save(sw, Encoding.UTF8);
        }
    }
}
