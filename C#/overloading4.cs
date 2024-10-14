using System.Diagnostics.SymbolStore;

class Books
{
    public int bno;
    public string bname;
    public double bprice;
    public Books()
    {
        bno = 101;
        bname = "Unix";
        bprice = 456.75;
    }
 public   void sbooksone()
    {
        System.Console.WriteLine("Bno=" + bno + "\t" + "Bname=" + bname + "\t" + "bprice="+bprice);
    }
    public Books(int bn,string bna)
    {
        bno = bn;
        bname = bna;
        
    }
    public void sbookstwo()
    {
        System.Console.WriteLine("Bno=" + bno + "\t" + "Bname=" + bname);
    }
    public Books(int bn, string bna,double bp)
    {
        bno = bn;
        bname = bna;
        bprice = bp;
    }
    public void sbooksthree()
    {
        System.Console.WriteLine("Bno=" + bno + "\t" + "Bname=" + bname+"\t"+"Bprice="+bprice);
    }
}
class Test
{
    static void Main()
    {
        Books B1 = new Books();
        Books B2 = new Books(102, "Java");
        Books B3 = new Books(103, "Python", 256.75);
        B1.sbooksone();
        B2.sbookstwo();
        B3.sbooksthree();

    }
}
