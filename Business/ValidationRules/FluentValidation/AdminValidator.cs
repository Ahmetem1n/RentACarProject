using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class AdminValidator : AbstractValidator<Admin>
    {

        public AdminValidator()
        {
            RuleFor(a => a.UserId).NotEmpty();
        }
    }
}
