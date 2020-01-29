using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollectionsArrayList
{
    class CustomCollectionArrayListClass<Object> : Random, IComparable
    {
        //All the Data Members
        public Object[] elmentData;
        private int Tsize;
        private int count;

        //The Constructor for Initialisation
        public CustomCollectionArrayListClass()
        {
            Tsize = 4;
            count = 0;
        }

        //Initialization of the array
        private void init()
        {
            elmentData = new Object[Tsize];
        }

        //The Insert Methord
        public void add(Object a)
        {
            if (count == 0)
            {
                init();
            }
            if (count == Tsize)
            {
                Tsize *= 2;
                Array.Resize<Object>(ref elmentData, Tsize);
            }
            elmentData[count] = a;
            count++;
        }

        //Getting tthe object at the given Index
        public Object get(int a)
        {
            return elmentData[a];
        }

        //Finding the Capacity of the ArrayList
        public int capacity()
        {
            if (elmentData == null)
            {
                return 0;
            }
            else
                return Tsize;
        }

        //Finding that the given object uis contained in the ArrayList
        public bool contains(Object a)
        {
            for (int i = 0; i < count; i++)
            {
                if (a.Equals(elmentData[i]))
                {
                    return true;
                }
            }
            return false;
        }

        //Finding the position of the given element
        public int find(Object a)
        {
            for (int i = 0; i < count; i++)
            {
                if (a.Equals(elmentData[i]))
                {
                    return (i + 1);
                }
            }
            return -1;
        }

        //Sorting the given ArrayList

        //public void sort()
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        for (int j = 1; j < (count - i); j++)
        //        {
        //            if (elmentData[j - 1])
        //            {
        //                Object temp = elmentData[j - 1];
        //                elmentData[j - 1] = elmentData[j];
        //                elmentData[j] = temp;
        //            }
        //        }
        //    }

        //}

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        //Show methord to display the whole ArrayList
        public void show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(elmentData[i]);
            }
        }

        //Deleting the given Object
        public void delete(Object a)
        {
            if (count == 0)
            {
                throw new Exception("The ArrayList is Empty");
            }
            else
            {
                int indexAt = find(a)-1;

                if (indexAt == -1)
                {
                    throw new Exception("The Element is not present in the ArrayList");
                }
                else
                {
                    for (int i = indexAt; i < (count - 1); i++)
                    {
                        elmentData[i] = elmentData[i + 1];
                    }
                    count--;

                    Array.Copy(elmentData, 0, elmentData, 0, count);
                }
            }
        }

        //Returning the size or number of elements in the ArrayList
        public int size()
        {
            return count;
        }
        
    }
}
    
