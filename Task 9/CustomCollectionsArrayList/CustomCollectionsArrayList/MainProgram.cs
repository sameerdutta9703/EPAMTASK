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
            cus.add(1);
            cus.add(2);
            cus.add(3);
            cus.add(4);
            cus.add(5);
            
            //Printing the elements
            cus.show();

            //Deleting a particular element and showing the remannings
            cus.delete(3);
            cus.show();

            Console.ReadLine();
        }
    }
}
