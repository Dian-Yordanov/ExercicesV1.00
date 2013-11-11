using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++) if((i+1)%3!=0 && (i+1)%7!=0) Console.WriteLine(i+1);
        }
    }