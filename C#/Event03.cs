//Built-in Delegate (EventHandler) nstead of creating custom delegates, you can use EventHandler:

using System;

class Demo
{
    public event EventHandler MyEvent;

    public void RaiseEvent()
    {
        MyEvent?.Invoke(this, EventArgs.Empty);
    }
}

class Program
{
    static void Main()
    {
        Demo d = new Demo();
        d.MyEvent += Handler;

        d.RaiseEvent();
    }

    static void Handler(object sender, EventArgs e)
    {
        Console.WriteLine("Event handled using EventHandler!");
    }
}
