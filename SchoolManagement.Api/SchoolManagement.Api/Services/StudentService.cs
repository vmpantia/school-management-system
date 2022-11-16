using SchoolManagement.Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement.Api.Services
{
    public class StudentService : IStudentService
    {
        private SMEntities _db;

        public StudentService()
        {
            _db = new SMEntities();
        }

        public async Task<List<Student_MST>> GetStudentsAsync(Filter filter)
        {
            var result = _db.Student_MST.ToListAsync();

            if (result == null)
            {
                throw new Exception(ErrorMessage.STUDENT_MST_NULL_MESSAGE);
            }

            return await result;
        }

        public async Task<SuccessResponse> SaveStudentAsync(StudentRequest request)
        {
            using(var transaction = _db.Database.BeginTransaction())
            {
                var requestID = _db.GetNewRequestID().ToList().FirstOrDefault();
                switch (request.FunctionID)
                {
                    case FunctionID.NewStudent:
                        request.inputStudent.StudentID = _db.GetNewStudentID().ToList().FirstOrDefault();
                        request.inputStudent.InternalID = Guid.NewGuid();
                        InsertRequest_LST(requestID, request.inputClientInfo.UserID,
                                          request.FunctionID, RequestStatus.Completed);
                        InsertStudent_TRN(requestID, request.inputStudent);
                        InsertStudent_MST(request.inputStudent);
                        break;


                    default:
                        throw new Exception(ErrorMessage.FUNCTIONID_NOT_VALID_MESSAGE);
                }

                await _db.SaveChangesAsync();
                transaction.Commit();

                return new SuccessResponse { RequestID = requestID,
                                             Message =  ResponseMssage.STUDENT_SAVE_SUCCESS_DETAILS};
            }
        }

        private void InsertRequest_LST(string RequestID, Guid UserID, string FunctionID, string RequestStatus)
        {
            var newRequest = new Request_LST
            {
                RequestID = RequestID,
                FunctionID = FunctionID,
                Status = RequestStatus,
                CreatedBy = UserID,
                CreatedDate = DateTime.Now,
                ModifiedBy = null,
                ModifiedDate = null,
                ApprovedDate = null,
                ApprovedBy = null,
                LastUpdate = DateTime.Now
            };

            _db.Request_LST.Add(newRequest);
        }
        private void InsertStudent_TRN(string RequestID, Student_MST student)
        {
            var newStudentTRN = new Student_TRN
            {
                RequestID = RequestID,
                InternalID = student.InternalID,
                StudentID = student.StudentID,
                FirstName = student.FirstName,
                MiddleName = student.MiddleName,
                LastName = student.LastName,
                Gender = student.Gender,
                CivilStatus = student.CivilStatus,
                BirthDate = student.BirthDate,
                Status = student.Status,
                LastUpdate = student.LastUpdate
            };

            _db.Student_TRN.Add(newStudentTRN);
        }
        private void InsertStudent_MST(Student_MST student)
        {
            _db.Student_MST.Add(student);
        }
    }
}