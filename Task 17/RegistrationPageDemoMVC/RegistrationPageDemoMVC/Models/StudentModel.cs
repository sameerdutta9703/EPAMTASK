using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegistrationPageDemoMVC.Models
{
    public class StudentModel
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Password { get; set; }
        public int Mobile { get; set; }
        public String Email { get; set; }
        public String Country { get; set; }
        public bool Gender { get; set; }
        public String Stream { get; set; }
        public String Date { get; set; }

    }
}