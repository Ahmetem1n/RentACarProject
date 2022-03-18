﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalDetailValidator : AbstractValidator<RentalDetail>
    {

        public RentalDetailValidator()
        {
            RuleFor(r => r.RentalId).NotEmpty();
        }
    }
}