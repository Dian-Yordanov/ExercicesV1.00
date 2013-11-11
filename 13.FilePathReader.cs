using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program{
    static void Main()
    {

        try
        {
            Console.WriteLine(System.IO.File.ReadAllText(Console.ReadLine()));
        }
        catch (System.IO.FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (System.IO.DirectoryNotFoundException)
        {
            Console.WriteLine("Path is not correct.");
        }
        catch (SystemException se)
        {
            Console.WriteLine(se.Message);
        }
        catch
        {
            Console.WriteLine("something went really wrong");
        }

    }
}