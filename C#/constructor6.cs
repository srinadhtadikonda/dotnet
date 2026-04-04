using System;

class Rect
{
    public static int l;
    public static int b;

    static Rect()  // static constructor
    {
        l = 20;
        b = 10;
    }

    public static void putVals()
    {
        System.Console.WriteLine("Length=" + l);
        System.Console.WriteLine("Breadth=" + b);
    }

    public static int calArea()
    {
        return l * b;
    }
}

class MyRect
{
    static void Main()
    {
        Rect.putVals();
        System.Console.WriteLine("Area of Rectangle=" + Rect.calArea());
    }
}
