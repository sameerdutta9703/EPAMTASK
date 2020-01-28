using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposeApplication
{
    class IDisposeImplementation : IDisposable
    {
        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {

            //To show that we are getting the functionality of the Dipose methord
            Console.WriteLine("In the Dispose Methord");
            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                Console.WriteLine("Cleaned all the Managed Code");
                //free the managed objects here;
            }

            Console.WriteLine("Cleaned all the Unmanaged Code");
            //free the unmanaged objects

            disposed = true;
            
            Console.ReadLine();
        }

        // The Deconstructor
        ~IDisposeImplementation()
        {
            Dispose(false);
        }


        static void Main(string[] args)
        {
            
            using (IDisposeImplementation obj = new IDisposeImplementation())
            {                
                //obj.Dispose();
            }
           
        }
    }
}
