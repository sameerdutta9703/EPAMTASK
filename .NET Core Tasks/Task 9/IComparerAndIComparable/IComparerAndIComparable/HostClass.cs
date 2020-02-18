using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IComparerAndIComparable;

namespace IComparerAndIComparable
{
    class HostClass
    {
        [STAThread]
      static void Main(string[] args)
        {
            // Creating an arary of car objects.      
            car[] arrayOfCars = new car[4]
            {
            new car("Ford",1932), new car("Boult",1988), new car("Honda",1967), new car("Fiat",1978)            
            };

            Console.WriteLine("Default Unsorted Data\n");
            foreach (car c in arrayOfCars)
            {
                Console.WriteLine(c.Make + "\t" + c.Year);
            }                

            // IComparable by sorting array with "default" sort order.
            Array.Sort(arrayOfCars);
            Console.WriteLine("\nSorted by Make using IComparable\n");
            foreach (car c in arrayOfCars)
            {
                Console.WriteLine(c.Make + "\t" + c.Year);
            }

            // Ascending sort of numeric value with IComparer.
            Array.Sort(arrayOfCars, car.sortYearAscending());
            Console.WriteLine("\nSorted by Year using IComparer\n");
            foreach (car c in arrayOfCars)
            {
                Console.WriteLine(c.Make + "\t" + c.Year);
            }

            Console.ReadLine();
        }
    }
}
