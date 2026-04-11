using System;

class Complex
{
    public int real, imag;

    public Complex(int r, int i)
    {
        real = r;
        imag = i;
    }

    // Operator Overloading
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.real + c2.real, c1.imag + c2.imag);
    }

    public void Display()
    {
        Console.WriteLine(real + " + " + imag + "i");
    }
}

class Program
{
    static void Main()
    {
        Complex c1 = new Complex(2, 3);
        Complex c2 = new Complex(4, 5);

        Complex c3 = c1 + c2;   // Using overloaded operator
        c3.Display();           // Output: 6 + 8i
    }
}
