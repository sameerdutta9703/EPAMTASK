using System;

namespace DemoAbstraction
{

class Abstraction
{
    static void Main(string[] args)
    {
        Shape obj=new Square(6);

        double res=obj.area();
        Console.Write("{0}", res);
    }
}

    abstract class Shape
    {
        //The abstract methord
        public abstract int area();
    }

    class Square : Shape
    {
        private int side;

        public Square(int x=0)
        {
            side=x;
        }

        public override int area()
        {
            Console.Write("Area of the Square: ");
            return (side*side);
        }
    }
}