//program without using properties
class Test                  //class
{
    private int x;              //variable

    public void setx(int i)         //function to set a value
    {
        x = i;
    }
   public int getx()                //function to get a value
    {
        return x;
    }
}
class T
{
    static void Main()
    {
        Test TS = new Test();               //object TS
        TS.setx(20);                        //set value to x
        int t = TS.getx();                  //transfer value to a temp variable
        System.Console.WriteLine("X=" + t);     //print value
    }
}
