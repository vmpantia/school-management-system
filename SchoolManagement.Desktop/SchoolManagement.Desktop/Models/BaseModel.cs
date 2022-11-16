using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.Models
{
    public class BaseModel : IDataErrorInfo
    {
        public string this[string propertyName]
        {
            get
            {
                var descriptor = TypeDescriptor.GetProperties(this)[propertyName];
                if(descriptor == null)
                {
                    return string.Empty;
                }

                var errors = new List<ValidationResult>();
                var validationContext = new ValidationContext(this, null, null)
                {
                    MemberName = propertyName,
                };

                if(!Validator.TryValidateProperty(descriptor?.GetValue(this),validationContext, errors))
                {
                    return errors.FirstOrDefault()?.ErrorMessage ?? string.Empty;
                }

                return string.Empty;
            }
        }


        public string Error
        {
            get
            {
                var errors = new List<ValidationResult>();
                var validationContext = new ValidationContext(this, null, null);
                if (!Validator.TryValidateObject(this, validationContext, errors, true))
                {
                    return string.Join(Environment.NewLine, errors);
                }

                return string.Empty;
            }
        }
    }
}
