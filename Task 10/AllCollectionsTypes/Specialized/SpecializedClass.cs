using System;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Specialized
{
    class SpecializedClass
    {
        static void Main(string[] args)
        {
            StringCollection sc = new StringCollection();

            sc.Add("B");
            sc.Add("I");
            sc.Add("N");
            sc.Add("O");
            sc.Add("Y");

            foreach(Object obj in sc)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
