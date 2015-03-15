using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace WebRequestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WebRequest req = WebRequest.Create("http://www.microsoft.com");
            WebResponse resp = req.GetResponse();
            StreamReader reader = new StreamReader(resp.GetResponseStream(),Encoding.ASCII);
            //Console.WriteLine(reader.ReadToEnd());

            File.WriteAllText(Directory.GetCurrentDirectory()+"\\example.html",reader.ReadToEnd());

            Console.WriteLine(Directory.GetCurrentDirectory());

            Console.ReadLine();
        }
    }
}
