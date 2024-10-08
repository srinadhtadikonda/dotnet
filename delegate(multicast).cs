using System;

public delegate void GreetDelegate(string message);

class Program
{
    public static void GreetMorning(string message)
    {
        Console.WriteLine("Good Morning, " + message);
    }

    public static void GreetEvening(string message)
    {
        Console.WriteLine("Good Evening, " + message);
    }

    static void Main(string[] args)
    {
        // Create a multicast delegate
        GreetDelegate greet = GreetMorning;
        greet += GreetEvening;

        // Call both methods via the delegate
        greet("Charlie");
    }
}
