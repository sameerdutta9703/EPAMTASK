using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class MyGenericType<T>
    {
        public T data;

        //using properties
        public T value
        {
            //using the accessors 

            //The get methord
            get
            {
                return this.data;
            }
            //The set methord
            set
            {
                this.data = value;
            }
        }
    }
}
