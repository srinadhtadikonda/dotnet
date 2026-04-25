namespace MyMulticastDelegate {
    //this delegate will be used to call more than one
    //method at once
    public delegate void MulticastDelegate(int x, int y);
    //This class contains methods that MyDelegate will point to.
    public class MyClass {
        public static void Add(int x, int y) {
            Console.WriteLine("You are in Add() Method");
            Console.WriteLine("{0} + {1} = {2}\n", x, y, x + y);
        }
        public static void Multiply(int x, int y) {
            Console.WriteLine("You are in Multiply() Method");
            Console.WriteLine("{0} X {1} = {2}", x, y, x * y);
        }
    }
    class Program {
        static void Main(string[] args) {
            //Create an Instance of MulticastDelegate
            //that points to MyClass.Add().
            MulticastDelegate del = new MulticastDelegate(MyClass.Add);
            //using the same instance of MulticastDelegate
            //to call MyClass.Multibly() by adding it to it's
            //invocation list.
            del += new MulticastDelegate(MyClass.Multiply);
            //Invoke Add() and  Multiply() methods using the delegate.
            //Note that these methods must have a void return vlue
            Console.WriteLine("****calling Add() and Multibly() Methods.****\n\n");
            del(5, 5);
            //removing the Add() method from the invocation list
            del -= new MulticastDelegate(MyClass.Add);
            Console.WriteLine("\n\n****Add() Method removed.****\n\n");
            //this will invoke the Multibly() method only.
            del(5, 5);
        }
    }
}
