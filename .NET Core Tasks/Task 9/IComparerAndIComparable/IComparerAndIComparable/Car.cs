using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerAndIComparable
{
    public class car : IComparable
    {

        private int year;
        private string make;

        public car(string Make, int Year)
        {
            make = Make;
            year = Year;
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        // Implement IComparable CompareTo to provide default sort order.
        int IComparable.CompareTo(object obj)
        {
            car c = (car)obj;
            return String.Compare(this.make, c.make);
        }

        // Method to return IComparer object for sort helper.
        public static IComparer sortYearAscending()
        {
            return (IComparer)new sortYearAscendingHelper();
        }

        private class sortYearAscendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                car c1 = (car)a;
                car c2 = (car)b;

                if (c1.year > c2.year)
                    return 1;

                if (c1.year < c2.year)
                    return -1;

                else
                    return 0;
            }
        }
    }
}
