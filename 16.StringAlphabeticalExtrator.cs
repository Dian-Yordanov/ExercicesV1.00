using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] strarr = System.IO.File.ReadAllLines("./list.txt");
            Array.Sort<string>(strarr);

            foreach (string a in strarr) Console.WriteLine(a);
        }
    }
}
