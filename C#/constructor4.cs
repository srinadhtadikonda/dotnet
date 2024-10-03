using System;

class Rect
{
    public int l;
    public int b;
    
public Rect(int l,int b)           //Parameterized constructor
        {
        this.l=l;
        this.b=b;
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