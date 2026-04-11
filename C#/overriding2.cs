using System;

// Abstract class
abstract class Animal
{
    public abstract void Sound(); // Abstract method (no body)
}

// Derived class
class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        Animal a = new Cat();  // Abstract reference, child object
        a.Sound();             // Output: Cat meows
    }
}
