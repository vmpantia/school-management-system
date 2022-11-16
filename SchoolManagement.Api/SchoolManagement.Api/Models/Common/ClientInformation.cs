using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Api.Models
{
    public class ClientInformation
    {
        public Guid UserID { get; set; }
        public Guid Token { get; set; }
        public string IPAddress { get; set; }
        public string OperationSystem { get; set; }
    }
}