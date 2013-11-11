using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Task20
{
    class Program
    {
        static void Main()
        {
            string myFileContent;
            Console.Write("Enter the path to the file: ");
            string filePath = Console.ReadLine();
            try
            {
                myFileContent = File.ReadAllText(filePath).ToLower();
                char[] delim= {' ', '.', ',', '!', '?', '-',':', '\r','\n'};
                List <string> allWords = new List <string>
                    (myFileContent.Split(delim,StringSplitOptions.RemoveEmptyEntries));
                
                try
                {
                    int n = allWords.Count;
                    if (n < 1)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    List<int> count = new List<int>(n);
                    List<string> words = new List<string>();
                    for (int i = 0; i < n; i++)
                    {
                        bool met = false;
                        string comp= allWords[i];
                        Console.WriteLine(comp);
                        for (int j = 0; j < words.Count; j++)
                        {
                            if (comp.Equals(words[j]))
                            {
                                count[j]++;
                                met = true;
                            }

                        }
                        if (!met)
                        {
                            words.Add(comp);
                            count.Add(1);
                        }

                    }
                    words.Sort();
                    for (int i = 0; i < words.Count; i++)
                    {
                        Console.WriteLine("The word " + words[i] + " occured {0} time(s).", count[i]); 
                    }


                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(
                        "The length of the words should be more than 0.\n" + e);
                }

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("The entered file is not found. \n" + e);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("The path is not valid. \n " + e);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(
                    "You don't have authorized access to this file.\n" + e);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("The file directory cannot be found.\n" + e);
            }
            catch (PathTooLongException e)
            {
                Console.WriteLine("The entered path is too long.\n" + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("The is an exception.\n" + e);
            }
        }
    }
}
