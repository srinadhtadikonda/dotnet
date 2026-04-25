using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = a / b;   // May cause DivideByZeroException

            int[] arr = {10,20,30};
            Console.WriteLine(arr[5]); // May cause IndexOutOfRangeException

            Console.WriteLine("Result = " + result);
        }

        catch(DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }

        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("Array index is out of range");
        }

        catch(FormatException)
        {
            Console.WriteLine("Please enter numbers only");
        }

        catch(Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }

        finally
        {
            Console.WriteLine("Finally block executed");
        }
    }
}
