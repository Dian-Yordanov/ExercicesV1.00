using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Net;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            try
            {
                wc.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "./img.jpg");
            }
            catch (System.Net.WebException) { Console.WriteLine("coulld not download file.\n"); }
            catch (System.NotSupportedException) { Console.WriteLine("download is unsupported.\n"); }
            wc = null;
        }
    }
}
