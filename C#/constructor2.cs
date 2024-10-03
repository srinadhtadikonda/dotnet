using System;

class Rect
{
    public int l;
    public int b;
    
public Rect(int x,int y)           //Parameterized constructor
        {
        l=x;
        b=y;
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
        Rect R = new Rect(100,50);
        R.putVals();
        System.Console.WriteLine("Area of Rectangle=" + R.calArea());
    }
}