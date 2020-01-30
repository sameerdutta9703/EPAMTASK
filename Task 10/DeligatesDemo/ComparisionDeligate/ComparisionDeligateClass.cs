using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisionDeligate
{
    class ComparisionDeligateClass
    {
        //Declaration of the variables
        string stuName;
        string stuSchool;
        int stuRoll;

        //The constructor for initialization
        public ComparisionDeligateClass(string name, string school, int roll)
        {
            this.stuName = name;
            this.stuSchool = school;
            this.stuRoll = roll;
        }


        public string Name
        {
            get
            {
                return this.stuName;
            }
        }
        public string School
        {
            get
            {
                return this.stuSchool;
            }
        }
        public int Roll
        {
            get
            {
                return this.stuRoll;
            }
        }

        //Just for the name 
        public static int compareByName(ComparisionDeligateClass obj1, ComparisionDeligateClass obj2)
        {
            return String.Compare(obj1.Name, obj2.Name);
        }

        //For the combination of name and school
        public static int compareByNameAndSchool(ComparisionDeligateClass obj1, ComparisionDeligateClass obj2)
        {
            return String.Compare(obj1.School + obj1.Name, obj2.School + obj2.Name);
        }

        //For the roll number
        public static int compareByRoll(ComparisionDeligateClass obj1, ComparisionDeligateClass obj2)
        {
            return obj1.Roll.CompareTo(obj2.Roll);
        }


        //The Display Function for printing the array
        private static void DisplayArray(ComparisionDeligateClass[] student)
        {
            Console.WriteLine("{0,-20} {1,-25} {2,10}", "Name", "School", "Roll");
            foreach (var i in student)
                Console.WriteLine("{0,-20} {1,-25} {2,10:N0}", i.Name,
                                  i.School, i.Roll);
            Console.WriteLine("\n");
        }

        //The Main Function for this Class
        static void Main(string[] args)
        {
            ComparisionDeligateClass Sam = new ComparisionDeligateClass("Sameer", "NHES", 23);
            ComparisionDeligateClass Apu = new ComparisionDeligateClass("Apurv", "Loyala", 68);
            ComparisionDeligateClass Jay = new ComparisionDeligateClass("Jayaa", "Tagore", 18);

            ComparisionDeligateClass[] students = { Sam, Apu, Jay };

            //Displaying the ArrayList
            DisplayArray(students);

            //Sorting by the student name
            Array.Sort(students, ComparisionDeligateClass.compareByName);
            DisplayArray(students);

            //Sorting by the roll number
            Array.Sort(students, ComparisionDeligateClass.compareByRoll);
            DisplayArray(students);

            //Sorting the array by name + school
            Array.Sort(students, ComparisionDeligateClass.compareByNameAndSchool);
            DisplayArray(students);

            Console.ReadLine();
        }
    }
}
