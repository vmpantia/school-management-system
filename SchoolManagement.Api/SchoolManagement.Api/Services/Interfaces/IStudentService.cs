using SchoolManagement.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManagement.Api.Services
{
    public interface IStudentService
    {
        Task<List<Student_MST>> GetStudentsAsync(Filter filter);
        Task<SuccessResponse> SaveStudentAsync(StudentRequest request);
    }
}