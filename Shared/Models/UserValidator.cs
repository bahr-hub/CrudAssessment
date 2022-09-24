using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudAssessment.Shared.Models
{
    public class UserValidator : AbstractValidator<UserInfo>
    {
        public UserValidator()
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(user => user.UserName).NotEmpty().WithMessage("User name is a required field.")
                .Length(3, 50).WithMessage("First name must be between 3 and 50 characters.");

            RuleFor(user => user.PhoneNumber).NotEmpty().WithMessage("Phone Number is a required field.")
                .Length(3, 50).WithMessage("Last name must be between 3 and 50 characters.");

            RuleFor(user => user.Email).NotEmpty().WithMessage("Email Address is a required field.")
                .EmailAddress().WithMessage("A valid email is required");

            RuleFor(user => user.Password).NotEmpty().WithMessage("Password is a required field.")
                .Length(6, 50).WithMessage("Password must be between 6 and 50 characters.");
        }
    }
}
