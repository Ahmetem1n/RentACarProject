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
            RuleFor(d => d.LicenceNumber).NotEmpty();
            RuleFor(d => d.ExpiryDate).NotEmpty();
            RuleFor(d => d.LicenceProvince).NotEmpty();
            RuleFor(d => d.BloodGroup).NotEmpty();
        }
    }
}
