using System;

// Step 1: Declare delegate
public delegate void MyDelegate();

class Program
{
    // Step 2: Declare event
    public static event MyDelegate MyEvent;

    static void Main()
    {
        // Step 4: Subscribe to event
        MyEvent += Display;

        // Step 3: Raise event
        MyEvent?.Invoke();
    }

    static void Display()
    {
        Console.WriteLine("Event Triggered!");
    }
}
