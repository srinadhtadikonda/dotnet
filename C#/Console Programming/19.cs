using System;
int r;
double ci, a;
System.Console.Write("Enter Radius");
r = Convert.ToInt32(Console.ReadLine());
ci = 2 * Math.PI * r;
System.Console.Write("Enter circumference:" + ci);
a = Math.PI * r * r;
System.Console.Write("Area of circle:" + a);