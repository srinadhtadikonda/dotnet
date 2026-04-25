namespace MyFirstDelegate {
    //This delegate can point to any method,
    //taking two integers and returning an
    //integer.
    public delegate int MyDelegate(int x, int y);
    //This class contains methods that MyDelegate will point to.
    public class MyClass {
        public static int Add(int x, int y) {
            return x + y;
        }
        public static int Multiply(int x, int y) {
            return x * y;
        }
    }
    class Program {
        static void Main(string[] args) {
            //Create an Instance of MyDelegate
            //that points to MyClass.Add().
            MyDelegate del1 = new MyDelegate(MyClass.Add);
            //Invoke Add() method using the delegate.
            int addResult = del1(5, 5);
            Console.WriteLine("5 + 5 = {0}\n", addResult);
            //Create an Instance of MyDelegate
            //that points to MyClass.Multiply().
            MyDelegate del2 = new MyDelegate(MyClass.Multiply);
            //Invoke Multiply() method using the delegate.
            int multiplyResult = del2(5, 5);
            Console.WriteLine("5 X 5 = {0}", multiplyResult);
            Console.ReadLine();
        }
    }
}
