using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class IdentityInformationValidator : AbstractValidator<IdentityInformation>
    {

        public IdentityInformationValidator()
        {
            RuleFor(ı => ı.IdentityId).NotEmpty();
            RuleFor(ı => ı.SerialNumber).NotEmpty();
            RuleFor(ı => ı.FatherName).NotEmpty();
            RuleFor(ı => ı.MotherName).NotEmpty();
            RuleFor(ı => ı.BirthPlace).NotEmpty();
            RuleFor(ı => ı.BirthYear).NotEmpty();
            RuleFor(ı => ı.MaritalStatus).NotEmpty();
            RuleFor(ı => ı.Gender).NotEmpty();
            RuleFor(ı => ı.ValidUntil).NotEmpty();
        }
    }
}
