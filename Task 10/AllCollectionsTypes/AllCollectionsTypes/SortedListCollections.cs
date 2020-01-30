using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AllCollectionsTypes
{
    class SortedListCollections
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();

            sl.Add("0031", "Zara Ali");
            sl.Add("0025", "Abida Rehman");
            sl.Add("0093", "Joe Holzner");
            sl.Add("0054", "Mausam Benazir Nur");
            sl.Add("0059", "M. Amlan");
            sl.Add("0016", "M. Arif");
            sl.Add("0007", "Ritesh Saikia");

            if (sl.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                sl.Add("0018", "Nuha Ali");
            }

            // get a collection of the keys. 
            ICollection key = sl.Keys;

            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }

            Console.ReadLine();
        }
    }
}
