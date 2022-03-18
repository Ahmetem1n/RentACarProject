using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class BranchValidator : AbstractValidator<Branch>
    {

        public BranchValidator()
        {
            RuleFor(b => b.BranchId).NotEmpty();
            RuleFor(b => b.CityId).NotEmpty();
            RuleFor(b => b.BranchName).NotEmpty();
        }
    }
}
