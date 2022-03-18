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
            
        }
    }
}
