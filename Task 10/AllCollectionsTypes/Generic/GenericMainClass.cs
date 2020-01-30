using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Generic
{
    class GenericMainClass
    {
        static void Main(string[] args)
        {
            //Instance of a String Type
            MyGenericType<string> name = new MyGenericType<string>();
            name.value = "SameerDutta";
            Console.WriteLine(name.value);



            MyGenericType<int> roll = new MyGenericType<int>();
            roll.value = 180;
            Console.WriteLine(roll.value);

            Console.ReadLine();

        }
    }
}
