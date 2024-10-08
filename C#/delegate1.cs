using System;

// Declare a delegate
public delegate void GreetDelegate(string message);

class Program
{
    // Method that matches the delegate signature
    public static void GreetMorning(string message)
    {
        Console.WriteLine("Good Morning, " + message);
    }

    // Another method that matches the delegate signature
    public static void GreetEvening(string message)
    {
        Console.WriteLine("Good Evening, " + message);
    }

    static void Main(string[] args)
    {
        // Create delegate instances and assign methods
        GreetDelegate greet1 = new GreetDelegate(GreetMorning);
        GreetDelegate greet2 = new GreetDelegate(GreetEvening);

        // Call the methods using delegates
        greet1("Alice");  // Calls GreetMorning
        greet2("Bob");    // Calls GreetEvening
    }
}
