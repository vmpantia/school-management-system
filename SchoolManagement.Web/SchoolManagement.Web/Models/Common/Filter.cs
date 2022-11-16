using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Web.Models
{
    public class Filter
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public int PageSize { get; set; }
        public int PageNo { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
    }
}