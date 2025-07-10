using System;
using System.IO;

class Program
{
    static void Main()
    {
        // File path
        string filePath = "example.txt";

        // Check if the file exists
        if (File.Exists(filePath))
        {
            // Read all text from the file
            string content = File.ReadAllText(filePath);

            // Display the content
            Console.WriteLine("File Content:");
            Console.WriteLine(content);
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}
