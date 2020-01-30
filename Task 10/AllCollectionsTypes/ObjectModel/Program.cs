using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(3);
            list.Add(5);
       
            // Constructor.
            ReadOnlyCollection<int> read = new ReadOnlyCollection<int>(list);

            // Loop over ReadOnlyCollection.
            foreach (int value in read)
            {
                Console.WriteLine("read: {0}", value);
            }

            // Copy ReadOnlyCollection to an array.
            int[] array = new int[3];
            read.CopyTo(array, 0);

            // Display array.
            foreach (int value in array)
            {
                Console.WriteLine("array: {0}", value);
            }

            // Use methods on ReadOnlyCollection.
            int count = read.Count;
            bool contains = read.Contains(-1);
            int index = read.IndexOf(3);
            Console.WriteLine("{0}, {1}, {2}", count, contains, index);
        }
    }
}
