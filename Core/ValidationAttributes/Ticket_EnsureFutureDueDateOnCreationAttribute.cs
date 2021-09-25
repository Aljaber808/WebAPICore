using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Core.Models;

namespace Core.ValidationAttributes
{
    class Ticket_EnsureFutureDueDateOnCreationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ticket =  validationContext.ObjectInstance as Ticket;
            if (!ticket.ValidateFutureDueDate())
                return new ValidationResult("DueDate has to be in the future");
            return ValidationResult.Success;
        }
    }
}
