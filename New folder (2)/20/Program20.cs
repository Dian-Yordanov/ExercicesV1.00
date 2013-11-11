using System;
using System.Collections.Generic;
using System.IO;

namespace CSharp {
	class Program20 {
		static void Main() {
			Console.WriteLine("Write a program that reads a text file and finds all words used in it and how many times each word occurs. Assume that words differing in character casing only are the same.\n");
			string path = @"E:\input.txt";
			try {
				StreamReader file = File.OpenText(path);
				Dictionary<string, int> array = new Dictionary<string, int>();

				string inp = null;
				while ((inp = file.ReadLine()) != null) {
					string[] temp = inp.Split(' ');
					foreach (string s in temp) {
						s.ToLower();
						try {
							array.Add(s, 1);
						}
						catch {
							array[s] += 1;
						}
					}

				}
				file.Close();
				foreach (KeyValuePair<string, int> a in array) {
					Console.WriteLine("{0} ({1} times) ", a.Key, a.Value);
				}
			}
			catch(Exception e) {
				Console.WriteLine("{0}", e.Message);
			}
		}
	}
}
