using System;

class Singleton
{
    public static void Main()
    {
        SingletonDemo.obj.Show();
    }
}

sealed class SingletonDemo
{
    public static readonly SingletonDemo obj = new SingletonDemo();

    //Constructor with no parameter
    private SingletonDemo()
    {

    }
    public void Show()
    {
        Console.WriteLine("True");
    }
}