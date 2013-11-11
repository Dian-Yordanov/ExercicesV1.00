using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program{
    static void Main()
    {
        
        SortedDictionary<int, int> dict = new SortedDictionary<int,int>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
			{
			 string num = Console.ReadLine();
             if (dict.ContainsKey(int.Parse(num))) dict[int.Parse(num)]++;
             else dict.Add(int.Parse(num), 1);
			}

        foreach (var item in dict)
        {
            Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
        }
        {
            
        }
    
    }
}