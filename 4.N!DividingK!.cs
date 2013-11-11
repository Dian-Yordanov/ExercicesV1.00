using System.Text;

class Program
    {
    static Decimal Factor(int k)
    { decimal res=1;
    for (int i = 2; i<=k; i++) res *= i;
    return res;
    }
    static void Main(string[] args)
    {
        
            Console.WriteLine((double)Factor(int.Parse(Console.ReadLine())) / (double)Factor(int.Parse(Console.ReadLine())));

        
        }
    }

