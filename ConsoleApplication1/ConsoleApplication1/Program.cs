//Gaidarov
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string ins = Console.ReadLine();

        ins = ins.ToUpper();
        string tbf = Console.ReadLine();
        string inso = tbf;
        tbf = tbf.ToUpper();

        int lastoccurance = 0;
        int counter = 0;
        while (lastoccurance + tbf.Length <= ins.Length && (lastoccurance = ins.IndexOf(tbf, lastoccurance + tbf.Length)) != -1) { counter++; }

        Console.WriteLine("found {0} in the text {1} time(s)", inso, counter);
    }
}