using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Web.Models
{
    public class Student
    {
        public System.Guid InternalID { get; set; }
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
        public System.DateTime BirthDate { get; set; }
        public int Status { get; set; }
        public System.DateTime LastUpdate { get; set; }
    }
}