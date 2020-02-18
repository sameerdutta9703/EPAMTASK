using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollectionsArrayList
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            CustomCollectionArrayListClass<int> cus = new CustomCollectionArrayListClass<int>();

            //Added the elements in the ArrayList
            cus.add(12);
            cus.add(32);
            cus.add(83);
            cus.add(49);
            cus.add(65);
            cus.add(99);
            cus.add(0);
            
            //Printing the elements
            cus.show();

            //Deleting a particular element and showing the remannings
            cus.delete(32);
            cus.show();

            Console.WriteLine(cus.capacity());
            Console.WriteLine("\n");

            cus.sort();
            cus.show();
            
            Console.ReadLine();
        }
    }
}
