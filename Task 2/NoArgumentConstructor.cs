using System;
namespace NoArgumentConstructorExample
{
    class NoArgument
   {
       int num;
       string name;

        NoArgument()
        {
            Console.WriteLine("Constructor Called");
            num = 24;
            name = "Sameer";
        }
       Details()
       {
           Console.WriteLine("Default Constructor called");
       }

       public static void Main(string[] args)
       {
           NoArgument c = new NoArgument();
           
           Console.WriteLine(c.name);
           Console.WriteLine(c.num);
       }
   }
}
