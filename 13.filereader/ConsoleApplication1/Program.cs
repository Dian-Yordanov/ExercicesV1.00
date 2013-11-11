using System;

namespace _13.FileReader
{
    class Program
    {
        static void Main()
        {
            Console.Write("Vavedete patq do jelaniq fail: ");
            try
            {
                Console.WriteLine(System.IO.File.ReadAllText(Console.ReadLine()));
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Failat ne e nameren!");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("Greshna direktoriq!");
            }
            catch (SystemException systemexeption)
            {
                Console.WriteLine(systemexeption.Message);
            }
            catch
            {
                Console.WriteLine("Vaznikna greshka!");
            }
        }
    }
}
