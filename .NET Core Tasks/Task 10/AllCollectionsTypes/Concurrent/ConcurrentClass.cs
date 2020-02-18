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

            #region"ConcurrentBag"
            Console.WriteLine("ConcurrentBag");
            ConcurrentBag<string> Concbag = new ConcurrentBag<string>();
            Concbag.Add("Dev");
            Concbag.Add("Deva");
            Concbag.Add("Devi");
            Concbag.Add("Devo");

            Console.WriteLine(Concbag.Count);

            Console.WriteLine("\n");
            #endregion

            #region "Concurrent Stack"
            Console.WriteLine("Concurrent Stack");
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

            Console.WriteLine("\n");
            #endregion

            #region"ConcurrentQueue"
            Console.WriteLine("Concurrent Queue");

            ConcurrentQueue<int> ConnQueue = new ConcurrentQueue<int>();

            ConnQueue.Enqueue(487);
            ConnQueue.Enqueue(543);
            ConnQueue.Enqueue(251);

            foreach (int item in ConnQueue)
            {
                Console.WriteLine("item");
            }
            
            Console.WriteLine("\n");
            #endregion

            #region"ConcurrentDictionary"
            Console.WriteLine("ConcurrentDictionary");

            ConcurrentDictionary<string, string> dictionary = new ConcurrentDictionary<string, string>();
            bool firstItem = dictionary.TryAdd("1", "First"); //returns true
            bool secondItem = dictionary.TryAdd("2", "Second"); //returns  true
            bool thirdItem = dictionary.TryAdd("1", "Third"); //returns false;

            Console.WriteLine(firstItem);
            Console.WriteLine(secondItem);
            Console.WriteLine(thirdItem);

            Console.WriteLine("\n");
            #endregion

            #region"BlockingCollection"
            Console.WriteLine("Blocking Collection");

            BlockingCollection<int> BColl = new BlockingCollection<int>(boundedCapacity: 3);

            BColl.Add(45);
            BColl.Add(54);
            BColl.Add(86);
            //BColl.Add(548);

            foreach (int item in BColl.GetConsumingEnumerable())
            {
                Console.WriteLine(item);
            }
            #endregion

        }
    }
}
