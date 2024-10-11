interface A 
{
void greetone();   
}
interface B 
{
    void greettwo();
}
class C:A,B 
{
    public void greetone()
    {
        System.Console.WriteLine("Hai");
    }
    public void greettwo()
    {
        System.Console.WriteLine("How are you");
    }
}
class Test 
{
    static void Main()
    {
        C objC=new C();
        objC.greetone();
        objC.greettwo();
    }
}
