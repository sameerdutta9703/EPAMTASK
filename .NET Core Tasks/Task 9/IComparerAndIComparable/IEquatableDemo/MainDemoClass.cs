using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatableDemo
{
    class MainDemoClass
    {
        static void Main(string[] args)
        {
            StudentIEquat stud = new StudentIEquat { FirstName = "Mayang", LastName = "Agarwalla" };
            StudentIEquat stud1 = new StudentIEquat { FirstName = "Apurv", LastName = "Prakash" };

            List<StudentIEquat> student = new List<StudentIEquat> { stud, stud1 };
            // Add a Student to the List.  

            // Make the new Student.  
            StudentIEquat studnew = new StudentIEquat { FirstName = "Mayang", LastName = "Agarwalla" };

            if (student.Contains(studnew))
            {
                Console.WriteLine("The list contains this Student.");
            }

            Console.ReadLine();

        }
    }

    class StudentIEquat : IEquatable<StudentIEquat>
    {
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public bool Equals(StudentIEquat other)
        {
            return ((FirstName == other.FirstName) && (LastName == other.LastName));
        }

    }

}
