using System;
using System.Collections;

//First parent Class
class First
{
    public void language()
    {
        ArrayList aList = new ArrayList();

        aList.Add("C");
        aList.Add("C#");
        aList.Add("Java");

        Console.WriteLine("Languages :- ");
        foreach(var i in aList)
        {
            Console.WriteLine(i);
        }
    }
}
//Second Parent Class
class Second
{
    public void technology()
    {
        ArrayList aList = new ArrayList();

        aList.Add("Angular JS");
        aList.Add("BlockChain");
        aList.Add("Machine Automation");

        Console.WriteLine("Technology :- ");
        foreach(var i in aList)
        {
            Console.WriteLine(i);
        }
    }
//The Child class
    class Child : First, Second
    {

    }

    public class DriverMethord
    {
        public static void Main(string[] args)
        {
            Child child=new Child();
            child.language();
            child.technology();
        }
    }
}