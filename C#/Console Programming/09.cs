int a = 5, b = 7;
System.Console.WriteLine("values before swap a=" + a + "\t" + "b=" + b);
a = a ^ b;
b = a ^ b;
a = a ^ b;
System.Console.WriteLine("values after swap a=" + a + "\t" + "b=" + b);
