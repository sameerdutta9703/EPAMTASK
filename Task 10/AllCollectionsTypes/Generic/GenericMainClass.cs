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

            #region "List"
            Console.WriteLine("List");
            List<int> a = new List<int>();

            //Adding the items in the List
            a.Add(12);
            a.Add(44);
            a.Add(99);
            a.Add(15);
            a.Add(3);

            Console.WriteLine(a.Count);
            a.RemoveAt(0);

            //Printing the elements
            foreach (int obj in a)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("\n");
            #endregion

            #region "Dictionary"
            Console.WriteLine("Dictionary");
            Dictionary<string, int> dict = new Dictionary<string, int>();
            
            //Adding the elements
            dict.Add("abc", 1);
            dict.Add("bcd", 2);
            dict.Add("cad", 4);
            
            //Printing the elements
            foreach (KeyValuePair<string, int> kvp in dict)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
            
            Console.WriteLine("\n");
            #endregion

            #region"SortedList"
            Console.WriteLine("SortedList");
            SortedList<string, int> SortedL = new SortedList<string, int>();

            //Adding all the elements
            SortedL.Add("Abc", 7);
            SortedL.Add("AAA", 9);
            SortedL.Add("bbb", 3);

            //Printing all the elements
            foreach (KeyValuePair<String, int> SLObj in SortedL)
            {
                Console.WriteLine(SLObj.Key + " " + SLObj.Value);
            }

            Console.WriteLine("\n");
            #endregion

            #region"Stack"
            Console.WriteLine("Stack");
            Stack<int> GCStack = new Stack<int>();

            //Adding all the elements
            GCStack.Push(58);
            GCStack.Push(47);
            GCStack.Push(44);
            GCStack.Push(51);

            //Printing all the elements
            Console.WriteLine(GCStack.Count);
            Console.WriteLine(GCStack.Pop());
            Console.WriteLine(GCStack.Count);
            Console.WriteLine(GCStack.Peek());

            Console.WriteLine("\n");
            #endregion

            #region "Queue"
            Console.WriteLine("Queue");
            Queue<int> GCQueue = new Queue<int>();

            //Adding all the elements
            GCQueue.Enqueue(478);
            GCQueue.Enqueue(745);
            GCQueue.Enqueue(63);
            GCQueue.Enqueue(453);
            GCQueue.Enqueue(456);

            //Printing all the elements
            Console.WriteLine(GCQueue.Dequeue());
            Console.WriteLine(GCQueue.Count);
            Console.WriteLine(GCQueue.Peek());

            Console.WriteLine("\n");
            #endregion

            #region "My Generic Type"
            Console.WriteLine("My Generic Type");

            //Instance of a String Type
            MyGenericType<string> name = new MyGenericType<string>();
            name.value = "SameerDutta";
            Console.WriteLine(name.value);

            MyGenericType<int> roll = new MyGenericType<int>();
            roll.value = 180;
            Console.WriteLine(roll.value);
            #endregion

            Console.ReadLine();

        }
    }
}
