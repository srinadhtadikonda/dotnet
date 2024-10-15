class Test                  //class
{
    private int x;              //variable

    public void setx(int i)         //function to set a value
    {
        x = i;
    }
   public void getx()                //function to get a value
    {
        System.Console.WriteLine("value of x="+x);
    }
}
class T
{
    static void Main()
    {
        Test TS = new Test();               //object TS
        TS.setx(20);                        //set value to x
        TS.getx();				// get value of x
    }
}
