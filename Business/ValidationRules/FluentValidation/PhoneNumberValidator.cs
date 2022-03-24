using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class PhoneNumberValidator : AbstractValidator<PhoneNumber>
    {

        public PhoneNumberValidator()
        {
            RuleFor(p => p.UserId).NotEmpty();
            RuleFor(p => p.PhoneNo).NotEmpty();
        }
    }
}
