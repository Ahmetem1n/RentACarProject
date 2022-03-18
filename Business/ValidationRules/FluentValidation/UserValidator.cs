using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {

        public UserValidator()
        {
            RuleFor(u => u.UserId).NotEmpty();
            RuleFor(u => u.RoleId).NotEmpty();
            RuleFor(u => u.UserFirstname).NotEmpty();
            RuleFor(u => u.UserLastname).NotEmpty();
            RuleFor(u => u.UserNationalityId).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.UserPhoto).NotEmpty();
        }
    }
}
