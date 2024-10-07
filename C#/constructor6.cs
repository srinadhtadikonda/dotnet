using System;

class Rect
{
    public int l;
    public int b;
    
    private Rect()  // private constructor
    {
        l = 20;
        b = 10;
    }

    public static Rect CreateInstance() // static method to create instance
    {
        return new Rect();
    }

    public void putVals()
    {
        System.Console.WriteLine("Length=" + l);
        System.Console.WriteLine("Breadth=" + b);
    }

    public int calArea()
    {
        return l * b;
    }
}

class MyRect
{
    static void Main()
    {
        Rect R = Rect.CreateInstance(); // use static method to create instance
        R.putVals();
        System.Console.WriteLine("Area of Rectangle=" + R.calArea());
    }
}
