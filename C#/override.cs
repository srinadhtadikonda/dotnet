using System;

class Person
{
   public virtual void walk()  // Marked as virtual for overriding
    {
        Console.WriteLine("Person Walks Slowly");
    }
}

class Employee : Person
{
   public override void walk()  // Marked as override for correct overriding
    {
        Console.WriteLine("Person Walks Speedily");
    }
}

class Test
{
    static void Main()
    {
        Employee E = new Employee();
        E.walk();  // Calls the overridden method in Employee
    }
}
