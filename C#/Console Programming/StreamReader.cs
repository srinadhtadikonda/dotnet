using System;
using System.IO;

class Test
{
    static void Main()
    {
        StreamReader sr = new StreamReader("D:\\mycode\\Csharp\\ConsoleApp33\\ConsoleApp33\\fruits.txt");
        string line;   //converts bytes to string
        
        while ((line = sr.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
