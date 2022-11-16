using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Api.Models
{
    public class StudentRequest
    {
        public string FunctionID { get; set; }
        public ClientInformation inputClientInfo;
        public Student_MST inputStudent;
    }
}