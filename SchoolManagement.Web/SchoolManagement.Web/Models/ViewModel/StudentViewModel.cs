using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Web.Models
{
    public class StudentViewModel
    {
        public ClientInformation ClientInfo { get; set; }
        public Student Student { get; set; } 
        public List<Student> StudentsList { get; set; }
        public Filter Filter { get; set; }
    }
}