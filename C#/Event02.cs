using System;

public delegate void Notify();

class EventDemo
{
    public event Notify OnProcess;

    public void StartProcess()
    {
        Console.WriteLine("Process Started...");
        OnProcess?.Invoke(); // Trigger event
    }
}

class Program
{
    static void Main()
    {
        EventDemo obj = new EventDemo();

        obj.OnProcess += Message1;
        obj.OnProcess += Message2;

        obj.StartProcess();
    }

    static void Message1()
    {
        Console.WriteLine("Handler 1 Executed");
    }

    static void Message2()
    {
        Console.WriteLine("Handler 2 Executed");
    }
}
