class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}
class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}
