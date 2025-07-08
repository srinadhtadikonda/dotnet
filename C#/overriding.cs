using System;

class Person
{
    public virtual void walk()
    {
        Console.WriteLine("Person is walking Slowly");
    }
}

class Employee : Person
{
    public override void walk()
    {
        Console.WriteLine("Employee is walking Fast");
    }
}

class Test
{
    static void Main()
    {
        Person E = new Employee();  // Base class reference
        E.walk();  // Calls the overridden method in Employee
    }
}
