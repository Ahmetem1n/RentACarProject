﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {

        public CustomerValidator()
        {
            RuleFor(c => c.CustomerId).NotEmpty();
            RuleFor(c => c.UserId).NotEmpty();
            RuleFor(c => c.IdentityId).NotEmpty();
            RuleFor(c => c.DrivingId).NotEmpty();
            RuleFor(c => c.Address).NotEmpty();
        }
    }
}
