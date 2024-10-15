class Test // class
{
    private int x; // variable
    public int X
    {
        set
        {
            x = value;
        }
        get => x; // Expression-bodied get accessor
    }
    class T
    {
        static void Main()
        {
            Test TS = new Test(); // object TS
            TS.X = 100;
            int t = TS.X;
            System.Console.WriteLine("Value of x=" + t);
        }
    }
}
