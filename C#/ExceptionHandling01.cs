using System;

class Program
{
    static void Main()
    {
        // First try block
        try
        {
            int a = 10, b = 0;
            int c = a / b;   // Exception
            Console.WriteLine(c);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Cannot divide by zero");
        }

        // Second try block
        try
        {
            int[] arr = {10,20,30};
            Console.WriteLine(arr[5]); // Exception
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Array index out of range");
        }

        // Third try block
        try
        {
            string s = null;
            Console.WriteLine(s.Length); // Exception
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("Object reference is null");
        }

        Console.WriteLine("Program Ended");
    }
}
