using System;

class Rect
{
    public int l;
    public int b;


    public Rect(int x, int y)           //Parameterized constructor
    {
        l = x;
        b = y;
    }

    public Rect(Rect r)                 //copy constructor
    {
        l = r.l;
        b= r.b;
    }
    public void putVals()
    {
        System.Console.WriteLine("Length=" + l);
        System.Console.WriteLine("Breadth=" + b);

    }
}
class MyRect
{
    static void Main()
    {
        Rect RT1 = new Rect(100, 50);
        Rect RT2 = new Rect(RT1); 
        RT1.putVals();
        RT2.putVals();
    }
}