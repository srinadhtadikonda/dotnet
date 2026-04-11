using System;

class Animal
{
    public void Sound()
    {
        Console.WriteLine("Animal sound");
    }
}

class Dog : Animal
{
    public new void Sound()   // Method hiding (not overriding)
    {
        Console.WriteLine("Dog barks");
    }
}

class Program
{
    static void Main()
    {
        Animal a = new Dog();
        a.Sound();   // Output: Animal sound (NOT overridden)

        Dog d = new Dog();
        d.Sound();   // Output: Dog barks
    }
}
