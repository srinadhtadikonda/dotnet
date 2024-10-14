using System;

class MyCalci					#class
{
    public int a;					#variables
    public int b;	
    public int c;
    public MyCalci()				#constructor
    {	
        a = 1;
        b = 2;
        c = 3;
    }
    public int mysumone()		
    {
        return a + b + c;
    }
    public MyCalci(int x,int y)			#constructor
    {
        a = x;
        b = y;
       
    }
    public int mysumtwo()
    {
        return a + b;
    }
    public MyCalci(int x, int y,int z)				#constructor
    {
        a = x;
        b = y;
        c = z;
    }
    public int mysumthree()
    {
        return a + b+c;
    }
}
class Test
{
    static void Main()
    {
        MyCalci MC1 = new MyCalci();
        MyCalci MC2 = new MyCalci(10,20);
        MyCalci MC3 = new MyCalci(5,7,9);
        System.Console.WriteLine("Sum=" + MC1.mysumone());
        System.Console.WriteLine("Sum=" + MC2.mysumtwo());
        System.Console.WriteLine("Sum=" + MC3.mysumthree());
    }
}
