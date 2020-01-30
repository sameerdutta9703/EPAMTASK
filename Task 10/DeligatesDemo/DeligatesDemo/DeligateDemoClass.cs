using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligatesDemo
{
    class DeligateDemoClass
    {
        //Declaring the deligates
        public delegate void numAddition(int a, int b);
        public delegate void numSubtraction(int a, int b);

        //The  Addition methord
        public void sum(int a, int b)
        {
            Console.WriteLine("(100 + 40) = {0}", a + b);
        }

        //The Subtraction methord
        public void diff(int a, int b)
        {
            Console.WriteLine("(100 - 40) = {0}", a - b);
        }

        static void Main(string[] args)
        {

            //Creating the object of the DeligateDemoClass
            DeligateDemoClass obj = new DeligateDemoClass();

            //Creating the object of Deligates for the sum and diff methord
            numAddition addObj = new numAddition(obj.sum);
            numSubtraction diffObj = new numSubtraction(obj.diff);

            //Pass the values of the methord by the deligate object
            addObj(100, 40);

            //We can use the invoke methord too for calling the deligate objects
            diffObj.Invoke(100, 40);

            Console.ReadLine();
        }
    }
}
