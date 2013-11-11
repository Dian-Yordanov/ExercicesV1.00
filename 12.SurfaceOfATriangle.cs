using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TriangleSurfaceCalculator
    {
        class Program
            {
                static void Main()
                    {
                        Console.WriteLine(
                            "Find the surface of the triangle, with given :\n1. side and a given altitude to it \n2. three sides \n3. two sides and an angle between them");
                        int q = int.Parse(Console.ReadLine());
                        if (q == 1)
                            {
                                Console.WriteLine(
                                    "input the size of the side with a integer in sm: ");
                                int a = int.Parse(Console.ReadLine());
                                Console.WriteLine("input the size of the altitude to the side in sm: ");
                                int h = int.Parse(Console.ReadLine());
                                if ((a >= 0) && (h >= 0))
                                    {
                                        Console.WriteLine("S = " +
                                                          (a * h) / 2 + " sm^2");
                                    }
                            }
                        if (q == 2)
                            {
                                Console.WriteLine(
                                    "input the perimeter like a integer in sm: ");
                                int a = int.Parse(Console.ReadLine());
                                int b = int.Parse(Console.ReadLine());
                                int c = int.Parse(Console.ReadLine());
                                int p = (a + b + c) / 2;
                                Console.Write("a = {0}, b = {1}, c = {2} ",
                                              a,
                                              b,
                                              c + " S = " +
                                              Math.Sqrt(p * (p - a) * (p - b) * (p - c)) + " sm^2");
                            }
                        if (q == 3)
                            {
                                Console.WriteLine(
                                    "input the size of the two sides like integers and the size of the angle between them : ");
                                int a = int.Parse(Console.ReadLine());
                                int b = int.Parse(Console.ReadLine());
                                int alpha = int.Parse(Console.ReadLine());
                                var sinalpha = (System.Math.Sin(alpha));
                                int y = Convert.ToInt32(sinalpha);
                                Console.WriteLine("a = {0}, b = {1}, sin(alpha) = {2} ",
                                                  a,
                                                  b,
                                                  y + " S = " + a * b * y / 2 + " sm^2");
                            }
                    }
            }
    }
