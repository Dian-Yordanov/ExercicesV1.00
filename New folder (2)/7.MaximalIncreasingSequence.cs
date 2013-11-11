//Gaidarov
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program{
    

    static void Main(string[] args)
    {
        
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());

            

            bool inpoli = false;
            int longestpoli = 1;
            int longests=0, longeste=0;
            int curpoli = 1;
            int curs=0;
            int lnum = a[0];
            for (int i = 1; i < n; i++)
            {
                if (inpoli && a[i - 1] < a[i]) curpoli++;
                if (!inpoli && a[i - 1] < a[i]) { inpoli = true; curpoli++; curs = i - 1; }
                if (a[i - 1] >= a[i]) { curpoli = 1; }
                if (curpoli > longestpoli) { longestpoli = curpoli; lnum = a[i]; longests = curs; longeste = i; }
            }

            Console.Write("{");
        for(int i=longests; i<=longeste; i++) {Console.Write(a[i]); if(i!=longeste) Console.Write(','); }
        Console.Write("}");
        }
    }