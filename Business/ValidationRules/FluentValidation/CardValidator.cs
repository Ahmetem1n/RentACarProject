using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CardValidator : AbstractValidator<Card>
    {

        public CardValidator()
        {
            RuleFor(c => c.UserId).NotEmpty();
            RuleFor(c => c.FullName).NotEmpty();
            RuleFor(c => c.CardNo).NotEmpty();
            RuleFor(c => c.ExpiryDate).NotEmpty();
            RuleFor(c => c.Cvv).NotEmpty();
        }
    }
}
