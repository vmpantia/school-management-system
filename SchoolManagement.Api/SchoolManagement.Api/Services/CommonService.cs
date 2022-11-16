using SchoolManagement.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Api.Services
{
    public class CommonService : ICommonService
    {
        public bool IsTokenValid(ClientInformation inputClientInfo)
        {
            return true;
        }
    }
}