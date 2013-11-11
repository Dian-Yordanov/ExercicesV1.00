using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for(int i=0; i<inp.Length; i++) sb.Append(inp[inp.Length-i-1]);

            string out2 = sb.ToString();
            Console.WriteLine(out2);

        }
    }
}
