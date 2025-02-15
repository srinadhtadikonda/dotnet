int a = 5, b = 6;
System.Console.WriteLine("value before swaping a=" + a + "\t" + "b=" + b);
a = a + b;
b = a - b;
a = a - b;
System.Console.WriteLine("value after swaping a=" + a + "\t" + "b=" + b);