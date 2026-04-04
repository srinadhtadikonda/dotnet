//private constructor
using System;

class MyMath
{
    private MyMath() {} // prevent object creation

    public static int Add(int a, int b)
    {
        return a + b;
    }
}

class Test
{
    static void Main()
    {
        Console.WriteLine(MyMath.Add(5, 3)); // direct use
    }
}
