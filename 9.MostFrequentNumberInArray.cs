using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{


    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());

        bool sorted = false;
        do{
            sorted = false;
            for (int i = 0; i < n - 1; i++) { if (a[i] < a[i + 1]) { int temp = a[i];
                                        a[i] = a[i+1]; 
                                        a[i+1] = temp;
                                        sorted = true;
            } 
            }

        } while (sorted);

        bool inpoli = false;
        int longestpoli = 1;
        int curpoli = 1;
        int lnum = a[0];
        for (int i = 1; i < n; i++)
        {
            if (inpoli && a[i - 1] == a[i]) curpoli++;
            if (!inpoli && a[i - 1] == a[i]) { inpoli = true; curpoli++; }
            if (a[i - 1] != a[i]) curpoli = 1;
            if (curpoli > longestpoli) { longestpoli = curpoli; lnum = a[i]; }
        }

        Console.WriteLine("{0} ({1} times", lnum, longestpoli);
    }
}