//Program to create a text file

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.txt";
        string content = "Hello, this is a sample text file created using C#.";
        File.WriteAllText(filePath, content);
        Console.WriteLine("File created successfully at: " + Path.GetFullPath(filePath));
    }
}
