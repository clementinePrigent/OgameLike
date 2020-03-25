using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO_OgameLike
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Validation : ValidationAttribute
    {
        protected override ValidationResult
              IsValid(object value, ValidationContext validationContext)
        {
            DateTime LastUpdate = Convert.ToDateTime(value);
            if (LastUpdate > DateTime.Now)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult
                    ("La date ne peut pas être inférieure à la date du jour.");
            }
        }







    }
}
