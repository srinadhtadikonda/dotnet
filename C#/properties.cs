//C#: Property
using System;
class MyClass
{
            private int x;
            public int X
            {
                        get
                        {
                                    return x;
                        }
                        set
                        {
                                    x = value;
                        }
            }
}
class MyClient
{
            public static void Main()
            {
                        MyClass mc = new MyClass();
                        mc.X = 10;
                        int xVal = mc.X;
                        Console.WriteLine(xVal);//Displays 10
            }
}  
