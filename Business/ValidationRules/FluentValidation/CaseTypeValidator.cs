using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CaseTypeValidator : AbstractValidator<CaseType>
    {

        public CaseTypeValidator()
        {
            RuleFor(c => c.CaseId).NotEmpty();
            RuleFor(c => c.CaseName).NotEmpty();
        }
    }
}
