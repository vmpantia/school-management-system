//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement.Api.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_TRN
    {
        public string RequestID { get; set; }
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
