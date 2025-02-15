using System;
int a, b, h;
System.Console.Write("Enter Base:");
b = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Enter Height:");
h = Convert.ToInt32(System.Console.ReadLine());
a = 1 / 2 * (b * h);
System.Console.WriteLine("Area of triangle:" + a);