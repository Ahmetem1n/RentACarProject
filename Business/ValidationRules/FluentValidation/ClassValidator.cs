using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ClassValidator : AbstractValidator<Class>
    {

        public ClassValidator()
        {
            RuleFor(c => c.ClassId).NotEmpty();
            
        }
    }
}
