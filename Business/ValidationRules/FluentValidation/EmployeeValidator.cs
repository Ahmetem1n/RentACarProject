using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {

        public EmployeeValidator()
        {
            RuleFor(e => e.EmployeeId).NotEmpty();
        }
    }
}
