using System;
using System.IO;
class Test
{
    static void Main()
    {
        StreamWriter sw = File.CreateText("D:\\mycode\\Csharp\\ConsoleApp33\\ConsoleApp33\\fruits.txt");
        sw.WriteLine("apple");
        sw.WriteLine("banana");
        sw.WriteLine("orange");
        sw.WriteLine("grape");
        sw.Close();
    }
}
