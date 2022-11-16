using SchoolManagement.Api.Models;
using SchoolManagement.Api.Services;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SchoolManagement.Api.Controllers
{
    public class StudentController : ApiController
    {
        IStudentService _studentService;
        ICommonService _commonService;
        public StudentController()
        {
            _studentService = new StudentService();
            _commonService = new CommonService();
        }

        [HttpPost]
        [Route("GetStudents")]
        public async Task<IHttpActionResult> GetStudents(FilterRequest request)
        {
            try
            {
                if (request == null)
                {
                    throw new Exception(ErrorMessage.REQUEST_NULL_MESSAGE);
                }

                //Check if the user token is still valid
                var isTokenValid = _commonService.IsTokenValid(request.inputClientInfo);
                if(!isTokenValid)
                {
                    throw new Exception(ErrorMessage.TOKEN_NOT_VALID_MESSAGE);
                }

                //Get list of Students by Filter
                var result = await _studentService.GetStudentsAsync(request.inputFilter);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("SaveStudent")]
        public async Task<IHttpActionResult> SaveStudent(StudentRequest request)
        {
            try
            {
                if (request == null)
                {
                    throw new Exception(ErrorMessage.REQUEST_NULL_MESSAGE);
                }

                //Check if the user token is still valid
                var isTokenValid = _commonService.IsTokenValid(request.inputClientInfo);
                if (!isTokenValid)
                {
                    throw new Exception(ErrorMessage.TOKEN_NOT_VALID_MESSAGE);
                }

                //Save Student Information
                var result = await _studentService.SaveStudentAsync(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}