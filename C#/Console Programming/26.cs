using System;
int a, b;
System.Console.WriteLine("A:");
a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("B:");
b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    System.Console.WriteLine("A is big");
}
else if (b > a)
{
    System.Console.WriteLine("B is big");
}
else if(a==b)
{
    System.Console.WriteLine("Both are equal");
}