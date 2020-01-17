using System;
namespace DefaultConst
{
   class DefaultConstructor
   {
       int num;
       string name;

       Details()
       {
           Console.WriteLine("Default Constructor called");
       }

       public static void Main(string[] args)
       {
           DefaultConstructor c = new DefaultConstructor();
           
           Console.WriteLine(c.name);
           Console.WriteLine(c.num);
       }
   }
}