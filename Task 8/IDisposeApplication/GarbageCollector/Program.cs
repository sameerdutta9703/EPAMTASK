using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDisposeApplication;

namespace GarbageCollector
{
    class Program
    {
        static void MakeSomeGarbage()
        {
            Object obj;
            for (int i = 0; i < 100000; i++)
            {
                obj = new Object();
            }
        }

        static void Main(string[] args)
        {
            //Making some garbage
            Program.MakeSomeGarbage();
            Console.WriteLine("Memory used before collection : {0}", GC.GetTotalMemory(false));

            //Collecting the garbage
            GC.Collect();
            Console.WriteLine("Memory used after full collection : {0}", GC.GetTotalMemory(true));

            Console.ReadLine();
        }
    }
}
