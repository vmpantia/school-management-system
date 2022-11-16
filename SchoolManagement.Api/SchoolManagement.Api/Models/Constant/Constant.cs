using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Api.Models
{
    public class Constant
    {
        public const string NA = "N/A";
    }

    public class ErrorMessage
    {
        public const string REQUEST_NULL_MESSAGE = "Request can't be Null";
        public const string STUDENT_MST_NULL_MESSAGE = "Error in getting data in Student_MST";
        public const string TOKEN_NOT_VALID_MESSAGE = "You're Token is NOT Valid, You can't use this API";
        public const string FUNCTIONID_NOT_VALID_MESSAGE = "FunctionID of your transaction is NOT Valid";
    }

    public class RequestStatus
    {
        public const string Completed = "A2";
    }

    public class FunctionID
    {
        public const string NewStudent = "01A00";
    }

    public class ResponseMssage
    {
        public const string STUDENT_SAVE_SUCCESS_DETAILS = "Student Information is Successfully Saved";
    }
}