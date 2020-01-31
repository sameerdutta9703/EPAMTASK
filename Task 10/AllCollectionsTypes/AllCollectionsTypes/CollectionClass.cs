using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AllCollectionsTypes
{
    class CollectionClass
    {
        static void Main(string[] args)
        {
            #region "ArrayList"
            Console.WriteLine("ArrayList");
            ArrayList arr = new ArrayList();
            string str = "abc";
            int x = 7;
            float y = 8.66f;
            arr.Add(str);
            arr.Add(x);
            arr.Add(y);

            foreach (object o in arr)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("\n");
            #endregion

            #region "Hashtable"
            Console.WriteLine("Hashtable");
            // Create a hashtable 
            // Using Hashtable class 
            Hashtable my_hashtable1 = new Hashtable();

            // Adding key/value pair 
            // in the hashtable 
            // Using Add() method 

            Hashtable my_hashtable2 = new Hashtable() { { 1, "one" }, { 2, "two" }, { 3, "three" }, { 4, "four" }
            };

            Console.WriteLine("Key and Value pairs from my_hashtable2:");

            foreach (var ele2 in my_hashtable2.Values)
            {
                Console.WriteLine(ele2);
            }
            Console.Write("\n");
            #endregion

            #region "SortedList"
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
            Console.WriteLine("\n");
            #endregion 

            #region "Stack"
            Console.WriteLine("Stack");
            Stack St = new Stack();
            
            //Pushing the items in the Stack
            St.Push("A");
            St.Push("B");
            St.Push("C");
            
            //Pooping out and printing the popped element
            Console.WriteLine(St.Pop());

            Console.WriteLine("\n");
            #endregion

            #region "Queue"
            Console.WriteLine("Queue");
            Queue q = new Queue();

            //Pushing the items in the Queue
            q.Enqueue("A");
            q.Enqueue("B");
            q.Enqueue("C");

            //Printing the Count and Dequeue
            Console.WriteLine(q.Count);
            Console.WriteLine(q.Dequeue());

            Console.WriteLine("\n");
            #endregion

            Console.ReadLine();
        }
    }
}
