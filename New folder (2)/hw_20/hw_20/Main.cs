using System;

namespace hw_20
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] n = {3, 4, 4, 2, 3, 3, 4, 3, 2};
			
			int nl = n.Length;
			
			int[] c = new int[nl+1];
			
			for (int i=0; i < nl; i++)
			{
				c[n[i]]++;
			}
			
			int cl = c.Length;
			
			for (int k=0; k < cl; k++)
			{
				if (c[k] != 0)
				{
					Console.WriteLine (k+" ("+c[k]+" times)");
				}
			}
		}
	}
}

