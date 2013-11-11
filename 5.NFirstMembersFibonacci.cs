using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program{
    

    static void Main(string[] args)
    {
        int sum = 0;
            int f = int.Parse(Console.ReadLine());

            int pred = 0;
            int pred2 = 1;
            for (int i = 1; i <= f; i++)
            {
                int temp = pred;
                pred = pred + pred2;
                pred2 = temp;
                sum += pred2;
                //Console.WriteLine("{0}", pred2);
            }

            Console.WriteLine(sum);

        
        }
    }
