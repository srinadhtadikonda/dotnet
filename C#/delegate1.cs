using System;

// Define the delegate outside the class
delegate void greets();

class Test
{
    // This method should be static since it is called from a static context
    public static void greetone()
    {
        System.Console.WriteLine("I am a function");
    }

    // Main method should be static
    public static void Main()
    {
        // Create an instance of the delegate and point it to the greetone method
        greets g = new greets(greetone);
        
        // Invoke the delegate
        g();
    }
}


