using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserRoleValidator : AbstractValidator<UserRole>
    {

        public UserRoleValidator()
        {
            RuleFor(u => u.RoleId).NotEmpty();
        }
    }
}
