//Gaidarov
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program{
    static void Main()
    {
        try
        {
            string st = Console.ReadLine();
            string[] subs = st.Split(':');
            subs[1] = subs[1].Remove(0, 2);

            char[] a = new char[1];
            a[0] = '/';

            Console.WriteLine("[protocol] {0}\n[server] {1}\n[resource] /{2}", subs[0], subs[1].Split(new char[] { '/' }, 2)[0], subs[1].Split(new char[] { '/' }, 2)[1]);
        }
        catch (SystemExeption se)
        {
            Console.WriteLine(  se.Name);
        }
    
    }
}