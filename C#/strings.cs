//To print Reverse Elements of an array
using System;
using System.Data.Odbc;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
class Test
{

    static void Main()
    {
        String str1 = "state bank of india";
        string str2 = "VIJAYAWADA";
        string str3 = "            Patamata           ";
        System.Console.WriteLine("String=" + str1);
        System.Console.WriteLine("String=" + str1.Length);
        System.Console.WriteLine("Upper Case=" + str1.ToUpper());
        System.Console.WriteLine("Lower Case=" + str1.ToLower());
        System.Console.WriteLine("repalce=" + str3.Replace('a','x'));
        System.Console.WriteLine("Concat=" + str1.Concat(str2));
        System.Console.WriteLine("Contains=" + str1.Contains("bank"));
        System.Console.WriteLine("Contains=" + str1.StartsWith("country"));
        System.Console.WriteLine("Contains=" + str1.EndsWith("africa"));
        System.Console.WriteLine("Contains=" + str1.Insert(3,"abc"));
        System.Console.WriteLine("Contains=" + str1.Substring(7,4));
        System.Console.WriteLine("Contains=" + str1.IndexOf('b'));
    }
}
