using SchoolManagement.Api.Models;
using System;

namespace SchoolManagement.Api.Services
{
    public interface ICommonService
    {
        bool IsTokenValid(ClientInformation inputClientInfo);
    }
}