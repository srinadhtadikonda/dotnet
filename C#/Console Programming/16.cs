﻿using System;
int a, b;
System.Console.WriteLine("Enter a:");
a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter b:");
b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("values before swaping a=" + a + "\t" + "b=" + b);
a = a ^ b;
b = a ^ b;
a = a ^ b;
System.Console.WriteLine("values after swaping a=" + a + "\t" + "b=" + b);