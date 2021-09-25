using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace Core.ValidationAttributes
{
    class Ticket_EnsureReportDatePresentAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket =  validationContext.ObjectInstance as Ticket;
            if (!ticket.ValidateReportDatePresence())
                return new ValidationResult("ReportDate is Required.");
            return ValidationResult.Success;
        }
    }
}
