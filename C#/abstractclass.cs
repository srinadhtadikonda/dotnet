abstract class Bank
{
   public  abstract void irate();
}
class HDFC : Bank
{
    public override void irate()
    {
        System.Console.Write("Interest rate is 5%");
    }

    static void Main()
    {
        HDFC H = new HDFC();
        H.irate();
    }
}
