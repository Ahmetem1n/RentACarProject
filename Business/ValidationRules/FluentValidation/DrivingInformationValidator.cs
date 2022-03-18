using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class DrivingInformationValidator : AbstractValidator<DrivingInformation>
    {

        public DrivingInformationValidator()
        {
            RuleFor(d => d.DrivingId).NotEmpty();
        }
    }
}
