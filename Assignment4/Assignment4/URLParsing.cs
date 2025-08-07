using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal static class URLParsing
    {
        public static void ParseURL()
        {
            Console.WriteLine("Enter URL: ");
            string url = Console.ReadLine();
            string[] urlArr = null;
            string protocol = null, server = null, resource = null;
            if (url.Contains("://"))
            {
                urlArr = url.Split("://");
                //Console.WriteLine("[protocol] = \"" + urlArr[0] + "\"");
                protocol = urlArr[0];
                url = urlArr[1];
            }
            if (url.Contains("/"))
            {
                urlArr = url.Split("/");
                server = urlArr[0];
                resource = urlArr[1];
                //Console.WriteLine("[server] = " + urlArr[0]);
                //url = urlArr[1];
            }
            else
                server = url;

            Console.WriteLine("[protocol] = \"" + protocol + "\"");
            Console.WriteLine("[server] = \"" + server + "\"");
            Console.WriteLine("[resource] = \"" + resource + "\"");

        }
    }
}
