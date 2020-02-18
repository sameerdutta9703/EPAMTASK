using System;
namespace ProtectedConstructorExample
{
    class ProtectedConstructor
   {
       int num;
       string name;

        //accesed every where except from the subclass of different package
        protected ProtectedConstructor()
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
           ProtectedConstructor c = new ProtectedConstructor();
           
           Console.WriteLine(c.name);
           Console.WriteLine(c.num);
       }
   }
}