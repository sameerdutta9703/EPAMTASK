using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concurrent
{
    class ConcurrentClass
    {
        static void Main(string[] args)
        {

            ConcurrentStack<int> s = new ConcurrentStack<int>();

            s.Push(50);
            s.Push(100);
            s.Push(150);
            s.Push(200);
            s.Push(250);
            s.Push(300);

            if (s.IsEmpty)
            {
                Console.WriteLine("The stack is empty!");
            }

            else
            {
                Console.WriteLine("The stack isn't empty");
            }
        }
    }
}
