using System;

namespace DemoInheritance
{
    class Parent
    {
        public string name;
        public string subject;

        public void readers(string name, string subject)
        {
            this.name=name;
            this.subject=subject;

            Console.WriteLine("MY NAME :- "+name);
            Console.WriteLine("MY FAVORITE SUBJECT IS :- "+subject);
        }
    }
    class Child : Parent
    {
        //constructor for derieved class
        public Child()
        {
            Console.WriteLine("Child");
        }
    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            Child cd=new Child();
            cd.readers("Sameer", "History");
        }
    }
}