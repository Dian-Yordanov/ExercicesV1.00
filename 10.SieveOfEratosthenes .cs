using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program{


    static void Main(string[] args){
        bool[] re = new bool[10000000]; //true = slojno
        
        
        for(int i=2; i<10000000; i++) {
            if (re[i]) continue; 
            for (int i2 = i + i; i2 < 10000000; i2 += i) { re[i2] = true;  }
			
            }

        for(int i=0; i<10000000; i++) if(!re[i]) Console.WriteLine(i);
    }
}