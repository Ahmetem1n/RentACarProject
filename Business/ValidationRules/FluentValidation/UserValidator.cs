using Core.Entities.Concrete;
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
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.NationalityId).NotEmpty();
            RuleFor(u => u.BirthYear).NotEmpty();
            RuleFor(u => u.Photo).NotEmpty();
            RuleFor(u => u.Status).NotEmpty();
            RuleFor(u => u.PasswordHash).NotEmpty();
            RuleFor(u => u.PasswordSalt).NotEmpty();
        }
    }
}
