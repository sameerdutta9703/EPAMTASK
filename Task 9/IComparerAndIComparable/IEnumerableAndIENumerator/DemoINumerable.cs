using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIENumerator
{
    class DemoINumerable
    {
        static void Main(string[] args)
        {
            List<int> year = new List<int>();

            year.Add(1990);
            year.Add(1991);
            year.Add(1994);
            year.Add(1993);
            year.Add(1995);

            //Implementing the IEnumurable
            IEnumerable<int> ienum = (IEnumerable<int>)year;
            foreach(int i in ienum)
            {
                Console.WriteLine(i);
            }
            
            //Implementing the IEnumurator
            IEnumerator<int> iemurate = year.GetEnumerator();
            while(iemurate.MoveNext())
            {
                Console.WriteLine(iemurate.Current.ToString());
            }
            
            // The major difference between the IEnumurator and iEnumurable is the remembering the state of its cursor, which IEnumurator does but IEnumurable does not.

            Console.ReadLine();
        }
    }
}
