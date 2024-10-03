using System;

class Rect
{
    public int l;
    public int b;
    
public Rect()           //default constructor
        {
        l=20;
        b=10;
        }

public void putVals()
    {
        System.Console.WriteLine("Length=" + l);
        System.Console.WriteLine("Breadth=" + b);

    }
    public int calArea()
    {
        return l*b;
    }
}
class MyRect
{
    static void Main()
    {
        Rect R = new Rect();
        R.putVals();
        System.Console.WriteLine("Area of Rectangle=" + R.calArea());
    }
}