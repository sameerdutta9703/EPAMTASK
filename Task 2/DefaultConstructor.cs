using System;
namespace DefaultConst
{
   class Constructor
   {
       int num;
       string name;

       Details()
       {
           Console.WriteLine("Default Constructor called");
       }

       public static void Main(string[] args)
       {
           Constructor c = new Constructor();
           
           Console.WriteLine(c.name);
           Console.WriteLine(c.num);
       }
   }
}