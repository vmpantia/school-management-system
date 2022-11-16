using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.Models
{
    public class Student : BaseModel
    {
        public System.Guid InternalID { get; set; }
        public string StudentID { get; set; }
        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(20)]
        public string LastName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string CivilStatus { get; set; }
        [Required]
        public System.DateTime BirthDate { get; set; }
        public int Status { get; set; }
        public System.DateTime LastUpdate { get; set; }
    }
}
